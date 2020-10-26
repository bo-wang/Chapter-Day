namespace Chapter_Day.IoC
{
    public class TransportationFactory
    {
        public static Car GetCarObj()
        {
            return new Car();
        }

        public static Bicycle GetByBicycleObj()
        {
            return new Bicycle();
        }
    }
}
