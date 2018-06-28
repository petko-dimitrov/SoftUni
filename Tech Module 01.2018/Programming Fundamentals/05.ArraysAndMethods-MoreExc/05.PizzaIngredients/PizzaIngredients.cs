using System;
using System.Linq;

namespace _05.PizzaIngredients
{
    class PizzaIngredients
    {
        static void Main(string[] args)
        {
            string[] ingredients = Console.ReadLine().Split(' ');
            int length = int.Parse(Console.ReadLine());
            int counter = 0;
            string usedIngredients = ""; 

            for (int i = 0; i < ingredients.Length; i++)
            {
                if (counter >= 10)
                {
                    break;
                }
                if (ingredients[i].Length == length)
                {
                    Console.WriteLine($"Adding {ingredients[i]}.");
                    counter++;
                    usedIngredients += ingredients[i] + " ";   
                }
            }

            string[] usedIngr = usedIngredients.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            Console.WriteLine($"Made pizza with total of {counter} ingredients.");
            Console.WriteLine("The ingredients are: {0}.", string.Join(", ", usedIngr));

        }
    }
}
