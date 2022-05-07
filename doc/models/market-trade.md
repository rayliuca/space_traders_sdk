
# Market Trade

## Structure

`MarketTrade`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `waypoint_symbol` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `trade_symbol` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `price` | `int` | Required | - |
| `tariff` | `int` | Required | - |

## Example (as JSON)

```json
{
  "waypointSymbol": "waypointSymbol2",
  "tradeSymbol": "tradeSymbol8",
  "price": 16,
  "tariff": 140
}
```

