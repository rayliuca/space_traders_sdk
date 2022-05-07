<?php

declare(strict_types=1);

/*
 * SpaceTradersAPILib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace SpaceTradersAPILib\Models;

use stdClass;

class SystemsShipyardsResponse implements \JsonSerializable
{
    /**
     * @var Shipyard[]
     */
    private $data;

    /**
     * @var Meta
     */
    private $meta;

    /**
     * @param Shipyard[] $data
     * @param Meta $meta
     */
    public function __construct(array $data, Meta $meta)
    {
        $this->data = $data;
        $this->meta = $meta;
    }

    /**
     * Returns Data.
     *
     * @return Shipyard[]
     */
    public function getData(): array
    {
        return $this->data;
    }

    /**
     * Sets Data.
     *
     * @required
     * @maps data
     *
     * @param Shipyard[] $data
     */
    public function setData(array $data): void
    {
        $this->data = $data;
    }

    /**
     * Returns Meta.
     */
    public function getMeta(): Meta
    {
        return $this->meta;
    }

    /**
     * Sets Meta.
     *
     * @required
     * @maps meta
     */
    public function setMeta(Meta $meta): void
    {
        $this->meta = $meta;
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
        $json['meta'] = $this->meta;

        return (!$asArrayWhenEmpty && empty($json)) ? new stdClass() : $json;
    }
}
