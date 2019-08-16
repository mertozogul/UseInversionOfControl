using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple
{
    // bll layer, high level module

    /*
           The advantages of implementing DIP in the above example is that the CustomerBusinessLogic and CustomerDataAccess classes are loosely coupled classes because 
           CustomerBusinessLogic does not depend on the concrete DataAccess class, instead it includes a reference of the ICustomerDataAccess interface. 
           **************So now, we can easily use another class which implements ICustomerDataAccess with a different implementation.************
           Still, we have not achieved fully loosely coupled classes because the CustomerBusinessLogic 
           class includes a factory class to get the reference of ICustomerDataAccess. 
           This is where the Dependency Injection pattern helps us. 
           In the next chapter, we will learn how to use the Dependency Injection (DI) and the Strategy pattern using the above example.
    */

    /*
      **************SO NOW, WE CAN EASILY USE ANOTHER CLASS WHICH IMPLEMENTS ICUSTOMERDATAACCESS WITH A DIFFERENT IMPLEMENTATION.************     
    */
    public class CustomerBusinessLogic
    {
        ICustomerDataAccess _custDataAccess;

        public CustomerBusinessLogic()
        {
            //--> high level module de concrete low level module classının objesini oluşturmadık. Bir nebze loosely coupled tasarıma yaklaştık.
            //ama tam anlamıyla loosely coupled olmadı. Çünki  bu seferde ICustomerDataAccess reference'ını alabilmek için concrete factory classını içermek zorunda kaldık.  
            //bu durum loosely coupled tasarımın tam anlamıyla olmasını engelledi. İşte tam burada dependency injection devreye giricek. 
            _custDataAccess = CustomerDataAccessFactory.GetCustomerDataAccessObj();
        }

        public string GetCustomerName(int id)
        {
            return _custDataAccess.GetCustomerName(id);
        }
    }
}
