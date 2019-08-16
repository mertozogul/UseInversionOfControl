using System;
using System.Collections.Generic;
using System.Text;
using Unity;

namespace UnityContainerWithMethodInjection
{
    public class Driver
    {
        private ICar _car = null;

        public Driver()
        {
        }
        [InjectionMethod]
        public void UseCar(ICar car)
        {
            _car = car;
        }

        public void RunCar()
        {
            Console.WriteLine("Running {0} - {1} mile ", _car.GetType().Name, _car.Run());
        }
    }
}
