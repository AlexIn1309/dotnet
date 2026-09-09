/* PLUS MINUS */

/* Given an array of integers, calculate the ratios of its elements
 * that are positive, negative, and zero. Print the decimaal value
 * of each fraction on a new line with 6 places after the decimal
 * Note: This challenge introduces precision problems. The test cases
 * are scaled to six decimal places, though answars with absolute
 * error of up to 10^4 are acceptable. */

/* EXAMPLE
 * arr = [1,1,0,-1,-1]
 * Tere are n = 5 elements: two positive, two negative and one zero.
 * Their ratios are 2/5 = 0.4000000.
 * 2/5 = 0.4000000 and 1/5 = 0.2000000. Results are printed as:
 * 0.4000000
 * 0.4000000
 * 0.2000000*/

/* FUNCTION DESCRIPTION
 * - int arr[n]: an array of integers.*/

/* PRINT
 * Print the ratios of positive, negative and zero values in the array.
 * Each value should be printed on a separate line with 6 digits after
 * the decimal. The function should not return a value.*/

/* INPUT FORMAT
 * The first line contains an integer 'n', the size of the array
 * The second line contains n space-separated integers that describe arr[n]*/

using System;
using System.Collections.Generic;
using System.Linq;

class Result
{
	public static void plusMinus(List<int> arr)
	{
		double positivos = 0;
		double negativos = 0;
		double zero = 0;
		double tamano = arr.Count();
		foreach(int element in arr){
			if(element > 0)positivos++;
			if(element < 0)negativos++;
			if(element == 0)zero++;
		}
		Console.WriteLine($"Positivos: {positivos/tamano:F6}");
		Console.WriteLine($"Negativos: {negativos/tamano:F6}");
		Console.WriteLine($"Zero: {zero/tamano:F6}");
	}
}

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("== EJECUTANDO PRUEBAS LOCALES ==\n");
		List<int> test1 = new List<int> {1,1,0,-1,-1};
		RunTest("Prueba 1 Arreglo", test1);

		List<int> test2 = new List<int> {-4,3,-9,0,4,1};
		RunTest("Prueba 2 Arreglo", test2);
	}

	static void RunTest(string testname, List<int> arreglo)
	{
		Console.WriteLine($"-- {testname} --\n");
		Result.plusMinus(arreglo);
		Console.WriteLine();
	}
}

