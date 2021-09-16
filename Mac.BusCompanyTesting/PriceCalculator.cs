using System.Runtime.CompilerServices;

namespace Mac.BusCompanyTesting
{
    public class PriceCalculator : IPriceCalculator
    {
        public double TotalCost(int noOfPassengers, int kilometer)
        {
            double initialFee = 130;
            double priceCalculator = 0;
            
            if (kilometer is <= 100 and > 0)
            {
                priceCalculator = 3.20 * kilometer;
            }
            else if (noOfPassengers < 12 && kilometer is > 100 and < 500)
            {
                double firstHundred = 100 * 3.20;
                priceCalculator = ((kilometer - 100) * 2.75) + firstHundred;
            }
            else if (noOfPassengers > 12 && kilometer is > 100 and < 500)
            {
                double firstHundred = 100 * 3.20;
                priceCalculator = ((kilometer - 100) * 3.00) + firstHundred;
            }
            else if (kilometer > 500)
            {
                priceCalculator = kilometer * 2.25;
            }
            double totalCost = initialFee + priceCalculator;
            return totalCost;
        }
    }
}