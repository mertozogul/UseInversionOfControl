using System;
using System.Collections.Generic;
using System.Text;

namespace IocWithDependencyInjectionPattern
{
    public interface IDataAccessDependency
    {
        void SetDependency(ICustomerDataAccess customerDataAccess);
    }
}
