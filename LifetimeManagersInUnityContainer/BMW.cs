﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LifetimeManagersInUnityContainer
{
    public class BMW : ICar
    {
        private int _miles = 0;

        public int Run()
        {
            return ++_miles;
        }
    }
}
