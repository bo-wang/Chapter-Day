namespace Chapter_Day.Initial
{
    public class CustomerBusinessLogic
    {
        private readonly Car _car;

        public CustomerBusinessLogic()
        {
            _car = new Car();
        }

        public void GoHome()
        {
            _car.GoHome();
        }
    }
}
