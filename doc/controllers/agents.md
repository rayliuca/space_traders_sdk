# Agents

```python
agents_controller = client.agents
```

## Class Name

`AgentsController`

## Methods

* [Post-Agents](../../doc/controllers/agents.md#post-agents)
* [Get-My-Agent](../../doc/controllers/agents.md#get-my-agent)


# Post-Agents

Creates a new agent and ties it to a temporary Account. Use `COMMERCE_REPUBLIC` as your starting faction if you don't know any other factions to choose from.

The agent symbol is a 4-8 character string that will represent your agent. This symbol will prefix the symbol of every ship you own. Agent symbols will be cast to all uppercase characters.

A new agent will be granted an authorization token, a contract with their starting faction, a command ship with a jump drive, and one hundred thousand credits.

> #### Keep your token safe and secure
> 
> Save your token during the alpha phase. There is no way to regenerate this token without starting a new agent. In the future you will be able to generate and manage your tokens from the SpaceTraders website.

You can accept your contract using the `/my/contracts/{contractId}/accept` endpoint. You will want to navigate your command ship to a nearby asteroid field waypoint, and execute the `/my/ships/{shipSymbol}/accept` endpoint to mine various types of ores and minerals.

Return to the contract destination and execute the `/my/ships/{shipSymbol}/deliver` endpoint to deposit goods into the contract.

When your contract is fulfilled, you can call `/my/contracts/{contractId}/fulfill` to retrieve payment.

```python
def post_agents(self,
               body=None)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`AgentsRequest`](../../doc/models/agents-request.md) | Body, Optional | - |

## Response Type

[`AgentsResponse`](../../doc/models/agents-response.md)

## Example Usage

```python
result = agents_controller.post_agents()
```

## Example Response *(as JSON)*

```json
{
  "data": {
    "token": "string",
    "agent": {
      "accountId": "cl0hok34m0003ks0jjql5q8f2",
      "symbol": "EMBER",
      "headquarters": "X1-OE-PM",
      "credits": 0
    },
    "faction": {
      "symbol": "COMMERCE_REPUBLIC",
      "name": "Commerce Repubic",
      "description": "The Commerce Republic takes capital from top tier worlds and invests it into new systems with high potential for growth.",
      "headquarters": "X1-OE-PM",
      "traits": [
        "BUREAUCRATIC",
        "CAPITALISTIC",
        "GUILD",
        "ESTABLISHED"
      ]
    },
    "contract": {
      "id": "cl0hok38t0014ks0jnoy8o5vh",
      "faction": "COMMERCE_REPUBLIC",
      "type": "PROCUREMENT",
      "terms": {
        "deadline": "2022-03-11T05:16:59.113Z",
        "payment": {
          "onAccepted": 20000,
          "onFulfilled": 100000
        },
        "deliver": [
          {
            "tradeSymbol": "IRON_ORE",
            "destination": "X1-OE-PM",
            "units": 10000,
            "fulfilled": 0
          }
        ]
      },
      "accepted": false,
      "fulfilled": false,
      "expiresAt": "2022-03-09T05:16:59.112Z"
    },
    "ship": {
      "symbol": "string",
      "frame": "string",
      "reactor": "string",
      "engine": "string",
      "fuel": 0,
      "modules": [
        "string"
      ],
      "mounts": [
        "string"
      ],
      "registration": {
        "factionSymbol": "string",
        "agentSymbol": "string",
        "fee": 0,
        "role": "string"
      },
      "integrity": {
        "frame": 0,
        "reactor": 0,
        "engine": 0
      },
      "status": "string",
      "location": "string",
      "cargo": [
        {
          "tradeSymbol": "string",
          "units": 0
        }
      ]
    }
  }
}
```


# Get-My-Agent

Fetch your agent's details.

```python
def get_my_agent(self)
```

## Response Type

[`MyAgentResponse`](../../doc/models/my-agent-response.md)

## Example Usage

```python
result = agents_controller.get_my_agent()
```

## Example Response *(as JSON)*

```json
{
  "data": {
    "accountId": "cl0hok34m0003ks0jjql5q8f2",
    "symbol": "EMBER",
    "headquarters": "X1-OE-PM",
    "credits": 0
  }
}
```

