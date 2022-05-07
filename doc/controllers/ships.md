# Ships

```java
ShipsController shipsController = client.getShipsController();
```

## Class Name

`ShipsController`

## Methods

* [Post-My-Ships-Ship Symbol-Jettison](../../doc/controllers/ships.md#post-my-ships-ship-symbol-jettison)
* [Post-My-Ships-Ship Symbol-Scan](../../doc/controllers/ships.md#post-my-ships-ship-symbol-scan)
* [Get-My-Ships-Ship Symbol-Scan](../../doc/controllers/ships.md#get-my-ships-ship-symbol-scan)
* [Get-My-Ships-Ship Symbol](../../doc/controllers/ships.md#get-my-ships-ship-symbol)
* [Get-My-Ships](../../doc/controllers/ships.md#get-my-ships)


# Post-My-Ships-Ship Symbol-Jettison

Jettison cargo from your ship's cargo hold.

```java
CompletableFuture<MyShipsJettisonResponse> postMyShipsShipSymbolJettisonAsync(
    final String shipSymbol,
    final MyShipsJettisonRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `shipSymbol` | `String` | Template, Required | - |
| `body` | [`MyShipsJettisonRequest`](../../doc/models/my-ships-jettison-request.md) | Body, Optional | - |

## Response Type

[`MyShipsJettisonResponse`](../../doc/models/my-ships-jettison-response.md)

## Example Usage

```java
String shipSymbol = "shipSymbol2";

shipsController.postMyShipsShipSymbolJettisonAsync(shipSymbol, null).thenAccept(result -> {
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
    "tradeSymbol": "ALUMINUM",
    "units": 95
  }
}
```


# Post-My-Ships-Ship Symbol-Scan

Execute a ship scan to view approach / departing ships, system information or details about a waypoint. Send a scan mode to select the type of scan performed by your ship.

```java
CompletableFuture<MyShipsScanResponse> postMyShipsShipSymbolScanAsync(
    final String shipSymbol,
    final MyShipsScanRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `shipSymbol` | `String` | Template, Required | - |
| `body` | [`MyShipsScanRequest`](../../doc/models/my-ships-scan-request.md) | Body, Optional | - |

## Response Type

[`MyShipsScanResponse`](../../doc/models/my-ships-scan-response.md)

## Example Usage

```java
String shipSymbol = "shipSymbol2";
MyShipsScanRequest body = new MyShipsScanRequest();
body.setMode(ModeEnum.APPROACHING_SHIPS);

shipsController.postMyShipsShipSymbolScanAsync(shipSymbol, body).thenAccept(result -> {
    // TODO success callback handler
}).exceptionally(exception -> {
    // TODO failure callback handler
    return null;
});
```


# Get-My-Ships-Ship Symbol-Scan

Scan Cooldown

```java
CompletableFuture<MyShipsScanResponse1> getMyShipsShipSymbolScanAsync(
    final String shipSymbol)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `shipSymbol` | `String` | Template, Required | - |

## Response Type

[`MyShipsScanResponse1`](../../doc/models/my-ships-scan-response-1.md)

## Example Usage

```java
String shipSymbol = "shipSymbol2";

shipsController.getMyShipsShipSymbolScanAsync(shipSymbol).thenAccept(result -> {
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
    "cooldown": {
      "duration": 59,
      "expiration": "2022-03-12T00:42:44.220Z"
    }
  }
}
```


# Get-My-Ships-Ship Symbol

Retrieve the details of your ship.

```java
CompletableFuture<MyShipsResponse> getMyShipsShipSymbolAsync(
    final String shipSymbol)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `shipSymbol` | `String` | Template, Required | - |

## Response Type

[`MyShipsResponse`](../../doc/models/my-ships-response.md)

## Example Usage

```java
String shipSymbol = "shipSymbol2";

shipsController.getMyShipsShipSymbolAsync(shipSymbol).thenAccept(result -> {
    // TODO success callback handler
}).exceptionally(exception -> {
    // TODO failure callback handler
    return null;
});
```


# Get-My-Ships

Retrieve all of your ships.

```java
CompletableFuture<MyShipsResponse1> getMyShipsAsync()
```

## Response Type

[`MyShipsResponse1`](../../doc/models/my-ships-response-1.md)

## Example Usage

```java
shipsController.getMyShipsAsync().thenAccept(result -> {
    // TODO success callback handler
}).exceptionally(exception -> {
    // TODO failure callback handler
    return null;
});
```

## Example Response *(as JSON)*

```json
{
  "data": [
    {
      "symbol": "55B261-1",
      "crew": null,
      "officers": null,
      "fuel": 100,
      "frame": "FRAME_DRONE",
      "reactor": "REACTOR_SOLAR_I",
      "engine": "ENGINE_SOLAR_PROPULSION",
      "modules": [
        "MODULE_CARGO_HOLD"
      ],
      "mounts": [
        "MOUNT_MINING_LASER_I"
      ],
      "registration": {
        "factionSymbol": "COMMERCE_REPUBLIC",
        "agentSymbol": "55B261",
        "fee": 100,
        "role": "EXCAVATOR"
      },
      "integrity": {
        "frame": 1,
        "reactor": 1,
        "engine": 1
      },
      "status": "DOCKED",
      "location": "X1-OE-PM",
      "cargo": []
    },
    {
      "symbol": "55B261-2",
      "crew": null,
      "officers": null,
      "fuel": 100,
      "frame": "FRAME_DRONE",
      "reactor": "REACTOR_SOLAR_I",
      "engine": "ENGINE_SOLAR_PROPULSION",
      "modules": [
        "MODULE_CARGO_HOLD"
      ],
      "mounts": [
        "MOUNT_MINING_LASER_I"
      ],
      "registration": {
        "factionSymbol": "COMMERCE_REPUBLIC",
        "agentSymbol": "55B261",
        "fee": 100,
        "role": "EXCAVATOR"
      },
      "integrity": {
        "frame": 1,
        "reactor": 1,
        "engine": 1
      },
      "status": "DOCKED",
      "location": "X1-OE-PM",
      "cargo": []
    },
    {
      "symbol": "55B261-3",
      "crew": null,
      "officers": null,
      "fuel": 100,
      "frame": "FRAME_DRONE",
      "reactor": "REACTOR_SOLAR_I",
      "engine": "ENGINE_SOLAR_PROPULSION",
      "modules": [
        "MODULE_CARGO_HOLD"
      ],
      "mounts": [
        "MOUNT_MINING_LASER_I"
      ],
      "registration": {
        "factionSymbol": "COMMERCE_REPUBLIC",
        "agentSymbol": "55B261",
        "fee": 100,
        "role": "EXCAVATOR"
      },
      "integrity": {
        "frame": 1,
        "reactor": 1,
        "engine": 1
      },
      "status": "DOCKED",
      "location": "X1-OE-PM",
      "cargo": []
    },
    {
      "symbol": "55B261-4",
      "crew": null,
      "officers": null,
      "fuel": 100,
      "frame": "FRAME_DRONE",
      "reactor": "REACTOR_SOLAR_I",
      "engine": "ENGINE_SOLAR_PROPULSION",
      "modules": [
        "MODULE_CARGO_HOLD"
      ],
      "mounts": [
        "MOUNT_MINING_LASER_I"
      ],
      "registration": {
        "factionSymbol": "COMMERCE_REPUBLIC",
        "agentSymbol": "55B261",
        "fee": 100,
        "role": "EXCAVATOR"
      },
      "integrity": {
        "frame": 1,
        "reactor": 1,
        "engine": 1
      },
      "status": "DOCKED",
      "location": "X1-OE-PM",
      "cargo": []
    },
    {
      "symbol": "55B261-5",
      "crew": null,
      "officers": null,
      "fuel": 100,
      "frame": "FRAME_DRONE",
      "reactor": "REACTOR_SOLAR_I",
      "engine": "ENGINE_SOLAR_PROPULSION",
      "modules": [
        "MODULE_CARGO_HOLD"
      ],
      "mounts": [
        "MOUNT_MINING_LASER_I"
      ],
      "registration": {
        "factionSymbol": "COMMERCE_REPUBLIC",
        "agentSymbol": "55B261",
        "fee": 100,
        "role": "EXCAVATOR"
      },
      "integrity": {
        "frame": 1,
        "reactor": 1,
        "engine": 1
      },
      "status": "DOCKED",
      "location": "X1-OE-PM",
      "cargo": []
    },
    {
      "symbol": "55B261-6",
      "crew": null,
      "officers": null,
      "fuel": 100,
      "frame": "FRAME_DRONE",
      "reactor": "REACTOR_SOLAR_I",
      "engine": "ENGINE_SOLAR_PROPULSION",
      "modules": [
        "MODULE_CARGO_HOLD"
      ],
      "mounts": [
        "MOUNT_MINING_LASER_I"
      ],
      "registration": {
        "factionSymbol": "COMMERCE_REPUBLIC",
        "agentSymbol": "55B261",
        "fee": 100,
        "role": "EXCAVATOR"
      },
      "integrity": {
        "frame": 1,
        "reactor": 1,
        "engine": 1
      },
      "status": "DOCKED",
      "location": "X1-OE-PM",
      "cargo": []
    }
  ],
  "meta": {
    "total": 6,
    "page": 1,
    "limit": 20
  }
}
```

