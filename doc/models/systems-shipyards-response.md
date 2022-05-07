
# Systems Shipyards Response

## Structure

`SystemsShipyardsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<Models.Shipyard>`](../../doc/models/shipyard.md) | Required | **Constraints**: *Minimum Items*: `1`, *Unique Items Required* |
| `Meta` | [`Models.Meta`](../../doc/models/meta.md) | Required | - |

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

