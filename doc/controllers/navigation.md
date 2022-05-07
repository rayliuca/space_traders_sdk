# Navigation

```csharp
NavigationController navigationController = client.NavigationController;
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

```csharp
PostMyShipsShipSymbolDockAsync(
    string shipSymbol)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `shipSymbol` | `string` | Template, Required | The symbol of the ship |

## Response Type

[`Task<Models.MyShipsDockResponse>`](../../doc/models/my-ships-dock-response.md)

## Example Usage

```csharp
string shipSymbol = "shipSymbol2";

try
{
    MyShipsDockResponse result = await navigationController.PostMyShipsShipSymbolDockAsync(shipSymbol);
}
catch (ApiException e){};
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

```csharp
PostMyShipsShipSymbolOrbitAsync(
    string shipSymbol)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `shipSymbol` | `string` | Template, Required | The symbol of the ship |

## Response Type

[`Task<Models.MyShipsOrbitResponse>`](../../doc/models/my-ships-orbit-response.md)

## Example Usage

```csharp
string shipSymbol = "shipSymbol2";

try
{
    MyShipsOrbitResponse result = await navigationController.PostMyShipsShipSymbolOrbitAsync(shipSymbol);
}
catch (ApiException e){};
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

```csharp
PostMyShipsShipSymbolJumpAsync(
    string shipSymbol,
    Models.MyShipsJumpRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `shipSymbol` | `string` | Template, Required | - |
| `body` | [`Models.MyShipsJumpRequest`](../../doc/models/my-ships-jump-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.MyShipsJumpResponse>`](../../doc/models/my-ships-jump-response.md)

## Example Usage

```csharp
string shipSymbol = "shipSymbol2";

try
{
    MyShipsJumpResponse result = await navigationController.PostMyShipsShipSymbolJumpAsync(shipSymbol, null);
}
catch (ApiException e){};
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

```csharp
GetMyShipsShipSymbolJumpAsync(
    string shipSymbol)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `shipSymbol` | `string` | Template, Required | - |

## Response Type

[`Task<Models.MyShipsJumpResponse1>`](../../doc/models/my-ships-jump-response-1.md)

## Example Usage

```csharp
string shipSymbol = "shipSymbol2";

try
{
    MyShipsJumpResponse1 result = await navigationController.GetMyShipsShipSymbolJumpAsync(shipSymbol);
}
catch (ApiException e){};
```


# Post-My-Ships-Ship Symbol-Refuel

Refuel Ship

```csharp
PostMyShipsShipSymbolRefuelAsync(
    string shipSymbol)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `shipSymbol` | `string` | Template, Required | - |

## Response Type

[`Task<Models.MyShipsRefuelResponse>`](../../doc/models/my-ships-refuel-response.md)

## Example Usage

```csharp
string shipSymbol = "shipSymbol2";

try
{
    MyShipsRefuelResponse result = await navigationController.PostMyShipsShipSymbolRefuelAsync(shipSymbol);
}
catch (ApiException e){};
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

```csharp
PostMyShipsShipSymbolNavigateAsync(
    string shipSymbol,
    Models.MyShipsNavigateRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `shipSymbol` | `string` | Template, Required | The ship symbol |
| `body` | [`Models.MyShipsNavigateRequest`](../../doc/models/my-ships-navigate-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.MyShipsNavigateResponse>`](../../doc/models/my-ships-navigate-response.md)

## Example Usage

```csharp
string shipSymbol = "shipSymbol2";

try
{
    MyShipsNavigateResponse result = await navigationController.PostMyShipsShipSymbolNavigateAsync(shipSymbol, null);
}
catch (ApiException e){};
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

```csharp
GetMyShipsShipSymbolNavigateAsync(
    string shipSymbol)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `shipSymbol` | `string` | Template, Required | The ship symbol |

## Response Type

[`Task<Models.MyShipsNavigateResponse1>`](../../doc/models/my-ships-navigate-response-1.md)

## Example Usage

```csharp
string shipSymbol = "shipSymbol2";

try
{
    MyShipsNavigateResponse1 result = await navigationController.GetMyShipsShipSymbolNavigateAsync(shipSymbol);
}
catch (ApiException e){};
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

