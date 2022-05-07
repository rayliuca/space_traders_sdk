# Contracts

```java
ContractsController contractsController = client.getContractsController();
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

```java
CompletableFuture<MyShipsDeliverResponse> postMyShipsShipSymbolDeliverAsync(
    final String shipSymbol,
    final MyShipsDeliverRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `shipSymbol` | `String` | Template, Required | The symbol of the ship |
| `body` | [`MyShipsDeliverRequest`](../../doc/models/my-ships-deliver-request.md) | Body, Optional | - |

## Response Type

[`MyShipsDeliverResponse`](../../doc/models/my-ships-deliver-response.md)

## Example Usage

```java
String shipSymbol = "shipSymbol2";

contractsController.postMyShipsShipSymbolDeliverAsync(shipSymbol, null).thenAccept(result -> {
    // TODO success callback handler
}).exceptionally(exception -> {
    // TODO failure callback handler
    return null;
});
```


# Get-My-Contracts

List all of your contracts.

```java
CompletableFuture<MyContractsResponse> getMyContractsAsync()
```

## Response Type

[`MyContractsResponse`](../../doc/models/my-contracts-response.md)

## Example Usage

```java
contractsController.getMyContractsAsync().thenAccept(result -> {
    // TODO success callback handler
}).exceptionally(exception -> {
    // TODO failure callback handler
    return null;
});
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

```java
CompletableFuture<MyContractsResponse1> getMyContractsContractIdAsync(
    final String contractId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `contractId` | `String` | Template, Required | The contract ID |

## Response Type

[`MyContractsResponse1`](../../doc/models/my-contracts-response-1.md)

## Example Usage

```java
String contractId = "contractId2";

contractsController.getMyContractsContractIdAsync(contractId).thenAccept(result -> {
    // TODO success callback handler
}).exceptionally(exception -> {
    // TODO failure callback handler
    return null;
});
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

```java
CompletableFuture<MyContractsAcceptResponse> postMyContractsContractIdAcceptAsync(
    final String contractId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `contractId` | `String` | Template, Required | - |

## Response Type

[`MyContractsAcceptResponse`](../../doc/models/my-contracts-accept-response.md)

## Example Usage

```java
String contractId = "contractId2";

contractsController.postMyContractsContractIdAcceptAsync(contractId).thenAccept(result -> {
    // TODO success callback handler
}).exceptionally(exception -> {
    // TODO failure callback handler
    return null;
});
```

