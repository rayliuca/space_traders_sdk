// <copyright file="SpaceTradersAPIClient.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace SpaceTradersAPI.Standard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Text;
    using SpaceTradersAPI.Standard.Authentication;
    using SpaceTradersAPI.Standard.Controllers;
    using SpaceTradersAPI.Standard.Http.Client;
    using SpaceTradersAPI.Standard.Utilities;

    /// <summary>
    /// The gateway for the SDK. This class acts as a factory for Controller and
    /// holds the configuration of the SDK.
    /// </summary>
    public sealed class SpaceTradersAPIClient : IConfiguration
    {
        // A map of environments and their corresponding servers/baseurls
        private static readonly Dictionary<Environment, Dictionary<Server, string>> EnvironmentsMap =
            new Dictionary<Environment, Dictionary<Server, string>>
        {
            {
                Environment.Production, new Dictionary<Server, string>
                {
                    { Server.Default, "https://v2-0-0.alpha.spacetraders.io" },
                }
            },
        };

        private readonly IDictionary<string, IAuthManager> authManagers;
        private readonly IHttpClient httpClient;
        private readonly HttpCallBack httpCallBack;
        private readonly BearerAuthManager bearerAuthManager;

        private readonly Lazy<ShipsController> ships;
        private readonly Lazy<MarketsController> markets;
        private readonly Lazy<TradeController> trade;
        private readonly Lazy<NavigationController> navigation;
        private readonly Lazy<AgentsController> agents;
        private readonly Lazy<ContractsController> contracts;
        private readonly Lazy<ExtractController> extract;
        private readonly Lazy<SystemsController> systems;
        private readonly Lazy<ShipyardsController> shipyards;

        private SpaceTradersAPIClient(
            Environment environment,
            string accessToken,
            IDictionary<string, IAuthManager> authManagers,
            IHttpClient httpClient,
            HttpCallBack httpCallBack,
            IHttpClientConfiguration httpClientConfiguration)
        {
            this.Environment = environment;
            this.httpCallBack = httpCallBack;
            this.httpClient = httpClient;
            this.authManagers = (authManagers == null) ? new Dictionary<string, IAuthManager>() : new Dictionary<string, IAuthManager>(authManagers);
            this.HttpClientConfiguration = httpClientConfiguration;

            this.ships = new Lazy<ShipsController>(
                () => new ShipsController(this, this.httpClient, this.authManagers, this.httpCallBack));
            this.markets = new Lazy<MarketsController>(
                () => new MarketsController(this, this.httpClient, this.authManagers, this.httpCallBack));
            this.trade = new Lazy<TradeController>(
                () => new TradeController(this, this.httpClient, this.authManagers, this.httpCallBack));
            this.navigation = new Lazy<NavigationController>(
                () => new NavigationController(this, this.httpClient, this.authManagers, this.httpCallBack));
            this.agents = new Lazy<AgentsController>(
                () => new AgentsController(this, this.httpClient, this.authManagers, this.httpCallBack));
            this.contracts = new Lazy<ContractsController>(
                () => new ContractsController(this, this.httpClient, this.authManagers, this.httpCallBack));
            this.extract = new Lazy<ExtractController>(
                () => new ExtractController(this, this.httpClient, this.authManagers, this.httpCallBack));
            this.systems = new Lazy<SystemsController>(
                () => new SystemsController(this, this.httpClient, this.authManagers, this.httpCallBack));
            this.shipyards = new Lazy<ShipyardsController>(
                () => new ShipyardsController(this, this.httpClient, this.authManagers, this.httpCallBack));

            if (this.authManagers.ContainsKey("global"))
            {
                this.bearerAuthManager = (BearerAuthManager)this.authManagers["global"];
            }

            if (!this.authManagers.ContainsKey("global")
                || !this.BearerAuthCredentials.Equals(accessToken))
            {
                this.bearerAuthManager = new BearerAuthManager(accessToken);
                this.authManagers["global"] = this.bearerAuthManager;
            }
        }

        /// <summary>
        /// Gets ShipsController controller.
        /// </summary>
        public ShipsController ShipsController => this.ships.Value;

        /// <summary>
        /// Gets MarketsController controller.
        /// </summary>
        public MarketsController MarketsController => this.markets.Value;

        /// <summary>
        /// Gets TradeController controller.
        /// </summary>
        public TradeController TradeController => this.trade.Value;

        /// <summary>
        /// Gets NavigationController controller.
        /// </summary>
        public NavigationController NavigationController => this.navigation.Value;

        /// <summary>
        /// Gets AgentsController controller.
        /// </summary>
        public AgentsController AgentsController => this.agents.Value;

        /// <summary>
        /// Gets ContractsController controller.
        /// </summary>
        public ContractsController ContractsController => this.contracts.Value;

        /// <summary>
        /// Gets ExtractController controller.
        /// </summary>
        public ExtractController ExtractController => this.extract.Value;

        /// <summary>
        /// Gets SystemsController controller.
        /// </summary>
        public SystemsController SystemsController => this.systems.Value;

        /// <summary>
        /// Gets ShipyardsController controller.
        /// </summary>
        public ShipyardsController ShipyardsController => this.shipyards.Value;

        /// <summary>
        /// Gets the configuration of the Http Client associated with this client.
        /// </summary>
        public IHttpClientConfiguration HttpClientConfiguration { get; }

        /// <summary>
        /// Gets Environment.
        /// Current API environment.
        /// </summary>
        public Environment Environment { get; }

        /// <summary>
        /// Gets auth managers.
        /// </summary>
        internal IDictionary<string, IAuthManager> AuthManagers => this.authManagers;

        /// <summary>
        /// Gets http client.
        /// </summary>
        internal IHttpClient HttpClient => this.httpClient;

        /// <summary>
        /// Gets http callback.
        /// </summary>
        internal HttpCallBack HttpCallBack => this.httpCallBack;

        /// <summary>
        /// Gets the credentials to use with BearerAuth.
        /// </summary>
        private IBearerAuthCredentials BearerAuthCredentials => this.bearerAuthManager;

        /// <summary>
        /// Gets the access token to use with OAuth 2 authentication.
        /// </summary>
        public string AccessToken => this.BearerAuthCredentials.AccessToken;

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends
        /// it with template parameters.
        /// </summary>
        /// <param name="alias">Default value:DEFAULT.</param>
        /// <returns>Returns the baseurl.</returns>
        public string GetBaseUri(Server alias = Server.Default)
        {
            StringBuilder url = new StringBuilder(EnvironmentsMap[this.Environment][alias]);
            ApiHelper.AppendUrlWithTemplateParameters(url, this.GetBaseUriParameters());

            return url.ToString();
        }

        /// <summary>
        /// Creates an object of the SpaceTradersAPIClient using the values provided for the builder.
        /// </summary>
        /// <returns>Builder.</returns>
        public Builder ToBuilder()
        {
            Builder builder = new Builder()
                .Environment(this.Environment)
                .AccessToken(this.BearerAuthCredentials.AccessToken)
                .HttpCallBack(this.httpCallBack)
                .HttpClient(this.httpClient)
                .AuthManagers(this.authManagers)
                .HttpClientConfig(config => config.Build());

            return builder;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return
                $"Environment = {this.Environment}, " +
                $"HttpClientConfiguration = {this.HttpClientConfiguration}, ";
        }

        /// <summary>
        /// Creates the client using builder.
        /// </summary>
        /// <returns> SpaceTradersAPIClient.</returns>
        internal static SpaceTradersAPIClient CreateFromEnvironment()
        {
            var builder = new Builder();

            string environment = System.Environment.GetEnvironmentVariable("SPACE_TRADERS_API_STANDARD_ENVIRONMENT");
            string accessToken = System.Environment.GetEnvironmentVariable("SPACE_TRADERS_API_STANDARD_ACCESS_TOKEN");

            if (environment != null)
            {
                builder.Environment(ApiHelper.JsonDeserialize<Environment>($"\"{environment}\""));
            }

            if (accessToken != null)
            {
                builder.AccessToken(accessToken);
            }

            return builder.Build();
        }

        /// <summary>
        /// Makes a list of the BaseURL parameters.
        /// </summary>
        /// <returns>Returns the parameters list.</returns>
        private List<KeyValuePair<string, object>> GetBaseUriParameters()
        {
            List<KeyValuePair<string, object>> kvpList = new List<KeyValuePair<string, object>>()
            {
            };
            return kvpList;
        }

        /// <summary>
        /// Builder class.
        /// </summary>
        public class Builder
        {
            private Environment environment = SpaceTradersAPI.Standard.Environment.Production;
            private string accessToken = "";
            private IDictionary<string, IAuthManager> authManagers = new Dictionary<string, IAuthManager>();
            private HttpClientConfiguration.Builder httpClientConfig = new HttpClientConfiguration.Builder();
            private IHttpClient httpClient;
            private HttpCallBack httpCallBack;

            /// <summary>
            /// Sets credentials for BearerAuth.
            /// </summary>
            /// <param name="accessToken">AccessToken.</param>
            /// <returns>Builder.</returns>
            public Builder AccessToken(string accessToken)
            {
                this.accessToken = accessToken ?? throw new ArgumentNullException(nameof(accessToken));
                return this;
            }

            /// <summary>
            /// Sets Environment.
            /// </summary>
            /// <param name="environment"> Environment. </param>
            /// <returns> Builder. </returns>
            public Builder Environment(Environment environment)
            {
                this.environment = environment;
                return this;
            }

            /// <summary>
            /// Sets HttpClientConfig.
            /// </summary>
            /// <param name="action"> Action. </param>
            /// <returns>Builder.</returns>
            public Builder HttpClientConfig(Action<HttpClientConfiguration.Builder> action)
            {
                if (action is null)
                {
                    throw new ArgumentNullException(nameof(action));
                }

                action(this.httpClientConfig);
                return this;
            }

            /// <summary>
            /// Sets the IHttpClient for the Builder.
            /// </summary>
            /// <param name="httpClient"> http client. </param>
            /// <returns>Builder.</returns>
            internal Builder HttpClient(IHttpClient httpClient)
            {
                this.httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
                return this;
            }

            /// <summary>
            /// Sets the authentication managers for the Builder.
            /// </summary>
            /// <param name="authManagers"> auth managers. </param>
            /// <returns>Builder.</returns>
            internal Builder AuthManagers(IDictionary<string, IAuthManager> authManagers)
            {
                this.authManagers = authManagers ?? throw new ArgumentNullException(nameof(authManagers));
                return this;
            }

            /// <summary>
            /// Sets the HttpCallBack for the Builder.
            /// </summary>
            /// <param name="httpCallBack"> http callback. </param>
            /// <returns>Builder.</returns>
            internal Builder HttpCallBack(HttpCallBack httpCallBack)
            {
                this.httpCallBack = httpCallBack;
                return this;
            }

            /// <summary>
            /// Creates an object of the SpaceTradersAPIClient using the values provided for the builder.
            /// </summary>
            /// <returns>SpaceTradersAPIClient.</returns>
            public SpaceTradersAPIClient Build()
            {
                this.httpClient = new HttpClientWrapper(this.httpClientConfig.Build());

                return new SpaceTradersAPIClient(
                    this.environment,
                    this.accessToken,
                    this.authManagers,
                    this.httpClient,
                    this.httpCallBack,
                    this.httpClientConfig.Build());
            }
        }
    }
}
