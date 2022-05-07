// <copyright file="SystemsControllerTest.cs" company="APIMatic">
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
    /// SystemsControllerTest.
    /// </summary>
    [TestFixture]
    public class SystemsControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private SystemsController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.SystemsController;
        }

        /// <summary>
        /// Return a list of all systems..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetSystems()
        {
            // Perform API call
            Standard.Models.SystemsResponse result = null;
            try
            {
                result = await this.controller.GetSystemsAsync();
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
                    "{\"data\":[{\"symbol\":\"X1-OE\",\"sector\":\"X1\",\"type\":\"RED_STAR\",\"x\":0,\"y\":0,\"waypoints\":[\"X1-OE-PM\",\"X1-OE-PM01\",\"X1-OE-A005\",\"X1-OE-25X\"],\"factions\":[\"COMMERCE_REPUBLIC\",\"MINERS_COLLECTIVE\",\"SPACERS_GUILD\"],\"charted\":true,\"chartedBy\":null}],\"meta\":{\"total\":0,\"page\":0,\"limit\":0}}",
                    TestHelper.ConvertStreamToString(this.HttpCallBackHandler.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// View System.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetSystemsSystemSymbol()
        {
            // Parameters for the API call
            string systemSymbol = "X1-OE";

            // Perform API call
            Standard.Models.SystemsResponse1 result = null;
            try
            {
                result = await this.controller.GetSystemsSystemSymbolAsync(systemSymbol);
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
                    "{\"data\":{\"symbol\":\"X1-ZZ\",\"sector\":\"X1\",\"type\":\"BLUE_STAR\",\"x\":-2,\"y\":9,\"waypoints\":[],\"factions\":[],\"charted\":false,\"chartedBy\":null}}",
                    TestHelper.ConvertStreamToString(this.HttpCallBackHandler.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }
    }
}