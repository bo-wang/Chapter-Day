using System;
using Autofac;
using Chapter_Day.AutoFac;

namespace Chapter_Day
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Initial
            //Console.WriteLine("I want to go home");
            //new Initial.CustomerBusinessLogic().GoHome();

            ////IoC
            //Console.WriteLine("I want to go home");
            //new IoC.CustomerBusinessLogic().GoHome();

            ////DIP
            //Console.WriteLine("I want to go home");
            //new DIP.CustomerBusinessLogic().GoHome();

            ////DependencyInjection
            //Console.WriteLine("I want to go home");
            //new DependencyInjection.CustomerBusinessLogic(new DependencyInjection.Bicycle()).GoHome();

            //AutoFac
            Console.WriteLine("I want to go home");
            var container = IoCSetup.Configure();
            var customerTransportation = container.Resolve<ICustomerTransportation>();
            customerTransportation.GoHome();
        }
    }
}
