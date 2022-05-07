
# Terms

## Structure

`Terms`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `deadline` | `string` | Required | **Constraints**: *Minimum Length*: `1` | getDeadline(): string | setDeadline(string deadline): void |
| `payment` | [`Payment`](../../doc/models/payment.md) | Required | - | getPayment(): Payment | setPayment(Payment payment): void |
| `deliver` | [`Deliver[]`](../../doc/models/deliver.md) | Required | **Constraints**: *Minimum Items*: `1`, *Unique Items Required* | getDeliver(): array | setDeliver(array deliver): void |

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

