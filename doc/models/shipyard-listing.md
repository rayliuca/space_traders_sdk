
# Shipyard Listing

## Structure

`ShipyardListing`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `Waypoint` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `Price` | `int` | Required | - |
| `Role` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `Frame` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `Reactor` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `Engine` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `Modules` | `List<string>` | Required | - |
| `Mounts` | `List<string>` | Required | - |

## Example (as JSON)

```json
{
  "id": "cl0nahta90000aq0jonm1nprl",
  "waypoint": "X1-OE-PM",
  "price": 58191,
  "role": "EXCAVATOR",
  "frame": "FRAME_DRONE",
  "reactor": "REACTOR_SOLAR_I",
  "engine": "ENGINE_SOLAR_PROPULSION",
  "modules": [
    "MODULE_CARGO_HOLD"
  ],
  "mounts": [
    "MOUNT_MINING_LASER_I"
  ]
}
```

