namespace InversionOfControl
{
	public class CustomerBusinessLogic
	{
		public IDataAccess DataAccess { get; set; }

		public CustomerBusinessLogic() {}

		public string GetCustomerName(int id)
		{
			return DataAccess.GetCustomerName(id);
		}
	}
}
