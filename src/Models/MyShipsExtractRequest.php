<?php

declare(strict_types=1);

/*
 * SpaceTradersAPILib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace SpaceTradersAPILib\Models;

use stdClass;

class MyShipsExtractRequest implements \JsonSerializable
{
    /**
     * @var Survey|null
     */
    private $survey;

    /**
     * Returns Survey.
     */
    public function getSurvey(): ?Survey
    {
        return $this->survey;
    }

    /**
     * Sets Survey.
     *
     * @maps survey
     */
    public function setSurvey(?Survey $survey): void
    {
        $this->survey = $survey;
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
        if (isset($this->survey)) {
            $json['survey'] = $this->survey;
        }

        return (!$asArrayWhenEmpty && empty($json)) ? new stdClass() : $json;
    }
}
