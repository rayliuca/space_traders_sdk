# -*- coding: utf-8 -*-

"""
spacetradersapi

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""

from spacetradersapi.api_helper import APIHelper
from spacetradersapi.configuration import Server
from spacetradersapi.controllers.base_controller import BaseController
from spacetradersapi.models.my_ships_chart_response import MyShipsChartResponse
from spacetradersapi.models.systems_response import SystemsResponse
from spacetradersapi.models.systems_response_1 import SystemsResponse1
from spacetradersapi.models.systems_waypoints_response import SystemsWaypointsResponse


class SystemsController(BaseController):

    """A Controller to access Endpoints in the spacetradersapi API."""
    def __init__(self, config, auth_managers):
        super(SystemsController, self).__init__(config, auth_managers)

    def post_my_ships_ship_symbol_chart(self,
                                        ship_symbol):
        """Does a POST request to /my/ships/{shipSymbol}/chart.

        Chart a new system or waypoint. Returns an array of the symbols that
        have been charted, including the system and the waypoint if both were
        uncharted, or just the waypoint.

        Args:
            ship_symbol (string): The symbol of the ship

        Returns:
            MyShipsChartResponse: Response from the API. OK

        Raises:
            APIException: When an error occurs while fetching the data from
                the remote API. This exception includes the HTTP Response
                code, an error message, and the HTTP body that was received in
                the request.

        """

        # Prepare query URL
        _url_path = '/my/ships/{shipSymbol}/chart'
        _url_path = APIHelper.append_url_with_template_parameters(_url_path, {
            'shipSymbol': {'value': ship_symbol, 'encode': True}
        })
        _query_builder = self.config.get_base_uri()
        _query_builder += _url_path
        _query_url = APIHelper.clean_url(_query_builder)

        # Prepare headers
        _headers = {
            'accept': 'application/json'
        }

        # Prepare and execute request
        _request = self.config.http_client.post(_query_url, headers=_headers)
        # Apply authentication scheme on request
        self.apply_auth_schemes(_request, 'global')

        _response = self.execute_request(_request)
        self.validate_response(_response)

        decoded = APIHelper.json_deserialize(_response.text, MyShipsChartResponse.from_dictionary)

        return decoded

    def get_systems(self):
        """Does a GET request to /systems.

        Return a list of all systems.

        Returns:
            SystemsResponse: Response from the API. OK

        Raises:
            APIException: When an error occurs while fetching the data from
                the remote API. This exception includes the HTTP Response
                code, an error message, and the HTTP body that was received in
                the request.

        """

        # Prepare query URL
        _url_path = '/systems'
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

        decoded = APIHelper.json_deserialize(_response.text, SystemsResponse.from_dictionary)

        return decoded

    def get_systems_system_symbol(self,
                                  system_symbol):
        """Does a GET request to /systems/{systemSymbol}.

        View System

        Args:
            system_symbol (string): The system symbol

        Returns:
            SystemsResponse1: Response from the API. OK

        Raises:
            APIException: When an error occurs while fetching the data from
                the remote API. This exception includes the HTTP Response
                code, an error message, and the HTTP body that was received in
                the request.

        """

        # Prepare query URL
        _url_path = '/systems/{systemSymbol}'
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

        decoded = APIHelper.json_deserialize(_response.text, SystemsResponse1.from_dictionary)

        return decoded

    def get_systems_system_symbol_waypoints_waypoint_symbol(self,
                                                            system_symbol):
        """Does a GET request to /systems/{systemSymbol}/waypoints.

        Fetch all of the waypoints for a given system. System must be charted
        or a ship must be present to return waypoint details.

        Args:
            system_symbol (string): The system symbol

        Returns:
            SystemsWaypointsResponse: Response from the API. OK

        Raises:
            APIException: When an error occurs while fetching the data from
                the remote API. This exception includes the HTTP Response
                code, an error message, and the HTTP body that was received in
                the request.

        """

        # Prepare query URL
        _url_path = '/systems/{systemSymbol}/waypoints'
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

        decoded = APIHelper.json_deserialize(_response.text, SystemsWaypointsResponse.from_dictionary)

        return decoded

    def get_systems_system_symbol_waypoints(self,
                                            system_symbol,
                                            waypoint_symbol):
        """Does a GET request to /systems/{systemSymbol}/waypoints/{waypointSymbol}.

        View the details of a waypoint.

        Args:
            system_symbol (string): The system symbol
            waypoint_symbol (string): The waypoint symbol

        Returns:
            SystemsWaypointsResponse: Response from the API. OK

        Raises:
            APIException: When an error occurs while fetching the data from
                the remote API. This exception includes the HTTP Response
                code, an error message, and the HTTP body that was received in
                the request.

        """

        # Prepare query URL
        _url_path = '/systems/{systemSymbol}/waypoints/{waypointSymbol}'
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

        decoded = APIHelper.json_deserialize(_response.text, SystemsWaypointsResponse.from_dictionary)

        return decoded
