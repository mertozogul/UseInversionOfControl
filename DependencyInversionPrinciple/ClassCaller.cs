using System;

namespace DependencyInversionPrinciple
{
    //this class act as webui layer..
    public class ClassCaller
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("IOC With Dependency Inversion Principle..");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            CustomerBusinessLogic cblObj = new CustomerBusinessLogic();
            Console.WriteLine("customer name is {0}", cblObj.GetCustomerName(23));

            Console.ReadLine();
        }
    }
}
