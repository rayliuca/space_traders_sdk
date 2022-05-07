
# Survey

## Structure

`Survey`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Signature` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `Deposits` | `List<string>` | Required | - |
| `Expiration` | `string` | Required | **Constraints**: *Minimum Length*: `1` |

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

