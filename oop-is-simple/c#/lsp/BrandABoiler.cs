using System;

namespace LiskovSubstitutionPrinciple
{
	class BrandABoiler : Boiler
	{
		int WaterTemperature;

		public override void InitializeDevice()
		{
			Console.WriteLine("Brand A : InitializeDevice()");
			WaterTemperature = 0;
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
