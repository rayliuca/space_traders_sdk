<?php

declare(strict_types=1);

/*
 * SpaceTradersAPILib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace SpaceTradersAPILib\Models;

use stdClass;

class Stats implements \JsonSerializable
{
    /**
     * @var int
     */
    private $fuelTank;

    /**
     * @var int
     */
    private $cargoLimit;

    /**
     * @var int
     */
    private $jumpRange;

    /**
     * @param int $fuelTank
     * @param int $cargoLimit
     * @param int $jumpRange
     */
    public function __construct(int $fuelTank, int $cargoLimit, int $jumpRange)
    {
        $this->fuelTank = $fuelTank;
        $this->cargoLimit = $cargoLimit;
        $this->jumpRange = $jumpRange;
    }

    /**
     * Returns Fuel Tank.
     */
    public function getFuelTank(): int
    {
        return $this->fuelTank;
    }

    /**
     * Sets Fuel Tank.
     *
     * @required
     * @maps fuelTank
     */
    public function setFuelTank(int $fuelTank): void
    {
        $this->fuelTank = $fuelTank;
    }

    /**
     * Returns Cargo Limit.
     */
    public function getCargoLimit(): int
    {
        return $this->cargoLimit;
    }

    /**
     * Sets Cargo Limit.
     *
     * @required
     * @maps cargoLimit
     */
    public function setCargoLimit(int $cargoLimit): void
    {
        $this->cargoLimit = $cargoLimit;
    }

    /**
     * Returns Jump Range.
     */
    public function getJumpRange(): int
    {
        return $this->jumpRange;
    }

    /**
     * Sets Jump Range.
     *
     * @required
     * @maps jumpRange
     */
    public function setJumpRange(int $jumpRange): void
    {
        $this->jumpRange = $jumpRange;
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
        $json['fuelTank']   = $this->fuelTank;
        $json['cargoLimit'] = $this->cargoLimit;
        $json['jumpRange']  = $this->jumpRange;

        return (!$asArrayWhenEmpty && empty($json)) ? new stdClass() : $json;
    }
}