namespace EventsExample;

public class Rat : IDisposable
{
	private readonly Game _game;

	public string Id { get; }

	public int Attack { get; private set; } = 1;

	public Rat(Game game, string id)
	{
		_game = game;
		Id = id;

		_game.RatEntered += IncreaseDamage;
		_game.RatDied += DecreaseDamage;
		_game.CreateRat(this);
	}

	public void Dispose()
	{
		_game.KillRat();
	}

	private void IncreaseDamage(Rat rat)
	{
		if (this.Id != rat.Id)
		{
			this.Attack++;
			rat.Attack++;
		}
	}

	private void DecreaseDamage()
	{
		this.Attack--;
	}
}