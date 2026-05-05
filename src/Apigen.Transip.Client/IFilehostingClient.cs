using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Transip.Models;

#nullable enable

namespace Apigen.Transip.Client;

/// <summary>
/// Interface for Filehosting operations
/// </summary>
public interface IFilehostingClient
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
  Task OrderANewDiskAsync(Apigen.Transip.Models.OrderANewDiskRequest orderANewDiskRequest);

  /// <summary>
  /// Cancel a disk
  /// Operation: DELETE /filehosting/disks/{diskId}
  /// </summary>
  Task DeleteAsync(string diskId, Apigen.Transip.Models.CancelADiskRequest cancelADiskRequest);

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
  Task<JsonElement> ListAllBackupsForADiskAsync(string diskId);

  /// <summary>
  /// Revert a backup for a disk
  /// Operation: PUT /filehosting/disks/{diskId}/backups/{backupId}
  /// </summary>
  Task UpdateAsync(string diskId, string backupId);

  /// <summary>
  /// List all custom domain names for a disk
  /// Operation: GET /filehosting/disks/{diskId}/custom-domains
  /// </summary>
  Task<JsonElement> ListAllCustomDomainNamesForADiskAsync(string diskId);

  /// <summary>
  /// Attach custom domain name for a disk
  /// Operation: POST /filehosting/disks/{diskId}/custom-domains
  /// </summary>
  Task AttachCustomDomainNameForADiskAsync(string diskId, Apigen.Transip.Models.AttachCustomDomainNameForADiskRequest attachCustomDomainNameForADiskRequest);

  /// <summary>
  /// Detach a custom domain for a disk
  /// Operation: DELETE /filehosting/disks/{diskId}/custom-domains/{customDomainId}
  /// </summary>
  Task DeleteAsync(string diskId, string customDomainId);

  /// <summary>
  /// Upgrade a disk contract
  /// Operation: PUT /filehosting/disks/{diskId}/upgrades
  /// </summary>
  Task UpgradeADiskContractAsync(string diskId, Apigen.Transip.Models.UpgradeADiskContractRequest upgradeADiskContractRequest);

  /// <summary>
  /// List all users of a disk
  /// Operation: GET /filehosting/disks/{diskId}/users
  /// </summary>
  Task<JsonElement> ListAllUsersOfADiskAsync(string diskId);

  /// <summary>
  /// Reset password for a disk user
  /// Operation: PUT /filehosting/disks/{diskId}/users
  /// </summary>
  Task ResetPasswordForADiskUserAsync(string diskId, Apigen.Transip.Models.ResetPasswordForADiskUserRequest resetPasswordForADiskUserRequest);

}
