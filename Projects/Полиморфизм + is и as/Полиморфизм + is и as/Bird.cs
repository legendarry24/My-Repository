using System;

namespace Polymorphism
{
	internal class Bird : Animal
	{
		public Bird(string name)
		{
			Name = name;
			Type = "Птица";
		}

		public void Fly()
		{
			Console.WriteLine($"{Name} летает");
		}

		public override void GetInfo()
		{
			Console.WriteLine($"Имя: {Name}, Тип: {Type}");
		}
	}
}