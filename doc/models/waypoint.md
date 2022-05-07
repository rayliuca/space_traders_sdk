
# Waypoint

## Structure

`Waypoint`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `system` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `symbol` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `mtype` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `x` | `int` | Required | - |
| `y` | `int` | Required | - |
| `orbitals` | `List of string` | Required | - |
| `faction` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `features` | `List of string` | Required | - |
| `traits` | `List of string` | Required | - |
| `charted` | `bool` | Required | - |
| `charted_by` | `string` | Optional | - |

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

