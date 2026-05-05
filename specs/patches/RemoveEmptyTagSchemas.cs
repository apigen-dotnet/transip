using System.Collections.Generic;
using System.Linq;
using Microsoft.OpenApi;
using Apigen.Generator;

/// <summary>
/// The TransIP OpenAPI spec declares ~52 empty schemas in components.schemas
/// (e.g. Whois, Domains, VPS, Backups, Actions). They have no properties,
/// no allOf/oneOf/anyOf, no enum, no items, and are never referenced by any
/// operation, request body, or response.
///
/// They function as documentation tag groupings, not data types. Generating
/// them produces empty C# classes that pollute the model namespace.
///
/// This patch removes them. If TransIP ever populates one of these schemas
/// upstream (or another schema gains a $ref to it), the patch becomes a no-op
/// for that name and the class is generated normally.
/// </summary>
public class RemoveEmptyTagSchemas : ISpecPatch
{
  public string Name => "Remove empty unreferenced tag schemas";

  public bool Apply(OpenApiDocument document)
  {
    if (document.Components?.Schemas == null) return false;

    HashSet<string> referenced = CollectAllReferences(document);

    List<string> toRemove = new();
    foreach (var kvp in document.Components.Schemas)
    {
      if (IsEffectivelyEmpty(kvp.Value) && !referenced.Contains(kvp.Key))
      {
        toRemove.Add(kvp.Key);
      }
    }

    foreach (string name in toRemove)
    {
      document.Components.Schemas.Remove(name);
    }

    if (toRemove.Count > 0)
    {
      System.Console.WriteLine($"    Removed {toRemove.Count} empty tag schema(s): {string.Join(", ", toRemove)}");
    }

    return toRemove.Count > 0;
  }

  /// <summary>
  /// A schema is "effectively empty" if it carries no structural information
  /// the generator can turn into useful C#: no properties, no composition,
  /// no enum, no array items, no type constraint.
  /// </summary>
  private static bool IsEffectivelyEmpty(IOpenApiSchema iSchema)
  {
    OpenApiSchema? schema = iSchema as OpenApiSchema
      ?? (iSchema as OpenApiSchemaReference)?.RecursiveTarget;
    if (schema == null) return false;

    bool hasProperties = schema.Properties != null && schema.Properties.Count > 0;
    bool hasComposition = (schema.AllOf?.Count > 0) || (schema.OneOf?.Count > 0) || (schema.AnyOf?.Count > 0);
    bool hasEnum = schema.Enum != null && schema.Enum.Count > 0;
    bool hasItems = schema.Items != null;
    bool hasType = schema.Type != null;
    bool hasAdditionalProps = schema.AdditionalProperties != null;

    return !hasProperties && !hasComposition && !hasEnum && !hasItems && !hasType && !hasAdditionalProps;
  }

  /// <summary>
  /// Walk the entire document and collect every schema name reached via $ref.
  /// </summary>
  private static HashSet<string> CollectAllReferences(OpenApiDocument document)
  {
    HashSet<string> refs = new();

    if (document.Components?.Schemas != null)
    {
      foreach (var iSchema in document.Components.Schemas.Values)
      {
        Walk(iSchema, refs);
      }
    }

    if (document.Paths != null)
    {
      foreach (var path in document.Paths.Values)
      {
        if (path.Operations == null) continue;
        foreach (var op in path.Operations.Values)
        {
          if (op.Parameters != null)
          {
            foreach (var p in op.Parameters)
            {
              if (p.Schema != null) Walk(p.Schema, refs);
            }
          }

          if (op.RequestBody?.Content != null)
          {
            foreach (var content in op.RequestBody.Content.Values)
            {
              if (content.Schema != null) Walk(content.Schema, refs);
            }
          }

          if (op.Responses != null)
          {
            foreach (var response in op.Responses.Values)
            {
              if (response.Content != null)
              {
                foreach (var content in response.Content.Values)
                {
                  if (content.Schema != null) Walk(content.Schema, refs);
                }
              }
            }
          }
        }
      }
    }

    return refs;
  }

  private static void Walk(IOpenApiSchema iSchema, HashSet<string> refs)
  {
    if (iSchema is OpenApiSchemaReference schemaRef)
    {
      string? id = schemaRef.Reference?.Id;
      if (!string.IsNullOrEmpty(id))
      {
        // Avoid infinite recursion on circular refs
        if (!refs.Add(id)) return;
      }
      // Walk the target too
      OpenApiSchema? target = schemaRef.RecursiveTarget;
      if (target != null) WalkConcrete(target, refs);
      return;
    }

    if (iSchema is OpenApiSchema concrete)
    {
      WalkConcrete(concrete, refs);
    }
  }

  private static void WalkConcrete(OpenApiSchema schema, HashSet<string> refs)
  {
    if (schema.Properties != null)
    {
      foreach (var prop in schema.Properties.Values)
        Walk(prop, refs);
    }

    if (schema.Items != null) Walk(schema.Items, refs);
    if (schema.AdditionalProperties != null) Walk(schema.AdditionalProperties, refs);

    if (schema.AllOf != null) foreach (var s in schema.AllOf) Walk(s, refs);
    if (schema.OneOf != null) foreach (var s in schema.OneOf) Walk(s, refs);
    if (schema.AnyOf != null) foreach (var s in schema.AnyOf) Walk(s, refs);
  }
}
