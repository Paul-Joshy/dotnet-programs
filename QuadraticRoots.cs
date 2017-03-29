/*
	WARNING! MATH AHEAD!!
	basically this program does this
	input values for a, b and c for the equation ax2 * bx + c
	if a = 0 -> not a quadratic equation linear equation
	else
	d = b^2 - 4 * a * c
	if d = 0 -> roots are real and equal
		roots = -b/2a
	if d > 0 -> roots are real and distinct
		r1 = (-b + Vd)/2a
		r2 = (-b - Vd)/2a
	if d < 0 -> roots are imaginary
		r1 = -b/2a
		r2 = V-d/2a
*/	

using System;
class QuadraticRoots
{
	public static void Main()
	{
		Console.WriteLine("Input values (a, b and c)for the equation a*x*x + b*x + c");
		double a = Double.Parse(Console.ReadLine());// noob error: don't write readLine instead of writeLine
		double b = Double.Parse(Console.ReadLine());
		double c = Double.Parse(Console.ReadLine());
		if(a == 0)
		{
			Console.WriteLine("This is a linear equation");
		}
		else
		{
			double r1 = 0.0, r2 = 0.0;
			double d = (b*b) - (4.0*a*c);
			if(d == 0.0)
			{
				Console.WriteLine("Roots are Real and Equal");
				r1 = r2 = (-b) / (2.0*a);
			}
			if(d > 0.0)
			{
				Console.WriteLine("Roots are real and distinct");
				r1 = (-b+Math.Sqrt(d)) / (2.0*a);
				r2 = (-b-Math.Sqrt(d)) / (2.0*a); 
			}
			if(d < 0.0)
			{
				Console.WriteLine("Roots are imaginary");
				r1 = (-b) / (2.0*a);
				r2 = (Math.Sqrt(-d));
			}
			Console.WriteLine("cThe roots are {0} and {1}", r1, r2);
		}
	}

}