
# Ship Navigation

## Structure

`ShipNavigation`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ship_symbol` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `departure` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `destination` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `duration_remaining` | `int` | Required | - |
| `arrived_at` | `object` | Optional | - |

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

