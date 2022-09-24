namespace EventsExample
{
	/*Imagine a game where one or more rats can attack a player.
	Each individual rat has an Attack value of 1. However, rats attack as a swarm,so each rat's Attack value is equal to the total number of rats in play.

	Given that the rat enters play through the constructor and leaves play (dies) via its Dispose() method.
	It is needed to implement the Game and Rat classes so that,
	at any point in the game, the Attack value of a rat is always consistent.

	Rules:
	- The Game class cannot have properties or fields. It can only contain events and methods.
	- The Rat class's Attack field is strictly a property with the initial value of 1.*/

	internal class Program
	{
		private static void Main(string[] args)
		{
			var game = new Game();
			var rat1 = new Rat(game, "1");
			var rat2 = new Rat(game, "2");
			var rat3 = new Rat(game, "3");

			#region Test area

			// Test 1: Given3RatsInGame_ThenEachRatsAttackValueEqualsTo3
			TestAttackValueForAllRats("Given3RatsInGame_ThenEachRatsAttackValueEqualsTo3", rat1, rat2, rat3);

			// Test 2: Given3RatsInGame_WhenOneRatDied_ThenEachRatsAttackValueEqualsTo2
			rat3.Dispose();
			rat3 = null;
			TestAttackValueForAllRats("Given3RatsInGame_WhenOneRatDied_ThenEachRatsAttackValueEqualsTo2", rat1, rat2);

			#endregion
		}

		private static void TestAttackValueForAllRats(string testName, params Rat[] ratsInGame)
		{
			foreach (var rat in ratsInGame)
			{
				if (rat.Attack != ratsInGame.Length)
					throw new Exception(
						$"The rats do not have the same attack! Found rat{rat.Id}.Attack = {rat.Attack} should be {ratsInGame.Length}");
			}

			Console.WriteLine($"{testName}: passed successfully!");
		}
	}
}