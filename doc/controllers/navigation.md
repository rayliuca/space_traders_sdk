# Navigation

```php
$navigationController = $client->getNavigationController();
```

## Class Name

`NavigationController`

## Methods

* [Post-My-Ships-Ship Symbol-Dock](../../doc/controllers/navigation.md#post-my-ships-ship-symbol-dock)
* [Post-My-Ships-Ship Symbol-Orbit](../../doc/controllers/navigation.md#post-my-ships-ship-symbol-orbit)
* [Post-My-Ships-Ship Symbol-Jump](../../doc/controllers/navigation.md#post-my-ships-ship-symbol-jump)
* [Get-My-Ships-Ship Symbol-Jump](../../doc/controllers/navigation.md#get-my-ships-ship-symbol-jump)
* [Post-My-Ships-Ship Symbol-Refuel](../../doc/controllers/navigation.md#post-my-ships-ship-symbol-refuel)
* [Post-My-Ships-Ship Symbol-Navigate](../../doc/controllers/navigation.md#post-my-ships-ship-symbol-navigate)
* [Get-My-Ships-Ship Symbol-Navigate](../../doc/controllers/navigation.md#get-my-ships-ship-symbol-navigate)


# Post-My-Ships-Ship Symbol-Dock

Transition your ship from orbit to docked. Consecutive calls to this endpoint will succeed.

```php
function postMyShipsShipSymbolDock(string $shipSymbol): MyShipsDockResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `shipSymbol` | `string` | Template, Required | The symbol of the ship |

## Response Type

[`MyShipsDockResponse`](../../doc/models/my-ships-dock-response.md)

## Example Usage

```php
$shipSymbol = 'shipSymbol2';

$result = $navigationController->postMyShipsShipSymbolDock($shipSymbol);
```

## Example Response *(as JSON)*

```json
{
  "data": {
    "status": "DOCKED"
  }
}
```


# Post-My-Ships-Ship Symbol-Orbit

Transition your ship from docked into orbit. Ships are placed into orbit by default when arriving at a destination. Consecutive calls to this endpoint will continue to return a 200 response status.

```php
function postMyShipsShipSymbolOrbit(string $shipSymbol): MyShipsOrbitResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `shipSymbol` | `string` | Template, Required | The symbol of the ship |

## Response Type

[`MyShipsOrbitResponse`](../../doc/models/my-ships-orbit-response.md)

## Example Usage

```php
$shipSymbol = 'shipSymbol2';

$result = $navigationController->postMyShipsShipSymbolOrbit($shipSymbol);
```

## Example Response *(as JSON)*

```json
{
  "data": {
    "status": "ORBIT"
  }
}
```


# Post-My-Ships-Ship Symbol-Jump

Jump Ship

```php
function postMyShipsShipSymbolJump(string $shipSymbol, ?MyShipsJumpRequest $body = null): MyShipsJumpResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `shipSymbol` | `string` | Template, Required | - |
| `body` | [`?MyShipsJumpRequest`](../../doc/models/my-ships-jump-request.md) | Body, Optional | - |

## Response Type

[`MyShipsJumpResponse`](../../doc/models/my-ships-jump-response.md)

## Example Usage

```php
$shipSymbol = 'shipSymbol2';

$result = $navigationController->postMyShipsShipSymbolJump($shipSymbol);
```

## Example Response *(as JSON)*

```json
{
  "data": {
    "jump": {
      "shipSymbol": "1D7FDA-1",
      "destination": "00E0B1"
    },
    "cooldown": {
      "duration": 719,
      "expiration": "2022-03-12T00:52:56.735Z"
    }
  }
}
```


# Get-My-Ships-Ship Symbol-Jump

Jump Cooldown

```php
function getMyShipsShipSymbolJump(string $shipSymbol): MyShipsJumpResponse1
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `shipSymbol` | `string` | Template, Required | - |

## Response Type

[`MyShipsJumpResponse1`](../../doc/models/my-ships-jump-response-1.md)

## Example Usage

```php
$shipSymbol = 'shipSymbol2';

$result = $navigationController->getMyShipsShipSymbolJump($shipSymbol);
```


# Post-My-Ships-Ship Symbol-Refuel

Refuel Ship

```php
function postMyShipsShipSymbolRefuel(string $shipSymbol): MyShipsRefuelResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `shipSymbol` | `string` | Template, Required | - |

## Response Type

[`MyShipsRefuelResponse`](../../doc/models/my-ships-refuel-response.md)

## Example Usage

```php
$shipSymbol = 'shipSymbol2';

$result = $navigationController->postMyShipsShipSymbolRefuel($shipSymbol);
```

## Example Response *(as JSON)*

```json
{
  "data": {
    "credits": -1920,
    "fuel": 800
  }
}
```


# Post-My-Ships-Ship Symbol-Navigate

Navigate Ship

```php
function postMyShipsShipSymbolNavigate(
    string $shipSymbol,
    ?MyShipsNavigateRequest $body = null
): MyShipsNavigateResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `shipSymbol` | `string` | Template, Required | The ship symbol |
| `body` | [`?MyShipsNavigateRequest`](../../doc/models/my-ships-navigate-request.md) | Body, Optional | - |

## Response Type

[`MyShipsNavigateResponse`](../../doc/models/my-ships-navigate-response.md)

## Example Usage

```php
$shipSymbol = 'shipSymbol2';

$result = $navigationController->postMyShipsShipSymbolNavigate($shipSymbol);
```

## Example Response *(as JSON)*

```json
{
  "data": {
    "fuelCost": 38,
    "navigation": {
      "shipSymbol": "BA03F2-1",
      "departure": "X1-OE-PM",
      "destination": "X1-OE-A005",
      "durationRemaining": 2279,
      "arrivedAt": null
    }
  }
}
```


# Get-My-Ships-Ship Symbol-Navigate

Get the status of your last navigation.

```php
function getMyShipsShipSymbolNavigate(string $shipSymbol): MyShipsNavigateResponse1
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `shipSymbol` | `string` | Template, Required | The ship symbol |

## Response Type

[`MyShipsNavigateResponse1`](../../doc/models/my-ships-navigate-response-1.md)

## Example Usage

```php
$shipSymbol = 'shipSymbol2';

$result = $navigationController->getMyShipsShipSymbolNavigate($shipSymbol);
```

## Example Response *(as JSON)*

```json
{
  "data": {
    "navigation": {
      "shipSymbol": "BA03F2-1",
      "departure": "X1-OE-PM",
      "destination": "X1-OE-A005",
      "durationRemaining": 2279,
      "arrivedAt": null
    }
  }
}
```

