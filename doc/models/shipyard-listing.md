
# Shipyard Listing

## Structure

`ShipyardListing`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `id` | `string` | Required | **Constraints**: *Minimum Length*: `1` | getId(): string | setId(string id): void |
| `waypoint` | `string` | Required | **Constraints**: *Minimum Length*: `1` | getWaypoint(): string | setWaypoint(string waypoint): void |
| `price` | `int` | Required | - | getPrice(): int | setPrice(int price): void |
| `role` | `string` | Required | **Constraints**: *Minimum Length*: `1` | getRole(): string | setRole(string role): void |
| `frame` | `string` | Required | **Constraints**: *Minimum Length*: `1` | getFrame(): string | setFrame(string frame): void |
| `reactor` | `string` | Required | **Constraints**: *Minimum Length*: `1` | getReactor(): string | setReactor(string reactor): void |
| `engine` | `string` | Required | **Constraints**: *Minimum Length*: `1` | getEngine(): string | setEngine(string engine): void |
| `modules` | `string[]` | Required | - | getModules(): array | setModules(array modules): void |
| `mounts` | `string[]` | Required | - | getMounts(): array | setMounts(array mounts): void |

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

