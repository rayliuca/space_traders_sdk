# Trade

```php
$tradeController = $client->getTradeController();
```

## Class Name

`TradeController`

## Methods

* [Post-My-Ships-Ship Symbol-Purchase](../../doc/controllers/trade.md#post-my-ships-ship-symbol-purchase)
* [Post-My-Ships-Ship Symbol-Sell](../../doc/controllers/trade.md#post-my-ships-ship-symbol-sell)


# Post-My-Ships-Ship Symbol-Purchase

Purchase Cargo

```php
function postMyShipsShipSymbolPurchase(
    string $shipSymbol,
    ?MyShipsPurchaseRequest $body = null
): MyShipsPurchaseResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `shipSymbol` | `string` | Template, Required | - |
| `body` | [`?MyShipsPurchaseRequest`](../../doc/models/my-ships-purchase-request.md) | Body, Optional | - |

## Response Type

[`MyShipsPurchaseResponse`](../../doc/models/my-ships-purchase-response.md)

## Example Usage

```php
$shipSymbol = 'shipSymbol2';

$result = $tradeController->postMyShipsShipSymbolPurchase($shipSymbol);
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

```php
function postMyShipsShipSymbolSell(string $shipSymbol, ?MyShipsSellRequest $body = null): MyShipsSellResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `shipSymbol` | `string` | Template, Required | - |
| `body` | [`?MyShipsSellRequest`](../../doc/models/my-ships-sell-request.md) | Body, Optional | - |

## Response Type

[`MyShipsSellResponse`](../../doc/models/my-ships-sell-response.md)

## Example Usage

```php
$shipSymbol = 'shipSymbol2';

$result = $tradeController->postMyShipsShipSymbolSell($shipSymbol);
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

