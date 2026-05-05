using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Transip.Models;

#nullable enable

namespace Apigen.Transip.Client;

/// <summary>
/// Interface for VPS operations
/// </summary>
public interface IVpsClient
{
  /// <summary>
  /// List all big storages
  /// Operation: GET /big-storages
  /// </summary>
  Task<JsonElement> ListAllBigStoragesAsync();

  /// <summary>
  /// Upgrade big storage
  /// Operation: POST /big-storages
  /// </summary>
  Task UpgradeBigStorageAsync(Apigen.Transip.Models.UpgradeBigStorageRequest upgradeBigStorageRequest);

  /// <summary>
  /// Cancel big storage
  /// Operation: DELETE /big-storages/{bigStorageIdentifier}
  /// </summary>
  Task DeleteAsync(string bigStorageIdentifier, Apigen.Transip.Models.CancelBigStorageRequest cancelBigStorageRequest);

  /// <summary>
  /// Get big storage by identifier
  /// Operation: GET /big-storages/{bigStorageIdentifier}
  /// </summary>
  Task<JsonElement> GetAsync(string bigStorageIdentifier);

  /// <summary>
  /// Update big storage
  /// Operation: PUT /big-storages/{bigStorageIdentifier}
  /// </summary>
  Task UpdateAsync(string bigStorageIdentifier, Apigen.Transip.Models.UpdateBigStorageRequest updateBigStorageRequest);

  /// <summary>
  /// List backups for a big storage
  /// Operation: GET /big-storages/{bigStorageIdentifier}/backups
  /// </summary>
  Task<JsonElement> ListBackupsForABigStorageAsync(string bigStorageIdentifier);

  /// <summary>
  /// Revert a big storage backup
  /// Operation: PATCH /big-storages/{bigStorageIdentifier}/backups/{backupId}
  /// </summary>
  Task RevertABigStorageBackupAsync(string bigStorageIdentifier, decimal backupId, Apigen.Transip.Models.RevertABigStorageBackupRequest revertABigStorageBackupRequest);

  /// <summary>
  /// Get big storage usage statistics
  /// Operation: GET /big-storages/{bigStorageIdentifier}/usage
  /// </summary>
  Task<JsonElement> GetBigStorageUsageStatisticsAsync(string bigStorageIdentifier, Apigen.Transip.Models.GetBigStorageUsageStatisticsRequest getBigStorageUsageStatisticsRequest);

  /// <summary>
  /// List all block storages
  /// Operation: GET /block-storages
  /// </summary>
  Task<JsonElement> ListAllBlockStoragesAsync();

  /// <summary>
  /// Upgrade block storage
  /// Operation: POST /block-storages
  /// </summary>
  Task UpgradeBlockStorageAsync(Apigen.Transip.Models.UpgradeBlockStorageRequest upgradeBlockStorageRequest);

  /// <summary>
  /// Cancel block storage
  /// Operation: DELETE /block-storages/{blockStorageIdentifier}
  /// </summary>
  Task DeleteAsync(string blockStorageIdentifier, Apigen.Transip.Models.CancelBlockStorageRequest cancelBlockStorageRequest);

  /// <summary>
  /// Get block storage by identifier
  /// Operation: GET /block-storages/{blockStorageIdentifier}
  /// </summary>
  Task<JsonElement> GetBlockStoragesAsync(string blockStorageIdentifier);

  /// <summary>
  /// Update block storage
  /// Operation: PUT /block-storages/{blockStorageIdentifier}
  /// </summary>
  Task UpdateAsync(string blockStorageIdentifier, Apigen.Transip.Models.UpdateBlockStorageRequest updateBlockStorageRequest);

  /// <summary>
  /// List backups for a block storage
  /// Operation: GET /block-storages/{blockStorageIdentifier}/backups
  /// </summary>
  Task<JsonElement> ListBackupsForABlockStorageAsync(string blockStorageIdentifier);

  /// <summary>
  /// Revert a block storage backup
  /// Operation: PATCH /block-storages/{blockStorageIdentifier}/backups/{backupId}
  /// </summary>
  Task RevertABlockStorageBackupAsync(string blockStorageIdentifier, decimal backupId, Apigen.Transip.Models.RevertABlockStorageBackupRequest revertABlockStorageBackupRequest);

