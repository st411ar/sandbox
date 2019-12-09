using System;

namespace LiskovSubstitutionPrinciple
{
	class BrandBBoiler : Boiler
	{
		int WaterTemperature;

		public override void InitializeDevice()
		{
			Console.WriteLine("\nBrand B : InitializeDevice()");
			WaterTemperature = 35;
		}

		public override int GetWaterTemperature()
		{
			Console.WriteLine("Brand B : GetWaterTemperature()");
			return WaterTemperature;
		}

		public override void HeatWater()
		{
			Console.WriteLine("Brand B : HeatWater()");
			WaterTemperature++;
		}
	}
}
