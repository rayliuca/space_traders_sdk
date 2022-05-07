
# System

## Structure

`System`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Symbol` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `Sector` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `Type` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `X` | `int` | Required | - |
| `Y` | `int` | Required | - |
| `Waypoints` | `List<string>` | Required | - |
| `Factions` | `List<string>` | Required | - |
| `Charted` | `bool` | Required | - |
| `ChartedBy` | `string` | Optional | - |

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

