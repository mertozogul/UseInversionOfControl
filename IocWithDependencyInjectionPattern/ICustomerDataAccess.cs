using System;
using System.Collections.Generic;
using System.Text;

namespace IocWithDependencyInjectionPattern
{
    public interface ICustomerDataAccess
    {
        string GetCustomerData(int id);
    }
}
