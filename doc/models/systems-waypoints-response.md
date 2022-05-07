
# Systems Waypoints Response

## Structure

`SystemsWaypointsResponse`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `data` | [`Waypoint[]`](../../doc/models/waypoint.md) | Required | **Constraints**: *Minimum Items*: `1`, *Unique Items Required* | getData(): array | setData(array data): void |
| `meta` | [`Meta`](../../doc/models/meta.md) | Required | - | getMeta(): Meta | setMeta(Meta meta): void |

## Example (as JSON)

```json
{
  "data": {
    "system": "X1-OE",
    "symbol": "X1-OE-PM",
    "type": "PLANET",
    "x": 10,
    "y": 5,
    "orbitals": [
      "X1-OE-PM01"
    ],
    "faction": "COMMERCE_REPUBLIC",
    "features": [
      "MARKETPLACE",
      "SHIPYARD"
    ],
    "traits": [
      "OVERCROWDED",
      "HIGH_TECH",
      "BUREAUCRATIC",
      "TRADING_HUB",
      "TEMPERATE"
    ],
    "charted": true,
    "chartedBy": null
  },
  "meta": {
    "total": 10,
    "page": 1,
    "limit": 10
  }
}
```

