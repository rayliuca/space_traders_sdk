
# Contract

## Structure

`Contract`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `faction` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `mtype` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `terms` | [`Terms`](../../doc/models/terms.md) | Required | - |
| `accepted` | `bool` | Required | - |
| `fulfilled` | `bool` | Required | - |
| `expires_at` | `string` | Required | **Constraints**: *Minimum Length*: `1` |

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

