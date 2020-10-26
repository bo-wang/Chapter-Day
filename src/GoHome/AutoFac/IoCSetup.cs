using Autofac;

namespace Chapter_Day.AutoFac
{
    public class IoCSetup
    {
        public static IContainer Configure()
        {
            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterType<Car>().As<ICustomerTransportation>();
            return containerBuilder.Build();
        }
    }
}
