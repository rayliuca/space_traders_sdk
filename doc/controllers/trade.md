# Trade

```csharp
TradeController tradeController = client.TradeController;
```

## Class Name

`TradeController`

## Methods

* [Post-My-Ships-Ship Symbol-Purchase](../../doc/controllers/trade.md#post-my-ships-ship-symbol-purchase)
* [Post-My-Ships-Ship Symbol-Sell](../../doc/controllers/trade.md#post-my-ships-ship-symbol-sell)


# Post-My-Ships-Ship Symbol-Purchase

Purchase Cargo

```csharp
PostMyShipsShipSymbolPurchaseAsync(
    string shipSymbol,
    Models.MyShipsPurchaseRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `shipSymbol` | `string` | Template, Required | - |
| `body` | [`Models.MyShipsPurchaseRequest`](../../doc/models/my-ships-purchase-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.MyShipsPurchaseResponse>`](../../doc/models/my-ships-purchase-response.md)

## Example Usage

```csharp
string shipSymbol = "shipSymbol2";

try
{
    MyShipsPurchaseResponse result = await tradeController.PostMyShipsShipSymbolPurchaseAsync(shipSymbol, null);
}
catch (ApiException e){};
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

```csharp
PostMyShipsShipSymbolSellAsync(
    string shipSymbol,
    Models.MyShipsSellRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `shipSymbol` | `string` | Template, Required | - |
| `body` | [`Models.MyShipsSellRequest`](../../doc/models/my-ships-sell-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.MyShipsSellResponse>`](../../doc/models/my-ships-sell-response.md)

## Example Usage

```csharp
string shipSymbol = "shipSymbol2";

try
{
    MyShipsSellResponse result = await tradeController.PostMyShipsShipSymbolSellAsync(shipSymbol, null);
}
catch (ApiException e){};
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

