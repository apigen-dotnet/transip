using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Transip.Models;

#nullable enable

namespace Apigen.Transip.Client;

/// <summary>
/// Interface for General operations
/// </summary>
public partial interface IGeneralClient
{
  /// <summary>
  /// API Test
  /// Operation: GET /api-test
  /// </summary>
  Task<JsonElement> ApiTestAsync();

  /// <summary>
  /// List available AvailabilityZones
  /// Operation: GET /availability-zones
  /// </summary>
  Task<JsonElement> ListAvailableAvailabilityZonesAsync();

  /// <summary>
  /// List all products
  /// Operation: GET /products
  /// </summary>
  Task<JsonElement> ListAllProductsAsync();

  /// <summary>
  /// List specifications for product
  /// Operation: GET /products/{productName}/elements
  /// </summary>
  Task<JsonElement> ListSpecificationsProductAsync(string productName);

}
