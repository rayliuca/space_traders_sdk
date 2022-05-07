# -*- coding: utf-8 -*-

"""
spacetradersapi

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""
import os
from spacetradersapi.utilities.schema_validator_wrapper import SchemaValidatorWrapper
from jsonschema import ValidationError
from spacetradersapi.api_helper import APIHelper


class Deliver(object):

    """Implementation of the 'Deliver' model.

    TODO: type model description here.

    Attributes:
        trade_symbol (string): TODO: type description here.
        destination (string): TODO: type description here.
        units (int): TODO: type description here.
        fulfilled (int): TODO: type description here.

    """

    # Create a mapping from Model property names to API property names
    _names = {
        "trade_symbol": 'tradeSymbol',
        "destination": 'destination',
        "units": 'units',
        "fulfilled": 'fulfilled'
    }

    def __init__(self,
                 trade_symbol=None,
                 destination=None,
                 units=None,
                 fulfilled=None):
        """Constructor for the Deliver class"""

        # Initialize members of the class
        self.trade_symbol = trade_symbol
        self.destination = destination
        self.units = units
        self.fulfilled = fulfilled

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

        trade_symbol = dictionary.get('tradeSymbol')
        destination = dictionary.get('destination')
        units = dictionary.get('units')
        fulfilled = dictionary.get('fulfilled')
        # Return an object of this model
        return cls(trade_symbol,
                   destination,
                   units,
                   fulfilled)

    @classmethod
    def validate(cls, val):
        """Validates value against class schema

        Args:
            val: the value to be validated

        Returns:
            boolean : if value is valid against schema.

        """
        return SchemaValidatorWrapper.getValidator(APIHelper.get_schema_path(os.path.abspath(__file__))).is_valid(val)
