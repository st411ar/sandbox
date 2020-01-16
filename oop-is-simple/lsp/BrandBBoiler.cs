using System;

namespace LiskovSubstitutionPrinciple
{
	public class BrandBBoiler : Boiler
	{
		private int _waterTemperature;

		public override void InitializeDevice()
		{
			Console.WriteLine("\nBrand B : InitializeDevice()");
			_waterTemperature = 35;
		}

		public override int GetWaterTemperature()
		{
			Console.WriteLine("Brand B : GetWaterTemperature()");
			return _waterTemperature;
		}

		public override void HeatWater()
		{
			Console.WriteLine("Brand B : HeatWater()");
			_waterTemperature++;
		}
	}
}
