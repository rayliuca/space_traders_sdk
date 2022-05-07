// <copyright file="ShipyardsController.cs" company="APIMatic">
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
    /// ShipyardsController.
    /// </summary>
    public class ShipyardsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipyardsController"/> class.
        /// </summary>
        /// <param name="config"> config instance. </param>
        /// <param name="httpClient"> httpClient. </param>
        /// <param name="authManagers"> authManager. </param>
        /// <param name="httpCallBack"> httpCallBack. </param>
        internal ShipyardsController(IConfiguration config, IHttpClient httpClient, IDictionary<string, IAuthManager> authManagers, HttpCallBack httpCallBack = null)
            : base(config, httpClient, authManagers, httpCallBack)
        {
        }

        /// <summary>
        /// Purchase a ship.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.MyShipsResponse2 response from the API call.</returns>
        public Models.MyShipsResponse2 PostMyShips(
                Models.MyShipsRequest body = null)
        {
            Task<Models.MyShipsResponse2> t = this.PostMyShipsAsync(body);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Purchase a ship.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.MyShipsResponse2 response from the API call.</returns>
        public async Task<Models.MyShipsResponse2> PostMyShipsAsync(
                Models.MyShipsRequest body = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/my/ships");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
                { "Content-Type", "application/json" },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(body);

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText);

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

            return ApiHelper.JsonDeserialize<Models.MyShipsResponse2>(response.Body);
        }

        /// <summary>
        /// Returns a list of all shipyards in a system.
        /// </summary>
        /// <param name="systemSymbol">Required parameter: the system symbol.</param>
        /// <returns>Returns the Models.SystemsShipyardsResponse response from the API call.</returns>
        public Models.SystemsShipyardsResponse GetSystemsSystemSymbolShipyards(
                string systemSymbol)
        {
            Task<Models.SystemsShipyardsResponse> t = this.GetSystemsSystemSymbolShipyardsAsync(systemSymbol);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Returns a list of all shipyards in a system.
        /// </summary>
        /// <param name="systemSymbol">Required parameter: the system symbol.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SystemsShipyardsResponse response from the API call.</returns>
        public async Task<Models.SystemsShipyardsResponse> GetSystemsSystemSymbolShipyardsAsync(
                string systemSymbol,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/systems/{systemSymbol}/shipyards");

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

            return ApiHelper.JsonDeserialize<Models.SystemsShipyardsResponse>(response.Body);
        }

        /// <summary>
        /// Shipyard Details.
        /// </summary>
        /// <param name="systemSymbol">Required parameter: The system symbol.</param>
        /// <param name="waypointSymbol">Required parameter: The waypoint symbol.</param>
        /// <returns>Returns the Models.SystemsShipyardsResponse1 response from the API call.</returns>
        public Models.SystemsShipyardsResponse1 GetSystemsSystemSymbolShipyardsWaypointSymbol(
                string systemSymbol,
                string waypointSymbol)
        {
            Task<Models.SystemsShipyardsResponse1> t = this.GetSystemsSystemSymbolShipyardsWaypointSymbolAsync(systemSymbol, waypointSymbol);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Shipyard Details.
        /// </summary>
        /// <param name="systemSymbol">Required parameter: The system symbol.</param>
        /// <param name="waypointSymbol">Required parameter: The waypoint symbol.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SystemsShipyardsResponse1 response from the API call.</returns>
        public async Task<Models.SystemsShipyardsResponse1> GetSystemsSystemSymbolShipyardsWaypointSymbolAsync(
                string systemSymbol,
                string waypointSymbol,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/systems/{systemSymbol}/shipyards/{waypointSymbol}");

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

            return ApiHelper.JsonDeserialize<Models.SystemsShipyardsResponse1>(response.Body);
        }

        /// <summary>
        /// Shipyard Listings.
        /// </summary>
        /// <param name="systemSymbol">Required parameter: The system symbol.</param>
        /// <param name="waypointSymbol">Required parameter: The waypoint symbol.</param>
        /// <returns>Returns the Models.SystemsShipyardsShipsResponse response from the API call.</returns>
        public Models.SystemsShipyardsShipsResponse GetSystemsSystemSymbolShipyardsWaypointSymbolShips(
                string systemSymbol,
                string waypointSymbol)
        {
            Task<Models.SystemsShipyardsShipsResponse> t = this.GetSystemsSystemSymbolShipyardsWaypointSymbolShipsAsync(systemSymbol, waypointSymbol);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Shipyard Listings.
        /// </summary>
        /// <param name="systemSymbol">Required parameter: The system symbol.</param>
        /// <param name="waypointSymbol">Required parameter: The waypoint symbol.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SystemsShipyardsShipsResponse response from the API call.</returns>
        public async Task<Models.SystemsShipyardsShipsResponse> GetSystemsSystemSymbolShipyardsWaypointSymbolShipsAsync(
                string systemSymbol,
                string waypointSymbol,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/systems/{systemSymbol}/shipyards/{waypointSymbol}/ships");

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

            return ApiHelper.JsonDeserialize<Models.SystemsShipyardsShipsResponse>(response.Body);
        }
    }
}