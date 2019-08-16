using System;
using Unity;
using Unity.Injection; 
using Unity.Resolution;

namespace OverridesInUnityContainer
{
    public class ClassCaller
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("*** Class ParameterOverride ***");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");


            var container = new UnityContainer()
                .RegisterType<ICar, BMW>();

            var driver1 = container.Resolve<Driver>(); // Injects registered ICar type
            driver1.RunCar();


            Console.WriteLine("after the override..");

            //Overrides the registered ICar type
            var driver2 = container.Resolve<Driver>(new ParameterOverride("car", new Ford()));
            driver2.RunCar();

            // Override Multiple Parameters

            //Console.WriteLine("after multiple override...");

            //var driver2 = container.Resolve<Driver>(new ResolverOverride[] {
            //                                                new ParameterOverride("car1", new Ford()),
            //                                                new ParameterOverride("car2", new BMW()),
            //                                                new ParameterOverride("car3", new Audi())
            //                                        });
            //driver2.RunCar();


            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("*** Property Injection And Then Use Class PropertyOverride ***");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            var secondContainer = new UnityContainer();
            secondContainer.RegisterType<DriverClassForPropInj>(new InjectionProperty("Car", new BMW()));
            var secondDriverObject = container.Resolve<DriverClassForPropInj>();
            secondDriverObject.RunCar();

            Console.WriteLine("after the override..");

            //Override the default value of the Car property
            var drv = container.Resolve<DriverClassForPropInj>(
                new PropertyOverride("Car", new Audi()
            ));

            drv.RunCar();

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("*** Method Injection && Class Dependency Override ***");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            var thirdContainer = new UnityContainer().RegisterType<ICar, BMW>();
            var thirdDriverObject = thirdContainer.Resolve<DriverForMetInj>();
            thirdDriverObject.RunCar();


            Console.WriteLine("after the override..");

            //you can override a registered method injection and a provide different parameter  value when you resolve it. 
            //Override the dependency with different object and same unity container object.  
            var drv_2 = thirdContainer.Resolve<DriverForMetInj>(new DependencyOverride<ICar>(new Audi()));
            drv_2.RunCar();

            Console.ReadLine();
        }
    }
}
