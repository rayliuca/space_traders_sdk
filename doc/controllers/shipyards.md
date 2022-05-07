# Shipyards

```csharp
ShipyardsController shipyardsController = client.ShipyardsController;
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

```csharp
PostMyShipsAsync(
    Models.MyShipsRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.MyShipsRequest`](../../doc/models/my-ships-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.MyShipsResponse2>`](../../doc/models/my-ships-response-2.md)

## Example Usage

```csharp
try
{
    MyShipsResponse2 result = await shipyardsController.PostMyShipsAsync(null);
}
catch (ApiException e){};
```


# Get-Systems-System Symbol-Shipyards

Returns a list of all shipyards in a system.

```csharp
GetSystemsSystemSymbolShipyardsAsync(
    string systemSymbol)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `systemSymbol` | `string` | Template, Required | the system symbol |

## Response Type

[`Task<Models.SystemsShipyardsResponse>`](../../doc/models/systems-shipyards-response.md)

## Example Usage

```csharp
string systemSymbol = "systemSymbol4";

try
{
    SystemsShipyardsResponse result = await shipyardsController.GetSystemsSystemSymbolShipyardsAsync(systemSymbol);
}
catch (ApiException e){};
```


# Get-Systems-System Symbol-Shipyards-Waypoint Symbol

Shipyard Details

```csharp
GetSystemsSystemSymbolShipyardsWaypointSymbolAsync(
    string systemSymbol,
    string waypointSymbol)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `systemSymbol` | `string` | Template, Required | The system symbol |
| `waypointSymbol` | `string` | Template, Required | The waypoint symbol |

## Response Type

[`Task<Models.SystemsShipyardsResponse1>`](../../doc/models/systems-shipyards-response-1.md)

## Example Usage

```csharp
string systemSymbol = "systemSymbol4";
string waypointSymbol = "waypointSymbol2";

try
{
    SystemsShipyardsResponse1 result = await shipyardsController.GetSystemsSystemSymbolShipyardsWaypointSymbolAsync(systemSymbol, waypointSymbol);
}
catch (ApiException e){};
```


# Get-Systems-System Symbol-Shipyards-Waypoint Symbol-Ships

Shipyard Listings

```csharp
GetSystemsSystemSymbolShipyardsWaypointSymbolShipsAsync(
    string systemSymbol,
    string waypointSymbol)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `systemSymbol` | `string` | Template, Required | The system symbol |
| `waypointSymbol` | `string` | Template, Required | The waypoint symbol |

## Response Type

[`Task<Models.SystemsShipyardsShipsResponse>`](../../doc/models/systems-shipyards-ships-response.md)

## Example Usage

```csharp
string systemSymbol = "systemSymbol4";
string waypointSymbol = "waypointSymbol2";

try
{
    SystemsShipyardsShipsResponse result = await shipyardsController.GetSystemsSystemSymbolShipyardsWaypointSymbolShipsAsync(systemSymbol, waypointSymbol);
}
catch (ApiException e){};
```

