//Anatomy of a c sharp computer ptogram
/*
sooper impotant things to have
using System;
class name with brackets
public static void Main with brackets inside class body
first rule of fight club: things that have a body dont have a semicolon 
 */

using System;//tip: system is a class hence the captital C
class Anatomy
{
	public static void Main()//You don't have to put string args, also remeember capital M
	{
		//capital C for console as console is a class
		Console.WriteLine("Enter string input");//remainder: SEMICOLONS!!!!
		String s = Console.ReadLine();// Note that the variable is in the left and not the right

		/*
			Data flows from right to left as follows
			first ReadLine gets the input
			then parseInt converts input to integer
			converted value gets stored in int a
			now dont be a dumbfuck and convert to integer when strings are required 
		 */

		Console.WriteLine("Enter integer input");
		int a = Int32.Parse(Console.ReadLine());//its Parse, not parse or ParseInt

		// almost all methods(anything with '()') follows camel case including ReadLine and WriteLine)
		Console.WriteLine("This is a sample output");

		Console.WriteLine(s+a);// see how i used + to concat strings

		//another fancy trick to print variables with text
		Console.WriteLine("I am {0} and i am {1} years old",s,a);
		
	}
}