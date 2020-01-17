namespace InversionOfControl
{
	public class CustomerBusinessLogic
	{
		public CustomerBusinessLogic() {}

		public string GetCustomerName(int id)
		{
			DataAccess _dataAccess = DataAccessFactory.GetDataAccessObj();

			return _dataAccess.GetCustomerName(id);
		}
	}
}
