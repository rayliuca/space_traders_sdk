// <copyright file="AgentsControllerTest.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace SpaceTradersAPI.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Threading.Tasks;
    using Newtonsoft.Json.Converters;
    using NUnit.Framework;
    using SpaceTradersAPI.Standard;
    using SpaceTradersAPI.Standard.Controllers;
    using SpaceTradersAPI.Standard.Exceptions;
    using SpaceTradersAPI.Standard.Http.Client;
    using SpaceTradersAPI.Standard.Http.Response;
    using SpaceTradersAPI.Standard.Utilities;
    using SpaceTradersAPI.Tests.Helpers;

    /// <summary>
    /// AgentsControllerTest.
    /// </summary>
    [TestFixture]
    public class AgentsControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private AgentsController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.AgentsController;
        }

        /// <summary>
        /// Creates a new agent and ties it to a temporary Account. Use `COMMERCE_REPUBLIC` as your starting faction if you don't know any other factions to choose from.
        ///
        ///The agent symbol is a 4-8 character string that will represent your agent. This symbol will prefix the symbol of every ship you own. Agent symbols will be cast to all uppercase characters.
        ///
        ///A new agent will be granted an authorization token, a contract with their starting faction, a command ship with a jump drive, and one hundred thousand credits.
        ///
        ///> #### Keep your token safe and secure
        ///>
        ///> Save your token during the alpha phase. There is no way to regenerate this token without starting a new agent. In the future you will be able to generate and manage your tokens from the SpaceTraders website.
        ///
        ///You can accept your contract using the `/my/contracts/{contractId}/accept` endpoint. You will want to navigate your command ship to a nearby asteroid field waypoint, and execute the `/my/ships/{shipSymbol}/accept` endpoint to mine various types of ores and minerals.
        ///
        ///Return to the contract destination and execute the `/my/ships/{shipSymbol}/deliver` endpoint to deposit goods into the contract.
        ///
        ///When your contract is fulfilled, you can call `/my/contracts/{contractId}/fulfill` to retrieve payment..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestPostAgents()
        {
            // Parameters for the API call
            Standard.Models.AgentsRequest body = null;

            // Perform API call
            Standard.Models.AgentsResponse result = null;
            try
            {
                result = await this.controller.PostAgentsAsync(body);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(201, this.HttpCallBackHandler.Response.StatusCode, "Status should be 201");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    this.HttpCallBackHandler.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsJsonObjectProperSubsetOf(
                    "{\"data\":{\"token\":\"string\",\"agent\":{\"accountId\":\"cl0hok34m0003ks0jjql5q8f2\",\"symbol\":\"EMBER\",\"headquarters\":\"X1-OE-PM\",\"credits\":0},\"faction\":{\"symbol\":\"COMMERCE_REPUBLIC\",\"name\":\"Commerce Repubic\",\"description\":\"The Commerce Republic takes capital from top tier worlds and invests it into new systems with high potential for growth.\",\"headquarters\":\"X1-OE-PM\",\"traits\":[\"BUREAUCRATIC\",\"CAPITALISTIC\",\"GUILD\",\"ESTABLISHED\"]},\"contract\":{\"id\":\"cl0hok38t0014ks0jnoy8o5vh\",\"faction\":\"COMMERCE_REPUBLIC\",\"type\":\"PROCUREMENT\",\"terms\":{\"deadline\":\"2022-03-11T05:16:59.113Z\",\"payment\":{\"onAccepted\":20000,\"onFulfilled\":100000},\"deliver\":[{\"tradeSymbol\":\"IRON_ORE\",\"destination\":\"X1-OE-PM\",\"units\":10000,\"fulfilled\":0}]},\"accepted\":false,\"fulfilled\":false,\"expiresAt\":\"2022-03-09T05:16:59.112Z\"},\"ship\":{\"symbol\":\"string\",\"frame\":\"string\",\"reactor\":\"string\",\"engine\":\"string\",\"fuel\":0,\"modules\":[\"string\"],\"mounts\":[\"string\"],\"registration\":{\"factionSymbol\":\"string\",\"agentSymbol\":\"string\",\"fee\":0,\"role\":\"string\"},\"integrity\":{\"frame\":0,\"reactor\":0,\"engine\":0},\"status\":\"string\",\"location\":\"string\",\"cargo\":[{\"tradeSymbol\":\"string\",\"units\":0}]}}}",
                    TestHelper.ConvertStreamToString(this.HttpCallBackHandler.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Fetch your agent's details..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetMyAgent()
        {
            // Perform API call
            Standard.Models.MyAgentResponse result = null;
            try
            {
                result = await this.controller.GetMyAgentAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    this.HttpCallBackHandler.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsJsonObjectProperSubsetOf(
                    "{\"data\":{\"accountId\":\"cl0hok34m0003ks0jjql5q8f2\",\"symbol\":\"EMBER\",\"headquarters\":\"X1-OE-PM\",\"credits\":0}}",
                    TestHelper.ConvertStreamToString(this.HttpCallBackHandler.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }
    }
}