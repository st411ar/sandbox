namespace InversionOfControl
{
	public class CustomerBusinessLogic : IDataAccessDependency
	{
		IDataAccess _dataAccess;

		public CustomerBusinessLogic() {}

		public string GetCustomerName(int id)
		{
			return _dataAccess.GetCustomerName(id);
		}

		public void SetDependency(IDataAccess dataAccess)
		{
			_dataAccess = dataAccess;
		}
	}
}
