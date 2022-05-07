
# Registration 1

## Structure

`Registration1`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `factionSymbol` | `string` | Required | **Constraints**: *Minimum Length*: `1` | getFactionSymbol(): string | setFactionSymbol(string factionSymbol): void |
| `agentSymbol` | `string` | Required | **Constraints**: *Minimum Length*: `1` | getAgentSymbol(): string | setAgentSymbol(string agentSymbol): void |
| `fee` | `int` | Required | - | getFee(): int | setFee(int fee): void |
| `role` | `string` | Required | **Constraints**: *Minimum Length*: `1` | getRole(): string | setRole(string role): void |

## Example (as JSON)

```json
{
  "factionSymbol": "factionSymbol0",
  "agentSymbol": "agentSymbol2",
  "fee": 168,
  "role": "role6"
}
```

