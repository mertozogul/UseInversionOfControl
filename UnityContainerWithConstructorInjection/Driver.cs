using System;
using System.Collections.Generic;
using System.Text;
using Unity;

namespace UnityContainerWithConstructorInjection
{
    public class Driver
    {
        private ICar _car = null;
        private ICarKey _key = null;
        private string _name = string.Empty;

        [InjectionConstructor]
        public Driver(ICar car, ICarKey key, string driverName)
        {
            _car = car;
            _key = key;
            _name = driverName;
        }

        public Driver(string name)
        {

        }

        public void RunCar()
        {
            Console.WriteLine("{0} is running {1} with {2} - {3} mile", _name, _car.GetType().Name, _key.GetType().Name, _car.Run());
        }
    }
}
