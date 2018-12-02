<?php

namespace CarsBundle\Controller;

use CarsBundle\Entity\Supplier;
use Symfony\Bundle\FrameworkBundle\Controller\Controller;
use Symfony\Component\Routing\Annotation\Route;

class SupplierController extends Controller
{
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
}
