namespace EventsExample;

// remember - no fields or properties!
public class Game
{
	public event Action<Rat>? RatEntered;

	public event Action? RatDied;

	public void CreateRat(Rat rat)
	{
		RatEntered?.Invoke(rat);
	}

	public void KillRat()
	{
		RatDied?.Invoke();
	}
}