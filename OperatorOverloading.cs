using System;
class NumText
{
    public String num;
    public NumText()
    {}
	public NumText(String number)
	{
		num = number;
	}
	public static NumText operator +(NumText n1, NumText n2)
	{
		NumText sum = new NumText();
		if(n1.num == "One" && n2.num == "Two")
		{
			sum.num = "Three";
		}
		else
		{
			sum.num = "Undefined";
		}
		return sum;

	}
}

class OperatorOverloading
{
	public static void Main()
	{
		NumText n1, n2, n3;
		n1 = new NumText("One");
		n2 = new NumText("Two");
		n3 = n1 + n2;
		Console.WriteLine("The sum of {0} and {1} is {2}", n1.num,n2.num,n3.num);
	}
}