using System;

namespace _10.CubeProperties
{
    class CubeProperties
    {
        static void Main(string[] args)
        {
            double cubeSide = double.Parse(Console.ReadLine());
            string parameterToCalculate = Console.ReadLine().ToLower();

            switch (parameterToCalculate)
            {
                case "face":
                    double cubeFaceDiagonal = CalculateCubeFaceDiagonals(cubeSide);
                    Console.WriteLine($"{cubeFaceDiagonal:f2}");
                    break;
                case "space":
                    double cubeSpaceDiagonal = CalculateCubeSpaceDiagonals(cubeSide);
                    Console.WriteLine($"{cubeSpaceDiagonal:f2}");
                    break;
                case "volume":
                    double cubeVolume = CalculateCubeVolume(cubeSide);
                    Console.WriteLine($"{cubeVolume:f2}");
                    break;
                case "area":
                    double cubeArea = CalculateCubeArea(cubeSide);
                    Console.WriteLine($"{cubeArea:f2}");
                    break;
                default:
                    break;
            }
        }

        static double CalculateCubeArea(double cubeSide)
        {
            double area = 6 * cubeSide * cubeSide;
            return area;
        }

        static double CalculateCubeVolume(double cubeSide)
        {
            double volume = Math.Pow(cubeSide, 3);
            return volume;
        }

        static double CalculateCubeSpaceDiagonals(double cubeSide)
        {
            double spaceDiagonal = Math.Sqrt(3 * cubeSide * cubeSide);
            return spaceDiagonal;
        }

        static double CalculateCubeFaceDiagonals(double cubeSide)
        {
            double faceDiagonal = Math.Sqrt(2 * cubeSide * cubeSide);
            return faceDiagonal;
        }
    }
}
