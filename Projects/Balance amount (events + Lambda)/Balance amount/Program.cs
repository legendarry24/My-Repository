using System;

namespace Balance_amount
{
	public delegate void MyEventHandler();

	internal static class Bank
	{
		private static decimal _balance;

		public static decimal Balance
		{
			get => _balance;
			set
			{
				_balance = value;
				BalanceChanged?.Invoke();   // invoke event when private fields value changes
			}
		}
		public static event MyEventHandler BalanceChanged;
	}

	internal class Program
	{
		private static void Main(string[] args)
		{
			// use an anonymous delegate as an event handler
			Bank.BalanceChanged += delegate // without () cuz no parameters
			{
				Console.WriteLine($"The balance amount is {Bank.Balance}");
			};
			// use a lambda function as an event handler
			Bank.BalanceChanged += () =>
			{
				if (Bank.Balance > 500)
					Console.WriteLine($"You reached your savings goal! You have {Bank.Balance}");
			};

			while (true)
			{
				Console.WriteLine("How much to deposit?");
				string input = Console.ReadLine();
				if (input == "exit")
					break;
				Bank.Balance += Convert.ToDecimal(input);
			}
		}
	}
}