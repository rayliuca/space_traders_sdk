
# Agents Request

## Structure

`AgentsRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Symbol` | `string` | Optional | How other agents will see your ships and information.<br>**Constraints**: *Minimum Length*: `4`, *Maximum Length*: `8` |
| `Faction` | `string` | Optional | The faction you choose determines your headquarters.<br>**Default**: `"COMMERCE_REPUBLIC"` |

## Example (as JSON)

```json
{
  "symbol": null,
  "faction": null
}
```

