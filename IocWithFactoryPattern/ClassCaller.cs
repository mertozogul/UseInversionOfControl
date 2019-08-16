using System;

namespace IocWithFactoryPattern
{
    //this class act as webui sector 
    public class ClassCaller
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("IOC With Factory Pattern..");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            CustomerBusinessLogic cblObject = new CustomerBusinessLogic();
            Console.WriteLine("customer name: {0}", cblObject.GetCustomerName(23));
            
            Console.ReadLine();
        }
    }
}
