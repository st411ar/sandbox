using System;

using Microsoft.Practices.Unity;


namespace UnityContainerDemo
{
	public class DriverWithProperty
	{
		public DriverWithProperty() {}

		[Dependency]
		public ICar Car { get; set; }

		public void RunCar()
		{
			string carName = Car.GetType().Name;
			int mileage = Car.Run();

			Console.WriteLine($"Running {carName} - {mileage} miles");
		}
	}
}