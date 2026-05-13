using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Apigen.TransIp.Models;

#nullable enable

namespace Apigen.TransIp.Client;

/// <summary>
/// Interface for Filehosting operations
/// </summary>
public partial interface IFilehostingClient
{
  /// <summary>
  /// List all disks
  /// Operation: GET /filehosting/disks
  /// </summary>
  Task<JsonElement> ListAllDisksAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// Order a new disk
  /// Operation: POST /filehosting/disks
  /// </summary>
  Task OrderNewDiskAsync(Apigen.TransIp.Models.OrderNewDiskRequest orderNewDiskRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// Cancel a disk
  /// Operation: DELETE /filehosting/disks/{diskId}
  /// </summary>
  Task DeleteAsync(string diskId, Apigen.TransIp.Models.CancelDiskRequest cancelDiskRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// Get disk by disk id
  /// Operation: GET /filehosting/disks/{diskId}
  /// </summary>
  Task<JsonElement> GetAsync(string diskId, CancellationToken cancellationToken = default);

  /// <summary>
  /// Update disk
  /// Operation: PUT /filehosting/disks/{diskId}
  /// </summary>
  Task UpdateAsync(string diskId, Apigen.TransIp.Models.UpdateDiskRequest updateDiskRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// List all backups for a disk
  /// Operation: GET /filehosting/disks/{diskId}/backups
  /// </summary>
  Task<JsonElement> ListAllBackupsDiskAsync(string diskId, CancellationToken cancellationToken = default);

  /// <summary>
  /// Revert a backup for a disk
  /// Operation: PUT /filehosting/disks/{diskId}/backups/{backupId}
  /// </summary>
  Task UpdateAsync(string diskId, string backupId, CancellationToken cancellationToken = default);

  /// <summary>
  /// List all custom domain names for a disk
  /// Operation: GET /filehosting/disks/{diskId}/custom-domains
  /// </summary>
  Task<JsonElement> ListAllCustomDomainNamesDiskAsync(string diskId, CancellationToken cancellationToken = default);

  /// <summary>
  /// Attach custom domain name for a disk
  /// Operation: POST /filehosting/disks/{diskId}/custom-domains
  /// </summary>
  Task AttachCustomDomainNameDiskAsync(string diskId, Apigen.TransIp.Models.AttachCustomDomainNameDiskRequest attachCustomDomainNameDiskRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// Detach a custom domain for a disk
  /// Operation: DELETE /filehosting/disks/{diskId}/custom-domains/{customDomainId}
  /// </summary>
  Task DeleteAsync(string diskId, string customDomainId, CancellationToken cancellationToken = default);

  /// <summary>
  /// Upgrade a disk contract
  /// Operation: PUT /filehosting/disks/{diskId}/upgrades
  /// </summary>
  Task UpgradeDiskContractAsync(string diskId, Apigen.TransIp.Models.UpgradeDiskContractRequest upgradeDiskContractRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// List all users of a disk
  /// Operation: GET /filehosting/disks/{diskId}/users
  /// </summary>
  Task<JsonElement> ListAllUsersDiskAsync(string diskId, CancellationToken cancellationToken = default);

  /// <summary>
  /// Reset password for a disk user
  /// Operation: PUT /filehosting/disks/{diskId}/users
  /// </summary>
  Task ResetPasswordDiskUserAsync(string diskId, Apigen.TransIp.Models.ResetPasswordDiskUserRequest resetPasswordDiskUserRequest, CancellationToken cancellationToken = default);

}
