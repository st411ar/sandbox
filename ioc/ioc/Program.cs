using System;

namespace InversionOfControl
{
	class Program
	{
		static void Main(string[] args)
		{
			CustomerService service = new CustomerService();
			string name = service.GetCustomerName(0);

			Console.WriteLine(name);
		}
	}
}
