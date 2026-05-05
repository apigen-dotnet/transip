using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Transip.Models;

#nullable enable

namespace Apigen.Transip.Client;

/// <summary>
/// Interface for Colocations operations
/// </summary>
public interface IColocationsClient
{
  /// <summary>
  /// List all colocations
  /// Operation: GET /colocations
  /// </summary>
  Task<JsonElement> ListAllColocationsAsync();

  /// <summary>
  /// Get colocation
  /// Operation: GET /colocations/{colocationName}
  /// </summary>
  Task<JsonElement> GetAsync(string colocationName);

  /// <summary>
  /// List IP addresses for a colocation
  /// Operation: GET /colocations/{colocationName}/ip-addresses
  /// </summary>
  Task<JsonElement> ListIPAddressesForAColocationAsync(string colocationName);

  /// <summary>
  /// Create a new IP address for a colocation
  /// Operation: POST /colocations/{colocationName}/ip-addresses
  /// </summary>
  Task CreateANewIPAddressForAColocationAsync(string colocationName, Apigen.Transip.Models.CreateANewIPAddressForAColocationRequest createANewIPAddressForAColocationRequest);

  /// <summary>
  /// Delete an IP address
  /// Operation: DELETE /colocations/{colocationName}/ip-addresses/{ipAddress}
  /// </summary>
  Task DeleteAsync(string colocationName, string ipAddress);

  /// <summary>
  /// Get IP addresses for a colocation
  /// Operation: GET /colocations/{colocationName}/ip-addresses/{ipAddress}
  /// </summary>
  Task<JsonElement> GetAsync(string colocationName, string ipAddress);

  /// <summary>
  /// Set reverse DNS for an IP address
  /// Operation: PUT /colocations/{colocationName}/ip-addresses/{ipAddress}
  /// </summary>
  Task UpdateAsync(string colocationName, string ipAddress, Apigen.Transip.Models.SetReverseDnsForAnIPAddressRequest setReverseDnsForAnIPAddressRequest);

}
