using System;

namespace LiskovSubstitutionPrinciple
{
	class Program
	{
		static void Main(string[] args)
		{
			ManageBoilers(5);
		}


		private static void ManageBoilers(int boilersNumber)
		{
			for (int i = 0; i < boilersNumber; i++)
			{
				var boiler = BoilerFactory.GetNextBoiler();
				ManageBoiler(boiler);
			}
		}

		private static void ManageBoiler(Boiler boiler)
		{
			boiler.DesirableTemperature = 37;
			boiler.InitializeDevice();
			while (boiler.GetWaterTemperature() < boiler.DesirableTemperature)
				boiler.HeatWater();
		}
	}
}
