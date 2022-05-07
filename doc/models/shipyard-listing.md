
# Shipyard Listing

## Structure

`ShipyardListing`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `waypoint` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `price` | `int` | Required | - |
| `role` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `frame` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `reactor` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `engine` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `modules` | `List of string` | Required | - |
| `mounts` | `List of string` | Required | - |

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

