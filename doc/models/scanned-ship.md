
# Scanned Ship

## Structure

`ScannedShip`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `symbol` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `registration` | [`Registration`](../../doc/models/registration.md) | Required | - |
| `frame_symbol` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `reactor_symbol` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `engine_symbol` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `expiration` | `string` | Required | **Constraints**: *Minimum Length*: `1` |

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

