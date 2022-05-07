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


class Registration(object):

    """Implementation of the 'Registration' model.

    TODO: type model description here.

    Attributes:
        faction_symbol (string): TODO: type description here.
        role (string): TODO: type description here.

    """

    # Create a mapping from Model property names to API property names
    _names = {
        "faction_symbol": 'factionSymbol',
        "role": 'role'
    }

    def __init__(self,
                 faction_symbol=None,
                 role=None):
        """Constructor for the Registration class"""

        # Initialize members of the class
        self.faction_symbol = faction_symbol
        self.role = role

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

        faction_symbol = dictionary.get('factionSymbol')
        role = dictionary.get('role')
        # Return an object of this model
        return cls(faction_symbol,
                   role)

    @classmethod
    def validate(cls, val):
        """Validates value against class schema

        Args:
            val: the value to be validated

        Returns:
            boolean : if value is valid against schema.

        """
        return SchemaValidatorWrapper.getValidator(APIHelper.get_schema_path(os.path.abspath(__file__))).is_valid(val)
