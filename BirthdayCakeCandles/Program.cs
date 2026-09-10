/* BIRTHDAY CAKE CANDLES */

/* You are in charge of the cake for a child's birthday.
 * It will hace one candle for each year of their total age.
 * They will only be able to blow out the tallest of the 
 * candles. Your task is to count how many candles are the tallest.*/

/* EXAMPLE
 * candles = [4,4,1,4]
 * The tallest candles are 4 units high.
 * There are 2 candles with this height,
 * so the function should return 2.*/


using System;
using System.Collections.Generic;
using System.Linq;

class Result
{
	public static int birthdayCakeCandles(List<int> candles){
		int tallest = 0;
		int maximo = candles[0];
		foreach(int candl in candles){
			if(candl > maximo){
				maximo = candl;
				tallest = 0;
			}
			if(candl == maximo)tallest++;
		}
		return tallest;
	}
}

class Program
{
	static void Main(){
		Console.WriteLine("== EJECUTANDO PRUEBAS ==");

		List<int> test1 = [3,2,1,3];

		Console.WriteLine("-- PRUEBA 1 --");
		int k1 = Result.birthdayCakeCandles(test1);
		Console.WriteLine($"El resultado es: {k1}");
		Console.WriteLine("Esperado: 2\n");

		Console.WriteLine("-- PRUEBA 2 --");
		int k2 = Result.birthdayCakeCandles([4,4,1,3]);
		Console.WriteLine($"El resultado es: {k2}");
		Console.WriteLine("Esperado: 2\n");

		Console.WriteLine("-- PRUEBA 2 --");
		int k3 = Result.birthdayCakeCandles([18,90,90,13,90,75,90,8,90,43]);
		Console.WriteLine($"El resultado es: {k3}");
		Console.WriteLine("Esperado: 5\n");

	}
}
 
