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
			Console.WriteLine("\nRegisterNamedTypes() start");

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

			Console.WriteLine("RegisterNamedTypes() stop\n");
		}

		private static void RegisterInstance()
		{
			Console.WriteLine("\nRegisterInstance() start");

			IUnityContainer container = new UnityContainer();


			ICar audi = new Audi();
			container.RegisterInstance<ICar>(audi);

			container.RegisterType<ICarKey, AudiKey>();


			Driver driver1 = container.Resolve<Driver>();
			driver1.RunCar();
			driver1.RunCar();

			Driver driver2 = container.Resolve<Driver>();
			driver2.RunCar();

			Console.WriteLine("RegisterInstance() stop\n");
		}

		private static void MultipleParametersConstructorInjection()
		{
			Console.WriteLine("\nMultipleParametersConstructorInjection() start");

			var container = new UnityContainer();

			container.RegisterType<ICar, Audi>();
			container.RegisterType<ICarKey, AudiKey>();

			var driver = container.Resolve<Driver>();
			driver.RunCar();

			Console.WriteLine("MultipleParametersConstructorInjection() stop\n");
		}
	}
}
