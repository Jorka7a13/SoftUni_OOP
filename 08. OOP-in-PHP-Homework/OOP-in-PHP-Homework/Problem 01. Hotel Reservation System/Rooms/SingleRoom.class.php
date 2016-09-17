<?php

namespace HotelReservationSystem\Rooms;

use HotelReservationSystem\Enumerations\RoomType;

class SingleRoom extends Room
{
    public function __construct($roomNumber, $price) {
        parent::__construct(RoomType::Standard, true, false, 1, ['TV', 'Air-conditioner'], $roomNumber, $price);
    }
}