using System;

namespace LiskovSubstitutionPrinciple
{
	class BrandABoiler : Boiler
	{
		int WaterTemperature;

		public override void InitializeDevice()
		{
			Console.WriteLine("\nBrand A : InitializeDevice()");
			WaterTemperature = 33;
		}

		public override int GetWaterTemperature()
		{
			Console.WriteLine("Brand A : GetWaterTemperature()");
			return WaterTemperature;
		}

		public override void HeatWater()
		{
			Console.WriteLine("Brand A : HeatWater()");
			WaterTemperature++;
		}
	}
}
