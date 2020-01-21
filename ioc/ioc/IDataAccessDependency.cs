namespace InversionOfControl
{
	interface IDataAccessDependency
	{
		void SetDependency(IDataAccess dataAccess);
	}
}