namespace InversionOfControl
{
	public class CustomerBusinessLogic
	{
		IDataAccess _dataAccess;

		public CustomerBusinessLogic()
		{
			_dataAccess = DataAccessFactory.GetDataAccessObj();
		}

		public string GetCustomerName(int id)
		{
			return _dataAccess.GetCustomerName(id);
		}
	}
}
