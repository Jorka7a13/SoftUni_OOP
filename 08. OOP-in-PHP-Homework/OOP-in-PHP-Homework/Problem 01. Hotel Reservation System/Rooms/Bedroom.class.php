<?php

namespace HotelReservationSystem\Rooms;

use HotelReservationSystem\Enumerations\RoomType;

class Bedroom extends Room
{
    public function __construct($roomNumber, $price) {
        parent::__construct(RoomType::Gold, true, true, 2,
            ['TV', 'Air-conditioner', 'refrigerator', 'mini-bar', 'bathtub'], $roomNumber, $price);
    }
}