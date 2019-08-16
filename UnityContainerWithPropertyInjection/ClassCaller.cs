using System;
using Unity;
using Unity.Injection;

namespace UnityContainerWithPropertyInjection
{
    public class ClassCaller
    {
        public static void Main(string[] args)
        {
            var firstContainer = new UnityContainer();
            firstContainer.RegisterType<ICar, BMW>("LuxuryCar");
            
            var firstDriverObject = firstContainer.Resolve<Driver>();
            firstDriverObject.RunCar();

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("*** Runtime Configuration ***");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            var secondContainer = new UnityContainer();
            //run-time configuration
            secondContainer.RegisterType<Driver>(new InjectionProperty("Car", new Audi()));

            var secondDriverObject = secondContainer.Resolve<Driver>();
            secondDriverObject.RunCar();

            Console.ReadLine();
        }
    }
}
