using System;

namespace BasicEvents
{
	// define the delegate for the event handler
	public delegate void MyEventHandler(string value);

	internal class EventPublisher
	{
		private string _str;

		// declare the event
		public event MyEventHandler ValueChanged; // Action<string> can be used instead of MyEventHandler
		// .Net event handler
		public event EventHandler<ObjChangeEventArgs> ObjChanged;

		public string Str
		{
			set
			{
				_str = value;
				// when the value changes, invoke the events
				ValueChanged?.Invoke(_str);
				ObjChanged?.Invoke(this, new ObjChangeEventArgs { PropChanged = "another event", NewValue = value });
			}
		}
	}

	internal class ObjChangeEventArgs // : EventArgs (explicit inheritance is not necessary if name ends with EventArgs)
	{
		public string PropChanged;
		public string NewValue;
	}

	internal class Program
	{
		private static void Main(string[] args)
		{
			var publisher = new EventPublisher();
			// use a named function as an event handler
			publisher.ValueChanged += ValueChangedHandler;
			// Use a Lambda expression to define an event handler
			publisher.ValueChanged += value => Console.WriteLine($"The value changed to {value} one more time");
			// Note that this is a statement lambda, due to use of { }
			publisher.ValueChanged += x => { Console.WriteLine($"The value changed to {x} (Lambda)"); };
			// use an anonymous delegate as an event handler
			publisher.ObjChanged += delegate (object sender, ObjChangeEventArgs e)
			{
				Console.WriteLine($"{sender.GetType()} had the '{e.PropChanged}' invoked with value '{e.NewValue}'");
			};

			string str;
			do
			{
				Console.WriteLine("Enter a value: ");
				str = Console.ReadLine();
				publisher.Str = str;
			} while (!str.Equals("exit"));
		}

		private static void ValueChangedHandler(string value)
		{
			Console.WriteLine($"The value changed to {value}");
		}
	}
}