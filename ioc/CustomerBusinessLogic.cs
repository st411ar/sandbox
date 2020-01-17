namespace InversionOfControl
{
	public class CustomerBusinessLogic
	{
		IDataAccess _dataAccess;

		public CustomerBusinessLogic()
		{
			_dataAccess = new DataAccess();
		}

		public CustomerBusinessLogic(IDataAccess dataAccess)
		{
			_dataAccess = dataAccess;
		}

		public string GetCustomerName(int id)
		{
			return _dataAccess.GetCustomerName(id);
		}
	}
}
