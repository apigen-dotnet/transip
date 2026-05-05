using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Transip.Models;

#nullable enable

namespace Apigen.Transip.Client;

/// <summary>
/// Interface for Acronis operations
/// </summary>
public partial interface IAcronisClient
{
  /// <summary>
  /// List all tenants
  /// Operation: GET /acronis/tenants
  /// </summary>
  Task<JsonElement> ListAllTenantsAsync();

  /// <summary>
  /// Order a new tenant
  /// Operation: POST /acronis/tenants
  /// </summary>
  Task OrderNewTenantAsync(Apigen.Transip.Models.OrderNewTenantRequest orderNewTenantRequest);

  /// <summary>
  /// Cancel a tenant
  /// Operation: DELETE /acronis/tenants/{tenantUuid}
  /// </summary>
  Task DeleteAsync(string tenantUuid, Apigen.Transip.Models.CancelTenantRequest cancelTenantRequest);

  /// <summary>
  /// Get tenant by uuid
  /// Operation: GET /acronis/tenants/{tenantUuid}
  /// </summary>
  Task<JsonElement> GetAsync(string tenantUuid);

  /// <summary>
  /// Update tenant
  /// Operation: PUT /acronis/tenants/{tenantUuid}
  /// </summary>
  Task UpdateAsync(string tenantUuid, Apigen.Transip.Models.UpdateTenantRequest updateTenantRequest);

  /// <summary>
  /// Order addons
  /// Operation: POST /acronis/tenants/{tenantUuid}/addons
  /// </summary>
  Task OrderAddonsAsync(string tenantUuid, Apigen.Transip.Models.OrderAddonsRequest orderAddonsRequest);

  /// <summary>
  /// Cancel addons
  /// Operation: DELETE /acronis/tenants/{tenantUuid}/addons/{addonName}
  /// </summary>
  Task DeleteAsync(string tenantUuid, string addonName);

  /// <summary>
  /// Downgrade a tenant
  /// Operation: PUT /acronis/tenants/{tenantUuid}/downgrades
  /// </summary>
  Task DowngradeTenantAsync(string tenantUuid, Apigen.Transip.Models.DowngradeTenantRequest downgradeTenantRequest);

  /// <summary>
  /// Generate one time token login url
  /// Operation: GET /acronis/tenants/{tenantUuid}/login
  /// </summary>
  Task<JsonElement> GenerateOneTimeTokenLoginUrlAsync(string tenantUuid);

  /// <summary>
  /// Upgrade a tenant
  /// Operation: PUT /acronis/tenants/{tenantUuid}/upgrades
  /// </summary>
  Task UpgradeTenantAsync(string tenantUuid, Apigen.Transip.Models.UpgradeTenantRequest upgradeTenantRequest);

  /// <summary>
  /// Fetch overview of current storage usage [DEPRECATED]
  /// Operation: GET /acronis/tenants/{tenantUuid}/usage
  /// </summary>
  Task<JsonElement> FetchOverviewCurrentStorageUsageDeprecatedAsync(string tenantUuid);

  /// <summary>
  /// Fetch overview of current usages
  /// Operation: GET /acronis/tenants/{tenantUuid}/usages
  /// </summary>
  Task<JsonElement> FetchOverviewCurrentUsagesAsync(string tenantUuid);

}
