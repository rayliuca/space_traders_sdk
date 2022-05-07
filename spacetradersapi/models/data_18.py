# -*- coding: utf-8 -*-

"""
spacetradersapi

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""
from spacetradersapi.models.market_trade import MarketTrade
import os
from spacetradersapi.utilities.schema_validator_wrapper import SchemaValidatorWrapper
from jsonschema import ValidationError
from spacetradersapi.api_helper import APIHelper


class Data18(object):

    """Implementation of the 'Data18' model.

    TODO: type model description here.

    Attributes:
        exports (list of MarketTrade): TODO: type description here.
        imports (list of MarketTrade): TODO: type description here.
        exchange (list of MarketTrade): TODO: type description here.

    """

    # Create a mapping from Model property names to API property names
    _names = {
        "exports": 'exports',
        "imports": 'imports',
        "exchange": 'exchange'
    }

    def __init__(self,
                 exports=None,
                 imports=None,
                 exchange=None):
        """Constructor for the Data18 class"""

        # Initialize members of the class
        self.exports = exports
        self.imports = imports
        self.exchange = exchange

    @classmethod
    def from_dictionary(cls,
                        dictionary):
        """Creates an instance of this model from a dictionary

        Args:
            dictionary (dictionary): A dictionary representation of the object
            as obtained from the deserialization of the server's response. The
            keys MUST match property names in the API description.

        Returns:
            object: An instance of this structure class.

        """
        if dictionary is None:
            return None

        # Extract variables from the dictionary

        exports = None
        if dictionary.get('exports') is not None:
            exports = [MarketTrade.from_dictionary(x) for x in dictionary.get('exports')]
        imports = None
        if dictionary.get('imports') is not None:
            imports = [MarketTrade.from_dictionary(x) for x in dictionary.get('imports')]
        exchange = None
        if dictionary.get('exchange') is not None:
            exchange = [MarketTrade.from_dictionary(x) for x in dictionary.get('exchange')]
        # Return an object of this model
        return cls(exports,
                   imports,
                   exchange)

    @classmethod
    def validate(cls, val):
        """Validates value against class schema

        Args:
            val: the value to be validated

        Returns:
            boolean : if value is valid against schema.

        """
        return SchemaValidatorWrapper.getValidator(APIHelper.get_schema_path(os.path.abspath(__file__))).is_valid(val)
