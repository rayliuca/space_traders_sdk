
# System

## Structure

`System`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `symbol` | `string` | Required | **Constraints**: *Minimum Length*: `1` | getSymbol(): string | setSymbol(string symbol): void |
| `sector` | `string` | Required | **Constraints**: *Minimum Length*: `1` | getSector(): string | setSector(string sector): void |
| `type` | `string` | Required | **Constraints**: *Minimum Length*: `1` | getType(): string | setType(string type): void |
| `x` | `int` | Required | - | getX(): int | setX(int x): void |
| `y` | `int` | Required | - | getY(): int | setY(int y): void |
| `waypoints` | `string[]` | Required | - | getWaypoints(): array | setWaypoints(array waypoints): void |
| `factions` | `string[]` | Required | - | getFactions(): array | setFactions(array factions): void |
| `charted` | `bool` | Required | - | getCharted(): bool | setCharted(bool charted): void |
| `chartedBy` | `?string` | Optional | - | getChartedBy(): ?string | setChartedBy(?string chartedBy): void |

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

