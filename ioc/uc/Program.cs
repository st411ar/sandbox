using System;

using Microsoft.Practices.Unity;

namespace UnityContainerDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			IUnityContainer container = new UnityContainer();
			container.RegisterType<ICar, BMW>();
			container.RegisterType<ICar, Audi>();

			Driver driver = container.Resolve<Driver>();
			driver.RunCar();

			Driver driver2 = container.Resolve<Driver>();
			driver2.RunCar();
		}
	}
}
