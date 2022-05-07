
# Faction

## Structure

`Faction`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Symbol` | `String` | Required | **Constraints**: *Minimum Length*: `1` | String getSymbol() | setSymbol(String symbol) |
| `Name` | `String` | Required | **Constraints**: *Minimum Length*: `1` | String getName() | setName(String name) |
| `Description` | `String` | Required | **Constraints**: *Minimum Length*: `1` | String getDescription() | setDescription(String description) |
| `Headquarters` | `String` | Required | **Constraints**: *Minimum Length*: `1` | String getHeadquarters() | setHeadquarters(String headquarters) |
| `Traits` | `List<String>` | Required | - | List<String> getTraits() | setTraits(List<String> traits) |

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

