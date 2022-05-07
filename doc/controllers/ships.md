# Ships

```python
ships_controller = client.ships
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

```python
def post_my_ships_ship_symbol_jettison(self,
                                      ship_symbol,
                                      body=None)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ship_symbol` | `string` | Template, Required | - |
| `body` | [`MyShipsJettisonRequest`](../../doc/models/my-ships-jettison-request.md) | Body, Optional | - |

## Response Type

[`MyShipsJettisonResponse`](../../doc/models/my-ships-jettison-response.md)

## Example Usage

```python
ship_symbol = 'shipSymbol2'

result = ships_controller.post_my_ships_ship_symbol_jettison(ship_symbol)
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

```python
def post_my_ships_ship_symbol_scan(self,
                                  ship_symbol,
                                  body=None)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ship_symbol` | `string` | Template, Required | - |
| `body` | [`MyShipsScanRequest`](../../doc/models/my-ships-scan-request.md) | Body, Optional | - |

## Response Type

[`MyShipsScanResponse`](../../doc/models/my-ships-scan-response.md)

## Example Usage

```python
ship_symbol = 'shipSymbol2'
body = MyShipsScanRequest()
body.mode = ModeEnum.APPROACHING_SHIPS

result = ships_controller.post_my_ships_ship_symbol_scan(ship_symbol, body)
```


# Get-My-Ships-Ship Symbol-Scan

Scan Cooldown

```python
def get_my_ships_ship_symbol_scan(self,
                                 ship_symbol)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ship_symbol` | `string` | Template, Required | - |

## Response Type

[`MyShipsScanResponse1`](../../doc/models/my-ships-scan-response-1.md)

## Example Usage

```python
ship_symbol = 'shipSymbol2'

result = ships_controller.get_my_ships_ship_symbol_scan(ship_symbol)
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

```python
def get_my_ships_ship_symbol(self,
                            ship_symbol)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ship_symbol` | `string` | Template, Required | - |

## Response Type

[`MyShipsResponse`](../../doc/models/my-ships-response.md)

## Example Usage

```python
ship_symbol = 'shipSymbol2'

result = ships_controller.get_my_ships_ship_symbol(ship_symbol)
```


# Get-My-Ships

Retrieve all of your ships.

```python
def get_my_ships(self)
```

## Response Type

[`MyShipsResponse1`](../../doc/models/my-ships-response-1.md)

## Example Usage

```python
result = ships_controller.get_my_ships()
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

