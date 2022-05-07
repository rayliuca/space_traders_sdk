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


class Waypoint(object):

    """Implementation of the 'Waypoint' model.

    TODO: type model description here.

    Attributes:
        system (string): TODO: type description here.
        symbol (string): TODO: type description here.
        mtype (string): TODO: type description here.
        x (int): TODO: type description here.
        y (int): TODO: type description here.
        orbitals (list of string): TODO: type description here.
        faction (string): TODO: type description here.
        features (list of string): TODO: type description here.
        traits (list of string): TODO: type description here.
        charted (bool): TODO: type description here.
        charted_by (string): TODO: type description here.

    """

    # Create a mapping from Model property names to API property names
    _names = {
        "system": 'system',
        "symbol": 'symbol',
        "mtype": 'type',
        "x": 'x',
        "y": 'y',
        "orbitals": 'orbitals',
        "faction": 'faction',
        "features": 'features',
        "traits": 'traits',
        "charted": 'charted',
        "charted_by": 'chartedBy'
    }

    def __init__(self,
                 system=None,
                 symbol=None,
                 mtype=None,
                 x=None,
                 y=None,
                 orbitals=None,
                 faction=None,
                 features=None,
                 traits=None,
                 charted=None,
                 charted_by=None):
        """Constructor for the Waypoint class"""

        # Initialize members of the class
        self.system = system
        self.symbol = symbol
        self.mtype = mtype
        self.x = x
        self.y = y
        self.orbitals = orbitals
        self.faction = faction
        self.features = features
        self.traits = traits
        self.charted = charted
        self.charted_by = charted_by

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

        system = dictionary.get('system')
        symbol = dictionary.get('symbol')
        mtype = dictionary.get('type')
        x = dictionary.get('x')
        y = dictionary.get('y')
        orbitals = dictionary.get('orbitals')
        faction = dictionary.get('faction')
        features = dictionary.get('features')
        traits = dictionary.get('traits')
        charted = dictionary.get('charted')
        charted_by = dictionary.get('chartedBy')
        # Return an object of this model
        return cls(system,
                   symbol,
                   mtype,
                   x,
                   y,
                   orbitals,
                   faction,
                   features,
                   traits,
                   charted,
                   charted_by)

    @classmethod
    def validate(cls, val):
        """Validates value against class schema

        Args:
            val: the value to be validated

        Returns:
            boolean : if value is valid against schema.

        """
        return SchemaValidatorWrapper.getValidator(APIHelper.get_schema_path(os.path.abspath(__file__))).is_valid(val)
