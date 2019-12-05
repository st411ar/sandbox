using System;

namespace DependencyInversionPrinciple
{
	class Program
	{
		static void Main(string[] args)
		{
			DemonstrateInterface();
			DemonstrateAbstract();
		}


		private static void DemonstrateInterface()
		{
			Console.WriteLine("Interface demonstration start");

			var musicalInstrument = Friend.GiveInstrument();

			musicalInstrument.GetSound();

			Console.WriteLine("Interface demonstration stop");
		}

        private static void DemonstrateAbstract()
		{
			Console.WriteLine("Abstract demonstration start");

			var firmName = "Marys";
			var instrumentName = "Harmonica";

			var pawnshop = new Pawnshop();

			var musicalInstrument = pawnshop.PrepareToSell(firmName, instrumentName);

			musicalInstrument.GetSound();

			Console.WriteLine("Abstract demonstration stop");
		}
	}
}