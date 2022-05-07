
# Market Trade

## Structure

`MarketTrade`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `WaypointSymbol` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `TradeSymbol` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `Price` | `int` | Required | - |
| `Tariff` | `int` | Required | - |

## Example (as JSON)

```json
{
  "waypointSymbol": "waypointSymbol2",
  "tradeSymbol": "tradeSymbol8",
  "price": 16,
  "tariff": 140
}
```

