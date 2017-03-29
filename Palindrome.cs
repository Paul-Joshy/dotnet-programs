/*
sooper impotant things to have
using System;
class name with brackets
public static void Main with brackets inside class body
first rule of fight club: things that have a body dont have a semicolon 
 */
using System;
class Palindrome
{
	public static void Main()
	{
		/*
			Don't bother initialising the variable first.
			Try to figure that out by writing the program
		 */
		Console.WriteLine("Enter a number");
		int num = Int32.Parse(Console.ReadLine());
		int n = num; //This baby is going to become 0 so we need backup
		int rev = 0; //rev is initialised with 0 first cuz you cant multiply 10 to null you dumb bitch
		Console.WriteLine(n);
		while(n!=0)// checking is still = if it is preceeded by !
		{
			/*
				WHAT HAPPENS HERE?
				the last digit is taken from n and put in r
				r is concatinated with rev
				the last digit of n is cut off
			 */
			 int r = n%10; // %10 gets the last digit of n
			 rev = rev*10+r; // the last digit is concatenated to rev
			 /*
			 	WHY MULTIPLY 10 TO rev
				it gives rev an extra 0 to add the last digit too
				also make sure 
					-all these variables are initialised
					-rev is initialised with 0 first cuz you cant multiply 10 to null you dumb bitch 
			  */
			n = n/10; /*because:-
				-it will result in an infinite loop otherwise
				-n needs to keep cutting off its last digits
				-or the same last digit will go to r again and again */
		}
		if(num == rev)// = for assigning, == for checking
		{
			Console.WriteLine("{0} is a Palindrome", rev);// num and rev are the same if it is a palinrome
		}
		else
		{
			Console.WriteLine("{0} is not a palindrome", num);
		}
	}
}