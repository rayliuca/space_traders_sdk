
# Market Trade

## Structure

`MarketTrade`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `WaypointSymbol` | `String` | Required | **Constraints**: *Minimum Length*: `1` | String getWaypointSymbol() | setWaypointSymbol(String waypointSymbol) |
| `TradeSymbol` | `String` | Required | **Constraints**: *Minimum Length*: `1` | String getTradeSymbol() | setTradeSymbol(String tradeSymbol) |
| `Price` | `int` | Required | - | int getPrice() | setPrice(int price) |
| `Tariff` | `int` | Required | - | int getTariff() | setTariff(int tariff) |

## Example (as JSON)

```json
{
  "waypointSymbol": "waypointSymbol2",
  "tradeSymbol": "tradeSymbol8",
  "price": 16,
  "tariff": 140
}
```

