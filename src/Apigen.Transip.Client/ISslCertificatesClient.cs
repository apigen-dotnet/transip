using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Transip.Models;

#nullable enable

namespace Apigen.Transip.Client;

/// <summary>
/// Interface for SSL Certificates operations
/// </summary>
public interface ISslCertificatesClient
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
  Task OrderASslCertificateAsync(Apigen.Transip.Models.OrderASslCertificateRequest orderASslCertificateRequest);

  /// <summary>
  /// Get SSL certificate by id
  /// Operation: GET /ssl-certificates/{certificateId}
  /// </summary>
  Task<JsonElement> GetAsync(decimal certificateId);

  /// <summary>
  /// Reissue a certificate
  /// Operation: PATCH /ssl-certificates/{certificateId}
  /// </summary>
  Task ReissueACertificateAsync(decimal certificateId, Apigen.Transip.Models.ReissueACertificateRequest reissueACertificateRequest);

  /// <summary>
  /// Details for SSL certificate by id
  /// Operation: GET /ssl-certificates/{certificateId}/details
  /// </summary>
  Task<JsonElement> DetailsForSslCertificateByIdAsync(decimal certificateId);

  /// <summary>
  /// Download a SSL certificate by id
  /// Operation: POST /ssl-certificates/{certificateId}/download
  /// </summary>
  Task<JsonElement> DownloadASslCertificateByIdAsync(decimal certificateId, Apigen.Transip.Models.DownloadASslCertificateByIdRequest downloadASslCertificateByIdRequest);

  /// <summary>
  /// Install an ssl certificate
  /// Operation: PATCH /ssl-certificates/{certificateId}/install
  /// </summary>
  Task InstallAnSslCertificateAsync(decimal certificateId, Apigen.Transip.Models.InstallAnSslCertificateRequest installAnSslCertificateRequest);

  /// <summary>
  /// Uninstall an ssl certificate
  /// Operation: DELETE /ssl-certificates/{certificateId}/uninstall
  /// </summary>
  Task UninstallAnSslCertificateAsync(decimal certificateId, Apigen.Transip.Models.UninstallAnSslCertificateRequest uninstallAnSslCertificateRequest);

}
