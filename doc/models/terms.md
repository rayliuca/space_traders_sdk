
# Terms

## Structure

`Terms`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `deadline` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `payment` | [`Payment`](../../doc/models/payment.md) | Required | - |
| `deliver` | [`List of Deliver`](../../doc/models/deliver.md) | Required | **Constraints**: *Minimum Items*: `1`, *Unique Items Required* |

## Example (as JSON)

```json
{
  "deadline": "deadline0",
  "payment": {
    "onAccepted": 212,
    "onFulfilled": 66
  },
  "deliver": [
    {
      "tradeSymbol": "tradeSymbol9",
      "destination": "destination3",
      "units": 211,
      "fulfilled": 211
    }
  ]
}
```

