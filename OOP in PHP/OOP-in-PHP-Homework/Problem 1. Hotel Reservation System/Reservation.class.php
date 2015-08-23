<?php

namespace HotelReservationSystem;

class Reservation
{
    private $startDate ;
    private $endDate;
    private $guest;

    public function __construct($startDate, $endDate, $guest)
    {
        $this->setStartDate($startDate);
        $this->setEndDate($endDate);
        $this->setGuest($guest);
    }

    public function getStartDate()
    {
        return $this->startDate;
    }

    public function setStartDate($newStartDate)
    {
        if($newStartDate !== '') {
            $this->startDate = $newStartDate;
        } else {
            throw new \InvalidArgumentException("Start date can't be empty!");
        }
    }

    public function getEndDate()
    {
        return $this->endDate;
    }

    public function setEndDate($newEndDate)
    {
        if($newEndDate !== '') {
            $this->endDate = $newEndDate;
        } else {
            throw new \InvalidArgumentException("End date can't be empty!");
        }
    }

    public function getGuest()
    {
        return $this->guest;
    }

    public function setGuest($newGuest)
    {
        if(!is_null($newGuest)) {
            $this->guest = $newGuest;
        } else {
            throw new \InvalidArgumentException("Guest can't be null!");
        }
    }

    public function __toString()
    {
        return 'Reservation: from ' . $this->getStartDate() . ' to ' . $this->getEndDate() .
        ', on the name of ' . $this->getGuest();
    }
}