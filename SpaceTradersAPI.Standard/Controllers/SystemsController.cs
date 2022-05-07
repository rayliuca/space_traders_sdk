// <copyright file="SystemsController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace SpaceTradersAPI.Standard.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using Newtonsoft.Json.Converters;
    using SpaceTradersAPI.Standard;
    using SpaceTradersAPI.Standard.Authentication;
    using SpaceTradersAPI.Standard.Http.Client;
    using SpaceTradersAPI.Standard.Http.Request;
    using SpaceTradersAPI.Standard.Http.Request.Configuration;
    using SpaceTradersAPI.Standard.Http.Response;
    using SpaceTradersAPI.Standard.Utilities;

    /// <summary>
    /// SystemsController.
    /// </summary>
    public class SystemsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemsController"/> class.
        /// </summary>
        /// <param name="config"> config instance. </param>
        /// <param name="httpClient"> httpClient. </param>
        /// <param name="authManagers"> authManager. </param>
        /// <param name="httpCallBack"> httpCallBack. </param>
        internal SystemsController(IConfiguration config, IHttpClient httpClient, IDictionary<string, IAuthManager> authManagers, HttpCallBack httpCallBack = null)
            : base(config, httpClient, authManagers, httpCallBack)
        {
        }

        /// <summary>
        /// Chart a new system or waypoint. Returns an array of the symbols that have been charted, including the system and the waypoint if both were uncharted, or just the waypoint.
        /// </summary>
        /// <param name="shipSymbol">Required parameter: The symbol of the ship.</param>
        /// <returns>Returns the Models.MyShipsChartResponse response from the API call.</returns>
        public Models.MyShipsChartResponse PostMyShipsShipSymbolChart(
                string shipSymbol)
        {
            Task<Models.MyShipsChartResponse> t = this.PostMyShipsShipSymbolChartAsync(shipSymbol);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Chart a new system or waypoint. Returns an array of the symbols that have been charted, including the system and the waypoint if both were uncharted, or just the waypoint.
        /// </summary>
        /// <param name="shipSymbol">Required parameter: The symbol of the ship.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.MyShipsChartResponse response from the API call.</returns>
        public async Task<Models.MyShipsChartResponse> PostMyShipsShipSymbolChartAsync(
                string shipSymbol,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/my/ships/{shipSymbol}/chart");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "shipSymbol", shipSymbol },
            });

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, null);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken: cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.MyShipsChartResponse>(response.Body);
        }

        /// <summary>
        /// Return a list of all systems.
        /// </summary>
        /// <returns>Returns the Models.SystemsResponse response from the API call.</returns>
        public Models.SystemsResponse GetSystems()
        {
            Task<Models.SystemsResponse> t = this.GetSystemsAsync();
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Return a list of all systems.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SystemsResponse response from the API call.</returns>
        public async Task<Models.SystemsResponse> GetSystemsAsync(CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/systems");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken: cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.SystemsResponse>(response.Body);
        }

        /// <summary>
        /// View System.
        /// </summary>
        /// <param name="systemSymbol">Required parameter: The system symbol.</param>
        /// <returns>Returns the Models.SystemsResponse1 response from the API call.</returns>
        public Models.SystemsResponse1 GetSystemsSystemSymbol(
                string systemSymbol)
        {
            Task<Models.SystemsResponse1> t = this.GetSystemsSystemSymbolAsync(systemSymbol);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// View System.
        /// </summary>
        /// <param name="systemSymbol">Required parameter: The system symbol.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SystemsResponse1 response from the API call.</returns>
        public async Task<Models.SystemsResponse1> GetSystemsSystemSymbolAsync(
                string systemSymbol,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/systems/{systemSymbol}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "systemSymbol", systemSymbol },
            });

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken: cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.SystemsResponse1>(response.Body);
        }

        /// <summary>
        /// Fetch all of the waypoints for a given system. System must be charted or a ship must be present to return waypoint details.
        /// </summary>
        /// <param name="systemSymbol">Required parameter: The system symbol.</param>
        /// <returns>Returns the Models.SystemsWaypointsResponse response from the API call.</returns>
        public Models.SystemsWaypointsResponse GetSystemsSystemSymbolWaypointsWaypointSymbol(
                string systemSymbol)
        {
            Task<Models.SystemsWaypointsResponse> t = this.GetSystemsSystemSymbolWaypointsWaypointSymbolAsync(systemSymbol);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Fetch all of the waypoints for a given system. System must be charted or a ship must be present to return waypoint details.
        /// </summary>
        /// <param name="systemSymbol">Required parameter: The system symbol.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SystemsWaypointsResponse response from the API call.</returns>
        public async Task<Models.SystemsWaypointsResponse> GetSystemsSystemSymbolWaypointsWaypointSymbolAsync(
                string systemSymbol,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/systems/{systemSymbol}/waypoints");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "systemSymbol", systemSymbol },
            });

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken: cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.SystemsWaypointsResponse>(response.Body);
        }

        /// <summary>
        /// View the details of a waypoint.
        /// </summary>
        /// <param name="systemSymbol">Required parameter: The system symbol.</param>
        /// <param name="waypointSymbol">Required parameter: The waypoint symbol.</param>
        /// <returns>Returns the Models.SystemsWaypointsResponse response from the API call.</returns>
        public Models.SystemsWaypointsResponse GetSystemsSystemSymbolWaypoints(
                string systemSymbol,
                string waypointSymbol)
        {
            Task<Models.SystemsWaypointsResponse> t = this.GetSystemsSystemSymbolWaypointsAsync(systemSymbol, waypointSymbol);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// View the details of a waypoint.
        /// </summary>
        /// <param name="systemSymbol">Required parameter: The system symbol.</param>
        /// <param name="waypointSymbol">Required parameter: The waypoint symbol.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SystemsWaypointsResponse response from the API call.</returns>
        public async Task<Models.SystemsWaypointsResponse> GetSystemsSystemSymbolWaypointsAsync(
                string systemSymbol,
                string waypointSymbol,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/systems/{systemSymbol}/waypoints/{waypointSymbol}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "systemSymbol", systemSymbol },
                { "waypointSymbol", waypointSymbol },
            });

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken: cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.SystemsWaypointsResponse>(response.Body);
        }
    }
}