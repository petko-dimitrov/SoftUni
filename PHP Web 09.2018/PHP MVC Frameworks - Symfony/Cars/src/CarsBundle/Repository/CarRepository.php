<?php

namespace CarsBundle\Repository;

/**
 * CarRepository
 *
 * This class was generated by the Doctrine ORM. Add your own custom
 * repository methods below.
 */
class CarRepository extends \Doctrine\ORM\EntityRepository
{
    public function getCarsByMake($make)
    {
        return $this->createQueryBuilder('car')
            ->where('car.make = :make')
            ->setParameter('make', $make)
            ->orderBy('car.model')
            ->addOrderBy('car.travelledDistance', 'DESC')
            ->getQuery()
            ->getResult();
    }
}
