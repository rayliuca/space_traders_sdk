<?php

declare(strict_types=1);

/*
 * SpaceTradersAPILib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace SpaceTradersAPILib\Models;

use stdClass;

class Integrity implements \JsonSerializable
{
    /**
     * @var float
     */
    private $frame;

    /**
     * @var float
     */
    private $reactor;

    /**
     * @var float
     */
    private $engine;

    /**
     * @param float $frame
     * @param float $reactor
     * @param float $engine
     */
    public function __construct(float $frame, float $reactor, float $engine)
    {
        $this->frame = $frame;
        $this->reactor = $reactor;
        $this->engine = $engine;
    }

    /**
     * Returns Frame.
     */
    public function getFrame(): float
    {
        return $this->frame;
    }

    /**
     * Sets Frame.
     *
     * @required
     * @maps frame
     */
    public function setFrame(float $frame): void
    {
        $this->frame = $frame;
    }

    /**
     * Returns Reactor.
     */
    public function getReactor(): float
    {
        return $this->reactor;
    }

    /**
     * Sets Reactor.
     *
     * @required
     * @maps reactor
     */
    public function setReactor(float $reactor): void
    {
        $this->reactor = $reactor;
    }

    /**
     * Returns Engine.
     */
    public function getEngine(): float
    {
        return $this->engine;
    }

    /**
     * Sets Engine.
     *
     * @required
     * @maps engine
     */
    public function setEngine(float $engine): void
    {
        $this->engine = $engine;
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
        $json['frame']   = $this->frame;
        $json['reactor'] = $this->reactor;
        $json['engine']  = $this->engine;

        return (!$asArrayWhenEmpty && empty($json)) ? new stdClass() : $json;
    }
}