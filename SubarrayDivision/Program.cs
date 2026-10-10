/* SUBARRAY DIVISION
 * EASY
 * Cathegory: IMPLEMENTATION
 * HACKERANK
 * Two children, Lily and Ron, want to share a chocolate bar. Each of the squares has an
 * integer on it.
 * Lily decides to share a contiguos segment of the bar selected such that:
 * - The length of the segment matches Ron's birth month
 * - The sum of the integers on the squares is equal to his birth day.
 * Determine how many ways she can divide the chocolate.
 * EXAMPLE 
 * s = [2,2,1,3,2]
 * d = 4
 * m = 2
 * Lily wants to find segment summing to Ron's birth day, d = 4 with a length equaling his
 * birth month, m = 2.
 * In this case, there are two segments meeting her criteria: [2,2] and [1,3].*/

/* FUNCTION DESCRIPTION
 * Complete the birthday function in the editor below.
 * Birthday has the following paraameter(s)
 * - int s[n]: the numbers on each of the squares of chocolate
 * - int d: Ron's birth day
 * - int m: Ron's birth month
 * */

/* RETURNS
 * -int: the number of ways the bar can be divided
 * INPUT FORMAT
 * The first line contains an integer n, the number of squares in the chocolate bar
 * The second line contains n space-separated integers s[i], the numbers on the 
 * chocolate squares where 0 <= i <= n
 * The third line contains two space-separated integers, 'd' and 'm'
 * Ron's birthday and his birth month.*/

/* CONSTRAINTS
 * 1 <= n <= 100
 * 1 <= s[i] <= 5, where (0 <= i < n)
 * 1 <= d <= 31
 * 1 <= m <= 12 */

/* SAMPLE INPUT 0
 * 5
 * 1 2 1 3 2
 * 3 2
 * SAMPLE OUTPUT 0
 * 2 
 * EXPLANATION 0
 * Lily wants to give Ron m = 2 squares summing to d = 3.
 * The following two segments meet the criteria.
 *
 * 1 + 2   =   3
 * 1   2   1   3   2
 *     2 + 1 = 3 */

/* SAMPLE INPUT 1
 * 6
 * 1 1 1 1 1
 * 3 2
 * SAMPLE OUTPUT 1
 * 0
 * EXPLANATION 1
 * Lily only wants to give Ron m = 2 consecutive squares of chocolate whose integers sum
 * to d = 3. There are no possible pieces satisfying these constraints:
 *
 * 1   1   1   1   1
 * Thus, we print 0 as our answer */

/* SAMPLE INPUT 2
 * 1
 * 4
 * 4 1
 * SAMPLE OUTPUT 2
 * 1
 * EXPLANATION
 * Lily only wants to give Ron m = 1 squares of chocolate with an integer value of d = 4
 * Because the only square of chocolate in the bar satisfies this constraint,
 * we print 1 as our answer */

using System;
using System.Collections.Generic;

class Result
{
	public static int birthday(List<int> s, int d, int m)
	{
		int contador = 0;
		int tamano = s.Count();
		for(int i = 0; i <= tamano - m; i++){
			List<int> miventana = s[i..(i+m)];
			Console.WriteLine($"Mi ventana es: {miventana[0]}");
			int sumaVentana = miventana.Sum();
			if(sumaVentana == d)contador++;
		}
		return contador;
	}
}

class Program
{
	static void Main()
	{
		Console.WriteLine("== EJECUTANDO PRUEBAS ==");

		List<int> test1 = new() {1,2,1,3,2};
		EjecutarPruebas(test1,3,2,2);

		List<int> test2 = new() {1, 1, 1, 1, 1, 1 };
		EjecutarPruebas(test2,3,2,0);

		List<int> test3 = new() { 2, 2, 2, 2, 2 };
		EjecutarPruebas(test3,4,2,4);

		List<int> test4 = new() { 1, 2, 1, 2, 1 };
		EjecutarPruebas(test4,3,2,4);
	}
	static void EjecutarPruebas(List<int> s, int d, int m, int esperado)
	{
		int resultado = Result.birthday(s,d,m);
		Console.WriteLine(
			$"s=[{string.Join(", ", s)}], " +
			$"d={d}, m={m} | " +
			$"Esperado: {esperado}, " +
			$"Obtenido: {resultado} | " +
			$"{(resultado == esperado ? "OK" : "FALLO")}"
		);
	}
}

