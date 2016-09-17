<?php

namespace HotelReservationSystem\Rooms;

use HotelReservationSystem\Enumerations\RoomType;

class Apartment extends Room
{
    public function __construct($roomNumber, $price) {
        parent::__construct(RoomType::Diamond, true, true, 4,
            ['TV', 'Air-conditioner', 'refrigerator', 'kitchen box','mini-bar', 'bathtub', 'free Wi-Fi'],
            $roomNumber, $price);
    }
}