using System;
using Unity;
using Unity.Injection;

namespace UnityContainerWithMethodInjection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var firstContainer = new UnityContainer();
            firstContainer.RegisterType<ICar, BMW>();
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
            secondContainer.RegisterType<Driver>(new InjectionMethod("UseCar", new object[] { new Audi() }));
            var secondDriverObject = secondContainer.Resolve<Driver>();
            secondDriverObject.RunCar();

            Console.ReadLine();
        }
    }
}
