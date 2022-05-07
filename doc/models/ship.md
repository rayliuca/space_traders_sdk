
# Ship

## Structure

`Ship`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `symbol` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `frame` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `reactor` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `engine` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `modules` | `List of string` | Required | - |
| `mounts` | `List of string` | Required | - |
| `registration` | [`Registration1`](../../doc/models/registration-1.md) | Required | - |
| `integrity` | [`Integrity`](../../doc/models/integrity.md) | Required | - |
| `stats` | [`Stats`](../../doc/models/stats.md) | Optional | - |
| `status` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `location` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `cargo` | [`List of Cargo`](../../doc/models/cargo.md) | Required | **Constraints**: *Minimum Items*: `0`, *Unique Items Required* |
| `fuel` | `int` | Required | - |

## Example (as JSON)

```json
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
}
```

