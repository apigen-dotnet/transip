# Changelog

## [6.53.1] - 2026-05-12

- **Package renamed** from `Apigen.Transip.Client` to `Apigen.TransIp.Client`
- Namespaces and class names migrated to `TransIp` casing (`TransIpApiClient`,
  `TransIpBearerHandler`, `TransIpTokenAccessor`, `TransIpAuthTokenProvider`,
  `TransIpAuthException`)
- The old `Apigen.Transip.Client` package is deprecated; update your reference
  to `Apigen.TransIp.Client`

## [6.53.0] - 2026-05-05

- Initial release
- Generated C# client for TransIP REST API v6
- Bearer token authentication
- Hand-written `TransIpAuthTokenProvider` for private-key JWT exchange (no third-party crypto)
