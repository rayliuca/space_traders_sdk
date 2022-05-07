
# Data

## Structure

`Data`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TradeSymbol` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `Destination` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `Units` | `int` | Required | - |
| `Fulfilled` | `int` | Required | - |

## Example (as JSON)

```json
{
  "tradeSymbol": "tradeSymbol8",
  "destination": "destination4",
  "units": 142,
  "fulfilled": 24
}
```

