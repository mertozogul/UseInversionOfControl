﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UnityContainerWithPropertyInjection
{
    public class Audi : ICar
    {
        private int _miles = 0;

        public int Run()
        {
            return ++_miles;
        }
    }
}
