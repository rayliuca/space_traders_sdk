# Markets

```python
markets_controller = client.markets
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

```python
def post_my_ships_ship_symbol_deploy(self,
                                    ship_symbol,
                                    body=None)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ship_symbol` | `string` | Template, Required | The ship symbol |
| `body` | [`MyShipsDeployRequest`](../../doc/models/my-ships-deploy-request.md) | Body, Optional | - |

## Response Type

`void`

## Example Usage

```python
ship_symbol = 'shipSymbol2'

result = markets_controller.post_my_ships_ship_symbol_deploy(ship_symbol)
```


# Get-Trade-Trade Symbol-Imports

Trade Imports

```python
def get_trade_trade_symbol_imports(self,
                                  trade_symbol)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `trade_symbol` | `string` | Template, Required | The trade symbol |

## Response Type

[`TradeImportsResponse`](../../doc/models/trade-imports-response.md)

## Example Usage

```python
trade_symbol = 'tradeSymbol8'

result = markets_controller.get_trade_trade_symbol_imports(trade_symbol)
```


# Get-Trade-Trade Symbol-Exports

Trade Exports

```python
def get_trade_trade_symbol_exports(self,
                                  trade_symbol)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `trade_symbol` | `string` | Template, Required | The trade symbol |

## Response Type

[`TradeExportsResponse`](../../doc/models/trade-exports-response.md)

## Example Usage

```python
trade_symbol = 'tradeSymbol8'

result = markets_controller.get_trade_trade_symbol_exports(trade_symbol)
```


# Get-Trade-Trade Symbol-Exchange

Trade Exchanges

```python
def get_trade_trade_symbol_exchange(self,
                                   trade_symbol)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `trade_symbol` | `string` | Template, Required | The trade symbol |

## Response Type

[`TradeExchangeResponse`](../../doc/models/trade-exchange-response.md)

## Example Usage

```python
trade_symbol = 'tradeSymbol8'

result = markets_controller.get_trade_trade_symbol_exchange(trade_symbol)
```


# Get-Systems-System Symbol-Markets

Retrieve a list of all charted markets in the given system. Markets are only available if the waypoint is charted and contains a communications relay.

To install a communications relay at a market, look at the `my/ships/{shipSymbol}/deploy` endpoint.

```python
def get_systems_system_symbol_markets(self,
                                     system_symbol)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `system_symbol` | `string` | Template, Required | The system symbol |

## Response Type

[`SystemsMarketsResponse`](../../doc/models/systems-markets-response.md)

## Example Usage

```python
system_symbol = 'systemSymbol4'

result = markets_controller.get_systems_system_symbol_markets(system_symbol)
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

```python
def get_systems_system_symbol_markets_waypoint_symbol(self,
                                                     system_symbol,
                                                     waypoint_symbol)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `system_symbol` | `string` | Template, Required | The system symbol |
| `waypoint_symbol` | `string` | Template, Required | The waypoint symbol |

## Response Type

[`SystemsMarketsResponse1`](../../doc/models/systems-markets-response-1.md)

## Example Usage

```python
system_symbol = 'systemSymbol4'
waypoint_symbol = 'waypointSymbol2'

result = markets_controller.get_systems_system_symbol_markets_waypoint_symbol(system_symbol, waypoint_symbol)
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

