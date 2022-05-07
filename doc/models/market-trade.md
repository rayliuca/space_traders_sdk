
# Market Trade

## Structure

`MarketTrade`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `waypointSymbol` | `string` | Required | **Constraints**: *Minimum Length*: `1` | getWaypointSymbol(): string | setWaypointSymbol(string waypointSymbol): void |
| `tradeSymbol` | `string` | Required | **Constraints**: *Minimum Length*: `1` | getTradeSymbol(): string | setTradeSymbol(string tradeSymbol): void |
| `price` | `int` | Required | - | getPrice(): int | setPrice(int price): void |
| `tariff` | `int` | Required | - | getTariff(): int | setTariff(int tariff): void |

## Example (as JSON)

```json
{
  "waypointSymbol": "waypointSymbol2",
  "tradeSymbol": "tradeSymbol8",
  "price": 16,
  "tariff": 140
}
```

