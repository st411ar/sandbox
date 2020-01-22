using System;

using Microsoft.Practices.Unity;

namespace UnityContainerDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			RegisterNamedTypes();
		}


		private static void RegisterNamedTypes()
		{
			IUnityContainer container = new UnityContainer();


			container.RegisterType<ICar, BMW>();

			container.RegisterType<ICar, Audi>("LuxuryCar");

			container.RegisterType<Driver>(
				"LuxuryCarDriver",
				new InjectionConstructor(container.Resolve<ICar>("LuxuryCar"))
			);


			Driver driver = container.Resolve<Driver>();
			driver.RunCar();

			Driver driver2 = container.Resolve<Driver>("LuxuryCarDriver");
			driver2.RunCar();
		}
	}
}
