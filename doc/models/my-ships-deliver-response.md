
# My Ships Deliver Response

## Structure

`MyShipsDeliverResponse`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Data` | [`ContractDelivery`](../../doc/models/contract-delivery.md) | Required | - | ContractDelivery getData() | setData(ContractDelivery data) |

## Example (as JSON)

```json
{
  "data": {
    "data": {
      "tradeSymbol": "IRON_ORE",
      "destination": "X1-OE-PM",
      "units": 10000,
      "fulfilled": 500
    }
  }
}
```

