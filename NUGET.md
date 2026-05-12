# Apigen.TransIp

Generated C# client for the [TransIP REST API v6](https://api.transip.nl/rest/docs.html).

## Installation

```bash
dotnet add package Apigen.TransIp.Client
```

## Quick start

```csharp
using Apigen.TransIp.Client;

string privateKeyPem = File.ReadAllText("transip.pem");

// Singleton-friendly: returns a TransIpApiClient whose HttpClient
// automatically acquires & refreshes JWTs.
TransIpApiClient client = TransIpAuthTokenProvider.CreateClient(
    login: "your-username",
    privateKeyPem: privateKeyPem,
    label: "my-app");

var domains = await client.Domains.ListAllDomainsAsync();
```

## Custom `HttpClient` pipeline

```csharp
TransIpTokenAccessor accessor = TransIpAuthTokenProvider.CreateAccessor(login, privateKeyPem);

HttpClient http = new(new TransIpBearerHandler(accessor, new HttpClientHandler()))
{
    BaseAddress = new Uri("https://api.transip.nl/v6/"),
};
var client = new TransIpApiClient(http);
```

## Bring your own token storage

`TransIpTokenAccessor` is a delegate — implement it to persist the JWT wherever
you like (file, database, Vault, etc.). Default storage is in-memory only.

## With a pre-obtained Bearer token

```csharp
var client = TransIpApiClient.WithBearer("eyJ0eXAi...");
```

## Authentication options

`CreateClient`, `CreateAccessor`, and `GetBearerTokenAsync` accept:

- `login` — your TransIP account name
- `privateKeyPem` — the PKCS#8 PEM key obtained from the control panel
- `label` — token label (must be unique per active token; auto-generated if omitted)
- `readOnly` — request a read-only token (default `false`)
- `expirationTime` — e.g. `"30 minutes"`, `"1 hour"`, `"1 day"` (default `"1 day"`)
- `globalKey` — allow use from any IP address (default `false`)
- `baseUrl` — override the API base URL
- `refreshBefore` — re-auth this far before expiry (default 5 minutes)

## Versioning

Package versions follow the upstream API version: the **major.minor** matches
the TransIP API version, and the **patch** is our client revision. For example,
package `6.53.0` was built against API version `6.53.x`.

## License

MIT
