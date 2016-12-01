using System;
using NUnit.Framework;

namespace elifasConsoleProjectL
{
	public class Human : ILivable
	{
		public string Name { get; set; }
		public int Age { get; set; }

		public Human() : this("unknown", 0)
		{
		}

		public Human(string name, int age)
		{
			this.Name = name;
			this.Age = age;
		}

		public void Live()
		{
			if (String.IsNullOrEmpty(this.Name))
				throw new NullReferenceException();
			Console.WriteLine($"I'm alive! #{this.Name}");
		}

		//

	}
}
