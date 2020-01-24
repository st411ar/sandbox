using System;

using Microsoft.Practices.Unity;


namespace UnityContainerDemo
{
	public class NamedDriver
	{
		private ICar _car = null;


		public NamedDriver(string name) {}

//		[InjectionConstructor]
		public NamedDriver(ICar car)
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