<?php

namespace Core;


class Template implements TemplateInterface
{
    const TEMPLATE_DIRECTORY = 'MyMoney/Templates/';
    const TEMPLATE_EXTENSION = '.php';

    public function render($templateName, $data = null, array $errors = [])
    {
        require_once self::TEMPLATE_DIRECTORY . $templateName . self::TEMPLATE_EXTENSION;
    }
}