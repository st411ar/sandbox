using System;

namespace LiskovSubstitutionPrinciple
{
	public class BoilerInitializationException : Exception
	{
		public BoilerInitializationException(string message) : base(message) {}
	}
}