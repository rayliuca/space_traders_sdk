
# Data

## Structure

`Data`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `trade_symbol` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `destination` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `units` | `int` | Required | - |
| `fulfilled` | `int` | Required | - |

## Example (as JSON)

```json
{
  "tradeSymbol": "tradeSymbol8",
  "destination": "destination4",
  "units": 142,
  "fulfilled": 24
}
```

