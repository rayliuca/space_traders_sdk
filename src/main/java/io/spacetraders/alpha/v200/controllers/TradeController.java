/*
 * SpaceTradersAPILib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

package io.spacetraders.alpha.v200.controllers;

import com.fasterxml.jackson.core.JsonProcessingException;
import io.spacetraders.alpha.v200.ApiHelper;
import io.spacetraders.alpha.v200.AuthManager;
import io.spacetraders.alpha.v200.Configuration;
import io.spacetraders.alpha.v200.exceptions.ApiException;
import io.spacetraders.alpha.v200.http.Headers;
import io.spacetraders.alpha.v200.http.client.HttpCallback;
import io.spacetraders.alpha.v200.http.client.HttpClient;
import io.spacetraders.alpha.v200.http.client.HttpContext;
import io.spacetraders.alpha.v200.http.request.HttpRequest;
import io.spacetraders.alpha.v200.http.response.HttpResponse;
import io.spacetraders.alpha.v200.http.response.HttpStringResponse;
import io.spacetraders.alpha.v200.models.MyShipsPurchaseRequest;
import io.spacetraders.alpha.v200.models.MyShipsPurchaseResponse;
import io.spacetraders.alpha.v200.models.MyShipsSellRequest;
import io.spacetraders.alpha.v200.models.MyShipsSellResponse;
import java.io.IOException;
import java.util.AbstractMap.SimpleEntry;
import java.util.HashMap;
import java.util.Map;
import java.util.concurrent.CompletableFuture;

/**
 * This class lists all the endpoints of the groups.
 */
public final class TradeController extends BaseController {

    /**
     * Initializes the controller.
     * @param config    Configurations added in client.
     * @param httpClient    Send HTTP requests and read the responses.
     * @param authManagers    Apply authorization to requests.
     */
    public TradeController(Configuration config, HttpClient httpClient,
            Map<String, AuthManager> authManagers) {
        super(config, httpClient, authManagers);
    }

    /**
     * Initializes the controller with HTTPCallback.
     * @param config    Configurations added in client.
     * @param httpClient    Send HTTP requests and read the responses.
     * @param authManagers    Apply authorization to requests.
     * @param httpCallback    Callback to be called before and after the HTTP call.
     */
    public TradeController(Configuration config, HttpClient httpClient,
            Map<String, AuthManager> authManagers, HttpCallback httpCallback) {
        super(config, httpClient, authManagers, httpCallback);
    }

    /**
     * Purchase Cargo.
     * @param  shipSymbol  Required parameter: Example:
     * @param  body  Optional parameter: Example:
     * @return    Returns the MyShipsPurchaseResponse response from the API call
     * @throws    ApiException    Represents error response from the server.
     * @throws    IOException    Signals that an I/O exception of some sort has occurred.
     */
    public MyShipsPurchaseResponse postMyShipsShipSymbolPurchase(
            final String shipSymbol,
            final MyShipsPurchaseRequest body) throws ApiException, IOException {
        HttpRequest request = buildPostMyShipsShipSymbolPurchaseRequest(shipSymbol, body);
        authManagers.get("global").apply(request);

        HttpResponse response = getClientInstance().execute(request, false);
        HttpContext context = new HttpContext(request, response);

        return handlePostMyShipsShipSymbolPurchaseResponse(context);
    }

    /**
     * Purchase Cargo.
     * @param  shipSymbol  Required parameter: Example:
     * @param  body  Optional parameter: Example:
     * @return    Returns the MyShipsPurchaseResponse response from the API call
     */
    public CompletableFuture<MyShipsPurchaseResponse> postMyShipsShipSymbolPurchaseAsync(
            final String shipSymbol,
            final MyShipsPurchaseRequest body) {
        return makeHttpCallAsync(() -> buildPostMyShipsShipSymbolPurchaseRequest(shipSymbol, body),
            req -> authManagers.get("global").applyAsync(req)
                .thenCompose(request -> getClientInstance()
                        .executeAsync(request, false)),
            context -> handlePostMyShipsShipSymbolPurchaseResponse(context));
    }

    /**
     * Builds the HttpRequest object for postMyShipsShipSymbolPurchase.
     */
    private HttpRequest buildPostMyShipsShipSymbolPurchaseRequest(
            final String shipSymbol,
            final MyShipsPurchaseRequest body) throws JsonProcessingException {
        //the base uri for api requests
        String baseUri = config.getBaseUri();

        //prepare query string for API call
        final StringBuilder queryBuilder = new StringBuilder(baseUri
                + "/my/ships/{shipSymbol}/purchase");

        //process template parameters
        Map<String, SimpleEntry<Object, Boolean>> templateParameters = new HashMap<>();
        templateParameters.put("shipSymbol",
                new SimpleEntry<Object, Boolean>(shipSymbol, true));
        ApiHelper.appendUrlWithTemplateParameters(queryBuilder, templateParameters);

        //load all headers for the outgoing API request
        Headers headers = new Headers();
        headers.add("Content-Type", "application/json");
        headers.add("user-agent", BaseController.userAgent);
        headers.add("accept", "application/json");

        //prepare and invoke the API call request to fetch the response
        String bodyJson = ApiHelper.serialize(body);
        HttpRequest request = getClientInstance().postBody(queryBuilder, headers, null, bodyJson);

        // Invoke the callback before request if its not null
        if (getHttpCallback() != null) {
            getHttpCallback().onBeforeRequest(request);
        }

        return request;
    }

