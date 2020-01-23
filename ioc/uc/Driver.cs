using System;

namespace UnityContainerDemo
{
	public class Driver
	{
		private ICar _car = null;
		private ICarKey _key = null;

		public Driver(ICar car, ICarKey key)
		{
			_car = car;
			_key = key;
		}

		public void RunCar()
		{
			string carName = _car.GetType().Name;
			string keyName = _key.GetType().Name;
			int mileage = _car.Run();

			Console.WriteLine($"Running {carName} with {keyName} - {mileage} miles");
		}
	}
}