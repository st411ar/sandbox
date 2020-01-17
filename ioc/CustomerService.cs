namespace InversionOfControl
{
	public class CustomerService
	{
		CustomerBusinessLogic _logic;

		public CustomerService()
		{
			_logic = new CustomerBusinessLogic(new DataAccess());
		}

		public string GetCustomerName(int id)
		{
			return _logic.GetCustomerName(id);
		}
	}
}