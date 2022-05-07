
# Faction

## Structure

`Faction`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `symbol` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `name` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `description` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `headquarters` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `traits` | `List of string` | Required | - |

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

