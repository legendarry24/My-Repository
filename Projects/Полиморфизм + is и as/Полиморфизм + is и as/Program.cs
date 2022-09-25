using System;
using System.Collections.Generic;

namespace Polymorphism
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var animals = new List<Animal>(); // список указателей на базовый класс
			animals.Add(new Cat("Котэ"));
			animals.Add(new Dog("Догес"));
			animals.Add(new Bird("Птичка"));
			Console.WriteLine(animals[0].GetType().Name + " именуемый {0}", animals[0].Name);
			Console.WriteLine(animals[1].GetType().Name + " именуемый {0}", animals[1].Name);
			Console.WriteLine(animals[2].GetType().Name + " именуемый {0}", animals[2].Name);
			// animals[1].Guard();   // поскольку обьект класса наследника является указателем на базой класс,
			// то мы имеем доступ только к тому, что описано в базовом классе
			// animals[2].Type = ""; // protected set не позволяет этого сделать
			foreach (Animal animal in animals)
			{
				animal.GetInfo();

				if (animal is Cat) // проверяем является ли данное животное котом
				{
					((Cat)animal).Catch(); // использовав явное преобразование, мы получаем полный доступ к объектам из списка
				}
				else if (animal is Dog)
				{
					(animal as Dog).Guard(); // animal as Dog эквивалентно выражению (Dog)animal
				}
				else
				{
					(animal as Bird)?.Fly(); // conditional access to avoid possible NullReferenceException
				}
			}
			Console.ReadKey();
		}
	}
}