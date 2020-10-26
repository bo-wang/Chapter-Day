namespace Chapter_Day.DIP
{
    public class TransportationFactory
    {
        public static ICustomerTransportation GetCarObj()
        {
            return new Car();
        }

        public static ICustomerTransportation GetByBicycleObj()
        {
            return new Bicycle();
        }
    }
}
