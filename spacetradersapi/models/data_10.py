# -*- coding: utf-8 -*-

"""
spacetradersapi

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""
from spacetradersapi.models.cooldown import Cooldown
from spacetradersapi.models.jump import Jump
import os
from spacetradersapi.utilities.schema_validator_wrapper import SchemaValidatorWrapper
from jsonschema import ValidationError
from spacetradersapi.api_helper import APIHelper


class Data10(object):

    """Implementation of the 'Data10' model.

    TODO: type model description here.

    Attributes:
        jump (Jump): TODO: type description here.
        cooldown (Cooldown): TODO: type description here.

    """

    # Create a mapping from Model property names to API property names
    _names = {
        "jump": 'jump',
        "cooldown": 'cooldown'
    }

    def __init__(self,
                 jump=None,
                 cooldown=None):
        """Constructor for the Data10 class"""

        # Initialize members of the class
        self.jump = jump
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

        jump = Jump.from_dictionary(dictionary.get('jump')) if dictionary.get('jump') else None
        cooldown = Cooldown.from_dictionary(dictionary.get('cooldown')) if dictionary.get('cooldown') else None
        # Return an object of this model
        return cls(jump,
                   cooldown)

    @classmethod
    def validate(cls, val):
        """Validates value against class schema

        Args:
            val: the value to be validated

        Returns:
            boolean : if value is valid against schema.

        """
        return SchemaValidatorWrapper.getValidator(APIHelper.get_schema_path(os.path.abspath(__file__))).is_valid(val)