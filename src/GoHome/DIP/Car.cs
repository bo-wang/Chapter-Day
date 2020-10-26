using System;

namespace Chapter_Day.DIP
{
    public class Car:ICustomerTransportation
    {
        public Car()
        {
        }

        public void GoHome()
        {
            Console.WriteLine("************Go home by Car*************");
        }
    }
}
