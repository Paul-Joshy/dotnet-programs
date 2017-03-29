using System;
class RevString
{
	public static void Main()
	{
		Console.WriteLine("Enter String");
		String s = Console.ReadLine();
		String rev = "";
		int length = s.Length -1;
		for(int i=length; i>=0; i--)
		{
			rev = rev + s[i];
		}
		Console.WriteLine("The reverse of {0} is {1}", s,rev);
	}
}