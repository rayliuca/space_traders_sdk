
# Data 18

## Structure

`Data18`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `exports` | [`MarketTrade[]`](../../doc/models/market-trade.md) | Required | **Constraints**: *Minimum Items*: `1`, *Unique Items Required* | getExports(): array | setExports(array exports): void |
| `imports` | [`MarketTrade[]`](../../doc/models/market-trade.md) | Required | **Constraints**: *Minimum Items*: `1`, *Unique Items Required* | getImports(): array | setImports(array imports): void |
| `exchange` | [`MarketTrade[]`](../../doc/models/market-trade.md) | Required | - | getExchange(): array | setExchange(array exchange): void |

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

