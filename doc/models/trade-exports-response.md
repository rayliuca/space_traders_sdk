
# Trade Exports Response

## Structure

`TradeExportsResponse`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Data` | [`List<MarketTrade>`](../../doc/models/market-trade.md) | Required | **Constraints**: *Minimum Items*: `1`, *Unique Items Required* | List<MarketTrade> getData() | setData(List<MarketTrade> data) |
| `Meta` | [`Meta`](../../doc/models/meta.md) | Required | - | Meta getMeta() | setMeta(Meta meta) |

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

