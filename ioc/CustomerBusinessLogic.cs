namespace InversionOfControl
{
	public class CustomerBusinessLogic
	{
		DataAccess _dataAccess;

		public CustomerBusinessLogic()
		{
			_dataAccess = new DataAccess();
		}

		public string GetCustomerName(int id)
		{
			return _dataAccess.GetCustomerName(id);
		}
	}
}
