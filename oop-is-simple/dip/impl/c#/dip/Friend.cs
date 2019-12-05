namespace DependencyInversionPrinciple
{
	class Friend
	{
		public static IInstrument GiveInstrument()
		{
			return new Drum();
		}
	}
}
