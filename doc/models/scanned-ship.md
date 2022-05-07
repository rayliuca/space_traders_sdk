
# Scanned Ship

## Structure

`ScannedShip`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Symbol` | `String` | Required | **Constraints**: *Minimum Length*: `1` | String getSymbol() | setSymbol(String symbol) |
| `Registration` | [`Registration`](../../doc/models/registration.md) | Required | - | Registration getRegistration() | setRegistration(Registration registration) |
| `FrameSymbol` | `String` | Required | **Constraints**: *Minimum Length*: `1` | String getFrameSymbol() | setFrameSymbol(String frameSymbol) |
| `ReactorSymbol` | `String` | Required | **Constraints**: *Minimum Length*: `1` | String getReactorSymbol() | setReactorSymbol(String reactorSymbol) |
| `EngineSymbol` | `String` | Required | **Constraints**: *Minimum Length*: `1` | String getEngineSymbol() | setEngineSymbol(String engineSymbol) |
| `Expiration` | `String` | Required | **Constraints**: *Minimum Length*: `1` | String getExpiration() | setExpiration(String expiration) |

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

