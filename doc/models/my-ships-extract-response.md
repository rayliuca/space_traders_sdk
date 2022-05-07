
# My Ships Extract Response

## Structure

`MyShipsExtractResponse`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Data` | [`Data6`](../../doc/models/data-6.md) | Required | - | Data6 getData() | setData(Data6 data) |

## Example (as JSON)

```json
{
  "data": {
    "extraction": {
      "shipSymbol": "4B902A-1",
      "yield": {
        "tradeSymbol": "SILICON",
        "units": 16
      }
    },
    "cooldown": {
      "duration": 119,
      "expiration": "2022-03-12T00:41:29.285Z"
    }
  }
}
```

