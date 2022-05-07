
# Survey

## Structure

`Survey`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `signature` | `string` | Required | **Constraints**: *Minimum Length*: `1` | getSignature(): string | setSignature(string signature): void |
| `deposits` | `string[]` | Required | - | getDeposits(): array | setDeposits(array deposits): void |
| `expiration` | `string` | Required | **Constraints**: *Minimum Length*: `1` | getExpiration(): string | setExpiration(string expiration): void |

## Example (as JSON)

```json
{
  "signature": "X1-OE-D2DD38",
  "deposits": [
    "COPPER_ORE"
  ],
  "expiration": "2022-03-08T05:41:55.514Z"
}
```

