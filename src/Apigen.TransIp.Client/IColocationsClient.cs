using System.Text.Json;
using System.Threading.Tasks;
using Apigen.TransIp.Models;

#nullable enable

namespace Apigen.TransIp.Client;

/// <summary>
/// Interface for Colocations operations
/// </summary>
public partial interface IColocationsClient
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
  Task<JsonElement> ListIpAddressesColocationAsync(string colocationName);

  /// <summary>
  /// Create a new IP address for a colocation
  /// Operation: POST /colocations/{colocationName}/ip-addresses
  /// </summary>
  Task CreateNewIpAddressColocationAsync(string colocationName, Apigen.TransIp.Models.CreateNewIpAddressColocationRequest createNewIpAddressColocationRequest);

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
  Task UpdateAsync(string colocationName, string ipAddress, Apigen.TransIp.Models.SetReverseDnsIpAddressRequest setReverseDnsIpAddressRequest);

}
