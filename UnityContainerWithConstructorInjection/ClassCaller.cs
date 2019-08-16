using System;
using Unity;
using Unity.Injection;
using UnityContainerWithConstructorInjection;

namespace UnityWithConstructorInjection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var container = new UnityContainer();
            //container.RegisterType<ICar, Audi>();
            //container.RegisterType<ICarKey, AudiKey>();

            ////resolve namely inject object to the dependent class 
            //var driver = container.Resolve<Driver>();
            //driver.RunCar();

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("*** Runtime Configuration ***");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            //var runTimeContainer = new UnityContainer();
            //runTimeContainer.RegisterType<ICar, Ford>();
            //runTimeContainer.RegisterType<ICarKey, FordKey>();
            //runTimeContainer.RegisterType<Driver>(new InjectionConstructor(new object[] { runTimeContainer.Resolve<ICar>(), runTimeContainer.Resolve<ICarKey>() }));
            //var driverObject = runTimeContainer.Resolve<Driver>();
            //driverObject.RunCar();

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("*** Configuration With Primitive Configuration ***");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            var finalContainer = new UnityContainer();
            finalContainer.RegisterType<ICar, Ford>();
            finalContainer.RegisterType<ICarKey, FordKey>();
            finalContainer.RegisterType<Driver>(new InjectionConstructor(new object[] { finalContainer.Resolve<ICar>(), finalContainer.Resolve<ICarKey>(), "Steve" }));
            var thirdObject = finalContainer.Resolve<Driver>();
            thirdObject.RunCar();


            Console.ReadLine();
        }
    }
}
