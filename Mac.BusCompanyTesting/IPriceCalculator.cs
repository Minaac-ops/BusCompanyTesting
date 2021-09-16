namespace Mac.BusCompanyTesting
{
    public interface IPriceCalculator
    {
        double TotalCost(int noOfPassengers, int kilometer);
    }
}