using System;
interface Mother
{
	void motherMethod();
}
interface Father
{
	void fatherMethod();
}
class Child: Mother, Father
{
	public void motherMethod()
	{
		Console.WriteLine("Yo mama");
	}
	public void fatherMethod()
	{
		Console.WriteLine("Luke i am your father");
	}
}
class InterfaceProgram
{
	public static void Main()
	{
        Child c = new Child();
		c.motherMethod();
		c.fatherMethod();
	}
}