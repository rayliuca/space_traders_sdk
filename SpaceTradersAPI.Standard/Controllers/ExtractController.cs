// <copyright file="ExtractController.cs" company="APIMatic">
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
    /// ExtractController.
    /// </summary>
    public class ExtractController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractController"/> class.
        /// </summary>
        /// <param name="config"> config instance. </param>
        /// <param name="httpClient"> httpClient. </param>
        /// <param name="authManagers"> authManager. </param>
        /// <param name="httpCallBack"> httpCallBack. </param>
        internal ExtractController(IConfiguration config, IHttpClient httpClient, IDictionary<string, IAuthManager> authManagers, HttpCallBack httpCallBack = null)
            : base(config, httpClient, authManagers, httpCallBack)
        {
        }

        /// <summary>
        /// Extract resources from the waypoint into your ship. Send a survey as the payload to target specific yields. The entire survey must be sent as it contains a signature that the backend verifies.
        /// </summary>
        /// <param name="shipSymbol">Required parameter: The ship symbol.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.MyShipsExtractResponse response from the API call.</returns>
        public Models.MyShipsExtractResponse PostMyShipsShipSymbolExtract(
                string shipSymbol,
                Models.MyShipsExtractRequest body = null)
        {
            Task<Models.MyShipsExtractResponse> t = this.PostMyShipsShipSymbolExtractAsync(shipSymbol, body);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Extract resources from the waypoint into your ship. Send a survey as the payload to target specific yields. The entire survey must be sent as it contains a signature that the backend verifies.
        /// </summary>
        /// <param name="shipSymbol">Required parameter: The ship symbol.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.MyShipsExtractResponse response from the API call.</returns>
        public async Task<Models.MyShipsExtractResponse> PostMyShipsShipSymbolExtractAsync(
                string shipSymbol,
                Models.MyShipsExtractRequest body = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/my/ships/{shipSymbol}/extract");

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

            return ApiHelper.JsonDeserialize<Models.MyShipsExtractResponse>(response.Body);
        }

        /// <summary>
        /// Get the status of your last extraction.
        /// </summary>
        /// <param name="shipSymbol">Required parameter: The ship symbol.</param>
        /// <returns>Returns the Models.MyShipsExtractResponse1 response from the API call.</returns>
        public Models.MyShipsExtractResponse1 GetMyShipsShipSymbolExtract(
                string shipSymbol)
        {
            Task<Models.MyShipsExtractResponse1> t = this.GetMyShipsShipSymbolExtractAsync(shipSymbol);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get the status of your last extraction.
        /// </summary>
        /// <param name="shipSymbol">Required parameter: The ship symbol.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.MyShipsExtractResponse1 response from the API call.</returns>
        public async Task<Models.MyShipsExtractResponse1> GetMyShipsShipSymbolExtractAsync(
                string shipSymbol,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/my/ships/{shipSymbol}/extract");

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

            return ApiHelper.JsonDeserialize<Models.MyShipsExtractResponse1>(response.Body);
        }

        /// <summary>
        /// If you want to target specific yields for an extraction, you can survey a waypoint, such as an asteroid field, and send the survey in the body of the extract request. Each survey may have multiple deposits, and if a symbol shows up more than once, that indicates a higher chance of extracting that resource.
        /// Your ship will enter a cooldown between consecutive survey requests. Surveys will eventually expire after a period of time. Multiple ships can use the same survey for extraction.
        /// </summary>
        /// <param name="shipSymbol">Required parameter: Example: .</param>
        /// <returns>Returns the Models.MyShipsSurveyResponse response from the API call.</returns>
        public Models.MyShipsSurveyResponse PostMyShipsShipSymbolSurvey(
                string shipSymbol)
        {
            Task<Models.MyShipsSurveyResponse> t = this.PostMyShipsShipSymbolSurveyAsync(shipSymbol);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// If you want to target specific yields for an extraction, you can survey a waypoint, such as an asteroid field, and send the survey in the body of the extract request. Each survey may have multiple deposits, and if a symbol shows up more than once, that indicates a higher chance of extracting that resource.
        /// Your ship will enter a cooldown between consecutive survey requests. Surveys will eventually expire after a period of time. Multiple ships can use the same survey for extraction.
        /// </summary>
        /// <param name="shipSymbol">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.MyShipsSurveyResponse response from the API call.</returns>
        public async Task<Models.MyShipsSurveyResponse> PostMyShipsShipSymbolSurveyAsync(
                string shipSymbol,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/my/ships/{shipSymbol}/survey");

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

            return ApiHelper.JsonDeserialize<Models.MyShipsSurveyResponse>(response.Body);
        }

        /// <summary>
        /// Executing a survey will initiate a cooldown for a number of seconds before you can call it again. This endpoint returns the details of your cooldown, or a 404 if there is no cooldown for the survey action.
        /// </summary>
        /// <param name="shipSymbol">Required parameter: Example: .</param>
        /// <returns>Returns the Models.MyShipsSurveyResponse1 response from the API call.</returns>
        public Models.MyShipsSurveyResponse1 GetMyShipsShipSymbolSurvey(
                string shipSymbol)
        {
            Task<Models.MyShipsSurveyResponse1> t = this.GetMyShipsShipSymbolSurveyAsync(shipSymbol);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Executing a survey will initiate a cooldown for a number of seconds before you can call it again. This endpoint returns the details of your cooldown, or a 404 if there is no cooldown for the survey action.
        /// </summary>
        /// <param name="shipSymbol">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.MyShipsSurveyResponse1 response from the API call.</returns>
        public async Task<Models.MyShipsSurveyResponse1> GetMyShipsShipSymbolSurveyAsync(
                string shipSymbol,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/my/ships/{shipSymbol}/survey");

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

            return ApiHelper.JsonDeserialize<Models.MyShipsSurveyResponse1>(response.Body);
        }
    }
}