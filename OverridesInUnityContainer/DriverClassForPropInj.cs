using System;
using System.Collections.Generic;
using System.Text;
using Unity;

namespace OverridesInUnityContainer
{
    public class DriverClassForPropInj
    {
        [Dependency]
        public ICar Car { get; set; }

        public DriverClassForPropInj()
        {
        }
        public void RunCar()
        {
            Console.WriteLine("Running {0} - {1} mile ", Car.GetType().Name, Car.Run());
        }
    }
}
