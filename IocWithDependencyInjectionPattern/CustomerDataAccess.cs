using System;
using System.Collections.Generic;
using System.Text;

namespace IocWithDependencyInjectionPattern
{
    public class CustomerDataAccess : ICustomerDataAccess
    {
        public CustomerDataAccess()
        {
        }

        public string GetCustomerData(int id)
        {
            //get the customer name from the db in real application        
            return "Dummy Customer Name";
        }
    }
}
