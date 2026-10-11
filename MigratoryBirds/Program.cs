/* MIGRATORY BIRDS
 * - EASY
 * - Cathegory: IMPLEMENTATION
 * - HACKERANK
 * Given an array of birds sightings where every element represents a bird type id,
 * determine the id of the most frequently sighted type. If more than 1 type
 * has been spotted that maximum amount, return the smallest of their ids */

/* EXAMPLE
 * arr = [1,1,2,2,3]
 * There are two each of types 1 and 2, and one	sighting of type 3.
 * Pick the lower of the two types seen twice: type 1  */

/* FUNCTION DESCRIPTION
 * - int arr[n]: the types of birds sighted
 * RETURNS
 * - int: the lowest type id of the most frequently sighted birds
 * INPUT FORMAT
 * The first line contains an integer, n the size of 'arr'
 * The second line describes the 'arr' as n space-separated integers,
 * each a type number of the bird sighted  */

/* CONSTRAINTS
 * 5 <= n <= 2 x 10^5
 * It is guaranteed that each type is 1,2,3,4 or 5
 * SAMPLE INPUT 0
 * 6
 * 1 4 4 4 5 3
 * SAMPLE OUTPUT
 * 4
 * EXPLANATION 0
 * The different types of birds occur in the following frequencies
 * - Type 1: 1 bird
 * - Type 2: 0 bird
 * - Type 3: 1 bird
 * - Type 4: 3 bird
 * - Type 5: 1 bird 
 * The type number that occurs at the highest frequency is type 4,
 * so we print 4 as our answer */

/* SAMPLE INPUT 1
 * 11
 * 1 2 3 4 5 4 3 2 1 3 4
 * SAMPLE OUTPUT 1
 * 3
 * EXPLANATION 1
 * The different types of birds occur in the following frequencies:
 * - Type 1: 2 bird
 * - Type 2: 2 bird
 * - Type 3: 3 bird
 * - Type 4: 3 bird
 * - Type 5: 1 bird
 * The types have a frequency of 3,and the lower of those is type 3 
 *  */

using System;

class Result
{
	public static int migratoryBirds(List<int> arr)
	{
		List<int> frecuencias = [0,0,0,0,0,0];
		foreach(int numero in arr){
			frecuencias[numero]++;
		}
		int maximaFrecuencia = frecuencias.Max();
		int indice = frecuencias.IndexOf(maximaFrecuencia);
		return indice;
	}
}

class Program
{
	static void Main()
	{
		Console.WriteLine("== EJECUTANDO PRUEBAS ==");
		List<int> test1 = new() {1,2,3,4,5,4,3,2,1,3,4};
		EjecutarPruebas(test1,3);
	}

	static void EjecutarPruebas(List<int> test,int esperado)
	{
		int resultado = Result.migratoryBirds(test);
		Console.WriteLine(
			$"test=[{String.Join(", ",test)}], " +
			$"Esperado: {esperado}, " +
			$"Recibido: {resultado} | " +
			$"{(resultado == esperado?"OK":"FALLO")}"
		);
	}
}
