
# Extraction

## Structure

`Extraction`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ship_symbol` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `myield` | [`Yield`](../../doc/models/yield.md) | Required | - |

## Example (as JSON)

```json
{
  "shipSymbol": "4B902A-1",
  "yield": {
    "tradeSymbol": "SILICON",
    "units": 16
  }
}
```

