using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Apigen.TransIp.Models;

#nullable enable

namespace Apigen.TransIp.Client;

/// <summary>
/// Interface for Acronis operations
/// </summary>
public partial interface IAcronisClient
{
  /// <summary>
  /// List all tenants
  /// Operation: GET /acronis/tenants
  /// </summary>
  Task<JsonElement> ListAllTenantsAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// Order a new tenant
  /// Operation: POST /acronis/tenants
  /// </summary>
  Task OrderNewTenantAsync(Apigen.TransIp.Models.OrderNewTenantRequest orderNewTenantRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// Cancel a tenant
  /// Operation: DELETE /acronis/tenants/{tenantUuid}
  /// </summary>
  Task DeleteAsync(string tenantUuid, Apigen.TransIp.Models.CancelTenantRequest cancelTenantRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// Get tenant by uuid
  /// Operation: GET /acronis/tenants/{tenantUuid}
  /// </summary>
  Task<JsonElement> GetAsync(string tenantUuid, CancellationToken cancellationToken = default);

  /// <summary>
  /// Update tenant
  /// Operation: PUT /acronis/tenants/{tenantUuid}
  /// </summary>
  Task UpdateAsync(string tenantUuid, Apigen.TransIp.Models.UpdateTenantRequest updateTenantRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// Order addons
  /// Operation: POST /acronis/tenants/{tenantUuid}/addons
  /// </summary>
  Task OrderAddonsAsync(string tenantUuid, Apigen.TransIp.Models.OrderAddonsRequest orderAddonsRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// Cancel addons
  /// Operation: DELETE /acronis/tenants/{tenantUuid}/addons/{addonName}
  /// </summary>
  Task DeleteAsync(string tenantUuid, string addonName, CancellationToken cancellationToken = default);

  /// <summary>
  /// Downgrade a tenant
  /// Operation: PUT /acronis/tenants/{tenantUuid}/downgrades
  /// </summary>
  Task DowngradeTenantAsync(string tenantUuid, Apigen.TransIp.Models.DowngradeTenantRequest downgradeTenantRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// Generate one time token login url
  /// Operation: GET /acronis/tenants/{tenantUuid}/login
  /// </summary>
  Task<JsonElement> GenerateOneTimeTokenLoginUrlAsync(string tenantUuid, CancellationToken cancellationToken = default);

  /// <summary>
  /// Upgrade a tenant
  /// Operation: PUT /acronis/tenants/{tenantUuid}/upgrades
  /// </summary>
  Task UpgradeTenantAsync(string tenantUuid, Apigen.TransIp.Models.UpgradeTenantRequest upgradeTenantRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// Fetch overview of current storage usage [DEPRECATED]
  /// Operation: GET /acronis/tenants/{tenantUuid}/usage
  /// </summary>
  Task<JsonElement> FetchOverviewCurrentStorageUsageDeprecatedAsync(string tenantUuid, CancellationToken cancellationToken = default);

  /// <summary>
  /// Fetch overview of current usages
  /// Operation: GET /acronis/tenants/{tenantUuid}/usages
  /// </summary>
  Task<JsonElement> FetchOverviewCurrentUsagesAsync(string tenantUuid, CancellationToken cancellationToken = default);

}
