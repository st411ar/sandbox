using System;

namespace DependencyInversionPrinciple
{
	class Drum : Instrument
	{
		public void GetSound()
		{
			Console.WriteLine("Bom-bum-tz!");
		}
	}
}