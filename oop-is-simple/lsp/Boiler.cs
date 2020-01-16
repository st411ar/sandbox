using System;

namespace LiskovSubstitutionPrinciple
{
	public abstract class Boiler
	{
		private int _desirableTemperature;

		public virtual void SetDesirableTemperature(int temp)
		{
			_desirableTemperature = temp;
		}

		public virtual int GetDesirableTemperature()
		{
			return _desirableTemperature;
		}

		public abstract void InitializeDevice();
		public abstract int GetWaterTemperature();
		public abstract void HeatWater();
	}
}
