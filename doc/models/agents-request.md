
# Agents Request

## Structure

`AgentsRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Symbol` | `String` | Optional | How other agents will see your ships and information.<br>**Constraints**: *Minimum Length*: `4`, *Maximum Length*: `8` | String getSymbol() | setSymbol(String symbol) |
| `Faction` | `String` | Optional | The faction you choose determines your headquarters.<br>**Default**: `"COMMERCE_REPUBLIC"` | String getFaction() | setFaction(String faction) |

## Example (as JSON)

```json
{
  "symbol": null,
  "faction": null
}
```

