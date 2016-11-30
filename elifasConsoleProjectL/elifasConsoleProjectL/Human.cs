using System;

namespace elifasConsoleProjectL
{
	public class Human
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

		//

	}
}
