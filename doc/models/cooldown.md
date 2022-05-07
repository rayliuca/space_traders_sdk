
# Cooldown

## Structure

`Cooldown`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `duration` | `int` | Required | - | getDuration(): int | setDuration(int duration): void |
| `expiration` | `string` | Required | **Constraints**: *Minimum Length*: `1` | getExpiration(): string | setExpiration(string expiration): void |

## Example (as JSON)

```json
{
  "duration": 119,
  "expiration": "2022-03-12T00:41:29.285Z"
}
```

