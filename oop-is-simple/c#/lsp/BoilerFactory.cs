using System;

namespace LiskovSubstitutionPrinciple
{
	class BoilerFactory
	{
		public static Boiler GetNextBoiler()
		{
			var rnd = new Random().Next(1, 4);

			switch (rnd)
			{
				case 1:
					return new BrandABoiler();
				case 2:
					return new BrandBBoiler();
				case 3:
					return new BrandCBoilerLspBroken();
				default:
					return null;
			}
		}
	}
}
