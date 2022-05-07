
# Ship

## Structure

`Ship`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Symbol` | `String` | Required | **Constraints**: *Minimum Length*: `1` | String getSymbol() | setSymbol(String symbol) |
| `Frame` | `String` | Required | **Constraints**: *Minimum Length*: `1` | String getFrame() | setFrame(String frame) |
| `Reactor` | `String` | Required | **Constraints**: *Minimum Length*: `1` | String getReactor() | setReactor(String reactor) |
| `Engine` | `String` | Required | **Constraints**: *Minimum Length*: `1` | String getEngine() | setEngine(String engine) |
| `Modules` | `List<String>` | Required | - | List<String> getModules() | setModules(List<String> modules) |
| `Mounts` | `List<String>` | Required | - | List<String> getMounts() | setMounts(List<String> mounts) |
| `Registration` | [`Registration1`](../../doc/models/registration-1.md) | Required | - | Registration1 getRegistration() | setRegistration(Registration1 registration) |
| `Integrity` | [`Integrity`](../../doc/models/integrity.md) | Required | - | Integrity getIntegrity() | setIntegrity(Integrity integrity) |
| `Stats` | [`Stats`](../../doc/models/stats.md) | Optional | - | Stats getStats() | setStats(Stats stats) |
| `Status` | `String` | Required | **Constraints**: *Minimum Length*: `1` | String getStatus() | setStatus(String status) |
| `Location` | `String` | Required | **Constraints**: *Minimum Length*: `1` | String getLocation() | setLocation(String location) |
| `Cargo` | [`List<Cargo>`](../../doc/models/cargo.md) | Required | **Constraints**: *Minimum Items*: `0`, *Unique Items Required* | List<Cargo> getCargo() | setCargo(List<Cargo> cargo) |
| `Fuel` | `int` | Required | - | int getFuel() | setFuel(int fuel) |

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

