using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Transip.Models;

#nullable enable

namespace Apigen.Transip.Client;

/// <summary>
/// Interface for Domains operations
/// </summary>
public interface IDomainsClient
{
  /// <summary>
  /// Check the availability for multiple domain names
  /// Operation: GET /domain-availability
  /// </summary>
  Task<JsonElement> CheckTheAvailabilityForMultipleDomainNamesAsync(Apigen.Transip.Models.CheckTheAvailabilityForMultipleDomainNamesRequest checkTheAvailabilityForMultipleDomainNamesRequest);

  /// <summary>
  /// Check availability for a domain name
  /// Operation: GET /domain-availability/{domainName}
  /// </summary>
  Task<JsonElement> GetAsync(string domainName);

  /// <summary>
  /// List all default domain contacts for your account
  /// Operation: GET /domain-defaults/contacts
  /// </summary>
  Task<JsonElement> ListAllDefaultDomainContactsForYourAccountAsync();

  /// <summary>
  /// Update contacts for a account
  /// Operation: PUT /domain-defaults/contacts
  /// </summary>
  Task UpdateContactsForAAccountAsync(Apigen.Transip.Models.UpdateContactsForAAccountRequest updateContactsForAAccountRequest);

  /// <summary>
  /// List all domains
  /// Operation: GET /domains
  /// </summary>
  Task<JsonElement> ListAllDomainsAsync(Apigen.Transip.Models.ListAllDomainsRequest listAllDomainsRequest);

  /// <summary>
  /// Transfer a domain
  /// Operation: POST /domains
  /// </summary>
  Task TransferADomainAsync(Apigen.Transip.Models.TransferADomainRequest transferADomainRequest);

  /// <summary>
  /// Cancel a domain
  /// Operation: DELETE /domains/{domainName}
  /// </summary>
  Task DeleteAsync(string domainName, Apigen.Transip.Models.CancelADomainRequest cancelADomainRequest);

  /// <summary>
  /// Retrieve an existing domain
  /// Operation: GET /domains/{domainName}
  /// </summary>
  Task<JsonElement> GetDomainsAsync(string domainName);

  /// <summary>
  /// Handover a domain
  /// Operation: PATCH /domains/{domainName}
  /// </summary>
  Task HandoverADomainAsync(string domainName, Apigen.Transip.Models.HandoverADomainRequest handoverADomainRequest);

  /// <summary>
  /// Update a domain
  /// Operation: PUT /domains/{domainName}
  /// </summary>
  Task UpdateAsync(string domainName, Apigen.Transip.Models.UpdateADomainRequest updateADomainRequest);

  /// <summary>
  /// Cancel domain action
  /// Operation: DELETE /domains/{domainName}/actions
  /// </summary>
  Task CancelDomainActionAsync(string domainName);

  /// <summary>
  /// Get current domain action
  /// Operation: GET /domains/{domainName}/actions
  /// </summary>
  Task<JsonElement> GetCurrentDomainActionAsync(string domainName);

  /// <summary>
  /// Retry domain action
  /// Operation: PATCH /domains/{domainName}/actions
  /// </summary>
  Task RetryDomainActionAsync(string domainName, Apigen.Transip.Models.RetryDomainActionRequest retryDomainActionRequest);

  /// <summary>
  /// Get auth-code of a domain name
  /// Operation: GET /domains/{domainName}/auth-code
  /// </summary>
  Task<JsonElement> GetAuthCodeOfADomainNameAsync(string domainName);

  /// <summary>
  /// Request an auth code for a domain name
  /// Operation: POST /domains/{domainName}/auth-code
  /// </summary>
  Task RequestAnAuthCodeForADomainNameAsync(string domainName);

  /// <summary>
  /// Get domain branding
  /// Operation: GET /domains/{domainName}/branding
  /// </summary>
  Task<JsonElement> GetDomainBrandingAsync(string domainName);

  /// <summary>
  /// Update domain branding
  /// Operation: PUT /domains/{domainName}/branding
  /// </summary>
  Task UpdateDomainBrandingAsync(string domainName, Apigen.Transip.Models.UpdateDomainBrandingRequest updateDomainBrandingRequest);

