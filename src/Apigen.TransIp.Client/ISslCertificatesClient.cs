using System.Text.Json;
using System.Threading.Tasks;
using Apigen.TransIp.Models;

#nullable enable

namespace Apigen.TransIp.Client;

/// <summary>
/// Interface for SSL Certificates operations
/// </summary>
public partial interface ISslCertificatesClient
{
  /// <summary>
  /// List all SSL certificates
  /// Operation: GET /ssl-certificates
  /// </summary>
  Task<JsonElement> ListAllSslCertificatesAsync();

  /// <summary>
  /// Order a SSL certificate
  /// Operation: POST /ssl-certificates
  /// </summary>
  Task OrderSslCertificateAsync(Apigen.TransIp.Models.OrderSslCertificateRequest orderSslCertificateRequest);

  /// <summary>
  /// Get SSL certificate by id
  /// Operation: GET /ssl-certificates/{certificateId}
  /// </summary>
  Task<JsonElement> GetAsync(decimal certificateId);

  /// <summary>
  /// Reissue a certificate
  /// Operation: PATCH /ssl-certificates/{certificateId}
  /// </summary>
  Task ReissueCertificateAsync(decimal certificateId, Apigen.TransIp.Models.ReissueCertificateRequest reissueCertificateRequest);

  /// <summary>
  /// Details for SSL certificate by id
  /// Operation: GET /ssl-certificates/{certificateId}/details
  /// </summary>
  Task<JsonElement> DetailsSslCertificateIdAsync(decimal certificateId);

  /// <summary>
  /// Download a SSL certificate by id
  /// Operation: POST /ssl-certificates/{certificateId}/download
  /// </summary>
  Task<JsonElement> DownloadSslCertificateIdAsync(decimal certificateId, Apigen.TransIp.Models.DownloadSslCertificateIdRequest downloadSslCertificateIdRequest);

  /// <summary>
  /// Install an ssl certificate
  /// Operation: PATCH /ssl-certificates/{certificateId}/install
  /// </summary>
  Task InstallSslCertificateAsync(decimal certificateId, Apigen.TransIp.Models.InstallSslCertificateRequest installSslCertificateRequest);

  /// <summary>
  /// Uninstall an ssl certificate
  /// Operation: DELETE /ssl-certificates/{certificateId}/uninstall
  /// </summary>
  Task UninstallSslCertificateAsync(decimal certificateId, Apigen.TransIp.Models.UninstallSslCertificateRequest uninstallSslCertificateRequest);

}
