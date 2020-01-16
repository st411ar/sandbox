using System;

namespace LiskovSubstitutionPrinciple
{
	class Program
	{
		public static void Main(string[] args)
		{
			const int boilersNumber = 5;

			Console.WriteLine($"Managing {boilersNumber} boilers");
			ManageBoilers(5);
		}


		private static void ManageBoilers(int boilersNumber)
		{
			for (var i = 0; i < boilersNumber; i++)
			{
				var boiler = BoilerFactory.GetNextBoiler();
				ManageBoiler(boiler);
			}
		}

		private static void ManageBoiler(Boiler boiler)
		{
			boiler.SetDesirableTemperature(37);
			boiler.InitializeDevice();
			while (boiler.GetWaterTemperature() < boiler.GetDesirableTemperature())
				boiler.HeatWater();
			Console.WriteLine($"result temperature: {boiler.GetWaterTemperature()}");
		}
	}
}
