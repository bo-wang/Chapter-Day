namespace Chapter_Day.DIP
{
    public class CustomerBusinessLogic
    {
        private readonly ICustomerTransportation _customerTransportation;

        public CustomerBusinessLogic()
        {
            _customerTransportation = TransportationFactory.GetCarObj();
        }

        public void GoHome()
        {
            _customerTransportation.GoHome();
        }
    }
}
