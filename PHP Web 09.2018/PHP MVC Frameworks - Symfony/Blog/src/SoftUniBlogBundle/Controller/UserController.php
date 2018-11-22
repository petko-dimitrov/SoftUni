<?php

namespace SoftUniBlogBundle\Controller;

use SoftUniBlogBundle\Entity\Role;
use SoftUniBlogBundle\Entity\User;
use SoftUniBlogBundle\Form\UserType;
use Symfony\Bundle\FrameworkBundle\Controller\Controller;
use Symfony\Component\HttpFoundation\Request;
use Symfony\Component\HttpFoundation\Response;
use Symfony\Component\Routing\Annotation\Route;

class UserController extends Controller
{
    /**
     * @Route("register", name="user_register")
     * @param Request $request
     * @return \Symfony\Component\HttpFoundation\RedirectResponse|Response
     */
    public function registerAction(Request $request)
    {
        $user = new User();
        $form = $this->createForm(UserType::class, $user);
        $form->handleRequest($request);

        if ($form->isSubmitted()) {
            $email = $form->getData()->getEmail();
            $userToCheck = $this->getDoctrine()->getRepository(User::class)->findBy(['email' => $email]);

            if (null != $userToCheck) {
                $this->addFlash('message', "User with email $email is already registered!");
                return $this->render("user/register.html.twig");
            }

            if ($user->getPassword()['first'] !== $user->getPassword()['second']) {
                $this->addFlash('message', 'Passwords mismatch!');
                return $this->render("user/register.html.twig");
            }

            $password = $this->get('security.password_encoder')
                ->encodePassword($user, $user->getPassword()['first']);
            $user->setPassword($password);

            $roleRepository = $this->getDoctrine()->getRepository(Role::class);
            $userRole = $roleRepository->findOneBy(['name' => 'ROLE_USER']);
            $user->addRole($userRole);

            $em = $this->getDoctrine()->getManager();
            $em->persist($user);
            $em->flush();

            return $this->redirectToRoute("security_login");
        }

        return $this->render("user/register.html.twig");
    }

    /**
     * @Route("profile", name="user_profile")
     */
    public function profileAction(){
        $currentUser = $this->getUser();
        return $this->render('user/profile.html.twig', ['user' => $currentUser]);
    }
}
