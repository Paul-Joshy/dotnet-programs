using System;
class MethodOverLoading
{
	public static void twinMethod()
	{
		Console.WriteLine("I am the first twin method");
	}

	public static void twinMethod(int dummyVariable)
	{
		Console.WriteLine("I am the second twin method");
	}

	public static void Main()
	{
		twinMethod();
		twinMethod(1);
	}
}