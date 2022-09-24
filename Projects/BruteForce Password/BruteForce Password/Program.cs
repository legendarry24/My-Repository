using System;
using System.Diagnostics;
using System.Linq;

namespace BruteForce_Password
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			//Console.Write("Insert Password: ");
			//string password = Console.ReadLine();
			const string password = "VerY$Tr0nGp@SSw0^rD";

			Stopwatch sw = Stopwatch.StartNew();
			Console.WriteLine($"[+][+] All Matched - Password Found: {BruteForce(password)}");
			sw.Stop();
			Console.WriteLine($"Elapsed time: {sw.ElapsedMilliseconds} ms");
			Console.ReadKey();
		}

		private static string BruteForce(string password)
		{
			string result = "";

			Console.WriteLine("[+][+] Starting BruteForce...");
			foreach (char c in password)
			{
				if (IsMatched(c, FindCharset(c)))
				{
					result += c;
				}
			}

			return result;
		}

		private static string FindCharset(char passwordChar)
		{
			const string lowerChars = "abcdefghijklmnopqrstuvwxyz";
			const string upperChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
			const string digitalChars = "0123456789";
			const string specialChars = "!@#$%^&*(~[-+:=;'{<>_?/,.|¿¡}'])";

			if (lowerChars.Contains(passwordChar))
			{
				return lowerChars;
			}
			else if (upperChars.Contains(passwordChar))
			{
				return upperChars;
			}
			else if (digitalChars.Contains(passwordChar))
			{
				return digitalChars;
			}
			else
			{
				return specialChars;
			}
		}

		private static bool IsMatched(char passwordChar, string charset)
		{
			foreach (char c in charset)
			{
				Console.WriteLine($"[+] Trying... {c}");

				if (c == passwordChar)
				{
					Console.WriteLine($"[+][+] Matched ({c})");
					return true;
				}
			}

			return false;
		}
	}
}