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


class Survey(object):

    """Implementation of the 'Survey' model.

    TODO: type model description here.

    Attributes:
        signature (string): TODO: type description here.
        deposits (list of string): TODO: type description here.
        expiration (string): TODO: type description here.

    """

    # Create a mapping from Model property names to API property names
    _names = {
        "signature": 'signature',
        "deposits": 'deposits',
        "expiration": 'expiration'
    }

    def __init__(self,
                 signature=None,
                 deposits=None,
                 expiration=None):
        """Constructor for the Survey class"""

        # Initialize members of the class
        self.signature = signature
        self.deposits = deposits
        self.expiration = expiration

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

        signature = dictionary.get('signature')
        deposits = dictionary.get('deposits')
        expiration = dictionary.get('expiration')
        # Return an object of this model
        return cls(signature,
                   deposits,
                   expiration)

    @classmethod
    def validate(cls, val):
        """Validates value against class schema

        Args:
            val: the value to be validated

        Returns:
            boolean : if value is valid against schema.

        """
        return SchemaValidatorWrapper.getValidator(APIHelper.get_schema_path(os.path.abspath(__file__))).is_valid(val)
