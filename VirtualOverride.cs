using System;
class Parent
{
	public void regularMethod()
	{
		Console.WriteLine("I am the regular parent method");
	}
	public virtual void ultaMethod()
	{
		Console.WriteLine("I am the virtual/override parent method");
	}
}

class Child:Parent
{
	public void regularMethod()
	{
		Console.WriteLine("I am the regular child method");
	}

	public override void ultaMethod()
	{
		Console.WriteLine("I am the virtual/override child method");
	}
}

class VirtualOverride
{
	public static void Main()
	{
		Child c = new Child();
		Console.WriteLine("This is the case of regular method");
		c.regularMethod();
		Console.WriteLine();

		Console.WriteLine("This is the case of an override/virtual method");
		c.ultaMethod();
	}
}