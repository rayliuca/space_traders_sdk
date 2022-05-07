
# Contract Delivery

## Structure

`ContractDelivery`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `data` | [`Data`](../../doc/models/data.md) | Required | - | getData(): Data | setData(Data data): void |

## Example (as JSON)

```json
{
  "data": {
    "tradeSymbol": "IRON_ORE",
    "destination": "X1-OE-PM",
    "units": 10000,
    "fulfilled": 500
  }
}
```

