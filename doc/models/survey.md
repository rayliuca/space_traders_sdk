
# Survey

## Structure

`Survey`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Signature` | `String` | Required | **Constraints**: *Minimum Length*: `1` | String getSignature() | setSignature(String signature) |
| `Deposits` | `List<String>` | Required | - | List<String> getDeposits() | setDeposits(List<String> deposits) |
| `Expiration` | `String` | Required | **Constraints**: *Minimum Length*: `1` | String getExpiration() | setExpiration(String expiration) |

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

