# Markets

```java
MarketsController marketsController = client.getMarketsController();
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

```java
CompletableFuture<Void> postMyShipsShipSymbolDeployAsync(
    final String shipSymbol,
    final MyShipsDeployRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `shipSymbol` | `String` | Template, Required | The ship symbol |
| `body` | [`MyShipsDeployRequest`](../../doc/models/my-ships-deploy-request.md) | Body, Optional | - |

## Response Type

`void`

## Example Usage

```java
String shipSymbol = "shipSymbol2";

marketsController.postMyShipsShipSymbolDeployAsync(shipSymbol, null).thenAccept(result -> {
    // TODO success callback handler
}).exceptionally(exception -> {
    // TODO failure callback handler
    return null;
});
```


# Get-Trade-Trade Symbol-Imports

Trade Imports

```java
CompletableFuture<TradeImportsResponse> getTradeTradeSymbolImportsAsync(
    final String tradeSymbol)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `tradeSymbol` | `String` | Template, Required | The trade symbol |

## Response Type

[`TradeImportsResponse`](../../doc/models/trade-imports-response.md)

## Example Usage

```java
String tradeSymbol = "tradeSymbol8";

marketsController.getTradeTradeSymbolImportsAsync(tradeSymbol).thenAccept(result -> {
    // TODO success callback handler
}).exceptionally(exception -> {
    // TODO failure callback handler
    return null;
});
```


# Get-Trade-Trade Symbol-Exports

Trade Exports

```java
CompletableFuture<TradeExportsResponse> getTradeTradeSymbolExportsAsync(
    final String tradeSymbol)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `tradeSymbol` | `String` | Template, Required | The trade symbol |

## Response Type

[`TradeExportsResponse`](../../doc/models/trade-exports-response.md)

## Example Usage

```java
String tradeSymbol = "tradeSymbol8";

marketsController.getTradeTradeSymbolExportsAsync(tradeSymbol).thenAccept(result -> {
    // TODO success callback handler
}).exceptionally(exception -> {
    // TODO failure callback handler
    return null;
});
```


# Get-Trade-Trade Symbol-Exchange

Trade Exchanges

```java
CompletableFuture<TradeExchangeResponse> getTradeTradeSymbolExchangeAsync(
    final String tradeSymbol)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `tradeSymbol` | `String` | Template, Required | The trade symbol |

## Response Type

[`TradeExchangeResponse`](../../doc/models/trade-exchange-response.md)

## Example Usage

```java
String tradeSymbol = "tradeSymbol8";

marketsController.getTradeTradeSymbolExchangeAsync(tradeSymbol).thenAccept(result -> {
    // TODO success callback handler
}).exceptionally(exception -> {
    // TODO failure callback handler
    return null;
});
```


# Get-Systems-System Symbol-Markets

Retrieve a list of all charted markets in the given system. Markets are only available if the waypoint is charted and contains a communications relay.

To install a communications relay at a market, look at the `my/ships/{shipSymbol}/deploy` endpoint.

```java
CompletableFuture<SystemsMarketsResponse> getSystemsSystemSymbolMarketsAsync(
    final String systemSymbol)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `systemSymbol` | `String` | Template, Required | The system symbol |

## Response Type

[`SystemsMarketsResponse`](../../doc/models/systems-markets-response.md)

## Example Usage

```java
String systemSymbol = "systemSymbol4";

marketsController.getSystemsSystemSymbolMarketsAsync(systemSymbol).thenAccept(result -> {
    // TODO success callback handler
}).exceptionally(exception -> {
    // TODO failure callback handler
    return null;
});
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

```java
CompletableFuture<SystemsMarketsResponse1> getSystemsSystemSymbolMarketsWaypointSymbolAsync(
    final String systemSymbol,
    final String waypointSymbol)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `systemSymbol` | `String` | Template, Required | The system symbol |
| `waypointSymbol` | `String` | Template, Required | The waypoint symbol |

## Response Type

[`SystemsMarketsResponse1`](../../doc/models/systems-markets-response-1.md)

## Example Usage

```java
String systemSymbol = "systemSymbol4";
String waypointSymbol = "waypointSymbol2";

marketsController.getSystemsSystemSymbolMarketsWaypointSymbolAsync(systemSymbol, waypointSymbol).thenAccept(result -> {
    // TODO success callback handler
}).exceptionally(exception -> {
    // TODO failure callback handler
    return null;
});
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

