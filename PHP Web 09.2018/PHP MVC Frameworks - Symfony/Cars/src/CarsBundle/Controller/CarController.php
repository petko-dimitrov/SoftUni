<?php

namespace CarsBundle\Controller;

use CarsBundle\Entity\Car;
use CarsBundle\Entity\Part;
use Symfony\Bundle\FrameworkBundle\Controller\Controller;
use Symfony\Component\HttpFoundation\Request;
use Symfony\Component\Routing\Annotation\Route;

class CarController extends Controller
{
    /**
     * @Route("/", name="homepage")
     */
    public function indexAction()
    {
        $car = new Car();

        return $this->render('default/index.html.twig',
            ['car' => $car]);
    }

    /**
     * @Route("cars/all", name="cars_all")
     */
    public function allCars()
    {
        $cars = $this->getDoctrine()
            ->getRepository(Car::class)
            ->findAll();

        return $this->render('default/cars.html.twig',
            ['cars' => $cars]);
    }

    /**
     * @Route("/cars", name="cars_from_make")
     * @return \Symfony\Component\HttpFoundation\Response
     */
    public function carsFromMake (Request $request)
    {
        $make = $request->request->get('make');
        $cars = $this
            ->getDoctrine()
            ->getRepository(Car::class)
            ->getCarsByMake($make);

        if(null == $cars){
            $this->addFlash('message', "There is no car with make $make!");
            return $this->render("default/index.html.twig");
        }

        return $this->render('default/cars.html.twig', ['cars' => $cars]);
    }


    /**
     * @Route("/cars/parts", name="car_with_parts")
     * @param int $id
     * @return \Symfony\Component\HttpFoundation\Response
     */
    public function carsWithListOfParts(Request $request)
    {
        $id = $request->request->get('car_id');

        /** @var Car $car */
        $car = $this
            ->getDoctrine()
            ->getRepository(Car::class)
            ->find($id);

        if (null === $car) {
            $this->addFlash('message', "There is no car with id $id!");
            return $this->render("default/index.html.twig");
        }

        $parts = $this->getDoctrine()
            ->getRepository(Part::class)
            ->getPartsByCar($car->getId());

        return $this->render('default/car-with-parts.html.twig',
            ['car' => $car, 'parts' => $parts]);
    }


}
