
# Contract

## Structure

`Contract`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `Faction` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `Type` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `Terms` | [`Models.Terms`](../../doc/models/terms.md) | Required | - |
| `Accepted` | `bool` | Required | - |
| `Fulfilled` | `bool` | Required | - |
| `ExpiresAt` | `string` | Required | **Constraints**: *Minimum Length*: `1` |

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

