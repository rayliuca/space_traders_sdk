
# Faction

## Structure

`Faction`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `symbol` | `string` | Required | **Constraints**: *Minimum Length*: `1` | getSymbol(): string | setSymbol(string symbol): void |
| `name` | `string` | Required | **Constraints**: *Minimum Length*: `1` | getName(): string | setName(string name): void |
| `description` | `string` | Required | **Constraints**: *Minimum Length*: `1` | getDescription(): string | setDescription(string description): void |
| `headquarters` | `string` | Required | **Constraints**: *Minimum Length*: `1` | getHeadquarters(): string | setHeadquarters(string headquarters): void |
| `traits` | `string[]` | Required | - | getTraits(): array | setTraits(array traits): void |

## Example (as JSON)

```json
{
  "symbol": "COMMERCE_REPUBLIC",
  "name": "Commerce Repubic",
  "description": "The Commerce Republic takes capital from top tier worlds and invests it into new systems with high potential for growth.",
  "headquarters": "X1-OE-PM",
  "traits": [
    "BUREAUCRATIC",
    "CAPITALISTIC",
    "GUILD",
    "ESTABLISHED"
  ]
}
```

