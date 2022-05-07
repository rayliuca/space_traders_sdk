
# Faction

## Structure

`Faction`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Symbol` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `Description` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `Headquarters` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `Traits` | `List<string>` | Required | - |

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

