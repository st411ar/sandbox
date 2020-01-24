using System;

namespace UnityContainerDemo
{
	public class NamedDriver2
	{
		private string _name = string.Empty;
		private ICar _car = null;


		public NamedDriver2(ICar car, string driverName)
		{
			_car = car;
			_name = driverName;
		}


		public void RunCar()
		{
			string carName = _car.GetType().Name;
			int mileage = _car.Run();

			Console.WriteLine($"{_name} is running {carName} - {mileage} miles");
		}
	}
}