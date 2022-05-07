
# My Ships Scan Response

## Structure

`MyShipsScanResponse`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Data` | [`MyShipsScanResponseData`]($m/MyShipsScanResponseData) | Required | - | MyShipsScanResponseData getData() | setData(MyShipsScanResponseData data) |

## Example (as JSON)

```json
{
  "data": {
    "ships": [
      {
        "symbol": "symbol1",
        "registration": {
          "factionSymbol": "factionSymbol1",
          "role": "role5"
        },
        "frameSymbol": "frameSymbol3",
        "reactorSymbol": "reactorSymbol9",
        "engineSymbol": "engineSymbol7",
        "expiration": "expiration9"
      },
      {
        "symbol": "symbol0",
        "registration": {
          "factionSymbol": "factionSymbol2",
          "role": "role4"
        },
        "frameSymbol": "frameSymbol4",
        "reactorSymbol": "reactorSymbol8",
        "engineSymbol": "engineSymbol8",
        "expiration": "expiration8"
      }
    ],
    "cooldown": {
      "duration": 149,
      "expiration": "expiration3"
    }
  }
}
```

