namespace DependencyInversionPrinciple
{
	class Friend
	{
		static Instrument GiveInstrument()
		{
			return new Drum();
		}
	}
}
