
# Systems Shipyards Response

## Structure

`SystemsShipyardsResponse`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `data` | [`Shipyard[]`](../../doc/models/shipyard.md) | Required | **Constraints**: *Minimum Items*: `1`, *Unique Items Required* | getData(): array | setData(array data): void |
| `meta` | [`Meta`](../../doc/models/meta.md) | Required | - | getMeta(): Meta | setMeta(Meta meta): void |

## Example (as JSON)

```json
{
  "data": {
    "symbol": "X1-OE-PM",
    "faction": "COMMERCE_REPUBLIC"
  },
  "meta": {
    "total": 10,
    "page": 1,
    "limit": 10
  }
}
```

