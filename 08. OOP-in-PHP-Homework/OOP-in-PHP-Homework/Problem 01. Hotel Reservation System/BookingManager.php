<?php

namespace HotelReservationSystem;

use HotelReservationSystem\Rooms\Room;

class BookingManager
{
    public static function bookRoom(Room $room, Reservation $reservation)
    {
        $room->addReservation($reservation);

        echo "\nRoom <strong>" . $room->getRoomNumber() . "</strong>\n" .
            "successfully booked for\n" .
            "<strong>" . $reservation->getGuest()->getFirstName() . " " . $reservation->getGuest()->getLastName() .  "</strong>\n".
            "from <time>" . $reservation->getStartDate() . "</time> to\n".
            "<time>" . $reservation->getEndDate() . "</time>!\n";
    }
}