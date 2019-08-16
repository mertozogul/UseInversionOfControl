using System;
using System.Collections.Generic;
using System.Text;

namespace IocWithFactoryPattern
{
    //low level module factory class which generates low level module class's object for high level module class.
    public class DataAccessFactory
    {
        public static DataAccess GetDataAccessObj()
        {
            return new DataAccess();
        }
    }
}
