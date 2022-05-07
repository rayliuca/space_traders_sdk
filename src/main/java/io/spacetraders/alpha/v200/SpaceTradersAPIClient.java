/*
 * SpaceTradersAPILib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

package io.spacetraders.alpha.v200;

import io.spacetraders.alpha.v200.controllers.AgentsController;
import io.spacetraders.alpha.v200.controllers.ContractsController;
import io.spacetraders.alpha.v200.controllers.ExtractController;
import io.spacetraders.alpha.v200.controllers.MarketsController;
import io.spacetraders.alpha.v200.controllers.NavigationController;
import io.spacetraders.alpha.v200.controllers.ShipsController;
import io.spacetraders.alpha.v200.controllers.ShipyardsController;
import io.spacetraders.alpha.v200.controllers.SystemsController;
import io.spacetraders.alpha.v200.controllers.TradeController;
import io.spacetraders.alpha.v200.http.client.HttpCallback;
import io.spacetraders.alpha.v200.http.client.HttpClient;
import io.spacetraders.alpha.v200.http.client.HttpClientConfiguration;
import io.spacetraders.alpha.v200.http.client.OkClient;
import io.spacetraders.alpha.v200.http.client.ReadonlyHttpClientConfiguration;
import java.util.HashMap;
import java.util.Map;
import java.util.function.Consumer;

/**
 * Gateway class for the library.
 * This class acts as a factory for Controllers.
 * It holds the state of the SDK.
 */
public final class SpaceTradersAPIClient implements Configuration {

    /**
     * Private store for controllers.
     */
    private ShipsController ships;
    private MarketsController markets;
    private TradeController trade;
    private NavigationController navigation;
    private AgentsController agents;
    private ContractsController contracts;
    private ExtractController extract;
    private SystemsController systems;
    private ShipyardsController shipyards;

    /**
     * Current API environment.
     */
    private final Environment environment;

    /**
     * The HTTP Client instance to use for making HTTP requests.
     */
    private final HttpClient httpClient;

    /**
     * Http Client Configuration instance.
     */
    private final ReadonlyHttpClientConfiguration httpClientConfig;

    /**
     * BearerAuthManager.
     */
    private BearerAuthManager bearerAuthManager;

    /**
     * Map of authentication Managers.
     */
    private Map<String, AuthManager> authManagers;

    /**
     * Callback to be called before and after the HTTP call for an endpoint is made.
     */
    private final HttpCallback httpCallback;

    private SpaceTradersAPIClient(Environment environment, HttpClient httpClient,
            ReadonlyHttpClientConfiguration httpClientConfig, String accessToken,
            Map<String, AuthManager> authManagers, HttpCallback httpCallback) {
        this.environment = environment;
        this.httpClient = httpClient;
        this.httpClientConfig = httpClientConfig;
        this.httpCallback = httpCallback;

        this.authManagers = (authManagers == null) ? new HashMap<>() : new HashMap<>(authManagers);
        if (this.authManagers.containsKey("global")) {
            this.bearerAuthManager = (BearerAuthManager) this.authManagers.get("global");
        }

        if (!this.authManagers.containsKey("global")
                || !getBearerAuthCredentials().equals(accessToken)) {
            this.bearerAuthManager = new BearerAuthManager(accessToken);
            this.authManagers.put("global", bearerAuthManager);
        }

        ships = new ShipsController(this, this.httpClient, this.authManagers, this.httpCallback);
        markets = new MarketsController(this, this.httpClient, this.authManagers,
                this.httpCallback);
        trade = new TradeController(this, this.httpClient, this.authManagers, this.httpCallback);
        navigation = new NavigationController(this, this.httpClient, this.authManagers,
                this.httpCallback);
        agents = new AgentsController(this, this.httpClient, this.authManagers, this.httpCallback);
        contracts = new ContractsController(this, this.httpClient, this.authManagers,
                this.httpCallback);
        extract = new ExtractController(this, this.httpClient, this.authManagers,
                this.httpCallback);
        systems = new SystemsController(this, this.httpClient, this.authManagers,
                this.httpCallback);
        shipyards = new ShipyardsController(this, this.httpClient, this.authManagers,
                this.httpCallback);
    }

    /**
     * Shutdown the underlying HttpClient instance.
     */
    public static void shutdown() {
        OkClient.shutdown();
    }

    /**
     * Get the instance of ShipsController.
     * @return ships
     */
    public ShipsController getShipsController() {
        return ships;
    }

    /**
     * Get the instance of MarketsController.
     * @return markets
     */
    public MarketsController getMarketsController() {
        return markets;
    }

    /**
     * Get the instance of TradeController.
     * @return trade
     */
    public TradeController getTradeController() {
        return trade;
    }

    /**
     * Get the instance of NavigationController.
     * @return navigation
     */
    public NavigationController getNavigationController() {
        return navigation;
    }

    /**
     * Get the instance of AgentsController.
     * @return agents
     */
    public AgentsController getAgentsController() {
        return agents;
    }

    /**
     * Get the instance of ContractsController.
     * @return contracts
     */
    public ContractsController getContractsController() {
        return contracts;
    }

    /**
     * Get the instance of ExtractController.
     * @return extract
     */
    public ExtractController getExtractController() {
        return extract;
    }

    /**
     * Get the instance of SystemsController.
     * @return systems
     */
    public SystemsController getSystemsController() {
        return systems;
    }

