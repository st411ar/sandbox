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

			var instrument = (AInstrument) Activator.CreateInstance(instrumentClass);

			return PrepareToSell(instrument);
		}

		public AInstrument PrepareToSell()
		{
			var instrument = InstrumentFactory.GetInstrument();

			return PrepareToSell(instrument);
		}

		public AInstrument PrepareToSell(AInstrument instrument)
		{
			ProcessPreparingToCell(instrument);
			return instrument;
		}



		private void ProcessPreparingToCell(AInstrument instrument)
		{
			instrument.Repair();
			instrument.Pack();
		}
	}
}
