using System;

using Microsoft.Practices.Unity;


namespace UnityContainerDemo
{
	public class DriverWithMethodAtRunTime
	{
		private ICar _car = null;

		public DriverWithMethodAtRunTime() {}

		public void UseCar(ICar car)
		{
			_car = car;
		}

		public void RunCar()
		{
			string carName = _car.GetType().Name;
			int mileage = _car.Run();

			Console.WriteLine($"Running {carName} - {mileage} miles");
		}
	}
}