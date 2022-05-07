
# My Contracts Response

## Structure

`MyContractsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<Models.Contract>`](../../doc/models/contract.md) | Required | **Constraints**: *Minimum Items*: `1`, *Unique Items Required* |
| `Meta` | [`Models.Meta`](../../doc/models/meta.md) | Required | - |

## Example (as JSON)

```json
{
  "data": {
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
  },
  "meta": {
    "total": 10,
    "page": 1,
    "limit": 10
  }
}
```

