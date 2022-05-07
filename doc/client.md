
# Client Class Documentation

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| `httpClientConfig` | `ReadonlyHttpClientConfiguration` | Http Client Configuration instance. |
| `accessToken` | `String` | The OAuth 2.0 Access Token to use for API requests. |

The API client can be initialized as follows:

```java
SpaceTradersAPIClient client = new SpaceTradersAPIClient.Builder()
    .httpClientConfig(configBuilder -> configBuilder
            .timeout(0))
    .accessToken("AccessToken")
    .build();
```

## SpaceTraders APIClient Class

The gateway for the SDK. This class acts as a factory for the Controllers and also holds the configuration of the SDK.

### Controllers

| Name | Description | Return Type |
|  --- | --- | --- |
| `getShipsController()` | Provides access to Ships controller. | `ShipsController` |
| `getMarketsController()` | Provides access to Markets controller. | `MarketsController` |
| `getTradeController()` | Provides access to Trade controller. | `TradeController` |
| `getNavigationController()` | Provides access to Navigation controller. | `NavigationController` |
| `getAgentsController()` | Provides access to Agents controller. | `AgentsController` |
| `getContractsController()` | Provides access to Contracts controller. | `ContractsController` |
| `getExtractController()` | Provides access to Extract controller. | `ExtractController` |
| `getSystemsController()` | Provides access to Systems controller. | `SystemsController` |
| `getShipyardsController()` | Provides access to Shipyards controller. | `ShipyardsController` |

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `shutdown()` | Shutdown the underlying HttpClient instance. | `void` |
| `getEnvironment()` | Current API environment. | `Environment` |
| `getHttpClient()` | The HTTP Client instance to use for making HTTP requests. | `HttpClient` |
| `getHttpClientConfig()` | Http Client Configuration instance. | `ReadonlyHttpClientConfiguration` |
| `getBearerAuthCredentials()` | The credentials to use with BearerAuth. | `BearerAuthCredentials` |
| `getAccessToken()` | OAuth 2.0 Access Token. | `String` |
| `getBaseUri(Server server)` | Get base URI by current environment | `String` |
| `getBaseUri()` | Get base URI by current environment | `String` |

