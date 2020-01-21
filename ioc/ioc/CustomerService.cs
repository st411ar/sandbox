namespace InversionOfControl
{
	public class CustomerService
	{
		CustomerBusinessLogic _logic;

		public CustomerService()
		{
			_logic = new CustomerBusinessLogic();
			_logic.SetDependency(new DataAccess());
		}

		public string GetCustomerName(int id)
		{
			return _logic.GetCustomerName(id);
		}
	}
}