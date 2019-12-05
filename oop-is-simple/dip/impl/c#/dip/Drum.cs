using System;

namespace DependencyInversionPrinciple
{
	class Drum : IInstrument
	{
		public void GetSound()
		{
			Console.WriteLine("Bom-bum-tz!");
		}
	}
}