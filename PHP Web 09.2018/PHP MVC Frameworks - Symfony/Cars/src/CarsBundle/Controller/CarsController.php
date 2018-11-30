<?php

namespace CarsBundle\Controller;

use CarsBundle\Entity\Car;
use CarsBundle\Entity\Customer;
use CarsBundle\Entity\Part;
use CarsBundle\Entity\Supplier;
use Symfony\Bundle\FrameworkBundle\Controller\Controller;
use Symfony\Component\HttpFoundation\Request;
use Symfony\Component\Routing\Annotation\Route;

class CarsController extends Controller
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
     * @Route("/customers/all/ascending", name="customers_asc")
     */
    public function orderedCustomersAsc ()
    {
        $customers = $this->getDoctrine()
            ->getRepository(Customer::class)
            ->getAllCustomers('ASC');

        return $this->render('default/customer.html.twig', ['customers' => $customers]);
    }

    /**
     * @Route("/customers/all/descending", name="customers_desc")
     */
    public function orderedCustomersDesc ()
    {
        $customers = $this->getDoctrine()
            ->getRepository(Customer::class)
            ->getAllCustomers('DESC');

        return $this->render('default/customer.html.twig', ['customers' => $customers]);
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
     * @Route("/suppliers/local", name="suppliers_local")
     */
    public function localSuppliers ()
    {
        $suppliers = $this->getDoctrine()
            ->getRepository(Supplier::class)
            ->getAllSuppliers(0);

        return $this->render('default/suppliers.html.twig', ['suppliers' => $suppliers]);
    }

    /**
     * @Route("/suppliers/importers", name="suppliers_importers")
     */
    public function importerSuppliers ()
    {
        $suppliers = $this->getDoctrine()
            ->getRepository(Supplier::class)
            ->getAllSuppliers(1);

        return $this->render('default/suppliers.html.twig', ['suppliers' => $suppliers]);
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
