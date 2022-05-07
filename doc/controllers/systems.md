# Systems

```java
SystemsController systemsController = client.getSystemsController();
```

## Class Name

`SystemsController`

## Methods

* [Post-My-Ships- ship Symbol-Chart](../../doc/controllers/systems.md#post-my-ships--ship-symbol-chart)
* [Get-Systems](../../doc/controllers/systems.md#get-systems)
* [Get-Systems-System Symbol](../../doc/controllers/systems.md#get-systems-system-symbol)
* [Get-Systems-System Symbol-Waypoints-Waypoint Symbol](../../doc/controllers/systems.md#get-systems-system-symbol-waypoints-waypoint-symbol)
* [Get-Systems-System Symbol-Waypoints](../../doc/controllers/systems.md#get-systems-system-symbol-waypoints)


# Post-My-Ships- ship Symbol-Chart

Chart a new system or waypoint. Returns an array of the symbols that have been charted, including the system and the waypoint if both were uncharted, or just the waypoint.

```java
CompletableFuture<MyShipsChartResponse> postMyShipsShipSymbolChartAsync(
    final String shipSymbol)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `shipSymbol` | `String` | Template, Required | The symbol of the ship |

## Response Type

[`MyShipsChartResponse`](../../doc/models/my-ships-chart-response.md)

## Example Usage

```java
String shipSymbol = "shipSymbol2";

systemsController.postMyShipsShipSymbolChartAsync(shipSymbol).thenAccept(result -> {
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
    "submitted": [
      "X1-ZZ",
      "X1-ZZ-7-EE"
    ]
  }
}
```


# Get-Systems

Return a list of all systems.

```java
CompletableFuture<SystemsResponse> getSystemsAsync()
```

## Response Type

[`SystemsResponse`](../../doc/models/systems-response.md)

## Example Usage

```java
systemsController.getSystemsAsync().thenAccept(result -> {
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
      "symbol": "X1-OE",
      "sector": "X1",
      "type": "RED_STAR",
      "x": 0,
      "y": 0,
      "waypoints": [
        "X1-OE-PM",
        "X1-OE-PM01",
        "X1-OE-A005",
        "X1-OE-25X"
      ],
      "factions": [
        "COMMERCE_REPUBLIC",
        "MINERS_COLLECTIVE",
        "SPACERS_GUILD"
      ],
      "charted": true,
      "chartedBy": null
    }
  ],
  "meta": {
    "total": 0,
    "page": 0,
    "limit": 0
  }
}
```


# Get-Systems-System Symbol

View System

```java
CompletableFuture<SystemsResponse1> getSystemsSystemSymbolAsync(
    final String systemSymbol)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `systemSymbol` | `String` | Template, Required | The system symbol |

## Response Type

[`SystemsResponse1`](../../doc/models/systems-response-1.md)

## Example Usage

```java
String systemSymbol = "X1-OE";

systemsController.getSystemsSystemSymbolAsync(systemSymbol).thenAccept(result -> {
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
    "symbol": "X1-ZZ",
    "sector": "X1",
    "type": "BLUE_STAR",
    "x": -2,
    "y": 9,
    "waypoints": [],
    "factions": [],
    "charted": false,
    "chartedBy": null
  }
}
```


# Get-Systems-System Symbol-Waypoints-Waypoint Symbol

Fetch all of the waypoints for a given system. System must be charted or a ship must be present to return waypoint details.

```java
CompletableFuture<SystemsWaypointsResponse> getSystemsSystemSymbolWaypointsWaypointSymbolAsync(
    final String systemSymbol)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `systemSymbol` | `String` | Template, Required | The system symbol |

## Response Type

[`SystemsWaypointsResponse`](../../doc/models/systems-waypoints-response.md)

## Example Usage

```java
String systemSymbol = "systemSymbol4";

systemsController.getSystemsSystemSymbolWaypointsWaypointSymbolAsync(systemSymbol).thenAccept(result -> {
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
      "system": "X1-OE",
      "symbol": "X1-OE-PM",
      "type": "PLANET",
      "x": 10,
      "y": 5,
      "orbitals": [
        "X1-OE-PM01"
      ],
      "faction": "COMMERCE_REPUBLIC",
      "features": [
        "MARKETPLACE",
        "SHIPYARD"
      ],
      "traits": [
        "OVERCROWDED",
        "HIGH_TECH",
        "BUREAUCRATIC",
        "TRADING_HUB",
        "TEMPERATE"
      ],
      "charted": true,
      "chartedBy": null
    },
    {
      "system": "X1-OE",
      "symbol": "X1-OE-PM01",
      "type": "MOON",
      "x": 10,
      "y": 5,
      "orbitals": [],
      "faction": "COMMERCE_REPUBLIC",
      "features": [
        "MARKETPLACE"
      ],
      "traits": [
        "WEAK_GRAVITY"
      ],
      "charted": true,
      "chartedBy": null
    },
    {
      "system": "X1-OE",
      "symbol": "X1-OE-A005",
      "type": "ASTEROID_FIELD",
      "x": -1,
      "y": -29,
      "orbitals": [],
      "faction": "MINERS_COLLECTIVE",
      "features": [],
      "traits": [
        "COMMON_METAL_DEPOSITS"
      ],
      "charted": true,
      "chartedBy": null
    },
    {
      "system": "X1-OE",
      "symbol": "X1-OE-25X",
      "type": "JUMP_GATE",
      "x": -38,
      "y": 47,
      "orbitals": [],
      "faction": "SPACERS_GUILD",
      "features": [],
      "traits": [],
      "charted": true,
      "chartedBy": null
    }
  ],
  "meta": {
    "total": 4,
    "page": 1,
    "limit": 20
  }
}
```


# Get-Systems-System Symbol-Waypoints

View the details of a waypoint.

```java
CompletableFuture<SystemsWaypointsResponse> getSystemsSystemSymbolWaypointsAsync(
    final String systemSymbol,
    final String waypointSymbol)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `systemSymbol` | `String` | Template, Required | The system symbol |
| `waypointSymbol` | `String` | Template, Required | The waypoint symbol |

## Response Type

[`SystemsWaypointsResponse`](../../doc/models/systems-waypoints-response.md)

## Example Usage

```java
String systemSymbol = "systemSymbol4";
String waypointSymbol = "waypointSymbol2";

systemsController.getSystemsSystemSymbolWaypointsAsync(systemSymbol, waypointSymbol).thenAccept(result -> {
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
      "system": "X1-OE",
      "symbol": "X1-OE-PM",
      "type": "PLANET",
      "x": 10,
      "y": 5,
      "orbitals": [
        "X1-OE-PM01"
      ],
      "faction": "COMMERCE_REPUBLIC",
      "features": [
        "MARKETPLACE",
        "SHIPYARD"
      ],
      "traits": [
        "OVERCROWDED",
        "HIGH_TECH",
        "BUREAUCRATIC",
        "TRADING_HUB",
        "TEMPERATE"
      ],
      "charted": true,
      "chartedBy": null
    },
    {
      "system": "X1-OE",
      "symbol": "X1-OE-PM01",
      "type": "MOON",
      "x": 10,
      "y": 5,
      "orbitals": [],
      "faction": "COMMERCE_REPUBLIC",
      "features": [
        "MARKETPLACE"
      ],
      "traits": [
        "WEAK_GRAVITY"
      ],
      "charted": true,
      "chartedBy": null
    },
    {
      "system": "X1-OE",
      "symbol": "X1-OE-A005",
      "type": "ASTEROID_FIELD",
      "x": -1,
      "y": -29,
      "orbitals": [],
      "faction": "MINERS_COLLECTIVE",
      "features": [],
      "traits": [
        "COMMON_METAL_DEPOSITS"
      ],
      "charted": true,
      "chartedBy": null
    },
    {
      "system": "X1-OE",
      "symbol": "X1-OE-25X",
      "type": "JUMP_GATE",
      "x": -38,
      "y": 47,
      "orbitals": [],
      "faction": "SPACERS_GUILD",
      "features": [],
      "traits": [],
      "charted": true,
      "chartedBy": null
    }
  ],
  "meta": {
    "total": 4,
    "page": 1,
    "limit": 20
  }
}
```