  /// <summary>
  /// Get block storage usage statistics
  /// Operation: GET /block-storages/{blockStorageIdentifier}/usage
  /// </summary>
  Task<JsonElement> GetBlockStorageUsageStatisticsAsync(string blockStorageIdentifier, Apigen.Transip.Models.GetBlockStorageUsageStatisticsRequest getBlockStorageUsageStatisticsRequest);

  /// <summary>
  /// Get mail service information
  /// Operation: GET /mail-service
  /// </summary>
  Task<JsonElement> GetMailServiceInformationAsync();

  /// <summary>
  /// Regenerate mail service password
  /// Operation: PATCH /mail-service
  /// </summary>
  Task RegenerateMailServicePasswordAsync();

  /// <summary>
  /// Add mail service DNS entries to domains
  /// Operation: POST /mail-service
  /// </summary>
  Task AddMailServiceDnsEntriesToDomainsAsync(Apigen.Transip.Models.AddMailServiceDnsEntriesToDomainsRequest addMailServiceDnsEntriesToDomainsRequest);

  /// <summary>
  /// List all contacts
  /// Operation: GET /monitoring-contacts
  /// </summary>
  Task<JsonElement> ListAllContactsAsync();

  /// <summary>
  /// Create a contact
  /// Operation: POST /monitoring-contacts
  /// </summary>
  Task CreateAContactAsync(Apigen.Transip.Models.CreateAContactRequest createAContactRequest);

  /// <summary>
  /// Delete a contact
  /// Operation: DELETE /monitoring-contacts/{contactId}
  /// </summary>
  Task DeleteAsync(decimal contactId);

  /// <summary>
  /// Update a contact
  /// Operation: PUT /monitoring-contacts/{contactId}
  /// </summary>
  Task UpdateAsync(decimal contactId, Apigen.Transip.Models.UpdateAContactRequest updateAContactRequest);

  /// <summary>
  /// Filter Operating Systems on specifications
  /// Operation: GET /operating-systems
  /// </summary>
  Task<JsonElement> FilterOperatingSystemsOnSpecificationsAsync(Apigen.Transip.Models.FilterOperatingSystemsOnSpecificationsRequest filterOperatingSystemsOnSpecificationsRequest);

  /// <summary>
  /// List all private networks
  /// Operation: GET /private-networks
  /// </summary>
  Task<JsonElement> ListAllPrivateNetworksAsync();

  /// <summary>
  /// Order a new private network
  /// Operation: POST /private-networks
  /// </summary>
  Task OrderANewPrivateNetworkAsync(Apigen.Transip.Models.OrderANewPrivateNetworkRequest orderANewPrivateNetworkRequest);

  /// <summary>
  /// Cancel a private network
  /// Operation: DELETE /private-networks/{privateNetworkName}
  /// </summary>
  Task DeleteAsync(string privateNetworkName, Apigen.Transip.Models.CancelAPrivateNetworkRequest cancelAPrivateNetworkRequest);

  /// <summary>
  /// Get private network by name
  /// Operation: GET /private-networks/{privateNetworkName}
  /// </summary>
  Task<JsonElement> GetPrivateNetworksAsync(string privateNetworkName);

  /// <summary>
  /// Detach vps from privateNetwork
  /// Operation: PATCH /private-networks/{privateNetworkName}
  /// </summary>
  Task DetachVpsFromPrivateNetworkAsync(string privateNetworkName, Apigen.Transip.Models.DetachVpsFromPrivateNetworkRequest detachVpsFromPrivateNetworkRequest);

  /// <summary>
  /// Update private network
  /// Operation: PUT /private-networks/{privateNetworkName}
  /// </summary>
  Task UpdateAsync(string privateNetworkName, Apigen.Transip.Models.UpdatePrivateNetworkRequest updatePrivateNetworkRequest);

  /// <summary>
  /// Get traffic pool information
  /// Operation: GET /traffic-pool
  /// </summary>
  Task<JsonElement> GetTrafficPoolInformationAsync();

  /// <summary>
  /// Get traffic information for a VPS
  /// Operation: GET /traffic-pool/{vpsName}
  /// </summary>
  Task<JsonElement> GetTrafficPoolAsync(string vpsName);

