using System;

namespace DependencyInversionPrinciple
{
	class MarysHarmonica : AInstrument
	{
		public override void GetSound()
		{
			Console.WriteLine("Piu-piu");
		}

		public override void Repair()
		{
			Console.WriteLine("MarysHarmonica has been repaired");
		}

		public override void Pack()
		{
			Console.WriteLine("MarysHarmonica is packed now in a big red box");
		}
	}
}