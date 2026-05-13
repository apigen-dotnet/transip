using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Apigen.TransIp.Models;

#nullable enable

namespace Apigen.TransIp.Client;

/// <summary>
/// Interface for Domains operations
/// </summary>
public partial interface IDomainsClient
{
  /// <summary>
  /// Check the availability for multiple domain names
  /// Operation: GET /domain-availability
  /// </summary>
  Task<JsonElement> CheckAvailabilityMultipleDomainNamesAsync(Apigen.TransIp.Models.CheckAvailabilityMultipleDomainNamesRequest checkAvailabilityMultipleDomainNamesRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// Check availability for a domain name
  /// Operation: GET /domain-availability/{domainName}
  /// </summary>
  Task<JsonElement> GetAsync(string domainName, CancellationToken cancellationToken = default);

  /// <summary>
  /// List all default domain contacts for your account
  /// Operation: GET /domain-defaults/contacts
  /// </summary>
  Task<JsonElement> ListAllDefaultDomainContactsYourAccountAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// Update contacts for a account
  /// Operation: PUT /domain-defaults/contacts
  /// </summary>
  Task UpdateContactsAccountAsync(Apigen.TransIp.Models.UpdateContactsAccountRequest updateContactsAccountRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// List all domains
  /// Operation: GET /domains
  /// </summary>
  Task<JsonElement> ListAllDomainsAsync(Apigen.TransIp.Models.ListAllDomainsRequest listAllDomainsRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// Transfer a domain
  /// Operation: POST /domains
  /// </summary>
  Task TransferDomainAsync(Apigen.TransIp.Models.TransferDomainRequest transferDomainRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// Cancel a domain
  /// Operation: DELETE /domains/{domainName}
  /// </summary>
  Task DeleteAsync(string domainName, Apigen.TransIp.Models.CancelDomainRequest cancelDomainRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// Retrieve an existing domain
  /// Operation: GET /domains/{domainName}
  /// </summary>
  Task<JsonElement> GetDomainsAsync(string domainName, CancellationToken cancellationToken = default);

  /// <summary>
  /// Handover a domain
  /// Operation: PATCH /domains/{domainName}
  /// </summary>
  Task HandoverDomainAsync(string domainName, Apigen.TransIp.Models.HandoverDomainRequest handoverDomainRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// Update a domain
  /// Operation: PUT /domains/{domainName}
  /// </summary>
  Task UpdateAsync(string domainName, Apigen.TransIp.Models.UpdateDomainRequest updateDomainRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// Cancel domain action
  /// Operation: DELETE /domains/{domainName}/actions
  /// </summary>
  Task CancelDomainActionAsync(string domainName, CancellationToken cancellationToken = default);

  /// <summary>
  /// Get current domain action
  /// Operation: GET /domains/{domainName}/actions
  /// </summary>
  Task<JsonElement> GetCurrentDomainActionAsync(string domainName, CancellationToken cancellationToken = default);

  /// <summary>
  /// Retry domain action
  /// Operation: PATCH /domains/{domainName}/actions
  /// </summary>
  Task RetryDomainActionAsync(string domainName, Apigen.TransIp.Models.RetryDomainActionRequest retryDomainActionRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// Get auth-code of a domain name
  /// Operation: GET /domains/{domainName}/auth-code
  /// </summary>
  Task<JsonElement> GetAuthCodeDomainNameAsync(string domainName, CancellationToken cancellationToken = default);

  /// <summary>
  /// Request an auth code for a domain name
  /// Operation: POST /domains/{domainName}/auth-code
  /// </summary>
  Task RequestAuthCodeDomainNameAsync(string domainName, CancellationToken cancellationToken = default);

  /// <summary>
  /// Get domain branding
  /// Operation: GET /domains/{domainName}/branding
  /// </summary>
  Task<JsonElement> GetDomainBrandingAsync(string domainName, CancellationToken cancellationToken = default);

  /// <summary>
  /// Update domain branding
  /// Operation: PUT /domains/{domainName}/branding
  /// </summary>
  Task UpdateDomainBrandingAsync(string domainName, Apigen.TransIp.Models.UpdateDomainBrandingRequest updateDomainBrandingRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// List all contacts for a domain
  /// Operation: GET /domains/{domainName}/contacts
  /// </summary>
  Task<JsonElement> ListAllContactsDomainAsync(string domainName, CancellationToken cancellationToken = default);

  /// <summary>
  /// Update contacts for a domain
  /// Operation: PUT /domains/{domainName}/contacts
  /// </summary>
  Task UpdateContactsDomainAsync(string domainName, Apigen.TransIp.Models.UpdateContactsDomainRequest updateContactsDomainRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// Remove a DNS entry from a domain
  /// Operation: DELETE /domains/{domainName}/dns
  /// </summary>
  Task RemoveDnsEntryDomainAsync(string domainName, Apigen.TransIp.Models.RemoveDnsEntryDomainRequest removeDnsEntryDomainRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// List all DNS entries for a domain
  /// Operation: GET /domains/{domainName}/dns
  /// </summary>
  Task<JsonElement> ListAllDnsEntriesDomainAsync(string domainName, CancellationToken cancellationToken = default);

  /// <summary>
  /// Update single DNS entry
  /// Operation: PATCH /domains/{domainName}/dns
  /// </summary>
  Task UpdateSingleDnsEntryAsync(string domainName, Apigen.TransIp.Models.UpdateSingleDnsEntryRequest updateSingleDnsEntryRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// Add a new single DNS entry to a domain
  /// Operation: POST /domains/{domainName}/dns
  /// </summary>
  Task AddNewSingleDnsEntryDomainAsync(string domainName, Apigen.TransIp.Models.AddNewSingleDnsEntryDomainRequest addNewSingleDnsEntryDomainRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// Update all DNS entries for a domain
  /// Operation: PUT /domains/{domainName}/dns
  /// </summary>
  Task UpdateAllDnsEntriesDomainAsync(string domainName, Apigen.TransIp.Models.UpdateAllDnsEntriesDomainRequest updateAllDnsEntriesDomainRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// List DNSSEC entries
  /// Operation: GET /domains/{domainName}/dnssec
  /// </summary>
  Task<JsonElement> ListDnssecEntriesAsync(string domainName, CancellationToken cancellationToken = default);

  /// <summary>
  /// Update all DNSSEC entries
  /// Operation: PUT /domains/{domainName}/dnssec
  /// </summary>
  Task UpdateAllDnssecEntriesAsync(string domainName, Apigen.TransIp.Models.UpdateAllDnssecEntriesRequest updateAllDnssecEntriesRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// List nameservers for a domain
  /// Operation: GET /domains/{domainName}/nameservers
  /// </summary>
  Task<JsonElement> ListNameserversDomainAsync(string domainName, CancellationToken cancellationToken = default);

  /// <summary>
  /// Update nameservers for a domain
  /// Operation: PUT /domains/{domainName}/nameservers
  /// </summary>
  Task UpdateNameserversDomainAsync(string domainName, Apigen.TransIp.Models.UpdateNameserversDomainRequest updateNameserversDomainRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// List all SSL certificates
  /// Operation: GET /domains/{domainName}/ssl
  /// </summary>
  Task<JsonElement> ListAllSslCertificatesAsync(string domainName, CancellationToken cancellationToken = default);

  /// <summary>
  /// Get SSL certificate by id
  /// Operation: GET /domains/{domainName}/ssl/{certificateId}
  /// </summary>
  Task<JsonElement> GetAsync(string domainName, decimal certificateId, CancellationToken cancellationToken = default);

  /// <summary>
  /// Get WHOIS information for a domain name
  /// Operation: GET /domains/{domainName}/whois
  /// </summary>
  Task<JsonElement> GetWhoisInformationDomainNameAsync(string domainName, CancellationToken cancellationToken = default);

  /// <summary>
  /// List all TLDs
  /// Operation: GET /tlds
  /// </summary>
  Task<JsonElement> ListAllTLDsAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// Get info for a TLD
  /// Operation: GET /tlds/{tld}
  /// </summary>
  Task<JsonElement> GetTldsAsync(string tld, CancellationToken cancellationToken = default);

  /// <summary>
  /// Order a whitelabel account
  /// Operation: POST /whitelabel
  /// </summary>
  Task OrderWhitelabelAccountAsync(CancellationToken cancellationToken = default);

}
