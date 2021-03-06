
# Data 18

## Structure

`Data18`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `exports` | [`List of MarketTrade`](../../doc/models/market-trade.md) | Required | **Constraints**: *Minimum Items*: `1`, *Unique Items Required* |
| `imports` | [`List of MarketTrade`](../../doc/models/market-trade.md) | Required | **Constraints**: *Minimum Items*: `1`, *Unique Items Required* |
| `exchange` | [`List of MarketTrade`](../../doc/models/market-trade.md) | Required | - |

## Example (as JSON)

```json
{
  "exports": [
    {
      "waypointSymbol": "waypointSymbol5",
      "tradeSymbol": "tradeSymbol5",
      "price": 59,
      "tariff": 183
    }
  ],
  "imports": [
    {
      "waypointSymbol": "waypointSymbol2",
      "tradeSymbol": "tradeSymbol8",
      "price": 182,
      "tariff": 50
    }
  ],
  "exchange": [
    {
      "waypointSymbol": "waypointSymbol4",
      "tradeSymbol": "tradeSymbol4",
      "price": 4,
      "tariff": 136
    }
  ]
}
```

