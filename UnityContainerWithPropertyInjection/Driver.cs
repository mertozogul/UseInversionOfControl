using System;
using System.Collections.Generic;
using System.Text;
using Unity;

namespace UnityContainerWithPropertyInjection
{
    public  class Driver
    {
        public Driver()
        {
        }

        [Dependency("LuxuryCar")]
        public ICar Car { get; set; }

        public void RunCar()
        {
            Console.WriteLine("Running {0} - {1} mile ", this.Car.GetType().Name, this.Car.Run());
        }
    }
}
