namespace DependencyInversionPrinciple
{
	class InstrumentFactory
	{
		public static AInstrument GetInstrument()
		{
			return new MarysHarmonica();
		}
	}
}
