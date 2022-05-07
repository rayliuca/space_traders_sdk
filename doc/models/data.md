
# Data

## Structure

`Data`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `tradeSymbol` | `string` | Required | **Constraints**: *Minimum Length*: `1` | getTradeSymbol(): string | setTradeSymbol(string tradeSymbol): void |
| `destination` | `string` | Required | **Constraints**: *Minimum Length*: `1` | getDestination(): string | setDestination(string destination): void |
| `units` | `int` | Required | - | getUnits(): int | setUnits(int units): void |
| `fulfilled` | `int` | Required | - | getFulfilled(): int | setFulfilled(int fulfilled): void |

## Example (as JSON)

```json
{
  "tradeSymbol": "tradeSymbol8",
  "destination": "destination4",
  "units": 142,
  "fulfilled": 24
}
```

