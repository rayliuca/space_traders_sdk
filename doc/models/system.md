
# System

## Structure

`System`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Symbol` | `String` | Required | **Constraints**: *Minimum Length*: `1` | String getSymbol() | setSymbol(String symbol) |
| `Sector` | `String` | Required | **Constraints**: *Minimum Length*: `1` | String getSector() | setSector(String sector) |
| `Type` | `String` | Required | **Constraints**: *Minimum Length*: `1` | String getType() | setType(String type) |
| `X` | `int` | Required | - | int getX() | setX(int x) |
| `Y` | `int` | Required | - | int getY() | setY(int y) |
| `Waypoints` | `List<String>` | Required | - | List<String> getWaypoints() | setWaypoints(List<String> waypoints) |
| `Factions` | `List<String>` | Required | - | List<String> getFactions() | setFactions(List<String> factions) |
| `Charted` | `boolean` | Required | - | boolean getCharted() | setCharted(boolean charted) |
| `ChartedBy` | `String` | Optional | - | String getChartedBy() | setChartedBy(String chartedBy) |

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

