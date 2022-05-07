
# Trade

## Structure

`Trade`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `WaypointSymbol` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `TradeSymbol` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `Credits` | `int` | Required | - |
| `Units` | `int` | Required | - |

## Example (as JSON)

```json
{
  "waypointSymbol": "X1-OE-PM",
  "tradeSymbol": "MICROPROCESSORS",
  "credits": 843,
  "units": 1
}
```

