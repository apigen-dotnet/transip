using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Apigen.TransIp.Models;

#nullable enable

namespace Apigen.TransIp.Client;

/// <summary>
/// Interface for Actions operations
/// </summary>
public partial interface IActionsClient
{
  /// <summary>
  /// List all actions
  /// Operation: GET /actions
  /// </summary>
  Task<JsonElement> ListAllActionsAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// Get action by uuid
  /// Operation: GET /actions/{uuid}
  /// </summary>
  Task<JsonElement> GetAsync(string uuid, CancellationToken cancellationToken = default);

  /// <summary>
  /// List all child actions for a parent action
  /// Operation: GET /actions/{uuid}/children
  /// </summary>
  Task<JsonElement> ListAllChildActionsParentActionAsync(string uuid, CancellationToken cancellationToken = default);

}
