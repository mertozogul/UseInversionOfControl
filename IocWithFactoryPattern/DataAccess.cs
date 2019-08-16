using System;
using System.Collections.Generic;
using System.Text;

namespace IocWithFactoryPattern
{
    //low level module
    //dependency class
    public class DataAccess
    { 
        public DataAccess()
        {
        }

        public string GetCustomerName(int id)
        {
            return "Dummy Customer Name"; // get it from DB in real app
        }
    }
}
