
# Trade

## Structure

`Trade`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `WaypointSymbol` | `String` | Required | **Constraints**: *Minimum Length*: `1` | String getWaypointSymbol() | setWaypointSymbol(String waypointSymbol) |
| `TradeSymbol` | `String` | Required | **Constraints**: *Minimum Length*: `1` | String getTradeSymbol() | setTradeSymbol(String tradeSymbol) |
| `Credits` | `int` | Required | - | int getCredits() | setCredits(int credits) |
| `Units` | `int` | Required | - | int getUnits() | setUnits(int units) |

## Example (as JSON)

```json
{
  "waypointSymbol": "X1-OE-PM",
  "tradeSymbol": "MICROPROCESSORS",
  "credits": 843,
  "units": 1
}
```