  /// <summary>
  /// List all contacts for a domain
  /// Operation: GET /domains/{domainName}/contacts
  /// </summary>
  Task<JsonElement> ListAllContactsForADomainAsync(string domainName);

  /// <summary>
  /// Update contacts for a domain
  /// Operation: PUT /domains/{domainName}/contacts
  /// </summary>
  Task UpdateContactsForADomainAsync(string domainName, Apigen.Transip.Models.UpdateContactsForADomainRequest updateContactsForADomainRequest);

  /// <summary>
  /// Remove a DNS entry from a domain
  /// Operation: DELETE /domains/{domainName}/dns
  /// </summary>
  Task RemoveADnsEntryFromADomainAsync(string domainName, Apigen.Transip.Models.RemoveADnsEntryFromADomainRequest removeADnsEntryFromADomainRequest);

  /// <summary>
  /// List all DNS entries for a domain
  /// Operation: GET /domains/{domainName}/dns
  /// </summary>
  Task<JsonElement> ListAllDnsEntriesForADomainAsync(string domainName);

  /// <summary>
  /// Update single DNS entry
  /// Operation: PATCH /domains/{domainName}/dns
  /// </summary>
  Task UpdateSingleDnsEntryAsync(string domainName, Apigen.Transip.Models.UpdateSingleDnsEntryRequest updateSingleDnsEntryRequest);

  /// <summary>
  /// Add a new single DNS entry to a domain
  /// Operation: POST /domains/{domainName}/dns
  /// </summary>
  Task AddANewSingleDnsEntryToADomainAsync(string domainName, Apigen.Transip.Models.AddANewSingleDnsEntryToADomainRequest addANewSingleDnsEntryToADomainRequest);

  /// <summary>
  /// Update all DNS entries for a domain
  /// Operation: PUT /domains/{domainName}/dns
  /// </summary>
  Task UpdateAllDnsEntriesForADomainAsync(string domainName, Apigen.Transip.Models.UpdateAllDnsEntriesForADomainRequest updateAllDnsEntriesForADomainRequest);

  /// <summary>
  /// List DNSSEC entries
  /// Operation: GET /domains/{domainName}/dnssec
  /// </summary>
  Task<JsonElement> ListDnssecEntriesAsync(string domainName);

  /// <summary>
  /// Update all DNSSEC entries
  /// Operation: PUT /domains/{domainName}/dnssec
  /// </summary>
  Task UpdateAllDnssecEntriesAsync(string domainName, Apigen.Transip.Models.UpdateAllDnssecEntriesRequest updateAllDnssecEntriesRequest);

  /// <summary>
  /// List nameservers for a domain
  /// Operation: GET /domains/{domainName}/nameservers
  /// </summary>
  Task<JsonElement> ListNameserversForADomainAsync(string domainName);

  /// <summary>
  /// Update nameservers for a domain
  /// Operation: PUT /domains/{domainName}/nameservers
  /// </summary>
  Task UpdateNameserversForADomainAsync(string domainName, Apigen.Transip.Models.UpdateNameserversForADomainRequest updateNameserversForADomainRequest);

  /// <summary>
  /// List all SSL certificates
  /// Operation: GET /domains/{domainName}/ssl
  /// </summary>
  Task<JsonElement> ListAllSslCertificatesAsync(string domainName);

  /// <summary>
  /// Get SSL certificate by id
  /// Operation: GET /domains/{domainName}/ssl/{certificateId}
  /// </summary>
  Task<JsonElement> GetAsync(string domainName, decimal certificateId);

  /// <summary>
  /// Get WHOIS information for a domain name
  /// Operation: GET /domains/{domainName}/whois
  /// </summary>
  Task<JsonElement> GetWhoisInformationForADomainNameAsync(string domainName);

  /// <summary>
  /// List all TLDs
  /// Operation: GET /tlds
  /// </summary>
  Task<JsonElement> ListAllTLDsAsync();

  /// <summary>
  /// Get info for a TLD
  /// Operation: GET /tlds/{tld}
  /// </summary>
  Task<JsonElement> GetTldsAsync(string tld);

  /// <summary>
  /// Order a whitelabel account
  /// Operation: POST /whitelabel
  /// </summary>
  Task OrderAWhitelabelAccountAsync();

}
