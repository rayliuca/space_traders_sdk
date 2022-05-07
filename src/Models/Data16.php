<?php

declare(strict_types=1);

/*
 * SpaceTradersAPILib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace SpaceTradersAPILib\Models;

use stdClass;

class Data16 implements \JsonSerializable
{
    /**
     * @var ShipNavigation|null
     */
    private $navigation;

    /**
     * Returns Navigation.
     */
    public function getNavigation(): ?ShipNavigation
    {
        return $this->navigation;
    }

    /**
     * Sets Navigation.
     *
     * @maps navigation
     */
    public function setNavigation(?ShipNavigation $navigation): void
    {
        $this->navigation = $navigation;
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
        if (isset($this->navigation)) {
            $json['navigation'] = $this->navigation;
        }

        return (!$asArrayWhenEmpty && empty($json)) ? new stdClass() : $json;
    }
}