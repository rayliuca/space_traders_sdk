// <copyright file="MarketsController.cs" company="APIMatic">
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
    /// MarketsController.
    /// </summary>
    public class MarketsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarketsController"/> class.
        /// </summary>
        /// <param name="config"> config instance. </param>
        /// <param name="httpClient"> httpClient. </param>
        /// <param name="authManagers"> authManager. </param>
        /// <param name="httpCallBack"> httpCallBack. </param>
        internal MarketsController(IConfiguration config, IHttpClient httpClient, IDictionary<string, IAuthManager> authManagers, HttpCallBack httpCallBack = null)
            : base(config, httpClient, authManagers, httpCallBack)
        {
        }

        /// <summary>
        /// Use this endpoint to deploy a Communications Relay to a waypoint. A waypoint with a communications relay will allow agents to retrieve price information from the market. Without a relay, agents must send a ship to a market to retrieve price information.
        /// Communication relays can be purchased from a market that exports `COMM_RELAY_I`.
        /// </summary>
        /// <param name="shipSymbol">Required parameter: The ship symbol.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        public void PostMyShipsShipSymbolDeploy(
                string shipSymbol,
                Models.MyShipsDeployRequest body = null)
        {
            Task t = this.PostMyShipsShipSymbolDeployAsync(shipSymbol, body);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// Use this endpoint to deploy a Communications Relay to a waypoint. A waypoint with a communications relay will allow agents to retrieve price information from the market. Without a relay, agents must send a ship to a market to retrieve price information.
        /// Communication relays can be purchased from a market that exports `COMM_RELAY_I`.
        /// </summary>
        /// <param name="shipSymbol">Required parameter: The ship symbol.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task PostMyShipsShipSymbolDeployAsync(
                string shipSymbol,
                Models.MyShipsDeployRequest body = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/my/ships/{shipSymbol}/deploy");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "shipSymbol", shipSymbol },
            });

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
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
        }

        /// <summary>
        /// Trade Imports.
        /// </summary>
        /// <param name="tradeSymbol">Required parameter: The trade symbol.</param>
        /// <returns>Returns the Models.TradeImportsResponse response from the API call.</returns>
        public Models.TradeImportsResponse GetTradeTradeSymbolImports(
                string tradeSymbol)
        {
            Task<Models.TradeImportsResponse> t = this.GetTradeTradeSymbolImportsAsync(tradeSymbol);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Trade Imports.
        /// </summary>
        /// <param name="tradeSymbol">Required parameter: The trade symbol.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.TradeImportsResponse response from the API call.</returns>
        public async Task<Models.TradeImportsResponse> GetTradeTradeSymbolImportsAsync(
                string tradeSymbol,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/trade/{tradeSymbol}/imports");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "tradeSymbol", tradeSymbol },
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

            return ApiHelper.JsonDeserialize<Models.TradeImportsResponse>(response.Body);
        }

        /// <summary>
        /// Trade Exports.
        /// </summary>
        /// <param name="tradeSymbol">Required parameter: The trade symbol.</param>
        /// <returns>Returns the Models.TradeExportsResponse response from the API call.</returns>
        public Models.TradeExportsResponse GetTradeTradeSymbolExports(
                string tradeSymbol)
        {
            Task<Models.TradeExportsResponse> t = this.GetTradeTradeSymbolExportsAsync(tradeSymbol);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Trade Exports.
        /// </summary>
        /// <param name="tradeSymbol">Required parameter: The trade symbol.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.TradeExportsResponse response from the API call.</returns>
        public async Task<Models.TradeExportsResponse> GetTradeTradeSymbolExportsAsync(
                string tradeSymbol,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/trade/{tradeSymbol}/exports");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "tradeSymbol", tradeSymbol },
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

            return ApiHelper.JsonDeserialize<Models.TradeExportsResponse>(response.Body);
        }

        /// <summary>
        /// Trade Exchanges.
        /// </summary>
        /// <param name="tradeSymbol">Required parameter: The trade symbol.</param>
        /// <returns>Returns the Models.TradeExchangeResponse response from the API call.</returns>
        public Models.TradeExchangeResponse GetTradeTradeSymbolExchange(
                string tradeSymbol)
        {
            Task<Models.TradeExchangeResponse> t = this.GetTradeTradeSymbolExchangeAsync(tradeSymbol);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Trade Exchanges.
        /// </summary>
        /// <param name="tradeSymbol">Required parameter: The trade symbol.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.TradeExchangeResponse response from the API call.</returns>
        public async Task<Models.TradeExchangeResponse> GetTradeTradeSymbolExchangeAsync(
                string tradeSymbol,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/trade/{tradeSymbol}/exchange");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "tradeSymbol", tradeSymbol },
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

            return ApiHelper.JsonDeserialize<Models.TradeExchangeResponse>(response.Body);
        }

        /// <summary>
        /// Retrieve a list of all charted markets in the given system. Markets are only available if the waypoint is charted and contains a communications relay.
        /// To install a communications relay at a market, look at the `my/ships/{shipSymbol}/deploy` endpoint.
        /// </summary>
        /// <param name="systemSymbol">Required parameter: The system symbol.</param>
        /// <returns>Returns the Models.SystemsMarketsResponse response from the API call.</returns>
        public Models.SystemsMarketsResponse GetSystemsSystemSymbolMarkets(
                string systemSymbol)
        {
            Task<Models.SystemsMarketsResponse> t = this.GetSystemsSystemSymbolMarketsAsync(systemSymbol);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve a list of all charted markets in the given system. Markets are only available if the waypoint is charted and contains a communications relay.
        /// To install a communications relay at a market, look at the `my/ships/{shipSymbol}/deploy` endpoint.
        /// </summary>
        /// <param name="systemSymbol">Required parameter: The system symbol.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SystemsMarketsResponse response from the API call.</returns>
        public async Task<Models.SystemsMarketsResponse> GetSystemsSystemSymbolMarketsAsync(
                string systemSymbol,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/systems/{systemSymbol}/markets");

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

            return ApiHelper.JsonDeserialize<Models.SystemsMarketsResponse>(response.Body);
        }

        /// <summary>
        /// Retrieve imports, exports and exchange data from a marketplace. Imports can be sold, exports can be purchased, and exchange trades can be purchased or sold.
        /// Market data is only available if you have a ship at the location, or the location is charted and has a communications relay deployed.
        /// See `/my/ships/{shipSymbol}/deploy` for deploying relays at a location.
        /// </summary>
        /// <param name="systemSymbol">Required parameter: The system symbol.</param>
        /// <param name="waypointSymbol">Required parameter: The waypoint symbol.</param>
        /// <returns>Returns the Models.SystemsMarketsResponse1 response from the API call.</returns>
        public Models.SystemsMarketsResponse1 GetSystemsSystemSymbolMarketsWaypointSymbol(
                string systemSymbol,
                string waypointSymbol)
        {
            Task<Models.SystemsMarketsResponse1> t = this.GetSystemsSystemSymbolMarketsWaypointSymbolAsync(systemSymbol, waypointSymbol);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve imports, exports and exchange data from a marketplace. Imports can be sold, exports can be purchased, and exchange trades can be purchased or sold.
        /// Market data is only available if you have a ship at the location, or the location is charted and has a communications relay deployed.
        /// See `/my/ships/{shipSymbol}/deploy` for deploying relays at a location.
        /// </summary>
        /// <param name="systemSymbol">Required parameter: The system symbol.</param>
        /// <param name="waypointSymbol">Required parameter: The waypoint symbol.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SystemsMarketsResponse1 response from the API call.</returns>
        public async Task<Models.SystemsMarketsResponse1> GetSystemsSystemSymbolMarketsWaypointSymbolAsync(
                string systemSymbol,
                string waypointSymbol,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/systems/{systemSymbol}/markets/{waypointSymbol}");

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

            return ApiHelper.JsonDeserialize<Models.SystemsMarketsResponse1>(response.Body);
        }
    }
}