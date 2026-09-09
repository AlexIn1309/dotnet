/* MINI-MAX SUM */

/* Given five positive integers, find the minimum and maximum values that
 * can be calculated by summing exactly four of the five integers.
 * Then print the respective minimum and maximum values as a single
 * line of two space-separated long integers.*/

/* EXAMPLE
 * arr = [1,3,5,7,9]
 * The minimum sum is 
 * 1 + 3 + 5 + 7 = 16
 * and the maximum sum is
 * 3 + 5 + 7 + 9 = 24.
 * The function prints
 * 16 24*/

/* FUNCTION DESCRIPTION
 * - arr[5]: an array of 5 integers
 * PRINT
 * Print two spaces-integers on one line:
 * the minimum sum and the maximum of 4 of 5 elements.
 * No value should be returned.
 * NOTE: For some languages, like C, C++, and Java,
 * the sums may require that you use a long integer
 * due to their size.*/

/* INPUT FORMAT
 * A single line of five spaces-separated integers.*/
/* CONSTRAINTS
 * 1 <= arr[i] <= 10 a la novena potencia*/

/* SAMPLE INPUT
 * 1 2 3 4 5
 * SAMPLE OUTPUT
 * 10 14*/

/* EXPLANATION
 * The numbers are 1,2,3,4 and 5.
 * Calculate the following sums using
 * four of the five integers:
 * 1. Sum everything except 1. */

using System;
using System.Collections.Generic;
using System.Linq;

class Result
{
	public static void miniMaxSum(List<int> arr){
		long sumaTotal = 0;
		int minimo = arr[0];
		int maximo = arr[0];
		foreach(int numero in arr){
			sumaTotal += numero;
			if(numero < minimo) minimo = numero;
			if(numero > maximo) maximo = numero;
		}
		Console.WriteLine($"{sumaTotal - maximo} {sumaTotal - minimo}");
	}
}

class Program
{
	static void Main(){
		Console.WriteLine("== EJECUTANDO PRUEBAS ==");

		List<int> test1 = [1,2,3,4,5];

		Result.miniMaxSum(test1);
		Result.miniMaxSum([1,3,5,7,9]);
		Result.miniMaxSum([256741038,623958417,467905213,714532089,938071625]);
	}
}
