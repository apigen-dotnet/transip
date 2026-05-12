using System.Text.Json;
using System.Threading.Tasks;
using Apigen.TransIp.Models;

#nullable enable

namespace Apigen.TransIp.Client;

/// <summary>
/// Interface for HA-IP operations
/// </summary>
public partial interface IHaipClient
{
  /// <summary>
  /// List all HA-IPs
  /// Operation: GET /haips
  /// </summary>
  Task<JsonElement> ListAllHaipsAsync();

  /// <summary>
  /// Order a new HA-IP
  /// Operation: POST /haips
  /// </summary>
  Task OrderNewHaipAsync(Apigen.TransIp.Models.OrderNewHaipRequest orderNewHaipRequest);

  /// <summary>
  /// Cancel a HA-IP
  /// Operation: DELETE /haips/{haipName}
  /// </summary>
  Task DeleteAsync(string haipName, Apigen.TransIp.Models.CancelHaipRequest cancelHaipRequest);

  /// <summary>
  /// Get HA-IP info
  /// Operation: GET /haips/{haipName}
  /// </summary>
  Task<JsonElement> GetAsync(string haipName);

  /// <summary>
  /// Update a HA-IP
  /// Operation: PUT /haips/{haipName}
  /// </summary>
  Task UpdateAsync(string haipName, Apigen.TransIp.Models.UpdateHaipRequest updateHaipRequest);

  /// <summary>
  /// List all HA-IP certificates
  /// Operation: GET /haips/{haipName}/certificates
  /// </summary>
  Task<JsonElement> ListAllHaipCertificatesAsync(string haipName);

  /// <summary>
  /// Add LetsEncrypt certificate to HA-IP
  /// Operation: POST /haips/{haipName}/certificates
  /// </summary>
  Task AddLetsEncryptCertificateHaipAsync(string haipName, Apigen.TransIp.Models.AddLetsEncryptCertificateHaipRequest addLetsEncryptCertificateHaipRequest);

  /// <summary>
  /// Detach a certificate from this HA-IP
  /// Operation: DELETE /haips/{haipName}/certificates/{certificateId}
  /// </summary>
  Task DeleteAsync(string haipName, decimal certificateId);

  /// <summary>
  /// Detach all IPs from HA-IP
  /// Operation: DELETE /haips/{haipName}/ip-addresses
  /// </summary>
  Task DetachAllIpsHaipAsync(string haipName);

  /// <summary>
  /// List all IPs attached to a HA-IP
  /// Operation: GET /haips/{haipName}/ip-addresses
  /// </summary>
  Task<JsonElement> ListAllIpsAttachedHaipAsync(string haipName);

  /// <summary>
  /// Set HA-IP attached IP addresses
  /// Operation: PUT /haips/{haipName}/ip-addresses
  /// </summary>
  Task SetHaipAttachedIpAddressesAsync(string haipName, Apigen.TransIp.Models.SetHaipAttachedIpAddressesRequest setHaipAttachedIpAddressesRequest);

  /// <summary>
  /// List all HA-IP port configurations
  /// Operation: GET /haips/{haipName}/port-configurations
  /// </summary>
  Task<JsonElement> ListAllHaipPortConfigurationsAsync(string haipName);

  /// <summary>
  /// Create a port configuration
  /// Operation: POST /haips/{haipName}/port-configurations
  /// </summary>
  Task CreatePortConfigurationAsync(string haipName, Apigen.TransIp.Models.CreatePortConfigurationRequest createPortConfigurationRequest);

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
  Task UpdateAsync(string haipName, decimal portConfigurationId, Apigen.TransIp.Models.UpdatePortConfigurationRequest updatePortConfigurationRequest);

  /// <summary>
  /// Get a full status report for a HA-IP
  /// Operation: GET /haips/{haipName}/status-reports
  /// </summary>
  Task<JsonElement> GetFullStatusReportHaipAsync(string haipName);

}
