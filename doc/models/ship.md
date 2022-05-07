
# Ship

## Structure

`Ship`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Symbol` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `Frame` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `Reactor` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `Engine` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `Modules` | `List<string>` | Required | - |
| `Mounts` | `List<string>` | Required | - |
| `Registration` | [`Models.Registration1`](../../doc/models/registration-1.md) | Required | - |
| `Integrity` | [`Models.Integrity`](../../doc/models/integrity.md) | Required | - |
| `Stats` | [`Models.Stats`](../../doc/models/stats.md) | Optional | - |
| `Status` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `Location` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `Cargo` | [`List<Models.Cargo>`](../../doc/models/cargo.md) | Required | **Constraints**: *Minimum Items*: `0`, *Unique Items Required* |
| `Fuel` | `int` | Required | - |

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

