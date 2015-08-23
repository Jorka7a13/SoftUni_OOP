<?php

namespace HotelReservationSystem\Rooms;

use HotelReservationSystem;
use HotelReservationSystem\Enumerations;
use HotelReservationSystem\Reservation;
use HotelReservationSystem\Exceptions\EReservationException;

abstract class Room implements HotelReservationSystem\iReservable
{
    private $roomType;
    private $restroom;
    private $balcony;
    private $bedCount;
    private $roomNumber;
    private $extras = [];
    private $reservations = [];
    private $price;

    function __construct($roomType = Enumerations\RoomType::Standard,
                         $restroom = false,
                         $balcony = false,
                         $bedCount = 1,
                         $roomNumber = 1,
                         $extras = [],
                         $reservations = [],
                         $price = 1)
    {
        $this->setRoomType($roomType);
        $this->setRestroom($restroom);
        $this->setBalcony($balcony);
        $this->setBedCount($bedCount);
        $this->setRoomNumber($roomNumber);
        $this->setExtras($extras);
        $this->setReservations($reservations);
        $this->setPrice($price);
    }

    public function getRoomType()
    {
        return $this->roomType;
    }

    public function setRoomType($roomType)
    {
        if($roomType >= 0 || $roomType <= 2) {
            $this->roomType = $roomType;
        } else {
            throw new \InvalidArgumentException('Invalid room type!');
        }
    }

    public function hasRestroom()
    {
        return $this->restroom;
    }

    public function setRestroom($restroom)
    {
        if(is_bool($restroom)) {
            $this->restroom = $restroom;
        } else {
            throw new \InvalidArgumentException('Invalid restroom!');
        }
    }

    public function hasBalcony()
    {
        return $this->balcony;
    }

    public function setBalcony($balcony)
    {
        if(is_bool($balcony)) {
            $this->balcony = $balcony;
        } else {
            throw new \InvalidArgumentException('Invalid balcony!');
        }
    }

    public function getBedCount()
    {
        return $this->bedCount;
    }

    public function setBedCount($bedCount)
    {
        if($bedCount > 0) {
            $this->bedCount = $bedCount;
        } else {
            throw new \InvalidArgumentException('Bed count can\'t be negative!');
        }
    }

    public function getRoomNumber()
    {
        return $this->roomNumber;
    }

    public function setRoomNumber($roomNumber)
    {
        if($roomNumber > 0) {
            $this->roomNumber = $roomNumber;
        } else {
            throw new \InvalidArgumentException('Room number can\'t be negative!');
        }
    }

    public function getExtras()
    {
        return $this->extras;
    }

    public function setExtras($extras)
    {
        if(is_array($extras)) {
            $this->extras = $extras;
        } else {
            throw new \InvalidArgumentException('Extras must be an array!');
        }
    }

    public function getReservations()
    {
        return $this->reservations;
    }

    public function setReservations($reservations)
    {
        if(is_array($reservations)) {
            $this->reservations = $reservations;
        } else {
            throw new \InvalidArgumentException('Reservations must be an array!');
        }
    }

    public function getPrice()
    {
        return $this->price;
    }

    public function setPrice($price)
    {
        if($price > 0) {
            $this->price = $price;
        } else {
            throw new \InvalidArgumentException('Price can\'t be negative!');
        }
    }

    function __toString()
    {
        return 'Room ' . $this->getRoomNumber() . "\r\n" . 'Room type: ' . $this->getRoomType() . "\r\n" .
            'Bed count: ' . $this->getBedCount() . "\r\n" . 'Restroom: ' . $this->hasRestroom() . "\r\n" .
            'Balcony: ' . $this->hasBalcony()  . "\r\n" . 'Extras: ' . implode(', ', $this->getExtras()) . "\r\n" .
            'Price: ' . $this->getPrice() . "\r\n" . 'Reservations: ' . implode(', ', $this->getReservations());
    }

    public function addReservation($reservation)
    {
        $this->checkReservation($reservation);
        $this->$reservations = $reservation;
    }

    public function removeReservation($reservation)
    {
        $array = $this->getReservations();

        if(($key = array_search($reservation, $array, true)) !== FALSE) {
            unset($array[$key]);
        }
    }

    private function checkReservation(Reservation $reservation)
    {
        foreach ($this->getReservations() as $currentReservation) {
            if (($reservation->getStartDate() >=  $currentReservation->getStartDate()  &&
                $reservation->getStartDate() <=  $currentReservation->getEndDate())) {
                    throw new EReservationException($this->roomNumber);
            } else if (($reservation->getEndDate() >=  $currentReservation->getStartDate()  &&
                $reservation->getEndDate()  <=   $currentReservation->getEndDate())) {
                    throw new EReservationException($this->roomNumber);
            }
        }
    }
}