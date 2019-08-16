using System;
using System.Collections.Generic;
using System.Text;
using Unity;

namespace OverridesInUnityContainer
{
    public class Driver
    {
        //private ICar _car_1 = null;
        //private ICar _car_2 = null;
        //private ICar _car_3 = null;

        //public Driver(ICar car1, ICar car2, ICar car3)
        //{
        //    _car_1 = car1;
        //    _car_2 = car2;
        //    _car_3 = car3;
        //}

        //public void RunCar()
        //{
        //    if (_car_1 != null)
        //    {
        //        Console.WriteLine("running first car {0} - {1} mile", _car_1.GetType().Module, _car_1.Run());
        //    }

        //    if (_car_2 != null)
        //    {
        //        Console.WriteLine("running second car  {0} - {1} mile", _car_2.GetType().Module, _car_2.Run());
        //    }

        //    if (_car_3 != null)
        //    {
        //        Console.WriteLine("running third car  {0} - {1} mile", _car_3.GetType().Module, _car_3.Run());
        //    }
        //}

        [Dependency]
        public ICar _car = null;

        public Driver(ICar car)
        {
            _car = car;
        }

        public void RunCar()
        {
            Console.WriteLine("Running {0} - {1} mile ", _car.GetType().Name, _car.Run());
        }
    }
}
