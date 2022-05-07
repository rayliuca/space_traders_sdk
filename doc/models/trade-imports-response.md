
# Trade Imports Response

## Structure

`TradeImportsResponse`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `data` | [`MarketTrade[]`](../../doc/models/market-trade.md) | Required | **Constraints**: *Minimum Items*: `1`, *Unique Items Required* | getData(): array | setData(array data): void |
| `meta` | [`Meta`](../../doc/models/meta.md) | Required | - | getMeta(): Meta | setMeta(Meta meta): void |

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

