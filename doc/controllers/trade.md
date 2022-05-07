# Trade

```java
TradeController tradeController = client.getTradeController();
```

## Class Name

`TradeController`

## Methods

* [Post-My-Ships-Ship Symbol-Purchase](../../doc/controllers/trade.md#post-my-ships-ship-symbol-purchase)
* [Post-My-Ships-Ship Symbol-Sell](../../doc/controllers/trade.md#post-my-ships-ship-symbol-sell)


# Post-My-Ships-Ship Symbol-Purchase

Purchase Cargo

```java
CompletableFuture<MyShipsPurchaseResponse> postMyShipsShipSymbolPurchaseAsync(
    final String shipSymbol,
    final MyShipsPurchaseRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `shipSymbol` | `String` | Template, Required | - |
| `body` | [`MyShipsPurchaseRequest`](../../doc/models/my-ships-purchase-request.md) | Body, Optional | - |

## Response Type

[`MyShipsPurchaseResponse`](../../doc/models/my-ships-purchase-response.md)

## Example Usage

```java
String shipSymbol = "shipSymbol2";

tradeController.postMyShipsShipSymbolPurchaseAsync(shipSymbol, null).thenAccept(result -> {
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
    "waypointSymbol": "X1-OE-PM",
    "tradeSymbol": "MICROPROCESSORS",
    "credits": -843,
    "units": 1
  }
}
```


# Post-My-Ships-Ship Symbol-Sell

Sell cargo from your ship's hold to the local market.

```java
CompletableFuture<MyShipsSellResponse> postMyShipsShipSymbolSellAsync(
    final String shipSymbol,
    final MyShipsSellRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `shipSymbol` | `String` | Template, Required | - |
| `body` | [`MyShipsSellRequest`](../../doc/models/my-ships-sell-request.md) | Body, Optional | - |

## Response Type

[`MyShipsSellResponse`](../../doc/models/my-ships-sell-response.md)

## Example Usage

```java
String shipSymbol = "shipSymbol2";

tradeController.postMyShipsShipSymbolSellAsync(shipSymbol, null).thenAccept(result -> {
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
    "waypointSymbol": "X1-OE-PM",
    "tradeSymbol": "SILICON",
    "credits": 144,
    "units": -1
  }
}
```

