
# Scanned Ship

## Structure

`ScannedShip`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Symbol` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `Registration` | [`Models.Registration`](../../doc/models/registration.md) | Required | - |
| `FrameSymbol` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `ReactorSymbol` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `EngineSymbol` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `Expiration` | `string` | Required | **Constraints**: *Minimum Length*: `1` |

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

