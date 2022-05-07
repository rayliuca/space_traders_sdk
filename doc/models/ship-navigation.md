
# Ship Navigation

## Structure

`ShipNavigation`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `shipSymbol` | `string` | Required | **Constraints**: *Minimum Length*: `1` | getShipSymbol(): string | setShipSymbol(string shipSymbol): void |
| `departure` | `string` | Required | **Constraints**: *Minimum Length*: `1` | getDeparture(): string | setDeparture(string departure): void |
| `destination` | `string` | Required | **Constraints**: *Minimum Length*: `1` | getDestination(): string | setDestination(string destination): void |
| `durationRemaining` | `int` | Required | - | getDurationRemaining(): int | setDurationRemaining(int durationRemaining): void |
| `arrivedAt` | `?array` | Optional | - | getArrivedAt(): ?array | setArrivedAt(?array arrivedAt): void |

## Example (as JSON)

```json
{
  "shipSymbol": "3AE434-1",
  "departure": "X1-OE-PM",
  "destination": "X1-OE-A005",
  "durationRemaining": 2159,
  "arrivedAt": null
}
```

