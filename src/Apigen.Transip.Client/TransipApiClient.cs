using System;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using Apigen.Transip.Models;
using Microsoft.Extensions.Logging;

#nullable enable

namespace Apigen.Transip.Client;

/// <summary>
/// Main API client for accessing all resources
/// </summary>
public class TransipApiClient
{
  private readonly HttpClient _httpClient;
  private readonly bool _disposeHttpClient;
  private readonly ILogger? _logger;

  /// <summary>
  /// Client for Acronis operations
  /// </summary>
  public AcronisClient Acronis { get; }

  /// <summary>
  /// Client for Actions operations
  /// </summary>
  public ActionsClient Actions { get; }

  /// <summary>
  /// Client for General operations
  /// </summary>
  public GeneralClient General { get; }

  /// <summary>
  /// Client for VPS operations
  /// </summary>
  public VpsClient Vps { get; }

  /// <summary>
  /// Client for Colocations operations
  /// </summary>
  public ColocationsClient Colocations { get; }

  /// <summary>
  /// Client for Account operations
  /// </summary>
  public AccountClient Account { get; }

  /// <summary>
  /// Client for Domains operations
  /// </summary>
  public DomainsClient Domains { get; }

  /// <summary>
  /// Client for Email operations
  /// </summary>
  public EmailClient Email { get; }

  /// <summary>
  /// Client for Filehosting operations
  /// </summary>
  public FilehostingClient Filehosting { get; }

  /// <summary>
  /// Client for HA-IP operations
  /// </summary>
  public HaipClient Haip { get; }

  /// <summary>
  /// Client for Kubernetes operations
  /// </summary>
  public KubernetesClient Kubernetes { get; }

  /// <summary>
  /// Client for OpenStack operations
  /// </summary>
  public OpenStackClient OpenStack { get; }

  /// <summary>
  /// Client for SSL Certificates operations
  /// </summary>
  public SslCertificatesClient SslCertificates { get; }

  /// <summary>
  /// Initialize client with a pre-configured HttpClient
  /// </summary>
  /// <param name="httpClient">Pre-configured HttpClient with base address, auth headers, etc.</param>
  /// <param name="logger">Optional logger for request/response logging</param>
  public TransipApiClient(HttpClient httpClient, ILogger? logger = null)
  {
    _httpClient = httpClient;
    _disposeHttpClient = false;
    _logger = logger;

    Acronis = new AcronisClient(_httpClient, _logger);
    Actions = new ActionsClient(_httpClient, _logger);
    General = new GeneralClient(_httpClient, _logger);
    Vps = new VpsClient(_httpClient, _logger);
    Colocations = new ColocationsClient(_httpClient, _logger);
    Account = new AccountClient(_httpClient, _logger);
    Domains = new DomainsClient(_httpClient, _logger);
    Email = new EmailClient(_httpClient, _logger);
    Filehosting = new FilehostingClient(_httpClient, _logger);
    Haip = new HaipClient(_httpClient, _logger);
    Kubernetes = new KubernetesClient(_httpClient, _logger);
    OpenStack = new OpenStackClient(_httpClient, _logger);
    SslCertificates = new SslCertificatesClient(_httpClient, _logger);
  }

  private TransipApiClient(HttpClient httpClient, bool disposeHttpClient, ILogger? logger)
  {
    _httpClient = httpClient;
    _disposeHttpClient = disposeHttpClient;
    _logger = logger;

    Acronis = new AcronisClient(_httpClient, _logger);
    Actions = new ActionsClient(_httpClient, _logger);
    General = new GeneralClient(_httpClient, _logger);
    Vps = new VpsClient(_httpClient, _logger);
    Colocations = new ColocationsClient(_httpClient, _logger);
    Account = new AccountClient(_httpClient, _logger);
    Domains = new DomainsClient(_httpClient, _logger);
    Email = new EmailClient(_httpClient, _logger);
    Filehosting = new FilehostingClient(_httpClient, _logger);
    Haip = new HaipClient(_httpClient, _logger);
    Kubernetes = new KubernetesClient(_httpClient, _logger);
    OpenStack = new OpenStackClient(_httpClient, _logger);
    SslCertificates = new SslCertificatesClient(_httpClient, _logger);
  }

  /// <summary>
  /// Create client with Bearer token authentication
  /// </summary>
  public static TransipApiClient WithBearer(string bearerToken, string baseUrl = "https://api.transip.nl/v6", ILogger? logger = null)
  {
    HttpClient httpClient = CreateTokenAuthHttpClient(bearerToken, baseUrl, "Authorization", true);
    return new TransipApiClient(httpClient, true, logger);
  }

  private static HttpClient CreateTokenAuthHttpClient(string apiToken, string baseUrl, string headerName, bool useBearer)
  {
    // Ensure baseUrl ends with / for proper Uri combining with relative paths
    string normalizedBaseUrl = baseUrl.EndsWith("/") ? baseUrl : baseUrl + "/";
    HttpClient client = new() { BaseAddress = new Uri(normalizedBaseUrl) };

    if (useBearer)
    {
      client.DefaultRequestHeaders.Add(headerName, $"Bearer {apiToken}");
    }
    else
    {
      client.DefaultRequestHeaders.Add(headerName, apiToken);
    }

    return client;
  }

  private static HttpClient CreateBasicAuthHttpClient(string username, string password, string baseUrl)
  {
    // Ensure baseUrl ends with / for proper Uri combining with relative paths
    string normalizedBaseUrl = baseUrl.EndsWith("/") ? baseUrl : baseUrl + "/";
    HttpClient client = new() { BaseAddress = new Uri(normalizedBaseUrl) };

    string credentials = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes($"{username}:{password}"));
    client.DefaultRequestHeaders.Add("Authorization", $"Basic {credentials}");

    return client;
  }

  private static HttpClient CreateCookieAuthHttpClient(string token, string cookieName, string baseUrl)
  {
    string normalizedBaseUrl = baseUrl.EndsWith("/") ? baseUrl : baseUrl + "/";
    System.Net.CookieContainer cookies = new();
    cookies.Add(new Uri(normalizedBaseUrl), new System.Net.Cookie(cookieName, token));
    HttpClientHandler handler = new() { CookieContainer = cookies };
    HttpClient client = new(handler) { BaseAddress = new Uri(normalizedBaseUrl) };

    return client;
  }

  /// <summary>
  /// Dispose resources
  /// </summary>
  public void Dispose()
  {
    if (_disposeHttpClient)
    {
      _httpClient?.Dispose();
    }
  }
}
