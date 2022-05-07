# Shipyards

```python
shipyards_controller = client.shipyards
```

## Class Name

`ShipyardsController`

## Methods

* [Post-My-Ships](../../doc/controllers/shipyards.md#post-my-ships)
* [Get-Systems-System Symbol-Shipyards](../../doc/controllers/shipyards.md#get-systems-system-symbol-shipyards)
* [Get-Systems-System Symbol-Shipyards-Waypoint Symbol](../../doc/controllers/shipyards.md#get-systems-system-symbol-shipyards-waypoint-symbol)
* [Get-Systems-System Symbol-Shipyards-Waypoint Symbol-Ships](../../doc/controllers/shipyards.md#get-systems-system-symbol-shipyards-waypoint-symbol-ships)


# Post-My-Ships

Purchase a ship

```python
def post_my_ships(self,
                 body=None)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`MyShipsRequest`](../../doc/models/my-ships-request.md) | Body, Optional | - |

## Response Type

[`MyShipsResponse2`](../../doc/models/my-ships-response-2.md)

## Example Usage

```python
result = shipyards_controller.post_my_ships()
```


# Get-Systems-System Symbol-Shipyards

Returns a list of all shipyards in a system.

```python
def get_systems_system_symbol_shipyards(self,
                                       system_symbol)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `system_symbol` | `string` | Template, Required | the system symbol |

## Response Type

[`SystemsShipyardsResponse`](../../doc/models/systems-shipyards-response.md)

## Example Usage

```python
system_symbol = 'systemSymbol4'

result = shipyards_controller.get_systems_system_symbol_shipyards(system_symbol)
```


# Get-Systems-System Symbol-Shipyards-Waypoint Symbol

Shipyard Details

```python
def get_systems_system_symbol_shipyards_waypoint_symbol(self,
                                                       system_symbol,
                                                       waypoint_symbol)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `system_symbol` | `string` | Template, Required | The system symbol |
| `waypoint_symbol` | `string` | Template, Required | The waypoint symbol |

## Response Type

[`SystemsShipyardsResponse1`](../../doc/models/systems-shipyards-response-1.md)

## Example Usage

```python
system_symbol = 'systemSymbol4'
waypoint_symbol = 'waypointSymbol2'

result = shipyards_controller.get_systems_system_symbol_shipyards_waypoint_symbol(system_symbol, waypoint_symbol)
```


# Get-Systems-System Symbol-Shipyards-Waypoint Symbol-Ships

Shipyard Listings

```python
def get_systems_system_symbol_shipyards_waypoint_symbol_ships(self,
                                                             system_symbol,
                                                             waypoint_symbol)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `system_symbol` | `string` | Template, Required | The system symbol |
| `waypoint_symbol` | `string` | Template, Required | The waypoint symbol |

## Response Type

[`SystemsShipyardsShipsResponse`](../../doc/models/systems-shipyards-ships-response.md)

## Example Usage

```python
system_symbol = 'systemSymbol4'
waypoint_symbol = 'waypointSymbol2'

result = shipyards_controller.get_systems_system_symbol_shipyards_waypoint_symbol_ships(system_symbol, waypoint_symbol)
```

