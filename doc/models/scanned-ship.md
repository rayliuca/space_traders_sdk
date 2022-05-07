
# Scanned Ship

## Structure

`ScannedShip`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `symbol` | `string` | Required | **Constraints**: *Minimum Length*: `1` | getSymbol(): string | setSymbol(string symbol): void |
| `registration` | [`Registration`](../../doc/models/registration.md) | Required | - | getRegistration(): Registration | setRegistration(Registration registration): void |
| `frameSymbol` | `string` | Required | **Constraints**: *Minimum Length*: `1` | getFrameSymbol(): string | setFrameSymbol(string frameSymbol): void |
| `reactorSymbol` | `string` | Required | **Constraints**: *Minimum Length*: `1` | getReactorSymbol(): string | setReactorSymbol(string reactorSymbol): void |
| `engineSymbol` | `string` | Required | **Constraints**: *Minimum Length*: `1` | getEngineSymbol(): string | setEngineSymbol(string engineSymbol): void |
| `expiration` | `string` | Required | **Constraints**: *Minimum Length*: `1` | getExpiration(): string | setExpiration(string expiration): void |

## Example (as JSON)

```json
{
  "symbol": "symbol8",
  "registration": {
    "factionSymbol": "factionSymbol4",
    "role": "role2"
  },
  "frameSymbol": "frameSymbol6",
  "reactorSymbol": "reactorSymbol6",
  "engineSymbol": "engineSymbol0",
  "expiration": "expiration6"
}
```

