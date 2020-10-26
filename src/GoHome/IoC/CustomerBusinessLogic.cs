namespace Chapter_Day.IoC
{
    public class CustomerBusinessLogic
    {
        private readonly Car _car;

        public CustomerBusinessLogic()
        {
            _car = TransportationFactory.GetCarObj();
        }

        public void GoHome()
        {
            _car.GoHome();
        }
    }
}
