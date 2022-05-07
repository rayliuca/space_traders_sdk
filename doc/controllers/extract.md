# Extract

```java
ExtractController extractController = client.getExtractController();
```

## Class Name

`ExtractController`

## Methods

* [Post-My-Ships-Ship Symbol-Extract](../../doc/controllers/extract.md#post-my-ships-ship-symbol-extract)
* [Get-My-Ships-Ship Symbol-Extract](../../doc/controllers/extract.md#get-my-ships-ship-symbol-extract)
* [Post-My-Ships-Ship Symbol-Survey](../../doc/controllers/extract.md#post-my-ships-ship-symbol-survey)
* [Get-My-Ships-Ship Symbol-Survey](../../doc/controllers/extract.md#get-my-ships-ship-symbol-survey)


# Post-My-Ships-Ship Symbol-Extract

Extract resources from the waypoint into your ship. Send a survey as the payload to target specific yields. The entire survey must be sent as it contains a signature that the backend verifies.

```java
CompletableFuture<MyShipsExtractResponse> postMyShipsShipSymbolExtractAsync(
    final String shipSymbol,
    final MyShipsExtractRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `shipSymbol` | `String` | Template, Required | The ship symbol |
| `body` | [`MyShipsExtractRequest`](../../doc/models/my-ships-extract-request.md) | Body, Optional | - |

## Response Type

[`MyShipsExtractResponse`](../../doc/models/my-ships-extract-response.md)

## Example Usage

```java
String shipSymbol = "shipSymbol2";
MyShipsExtractRequest body = new MyShipsExtractRequest();

extractController.postMyShipsShipSymbolExtractAsync(shipSymbol, body).thenAccept(result -> {
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
    "extraction": {
      "shipSymbol": "4B902A-1",
      "yield": {
        "tradeSymbol": "SILICON",
        "units": 16
      }
    },
    "cooldown": {
      "duration": 119,
      "expiration": "2022-03-12T00:41:29.371Z"
    }
  }
}
```


# Get-My-Ships-Ship Symbol-Extract

Get the status of your last extraction.

```java
CompletableFuture<MyShipsExtractResponse1> getMyShipsShipSymbolExtractAsync(
    final String shipSymbol)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `shipSymbol` | `String` | Template, Required | The ship symbol |

## Response Type

[`MyShipsExtractResponse1`](../../doc/models/my-ships-extract-response-1.md)

## Example Usage

```java
String shipSymbol = "shipSymbol2";

extractController.getMyShipsShipSymbolExtractAsync(shipSymbol).thenAccept(result -> {
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
    "cooldown": {
      "duration": 119,
      "expiration": "2022-03-12T00:41:29.285Z"
    }
  }
}
```


# Post-My-Ships-Ship Symbol-Survey

If you want to target specific yields for an extraction, you can survey a waypoint, such as an asteroid field, and send the survey in the body of the extract request. Each survey may have multiple deposits, and if a symbol shows up more than once, that indicates a higher chance of extracting that resource.

Your ship will enter a cooldown between consecutive survey requests. Surveys will eventually expire after a period of time. Multiple ships can use the same survey for extraction.

```java
CompletableFuture<MyShipsSurveyResponse> postMyShipsShipSymbolSurveyAsync(
    final String shipSymbol)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `shipSymbol` | `String` | Template, Required | - |

## Response Type

[`MyShipsSurveyResponse`](../../doc/models/my-ships-survey-response.md)

## Example Usage

```java
String shipSymbol = "shipSymbol2";

extractController.postMyShipsShipSymbolSurveyAsync(shipSymbol).thenAccept(result -> {
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
    "cooldown": {
      "duration": 899,
      "expiration": "2022-03-12T02:11:35.618Z"
    },
    "surveys": [
      {
        "signature": "X1-OE-397C82",
        "deposits": [
          "SILICON"
        ],
        "expiration": "2022-03-12T02:00:19.622Z"
      },
      {
        "signature": "X1-OE-4413F6",
        "deposits": [
          "ALUMINUM_ORE",
          "ALUMINUM_ORE",
          "COPPER_ORE",
          "IRON_ORE"
        ],
        "expiration": "2022-03-12T02:20:08.625Z"
      },
      {
        "signature": "X1-OE-E6480F",
        "deposits": [
          "ALUMINUM_ORE",
          "IRON_ORE",
          "QUARTZ",
          "SILICON"
        ],
        "expiration": "2022-03-12T02:18:00.626Z"
      },
      {
        "signature": "X1-OE-660BE9",
        "deposits": [
          "ALUMINUM_ORE"
        ],
        "expiration": "2022-03-12T02:20:45.626Z"
      },
      {
        "signature": "X1-OE-D64798",
        "deposits": [
          "COPPER_ORE",
          "QUARTZ",
          "SILICON"
        ],
        "expiration": "2022-03-12T02:07:33.626Z"
      },
      {
        "signature": "X1-OE-F799F3",
        "deposits": [
          "IRON_ORE"
        ],
        "expiration": "2022-03-12T02:23:16.627Z"
      }
    ]
  }
}
```


# Get-My-Ships-Ship Symbol-Survey

Executing a survey will initiate a cooldown for a number of seconds before you can call it again. This endpoint returns the details of your cooldown, or a 404 if there is no cooldown for the survey action.

```java
CompletableFuture<MyShipsSurveyResponse1> getMyShipsShipSymbolSurveyAsync(
    final String shipSymbol)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `shipSymbol` | `String` | Template, Required | - |

## Response Type

[`MyShipsSurveyResponse1`](../../doc/models/my-ships-survey-response-1.md)

## Example Usage

```java
String shipSymbol = "shipSymbol2";

extractController.getMyShipsShipSymbolSurveyAsync(shipSymbol).thenAccept(result -> {
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
    "cooldown": {
      "duration": 899,
      "expiration": "2022-03-12T02:11:35.618Z"
    }
  }
}
```

