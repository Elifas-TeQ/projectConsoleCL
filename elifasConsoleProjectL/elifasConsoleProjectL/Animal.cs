using System;

namespace elifasConsoleProjectL
{
	public class Animal : ILivable
	{
		public Animal()
		{
		}

		public void Live()
		{
			Console.WriteLine("gaf-gaf...");
		}
	}
}
