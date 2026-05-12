using System.Text.Json;
using System.Threading.Tasks;
using Apigen.TransIp.Models;

#nullable enable

namespace Apigen.TransIp.Client;

/// <summary>
/// Interface for VPS operations
/// </summary>
public partial interface IVpsClient
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
  Task UpgradeBigStorageAsync(Apigen.TransIp.Models.UpgradeBigStorageRequest upgradeBigStorageRequest);

  /// <summary>
  /// Cancel big storage
  /// Operation: DELETE /big-storages/{bigStorageIdentifier}
  /// </summary>
  Task DeleteAsync(string bigStorageIdentifier, Apigen.TransIp.Models.CancelBigStorageRequest cancelBigStorageRequest);

  /// <summary>
  /// Get big storage by identifier
  /// Operation: GET /big-storages/{bigStorageIdentifier}
  /// </summary>
  Task<JsonElement> GetAsync(string bigStorageIdentifier);

  /// <summary>
  /// Update big storage
  /// Operation: PUT /big-storages/{bigStorageIdentifier}
  /// </summary>
  Task UpdateAsync(string bigStorageIdentifier, Apigen.TransIp.Models.UpdateBigStorageRequest updateBigStorageRequest);

  /// <summary>
  /// List backups for a big storage
  /// Operation: GET /big-storages/{bigStorageIdentifier}/backups
  /// </summary>
  Task<JsonElement> ListBackupsBigStorageAsync(string bigStorageIdentifier);

  /// <summary>
  /// Revert a big storage backup
  /// Operation: PATCH /big-storages/{bigStorageIdentifier}/backups/{backupId}
  /// </summary>
  Task RevertBigStorageBackupAsync(string bigStorageIdentifier, decimal backupId, Apigen.TransIp.Models.RevertBigStorageBackupRequest revertBigStorageBackupRequest);

  /// <summary>
  /// Get big storage usage statistics
  /// Operation: GET /big-storages/{bigStorageIdentifier}/usage
  /// </summary>
  Task<JsonElement> GetBigStorageUsageStatisticsAsync(string bigStorageIdentifier, Apigen.TransIp.Models.GetBigStorageUsageStatisticsRequest getBigStorageUsageStatisticsRequest);

  /// <summary>
  /// List all block storages
  /// Operation: GET /block-storages
  /// </summary>
  Task<JsonElement> ListAllBlockStoragesAsync();

  /// <summary>
  /// Upgrade block storage
  /// Operation: POST /block-storages
  /// </summary>
  Task UpgradeBlockStorageAsync(Apigen.TransIp.Models.UpgradeBlockStorageRequest upgradeBlockStorageRequest);

  /// <summary>
  /// Cancel block storage
  /// Operation: DELETE /block-storages/{blockStorageIdentifier}
  /// </summary>
  Task DeleteAsync(string blockStorageIdentifier, Apigen.TransIp.Models.CancelBlockStorageRequest cancelBlockStorageRequest);

  /// <summary>
  /// Get block storage by identifier
  /// Operation: GET /block-storages/{blockStorageIdentifier}
  /// </summary>
  Task<JsonElement> GetBlockStoragesAsync(string blockStorageIdentifier);

  /// <summary>
  /// Update block storage
  /// Operation: PUT /block-storages/{blockStorageIdentifier}
  /// </summary>
  Task UpdateAsync(string blockStorageIdentifier, Apigen.TransIp.Models.UpdateBlockStorageRequest updateBlockStorageRequest);

  /// <summary>
  /// List backups for a block storage
  /// Operation: GET /block-storages/{blockStorageIdentifier}/backups
  /// </summary>
  Task<JsonElement> ListBackupsBlockStorageAsync(string blockStorageIdentifier);

  /// <summary>
  /// Revert a block storage backup
  /// Operation: PATCH /block-storages/{blockStorageIdentifier}/backups/{backupId}
  /// </summary>
  Task RevertBlockStorageBackupAsync(string blockStorageIdentifier, decimal backupId, Apigen.TransIp.Models.RevertBlockStorageBackupRequest revertBlockStorageBackupRequest);

  /// <summary>
  /// Get block storage usage statistics
  /// Operation: GET /block-storages/{blockStorageIdentifier}/usage
  /// </summary>
  Task<JsonElement> GetBlockStorageUsageStatisticsAsync(string blockStorageIdentifier, Apigen.TransIp.Models.GetBlockStorageUsageStatisticsRequest getBlockStorageUsageStatisticsRequest);

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
  Task AddMailServiceDnsEntriesDomainsAsync(Apigen.TransIp.Models.AddMailServiceDnsEntriesDomainsRequest addMailServiceDnsEntriesDomainsRequest);

  /// <summary>
  /// List all contacts
  /// Operation: GET /monitoring-contacts
  /// </summary>
  Task<JsonElement> ListAllContactsAsync();

  /// <summary>
  /// Create a contact
  /// Operation: POST /monitoring-contacts
  /// </summary>
  Task CreateContactAsync(Apigen.TransIp.Models.CreateContactRequest createContactRequest);

  /// <summary>
  /// Delete a contact
  /// Operation: DELETE /monitoring-contacts/{contactId}
  /// </summary>
  Task DeleteAsync(decimal contactId);

  /// <summary>
  /// Update a contact
  /// Operation: PUT /monitoring-contacts/{contactId}
  /// </summary>
  Task UpdateAsync(decimal contactId, Apigen.TransIp.Models.UpdateContactRequest updateContactRequest);

  /// <summary>
  /// Filter Operating Systems on specifications
  /// Operation: GET /operating-systems
  /// </summary>
  Task<JsonElement> FilterOperatingSystemsOnSpecificationsAsync(Apigen.TransIp.Models.FilterOperatingSystemsOnSpecificationsRequest filterOperatingSystemsOnSpecificationsRequest);

  /// <summary>
  /// List all private networks
  /// Operation: GET /private-networks
  /// </summary>
  Task<JsonElement> ListAllPrivateNetworksAsync();

  /// <summary>
  /// Order a new private network
  /// Operation: POST /private-networks
  /// </summary>
  Task OrderNewPrivateNetworkAsync(Apigen.TransIp.Models.OrderNewPrivateNetworkRequest orderNewPrivateNetworkRequest);

  /// <summary>
  /// Cancel a private network
  /// Operation: DELETE /private-networks/{privateNetworkName}
  /// </summary>
  Task DeleteAsync(string privateNetworkName, Apigen.TransIp.Models.CancelPrivateNetworkRequest cancelPrivateNetworkRequest);

  /// <summary>
  /// Get private network by name
  /// Operation: GET /private-networks/{privateNetworkName}
  /// </summary>
  Task<JsonElement> GetPrivateNetworksAsync(string privateNetworkName);

  /// <summary>
  /// Detach vps from privateNetwork
  /// Operation: PATCH /private-networks/{privateNetworkName}
  /// </summary>
  Task DetachVpsPrivateNetworkAsync(string privateNetworkName, Apigen.TransIp.Models.DetachVpsPrivateNetworkRequest detachVpsPrivateNetworkRequest);

  /// <summary>
  /// Update private network
  /// Operation: PUT /private-networks/{privateNetworkName}
  /// </summary>
  Task UpdateAsync(string privateNetworkName, Apigen.TransIp.Models.UpdatePrivateNetworkRequest updatePrivateNetworkRequest);

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
  Task CloneVpsAsync(Apigen.TransIp.Models.CloneVpsRequest cloneVpsRequest);

  /// <summary>
  /// Cancel a VPS
  /// Operation: DELETE /vps/{vpsIdentifier}
  /// </summary>
  Task DeleteAsync(string vpsIdentifier, Apigen.TransIp.Models.CancelVpsRequest cancelVpsRequest);

  /// <summary>
  /// Get VPS by identifier
  /// Operation: GET /vps/{vpsIdentifier}
  /// </summary>
  Task<JsonElement> GetVpsAsync(string vpsIdentifier);

  /// <summary>
  /// Handover a VPS
  /// Operation: PATCH /vps/{vpsIdentifier}
  /// </summary>
  Task HandoverVpsAsync(string vpsIdentifier, Apigen.TransIp.Models.HandoverVpsRequest handoverVpsRequest);

  /// <summary>
  /// Update a VPS
  /// Operation: PUT /vps/{vpsIdentifier}
  /// </summary>
  Task UpdateAsync(string vpsIdentifier, Apigen.TransIp.Models.UpdateVpsRequest updateVpsRequest);

  /// <summary>
  /// List addons for a VPS
  /// Operation: GET /vps/{vpsIdentifier}/addons
  /// </summary>
  Task<JsonElement> ListAddonsVpsAsync(string vpsIdentifier);

  /// <summary>
  /// Order addons for a VPS
  /// Operation: POST /vps/{vpsIdentifier}/addons
  /// </summary>
  Task OrderAddonsVpsAsync(string vpsIdentifier, Apigen.TransIp.Models.OrderAddonsVpsRequest orderAddonsVpsRequest);

  /// <summary>
  /// Cancel an addon for a VPS
  /// Operation: DELETE /vps/{vpsIdentifier}/addons/{addonName}
  /// </summary>
  Task DeleteAsync(string vpsIdentifier, string addonName);

  /// <summary>
  /// List backups for a VPS
  /// Operation: GET /vps/{vpsIdentifier}/backups
  /// </summary>
  Task<JsonElement> ListBackupsVpsAsync(string vpsIdentifier);

  /// <summary>
  /// Convert backup to snapshot
  /// Operation: PATCH /vps/{vpsIdentifier}/backups/{backupId}
  /// </summary>
  Task ConvertBackupSnapshotAsync(string vpsIdentifier, decimal backupId, Apigen.TransIp.Models.ConvertBackupSnapshotRequest convertBackupSnapshotRequest);

  /// <summary>
  /// List firewall for a VPS
  /// Operation: GET /vps/{vpsIdentifier}/firewall
  /// </summary>
  Task<JsonElement> ListFirewallVpsAsync(string vpsIdentifier);

  /// <summary>
  /// Reset firewall for a VPS
  /// Operation: PATCH /vps/{vpsIdentifier}/firewall
  /// </summary>
  Task ResetFirewallVpsAsync(string vpsIdentifier, Apigen.TransIp.Models.ResetFirewallVpsRequest resetFirewallVpsRequest);

  /// <summary>
  /// Update firewall for a VPS
  /// Operation: PUT /vps/{vpsIdentifier}/firewall
  /// </summary>
  Task UpdateFirewallVpsAsync(string vpsIdentifier, Apigen.TransIp.Models.UpdateFirewallVpsRequest updateFirewallVpsRequest);

  /// <summary>
  /// List IP addresses for a VPS
  /// Operation: GET /vps/{vpsIdentifier}/ip-addresses
  /// </summary>
  Task<JsonElement> ListIpAddressesVpsAsync(string vpsIdentifier);

  /// <summary>
  /// Add IPv6 address to a VPS
  /// Operation: POST /vps/{vpsIdentifier}/ip-addresses
  /// </summary>
  Task AddIPv6AddressVpsAsync(string vpsIdentifier, Apigen.TransIp.Models.AddIPv6AddressVpsRequest addIPv6AddressVpsRequest);

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
  Task UpdateAsync(string vpsIdentifier, string ipAddress, Apigen.TransIp.Models.UpdateReverseDnsVpsRequest updateReverseDnsVpsRequest);

  /// <summary>
  /// List licenses for a VPS
  /// Operation: GET /vps/{vpsIdentifier}/licenses
  /// </summary>
  Task<JsonElement> ListLicensesVpsAsync(string vpsIdentifier);

  /// <summary>
  /// Order an addon license
  /// Operation: POST /vps/{vpsIdentifier}/licenses
  /// </summary>
  Task OrderAddonLicenseAsync(string vpsIdentifier, Apigen.TransIp.Models.OrderAddonLicenseRequest orderAddonLicenseRequest);

  /// <summary>
  /// Cancel an addon license
  /// Operation: DELETE /vps/{vpsIdentifier}/licenses/{licenseId}
  /// </summary>
  Task DeleteVpsLicensesAsync(string vpsIdentifier, string licenseId);

  /// <summary>
  /// Update an operating system license
  /// Operation: PUT /vps/{vpsIdentifier}/licenses/{licenseId}
  /// </summary>
  Task UpdateAsync(string vpsIdentifier, string licenseId, Apigen.TransIp.Models.UpdateOperatingSystemLicenseRequest updateOperatingSystemLicenseRequest);

  /// <summary>
  /// List installable operating systems for a VPS
  /// Operation: GET /vps/{vpsIdentifier}/operating-systems
  /// </summary>
  Task<JsonElement> ListInstallableOperatingSystemsVpsAsync(string vpsIdentifier);

  /// <summary>
  /// Install an operating system on a VPS
  /// Operation: POST /vps/{vpsIdentifier}/operating-systems
  /// </summary>
  Task InstallOperatingSystemOnVpsAsync(string vpsIdentifier, Apigen.TransIp.Models.InstallOperatingSystemOnVpsRequest installOperatingSystemOnVpsRequest);

  /// <summary>
  /// Get Rescue Images for your VPS
  /// Operation: GET /vps/{vpsIdentifier}/rescue-images
  /// </summary>
  Task<JsonElement> GetRescueImagesYourVpsAsync(string vpsIdentifier);

  /// <summary>
  /// Boot Rescue Image for a VPS
  /// Operation: PATCH /vps/{vpsIdentifier}/rescue-images
  /// </summary>
  Task BootRescueImageVpsAsync(string vpsIdentifier, Apigen.TransIp.Models.BootRescueImageVpsRequest bootRescueImageVpsRequest);

  /// <summary>
  /// List All Settings for a VPS
  /// Operation: GET /vps/{vpsIdentifier}/settings
  /// </summary>
  Task<JsonElement> ListAllSettingsVpsAsync(string vpsIdentifier);

  /// <summary>
  /// Get VPS Setting Information
  /// Operation: GET /vps/{vpsIdentifier}/settings/{setting}
  /// </summary>
  Task<JsonElement> GetVpsSettingsAsync(string vpsIdentifier, string setting);

  /// <summary>
  /// Update a setting for the specified VPS
  /// Operation: PUT /vps/{vpsIdentifier}/settings/{setting}
  /// </summary>
  Task UpdateAsync(string vpsIdentifier, string setting, Apigen.TransIp.Models.UpdateSettingSpecifiedVpsRequest updateSettingSpecifiedVpsRequest);

  /// <summary>
  /// List snapshots for a VPS
  /// Operation: GET /vps/{vpsIdentifier}/snapshots
  /// </summary>
  Task<JsonElement> ListSnapshotsVpsAsync(string vpsIdentifier);

  /// <summary>
  /// Create snapshot of a VPS
  /// Operation: POST /vps/{vpsIdentifier}/snapshots
  /// </summary>
  Task CreateSnapshotVpsAsync(string vpsIdentifier, Apigen.TransIp.Models.CreateSnapshotVpsRequest createSnapshotVpsRequest);

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
  Task RevertSnapshotVpsAsync(string vpsIdentifier, string snapshotName, Apigen.TransIp.Models.RevertSnapshotVpsRequest revertSnapshotVpsRequest);

  /// <summary>
  /// List all TCP monitors for a VPS
  /// Operation: GET /vps/{vpsIdentifier}/tcp-monitors
  /// </summary>
  Task<JsonElement> ListAllTcpMonitorsVpsAsync(string vpsIdentifier);

  /// <summary>
  /// Create a TCP monitor for a VPS
  /// Operation: POST /vps/{vpsIdentifier}/tcp-monitors
  /// </summary>
  Task CreateTcpMonitorVpsAsync(string vpsIdentifier, Apigen.TransIp.Models.CreateTcpMonitorVpsRequest createTcpMonitorVpsRequest);

  /// <summary>
  /// Delete a TCP monitor for a VPS
  /// Operation: DELETE /vps/{vpsIdentifier}/tcp-monitors/{ipAddress}
  /// </summary>
  Task DeleteVpsTcpMonitorsAsync(string vpsIdentifier, string ipAddress);

  /// <summary>
  /// Update a TCP monitor for a VPS
  /// Operation: PUT /vps/{vpsIdentifier}/tcp-monitors/{ipAddress}
  /// </summary>
  Task UpdateAsync(string vpsIdentifier, string ipAddress, Apigen.TransIp.Models.UpdateTcpMonitorVpsRequest updateTcpMonitorVpsRequest);

  /// <summary>
  /// List available upgrades for a VPS
  /// Operation: GET /vps/{vpsIdentifier}/upgrades
  /// </summary>
  Task<JsonElement> ListAvailableUpgradesVpsAsync(string vpsIdentifier);

  /// <summary>
  /// Upgrade a VPS
  /// Operation: POST /vps/{vpsIdentifier}/upgrades
  /// </summary>
  Task UpgradeVpsAsync(string vpsIdentifier, Apigen.TransIp.Models.UpgradeVpsRequest upgradeVpsRequest);

  /// <summary>
  /// Get usage data for a VPS
  /// Operation: GET /vps/{vpsIdentifier}/usage
  /// </summary>
  Task<JsonElement> GetUsageDataVpsAsync(string vpsIdentifier, Apigen.TransIp.Models.GetUsageDataVpsRequest getUsageDataVpsRequest);

  /// <summary>
  /// Get VNC data for a VPS
  /// Operation: GET /vps/{vpsIdentifier}/vnc-data
  /// </summary>
  Task<JsonElement> GetVncDataVpsAsync(string vpsIdentifier);

  /// <summary>
  /// Regenerate VNC token for a vps
  /// Operation: PATCH /vps/{vpsIdentifier}/vnc-data
  /// </summary>
  Task RegenerateVncTokenVpsAsync(string vpsIdentifier);

}
