
# Trade Imports Response

## Structure

`TradeImportsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `data` | [`List of MarketTrade`](../../doc/models/market-trade.md) | Required | **Constraints**: *Minimum Items*: `1`, *Unique Items Required* |
| `meta` | [`Meta`](../../doc/models/meta.md) | Required | - |

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

