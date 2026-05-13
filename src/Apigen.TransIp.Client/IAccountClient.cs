using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Apigen.TransIp.Models;

#nullable enable

namespace Apigen.TransIp.Client;

/// <summary>
/// Interface for Account operations
/// </summary>
public partial interface IAccountClient
{
  /// <summary>
  /// Contact key
  /// Operation: GET /contact-key
  /// </summary>
  Task<JsonElement> ContactKeyAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// List all invoices
  /// Operation: GET /invoices
  /// </summary>
  Task<JsonElement> ListAllInvoicesAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// List a single invoice
  /// Operation: GET /invoices/{invoiceNumber}
  /// </summary>
  Task<JsonElement> GetAsync(string invoiceNumber, CancellationToken cancellationToken = default);

  /// <summary>
  /// List invoice items by InvoiceNumber
  /// Operation: GET /invoices/{invoiceNumber}/invoice-items
  /// </summary>
  Task<JsonElement> ListInvoiceItemsInvoiceNumberAsync(string invoiceNumber, CancellationToken cancellationToken = default);

  /// <summary>
  /// Retrieve an invoice as PDF file
  /// Operation: GET /invoices/{invoiceNumber}/pdf
  /// </summary>
  Task<JsonElement> RetrieveInvoiceAsPdfFileAsync(string invoiceNumber, CancellationToken cancellationToken = default);

  /// <summary>
  /// List all SSH keys
  /// Operation: GET /ssh-keys
  /// </summary>
  Task<JsonElement> ListAllSshKeysAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// Add a new SSH key
  /// Operation: POST /ssh-keys
  /// </summary>
  Task AddNewSshKeyAsync(Apigen.TransIp.Models.AddNewSshKeyRequest addNewSshKeyRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// Delete an SSH key
  /// Operation: DELETE /ssh-keys/{id}
  /// </summary>
  Task DeleteAsync(string id, CancellationToken cancellationToken = default);

  /// <summary>
  /// Get SSH key by id
  /// Operation: GET /ssh-keys/{id}
  /// </summary>
  Task<JsonElement> GetSshKeysAsync(string id, CancellationToken cancellationToken = default);

  /// <summary>
  /// Update an SSH key
  /// Operation: PUT /ssh-keys/{id}
  /// </summary>
  Task UpdateAsync(string id, Apigen.TransIp.Models.UpdateSshKeyRequest updateSshKeyRequest, CancellationToken cancellationToken = default);

}
