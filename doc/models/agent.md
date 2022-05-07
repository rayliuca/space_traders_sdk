
# Agent

## Structure

`Agent`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `accountId` | `string` | Required | **Constraints**: *Minimum Length*: `1` | getAccountId(): string | setAccountId(string accountId): void |
| `symbol` | `string` | Required | **Constraints**: *Minimum Length*: `1` | getSymbol(): string | setSymbol(string symbol): void |
| `headquarters` | `string` | Required | **Constraints**: *Minimum Length*: `1` | getHeadquarters(): string | setHeadquarters(string headquarters): void |
| `credits` | `int` | Required | - | getCredits(): int | setCredits(int credits): void |

## Example (as JSON)

```json
{
  "accountId": "cl0hok34m0003ks0jjql5q8f2",
  "symbol": "EMBER",
  "headquarters": "X1-OE-PM",
  "credits": 0
}
```

