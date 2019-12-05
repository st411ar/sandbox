using System;

namespace DependencyInversionPrinciple
{
	class Pawnshop
	{
		public AInstrument PrepareToSell(string firmName, string instrumentName)
		{
			var instrumentClassFullName = $"DependencyInversionPrinciple.{firmName}{instrumentName}";
			var instrumentClass = Type.GetType(instrumentClassFullName);

			if (instrumentClass == null)
				return null;

			return (AInstrument) Activator.CreateInstance(instrumentClass);
		}
	}
}
