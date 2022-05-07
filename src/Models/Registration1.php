<?php

declare(strict_types=1);

/*
 * SpaceTradersAPILib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace SpaceTradersAPILib\Models;

use stdClass;

class Registration1 implements \JsonSerializable
{
    /**
     * @var string
     */
    private $factionSymbol;

    /**
     * @var string
     */
    private $agentSymbol;

    /**
     * @var int
     */
    private $fee;

    /**
     * @var string
     */
    private $role;

    /**
     * @param string $factionSymbol
     * @param string $agentSymbol
     * @param int $fee
     * @param string $role
     */
    public function __construct(string $factionSymbol, string $agentSymbol, int $fee, string $role)
    {
        $this->factionSymbol = $factionSymbol;
        $this->agentSymbol = $agentSymbol;
        $this->fee = $fee;
        $this->role = $role;
    }

    /**
     * Returns Faction Symbol.
     */
    public function getFactionSymbol(): string
    {
        return $this->factionSymbol;
    }

    /**
     * Sets Faction Symbol.
     *
     * @required
     * @maps factionSymbol
     */
    public function setFactionSymbol(string $factionSymbol): void
    {
        $this->factionSymbol = $factionSymbol;
    }

    /**
     * Returns Agent Symbol.
     */
    public function getAgentSymbol(): string
    {
        return $this->agentSymbol;
    }

    /**
     * Sets Agent Symbol.
     *
     * @required
     * @maps agentSymbol
     */
    public function setAgentSymbol(string $agentSymbol): void
    {
        $this->agentSymbol = $agentSymbol;
    }

    /**
     * Returns Fee.
     */
    public function getFee(): int
    {
        return $this->fee;
    }

    /**
     * Sets Fee.
     *
     * @required
     * @maps fee
     */
    public function setFee(int $fee): void
    {
        $this->fee = $fee;
    }

    /**
     * Returns Role.
     */
    public function getRole(): string
    {
        return $this->role;
    }

    /**
     * Sets Role.
     *
     * @required
     * @maps role
     */
    public function setRole(string $role): void
    {
        $this->role = $role;
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
        $json['factionSymbol'] = $this->factionSymbol;
        $json['agentSymbol']   = $this->agentSymbol;
        $json['fee']           = $this->fee;
        $json['role']          = $this->role;

        return (!$asArrayWhenEmpty && empty($json)) ? new stdClass() : $json;
    }
}
