
# Extraction

## Structure

`Extraction`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `shipSymbol` | `string` | Required | **Constraints**: *Minimum Length*: `1` | getShipSymbol(): string | setShipSymbol(string shipSymbol): void |
| `mYield` | [`MYield`](../../doc/models/m-yield.md) | Required | - | getMYield(): MYield | setMYield(MYield mYield): void |

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

