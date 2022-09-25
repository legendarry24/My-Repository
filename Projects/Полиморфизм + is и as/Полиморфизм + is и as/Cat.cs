using System;

namespace Polymorphism
{
	internal class Cat : Animal
	{
		public Cat(string name)
		{
			Name = name;
			Type = "Млекопитающее";
		}

		public void Catch()
		{
			Console.WriteLine($"{Name} ловит мышь");
		}

		public override void GetInfo() // реализация абстрактного метода
		{
			Console.WriteLine($"Имя: {Name}");
		}
	}
}