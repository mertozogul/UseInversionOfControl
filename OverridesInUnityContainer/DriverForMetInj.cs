using System;
using System.Collections.Generic;
using System.Text;
using Unity;

namespace OverridesInUnityContainer
{
    public class DriverForMetInj
    {
        private ICar _car = null;

        public DriverForMetInj()
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
