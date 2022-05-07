# Ships

```csharp
ShipsController shipsController = client.ShipsController;
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

```csharp
PostMyShipsShipSymbolJettisonAsync(
    string shipSymbol,
    Models.MyShipsJettisonRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `shipSymbol` | `string` | Template, Required | - |
| `body` | [`Models.MyShipsJettisonRequest`](../../doc/models/my-ships-jettison-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.MyShipsJettisonResponse>`](../../doc/models/my-ships-jettison-response.md)

## Example Usage

```csharp
string shipSymbol = "shipSymbol2";

try
{
    MyShipsJettisonResponse result = await shipsController.PostMyShipsShipSymbolJettisonAsync(shipSymbol, null);
}
catch (ApiException e){};
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

```csharp
PostMyShipsShipSymbolScanAsync(
    string shipSymbol,
    Models.MyShipsScanRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `shipSymbol` | `string` | Template, Required | - |
| `body` | [`Models.MyShipsScanRequest`](../../doc/models/my-ships-scan-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.MyShipsScanResponse>`](../../doc/models/my-ships-scan-response.md)

## Example Usage

```csharp
string shipSymbol = "shipSymbol2";
var body = new MyShipsScanRequest();
body.Mode = ModeEnum.APPROACHINGSHIPS;

try
{
    MyShipsScanResponse result = await shipsController.PostMyShipsShipSymbolScanAsync(shipSymbol, body);
}
catch (ApiException e){};
```


# Get-My-Ships-Ship Symbol-Scan

Scan Cooldown

```csharp
GetMyShipsShipSymbolScanAsync(
    string shipSymbol)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `shipSymbol` | `string` | Template, Required | - |

## Response Type

[`Task<Models.MyShipsScanResponse1>`](../../doc/models/my-ships-scan-response-1.md)

## Example Usage

```csharp
string shipSymbol = "shipSymbol2";

try
{
    MyShipsScanResponse1 result = await shipsController.GetMyShipsShipSymbolScanAsync(shipSymbol);
}
catch (ApiException e){};
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

```csharp
GetMyShipsShipSymbolAsync(
    string shipSymbol)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `shipSymbol` | `string` | Template, Required | - |

## Response Type

[`Task<Models.MyShipsResponse>`](../../doc/models/my-ships-response.md)

## Example Usage

```csharp
string shipSymbol = "shipSymbol2";

try
{
    MyShipsResponse result = await shipsController.GetMyShipsShipSymbolAsync(shipSymbol);
}
catch (ApiException e){};
```


# Get-My-Ships

Retrieve all of your ships.

```csharp
GetMyShipsAsync()
```

## Response Type

[`Task<Models.MyShipsResponse1>`](../../doc/models/my-ships-response-1.md)

## Example Usage

```csharp
try
{
    MyShipsResponse1 result = await shipsController.GetMyShipsAsync();
}
catch (ApiException e){};
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

