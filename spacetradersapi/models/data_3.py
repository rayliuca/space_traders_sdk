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


class Data3(object):

    """Implementation of the 'Data3' model.

    TODO: type model description here.

    Attributes:
        status (string): TODO: type description here.

    """

    # Create a mapping from Model property names to API property names
    _names = {
        "status": 'status'
    }

    def __init__(self,
                 status=None):
        """Constructor for the Data3 class"""

        # Initialize members of the class
        self.status = status

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

        status = dictionary.get('status')
        # Return an object of this model
        return cls(status)

    @classmethod
    def validate(cls, val):
        """Validates value against class schema

        Args:
            val: the value to be validated

        Returns:
            boolean : if value is valid against schema.

        """
        return SchemaValidatorWrapper.getValidator(APIHelper.get_schema_path(os.path.abspath(__file__))).is_valid(val)
