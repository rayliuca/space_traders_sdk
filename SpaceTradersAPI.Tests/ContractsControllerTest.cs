// <copyright file="ContractsControllerTest.cs" company="APIMatic">
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
    /// ContractsControllerTest.
    /// </summary>
    [TestFixture]
    public class ContractsControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private ContractsController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.ContractsController;
        }

        /// <summary>
        /// List all of your contracts..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetMyContracts()
        {
            // Perform API call
            Standard.Models.MyContractsResponse result = null;
            try
            {
                result = await this.controller.GetMyContractsAsync();
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
                    "{\"data\":[{\"id\":\"cl0hok38t0014ks0jnoy8o5vh\",\"faction\":\"COMMERCE_REPUBLIC\",\"type\":\"PROCUREMENT\",\"terms\":{\"deadline\":\"2022-03-11T05:16:59.113Z\",\"payment\":{\"onAccepted\":20000,\"onFulfilled\":100000},\"deliver\":[{\"tradeSymbol\":\"IRON_ORE\",\"destination\":\"X1-OE-PM\",\"units\":10000,\"fulfilled\":0}]},\"accepted\":false,\"fulfilled\":false,\"expiresAt\":\"2022-03-09T05:16:59.112Z\"}],\"meta\":{\"total\":10,\"page\":1,\"limit\":10}}",
                    TestHelper.ConvertStreamToString(this.HttpCallBackHandler.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }
    }
}