
# Data 13

## Structure

`Data13`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `ships` | [`ScannedShip[]`](../../doc/models/scanned-ship.md) | Required | **Constraints**: *Minimum Items*: `1`, *Unique Items Required* | getShips(): array | setShips(array ships): void |
| `cooldown` | [`Cooldown`](../../doc/models/cooldown.md) | Required | - | getCooldown(): Cooldown | setCooldown(Cooldown cooldown): void |

## Example (as JSON)

```json
{
  "ships": null,
  "cooldown": {
    "duration": 119,
    "expiration": "2022-03-12T00:41:29.285Z"
  }
}
```

