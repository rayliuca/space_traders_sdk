# Contracts

```php
$contractsController = $client->getContractsController();
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

```php
function postMyShipsShipSymbolDeliver(
    string $shipSymbol,
    ?MyShipsDeliverRequest $body = null
): MyShipsDeliverResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `shipSymbol` | `string` | Template, Required | The symbol of the ship |
| `body` | [`?MyShipsDeliverRequest`](../../doc/models/my-ships-deliver-request.md) | Body, Optional | - |

## Response Type

[`MyShipsDeliverResponse`](../../doc/models/my-ships-deliver-response.md)

## Example Usage

```php
$shipSymbol = 'shipSymbol2';

$result = $contractsController->postMyShipsShipSymbolDeliver($shipSymbol);
```


# Get-My-Contracts

List all of your contracts.

```php
function getMyContracts(): MyContractsResponse
```

## Response Type

[`MyContractsResponse`](../../doc/models/my-contracts-response.md)

## Example Usage

```php
$result = $contractsController->getMyContracts();
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

```php
function getMyContractsContractId(string $contractId): MyContractsResponse1
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `contractId` | `string` | Template, Required | The contract ID |

## Response Type

[`MyContractsResponse1`](../../doc/models/my-contracts-response-1.md)

## Example Usage

```php
$contractId = 'contractId2';

$result = $contractsController->getMyContractsContractId($contractId);
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

```php
function postMyContractsContractIdAccept(string $contractId): MyContractsAcceptResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `contractId` | `string` | Template, Required | - |

## Response Type

[`MyContractsAcceptResponse`](../../doc/models/my-contracts-accept-response.md)

## Example Usage

```php
$contractId = 'contractId2';

$result = $contractsController->postMyContractsContractIdAccept($contractId);
```

