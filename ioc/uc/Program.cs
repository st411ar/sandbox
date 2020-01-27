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
			MultipleConstructorsInjection();
			PrimitiveTypeConstructorInjection();
			PropertyInjectionDemo();
			NamedPropertyInjectionDemo();
			RunTimePropertyInjectionDemo();
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

		private static void MultipleConstructorsInjection()
		{
			Console.WriteLine("\nMultipleConstructorsInjection() start");

			var container = new UnityContainer();

			container.RegisterType<ICar, Audi>();

			var driver = ResolveNamedDriverSafely(container);
			driver.RunCar();

			Console.WriteLine("MultipleConstructorsInjection() stop\n");
		}

		private static void PrimitiveTypeConstructorInjection()
		{
			Console.WriteLine("\nPrimitiveTypeConstructorInjection() start");

			var container = new UnityContainer();

			container.RegisterType<ICar, Audi>();
//			container.RegisterType<NamedDriver2>(new InjectionConstructor(new object[] { new Ford(), "Steve" }));
			container.RegisterType<NamedDriver2>(new InjectionConstructor(new object[] { container.Resolve<ICar>(), "Steve" }));

			var driver = container.Resolve<NamedDriver2>();
			driver.RunCar();

			Console.WriteLine("PrimitiveTypeConstructorInjection() stop\n");
		}

		private static void PropertyInjectionDemo()
		{
			Console.WriteLine("\nPropertyInjectionDemo() start");

			var container = new UnityContainer();

			container.RegisterType<ICar, BMW>();

			var driver = container.Resolve<DriverWithProperty>();
			driver.RunCar();

			Console.WriteLine("PropertyInjectionDemo() stop\n");
		}

		private static void NamedPropertyInjectionDemo()
		{
			Console.WriteLine("\nNamedPropertyInjectionDemo() start");

			var container = new UnityContainer();

			container.RegisterType<ICar, BMW>();
			container.RegisterType<ICar, Audi>("LuxuryCar");

			var driver = container.Resolve<NamedDriverWithProperty>();
			driver.RunCar();

			Console.WriteLine("NamedPropertyInjectionDemo() stop\n");
		}

		private static void RunTimePropertyInjectionDemo()
		{
			Console.WriteLine("\nRunTimePropertyInjectionDemo() start");

			var container = new UnityContainer();

			container.RegisterType<NamedDriverWithProperty>(new InjectionProperty("Car", new BMW()));

			var driver = container.Resolve<NamedDriverWithProperty>();
			driver.RunCar();

			Console.WriteLine("RunTimePropertyInjectionDemo() stop\n");
		}


		private static NamedDriver ResolveNamedDriverSafely(UnityContainer container)
		{
			try
			{
				return container.Resolve<NamedDriver>();
			}
			catch (Exception e)
			{
				Console.WriteLine("Default resolving has been failed. Trying to resolve at run time ...");
//				container.RegisterType<NamedDriver>(new InjectionConstructor(new Ford()));
				container.RegisterType<NamedDriver>(new InjectionConstructor(container.Resolve<ICar>()));
				return container.Resolve<NamedDriver>();
			}
		}
	}
}
