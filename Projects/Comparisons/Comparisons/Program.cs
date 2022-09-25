using System;

namespace Comparisons
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			// Создадим две одиннаковые строки, но с разными адрессами
			string a = new string(new char[] { 'h', 'e', 'l', 'l', 'o' });
			string b = "hello";
			string s1 = "Hi";
			string s2 = null;
			Console.WriteLine(a == b);      // true
			Console.WriteLine(a.Equals(b)); // true
			// следующие 4 вызова дадут false, cuz ни значение, ни адрес не одиннаковые
			Console.WriteLine(s1 == s2);
			Console.WriteLine(s1.Equals(s2));
			Console.WriteLine(object.Equals(s1, s2));
			Console.WriteLine(object.ReferenceEquals(s1, s2));
			// Now let's see what happens with the same tests but
			// with variables of type object
			object c = a;
			object d = b;
			object e = a;
			// два одиннаковых сравнения значений
			Console.WriteLine(object.Equals(c, d)); // true
			Console.WriteLine(c.Equals(d));         // true
			// два одиннаковых сравнения ссылок
			Console.WriteLine(object.ReferenceEquals(c, e)); // true
			Console.WriteLine(c == e);      // здесь будет true, cuz адреса одиннаковые

			Console.WriteLine(c == d);      // здесь будет false, cuz object это ссылочный тип,
											// so == будет сравнивать адреса, а не значения
			Console.WriteLine(object.ReferenceEquals(c, d)); // false
			Console.ReadKey();
		}
	}
}