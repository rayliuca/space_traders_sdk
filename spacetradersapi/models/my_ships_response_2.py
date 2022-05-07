# -*- coding: utf-8 -*-

"""
spacetradersapi

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""
from spacetradersapi.models.data_17 import Data17
import os
from spacetradersapi.utilities.schema_validator_wrapper import SchemaValidatorWrapper
from jsonschema import ValidationError
from spacetradersapi.api_helper import APIHelper


class MyShipsResponse2(object):

    """Implementation of the 'My Ships Response2' model.

    TODO: type model description here.

    Attributes:
        data (Data17): TODO: type description here.

    """

    # Create a mapping from Model property names to API property names
    _names = {
        "data": 'data'
    }

    def __init__(self,
                 data=None):
        """Constructor for the MyShipsResponse2 class"""

        # Initialize members of the class
        self.data = data

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

        data = Data17.from_dictionary(dictionary.get('data')) if dictionary.get('data') else None
        # Return an object of this model
        return cls(data)

    @classmethod
    def validate(cls, val):
        """Validates value against class schema

        Args:
            val: the value to be validated

        Returns:
            boolean : if value is valid against schema.

        """
        return SchemaValidatorWrapper.getValidator(APIHelper.get_schema_path(os.path.abspath(__file__))).is_valid(val)