    /**
     * Processes the response for postMyShipsShipSymbolPurchase.
     * @return An object of type MyShipsPurchaseResponse
     */
    private MyShipsPurchaseResponse handlePostMyShipsShipSymbolPurchaseResponse(
            HttpContext context) throws ApiException, IOException {
        HttpResponse response = context.getResponse();

        //invoke the callback after response if its not null
        if (getHttpCallback() != null) {
            getHttpCallback().onAfterResponse(context);
        }

        //handle errors defined at the API level
        validateResponse(response, context);

        //extract result from the http response
        String responseBody = ((HttpStringResponse) response).getBody();
        MyShipsPurchaseResponse result = ApiHelper.deserialize(responseBody,
                MyShipsPurchaseResponse.class);

        return result;
    }

    /**
     * Sell cargo from your ship's hold to the local market.
     * @param  shipSymbol  Required parameter: Example:
     * @param  body  Optional parameter: Example:
     * @return    Returns the MyShipsSellResponse response from the API call
     * @throws    ApiException    Represents error response from the server.
     * @throws    IOException    Signals that an I/O exception of some sort has occurred.
     */
    public MyShipsSellResponse postMyShipsShipSymbolSell(
            final String shipSymbol,
            final MyShipsSellRequest body) throws ApiException, IOException {
        HttpRequest request = buildPostMyShipsShipSymbolSellRequest(shipSymbol, body);
        authManagers.get("global").apply(request);

        HttpResponse response = getClientInstance().execute(request, false);
        HttpContext context = new HttpContext(request, response);

        return handlePostMyShipsShipSymbolSellResponse(context);
    }

    /**
     * Sell cargo from your ship's hold to the local market.
     * @param  shipSymbol  Required parameter: Example:
     * @param  body  Optional parameter: Example:
     * @return    Returns the MyShipsSellResponse response from the API call
     */
    public CompletableFuture<MyShipsSellResponse> postMyShipsShipSymbolSellAsync(
            final String shipSymbol,
            final MyShipsSellRequest body) {
        return makeHttpCallAsync(() -> buildPostMyShipsShipSymbolSellRequest(shipSymbol, body),
            req -> authManagers.get("global").applyAsync(req)
                .thenCompose(request -> getClientInstance()
                        .executeAsync(request, false)),
            context -> handlePostMyShipsShipSymbolSellResponse(context));
    }

    /**
     * Builds the HttpRequest object for postMyShipsShipSymbolSell.
     */
    private HttpRequest buildPostMyShipsShipSymbolSellRequest(
            final String shipSymbol,
            final MyShipsSellRequest body) throws JsonProcessingException {
        //the base uri for api requests
        String baseUri = config.getBaseUri();

        //prepare query string for API call
        final StringBuilder queryBuilder = new StringBuilder(baseUri
                + "/my/ships/{shipSymbol}/sell");

        //process template parameters
        Map<String, SimpleEntry<Object, Boolean>> templateParameters = new HashMap<>();
        templateParameters.put("shipSymbol",
                new SimpleEntry<Object, Boolean>(shipSymbol, true));
        ApiHelper.appendUrlWithTemplateParameters(queryBuilder, templateParameters);

        //load all headers for the outgoing API request
        Headers headers = new Headers();
        headers.add("Content-Type", "application/json");
        headers.add("user-agent", BaseController.userAgent);
        headers.add("accept", "application/json");

        //prepare and invoke the API call request to fetch the response
        String bodyJson = ApiHelper.serialize(body);
        HttpRequest request = getClientInstance().postBody(queryBuilder, headers, null, bodyJson);

        // Invoke the callback before request if its not null
        if (getHttpCallback() != null) {
            getHttpCallback().onBeforeRequest(request);
        }

        return request;
    }

    /**
     * Processes the response for postMyShipsShipSymbolSell.
     * @return An object of type MyShipsSellResponse
     */
    private MyShipsSellResponse handlePostMyShipsShipSymbolSellResponse(
            HttpContext context) throws ApiException, IOException {
        HttpResponse response = context.getResponse();

        //invoke the callback after response if its not null
        if (getHttpCallback() != null) {
            getHttpCallback().onAfterResponse(context);
        }

        //handle errors defined at the API level
        validateResponse(response, context);

        //extract result from the http response
        String responseBody = ((HttpStringResponse) response).getBody();
        MyShipsSellResponse result = ApiHelper.deserialize(responseBody,
                MyShipsSellResponse.class);

        return result;
    }

}