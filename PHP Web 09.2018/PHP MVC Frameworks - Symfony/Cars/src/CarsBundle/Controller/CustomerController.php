<?php

namespace CarsBundle\Controller;

use CarsBundle\Entity\Customer;
use Symfony\Bundle\FrameworkBundle\Controller\Controller;
use Symfony\Component\Routing\Annotation\Route;

class CustomerController extends Controller
{
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
}
