
# Systems Markets Response 1

## Structure

`SystemsMarketsResponse1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `data` | [`Data18`](../../doc/models/data-18.md) | Required | - |

## Example (as JSON)

```json
{
  "data": {
    "exports": [
      {
        "waypointSymbol": "waypointSymbol3",
        "tradeSymbol": "tradeSymbol7",
        "price": 117,
        "tariff": 241
      },
      {
        "waypointSymbol": "waypointSymbol2",
        "tradeSymbol": "tradeSymbol8",
        "price": 116,
        "tariff": 240
      }
    ],
    "imports": [
      {
        "waypointSymbol": "waypointSymbol2",
        "tradeSymbol": "tradeSymbol8",
        "price": 80,
        "tariff": 204
      },
      {
        "waypointSymbol": "waypointSymbol3",
        "tradeSymbol": "tradeSymbol7",
        "price": 81,
        "tariff": 205
      },
      {
        "waypointSymbol": "waypointSymbol4",
        "tradeSymbol": "tradeSymbol6",
        "price": 82,
        "tariff": 206
      }
    ],
    "exchange": [
      {
        "waypointSymbol": "waypointSymbol4",
        "tradeSymbol": "tradeSymbol4",
        "price": 30,
        "tariff": 162
      },
      {
        "waypointSymbol": "waypointSymbol5",
        "tradeSymbol": "tradeSymbol5",
        "price": 31,
        "tariff": 163
      }
    ]
  }
}
```

