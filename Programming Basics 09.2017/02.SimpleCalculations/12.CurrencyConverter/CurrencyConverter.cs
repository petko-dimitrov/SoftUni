using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class CurrencyConverter
    {
        static void Main(string[] args)
        {
            var sum = double.Parse(Console.ReadLine());
            var fromCurrency = Console.ReadLine();
            var toCurrency = Console.ReadLine();
            double result = 0;
            double usdRate = 1.79549;
            double eurRate = 1.95583;
            double gbpRate = 2.53405;

            switch (fromCurrency)
            {
                case "BGN":
                    switch (toCurrency)
                    {
                        case "USD":
                            result = sum / usdRate;
                            Console.WriteLine(Math.Round(result, 2) + " USD");
                            break;
                        case "EUR":
                            result = sum / eurRate;
                            Console.WriteLine(Math.Round(result, 2) + " EUR");
                            break;
                        case "GBP":
                            result = sum / gbpRate;
                            Console.WriteLine(Math.Round(result, 2) + " GBP");
                            break;
                        default:
                            break;
                    }                
                    break;
                case "USD":
                    switch (toCurrency)
                    {
                        case "BGN":
                            result = sum * usdRate;
                            Console.WriteLine(Math.Round(result, 2) + " BGN");
                            break;
                        case "EUR":
                            result = sum * usdRate / eurRate;
                            Console.WriteLine(Math.Round(result, 2) + " EUR");
                            break;
                        case "GBP":
                            result = sum * usdRate / gbpRate;
                            Console.WriteLine(Math.Round(result, 2) + " GBP");
                            break;                       
                        default:
                            break;
                    }
                    break;
                case "EUR":
                    switch (toCurrency)
                    {
                        case "BGN":
                            result = sum * eurRate;
                            Console.WriteLine(Math.Round(result, 2) + " BGN");
                            break;
                        case "USD":
                            result = sum * eurRate / usdRate;
                            Console.WriteLine(Math.Round(result, 2) + " USD");
                            break;
                        case "GBP":
                            result = sum * eurRate / gbpRate;
                            Console.WriteLine(Math.Round(result, 2) + " GBP");
                            break;
                        default:
                            break;
                    }
                    break;
                case "GBP":
                    switch (toCurrency)
                    {
                        case "BGN":
                            result = sum * gbpRate;
                            Console.WriteLine(Math.Round(result, 2) + " BGN");
                            break;
                        case "USD":
                            result = sum * gbpRate / usdRate;
                            Console.WriteLine(Math.Round(result, 2) + " USD");
                            break;
                        case "EUR":
                            result = sum * gbpRate / eurRate;
                            Console.WriteLine(Math.Round(result, 2) + " EUR");
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}