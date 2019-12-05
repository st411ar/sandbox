namespace DependencyInversionPrinciple
{
	class Friend
	{
		public static Instrument GiveInstrument()
		{
			return new Drum();
		}
	}
}
