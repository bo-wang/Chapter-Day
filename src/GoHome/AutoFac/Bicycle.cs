using System;

namespace Chapter_Day.AutoFac
{
    public class Bicycle:ICustomerTransportation
    {
        public Bicycle()
        {
        }

        public void GoHome()
        {
            Console.WriteLine("************Go home by Bicycle*************");
        }
    }
}
