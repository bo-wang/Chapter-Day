namespace Chapter_Day.AutoFac
{
    public class CustomerBusinessLogic
    {
        private readonly ICustomerTransportation _customerTransportation;

        public CustomerBusinessLogic(ICustomerTransportation customerTransportation)
        {
            _customerTransportation = customerTransportation;
        }

        public void GoHome()
        {
            _customerTransportation.GoHome();
        }
    }
}
