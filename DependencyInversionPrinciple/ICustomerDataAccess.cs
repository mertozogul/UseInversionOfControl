using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple
{
    public interface ICustomerDataAccess
    {
        string GetCustomerName(int id);
    }
}
