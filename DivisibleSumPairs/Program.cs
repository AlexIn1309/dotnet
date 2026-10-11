/* DIVISIBLE SUM PAIRS
 * EASY
 * HACKERANK
 * Cathegory: Implementation
 * Given an array of integers and a positive integer k,
 * determine the number of (i,j) pairs where i < j 
 * and ar[i] + ar[j] is divisble by k */

/* EXAMPLE
 * ar = [1,2,3,4,5,6] 
 * k = 5 
 * Three pairs meet the criteria: [1,4],[2,3], and [4,6]
 * FUNCTION DESCRIPTION
 * - int n: the length of array ar
 * - int ar[n]: an array of integers
 * - int k: the integer divisor 
 * RETURNS
 * - int: the number of pairs
 * INTPUT FORMAT
 * The first line contains 2 space-separated integers, n and k
 * The second line contains n space-separated integers, each value of arr[i]
 * CONSTRAINTS
 * - 2 <= n <= 100
 * - 1 <= k <= 100
 * - 1 <= ar[i] <= 100*/

/* SAMPLE INPUT
 * 63
 * 1 3 2 6 1 2 
 * SAMPLE OUTPUT
 * 5
 * EXPLANATION
 * Here are the 5 valid pairs when k = 3
 * - (0,2) -> ar[0] + ar[2] = 1 + 2 = 3
 * - (0,5) -> ar[0] + ar[5] = 1 + 2 = 3
 * - (1,3) -> ar[1] + ar[3] = 3 + 6 = 9
 * - (2,4) -> ar[2] + ar[4] = 2 + 1 = 3
 * - (4,5) -> ar[4] + ar[5] = 1 + 2 = 3
 * */

class Result
{
	public static int divisibleSumPairs(int n, int k, List<int> ar)
	{
		int contador = 0;
		for(int i = 0; i < n; i++){
			for(int j = i + 1; j < n; j++){
				if((ar[i] + ar[j]) % k == 0){
					contador++;
				}
			}
		}
		return contador;
	}
}

class Program
{
	static void Main()
	{
		Console.WriteLine("== EJECUTANDO PRUEBAS ==");

		List<int> test1 = new() {1,3,2,6,1,2};
		int n1 = 6, k1 = 3;
		EjecutarPruebas(test1,n1,k1,5);

	}

	static void EjecutarPruebas(List<int> test, int n, int k, int esperado)
	{
		int resultado = Result.divisibleSumPairs(n,k,test);
		Console.WriteLine(
			$"test=[{String.Join(",",test)}], " +
			$"n=[{n}, k={k}] | " +
			$"Esperado: {esperado} " +
			$"Obtenido: {resultado} | " +
			$"{(resultado == esperado ? "OK" : "FALLO" )}"
		);
	}
}
