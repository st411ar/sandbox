namespace LiskovSubstitutionPrinciple
{
	public abstract class Boiler
	{
		private int _desirableTemperature;

		public void SetDesirableTemperature(int temp)
		{
			_desirableTemperature = temp;
		}

		public int GetDesirableTemperature()
		{
			return _desirableTemperature;
		}

		public abstract void InitializeDevice();
		public abstract int GetWaterTemperature();
		public abstract void HeatWater();
	}
}
