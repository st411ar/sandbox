using System;

namespace UnityContainerDemo
{
	public class Driver
	{
		private ICar _car = null;

		public Driver(ICar car)
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