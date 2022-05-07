<?php

declare(strict_types=1);

/*
 * SpaceTradersAPILib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace SpaceTradersAPILib\Models;

use stdClass;

class Terms implements \JsonSerializable
{
    /**
     * @var string
     */
    private $deadline;

    /**
     * @var Payment
     */
    private $payment;

    /**
     * @var Deliver[]
     */
    private $deliver;

    /**
     * @param string $deadline
     * @param Payment $payment
     * @param Deliver[] $deliver
     */
    public function __construct(string $deadline, Payment $payment, array $deliver)
    {
        $this->deadline = $deadline;
        $this->payment = $payment;
        $this->deliver = $deliver;
    }

    /**
     * Returns Deadline.
     */
    public function getDeadline(): string
    {
        return $this->deadline;
    }

    /**
     * Sets Deadline.
     *
     * @required
     * @maps deadline
     */
    public function setDeadline(string $deadline): void
    {
        $this->deadline = $deadline;
    }

    /**
     * Returns Payment.
     */
    public function getPayment(): Payment
    {
        return $this->payment;
    }

    /**
     * Sets Payment.
     *
     * @required
     * @maps payment
     */
    public function setPayment(Payment $payment): void
    {
        $this->payment = $payment;
    }

    /**
     * Returns Deliver.
     *
     * @return Deliver[]
     */
    public function getDeliver(): array
    {
        return $this->deliver;
    }

    /**
     * Sets Deliver.
     *
     * @required
     * @maps deliver
     *
     * @param Deliver[] $deliver
     */
    public function setDeliver(array $deliver): void
    {
        $this->deliver = $deliver;
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
        $json['deadline'] = $this->deadline;
        $json['payment']  = $this->payment;
        $json['deliver']  = $this->deliver;

        return (!$asArrayWhenEmpty && empty($json)) ? new stdClass() : $json;
    }
}