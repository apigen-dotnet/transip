using System.Text.Json;
using System.Threading;
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
  Task<JsonElement> ListAllBigStoragesAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// Upgrade big storage
  /// Operation: POST /big-storages
  /// </summary>
  Task UpgradeBigStorageAsync(Apigen.TransIp.Models.UpgradeBigStorageRequest upgradeBigStorageRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// Cancel big storage
  /// Operation: DELETE /big-storages/{bigStorageIdentifier}
  /// </summary>
  Task DeleteAsync(string bigStorageIdentifier, Apigen.TransIp.Models.CancelBigStorageRequest cancelBigStorageRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// Get big storage by identifier
  /// Operation: GET /big-storages/{bigStorageIdentifier}
  /// </summary>
  Task<JsonElement> GetAsync(string bigStorageIdentifier, CancellationToken cancellationToken = default);

  /// <summary>
  /// Update big storage
  /// Operation: PUT /big-storages/{bigStorageIdentifier}
  /// </summary>
  Task UpdateAsync(string bigStorageIdentifier, Apigen.TransIp.Models.UpdateBigStorageRequest updateBigStorageRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// List backups for a big storage
  /// Operation: GET /big-storages/{bigStorageIdentifier}/backups
  /// </summary>
  Task<JsonElement> ListBackupsBigStorageAsync(string bigStorageIdentifier, CancellationToken cancellationToken = default);

  /// <summary>
  /// Revert a big storage backup
  /// Operation: PATCH /big-storages/{bigStorageIdentifier}/backups/{backupId}
  /// </summary>
  Task RevertBigStorageBackupAsync(string bigStorageIdentifier, decimal backupId, Apigen.TransIp.Models.RevertBigStorageBackupRequest revertBigStorageBackupRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// Get big storage usage statistics
  /// Operation: GET /big-storages/{bigStorageIdentifier}/usage
  /// </summary>
  Task<JsonElement> GetBigStorageUsageStatisticsAsync(string bigStorageIdentifier, Apigen.TransIp.Models.GetBigStorageUsageStatisticsRequest getBigStorageUsageStatisticsRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// List all block storages
  /// Operation: GET /block-storages
  /// </summary>
  Task<JsonElement> ListAllBlockStoragesAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// Upgrade block storage
  /// Operation: POST /block-storages
  /// </summary>
  Task UpgradeBlockStorageAsync(Apigen.TransIp.Models.UpgradeBlockStorageRequest upgradeBlockStorageRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// Cancel block storage
  /// Operation: DELETE /block-storages/{blockStorageIdentifier}
  /// </summary>
  Task DeleteAsync(string blockStorageIdentifier, Apigen.TransIp.Models.CancelBlockStorageRequest cancelBlockStorageRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// Get block storage by identifier
  /// Operation: GET /block-storages/{blockStorageIdentifier}
  /// </summary>
  Task<JsonElement> GetBlockStoragesAsync(string blockStorageIdentifier, CancellationToken cancellationToken = default);

  /// <summary>
  /// Update block storage
  /// Operation: PUT /block-storages/{blockStorageIdentifier}
  /// </summary>
  Task UpdateAsync(string blockStorageIdentifier, Apigen.TransIp.Models.UpdateBlockStorageRequest updateBlockStorageRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// List backups for a block storage
  /// Operation: GET /block-storages/{blockStorageIdentifier}/backups
  /// </summary>
  Task<JsonElement> ListBackupsBlockStorageAsync(string blockStorageIdentifier, CancellationToken cancellationToken = default);

  /// <summary>
  /// Revert a block storage backup
  /// Operation: PATCH /block-storages/{blockStorageIdentifier}/backups/{backupId}
  /// </summary>
  Task RevertBlockStorageBackupAsync(string blockStorageIdentifier, decimal backupId, Apigen.TransIp.Models.RevertBlockStorageBackupRequest revertBlockStorageBackupRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// Get block storage usage statistics
  /// Operation: GET /block-storages/{blockStorageIdentifier}/usage
  /// </summary>
  Task<JsonElement> GetBlockStorageUsageStatisticsAsync(string blockStorageIdentifier, Apigen.TransIp.Models.GetBlockStorageUsageStatisticsRequest getBlockStorageUsageStatisticsRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// Get mail service information
  /// Operation: GET /mail-service
  /// </summary>
  Task<JsonElement> GetMailServiceInformationAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// Regenerate mail service password
  /// Operation: PATCH /mail-service
  /// </summary>
  Task RegenerateMailServicePasswordAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// Add mail service DNS entries to domains
  /// Operation: POST /mail-service
  /// </summary>
  Task AddMailServiceDnsEntriesDomainsAsync(Apigen.TransIp.Models.AddMailServiceDnsEntriesDomainsRequest addMailServiceDnsEntriesDomainsRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// List all contacts
  /// Operation: GET /monitoring-contacts
  /// </summary>
  Task<JsonElement> ListAllContactsAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// Create a contact
  /// Operation: POST /monitoring-contacts
  /// </summary>
  Task CreateContactAsync(Apigen.TransIp.Models.CreateContactRequest createContactRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// Delete a contact
  /// Operation: DELETE /monitoring-contacts/{contactId}
  /// </summary>
  Task DeleteAsync(decimal contactId, CancellationToken cancellationToken = default);

  /// <summary>
  /// Update a contact
  /// Operation: PUT /monitoring-contacts/{contactId}
  /// </summary>
  Task UpdateAsync(decimal contactId, Apigen.TransIp.Models.UpdateContactRequest updateContactRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// Filter Operating Systems on specifications
  /// Operation: GET /operating-systems
  /// </summary>
  Task<JsonElement> FilterOperatingSystemsOnSpecificationsAsync(Apigen.TransIp.Models.FilterOperatingSystemsOnSpecificationsRequest filterOperatingSystemsOnSpecificationsRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// List all private networks
  /// Operation: GET /private-networks
  /// </summary>
  Task<JsonElement> ListAllPrivateNetworksAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// Order a new private network
  /// Operation: POST /private-networks
  /// </summary>
  Task OrderNewPrivateNetworkAsync(Apigen.TransIp.Models.OrderNewPrivateNetworkRequest orderNewPrivateNetworkRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// Cancel a private network
  /// Operation: DELETE /private-networks/{privateNetworkName}
  /// </summary>
  Task DeleteAsync(string privateNetworkName, Apigen.TransIp.Models.CancelPrivateNetworkRequest cancelPrivateNetworkRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// Get private network by name
  /// Operation: GET /private-networks/{privateNetworkName}
  /// </summary>
  Task<JsonElement> GetPrivateNetworksAsync(string privateNetworkName, CancellationToken cancellationToken = default);

  /// <summary>
  /// Detach vps from privateNetwork
  /// Operation: PATCH /private-networks/{privateNetworkName}
  /// </summary>
  Task DetachVpsPrivateNetworkAsync(string privateNetworkName, Apigen.TransIp.Models.DetachVpsPrivateNetworkRequest detachVpsPrivateNetworkRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// Update private network
  /// Operation: PUT /private-networks/{privateNetworkName}
  /// </summary>
  Task UpdateAsync(string privateNetworkName, Apigen.TransIp.Models.UpdatePrivateNetworkRequest updatePrivateNetworkRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// Get traffic pool information
  /// Operation: GET /traffic-pool
  /// </summary>
  Task<JsonElement> GetTrafficPoolInformationAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// Get traffic information for a VPS
  /// Operation: GET /traffic-pool/{vpsName}
  /// </summary>
  Task<JsonElement> GetTrafficPoolAsync(string vpsName, CancellationToken cancellationToken = default);

  /// <summary>
  /// List all VPSs
  /// Operation: GET /vps
  /// </summary>
  Task<JsonElement> ListAllVPSsAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// Clone a VPS
  /// Operation: POST /vps
  /// </summary>
  Task CloneVpsAsync(Apigen.TransIp.Models.CloneVpsRequest cloneVpsRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// Cancel a VPS
  /// Operation: DELETE /vps/{vpsIdentifier}
  /// </summary>
  Task DeleteAsync(string vpsIdentifier, Apigen.TransIp.Models.CancelVpsRequest cancelVpsRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// Get VPS by identifier
  /// Operation: GET /vps/{vpsIdentifier}
  /// </summary>
  Task<JsonElement> GetVpsAsync(string vpsIdentifier, CancellationToken cancellationToken = default);

  /// <summary>
  /// Handover a VPS
  /// Operation: PATCH /vps/{vpsIdentifier}
  /// </summary>
  Task HandoverVpsAsync(string vpsIdentifier, Apigen.TransIp.Models.HandoverVpsRequest handoverVpsRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// Update a VPS
  /// Operation: PUT /vps/{vpsIdentifier}
  /// </summary>
  Task UpdateAsync(string vpsIdentifier, Apigen.TransIp.Models.UpdateVpsRequest updateVpsRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// List addons for a VPS
  /// Operation: GET /vps/{vpsIdentifier}/addons
  /// </summary>
  Task<JsonElement> ListAddonsVpsAsync(string vpsIdentifier, CancellationToken cancellationToken = default);

  /// <summary>
  /// Order addons for a VPS
  /// Operation: POST /vps/{vpsIdentifier}/addons
  /// </summary>
  Task OrderAddonsVpsAsync(string vpsIdentifier, Apigen.TransIp.Models.OrderAddonsVpsRequest orderAddonsVpsRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// Cancel an addon for a VPS
  /// Operation: DELETE /vps/{vpsIdentifier}/addons/{addonName}
  /// </summary>
  Task DeleteAsync(string vpsIdentifier, string addonName, CancellationToken cancellationToken = default);

  /// <summary>
  /// List backups for a VPS
  /// Operation: GET /vps/{vpsIdentifier}/backups
  /// </summary>
  Task<JsonElement> ListBackupsVpsAsync(string vpsIdentifier, CancellationToken cancellationToken = default);

  /// <summary>
  /// Convert backup to snapshot
  /// Operation: PATCH /vps/{vpsIdentifier}/backups/{backupId}
  /// </summary>
  Task ConvertBackupSnapshotAsync(string vpsIdentifier, decimal backupId, Apigen.TransIp.Models.ConvertBackupSnapshotRequest convertBackupSnapshotRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// List firewall for a VPS
  /// Operation: GET /vps/{vpsIdentifier}/firewall
  /// </summary>
  Task<JsonElement> ListFirewallVpsAsync(string vpsIdentifier, CancellationToken cancellationToken = default);

  /// <summary>
  /// Reset firewall for a VPS
  /// Operation: PATCH /vps/{vpsIdentifier}/firewall
  /// </summary>
  Task ResetFirewallVpsAsync(string vpsIdentifier, Apigen.TransIp.Models.ResetFirewallVpsRequest resetFirewallVpsRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// Update firewall for a VPS
  /// Operation: PUT /vps/{vpsIdentifier}/firewall
  /// </summary>
  Task UpdateFirewallVpsAsync(string vpsIdentifier, Apigen.TransIp.Models.UpdateFirewallVpsRequest updateFirewallVpsRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// List IP addresses for a VPS
  /// Operation: GET /vps/{vpsIdentifier}/ip-addresses
  /// </summary>
  Task<JsonElement> ListIpAddressesVpsAsync(string vpsIdentifier, CancellationToken cancellationToken = default);

  /// <summary>
  /// Add IPv6 address to a VPS
  /// Operation: POST /vps/{vpsIdentifier}/ip-addresses
  /// </summary>
  Task AddIPv6AddressVpsAsync(string vpsIdentifier, Apigen.TransIp.Models.AddIPv6AddressVpsRequest addIPv6AddressVpsRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// Remove an IPv6 address from a VPS
  /// Operation: DELETE /vps/{vpsIdentifier}/ip-addresses/{ipAddress}
  /// </summary>
  Task DeleteVpsIpAddressesAsync(string vpsIdentifier, string ipAddress, CancellationToken cancellationToken = default);

  /// <summary>
  /// Get IP address info by address
  /// Operation: GET /vps/{vpsIdentifier}/ip-addresses/{ipAddress}
  /// </summary>
  Task<JsonElement> GetAsync(string vpsIdentifier, string ipAddress, CancellationToken cancellationToken = default);

  /// <summary>
  /// Update reverse DNS for a VPS
  /// Operation: PUT /vps/{vpsIdentifier}/ip-addresses/{ipAddress}
  /// </summary>
  Task UpdateAsync(string vpsIdentifier, string ipAddress, Apigen.TransIp.Models.UpdateReverseDnsVpsRequest updateReverseDnsVpsRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// List licenses for a VPS
  /// Operation: GET /vps/{vpsIdentifier}/licenses
  /// </summary>
  Task<JsonElement> ListLicensesVpsAsync(string vpsIdentifier, CancellationToken cancellationToken = default);

  /// <summary>
  /// Order an addon license
  /// Operation: POST /vps/{vpsIdentifier}/licenses
  /// </summary>
  Task OrderAddonLicenseAsync(string vpsIdentifier, Apigen.TransIp.Models.OrderAddonLicenseRequest orderAddonLicenseRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// Cancel an addon license
  /// Operation: DELETE /vps/{vpsIdentifier}/licenses/{licenseId}
  /// </summary>
  Task DeleteVpsLicensesAsync(string vpsIdentifier, string licenseId, CancellationToken cancellationToken = default);

  /// <summary>
  /// Update an operating system license
  /// Operation: PUT /vps/{vpsIdentifier}/licenses/{licenseId}
  /// </summary>
  Task UpdateAsync(string vpsIdentifier, string licenseId, Apigen.TransIp.Models.UpdateOperatingSystemLicenseRequest updateOperatingSystemLicenseRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// List installable operating systems for a VPS
  /// Operation: GET /vps/{vpsIdentifier}/operating-systems
  /// </summary>
  Task<JsonElement> ListInstallableOperatingSystemsVpsAsync(string vpsIdentifier, CancellationToken cancellationToken = default);

  /// <summary>
  /// Install an operating system on a VPS
  /// Operation: POST /vps/{vpsIdentifier}/operating-systems
  /// </summary>
  Task InstallOperatingSystemOnVpsAsync(string vpsIdentifier, Apigen.TransIp.Models.InstallOperatingSystemOnVpsRequest installOperatingSystemOnVpsRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// Get Rescue Images for your VPS
  /// Operation: GET /vps/{vpsIdentifier}/rescue-images
  /// </summary>
  Task<JsonElement> GetRescueImagesYourVpsAsync(string vpsIdentifier, CancellationToken cancellationToken = default);

  /// <summary>
  /// Boot Rescue Image for a VPS
  /// Operation: PATCH /vps/{vpsIdentifier}/rescue-images
  /// </summary>
  Task BootRescueImageVpsAsync(string vpsIdentifier, Apigen.TransIp.Models.BootRescueImageVpsRequest bootRescueImageVpsRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// List All Settings for a VPS
  /// Operation: GET /vps/{vpsIdentifier}/settings
  /// </summary>
  Task<JsonElement> ListAllSettingsVpsAsync(string vpsIdentifier, CancellationToken cancellationToken = default);

  /// <summary>
  /// Get VPS Setting Information
  /// Operation: GET /vps/{vpsIdentifier}/settings/{setting}
  /// </summary>
  Task<JsonElement> GetVpsSettingsAsync(string vpsIdentifier, string setting, CancellationToken cancellationToken = default);

  /// <summary>
  /// Update a setting for the specified VPS
  /// Operation: PUT /vps/{vpsIdentifier}/settings/{setting}
  /// </summary>
  Task UpdateAsync(string vpsIdentifier, string setting, Apigen.TransIp.Models.UpdateSettingSpecifiedVpsRequest updateSettingSpecifiedVpsRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// List snapshots for a VPS
  /// Operation: GET /vps/{vpsIdentifier}/snapshots
  /// </summary>
  Task<JsonElement> ListSnapshotsVpsAsync(string vpsIdentifier, CancellationToken cancellationToken = default);

  /// <summary>
  /// Create snapshot of a VPS
  /// Operation: POST /vps/{vpsIdentifier}/snapshots
  /// </summary>
  Task CreateSnapshotVpsAsync(string vpsIdentifier, Apigen.TransIp.Models.CreateSnapshotVpsRequest createSnapshotVpsRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// Delete a snapshot
  /// Operation: DELETE /vps/{vpsIdentifier}/snapshots/{snapshotName}
  /// </summary>
  Task DeleteVpsSnapshotsAsync(string vpsIdentifier, string snapshotName, CancellationToken cancellationToken = default);

  /// <summary>
  /// Get snapshot by name
  /// Operation: GET /vps/{vpsIdentifier}/snapshots/{snapshotName}
  /// </summary>
  Task<JsonElement> GetVpsSnapshotsAsync(string vpsIdentifier, string snapshotName, CancellationToken cancellationToken = default);

  /// <summary>
  /// Revert snapshot to a VPS
  /// Operation: PATCH /vps/{vpsIdentifier}/snapshots/{snapshotName}
  /// </summary>
  Task RevertSnapshotVpsAsync(string vpsIdentifier, string snapshotName, Apigen.TransIp.Models.RevertSnapshotVpsRequest revertSnapshotVpsRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// List all TCP monitors for a VPS
  /// Operation: GET /vps/{vpsIdentifier}/tcp-monitors
  /// </summary>
  Task<JsonElement> ListAllTcpMonitorsVpsAsync(string vpsIdentifier, CancellationToken cancellationToken = default);

  /// <summary>
  /// Create a TCP monitor for a VPS
  /// Operation: POST /vps/{vpsIdentifier}/tcp-monitors
  /// </summary>
  Task CreateTcpMonitorVpsAsync(string vpsIdentifier, Apigen.TransIp.Models.CreateTcpMonitorVpsRequest createTcpMonitorVpsRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// Delete a TCP monitor for a VPS
  /// Operation: DELETE /vps/{vpsIdentifier}/tcp-monitors/{ipAddress}
  /// </summary>
  Task DeleteVpsTcpMonitorsAsync(string vpsIdentifier, string ipAddress, CancellationToken cancellationToken = default);

  /// <summary>
  /// Update a TCP monitor for a VPS
  /// Operation: PUT /vps/{vpsIdentifier}/tcp-monitors/{ipAddress}
  /// </summary>
  Task UpdateAsync(string vpsIdentifier, string ipAddress, Apigen.TransIp.Models.UpdateTcpMonitorVpsRequest updateTcpMonitorVpsRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// List available upgrades for a VPS
  /// Operation: GET /vps/{vpsIdentifier}/upgrades
  /// </summary>
  Task<JsonElement> ListAvailableUpgradesVpsAsync(string vpsIdentifier, CancellationToken cancellationToken = default);

  /// <summary>
  /// Upgrade a VPS
  /// Operation: POST /vps/{vpsIdentifier}/upgrades
  /// </summary>
  Task UpgradeVpsAsync(string vpsIdentifier, Apigen.TransIp.Models.UpgradeVpsRequest upgradeVpsRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// Get usage data for a VPS
  /// Operation: GET /vps/{vpsIdentifier}/usage
  /// </summary>
  Task<JsonElement> GetUsageDataVpsAsync(string vpsIdentifier, Apigen.TransIp.Models.GetUsageDataVpsRequest getUsageDataVpsRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// Get VNC data for a VPS
  /// Operation: GET /vps/{vpsIdentifier}/vnc-data
  /// </summary>
  Task<JsonElement> GetVncDataVpsAsync(string vpsIdentifier, CancellationToken cancellationToken = default);

  /// <summary>
  /// Regenerate VNC token for a vps
  /// Operation: PATCH /vps/{vpsIdentifier}/vnc-data
  /// </summary>
  Task RegenerateVncTokenVpsAsync(string vpsIdentifier, CancellationToken cancellationToken = default);

}
