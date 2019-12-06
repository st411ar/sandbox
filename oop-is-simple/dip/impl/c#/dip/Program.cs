using System;

namespace DependencyInversionPrinciple
{
	class Program
	{
		static void Main(string[] args)
		{
			DemonstrateInterface();
			DemonstrateAbstract();
			DemonstrateDependencyInversionByCleanMethod();
			DemonstrateDependencyInversionByFactory();
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

			var preparedToSellInstrument = pawnshop.PrepareToSell(firmName, instrumentName);

			preparedToSellInstrument.GetSound();

			Console.WriteLine("Abstract demonstration stop");
		}

		private static void DemonstrateDependencyInversionByCleanMethod()
		{
			Console.WriteLine("Dependency inversion demonstration by clean method start");

			var pawnshop = new Pawnshop();

			var instrument = new MarysHarmonica();

			var preparedToSellInstrument = pawnshop.PrepareToSell(instrument);

			preparedToSellInstrument.GetSound();

			Console.WriteLine("Dependency inversion demonstration by clean method stop");
		}

		private static void DemonstrateDependencyInversionByFactory()
		{
			Console.WriteLine("Dependency inversion demonstration by factory start");

			var pawnshop = new Pawnshop();

			var preparedToSellInstrument = pawnshop.PrepareToSell();

			preparedToSellInstrument.GetSound();

			Console.WriteLine("Dependency inversion demonstration by factory stop");
		}
	}
}