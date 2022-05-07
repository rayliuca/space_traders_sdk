<?php

declare(strict_types=1);

/*
 * SpaceTradersAPILib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace SpaceTradersAPILib\Controllers;

use SpaceTradersAPILib\Exceptions\ApiException;
use SpaceTradersAPILib\ConfigurationInterface;
use SpaceTradersAPILib\ApiHelper;
use SpaceTradersAPILib\Models;
use SpaceTradersAPILib\Http\HttpRequest;
use SpaceTradersAPILib\Http\HttpResponse;
use SpaceTradersAPILib\Http\HttpMethod;
use SpaceTradersAPILib\Http\HttpContext;
use SpaceTradersAPILib\Http\HttpCallBack;
use Unirest\Request;

class TradeController extends BaseController
{
    public function __construct(ConfigurationInterface $config, array $authManagers, ?HttpCallBack $httpCallBack)
    {
        parent::__construct($config, $authManagers, $httpCallBack);
    }

    /**
     * Purchase Cargo
     *
     * @param string $shipSymbol
     * @param Models\MyShipsPurchaseRequest|null $body
     *
     * @return Models\MyShipsPurchaseResponse Response from the API call
     *
     * @throws ApiException Thrown if API call fails
     */
    public function postMyShipsShipSymbolPurchase(
        string $shipSymbol,
        ?Models\MyShipsPurchaseRequest $body = null
    ): Models\MyShipsPurchaseResponse {
        //prepare query string for API call
        $_queryUrl = $this->config->getBaseUri() . '/my/ships/{shipSymbol}/purchase';

        //process template parameters
        $_queryUrl = ApiHelper::appendUrlWithTemplateParameters($_queryUrl, [
            'shipSymbol'   => $shipSymbol,
        ]);

        //prepare headers
        $_headers = [
            'user-agent'    => self::$userAgent,
            'Accept'        => 'application/json',
            'Content-Type'    => 'application/json'
        ];

        //json encode body
        $_bodyJson = ApiHelper::serialize($body);

        $_httpRequest = new HttpRequest(HttpMethod::POST, $_headers, $_queryUrl);

        // Apply authorization to request
        $this->getAuthManager('global')->apply($_httpRequest);

        //call on-before Http callback
        if ($this->getHttpCallBack() != null) {
            $this->getHttpCallBack()->callOnBeforeRequest($_httpRequest);
        }

        // and invoke the API call request to fetch the response
        try {
            $response = Request::post($_httpRequest->getQueryUrl(), $_httpRequest->getHeaders(), $_bodyJson);
        } catch (\Unirest\Exception $ex) {
            throw new ApiException($ex->getMessage(), $_httpRequest);
        }


        $_httpResponse = new HttpResponse($response->code, $response->headers, $response->raw_body);
        $_httpContext = new HttpContext($_httpRequest, $_httpResponse);

        //call on-after Http callback
        if ($this->getHttpCallBack() != null) {
            $this->getHttpCallBack()->callOnAfterRequest($_httpContext);
        }

        //handle errors defined at the API level
        $this->validateResponse($_httpResponse, $_httpRequest);
        return ApiHelper::mapClass($_httpRequest, $_httpResponse, $response->body, 'MyShipsPurchaseResponse');
    }

    /**
     * Sell cargo from your ship's hold to the local market.
     *
     * @param string $shipSymbol
     * @param Models\MyShipsSellRequest|null $body
     *
     * @return Models\MyShipsSellResponse Response from the API call
     *
     * @throws ApiException Thrown if API call fails
     */
    public function postMyShipsShipSymbolSell(
        string $shipSymbol,
        ?Models\MyShipsSellRequest $body = null
    ): Models\MyShipsSellResponse {
        //prepare query string for API call
        $_queryUrl = $this->config->getBaseUri() . '/my/ships/{shipSymbol}/sell';

        //process template parameters
        $_queryUrl = ApiHelper::appendUrlWithTemplateParameters($_queryUrl, [
            'shipSymbol'   => $shipSymbol,
        ]);

        //prepare headers
        $_headers = [
            'user-agent'    => self::$userAgent,
            'Accept'        => 'application/json',
            'Content-Type'    => 'application/json'
        ];

        //json encode body
        $_bodyJson = ApiHelper::serialize($body);

        $_httpRequest = new HttpRequest(HttpMethod::POST, $_headers, $_queryUrl);

        // Apply authorization to request
        $this->getAuthManager('global')->apply($_httpRequest);

        //call on-before Http callback
        if ($this->getHttpCallBack() != null) {
            $this->getHttpCallBack()->callOnBeforeRequest($_httpRequest);
        }

        // and invoke the API call request to fetch the response
        try {
            $response = Request::post($_httpRequest->getQueryUrl(), $_httpRequest->getHeaders(), $_bodyJson);
        } catch (\Unirest\Exception $ex) {
            throw new ApiException($ex->getMessage(), $_httpRequest);
        }


        $_httpResponse = new HttpResponse($response->code, $response->headers, $response->raw_body);
        $_httpContext = new HttpContext($_httpRequest, $_httpResponse);

        //call on-after Http callback
        if ($this->getHttpCallBack() != null) {
            $this->getHttpCallBack()->callOnAfterRequest($_httpContext);
        }

        //handle errors defined at the API level
        $this->validateResponse($_httpResponse, $_httpRequest);
        return ApiHelper::mapClass($_httpRequest, $_httpResponse, $response->body, 'MyShipsSellResponse');
    }
}
