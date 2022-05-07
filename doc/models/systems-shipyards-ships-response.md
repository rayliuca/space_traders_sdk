
# Systems Shipyards Ships Response

## Structure

`SystemsShipyardsShipsResponse`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `data` | [`ShipyardListing[]`](../../doc/models/shipyard-listing.md) | Required | **Constraints**: *Minimum Items*: `1`, *Unique Items Required* | getData(): array | setData(array data): void |
| `meta` | [`Meta`](../../doc/models/meta.md) | Required | - | getMeta(): Meta | setMeta(Meta meta): void |

## Example (as JSON)

```json
{
  "data": {
    "id": "cl0nahta90000aq0jonm1nprl",
    "waypoint": "X1-OE-PM",
    "price": 58191,
    "role": "EXCAVATOR",
    "frame": "FRAME_DRONE",
    "reactor": "REACTOR_SOLAR_I",
    "engine": "ENGINE_SOLAR_PROPULSION",
    "modules": [
      "MODULE_CARGO_HOLD"
    ],
    "mounts": [
      "MOUNT_MINING_LASER_I"
    ]
  },
  "meta": {
    "total": 10,
    "page": 1,
    "limit": 10
  }
}
```

