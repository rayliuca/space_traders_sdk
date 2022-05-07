# -*- coding: utf-8 -*-

"""
spacetradersapi

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""

from spacetradersapi.api_helper import APIHelper
from spacetradersapi.configuration import Server
from spacetradersapi.controllers.base_controller import BaseController
from spacetradersapi.models.trade_imports_response import TradeImportsResponse
from spacetradersapi.models.trade_exports_response import TradeExportsResponse
from spacetradersapi.models.trade_exchange_response import TradeExchangeResponse
from spacetradersapi.models.systems_markets_response import SystemsMarketsResponse
from spacetradersapi.models.systems_markets_response_1 import SystemsMarketsResponse1


class MarketsController(BaseController):

    """A Controller to access Endpoints in the spacetradersapi API."""
    def __init__(self, config, auth_managers):
        super(MarketsController, self).__init__(config, auth_managers)

    def post_my_ships_ship_symbol_deploy(self,
                                         ship_symbol,
                                         body=None):
        """Does a POST request to /my/ships/{shipSymbol}/deploy.

        Use this endpoint to deploy a Communications Relay to a waypoint. A
        waypoint with a communications relay will allow agents to retrieve
        price information from the market. Without a relay, agents must send a
        ship to a market to retrieve price information.
        Communication relays can be purchased from a market that exports
        `COMM_RELAY_I`.

        Args:
            ship_symbol (string): The ship symbol
            body (MyShipsDeployRequest, optional): TODO: type description
                here.

        Returns:
            void: Response from the API. OK

        Raises:
            APIException: When an error occurs while fetching the data from
                the remote API. This exception includes the HTTP Response
                code, an error message, and the HTTP body that was received in
                the request.

        """

        # Prepare query URL
        _url_path = '/my/ships/{shipSymbol}/deploy'
        _url_path = APIHelper.append_url_with_template_parameters(_url_path, {
            'shipSymbol': {'value': ship_symbol, 'encode': True}
        })
        _query_builder = self.config.get_base_uri()
        _query_builder += _url_path
        _query_url = APIHelper.clean_url(_query_builder)

        # Prepare headers
        _headers = {
            'Content-Type': 'application/json'
        }

        # Prepare and execute request
        _request = self.config.http_client.post(_query_url, headers=_headers, parameters=APIHelper.json_serialize(body))
        # Apply authentication scheme on request
        self.apply_auth_schemes(_request, 'global')

        _response = self.execute_request(_request)
        self.validate_response(_response)

    def get_trade_trade_symbol_imports(self,
                                       trade_symbol):
        """Does a GET request to /trade/{tradeSymbol}/imports.

        Trade Imports

        Args:
            trade_symbol (string): The trade symbol

        Returns:
            TradeImportsResponse: Response from the API. OK

        Raises:
            APIException: When an error occurs while fetching the data from
                the remote API. This exception includes the HTTP Response
                code, an error message, and the HTTP body that was received in
                the request.

        """

        # Prepare query URL
        _url_path = '/trade/{tradeSymbol}/imports'
        _url_path = APIHelper.append_url_with_template_parameters(_url_path, {
            'tradeSymbol': {'value': trade_symbol, 'encode': True}
        })
        _query_builder = self.config.get_base_uri()
        _query_builder += _url_path
        _query_url = APIHelper.clean_url(_query_builder)

        # Prepare headers
        _headers = {
            'accept': 'application/json'
        }

        # Prepare and execute request
        _request = self.config.http_client.get(_query_url, headers=_headers)
        # Apply authentication scheme on request
        self.apply_auth_schemes(_request, 'global')

        _response = self.execute_request(_request)
        self.validate_response(_response)

        decoded = APIHelper.json_deserialize(_response.text, TradeImportsResponse.from_dictionary)

        return decoded

    def get_trade_trade_symbol_exports(self,
                                       trade_symbol):
        """Does a GET request to /trade/{tradeSymbol}/exports.

        Trade Exports

        Args:
            trade_symbol (string): The trade symbol

        Returns:
            TradeExportsResponse: Response from the API. OK

        Raises:
            APIException: When an error occurs while fetching the data from
                the remote API. This exception includes the HTTP Response
                code, an error message, and the HTTP body that was received in
                the request.

        """

        # Prepare query URL
        _url_path = '/trade/{tradeSymbol}/exports'
        _url_path = APIHelper.append_url_with_template_parameters(_url_path, {
            'tradeSymbol': {'value': trade_symbol, 'encode': True}
        })
        _query_builder = self.config.get_base_uri()
        _query_builder += _url_path
        _query_url = APIHelper.clean_url(_query_builder)

        # Prepare headers
        _headers = {
            'accept': 'application/json'
        }

        # Prepare and execute request
        _request = self.config.http_client.get(_query_url, headers=_headers)
        # Apply authentication scheme on request
        self.apply_auth_schemes(_request, 'global')

        _response = self.execute_request(_request)
        self.validate_response(_response)

        decoded = APIHelper.json_deserialize(_response.text, TradeExportsResponse.from_dictionary)

        return decoded

    def get_trade_trade_symbol_exchange(self,
                                        trade_symbol):
        """Does a GET request to /trade/{tradeSymbol}/exchange.

        Trade Exchanges

        Args:
            trade_symbol (string): The trade symbol

        Returns:
            TradeExchangeResponse: Response from the API. OK

        Raises:
            APIException: When an error occurs while fetching the data from
                the remote API. This exception includes the HTTP Response
                code, an error message, and the HTTP body that was received in
                the request.

        """

        # Prepare query URL
        _url_path = '/trade/{tradeSymbol}/exchange'
        _url_path = APIHelper.append_url_with_template_parameters(_url_path, {
            'tradeSymbol': {'value': trade_symbol, 'encode': True}
        })
        _query_builder = self.config.get_base_uri()
        _query_builder += _url_path
        _query_url = APIHelper.clean_url(_query_builder)

        # Prepare headers
        _headers = {
            'accept': 'application/json'
        }

        # Prepare and execute request
        _request = self.config.http_client.get(_query_url, headers=_headers)
        # Apply authentication scheme on request
        self.apply_auth_schemes(_request, 'global')

        _response = self.execute_request(_request)
        self.validate_response(_response)

        decoded = APIHelper.json_deserialize(_response.text, TradeExchangeResponse.from_dictionary)

        return decoded

    def get_systems_system_symbol_markets(self,
                                          system_symbol):
        """Does a GET request to /systems/{systemSymbol}/markets.

        Retrieve a list of all charted markets in the given system. Markets
        are only available if the waypoint is charted and contains a
        communications relay.
        To install a communications relay at a market, look at the
        `my/ships/{shipSymbol}/deploy` endpoint.

        Args:
            system_symbol (string): The system symbol

        Returns:
            SystemsMarketsResponse: Response from the API. OK

        Raises:
            APIException: When an error occurs while fetching the data from
                the remote API. This exception includes the HTTP Response
                code, an error message, and the HTTP body that was received in
                the request.

        """

        # Prepare query URL
        _url_path = '/systems/{systemSymbol}/markets'
        _url_path = APIHelper.append_url_with_template_parameters(_url_path, {
            'systemSymbol': {'value': system_symbol, 'encode': True}
        })
        _query_builder = self.config.get_base_uri()
        _query_builder += _url_path
        _query_url = APIHelper.clean_url(_query_builder)

        # Prepare headers
        _headers = {
            'accept': 'application/json'
        }

        # Prepare and execute request
        _request = self.config.http_client.get(_query_url, headers=_headers)
        # Apply authentication scheme on request
        self.apply_auth_schemes(_request, 'global')

        _response = self.execute_request(_request)
        self.validate_response(_response)

        decoded = APIHelper.json_deserialize(_response.text, SystemsMarketsResponse.from_dictionary)

        return decoded

    def get_systems_system_symbol_markets_waypoint_symbol(self,
                                                          system_symbol,
                                                          waypoint_symbol):
        """Does a GET request to /systems/{systemSymbol}/markets/{waypointSymbol}.

        Retrieve imports, exports and exchange data from a marketplace.
        Imports can be sold, exports can be purchased, and exchange trades can
        be purchased or sold.
        Market data is only available if you have a ship at the location, or
        the location is charted and has a communications relay deployed.
        See `/my/ships/{shipSymbol}/deploy` for deploying relays at a
        location.

        Args:
            system_symbol (string): The system symbol
            waypoint_symbol (string): The waypoint symbol

        Returns:
            SystemsMarketsResponse1: Response from the API. OK

        Raises:
            APIException: When an error occurs while fetching the data from
                the remote API. This exception includes the HTTP Response
                code, an error message, and the HTTP body that was received in
                the request.

        """

        # Prepare query URL
        _url_path = '/systems/{systemSymbol}/markets/{waypointSymbol}'
        _url_path = APIHelper.append_url_with_template_parameters(_url_path, {
            'systemSymbol': {'value': system_symbol, 'encode': True},
            'waypointSymbol': {'value': waypoint_symbol, 'encode': True}
        })
        _query_builder = self.config.get_base_uri()
        _query_builder += _url_path
        _query_url = APIHelper.clean_url(_query_builder)

        # Prepare headers
        _headers = {
            'accept': 'application/json'
        }

        # Prepare and execute request
        _request = self.config.http_client.get(_query_url, headers=_headers)
        # Apply authentication scheme on request
        self.apply_auth_schemes(_request, 'global')

        _response = self.execute_request(_request)
        self.validate_response(_response)

        decoded = APIHelper.json_deserialize(_response.text, SystemsMarketsResponse1.from_dictionary)

        return decoded