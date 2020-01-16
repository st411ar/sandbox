using System;

namespace LiskovSubstitutionPrinciple
{
	public class BrandCBoiler : Boiler
	{
		private int _waterTemperature;
		private int _desirableTemperature;

		public override void InitializeDevice()
		{
			Console.WriteLine("\nBrand C : InitializeDevice()");
			_desirableTemperature = GetDesirableTemperature();
			_waterTemperature = 31;
		}

		public override int GetWaterTemperature()
		{
			Console.WriteLine("Brand C : GetWaterTemperature()");
			return _waterTemperature;
		}

		public override void HeatWater()
		{
			Console.WriteLine("Brand C : HeatWater()");
			if (_waterTemperature < _desirableTemperature)
				_waterTemperature++;
		}
	}
}
