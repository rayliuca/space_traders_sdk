
# Getting Started with SpaceTraders API

## Introduction

SpaceTraders is a multiplayer sci-fi strategy game where you acquire and manage a fleet of ships across a growing and dynamic universe.

Similar to games such as Eve Online, you work with or against other players to establish trade routes, chart new systems, mine precious ores, patrol for pirates, spy on factions, and discover hidden treasures.

But what makes our game unique? SpaceTraders is entirely accessible through open and well-documented Web API endpoints. In fact, SpaceTraders doesn't have a first-class client to play the game - if you want to take it for a spin, you should try one of our community-created web clients, or use the API documentation to see how you might play a game through an API.

If this sounds fun and interesting to you, please drop into our Discord and get to know the community. We are actively working on new clients, new ideas and sharing tips for how to play the game.

```json http
{
  "method": "GET",
  "url": "https://v2-0-0.alpha.spacetraders.io",
}
```

## Building

The generated code uses the Newtonsoft Json.NET NuGet Package. If the automatic NuGet package restore is enabled, these dependencies will be installed automatically. Therefore, you will need internet access for build.

* Open the solution (SpaceTradersAPI.sln) file.

Invoke the build process using Ctrl + Shift + B shortcut key or using the Build menu as shown below.

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8, Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the MSDN Portable Class Libraries documentation.

## Installation

The following section explains how to use the SpaceTradersAPI.Standard library in a new project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the solution explorer and choose `Add -> New Project`.

![Add a new project in Visual Studio](https://apidocs.io/illustration/cs?workspaceFolder=SpaceTraders%20API-CSharp&workspaceName=SpaceTradersAPI&projectName=SpaceTradersAPI.Standard&rootNamespace=SpaceTradersAPI.Standard&step=addProject)

Next, choose `Console Application`, provide `TestConsoleProject` as the project name and click OK.

![Create a new Console Application in Visual Studio](https://apidocs.io/illustration/cs?workspaceFolder=SpaceTraders%20API-CSharp&workspaceName=SpaceTradersAPI&projectName=SpaceTradersAPI.Standard&rootNamespace=SpaceTradersAPI.Standard&step=createProject)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the `TestConsoleProject` as the start-up project. To do this, right-click on the `TestConsoleProject` and choose `Set as StartUp Project` form the context menu.

![Adding a project reference](https://apidocs.io/illustration/cs?workspaceFolder=SpaceTraders%20API-CSharp&workspaceName=SpaceTradersAPI&projectName=SpaceTradersAPI.Standard&rootNamespace=SpaceTradersAPI.Standard&step=setStartup)

### 3. Add reference of the library project

In order to use the Tester library in the new project, first we must add a project reference to the `TestConsoleProject`. First, right click on the `References` node in the solution explorer and click `Add Reference...`

![Adding a project reference](https://apidocs.io/illustration/cs?workspaceFolder=SpaceTraders%20API-CSharp&workspaceName=SpaceTradersAPI&projectName=SpaceTradersAPI.Standard&rootNamespace=SpaceTradersAPI.Standard&step=addReference)

Next, a window will be displayed where we must set the `checkbox` on `Tester.Tests` and click `OK`. By doing this, we have added a reference of the `Tester.Tests` project into the new `TestConsoleProject`.

![Creating a project reference](https://apidocs.io/illustration/cs?workspaceFolder=SpaceTraders%20API-CSharp&workspaceName=SpaceTradersAPI&projectName=SpaceTradersAPI.Standard&rootNamespace=SpaceTradersAPI.Standard&step=createReference)

### 4. Write sample code

Once the `TestConsoleProject` is created, a file named `Program.cs` will be visible in the solution explorer with an empty `Main` method. This is the entry point for the execution of the entire solution. Here, you can add code to initialize the client library and acquire the instance of a Controller class. Sample code to initialize the client library and using Controller methods is given in the subsequent sections.

![Adding a project reference](https://apidocs.io/illustration/cs?workspaceFolder=SpaceTraders%20API-CSharp&workspaceName=SpaceTradersAPI&projectName=SpaceTradersAPI.Standard&rootNamespace=SpaceTradersAPI.Standard&step=addCode)

## Test the SDK

The generated SDK also contain one or more Tests, which are contained in the Tests project. In order to invoke these test cases, you will need `NUnit 3.0 Test Adapter Extension` for Visual Studio. Once the SDK is complied, the test cases should appear in the Test Explorer window. Here, you can click `Run All` to execute these test cases.

## Initialize the API Client

**_Note:_** Documentation for the client can be found [here.](doc/client.md)

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| `Timeout` | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| `AccessToken` | `string` | The OAuth 2.0 Access Token to use for API requests. |

The API client can be initialized as follows:

```csharp
SpaceTradersAPI.Standard.SpaceTradersAPIClient client = new SpaceTradersAPI.Standard.SpaceTradersAPIClient.Builder().Build();
```

## Authorization

This API uses `OAuth 2 Bearer token`.

## List of APIs

* [Ships](doc/controllers/ships.md)
* [Markets](doc/controllers/markets.md)
* [Trade](doc/controllers/trade.md)
* [Navigation](doc/controllers/navigation.md)
* [Agents](doc/controllers/agents.md)
* [Contracts](doc/controllers/contracts.md)
* [Extract](doc/controllers/extract.md)
* [Systems](doc/controllers/systems.md)
* [Shipyards](doc/controllers/shipyards.md)

## Classes Documentation

* [Utility Classes](doc/utility-classes.md)
* [HttpRequest](doc/http-request.md)
* [HttpResponse](doc/http-response.md)
* [HttpStringResponse](doc/http-string-response.md)
* [HttpContext](doc/http-context.md)
* [HttpClientConfiguration](doc/http-client-configuration.md)
* [HttpClientConfiguration Builder](doc/http-client-configuration-builder.md)
* [IAuthManager](doc/i-auth-manager.md)
* [ApiException](doc/api-exception.md)

