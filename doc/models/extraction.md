
# Extraction

## Structure

`Extraction`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `ShipSymbol` | `String` | Required | **Constraints**: *Minimum Length*: `1` | String getShipSymbol() | setShipSymbol(String shipSymbol) |
| `Yield` | [`Yield`](../../doc/models/yield.md) | Required | - | Yield getYield() | setYield(Yield yield) |

## Example (as JSON)

```json
{
  "shipSymbol": "4B902A-1",
  "yield": {
    "tradeSymbol": "SILICON",
    "units": 16
  }
}
```

