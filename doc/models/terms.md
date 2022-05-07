
# Terms

## Structure

`Terms`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Deadline` | `String` | Required | **Constraints**: *Minimum Length*: `1` | String getDeadline() | setDeadline(String deadline) |
| `Payment` | [`Payment`](../../doc/models/payment.md) | Required | - | Payment getPayment() | setPayment(Payment payment) |
| `Deliver` | [`List<Deliver>`](../../doc/models/deliver.md) | Required | **Constraints**: *Minimum Items*: `1`, *Unique Items Required* | List<Deliver> getDeliver() | setDeliver(List<Deliver> deliver) |

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

