using System;
using System.Collections.Generic;
using System.Text;

namespace IocWithDependencyInjectionPattern
{
    public class CustomerBusisnessLogicForPropInj
    {
        public CustomerBusisnessLogicForPropInj()
        {
        }

        public string GetCustomerData(int id)
        {
            return DataAccess.GetCustomerData(id);
        }

        public ICustomerDataAccess DataAccess { get; set; }
    }
}
