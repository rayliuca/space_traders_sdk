
# My Ships Response 1

## Structure

`MyShipsResponse1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `data` | [`List of Ship`](../../doc/models/ship.md) | Required | **Constraints**: *Minimum Items*: `1`, *Unique Items Required* |
| `meta` | [`Meta`](../../doc/models/meta.md) | Required | - |

## Example (as JSON)

```json
{
  "data": {
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
  "meta": {
    "total": 10,
    "page": 1,
    "limit": 10
  }
}
```

