using System;
class ExceptionHandling
{
	public static void divide(int x)
	{
		try
		{
			Console.WriteLine(1/x);
		}
		catch(Exception e)
		{
			Console.Write("Caught exception "+e);
		}
		finally
		{
			Console.WriteLine("in divide method");
		}
	}
	public static void Main()
	{
        int x = Int32.Parse(Console.ReadLine());
		try
		{
			divide(x);
		}
		catch(Exception e)
		{
			Console.WriteLine("Caught exception ");
		}
		finally
		{
			Console.WriteLine("in Main method");
		}
	}
}