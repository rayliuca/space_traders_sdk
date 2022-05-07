
# Ship Navigation

## Structure

`ShipNavigation`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `ShipSymbol` | `String` | Required | **Constraints**: *Minimum Length*: `1` | String getShipSymbol() | setShipSymbol(String shipSymbol) |
| `Departure` | `String` | Required | **Constraints**: *Minimum Length*: `1` | String getDeparture() | setDeparture(String departure) |
| `Destination` | `String` | Required | **Constraints**: *Minimum Length*: `1` | String getDestination() | setDestination(String destination) |
| `DurationRemaining` | `int` | Required | - | int getDurationRemaining() | setDurationRemaining(int durationRemaining) |
| `ArrivedAt` | `Object` | Optional | - | Object getArrivedAt() | setArrivedAt(Object arrivedAt) |

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

