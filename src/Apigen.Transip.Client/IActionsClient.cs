using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Transip.Models;

#nullable enable

namespace Apigen.Transip.Client;

/// <summary>
/// Interface for Actions operations
/// </summary>
public interface IActionsClient
{
  /// <summary>
  /// List all actions
  /// Operation: GET /actions
  /// </summary>
  Task<JsonElement> ListAllActionsAsync();

  /// <summary>
  /// Get action by uuid
  /// Operation: GET /actions/{uuid}
  /// </summary>
  Task<JsonElement> GetAsync(string uuid);

  /// <summary>
  /// List all child actions for a parent action
  /// Operation: GET /actions/{uuid}/children
  /// </summary>
  Task<JsonElement> ListAllChildActionsForAParentActionAsync(string uuid);

}
