
# Waypoint

## Structure

`Waypoint`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `system` | `string` | Required | **Constraints**: *Minimum Length*: `1` | getSystem(): string | setSystem(string system): void |
| `symbol` | `string` | Required | **Constraints**: *Minimum Length*: `1` | getSymbol(): string | setSymbol(string symbol): void |
| `type` | `string` | Required | **Constraints**: *Minimum Length*: `1` | getType(): string | setType(string type): void |
| `x` | `int` | Required | - | getX(): int | setX(int x): void |
| `y` | `int` | Required | - | getY(): int | setY(int y): void |
| `orbitals` | `string[]` | Required | - | getOrbitals(): array | setOrbitals(array orbitals): void |
| `faction` | `string` | Required | **Constraints**: *Minimum Length*: `1` | getFaction(): string | setFaction(string faction): void |
| `features` | `string[]` | Required | - | getFeatures(): array | setFeatures(array features): void |
| `traits` | `string[]` | Required | - | getTraits(): array | setTraits(array traits): void |
| `charted` | `bool` | Required | - | getCharted(): bool | setCharted(bool charted): void |
| `chartedBy` | `?string` | Optional | - | getChartedBy(): ?string | setChartedBy(?string chartedBy): void |

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

