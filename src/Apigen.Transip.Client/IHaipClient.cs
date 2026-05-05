using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Transip.Models;

#nullable enable

namespace Apigen.Transip.Client;

/// <summary>
/// Interface for HA-IP operations
/// </summary>
public interface IHaipClient
{
  /// <summary>
  /// List all HA-IPs
  /// Operation: GET /haips
  /// </summary>
  Task<JsonElement> ListAllHaiPsAsync();

  /// <summary>
  /// Order a new HA-IP
  /// Operation: POST /haips
  /// </summary>
  Task OrderANewHaipAsync(Apigen.Transip.Models.OrderANewHAIPRequest orderANewHaipRequest);

  /// <summary>
  /// Cancel a HA-IP
  /// Operation: DELETE /haips/{haipName}
  /// </summary>
  Task DeleteAsync(string haipName, Apigen.Transip.Models.CancelAHAIPRequest cancelAhaipRequest);

  /// <summary>
  /// Get HA-IP info
  /// Operation: GET /haips/{haipName}
  /// </summary>
  Task<JsonElement> GetAsync(string haipName);

  /// <summary>
  /// Update a HA-IP
  /// Operation: PUT /haips/{haipName}
  /// </summary>
  Task UpdateAsync(string haipName, Apigen.Transip.Models.UpdateAHAIPRequest updateAhaipRequest);

  /// <summary>
  /// List all HA-IP certificates
  /// Operation: GET /haips/{haipName}/certificates
  /// </summary>
  Task<JsonElement> ListAllHaipCertificatesAsync(string haipName);

  /// <summary>
  /// Add LetsEncrypt certificate to HA-IP
  /// Operation: POST /haips/{haipName}/certificates
  /// </summary>
  Task AddLetsEncryptCertificateToHaipAsync(string haipName, Apigen.Transip.Models.AddLetsEncryptCertificateToHAIPRequest addLetsEncryptCertificateToHaipRequest);

  /// <summary>
  /// Detach a certificate from this HA-IP
  /// Operation: DELETE /haips/{haipName}/certificates/{certificateId}
  /// </summary>
  Task DeleteAsync(string haipName, decimal certificateId);

  /// <summary>
  /// Detach all IPs from HA-IP
  /// Operation: DELETE /haips/{haipName}/ip-addresses
  /// </summary>
  Task DetachAllIPsFromHaipAsync(string haipName);

  /// <summary>
  /// List all IPs attached to a HA-IP
  /// Operation: GET /haips/{haipName}/ip-addresses
  /// </summary>
  Task<JsonElement> ListAllIPsAttachedToAhaipAsync(string haipName);

  /// <summary>
  /// Set HA-IP attached IP addresses
  /// Operation: PUT /haips/{haipName}/ip-addresses
  /// </summary>
  Task SetHaipAttachedIPAddressesAsync(string haipName, Apigen.Transip.Models.SetHAIPAttachedIPAddressesRequest setHaipAttachedIPAddressesRequest);

  /// <summary>
  /// List all HA-IP port configurations
  /// Operation: GET /haips/{haipName}/port-configurations
  /// </summary>
  Task<JsonElement> ListAllHaipPortConfigurationsAsync(string haipName);

  /// <summary>
  /// Create a port configuration
  /// Operation: POST /haips/{haipName}/port-configurations
  /// </summary>
  Task CreateAPortConfigurationAsync(string haipName, Apigen.Transip.Models.CreateAPortConfigurationRequest createAPortConfigurationRequest);

  /// <summary>
  /// Remove port configuration
  /// Operation: DELETE /haips/{haipName}/port-configurations/{portConfigurationId}
  /// </summary>
  Task DeleteHaipsPortConfigurationsAsync(string haipName, decimal portConfigurationId);

  /// <summary>
  /// Get info about a specific PortConfiguration
  /// Operation: GET /haips/{haipName}/port-configurations/{portConfigurationId}
  /// </summary>
  Task<JsonElement> GetAsync(string haipName, decimal portConfigurationId);

  /// <summary>
  /// Update a port configuration
  /// Operation: PUT /haips/{haipName}/port-configurations/{portConfigurationId}
  /// </summary>
  Task UpdateAsync(string haipName, decimal portConfigurationId, Apigen.Transip.Models.UpdateAPortConfigurationRequest updateAPortConfigurationRequest);

  /// <summary>
  /// Get a full status report for a HA-IP
  /// Operation: GET /haips/{haipName}/status-reports
  /// </summary>
  Task<JsonElement> GetAFullStatusReportForAhaipAsync(string haipName);

}
