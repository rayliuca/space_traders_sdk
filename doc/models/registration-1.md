
# Registration 1

## Structure

`Registration1`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `FactionSymbol` | `String` | Required | **Constraints**: *Minimum Length*: `1` | String getFactionSymbol() | setFactionSymbol(String factionSymbol) |
| `AgentSymbol` | `String` | Required | **Constraints**: *Minimum Length*: `1` | String getAgentSymbol() | setAgentSymbol(String agentSymbol) |
| `Fee` | `int` | Required | - | int getFee() | setFee(int fee) |
| `Role` | `String` | Required | **Constraints**: *Minimum Length*: `1` | String getRole() | setRole(String role) |

## Example (as JSON)

```json
{
  "factionSymbol": "factionSymbol0",
  "agentSymbol": "agentSymbol2",
  "fee": 168,
  "role": "role6"
}
```

