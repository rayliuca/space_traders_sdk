
# Ship

## Structure

`Ship`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `symbol` | `string` | Required | **Constraints**: *Minimum Length*: `1` | getSymbol(): string | setSymbol(string symbol): void |
| `frame` | `string` | Required | **Constraints**: *Minimum Length*: `1` | getFrame(): string | setFrame(string frame): void |
| `reactor` | `string` | Required | **Constraints**: *Minimum Length*: `1` | getReactor(): string | setReactor(string reactor): void |
| `engine` | `string` | Required | **Constraints**: *Minimum Length*: `1` | getEngine(): string | setEngine(string engine): void |
| `modules` | `string[]` | Required | - | getModules(): array | setModules(array modules): void |
| `mounts` | `string[]` | Required | - | getMounts(): array | setMounts(array mounts): void |
| `registration` | [`Registration1`](../../doc/models/registration-1.md) | Required | - | getRegistration(): Registration1 | setRegistration(Registration1 registration): void |
| `integrity` | [`Integrity`](../../doc/models/integrity.md) | Required | - | getIntegrity(): Integrity | setIntegrity(Integrity integrity): void |
| `stats` | [`?Stats`](../../doc/models/stats.md) | Optional | - | getStats(): ?Stats | setStats(?Stats stats): void |
| `status` | `string` | Required | **Constraints**: *Minimum Length*: `1` | getStatus(): string | setStatus(string status): void |
| `location` | `string` | Required | **Constraints**: *Minimum Length*: `1` | getLocation(): string | setLocation(string location): void |
| `cargo` | [`Cargo[]`](../../doc/models/cargo.md) | Required | **Constraints**: *Minimum Items*: `0`, *Unique Items Required* | getCargo(): array | setCargo(array cargo): void |
| `fuel` | `int` | Required | - | getFuel(): int | setFuel(int fuel): void |

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

