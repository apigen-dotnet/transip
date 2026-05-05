using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Transip.Models;

#nullable enable

namespace Apigen.Transip.Client;

/// <summary>
/// Interface for Filehosting operations
/// </summary>
public partial interface IFilehostingClient
{
  /// <summary>
  /// List all disks
  /// Operation: GET /filehosting/disks
  /// </summary>
  Task<JsonElement> ListAllDisksAsync();

  /// <summary>
  /// Order a new disk
  /// Operation: POST /filehosting/disks
  /// </summary>
  Task OrderNewDiskAsync(Apigen.Transip.Models.OrderNewDiskRequest orderNewDiskRequest);

  /// <summary>
  /// Cancel a disk
  /// Operation: DELETE /filehosting/disks/{diskId}
  /// </summary>
  Task DeleteAsync(string diskId, Apigen.Transip.Models.CancelDiskRequest cancelDiskRequest);

  /// <summary>
  /// Get disk by disk id
  /// Operation: GET /filehosting/disks/{diskId}
  /// </summary>
  Task<JsonElement> GetAsync(string diskId);

  /// <summary>
  /// Update disk
  /// Operation: PUT /filehosting/disks/{diskId}
  /// </summary>
  Task UpdateAsync(string diskId, Apigen.Transip.Models.UpdateDiskRequest updateDiskRequest);

  /// <summary>
  /// List all backups for a disk
  /// Operation: GET /filehosting/disks/{diskId}/backups
  /// </summary>
  Task<JsonElement> ListAllBackupsDiskAsync(string diskId);

  /// <summary>
  /// Revert a backup for a disk
  /// Operation: PUT /filehosting/disks/{diskId}/backups/{backupId}
  /// </summary>
  Task UpdateAsync(string diskId, string backupId);

  /// <summary>
  /// List all custom domain names for a disk
  /// Operation: GET /filehosting/disks/{diskId}/custom-domains
  /// </summary>
  Task<JsonElement> ListAllCustomDomainNamesDiskAsync(string diskId);

  /// <summary>
  /// Attach custom domain name for a disk
  /// Operation: POST /filehosting/disks/{diskId}/custom-domains
  /// </summary>
  Task AttachCustomDomainNameDiskAsync(string diskId, Apigen.Transip.Models.AttachCustomDomainNameDiskRequest attachCustomDomainNameDiskRequest);

  /// <summary>
  /// Detach a custom domain for a disk
  /// Operation: DELETE /filehosting/disks/{diskId}/custom-domains/{customDomainId}
  /// </summary>
  Task DeleteAsync(string diskId, string customDomainId);

  /// <summary>
  /// Upgrade a disk contract
  /// Operation: PUT /filehosting/disks/{diskId}/upgrades
  /// </summary>
  Task UpgradeDiskContractAsync(string diskId, Apigen.Transip.Models.UpgradeDiskContractRequest upgradeDiskContractRequest);

  /// <summary>
  /// List all users of a disk
  /// Operation: GET /filehosting/disks/{diskId}/users
  /// </summary>
  Task<JsonElement> ListAllUsersDiskAsync(string diskId);

  /// <summary>
  /// Reset password for a disk user
  /// Operation: PUT /filehosting/disks/{diskId}/users
  /// </summary>
  Task ResetPasswordDiskUserAsync(string diskId, Apigen.Transip.Models.ResetPasswordDiskUserRequest resetPasswordDiskUserRequest);

}
