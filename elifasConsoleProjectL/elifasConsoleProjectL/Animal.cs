using System;

namespace elifasConsoleProjectL
{
	public class Animal : ILivable
	{
		public string Name { get; set; }
		public int Age { get; set; }

		public Animal()
		{
		}

		public void Live()
		{
			Console.WriteLine("gaf-gaf...");
		}
	}
}
