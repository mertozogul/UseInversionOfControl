using System;
using Unity;
using Unity.Lifetime;

namespace LifetimeManagersInUnityContainer
{
    public class ClassCaller
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Lifetime Managers In Unity Container...");


            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("*** TransientLifetimeManager ***");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            //if you dont specified lifetime manager with registertype method and then TransientLifetimeManager manager will be deafult manager. 
            var container = new UnityContainer()
                   .RegisterType<ICar, BMW>(new TransientLifetimeManager());

            var driver1 = container.Resolve<Driver>();
            driver1.RunCar();

            var driver2 = container.Resolve<Driver>();
            driver2.RunCar();

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("*** ContainerControlledLifetimeManager ***");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            var secondContainer = new UnityContainer()
                   .RegisterType<ICar, BMW>(new ContainerControlledLifetimeManager());

            var secondDriver1 = secondContainer.Resolve<Driver>();
            secondDriver1.RunCar();

            var secondDriver2 = secondContainer.Resolve<Driver>();
            secondDriver2.RunCar();

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("*** HierarchicalLifetimeManager ***");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");


            var thirdContainer = new UnityContainer()
                   .RegisterType<ICar, BMW>(new HierarchicalLifetimeManager());

            var childContainer = thirdContainer.CreateChildContainer();

            var thirdDriver1 = thirdContainer.Resolve<Driver>();
            thirdDriver1.RunCar();

            var thirdDriver2 = thirdContainer.Resolve<Driver>();
            thirdDriver2.RunCar();

            var thirdDriver3 = childContainer.Resolve<Driver>();
            thirdDriver3.RunCar();

            var thirdDriver4 = childContainer.Resolve<Driver>();
            thirdDriver4.RunCar();


            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("*** finished.. ***");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.ReadLine();
        }
    }
}
