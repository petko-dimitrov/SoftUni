using System;

namespace _11.PriceChangeAlert
{
    class PriceChangeAlert
    {
        static void Main()
        {
            int numberOfPrices = int.Parse(Console.ReadLine());
            double significanceThreshold = double.Parse(Console.ReadLine());
            double lastPrice = double.Parse(Console.ReadLine());
            significanceThreshold *= 100; 

            for (int i = 0; i < numberOfPrices - 1; i++)
            {
                double currentPrice = double.Parse(Console.ReadLine());
                double percentageDifference = GetPercentageDifference(lastPrice, currentPrice);
                bool isSignificantDifference = IsThereADifference(percentageDifference, significanceThreshold);
                string priceChangeMessage = GetPriceChange(currentPrice, lastPrice, percentageDifference, isSignificantDifference);
                Console.WriteLine(priceChangeMessage);
                lastPrice = currentPrice;
            }
        }
        static string GetPriceChange(double firstPrice, double secondPrice, double priceChange, bool isSignificantDifference)
        {
            string priceChangeMessage = "";
            if (priceChange == 0)
            {
                priceChangeMessage = string.Format("NO CHANGE: {0}", firstPrice);
            }
            else if (!isSignificantDifference)
            {
                priceChangeMessage = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", secondPrice, firstPrice, priceChange);
            }
            else if (isSignificantDifference && priceChange > 0)
            {
                priceChangeMessage = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", secondPrice, firstPrice, priceChange);
            }
            else if (isSignificantDifference && priceChange < 0)
            {
                priceChangeMessage = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", secondPrice, firstPrice, priceChange);
            }
            return priceChangeMessage;
        }

        static bool IsThereADifference(double treshold, double significanceThreshold)
        {
            if (Math.Abs(treshold) >= significanceThreshold)
            {
                return true;
            }
            return false;
        }

        static double GetPercentageDifference(double firstPrice, double secondPrice)
        {
            double percentageDifference = (secondPrice - firstPrice) / firstPrice * 100;
            return percentageDifference;
        }
    }
}