  /// <summary>
  /// List all VPSs
  /// Operation: GET /vps
  /// </summary>
  Task<JsonElement> ListAllVPSsAsync();

  /// <summary>
  /// Clone a VPS
  /// Operation: POST /vps
  /// </summary>
  Task CloneAVpsAsync(Apigen.Transip.Models.CloneAVpsRequest cloneAVpsRequest);

  /// <summary>
  /// Cancel a VPS
  /// Operation: DELETE /vps/{vpsIdentifier}
  /// </summary>
  Task DeleteAsync(string vpsIdentifier, Apigen.Transip.Models.CancelAVpsRequest cancelAVpsRequest);

  /// <summary>
  /// Get VPS by identifier
  /// Operation: GET /vps/{vpsIdentifier}
  /// </summary>
  Task<JsonElement> GetVpsAsync(string vpsIdentifier);

  /// <summary>
  /// Handover a VPS
  /// Operation: PATCH /vps/{vpsIdentifier}
  /// </summary>
  Task HandoverAVpsAsync(string vpsIdentifier, Apigen.Transip.Models.HandoverAVpsRequest handoverAVpsRequest);

  /// <summary>
  /// Update a VPS
  /// Operation: PUT /vps/{vpsIdentifier}
  /// </summary>
  Task UpdateAsync(string vpsIdentifier, Apigen.Transip.Models.UpdateAVpsRequest updateAVpsRequest);

  /// <summary>
  /// List addons for a VPS
  /// Operation: GET /vps/{vpsIdentifier}/addons
  /// </summary>
  Task<JsonElement> ListAddonsForAVpsAsync(string vpsIdentifier);

  /// <summary>
  /// Order addons for a VPS
  /// Operation: POST /vps/{vpsIdentifier}/addons
  /// </summary>
  Task OrderAddonsForAVpsAsync(string vpsIdentifier, Apigen.Transip.Models.OrderAddonsForAVpsRequest orderAddonsForAVpsRequest);

  /// <summary>
  /// Cancel an addon for a VPS
  /// Operation: DELETE /vps/{vpsIdentifier}/addons/{addonName}
  /// </summary>
  Task DeleteAsync(string vpsIdentifier, string addonName);

  /// <summary>
  /// List backups for a VPS
  /// Operation: GET /vps/{vpsIdentifier}/backups
  /// </summary>
  Task<JsonElement> ListBackupsForAVpsAsync(string vpsIdentifier);

  /// <summary>
  /// Convert backup to snapshot
  /// Operation: PATCH /vps/{vpsIdentifier}/backups/{backupId}
  /// </summary>
  Task ConvertBackupToSnapshotAsync(string vpsIdentifier, decimal backupId, Apigen.Transip.Models.ConvertBackupToSnapshotRequest convertBackupToSnapshotRequest);

  /// <summary>
  /// List firewall for a VPS
  /// Operation: GET /vps/{vpsIdentifier}/firewall
  /// </summary>
  Task<JsonElement> ListFirewallForAVpsAsync(string vpsIdentifier);

  /// <summary>
  /// Reset firewall for a VPS
  /// Operation: PATCH /vps/{vpsIdentifier}/firewall
  /// </summary>
  Task ResetFirewallForAVpsAsync(string vpsIdentifier, Apigen.Transip.Models.ResetFirewallForAVpsRequest resetFirewallForAVpsRequest);

  /// <summary>
  /// Update firewall for a VPS
  /// Operation: PUT /vps/{vpsIdentifier}/firewall
  /// </summary>
  Task UpdateFirewallForAVpsAsync(string vpsIdentifier, Apigen.Transip.Models.UpdateFirewallForAVpsRequest updateFirewallForAVpsRequest);

  /// <summary>
  /// List IP addresses for a VPS
  /// Operation: GET /vps/{vpsIdentifier}/ip-addresses
  /// </summary>
  Task<JsonElement> ListIPAddressesForAVpsAsync(string vpsIdentifier);

  /// <summary>
  /// Add IPv6 address to a VPS
  /// Operation: POST /vps/{vpsIdentifier}/ip-addresses
  /// </summary>
  Task AddIPv6AddressToAVpsAsync(string vpsIdentifier, Apigen.Transip.Models.AddIPv6AddressToAVpsRequest addIPv6AddressToAVpsRequest);

