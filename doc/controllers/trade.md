# Trade

```python
trade_controller = client.trade
```

## Class Name

`TradeController`

## Methods

* [Post-My-Ships-Ship Symbol-Purchase](../../doc/controllers/trade.md#post-my-ships-ship-symbol-purchase)
* [Post-My-Ships-Ship Symbol-Sell](../../doc/controllers/trade.md#post-my-ships-ship-symbol-sell)


# Post-My-Ships-Ship Symbol-Purchase

Purchase Cargo

```python
def post_my_ships_ship_symbol_purchase(self,
                                      ship_symbol,
                                      body=None)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ship_symbol` | `string` | Template, Required | - |
| `body` | [`MyShipsPurchaseRequest`](../../doc/models/my-ships-purchase-request.md) | Body, Optional | - |

## Response Type

[`MyShipsPurchaseResponse`](../../doc/models/my-ships-purchase-response.md)

## Example Usage

```python
ship_symbol = 'shipSymbol2'

result = trade_controller.post_my_ships_ship_symbol_purchase(ship_symbol)
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

```python
def post_my_ships_ship_symbol_sell(self,
                                  ship_symbol,
                                  body=None)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ship_symbol` | `string` | Template, Required | - |
| `body` | [`MyShipsSellRequest`](../../doc/models/my-ships-sell-request.md) | Body, Optional | - |

## Response Type

[`MyShipsSellResponse`](../../doc/models/my-ships-sell-response.md)

## Example Usage

```python
ship_symbol = 'shipSymbol2'

result = trade_controller.post_my_ships_ship_symbol_sell(ship_symbol)
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

