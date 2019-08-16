using System;
using System.Collections.Generic;
using System.Text;

namespace IocWithDependencyInjectionPattern
{
    public class CustomerBusinessLogicForMethodInj : IDataAccessDependency
    {
        ICustomerDataAccess CustomerDataAccess;

        public CustomerBusinessLogicForMethodInj()
        {
        }

        public string GetCustomerData(int id)
        {
            return CustomerDataAccess.GetCustomerData(id);
        }

        public void SetDependency(ICustomerDataAccess customerDataAccess)
        {
            this.CustomerDataAccess = customerDataAccess;
        }
    }
}
