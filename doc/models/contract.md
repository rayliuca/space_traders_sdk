
# Contract

## Structure

`Contract`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `id` | `string` | Required | **Constraints**: *Minimum Length*: `1` | getId(): string | setId(string id): void |
| `faction` | `string` | Required | **Constraints**: *Minimum Length*: `1` | getFaction(): string | setFaction(string faction): void |
| `type` | `string` | Required | **Constraints**: *Minimum Length*: `1` | getType(): string | setType(string type): void |
| `terms` | [`Terms`](../../doc/models/terms.md) | Required | - | getTerms(): Terms | setTerms(Terms terms): void |
| `accepted` | `bool` | Required | - | getAccepted(): bool | setAccepted(bool accepted): void |
| `fulfilled` | `bool` | Required | - | getFulfilled(): bool | setFulfilled(bool fulfilled): void |
| `expiresAt` | `string` | Required | **Constraints**: *Minimum Length*: `1` | getExpiresAt(): string | setExpiresAt(string expiresAt): void |

## Example (as JSON)

```json
{
  "id": "cl0hok38t0014ks0jnoy8o5vh",
  "faction": "COMMERCE_REPUBLIC",
  "type": "PROCUREMENT",
  "terms": {
    "deadline": "2022-03-11T05:16:59.113Z",
    "payment": {
      "onAccepted": 20000,
      "onFulfilled": 100000
    },
    "deliver": [
      {
        "tradeSymbol": "IRON_ORE",
        "destination": "X1-OE-PM",
        "units": 10000,
        "fulfilled": 0
      }
    ]
  },
  "accepted": false,
  "fulfilled": false,
  "expiresAt": "2022-03-09T05:16:59.112Z"
}
```

