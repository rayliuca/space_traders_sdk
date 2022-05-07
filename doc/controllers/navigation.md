# Navigation

```java
NavigationController navigationController = client.getNavigationController();
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

```java
CompletableFuture<MyShipsDockResponse> postMyShipsShipSymbolDockAsync(
    final String shipSymbol)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `shipSymbol` | `String` | Template, Required | The symbol of the ship |

## Response Type

[`MyShipsDockResponse`](../../doc/models/my-ships-dock-response.md)

## Example Usage

```java
String shipSymbol = "shipSymbol2";

navigationController.postMyShipsShipSymbolDockAsync(shipSymbol).thenAccept(result -> {
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
    "status": "DOCKED"
  }
}
```


# Post-My-Ships-Ship Symbol-Orbit

Transition your ship from docked into orbit. Ships are placed into orbit by default when arriving at a destination. Consecutive calls to this endpoint will continue to return a 200 response status.

```java
CompletableFuture<MyShipsOrbitResponse> postMyShipsShipSymbolOrbitAsync(
    final String shipSymbol)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `shipSymbol` | `String` | Template, Required | The symbol of the ship |

## Response Type

[`MyShipsOrbitResponse`](../../doc/models/my-ships-orbit-response.md)

## Example Usage

```java
String shipSymbol = "shipSymbol2";

navigationController.postMyShipsShipSymbolOrbitAsync(shipSymbol).thenAccept(result -> {
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
    "status": "ORBIT"
  }
}
```


# Post-My-Ships-Ship Symbol-Jump

Jump Ship

```java
CompletableFuture<MyShipsJumpResponse> postMyShipsShipSymbolJumpAsync(
    final String shipSymbol,
    final MyShipsJumpRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `shipSymbol` | `String` | Template, Required | - |
| `body` | [`MyShipsJumpRequest`](../../doc/models/my-ships-jump-request.md) | Body, Optional | - |

## Response Type

[`MyShipsJumpResponse`](../../doc/models/my-ships-jump-response.md)

## Example Usage

```java
String shipSymbol = "shipSymbol2";

navigationController.postMyShipsShipSymbolJumpAsync(shipSymbol, null).thenAccept(result -> {
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

```java
CompletableFuture<MyShipsJumpResponse1> getMyShipsShipSymbolJumpAsync(
    final String shipSymbol)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `shipSymbol` | `String` | Template, Required | - |

## Response Type

[`MyShipsJumpResponse1`](../../doc/models/my-ships-jump-response-1.md)

## Example Usage

```java
String shipSymbol = "shipSymbol2";

navigationController.getMyShipsShipSymbolJumpAsync(shipSymbol).thenAccept(result -> {
    // TODO success callback handler
}).exceptionally(exception -> {
    // TODO failure callback handler
    return null;
});
```


# Post-My-Ships-Ship Symbol-Refuel

Refuel Ship

```java
CompletableFuture<MyShipsRefuelResponse> postMyShipsShipSymbolRefuelAsync(
    final String shipSymbol)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `shipSymbol` | `String` | Template, Required | - |

## Response Type

[`MyShipsRefuelResponse`](../../doc/models/my-ships-refuel-response.md)

## Example Usage

```java
String shipSymbol = "shipSymbol2";

navigationController.postMyShipsShipSymbolRefuelAsync(shipSymbol).thenAccept(result -> {
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
    "credits": -1920,
    "fuel": 800
  }
}
```


# Post-My-Ships-Ship Symbol-Navigate

Navigate Ship

```java
CompletableFuture<MyShipsNavigateResponse> postMyShipsShipSymbolNavigateAsync(
    final String shipSymbol,
    final MyShipsNavigateRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `shipSymbol` | `String` | Template, Required | The ship symbol |
| `body` | [`MyShipsNavigateRequest`](../../doc/models/my-ships-navigate-request.md) | Body, Optional | - |

## Response Type

[`MyShipsNavigateResponse`](../../doc/models/my-ships-navigate-response.md)

## Example Usage

```java
String shipSymbol = "shipSymbol2";

navigationController.postMyShipsShipSymbolNavigateAsync(shipSymbol, null).thenAccept(result -> {
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

```java
CompletableFuture<MyShipsNavigateResponse1> getMyShipsShipSymbolNavigateAsync(
    final String shipSymbol)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `shipSymbol` | `String` | Template, Required | The ship symbol |

## Response Type

[`MyShipsNavigateResponse1`](../../doc/models/my-ships-navigate-response-1.md)

## Example Usage

```java
String shipSymbol = "shipSymbol2";

navigationController.getMyShipsShipSymbolNavigateAsync(shipSymbol).thenAccept(result -> {
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

