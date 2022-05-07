
# Data 6

## Structure

`Data6`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Extraction` | [`Extraction`](../../doc/models/extraction.md) | Required | - | Extraction getExtraction() | setExtraction(Extraction extraction) |
| `Cooldown` | [`Cooldown`](../../doc/models/cooldown.md) | Required | - | Cooldown getCooldown() | setCooldown(Cooldown cooldown) |

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

