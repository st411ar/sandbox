namespace LiskovSubstitutionPrinciple
{
	abstract class Boiler
	{
		public int DesirableTemperature { get; set; }

		public abstract void InitializeDevice();
		public abstract int GetWaterTemperature();
		public abstract void HeatWater();
	}
}
