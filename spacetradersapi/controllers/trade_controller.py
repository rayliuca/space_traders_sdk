# -*- coding: utf-8 -*-

"""
spacetradersapi

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""

from spacetradersapi.api_helper import APIHelper
from spacetradersapi.configuration import Server
from spacetradersapi.controllers.base_controller import BaseController
from spacetradersapi.models.my_ships_purchase_response import MyShipsPurchaseResponse
from spacetradersapi.models.my_ships_sell_response import MyShipsSellResponse


class TradeController(BaseController):

    """A Controller to access Endpoints in the spacetradersapi API."""
    def __init__(self, config, auth_managers):
        super(TradeController, self).__init__(config, auth_managers)

    def post_my_ships_ship_symbol_purchase(self,
                                           ship_symbol,
                                           body=None):
        """Does a POST request to /my/ships/{shipSymbol}/purchase.

        Purchase Cargo

        Args:
            ship_symbol (string): TODO: type description here.
            body (MyShipsPurchaseRequest, optional): TODO: type description
                here.

        Returns:
            MyShipsPurchaseResponse: Response from the API. Created

        Raises:
            APIException: When an error occurs while fetching the data from
                the remote API. This exception includes the HTTP Response
                code, an error message, and the HTTP body that was received in
                the request.

        """

        # Prepare query URL
        _url_path = '/my/ships/{shipSymbol}/purchase'
        _url_path = APIHelper.append_url_with_template_parameters(_url_path, {
            'shipSymbol': {'value': ship_symbol, 'encode': True}
        })
        _query_builder = self.config.get_base_uri()
        _query_builder += _url_path
        _query_url = APIHelper.clean_url(_query_builder)

        # Prepare headers
        _headers = {
            'accept': 'application/json',
            'Content-Type': 'application/json'
        }

        # Prepare and execute request
        _request = self.config.http_client.post(_query_url, headers=_headers, parameters=APIHelper.json_serialize(body))
        # Apply authentication scheme on request
        self.apply_auth_schemes(_request, 'global')

        _response = self.execute_request(_request)
        self.validate_response(_response)

        decoded = APIHelper.json_deserialize(_response.text, MyShipsPurchaseResponse.from_dictionary)

        return decoded

    def post_my_ships_ship_symbol_sell(self,
                                       ship_symbol,
                                       body=None):
        """Does a POST request to /my/ships/{shipSymbol}/sell.

        Sell cargo from your ship's hold to the local market.

        Args:
            ship_symbol (string): TODO: type description here.
            body (MyShipsSellRequest, optional): TODO: type description here.

        Returns:
            MyShipsSellResponse: Response from the API. OK

        Raises:
            APIException: When an error occurs while fetching the data from
                the remote API. This exception includes the HTTP Response
                code, an error message, and the HTTP body that was received in
                the request.

        """

        # Prepare query URL
        _url_path = '/my/ships/{shipSymbol}/sell'
        _url_path = APIHelper.append_url_with_template_parameters(_url_path, {
            'shipSymbol': {'value': ship_symbol, 'encode': True}
        })
        _query_builder = self.config.get_base_uri()
        _query_builder += _url_path
        _query_url = APIHelper.clean_url(_query_builder)

        # Prepare headers
        _headers = {
            'accept': 'application/json',
            'Content-Type': 'application/json'
        }

        # Prepare and execute request
        _request = self.config.http_client.post(_query_url, headers=_headers, parameters=APIHelper.json_serialize(body))
        # Apply authentication scheme on request
        self.apply_auth_schemes(_request, 'global')

        _response = self.execute_request(_request)
        self.validate_response(_response)

        decoded = APIHelper.json_deserialize(_response.text, MyShipsSellResponse.from_dictionary)

        return decoded