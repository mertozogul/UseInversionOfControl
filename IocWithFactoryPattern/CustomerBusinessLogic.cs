using System;
using System.Collections.Generic;
using System.Text;

namespace IocWithFactoryPattern
{
    //high level module 
    //dependent class
    public class CustomerBusinessLogic
    {
        public CustomerBusinessLogic()
        {
        }

        public string GetCustomerName(int id)
        {
            DataAccess _dataAccess = DataAccessFactory.GetDataAccessObj();
            return _dataAccess.GetCustomerName(id);
        }
    }
}
