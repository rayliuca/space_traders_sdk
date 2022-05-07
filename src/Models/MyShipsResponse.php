<?php

declare(strict_types=1);

/*
 * SpaceTradersAPILib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace SpaceTradersAPILib\Models;

use stdClass;

class MyShipsResponse implements \JsonSerializable
{
    /**
     * @var Ship
     */
    private $data;

    /**
     * @param Ship $data
     */
    public function __construct(Ship $data)
    {
        $this->data = $data;
    }

    /**
     * Returns Data.
     */
    public function getData(): Ship
    {
        return $this->data;
    }

    /**
     * Sets Data.
     *
     * @required
     * @maps data
     */
    public function setData(Ship $data): void
    {
        $this->data = $data;
    }

    /**
     * Encode this object to JSON
     *
     * @param bool $asArrayWhenEmpty Whether to serialize this model as an array whenever no fields
     *        are set. (default: false)
     *
     * @return array|stdClass
     */
    #[\ReturnTypeWillChange] // @phan-suppress-current-line PhanUndeclaredClassAttribute for (php < 8.1)
    public function jsonSerialize(bool $asArrayWhenEmpty = false)
    {
        $json = [];
        $json['data'] = $this->data;

        return (!$asArrayWhenEmpty && empty($json)) ? new stdClass() : $json;
    }
}
