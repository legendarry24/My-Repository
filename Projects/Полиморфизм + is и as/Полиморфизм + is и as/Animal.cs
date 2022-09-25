namespace Polymorphism
{
	internal abstract class Animal
	{
		public string Name { get; set; }
		public string Type { get; protected set; }
		public abstract void GetInfo();
	}
}