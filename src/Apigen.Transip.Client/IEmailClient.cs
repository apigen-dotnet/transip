using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Transip.Models;

#nullable enable

namespace Apigen.Transip.Client;

/// <summary>
/// Interface for Email operations
/// </summary>
public interface IEmailClient
{
  /// <summary>
  /// List all mail packages
  /// Operation: GET /email
  /// </summary>
  Task<JsonElement> ListAllMailPackagesAsync();

  /// <summary>
  /// List all mail addons
  /// Operation: GET /email/{domain}/mail-addons
  /// </summary>
  Task<JsonElement> ListAllMailAddonsAsync(string domain);

  /// <summary>
  /// Unlink email addon to mailbox
  /// Operation: PATCH /email/{domain}/mail-addons/{id}
  /// </summary>
  Task<JsonElement> UnlinkEmailAddonToMailboxAsync(string domain, string id, Apigen.Transip.Models.UnlinkEmailAddonToMailboxRequest unlinkEmailAddonToMailboxRequest);

  /// <summary>
  /// List all mail forwards
  /// Operation: GET /email/{domain}/mail-forwards
  /// </summary>
  Task<JsonElement> ListAllMailForwardsAsync(string domain);

  /// <summary>
  /// Create mail forward
  /// Operation: POST /email/{domain}/mail-forwards
  /// </summary>
  Task<JsonElement> CreateMailForwardAsync(string domain, Apigen.Transip.Models.CreateMailForwardRequest createMailForwardRequest);

  /// <summary>
  /// Delete mail forward
  /// Operation: DELETE /email/{domain}/mail-forwards/{forwardId}
  /// </summary>
  Task DeleteAsync(string domain, string forwardId);

  /// <summary>
  /// Get mail forward
  /// Operation: GET /email/{domain}/mail-forwards/{forwardId}
  /// </summary>
  Task<JsonElement> GetAsync(string domain, string forwardId);

  /// <summary>
  /// Update mail forward field
  /// Operation: PATCH /email/{domain}/mail-forwards/{forwardId}
  /// </summary>
  Task UpdateMailForwardFieldAsync(string domain, string forwardId, Apigen.Transip.Models.UpdateMailForwardFieldRequest updateMailForwardFieldRequest);

  /// <summary>
  /// Update mail forward
  /// Operation: PUT /email/{domain}/mail-forwards/{forwardId}
  /// </summary>
  Task UpdateAsync(string domain, string forwardId, Apigen.Transip.Models.UpdateMailForwardRequest updateMailForwardRequest);

  /// <summary>
  /// List all Mail lists
  /// Operation: GET /email/{domain}/mail-lists
  /// </summary>
  Task<JsonElement> ListAllMailListsAsync(string domain);

  /// <summary>
  /// Create Mail list
  /// Operation: POST /email/{domain}/mail-lists
  /// </summary>
  Task CreateMailListAsync(string domain, Apigen.Transip.Models.CreateMailListRequest createMailListRequest);

  /// <summary>
  /// Delete Mail List
  /// Operation: DELETE /email/{domain}/mail-lists/{listId}
  /// </summary>
  Task DeleteEmailMailListsAsync(string domain, string listId);

  /// <summary>
  /// Get Mail list
  /// Operation: GET /email/{domain}/mail-lists/{listId}
  /// </summary>
  Task<JsonElement> GetEmailMailListsAsync(string domain, string listId);

  /// <summary>
  /// Update Mail list
  /// Operation: PUT /email/{domain}/mail-lists/{listId}
  /// </summary>
  Task UpdateAsync(string domain, string listId, Apigen.Transip.Models.UpdateMailListRequest updateMailListRequest);

  /// <summary>
  /// List all Mailboxes
  /// Operation: GET /email/{domain}/mailboxes
  /// </summary>
  Task<JsonElement> ListAllMailboxesAsync(string domain);

  /// <summary>
  /// Create Mailbox
  /// Operation: POST /email/{domain}/mailboxes
  /// </summary>
  Task<JsonElement> CreateMailboxAsync(string domain, Apigen.Transip.Models.CreateMailboxRequest createMailboxRequest);

  /// <summary>
  /// Delete Mailbox
  /// Operation: DELETE /email/{domain}/mailboxes/{identifier}
  /// </summary>
  Task<JsonElement> DeleteEmailMailboxesAsync(string domain, string identifier);

  /// <summary>
  /// Get Mailbox
  /// Operation: GET /email/{domain}/mailboxes/{identifier}
  /// </summary>
  Task<JsonElement> GetEmailMailboxesAsync(string domain, string identifier);

  /// <summary>
  /// Update Mailbox field
  /// Operation: PATCH /email/{domain}/mailboxes/{identifier}
  /// </summary>
  Task<JsonElement> UpdateMailboxFieldAsync(string domain, string identifier, Apigen.Transip.Models.UpdateMailboxFieldRequest updateMailboxFieldRequest);

  /// <summary>
  /// Update Mailbox
  /// Operation: PUT /email/{domain}/mailboxes/{identifier}
  /// </summary>
  Task<JsonElement> UpdateAsync(string domain, string identifier, Apigen.Transip.Models.UpdateMailboxRequest updateMailboxRequest);

}
