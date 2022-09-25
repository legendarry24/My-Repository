using System.Text.RegularExpressions;

namespace RegexExample
{
	class Program
	{
		public static bool IsEmail(string s)
		{
			Regex regex = new Regex(@"^\w+([-.]\w+)*@\w+\.\w+([-.]\w+)*$");
			return regex.IsMatch(s);
		}

		static void Main(string[] args)
		{
			Console.WriteLine(IsEmail("www.aa_bb.a@gmail.com.ua")); // true
			Console.WriteLine(IsEmail("www_a-a.a@gmail.com"));		// true
			Console.WriteLine(IsEmail("www_a-a.agmail.com.ua"));	// false
			Console.WriteLine(IsEmail("a-a.a@gmail"));				// false

			// replace symbols that don't match the pattern
			string input = "12xy34";
			string pattern = "[^xy]";
			var regex = new Regex(pattern);

			Console.WriteLine(regex.Replace(input, "+")); // output: ++xy++
		}
	}
}
