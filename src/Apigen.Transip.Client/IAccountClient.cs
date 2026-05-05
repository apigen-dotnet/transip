using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Transip.Models;

#nullable enable

namespace Apigen.Transip.Client;

/// <summary>
/// Interface for Account operations
/// </summary>
public interface IAccountClient
{
  /// <summary>
  /// Contact key
  /// Operation: GET /contact-key
  /// </summary>
  Task<JsonElement> ContactKeyAsync();

  /// <summary>
  /// List all invoices
  /// Operation: GET /invoices
  /// </summary>
  Task<JsonElement> ListAllInvoicesAsync();

  /// <summary>
  /// List a single invoice
  /// Operation: GET /invoices/{invoiceNumber}
  /// </summary>
  Task<JsonElement> GetAsync(string invoiceNumber);

  /// <summary>
  /// List invoice items by InvoiceNumber
  /// Operation: GET /invoices/{invoiceNumber}/invoice-items
  /// </summary>
  Task<JsonElement> ListInvoiceItemsByInvoiceNumberAsync(string invoiceNumber);

  /// <summary>
  /// Retrieve an invoice as PDF file
  /// Operation: GET /invoices/{invoiceNumber}/pdf
  /// </summary>
  Task<JsonElement> RetrieveAnInvoiceAsPdfFileAsync(string invoiceNumber);

  /// <summary>
  /// List all SSH keys
  /// Operation: GET /ssh-keys
  /// </summary>
  Task<JsonElement> ListAllSshKeysAsync();

  /// <summary>
  /// Add a new SSH key
  /// Operation: POST /ssh-keys
  /// </summary>
  Task AddANewSshKeyAsync(Apigen.Transip.Models.AddANewSshKeyRequest addANewSshKeyRequest);

  /// <summary>
  /// Delete an SSH key
  /// Operation: DELETE /ssh-keys/{id}
  /// </summary>
  Task DeleteAsync(string id);

  /// <summary>
  /// Get SSH key by id
  /// Operation: GET /ssh-keys/{id}
  /// </summary>
  Task<JsonElement> GetSshKeysAsync(string id);

  /// <summary>
  /// Update an SSH key
  /// Operation: PUT /ssh-keys/{id}
  /// </summary>
  Task UpdateAsync(string id, Apigen.Transip.Models.UpdateAnSshKeyRequest updateAnSshKeyRequest);

}
