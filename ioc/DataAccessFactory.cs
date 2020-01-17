namespace InversionOfControl
{
	public class DataAccessFactory
	{
		public static IDataAccess GetDataAccessObj()
		{
			return new DataAccess();
		}
	}
}