# Contracts

```python
contracts_controller = client.contracts
```

## Class Name

`ContractsController`

## Methods

* [Post-My-Ships-Ship Symbol-Deliver](../../doc/controllers/contracts.md#post-my-ships-ship-symbol-deliver)
* [Get-My-Contracts](../../doc/controllers/contracts.md#get-my-contracts)
* [Get-My-Contracts-Contract Id](../../doc/controllers/contracts.md#get-my-contracts-contract-id)
* [Post-My-Contracts-Contract Id-Accept](../../doc/controllers/contracts.md#post-my-contracts-contract-id-accept)


# Post-My-Ships-Ship Symbol-Deliver

Deliver cargo on a given contract.

```python
def post_my_ships_ship_symbol_deliver(self,
                                     ship_symbol,
                                     body=None)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ship_symbol` | `string` | Template, Required | The symbol of the ship |
| `body` | [`MyShipsDeliverRequest`](../../doc/models/my-ships-deliver-request.md) | Body, Optional | - |

## Response Type

[`MyShipsDeliverResponse`](../../doc/models/my-ships-deliver-response.md)

## Example Usage

```python
ship_symbol = 'shipSymbol2'

result = contracts_controller.post_my_ships_ship_symbol_deliver(ship_symbol)
```


# Get-My-Contracts

List all of your contracts.

```python
def get_my_contracts(self)
```

## Response Type

[`MyContractsResponse`](../../doc/models/my-contracts-response.md)

## Example Usage

```python
result = contracts_controller.get_my_contracts()
```

## Example Response *(as JSON)*

```json
{
  "data": [
    {
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
    }
  ],
  "meta": {
    "total": 10,
    "page": 1,
    "limit": 10
  }
}
```


# Get-My-Contracts-Contract Id

Get the details of a contract by ID.

```python
def get_my_contracts_contract_id(self,
                                contract_id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `contract_id` | `string` | Template, Required | The contract ID |

## Response Type

[`MyContractsResponse1`](../../doc/models/my-contracts-response-1.md)

## Example Usage

```python
contract_id = 'contractId2'

result = contracts_controller.get_my_contracts_contract_id(contract_id)
```

## Example Response *(as JSON)*

```json
{
  "data": {
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
  }
}
```


# Post-My-Contracts-Contract Id-Accept

Accept a contract.

```python
def post_my_contracts_contract_id_accept(self,
                                        contract_id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `contract_id` | `string` | Template, Required | - |

## Response Type

[`MyContractsAcceptResponse`](../../doc/models/my-contracts-accept-response.md)

## Example Usage

```python
contract_id = 'contractId2'

result = contracts_controller.post_my_contracts_contract_id_accept(contract_id)
```

