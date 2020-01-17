using System;

namespace InversionOfControl
{
    class Program
    {
        static void Main(string[] args)
        {
        	CustomerBusinessLogic logic = new CustomerBusinessLogic();
        	string name = logic.GetCustomerName(0);

        	Console.WriteLine(name);
        }
    }
}
