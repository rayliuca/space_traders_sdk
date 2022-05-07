# Markets

```csharp
MarketsController marketsController = client.MarketsController;
```

## Class Name

`MarketsController`

## Methods

* [Post-My-Ships-Ship Symbol-Deploy](../../doc/controllers/markets.md#post-my-ships-ship-symbol-deploy)
* [Get-Trade-Trade Symbol-Imports](../../doc/controllers/markets.md#get-trade-trade-symbol-imports)
* [Get-Trade-Trade Symbol-Exports](../../doc/controllers/markets.md#get-trade-trade-symbol-exports)
* [Get-Trade-Trade Symbol-Exchange](../../doc/controllers/markets.md#get-trade-trade-symbol-exchange)
* [Get-Systems-System Symbol-Markets](../../doc/controllers/markets.md#get-systems-system-symbol-markets)
* [Get-Systems-System Symbol-Markets-Waypoint Symbol](../../doc/controllers/markets.md#get-systems-system-symbol-markets-waypoint-symbol)


# Post-My-Ships-Ship Symbol-Deploy

Use this endpoint to deploy a Communications Relay to a waypoint. A waypoint with a communications relay will allow agents to retrieve price information from the market. Without a relay, agents must send a ship to a market to retrieve price information.

Communication relays can be purchased from a market that exports `COMM_RELAY_I`.

```csharp
PostMyShipsShipSymbolDeployAsync(
    string shipSymbol,
    Models.MyShipsDeployRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `shipSymbol` | `string` | Template, Required | The ship symbol |
| `body` | [`Models.MyShipsDeployRequest`](../../doc/models/my-ships-deploy-request.md) | Body, Optional | - |

## Response Type

`Task`

## Example Usage

```csharp
string shipSymbol = "shipSymbol2";

try
{
    await marketsController.PostMyShipsShipSymbolDeployAsync(shipSymbol, null);
}
catch (ApiException e){};
```


# Get-Trade-Trade Symbol-Imports

Trade Imports

```csharp
GetTradeTradeSymbolImportsAsync(
    string tradeSymbol)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `tradeSymbol` | `string` | Template, Required | The trade symbol |

## Response Type

[`Task<Models.TradeImportsResponse>`](../../doc/models/trade-imports-response.md)

## Example Usage

```csharp
string tradeSymbol = "tradeSymbol8";

try
{
    TradeImportsResponse result = await marketsController.GetTradeTradeSymbolImportsAsync(tradeSymbol);
}
catch (ApiException e){};
```


# Get-Trade-Trade Symbol-Exports

Trade Exports

```csharp
GetTradeTradeSymbolExportsAsync(
    string tradeSymbol)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `tradeSymbol` | `string` | Template, Required | The trade symbol |

## Response Type

[`Task<Models.TradeExportsResponse>`](../../doc/models/trade-exports-response.md)

## Example Usage

```csharp
string tradeSymbol = "tradeSymbol8";

try
{
    TradeExportsResponse result = await marketsController.GetTradeTradeSymbolExportsAsync(tradeSymbol);
}
catch (ApiException e){};
```


# Get-Trade-Trade Symbol-Exchange

Trade Exchanges

```csharp
GetTradeTradeSymbolExchangeAsync(
    string tradeSymbol)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `tradeSymbol` | `string` | Template, Required | The trade symbol |

## Response Type

[`Task<Models.TradeExchangeResponse>`](../../doc/models/trade-exchange-response.md)

## Example Usage

```csharp
string tradeSymbol = "tradeSymbol8";

try
{
    TradeExchangeResponse result = await marketsController.GetTradeTradeSymbolExchangeAsync(tradeSymbol);
}
catch (ApiException e){};
```


# Get-Systems-System Symbol-Markets

Retrieve a list of all charted markets in the given system. Markets are only available if the waypoint is charted and contains a communications relay.

To install a communications relay at a market, look at the `my/ships/{shipSymbol}/deploy` endpoint.

```csharp
GetSystemsSystemSymbolMarketsAsync(
    string systemSymbol)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `systemSymbol` | `string` | Template, Required | The system symbol |

## Response Type

[`Task<Models.SystemsMarketsResponse>`](../../doc/models/systems-markets-response.md)

## Example Usage

```csharp
string systemSymbol = "systemSymbol4";

try
{
    SystemsMarketsResponse result = await marketsController.GetSystemsSystemSymbolMarketsAsync(systemSymbol);
}
catch (ApiException e){};
```

## Example Response *(as JSON)*

```json
{
  "data": [
    "X1-AK3-88760F"
  ],
  "meta": {
    "total": 1,
    "page": 1,
    "limit": 20
  }
}
```


# Get-Systems-System Symbol-Markets-Waypoint Symbol

Retrieve imports, exports and exchange data from a marketplace. Imports can be sold, exports can be purchased, and exchange trades can be purchased or sold.

Market data is only available if you have a ship at the location, or the location is charted and has a communications relay deployed.

See `/my/ships/{shipSymbol}/deploy` for deploying relays at a location.

```csharp
GetSystemsSystemSymbolMarketsWaypointSymbolAsync(
    string systemSymbol,
    string waypointSymbol)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `systemSymbol` | `string` | Template, Required | The system symbol |
| `waypointSymbol` | `string` | Template, Required | The waypoint symbol |

## Response Type

[`Task<Models.SystemsMarketsResponse1>`](../../doc/models/systems-markets-response-1.md)

## Example Usage

```csharp
string systemSymbol = "systemSymbol4";
string waypointSymbol = "waypointSymbol2";

try
{
    SystemsMarketsResponse1 result = await marketsController.GetSystemsSystemSymbolMarketsWaypointSymbolAsync(systemSymbol, waypointSymbol);
}
catch (ApiException e){};
```

## Example Response *(as JSON)*

```json
{
  "data": {
    "exports": [
      {
        "waypointSymbol": "X1-OE-PM",
        "tradeSymbol": "MICROPROCESSORS",
        "price": 834,
        "tariff": 0
      }
    ],
    "imports": [
      {
        "waypointSymbol": "X1-OE-PM",
        "tradeSymbol": "SILICON",
        "price": 144,
        "tariff": 0
      },
      {
        "waypointSymbol": "X1-OE-PM",
        "tradeSymbol": "QUARTZ",
        "price": 286,
        "tariff": 0
      }
    ],
    "exchange": []
  }
}
```

