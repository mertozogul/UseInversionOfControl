using System;

namespace IocWithDependencyInjectionPattern
{
    //this class act as webui layer
    public class ClassCaller
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Dependency Injection And Strategy Pattern:");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");


            Console.WriteLine("Constructor Injection:");

            CustomerBusinessLogic cblObj = new CustomerBusinessLogic(new CustomerDataAccess());
            Console.WriteLine("customer name: {0}", cblObj.ProcessCustomerData(23));

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");


            Console.WriteLine("Property Injection:");

            CustomerBusisnessLogicForPropInj cblObjForPropInj = new CustomerBusisnessLogicForPropInj();
            cblObjForPropInj.DataAccess = new CustomerDataAccess();
            Console.WriteLine("customer name: {0}", cblObjForPropInj.GetCustomerData(23));

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");


            Console.WriteLine("Method Injection (Based On Interface Method):");

            /*
                 In the method injection, dependencies are provided through methods. 
                 This method can be a class method or an interface method.
                 The following example demonstrates the method injection using an interface based method. 
            */

            CustomerBusinessLogicForMethodInj cblObjForMethodInj = new CustomerBusinessLogicForMethodInj();
            cblObjForMethodInj.SetDependency(new CustomerDataAccess());
            Console.WriteLine("customer name: {0}", cblObjForMethodInj.GetCustomerData(23));


            Console.ReadLine();
        }
    }
}
