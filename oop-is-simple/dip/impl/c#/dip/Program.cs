using System;

namespace DependencyInversionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var musicalInstrument = Friend.GiveInstrument();

            musicalInstrument.GetSound();
        }
    }
}
