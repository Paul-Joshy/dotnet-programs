using System;
class MatrixMul
{
	public static void Main()
	{
		Console.WriteLine("Enter order of matrices");
		int size = Int32.Parse(Console.ReadLine());

		int [,] a = new int[size,size];
		int [,] b = new int[size,size];
		int [,] c = new int[size,size];

		Console.WriteLine("Enter first matrix contents");
		for(int i=0; i<size; i++)
		{
			for(int j=0; j<size; j++)
			{
				a[i,j] = Int32.Parse(Console.ReadLine());
			}
		}

		Console.WriteLine("First matrix contents updated. Enter second matrix contents");
		for(int i=0; i<size; i++)
		{
			for(int j=0; j<size; j++)
			{
				b[i,j] = Int32.Parse(Console.ReadLine());
			}
		}

		int sum = 0;
		for(int i=0; i<size; i++)
		{
			for(int j=0; j<size; j++)
			{
				for(int k=0; k<size; k++)
				{
					sum = sum + a[i,j] * b[j,k]; 
				}
				c[i,j] = sum;
			}
		}

		Console.WriteLine("The product of both the matrices are as follows");
		for(int i=0; i<size; i++)
		{
			for(int j=0; j<size; j++)
			{
				Console.Write("{0}\t", c[i,j]);
			}
			Console.WriteLine();
		}


	}
}