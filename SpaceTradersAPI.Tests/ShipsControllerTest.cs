// <copyright file="ShipsControllerTest.cs" company="APIMatic">
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
    /// ShipsControllerTest.
    /// </summary>
    [TestFixture]
    public class ShipsControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private ShipsController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.ShipsController;
        }

        /// <summary>
        /// Retrieve all of your ships..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetMyShips()
        {
            // Perform API call
            Standard.Models.MyShipsResponse1 result = null;
            try
            {
                result = await this.controller.GetMyShipsAsync();
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
                    "{\"data\":[{\"symbol\":\"55B261-1\",\"crew\":null,\"officers\":null,\"fuel\":100,\"frame\":\"FRAME_DRONE\",\"reactor\":\"REACTOR_SOLAR_I\",\"engine\":\"ENGINE_SOLAR_PROPULSION\",\"modules\":[\"MODULE_CARGO_HOLD\"],\"mounts\":[\"MOUNT_MINING_LASER_I\"],\"registration\":{\"factionSymbol\":\"COMMERCE_REPUBLIC\",\"agentSymbol\":\"55B261\",\"fee\":100,\"role\":\"EXCAVATOR\"},\"integrity\":{\"frame\":1,\"reactor\":1,\"engine\":1},\"status\":\"DOCKED\",\"location\":\"X1-OE-PM\",\"cargo\":[]},{\"symbol\":\"55B261-2\",\"crew\":null,\"officers\":null,\"fuel\":100,\"frame\":\"FRAME_DRONE\",\"reactor\":\"REACTOR_SOLAR_I\",\"engine\":\"ENGINE_SOLAR_PROPULSION\",\"modules\":[\"MODULE_CARGO_HOLD\"],\"mounts\":[\"MOUNT_MINING_LASER_I\"],\"registration\":{\"factionSymbol\":\"COMMERCE_REPUBLIC\",\"agentSymbol\":\"55B261\",\"fee\":100,\"role\":\"EXCAVATOR\"},\"integrity\":{\"frame\":1,\"reactor\":1,\"engine\":1},\"status\":\"DOCKED\",\"location\":\"X1-OE-PM\",\"cargo\":[]},{\"symbol\":\"55B261-3\",\"crew\":null,\"officers\":null,\"fuel\":100,\"frame\":\"FRAME_DRONE\",\"reactor\":\"REACTOR_SOLAR_I\",\"engine\":\"ENGINE_SOLAR_PROPULSION\",\"modules\":[\"MODULE_CARGO_HOLD\"],\"mounts\":[\"MOUNT_MINING_LASER_I\"],\"registration\":{\"factionSymbol\":\"COMMERCE_REPUBLIC\",\"agentSymbol\":\"55B261\",\"fee\":100,\"role\":\"EXCAVATOR\"},\"integrity\":{\"frame\":1,\"reactor\":1,\"engine\":1},\"status\":\"DOCKED\",\"location\":\"X1-OE-PM\",\"cargo\":[]},{\"symbol\":\"55B261-4\",\"crew\":null,\"officers\":null,\"fuel\":100,\"frame\":\"FRAME_DRONE\",\"reactor\":\"REACTOR_SOLAR_I\",\"engine\":\"ENGINE_SOLAR_PROPULSION\",\"modules\":[\"MODULE_CARGO_HOLD\"],\"mounts\":[\"MOUNT_MINING_LASER_I\"],\"registration\":{\"factionSymbol\":\"COMMERCE_REPUBLIC\",\"agentSymbol\":\"55B261\",\"fee\":100,\"role\":\"EXCAVATOR\"},\"integrity\":{\"frame\":1,\"reactor\":1,\"engine\":1},\"status\":\"DOCKED\",\"location\":\"X1-OE-PM\",\"cargo\":[]},{\"symbol\":\"55B261-5\",\"crew\":null,\"officers\":null,\"fuel\":100,\"frame\":\"FRAME_DRONE\",\"reactor\":\"REACTOR_SOLAR_I\",\"engine\":\"ENGINE_SOLAR_PROPULSION\",\"modules\":[\"MODULE_CARGO_HOLD\"],\"mounts\":[\"MOUNT_MINING_LASER_I\"],\"registration\":{\"factionSymbol\":\"COMMERCE_REPUBLIC\",\"agentSymbol\":\"55B261\",\"fee\":100,\"role\":\"EXCAVATOR\"},\"integrity\":{\"frame\":1,\"reactor\":1,\"engine\":1},\"status\":\"DOCKED\",\"location\":\"X1-OE-PM\",\"cargo\":[]},{\"symbol\":\"55B261-6\",\"crew\":null,\"officers\":null,\"fuel\":100,\"frame\":\"FRAME_DRONE\",\"reactor\":\"REACTOR_SOLAR_I\",\"engine\":\"ENGINE_SOLAR_PROPULSION\",\"modules\":[\"MODULE_CARGO_HOLD\"],\"mounts\":[\"MOUNT_MINING_LASER_I\"],\"registration\":{\"factionSymbol\":\"COMMERCE_REPUBLIC\",\"agentSymbol\":\"55B261\",\"fee\":100,\"role\":\"EXCAVATOR\"},\"integrity\":{\"frame\":1,\"reactor\":1,\"engine\":1},\"status\":\"DOCKED\",\"location\":\"X1-OE-PM\",\"cargo\":[]}],\"meta\":{\"total\":6,\"page\":1,\"limit\":20}}",
                    TestHelper.ConvertStreamToString(this.HttpCallBackHandler.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }
    }
}