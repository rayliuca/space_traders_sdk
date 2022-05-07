
# Waypoint

## Structure

`Waypoint`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `System` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `Symbol` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `Type` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `X` | `int` | Required | - |
| `Y` | `int` | Required | - |
| `Orbitals` | `List<string>` | Required | - |
| `Faction` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `Features` | `List<string>` | Required | - |
| `Traits` | `List<string>` | Required | - |
| `Charted` | `bool` | Required | - |
| `ChartedBy` | `string` | Optional | - |

## Example (as JSON)

```json
{
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
}
```

