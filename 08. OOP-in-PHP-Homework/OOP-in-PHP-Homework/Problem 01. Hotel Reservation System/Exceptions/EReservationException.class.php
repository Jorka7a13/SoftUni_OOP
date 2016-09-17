<?php

namespace HotelReservationSystem\Exceptions;

class EReservationException extends \Exception
{
    public function __construct($roomNumber, $code = 0)
    {
        parent::__construct("Room $roomNumber is already occupied for that time period!");
    }
}