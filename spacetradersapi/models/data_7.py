# -*- coding: utf-8 -*-

"""
spacetradersapi

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""
from spacetradersapi.models.cooldown import Cooldown
import os
from spacetradersapi.utilities.schema_validator_wrapper import SchemaValidatorWrapper
from jsonschema import ValidationError
from spacetradersapi.api_helper import APIHelper


class Data7(object):

    """Implementation of the 'Data7' model.

    TODO: type model description here.

    Attributes:
        cooldown (Cooldown): TODO: type description here.

    """

    # Create a mapping from Model property names to API property names
    _names = {
        "cooldown": 'cooldown'
    }

    def __init__(self,
                 cooldown=None):
        """Constructor for the Data7 class"""

        # Initialize members of the class
        self.cooldown = cooldown

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

        cooldown = Cooldown.from_dictionary(dictionary.get('cooldown')) if dictionary.get('cooldown') else None
        # Return an object of this model
        return cls(cooldown)

    @classmethod
    def validate(cls, val):
        """Validates value against class schema

        Args:
            val: the value to be validated

        Returns:
            boolean : if value is valid against schema.

        """
        return SchemaValidatorWrapper.getValidator(APIHelper.get_schema_path(os.path.abspath(__file__))).is_valid(val)
