<?php

namespace CarsBundle\Controller;

use CarsBundle\Entity\Part;
use CarsBundle\Entity\Sale;
use Symfony\Bundle\FrameworkBundle\Controller\Controller;
use Symfony\Component\HttpFoundation\Request;
use Symfony\Component\Routing\Annotation\Route;

class SaleController extends Controller
{
    /**
     * @Route("/customers", name="sales_by_customer")
     * @param int $id
     * @return \Symfony\Component\HttpFoundation\Response
     */
    public function salesByCustomer(Request $request)
    {
        $id = $request->request->get('customer_id');

        $customer = $this->getDoctrine()
            ->getRepository(Sale::class)
            ->getTotalSalesByCustomer($id);

        if (null == $customer) {
            $this->addFlash('message', "There is no customer with id $id!");
            return $this->render("default/index.html.twig");
        }

        $cars = $this->getDoctrine()
            ->getRepository(Sale::class)
            ->getAllSalesByCustomer($id);

        $totalParts = [];

        foreach ($cars as $car) {
            $parts = $this->getDoctrine()
                ->getRepository(Part::class)
                ->getSumOfPartsByCar($car['id']);

            $totalParts[] = $parts;
        }

        $totalSum = 0;

        for ($i = 0; $i < count($totalParts); $i++){
            $totalSum += floatval($totalParts[$i][0]['total_price']);
        }

        return $this->render('default/sales-by-customer.html.twig',
            ['customer' => $customer, 'totalSum' => $totalSum]);
    }

    /**
     * @Route("sales", name="sales_all")
     */
    public function allSales()
    {
        $sales = $this->getDoctrine()
            ->getRepository(Sale::class)
            ->getAllSales();

        return $this->render('default/sales.html.twig',
            ['sales' => $sales]);
    }

    /**
     * @Route("sales/one", name="sales_one")
     * @param Request $request
     * @return \Symfony\Component\HttpFoundation\Response
     */
    public function allSalesById(Request $request)
    {
        $id = $request->request->get('sale_id');

        $sales = $this->getDoctrine()
            ->getRepository(Sale::class)
            ->getAllSalesById($id);

        if (null == $sales) {
            $this->addFlash('message', "There is no sale with id $id!");
            return $this->render("default/index.html.twig");
        }

        return $this->render('default/sales.html.twig',
            ['sales' => $sales]);
    }

    /**
     * @Route("sales/discounted", name="sales_discounted")
     */
    public function discountedSales()
    {
        $sales = $this->getDoctrine()
            ->getRepository(Sale::class)
            ->getDiscountedSales();

        return $this->render('default/sales.html.twig',
            ['sales' => $sales]);
    }

    /**
     * @Route("sales/discounted-by-percent", name="sales_discounted_percent")
     */
    public function discountedSalesByPercent(Request $request)
    {
        $percent = floatval($request->request->get('percent'));
        $percent /= 100;

        $sales = $this->getDoctrine()
            ->getRepository(Sale::class)
            ->getDiscountedSalesByPercent($percent);

        return $this->render('default/sales.html.twig',
            ['sales' => $sales]);
    }
}
