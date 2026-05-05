# Apigen.Transip

Generated C# client for the [TransIP REST API v6](https://api.transip.nl/rest/docs.html).

## Installation

```bash
dotnet add package Apigen.Transip.Client
```

## Usage

### With a private key (recommended)

`TransipAuthTokenProvider` signs an authentication request with your private key
and exchanges it for a short-lived JWT (no third-party crypto dependencies).

```csharp
using Apigen.Transip.Client;

var privateKeyPem = File.ReadAllText("transip.pem");

var client = await TransipAuthTokenProvider.CreateClientAsync(
    login: "your-username",
    privateKeyPem: privateKeyPem,
    label: "my-app");
```

### With a pre-obtained Bearer token

```csharp
var client = TransipApiClient.WithBearer("eyJ0eXAi...");
```

### With a pre-configured HttpClient

```csharp
var client = new TransipApiClient(httpClient);
```

## Authentication options

`TransipAuthTokenProvider.CreateClientAsync` / `GetBearerTokenAsync` accept:

- `login` — your TransIP account name
- `privateKeyPem` — the PKCS#8 PEM key obtained from the control panel
- `label` — token label (must be unique per active token; auto-generated if omitted)
- `readOnly` — request a read-only token (default `false`)
- `expirationTime` — e.g. `"30 minutes"`, `"1 hour"`, `"1 day"` (default `"30 minutes"`)
- `globalKey` — allow use from any IP address (default `false`)
- `baseUrl` — override the API base URL

## Versioning

Package versions follow the upstream API version: the **major.minor** matches the
TransIP API version, and the **patch** is our client revision. For example,
package `6.53.0` was built against API version `6.53.x`.

## License

MIT
