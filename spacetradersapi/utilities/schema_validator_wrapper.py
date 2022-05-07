
import json
import os
from jsonschema import RefResolver, Draft4Validator


class SchemaValidatorWrapper(object):
    cache = dict()

    @staticmethod
    def getValidator(fileName):
        if fileName in SchemaValidatorWrapper.cache:
            schema = SchemaValidatorWrapper.cache[fileName]
        else:
            schema = json.load(open(fileName))
            SchemaValidatorWrapper.cache[fileName] = schema

        schema_path = 'file:///{0}/'.format(
            os.path.dirname(os.path.abspath(fileName)).replace("\\", "/"))
        resolver = RefResolver(schema_path, schema)
        return Draft4Validator(schema=schema, resolver=resolver)
