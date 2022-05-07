
# Cooldown

## Structure

`Cooldown`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Duration` | `int` | Required | - | int getDuration() | setDuration(int duration) |
| `Expiration` | `String` | Required | **Constraints**: *Minimum Length*: `1` | String getExpiration() | setExpiration(String expiration) |

## Example (as JSON)

```json
{
  "duration": 119,
  "expiration": "2022-03-12T00:41:29.285Z"
}
```

