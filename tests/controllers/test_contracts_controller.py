# -*- coding: utf-8 -*-

"""
spacetradersapi

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""

import json
import dateutil.parser

from tests.controllers.controller_test_base import ControllerTestBase
from tests.test_helper import TestHelper
from spacetradersapi.api_helper import APIHelper


class ContractsControllerTests(ControllerTestBase):

    @classmethod
    def setUpClass(cls):
        super(ContractsControllerTests, cls).setUpClass()
        cls.controller = cls.client.contracts
        cls.response_catcher = cls.controller.http_call_back

    # List all of your contracts.
    def test_get_my_contracts(self):

        # Perform the API call through the SDK function
        result = self.controller.get_my_contracts()

        # Test response code
        self.assertEquals(self.response_catcher.response.status_code, 200)

        # Test headers
        expected_headers = {}
        expected_headers['content-type'] = 'application/json'

        self.assertTrue(TestHelper.match_headers(expected_headers, self.response_catcher.response.headers))

        
        # Test whether the captured response is as we expected
        self.assertIsNotNone(result)
        expected_body = APIHelper.json_deserialize('{"data":[{"id":"cl0hok38t0014ks0jnoy8o5vh","faction":"COMMERCE_REP'
            'UBLIC","type":"PROCUREMENT","terms":{"deadline":"2022-03-11T05:16:'
            '59.113Z","payment":{"onAccepted":20000,"onFulfilled":100000},"deli'
            'ver":[{"tradeSymbol":"IRON_ORE","destination":"X1-OE-PM","units":1'
            '0000,"fulfilled":0}]},"accepted":false,"fulfilled":false,"expiresA'
            't":"2022-03-09T05:16:59.112Z"}],"meta":{"total":10,"page":1,"limit'
            '":10}}')
        received_body = APIHelper.json_deserialize(self.response_catcher.response.text)
        self.assertTrue(TestHelper.match_body(expected_body, received_body))

