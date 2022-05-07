
# Trade Exchange Response

## Structure

`TradeExchangeResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<Models.MarketTrade>`](../../doc/models/market-trade.md) | Required | **Constraints**: *Minimum Items*: `1`, *Unique Items Required* |
| `Meta` | [`Models.Meta`](../../doc/models/meta.md) | Required | - |

## Example (as JSON)

```json
{
  "data": null,
  "meta": {
    "total": 10,
    "page": 1,
    "limit": 10
  }
}
```

