using System;

namespace LiskovSubstitutionPrinciple
{
	public class BrandABoiler : Boiler
	{
		private int _waterTemperature;

		public override void InitializeDevice()
		{
			Console.WriteLine("\nBrand A : InitializeDevice()");
			_waterTemperature = 33;
		}

		public override int GetWaterTemperature()
		{
			Console.WriteLine("Brand A : GetWaterTemperature()");
			return _waterTemperature;
		}

		public override void HeatWater()
		{
			Console.WriteLine("Brand A : HeatWater()");
			_waterTemperature++;
		}
	}
}
