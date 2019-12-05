using System;

namespace DependencyInversionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
        	DemonstrateInterface();
        }


        private static void DemonstrateInterface()
        {
            var musicalInstrument = Friend.GiveInstrument();

            musicalInstrument.GetSound();
        }
    }
}
