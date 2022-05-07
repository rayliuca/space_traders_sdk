
# Data 6

## Structure

`Data6`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Extraction` | [`Models.Extraction`](../../doc/models/extraction.md) | Required | - |
| `Cooldown` | [`Models.Cooldown`](../../doc/models/cooldown.md) | Required | - |

## Example (as JSON)

```json
{
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
```

