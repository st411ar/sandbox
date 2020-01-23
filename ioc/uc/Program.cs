using System;

using Microsoft.Practices.Unity;

namespace UnityContainerDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			RegisterNamedTypes();
			RegisterInstance();
			MultipleParametersConstructorInjection();
		}


		private static void RegisterNamedTypes()
		{
			IUnityContainer container = new UnityContainer();


			container.RegisterType<ICar, BMW>();
			container.RegisterType<ICarKey, BMWKey>();

			container.RegisterType<ICar, Audi>("LuxuryCar");
			container.RegisterType<ICarKey, AudiKey>("LuxuryCarKey");

			container.RegisterType<Driver>(
				"LuxuryCarDriver",
				new InjectionConstructor(
					container.Resolve<ICar>("LuxuryCar"),
					container.Resolve<ICarKey>("LuxuryCarKey")
				)
			);


			Driver driver = container.Resolve<Driver>();
			driver.RunCar();

			Driver driver2 = container.Resolve<Driver>("LuxuryCarDriver");
			driver2.RunCar();
		}

		private static void RegisterInstance()
		{
			IUnityContainer container = new UnityContainer();


			ICar audi = new Audi();
			container.RegisterInstance<ICar>(audi);

			container.RegisterType<ICarKey, AudiKey>();


			Driver driver1 = container.Resolve<Driver>();
			driver1.RunCar();
			driver1.RunCar();

			Driver driver2 = container.Resolve<Driver>();
			driver2.RunCar();
		}

		private static void MultipleParametersConstructorInjection()
		{
			var container = new UnityContainer();

			container.RegisterType<ICar, Audi>();
			container.RegisterType<ICarKey, AudiKey>();

			var driver = container.Resolve<Driver>();
			driver.RunCar();
		}
	}
}