  /// <summary>
  /// Remove an IPv6 address from a VPS
  /// Operation: DELETE /vps/{vpsIdentifier}/ip-addresses/{ipAddress}
  /// </summary>
  Task DeleteVpsIpAddressesAsync(string vpsIdentifier, string ipAddress);

  /// <summary>
  /// Get IP address info by address
  /// Operation: GET /vps/{vpsIdentifier}/ip-addresses/{ipAddress}
  /// </summary>
  Task<JsonElement> GetAsync(string vpsIdentifier, string ipAddress);

  /// <summary>
  /// Update reverse DNS for a VPS
  /// Operation: PUT /vps/{vpsIdentifier}/ip-addresses/{ipAddress}
  /// </summary>
  Task UpdateAsync(string vpsIdentifier, string ipAddress, Apigen.Transip.Models.UpdateReverseDnsForAVpsRequest updateReverseDnsForAVpsRequest);

  /// <summary>
  /// List licenses for a VPS
  /// Operation: GET /vps/{vpsIdentifier}/licenses
  /// </summary>
  Task<JsonElement> ListLicensesForAVpsAsync(string vpsIdentifier);

  /// <summary>
  /// Order an addon license
  /// Operation: POST /vps/{vpsIdentifier}/licenses
  /// </summary>
  Task OrderAnAddonLicenseAsync(string vpsIdentifier, Apigen.Transip.Models.OrderAnAddonLicenseRequest orderAnAddonLicenseRequest);

  /// <summary>
  /// Cancel an addon license
  /// Operation: DELETE /vps/{vpsIdentifier}/licenses/{licenseId}
  /// </summary>
  Task DeleteVpsLicensesAsync(string vpsIdentifier, string licenseId);

  /// <summary>
  /// Update an operating system license
  /// Operation: PUT /vps/{vpsIdentifier}/licenses/{licenseId}
  /// </summary>
  Task UpdateAsync(string vpsIdentifier, string licenseId, Apigen.Transip.Models.UpdateAnOperatingSystemLicenseRequest updateAnOperatingSystemLicenseRequest);

  /// <summary>
  /// List installable operating systems for a VPS
  /// Operation: GET /vps/{vpsIdentifier}/operating-systems
  /// </summary>
  Task<JsonElement> ListInstallableOperatingSystemsForAVpsAsync(string vpsIdentifier);

  /// <summary>
  /// Install an operating system on a VPS
  /// Operation: POST /vps/{vpsIdentifier}/operating-systems
  /// </summary>
  Task InstallAnOperatingSystemOnAVpsAsync(string vpsIdentifier, Apigen.Transip.Models.InstallAnOperatingSystemOnAVpsRequest installAnOperatingSystemOnAVpsRequest);

  /// <summary>
  /// Get Rescue Images for your VPS
  /// Operation: GET /vps/{vpsIdentifier}/rescue-images
  /// </summary>
  Task<JsonElement> GetRescueImagesForYourVpsAsync(string vpsIdentifier);

  /// <summary>
  /// Boot Rescue Image for a VPS
  /// Operation: PATCH /vps/{vpsIdentifier}/rescue-images
  /// </summary>
  Task BootRescueImageForAVpsAsync(string vpsIdentifier, Apigen.Transip.Models.BootRescueImageForAVpsRequest bootRescueImageForAVpsRequest);

  /// <summary>
  /// List All Settings for a VPS
  /// Operation: GET /vps/{vpsIdentifier}/settings
  /// </summary>
  Task<JsonElement> ListAllSettingsForAVpsAsync(string vpsIdentifier);

  /// <summary>
  /// Get VPS Setting Information
  /// Operation: GET /vps/{vpsIdentifier}/settings/{setting}
  /// </summary>
  Task<JsonElement> GetVpsSettingsAsync(string vpsIdentifier, string setting);

  /// <summary>
  /// Update a setting for the specified VPS
  /// Operation: PUT /vps/{vpsIdentifier}/settings/{setting}
  /// </summary>
  Task UpdateAsync(string vpsIdentifier, string setting, Apigen.Transip.Models.UpdateASettingForTheSpecifiedVpsRequest updateASettingForTheSpecifiedVpsRequest);

