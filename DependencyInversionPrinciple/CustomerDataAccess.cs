using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple
{
    //dal layer, low level module..
    public class CustomerDataAccess : ICustomerDataAccess
    {
        public CustomerDataAccess() { }
        public string GetCustomerName(int id)
        {
            return "Dummy Customer Name";
        }
    }
}
