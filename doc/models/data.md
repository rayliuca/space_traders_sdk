
# Data

## Structure

`Data`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `TradeSymbol` | `String` | Required | **Constraints**: *Minimum Length*: `1` | String getTradeSymbol() | setTradeSymbol(String tradeSymbol) |
| `Destination` | `String` | Required | **Constraints**: *Minimum Length*: `1` | String getDestination() | setDestination(String destination) |
| `Units` | `int` | Required | - | int getUnits() | setUnits(int units) |
| `Fulfilled` | `int` | Required | - | int getFulfilled() | setFulfilled(int fulfilled) |

## Example (as JSON)

```json
{
  "tradeSymbol": "tradeSymbol8",
  "destination": "destination4",
  "units": 142,
  "fulfilled": 24
}
```

