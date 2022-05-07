
# Agents Request

## Structure

`AgentsRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `symbol` | `?string` | Optional | How other agents will see your ships and information.<br>**Constraints**: *Minimum Length*: `4`, *Maximum Length*: `8` | getSymbol(): ?string | setSymbol(?string symbol): void |
| `faction` | `?string` | Optional | The faction you choose determines your headquarters.<br>**Default**: `'COMMERCE_REPUBLIC'` | getFaction(): ?string | setFaction(?string faction): void |

## Example (as JSON)

```json
{
  "symbol": null,
  "faction": null
}
```

