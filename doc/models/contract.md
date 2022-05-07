
# Contract

## Structure

`Contract`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Id` | `String` | Required | **Constraints**: *Minimum Length*: `1` | String getId() | setId(String id) |
| `Faction` | `String` | Required | **Constraints**: *Minimum Length*: `1` | String getFaction() | setFaction(String faction) |
| `Type` | `String` | Required | **Constraints**: *Minimum Length*: `1` | String getType() | setType(String type) |
| `Terms` | [`Terms`](../../doc/models/terms.md) | Required | - | Terms getTerms() | setTerms(Terms terms) |
| `Accepted` | `boolean` | Required | - | boolean getAccepted() | setAccepted(boolean accepted) |
| `Fulfilled` | `boolean` | Required | - | boolean getFulfilled() | setFulfilled(boolean fulfilled) |
| `ExpiresAt` | `String` | Required | **Constraints**: *Minimum Length*: `1` | String getExpiresAt() | setExpiresAt(String expiresAt) |

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

