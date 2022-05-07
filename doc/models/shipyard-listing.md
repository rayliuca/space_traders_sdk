
# Shipyard Listing

## Structure

`ShipyardListing`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Id` | `String` | Required | **Constraints**: *Minimum Length*: `1` | String getId() | setId(String id) |
| `Waypoint` | `String` | Required | **Constraints**: *Minimum Length*: `1` | String getWaypoint() | setWaypoint(String waypoint) |
| `Price` | `int` | Required | - | int getPrice() | setPrice(int price) |
| `Role` | `String` | Required | **Constraints**: *Minimum Length*: `1` | String getRole() | setRole(String role) |
| `Frame` | `String` | Required | **Constraints**: *Minimum Length*: `1` | String getFrame() | setFrame(String frame) |
| `Reactor` | `String` | Required | **Constraints**: *Minimum Length*: `1` | String getReactor() | setReactor(String reactor) |
| `Engine` | `String` | Required | **Constraints**: *Minimum Length*: `1` | String getEngine() | setEngine(String engine) |
| `Modules` | `List<String>` | Required | - | List<String> getModules() | setModules(List<String> modules) |
| `Mounts` | `List<String>` | Required | - | List<String> getMounts() | setMounts(List<String> mounts) |

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

