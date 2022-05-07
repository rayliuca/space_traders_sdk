
# System

## Structure

`System`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `symbol` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `sector` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `mtype` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `x` | `int` | Required | - |
| `y` | `int` | Required | - |
| `waypoints` | `List of string` | Required | - |
| `factions` | `List of string` | Required | - |
| `charted` | `bool` | Required | - |
| `charted_by` | `string` | Optional | - |

## Example (as JSON)

```json
{
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
}
```

