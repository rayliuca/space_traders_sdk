
# Trade

## Structure

`Trade`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `waypointSymbol` | `string` | Required | **Constraints**: *Minimum Length*: `1` | getWaypointSymbol(): string | setWaypointSymbol(string waypointSymbol): void |
| `tradeSymbol` | `string` | Required | **Constraints**: *Minimum Length*: `1` | getTradeSymbol(): string | setTradeSymbol(string tradeSymbol): void |
| `credits` | `int` | Required | - | getCredits(): int | setCredits(int credits): void |
| `units` | `int` | Required | - | getUnits(): int | setUnits(int units): void |

## Example (as JSON)

```json
{
  "waypointSymbol": "X1-OE-PM",
  "tradeSymbol": "MICROPROCESSORS",
  "credits": 843,
  "units": 1
}
```

