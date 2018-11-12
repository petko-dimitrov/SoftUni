<?php

namespace Core;

class DataBinder implements DataBinderInterface
{

    public function bind(array $form, $className)
    {
        $classInfo = new \ReflectionClass($className);
        $object = new $className;

        foreach ($form as $key => $value) {
            if ($classInfo->hasProperty($key)) {
                $setter = 'set' . ucfirst($key);

                if (method_exists($object, $setter)) {
                    $object->$setter($value);
                }
            }
        }

        return $object;
    }
}