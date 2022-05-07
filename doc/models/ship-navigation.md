
# Ship Navigation

## Structure

`ShipNavigation`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ShipSymbol` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `Departure` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `Destination` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `DurationRemaining` | `int` | Required | - |
| `ArrivedAt` | `object` | Optional | - |

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

