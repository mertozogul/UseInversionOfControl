using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple
{
    public class CustomerDataAccessFactory
    {
        public static ICustomerDataAccess GetCustomerDataAccessObj()
        {
            return new CustomerDataAccess();
        } 
    }
}