    /**
     * Get the instance of ShipyardsController.
     * @return shipyards
     */
    public ShipyardsController getShipyardsController() {
        return shipyards;
    }

    /**
     * Current API environment.
     * @return environment
     */
    public Environment getEnvironment() {
        return environment;
    }

    /**
     * The HTTP Client instance to use for making HTTP requests.
     * @return httpClient
     */
    private HttpClient getHttpClient() {
        return httpClient;
    }

    /**
     * Http Client Configuration instance.
     * @return httpClientConfig
     */
    public ReadonlyHttpClientConfiguration getHttpClientConfig() {
        return httpClientConfig;
    }

    /**
     * The credentials to use with BearerAuth.
     * @return bearerAuthCredentials
     */
    private BearerAuthCredentials getBearerAuthCredentials() {
        return bearerAuthManager;
    }

    /**
     * OAuth 2.0 Access Token.
     * @return accessToken
     */
    public String getAccessToken() {
        return getBearerAuthCredentials().getAccessToken();
    }

    /**
     * The timeout to use for making HTTP requests.
     * @deprecated This method will be removed in a future version. Use
     *             {@link #getHttpClientConfig()} instead.
     *
     * @return timeout
     */
    @Deprecated
    public long timeout() {
        return httpClientConfig.getTimeout();
    }

    /**
     * Get base URI by current environment.
     * @param server Server for which to get the base URI
     * @return Processed base URI
     */
    public String getBaseUri(Server server) {
        return environmentMapper(environment, server);
    }

    /**
     * Get base URI by current environment.
     * @return Processed base URI
     */
    public String getBaseUri() {
        return getBaseUri(Server.ENUM_DEFAULT);
    }

    /**
     * Base URLs by environment and server aliases.
     * @param environment Environment for which to get the base URI
     * @param server Server for which to get the base URI
     * @return base URL
     */
    private static String environmentMapper(Environment environment, Server server) {
        if (environment.equals(Environment.PRODUCTION)) {
            if (server.equals(Server.ENUM_DEFAULT)) {
                return "https://v2-0-0.alpha.spacetraders.io";
            }
        }
        return "https://v2-0-0.alpha.spacetraders.io";
    }

    /**
     * Converts this SpaceTradersAPIClient into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "SpaceTradersAPIClient [" + "environment=" + environment + ", httpClientConfig="
                + httpClientConfig + ", authManagers=" + authManagers + "]";
    }

    /**
     * Builds a new {@link SpaceTradersAPIClient.Builder} object.
     * Creates the instance with the state of the current client.
     * @return a new {@link SpaceTradersAPIClient.Builder} object
     */
    public Builder newBuilder() {
        Builder builder = new Builder();
        builder.environment = getEnvironment();
        builder.httpClient = getHttpClient();
        builder.accessToken = getBearerAuthCredentials().getAccessToken();
        builder.authManagers = authManagers;
        builder.httpCallback = httpCallback;
        builder.httpClientConfig(configBldr -> configBldr =
                ((HttpClientConfiguration) httpClientConfig).newBuilder());
        return builder;
    }

    /**
     * Class to build instances of {@link SpaceTradersAPIClient}.
     */
    public static class Builder {

        private Environment environment = Environment.PRODUCTION;
        private HttpClient httpClient;
        private String accessToken = "";
        private Map<String, AuthManager> authManagers = null;
        private HttpCallback httpCallback = null;
        private HttpClientConfiguration.Builder httpClientConfigBuilder =
                new HttpClientConfiguration.Builder();


        /**
         * Credentials setter for BearerAuth.
         * @param accessToken String value for accessToken.
         * @return Builder
         */
        public Builder accessToken(String accessToken) {
            if (accessToken == null) {
                throw new NullPointerException("AccessToken cannot be null.");
            }
            this.accessToken = accessToken;
            return this;
        }

        /**
         * Current API environment.
         * @param environment The environment for client.
         * @return Builder
         */
        public Builder environment(Environment environment) {
            this.environment = environment;
            return this;
        }

        /**
         * The timeout to use for making HTTP requests.
         * @deprecated This method will be removed in a future version. Use
         *             {@link #httpClientConfig(Consumer) httpClientConfig} instead.
         * @param timeout must be greater then 0.
         * @return Builder
         */
        @Deprecated
        public Builder timeout(long timeout) {
            this.httpClientConfigBuilder.timeout(timeout);
            return this;
        }

        /**
         * HttpCallback.
         * @param httpCallback Callback to be called before and after the HTTP call.
         * @return Builder
         */
        public Builder httpCallback(HttpCallback httpCallback) {
            this.httpCallback = httpCallback;
            return this;
        }

        /**
         * Setter for the Builder of httpClientConfiguration, takes in an operation to be performed
         * on the builder instance of HTTP client configuration.
         * 
         * @param action Consumer for the builder of httpClientConfiguration.
         * @return Builder
         */
        public Builder httpClientConfig(Consumer<HttpClientConfiguration.Builder> action) {
            action.accept(httpClientConfigBuilder);
            return this;
        }

        /**
         * Builds a new SpaceTradersAPIClient object using the set fields.
         * @return SpaceTradersAPIClient
         */
        public SpaceTradersAPIClient build() {
            HttpClientConfiguration httpClientConfig = httpClientConfigBuilder.build();
            httpClient = new OkClient(httpClientConfig);

            return new SpaceTradersAPIClient(environment, httpClient, httpClientConfig, accessToken,
                    authManagers, httpCallback);
        }
    }
}