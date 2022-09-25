using System;

namespace Polymorphism
{
	internal class Dog : Animal
	{
		public Dog(string name)
		{
			Name = name;
			Type = "Млекопитающее";
		}
		public void Guard()
		{
			Console.WriteLine($"{Name} охраняет");
		}
		public override void GetInfo()
		{
			Console.WriteLine($"Имя: {Name}");
		}
	}
}