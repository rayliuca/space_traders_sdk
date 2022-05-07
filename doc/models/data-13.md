
# Data 13

## Structure

`Data13`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Ships` | [`List<ScannedShip>`](../../doc/models/scanned-ship.md) | Required | **Constraints**: *Minimum Items*: `1`, *Unique Items Required* | List<ScannedShip> getShips() | setShips(List<ScannedShip> ships) |
| `Cooldown` | [`Cooldown`](../../doc/models/cooldown.md) | Required | - | Cooldown getCooldown() | setCooldown(Cooldown cooldown) |

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