  /// <summary>
  /// List snapshots for a VPS
  /// Operation: GET /vps/{vpsIdentifier}/snapshots
  /// </summary>
  Task<JsonElement> ListSnapshotsForAVpsAsync(string vpsIdentifier);

  /// <summary>
  /// Create snapshot of a VPS
  /// Operation: POST /vps/{vpsIdentifier}/snapshots
  /// </summary>
  Task CreateSnapshotOfAVpsAsync(string vpsIdentifier, Apigen.Transip.Models.CreateSnapshotOfAVpsRequest createSnapshotOfAVpsRequest);

  /// <summary>
  /// Delete a snapshot
  /// Operation: DELETE /vps/{vpsIdentifier}/snapshots/{snapshotName}
  /// </summary>
  Task DeleteVpsSnapshotsAsync(string vpsIdentifier, string snapshotName);

  /// <summary>
  /// Get snapshot by name
  /// Operation: GET /vps/{vpsIdentifier}/snapshots/{snapshotName}
  /// </summary>
  Task<JsonElement> GetVpsSnapshotsAsync(string vpsIdentifier, string snapshotName);

  /// <summary>
  /// Revert snapshot to a VPS
  /// Operation: PATCH /vps/{vpsIdentifier}/snapshots/{snapshotName}
  /// </summary>
  Task RevertSnapshotToAVpsAsync(string vpsIdentifier, string snapshotName, Apigen.Transip.Models.RevertSnapshotToAVpsRequest revertSnapshotToAVpsRequest);

  /// <summary>
  /// List all TCP monitors for a VPS
  /// Operation: GET /vps/{vpsIdentifier}/tcp-monitors
  /// </summary>
  Task<JsonElement> ListAllTcpMonitorsForAVpsAsync(string vpsIdentifier);

  /// <summary>
  /// Create a TCP monitor for a VPS
  /// Operation: POST /vps/{vpsIdentifier}/tcp-monitors
  /// </summary>
  Task CreateATcpMonitorForAVpsAsync(string vpsIdentifier, Apigen.Transip.Models.CreateATcpMonitorForAVpsRequest createATcpMonitorForAVpsRequest);

  /// <summary>
  /// Delete a TCP monitor for a VPS
  /// Operation: DELETE /vps/{vpsIdentifier}/tcp-monitors/{ipAddress}
  /// </summary>
  Task DeleteVpsTcpMonitorsAsync(string vpsIdentifier, string ipAddress);

  /// <summary>
  /// Update a TCP monitor for a VPS
  /// Operation: PUT /vps/{vpsIdentifier}/tcp-monitors/{ipAddress}
  /// </summary>
  Task UpdateAsync(string vpsIdentifier, string ipAddress, Apigen.Transip.Models.UpdateATcpMonitorForAVpsRequest updateATcpMonitorForAVpsRequest);

  /// <summary>
  /// List available upgrades for a VPS
  /// Operation: GET /vps/{vpsIdentifier}/upgrades
  /// </summary>
  Task<JsonElement> ListAvailableUpgradesForAVpsAsync(string vpsIdentifier);

  /// <summary>
  /// Upgrade a VPS
  /// Operation: POST /vps/{vpsIdentifier}/upgrades
  /// </summary>
  Task UpgradeAVpsAsync(string vpsIdentifier, Apigen.Transip.Models.UpgradeAVpsRequest upgradeAVpsRequest);

  /// <summary>
  /// Get usage data for a VPS
  /// Operation: GET /vps/{vpsIdentifier}/usage
  /// </summary>
  Task<JsonElement> GetUsageDataForAVpsAsync(string vpsIdentifier, Apigen.Transip.Models.GetUsageDataForAVpsRequest getUsageDataForAVpsRequest);

  /// <summary>
  /// Get VNC data for a VPS
  /// Operation: GET /vps/{vpsIdentifier}/vnc-data
  /// </summary>
  Task<JsonElement> GetVncDataForAVpsAsync(string vpsIdentifier);

  /// <summary>
  /// Regenerate VNC token for a vps
  /// Operation: PATCH /vps/{vpsIdentifier}/vnc-data
  /// </summary>
  Task RegenerateVncTokenForAVpsAsync(string vpsIdentifier);

}
