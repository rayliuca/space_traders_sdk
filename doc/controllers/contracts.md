# Contracts

```csharp
ContractsController contractsController = client.ContractsController;
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

```csharp
PostMyShipsShipSymbolDeliverAsync(
    string shipSymbol,
    Models.MyShipsDeliverRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `shipSymbol` | `string` | Template, Required | The symbol of the ship |
| `body` | [`Models.MyShipsDeliverRequest`](../../doc/models/my-ships-deliver-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.MyShipsDeliverResponse>`](../../doc/models/my-ships-deliver-response.md)

## Example Usage

```csharp
string shipSymbol = "shipSymbol2";

try
{
    MyShipsDeliverResponse result = await contractsController.PostMyShipsShipSymbolDeliverAsync(shipSymbol, null);
}
catch (ApiException e){};
```


# Get-My-Contracts

List all of your contracts.

```csharp
GetMyContractsAsync()
```

## Response Type

[`Task<Models.MyContractsResponse>`](../../doc/models/my-contracts-response.md)

## Example Usage

```csharp
try
{
    MyContractsResponse result = await contractsController.GetMyContractsAsync();
}
catch (ApiException e){};
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

```csharp
GetMyContractsContractIdAsync(
    string contractId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `contractId` | `string` | Template, Required | The contract ID |

## Response Type

[`Task<Models.MyContractsResponse1>`](../../doc/models/my-contracts-response-1.md)

## Example Usage

```csharp
string contractId = "contractId2";

try
{
    MyContractsResponse1 result = await contractsController.GetMyContractsContractIdAsync(contractId);
}
catch (ApiException e){};
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

```csharp
PostMyContractsContractIdAcceptAsync(
    string contractId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `contractId` | `string` | Template, Required | - |

## Response Type

[`Task<Models.MyContractsAcceptResponse>`](../../doc/models/my-contracts-accept-response.md)

## Example Usage

```csharp
string contractId = "contractId2";

try
{
    MyContractsAcceptResponse result = await contractsController.PostMyContractsContractIdAcceptAsync(contractId);
}
catch (ApiException e){};
```

