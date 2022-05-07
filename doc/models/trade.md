
# Trade

## Structure

`Trade`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `waypoint_symbol` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `trade_symbol` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `credits` | `int` | Required | - |
| `units` | `int` | Required | - |

## Example (as JSON)

```json
{
  "waypointSymbol": "X1-OE-PM",
  "tradeSymbol": "MICROPROCESSORS",
  "credits": 843,
  "units": 1
}
```

