
# Systems Response

## Structure

`SystemsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `data` | [`List of System`](../../doc/models/system.md) | Required | **Constraints**: *Minimum Items*: `1`, *Unique Items Required* |
| `meta` | [`Meta`](../../doc/models/meta.md) | Required | - |

## Example (as JSON)

```json
{
  "data": {
    "symbol": "X1-OE",
    "sector": "X1",
    "type": "RED_STAR",
    "x": 0,
    "y": 0,
    "waypoints": [
      "X1-OE-PM",
      "X1-OE-PM01",
      "X1-OE-A005",
      "X1-OE-25X"
    ],
    "factions": [
      "COMMERCE_REPUBLIC",
      "MINERS_COLLECTIVE",
      "SPACERS_GUILD"
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

