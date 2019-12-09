using System;

namespace LiskovSubstitutionPrinciple
{
	class BoilerFactory
	{
		public static Boiler GetNextBoiler()
		{
			var rnd = new Random().Next(1, 3);

			switch (rnd)
			{
				case 1:
					return new BrandABoiler();
				case 2:
					return new BrandBBoiler();
				default:
					return null;
			}
		}
	}
}
