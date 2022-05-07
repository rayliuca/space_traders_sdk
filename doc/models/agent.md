
# Agent

## Structure

`Agent`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AccountId` | `String` | Required | **Constraints**: *Minimum Length*: `1` | String getAccountId() | setAccountId(String accountId) |
| `Symbol` | `String` | Required | **Constraints**: *Minimum Length*: `1` | String getSymbol() | setSymbol(String symbol) |
| `Headquarters` | `String` | Required | **Constraints**: *Minimum Length*: `1` | String getHeadquarters() | setHeadquarters(String headquarters) |
| `Credits` | `int` | Required | - | int getCredits() | setCredits(int credits) |

## Example (as JSON)

```json
{
  "accountId": "cl0hok34m0003ks0jjql5q8f2",
  "symbol": "EMBER",
  "headquarters": "X1-OE-PM",
  "credits": 0
}
```

