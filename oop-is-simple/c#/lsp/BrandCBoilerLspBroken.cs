using System;

namespace LiskovSubstitutionPrinciple
{
	public class BrandCBoilerLspBroken : Boiler
	{
		private bool _isInitialized;
		private int _waterTemperature;
		private int _desirableTemperature;

		public override void SetDesirableTemperature(int temp)
		{
			if (!_isInitialized)
			{
				throw new BoilerInitializationException("Initialize boiler before setting desirable temperature");
			}

			_desirableTemperature = temp;
		}

		public override int GetDesirableTemperature()
		{
			if (!_isInitialized)
			{
				throw new BoilerInitializationException("Initialize boiler before getting desirable temperature");
			}

			return _desirableTemperature;
		}

		public override void InitializeDevice()
		{
			Console.WriteLine("\nBrand C with broken LSP : InitializeDevice()");
			_isInitialized = true;
			_waterTemperature = 31;
		}

		public override int GetWaterTemperature()
		{
			Console.WriteLine("Brand C with broken LSP : GetWaterTemperature()");
			return _waterTemperature;
		}

		public override void HeatWater()
		{
			Console.WriteLine("Brand C with broken LSP : HeatWater()");
			_waterTemperature++;
		}
	}
}
