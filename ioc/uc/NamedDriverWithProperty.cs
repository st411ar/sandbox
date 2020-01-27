using System;

using Microsoft.Practices.Unity;


namespace UnityContainerDemo
{
	public class NamedDriverWithProperty
	{
		public NamedDriverWithProperty() {}

		[Dependency("LuxuryCar")]
		public ICar Car { get; set; }

		public void RunCar()
		{
			string carName = Car.GetType().Name;
			int mileage = Car.Run();

			Console.WriteLine($"Running {carName} - {mileage} miles");
		}
	}
}