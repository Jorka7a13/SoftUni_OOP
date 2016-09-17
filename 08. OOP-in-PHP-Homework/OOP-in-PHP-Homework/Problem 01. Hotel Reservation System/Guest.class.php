<?php

namespace HotelReservationSystem;

class Guest
{
    private $firstName;
    private $lastName;
    private $id;

    public function __construct($firstName, $lastName, $id)
    {
        $this->setFirstName($firstName);
        $this->setLastName($lastName);
        $this->setID($id);
    }

    public function getFirstName()
    {
        return $this->firstName;
    }

    public function setFirstName($newFirstName)
    {
        if($newFirstName !== '') {
            $this->firstName = $newFirstName;
        } else {
            throw new \InvalidArgumentException('First name can\'t be empty!');
        }
    }

    public function getLastName()
    {
        return $this->lastName;
    }

    public function setLastName($newLastName)
    {
        if($newLastName !== '') {
            $this->lastName = $newLastName;
        } else {
            throw new \InvalidArgumentException('Last name can\'t be empty!');
        }
    }

    public function getID()
    {
        return $this->id;
    }

    public function setID($newID)
    {
        if($newID > 0) {
            $this->id = $newID;
        } else {
            throw new \InvalidArgumentException('ID can\'t be negative or zero!');
        }
    }

    public function __toString()
    {
        return $this->getFirstName() . ' ' . $this->getLastName() . ', ID:' . $this->getID();
    }
}