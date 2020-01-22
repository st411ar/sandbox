using System;

using Microsoft.Practices.Unity;

namespace UnityContainerDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			IUnityContainer container = new UnityContainer();

			Driver driver = new Driver(new BMW());

			driver.RunCar();
		}
	}
}
