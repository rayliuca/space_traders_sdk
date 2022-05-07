# Shipyards

```java
ShipyardsController shipyardsController = client.getShipyardsController();
```

## Class Name

`ShipyardsController`

## Methods

* [Post-My-Ships](../../doc/controllers/shipyards.md#post-my-ships)
* [Get-Systems-System Symbol-Shipyards](../../doc/controllers/shipyards.md#get-systems-system-symbol-shipyards)
* [Get-Systems-System Symbol-Shipyards-Waypoint Symbol](../../doc/controllers/shipyards.md#get-systems-system-symbol-shipyards-waypoint-symbol)
* [Get-Systems-System Symbol-Shipyards-Waypoint Symbol-Ships](../../doc/controllers/shipyards.md#get-systems-system-symbol-shipyards-waypoint-symbol-ships)


# Post-My-Ships

Purchase a ship

```java
CompletableFuture<MyShipsResponse2> postMyShipsAsync(
    final MyShipsRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`MyShipsRequest`](../../doc/models/my-ships-request.md) | Body, Optional | - |

## Response Type

[`MyShipsResponse2`](../../doc/models/my-ships-response-2.md)

## Example Usage

```java
shipyardsController.postMyShipsAsync(null).thenAccept(result -> {
    // TODO success callback handler
}).exceptionally(exception -> {
    // TODO failure callback handler
    return null;
});
```


# Get-Systems-System Symbol-Shipyards

Returns a list of all shipyards in a system.

```java
CompletableFuture<SystemsShipyardsResponse> getSystemsSystemSymbolShipyardsAsync(
    final String systemSymbol)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `systemSymbol` | `String` | Template, Required | the system symbol |

## Response Type

[`SystemsShipyardsResponse`](../../doc/models/systems-shipyards-response.md)

## Example Usage

```java
String systemSymbol = "systemSymbol4";

shipyardsController.getSystemsSystemSymbolShipyardsAsync(systemSymbol).thenAccept(result -> {
    // TODO success callback handler
}).exceptionally(exception -> {
    // TODO failure callback handler
    return null;
});
```


# Get-Systems-System Symbol-Shipyards-Waypoint Symbol

Shipyard Details

```java
CompletableFuture<SystemsShipyardsResponse1> getSystemsSystemSymbolShipyardsWaypointSymbolAsync(
    final String systemSymbol,
    final String waypointSymbol)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `systemSymbol` | `String` | Template, Required | The system symbol |
| `waypointSymbol` | `String` | Template, Required | The waypoint symbol |

## Response Type

[`SystemsShipyardsResponse1`](../../doc/models/systems-shipyards-response-1.md)

## Example Usage

```java
String systemSymbol = "systemSymbol4";
String waypointSymbol = "waypointSymbol2";

shipyardsController.getSystemsSystemSymbolShipyardsWaypointSymbolAsync(systemSymbol, waypointSymbol).thenAccept(result -> {
    // TODO success callback handler
}).exceptionally(exception -> {
    // TODO failure callback handler
    return null;
});
```


# Get-Systems-System Symbol-Shipyards-Waypoint Symbol-Ships

Shipyard Listings

```java
CompletableFuture<SystemsShipyardsShipsResponse> getSystemsSystemSymbolShipyardsWaypointSymbolShipsAsync(
    final String systemSymbol,
    final String waypointSymbol)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `systemSymbol` | `String` | Template, Required | The system symbol |
| `waypointSymbol` | `String` | Template, Required | The waypoint symbol |

## Response Type

[`SystemsShipyardsShipsResponse`](../../doc/models/systems-shipyards-ships-response.md)

## Example Usage

```java
String systemSymbol = "systemSymbol4";
String waypointSymbol = "waypointSymbol2";

shipyardsController.getSystemsSystemSymbolShipyardsWaypointSymbolShipsAsync(systemSymbol, waypointSymbol).thenAccept(result -> {
    // TODO success callback handler
}).exceptionally(exception -> {
    // TODO failure callback handler
    return null;
});
```

