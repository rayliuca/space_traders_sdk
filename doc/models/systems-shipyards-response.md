
# Systems Shipyards Response

## Structure

`SystemsShipyardsResponse`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Data` | [`List<Shipyard>`](../../doc/models/shipyard.md) | Required | **Constraints**: *Minimum Items*: `1`, *Unique Items Required* | List<Shipyard> getData() | setData(List<Shipyard> data) |
| `Meta` | [`Meta`](../../doc/models/meta.md) | Required | - | Meta getMeta() | setMeta(Meta meta) |

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

