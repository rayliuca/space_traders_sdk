
# Waypoint

## Structure

`Waypoint`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `System` | `String` | Required | **Constraints**: *Minimum Length*: `1` | String getSystem() | setSystem(String system) |
| `Symbol` | `String` | Required | **Constraints**: *Minimum Length*: `1` | String getSymbol() | setSymbol(String symbol) |
| `Type` | `String` | Required | **Constraints**: *Minimum Length*: `1` | String getType() | setType(String type) |
| `X` | `int` | Required | - | int getX() | setX(int x) |
| `Y` | `int` | Required | - | int getY() | setY(int y) |
| `Orbitals` | `List<String>` | Required | - | List<String> getOrbitals() | setOrbitals(List<String> orbitals) |
| `Faction` | `String` | Required | **Constraints**: *Minimum Length*: `1` | String getFaction() | setFaction(String faction) |
| `Features` | `List<String>` | Required | - | List<String> getFeatures() | setFeatures(List<String> features) |
| `Traits` | `List<String>` | Required | - | List<String> getTraits() | setTraits(List<String> traits) |
| `Charted` | `boolean` | Required | - | boolean getCharted() | setCharted(boolean charted) |
| `ChartedBy` | `String` | Optional | - | String getChartedBy() | setChartedBy(String chartedBy) |

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

