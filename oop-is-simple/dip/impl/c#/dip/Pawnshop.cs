using System;

namespace DependencyInversionPrinciple
{
	class Pawnshop
	{
		public AInstrument PrepareToSell(string firmName, string instrumentName)
		{
			var instrumentClassName = firmName + instrumentName;
			var instrumentClass = Type.GetType(instrumentClassName);

			if (instrumentClass == null)
				return null;

			return (AInstrument) Activator.CreateInstance(instrumentClass);
		}
	}
}
