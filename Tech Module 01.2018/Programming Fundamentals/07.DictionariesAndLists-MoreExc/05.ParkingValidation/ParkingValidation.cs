using System;
using System.Collections.Generic;

namespace _05.ParkingValidation
{
    class ParkingValidation
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> cars = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];
                string user = input[1];

                if (command == "register")
                {
                    string plate = input[2];

                    if (cars.ContainsKey(user))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {cars[user]}");
                    }
                    else if (!CheckIfPlateIsValid(plate))
                    {
                        Console.WriteLine($"ERROR: invalid license plate {plate}");
                    }
                    else if (cars.ContainsValue(plate))
                    {
                        Console.WriteLine($"ERROR: license plate {plate} is busy");
                    }
                    else
                    {
                        cars.Add(user, plate);
                        Console.WriteLine($"{user} registered {plate} successfully");
                    }
                }

                else if (command == "unregister")
                {
                    if (!cars.ContainsKey(user))
                    {
                        Console.WriteLine($"ERROR: user {user} not found");
                    }
                    else
                    {
                        cars.Remove(user);
                        Console.WriteLine($"user {user} unregistered successfully");
                    }
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Key} => {car.Value}");
            }
        }

        static bool CheckIfPlateIsValid(string carPlate)
        {
            bool plateIsValid = true;
            if (carPlate.Length != 8)
            {
                plateIsValid = false;
                return plateIsValid;
            }
            for (int i = 0; i < 2; i++)
            {
                if (carPlate[i] < 65 || carPlate[i] > 90)
                {
                    plateIsValid = false;
                    return plateIsValid;
                }
            }
            for (int i = 7; i >= 6; i--)
            {
                if (carPlate[i] < 65 || carPlate[i] > 90)
                {
                    plateIsValid = false;
                    return plateIsValid;
                }
            }
            for (int i = 2; i <= 5; i++)
            {
                if (carPlate[i] < 48 || carPlate[i] > 57)
                {
                    plateIsValid = false;
                    return plateIsValid;
                }
            }
            return plateIsValid;
        }
    }
}
