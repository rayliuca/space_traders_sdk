# Shipyards

```php
$shipyardsController = $client->getShipyardsController();
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

```php
function postMyShips(?MyShipsRequest $body = null): MyShipsResponse2
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`?MyShipsRequest`](../../doc/models/my-ships-request.md) | Body, Optional | - |

## Response Type

[`MyShipsResponse2`](../../doc/models/my-ships-response-2.md)

## Example Usage

```php
$result = $shipyardsController->postMyShips();
```


# Get-Systems-System Symbol-Shipyards

Returns a list of all shipyards in a system.

```php
function getSystemsSystemSymbolShipyards(string $systemSymbol): SystemsShipyardsResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `systemSymbol` | `string` | Template, Required | the system symbol |

## Response Type

[`SystemsShipyardsResponse`](../../doc/models/systems-shipyards-response.md)

## Example Usage

```php
$systemSymbol = 'systemSymbol4';

$result = $shipyardsController->getSystemsSystemSymbolShipyards($systemSymbol);
```


# Get-Systems-System Symbol-Shipyards-Waypoint Symbol

Shipyard Details

```php
function getSystemsSystemSymbolShipyardsWaypointSymbol(
    string $systemSymbol,
    string $waypointSymbol
): SystemsShipyardsResponse1
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `systemSymbol` | `string` | Template, Required | The system symbol |
| `waypointSymbol` | `string` | Template, Required | The waypoint symbol |

## Response Type

[`SystemsShipyardsResponse1`](../../doc/models/systems-shipyards-response-1.md)

## Example Usage

```php
$systemSymbol = 'systemSymbol4';
$waypointSymbol = 'waypointSymbol2';

$result = $shipyardsController->getSystemsSystemSymbolShipyardsWaypointSymbol($systemSymbol, $waypointSymbol);
```


# Get-Systems-System Symbol-Shipyards-Waypoint Symbol-Ships

Shipyard Listings

```php
function getSystemsSystemSymbolShipyardsWaypointSymbolShips(
    string $systemSymbol,
    string $waypointSymbol
): SystemsShipyardsShipsResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `systemSymbol` | `string` | Template, Required | The system symbol |
| `waypointSymbol` | `string` | Template, Required | The waypoint symbol |

## Response Type

[`SystemsShipyardsShipsResponse`](../../doc/models/systems-shipyards-ships-response.md)

## Example Usage

```php
$systemSymbol = 'systemSymbol4';
$waypointSymbol = 'waypointSymbol2';

$result = $shipyardsController->getSystemsSystemSymbolShipyardsWaypointSymbolShips($systemSymbol, $waypointSymbol);
```

