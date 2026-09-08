/* STAIRCASE */

/* Staircase detail
 * This is a staircase of size n = 4:
 *    #
 *   ##
 *  ###
 * ####
 * 
 * Its base and height are both equal to 'n'.
 * It is drawn using '#' symbol and spaces.
 * The last line is not precededd by any spaces.*/

/* FUNCTION DESCRIPTION
 * - int n: an integer
 * Print
 * Print a staircase as described above.
 * No value should be returned.
 * Note: The last line is not preceded by spaces.
 * All lines are right-aligned.*/

/* INPUT FORMAT
 * A single integer, 'n', denoting the size of the staircase.*/

/* CONSTRAINTS
 * 0 < n <= 100*/

/* EXAMPLE
 * Input: 6
 * Output:
 *      #
 *     ##
 *    ###
 *   ####
 *  #####
 * ######
 *
 * Explanation:
 * The staircase is right-aligned,
 * composed of '#' symbols and spaces,
 * and has a height and width of 'n' = 6.*/

using System;

class Result
{
	public static void staircase(int n)
	{
		for(int i = n; i>=1;i--){
			for(int j = i; j>1;j--){
				Console.Write("E");
			}
			for(int j = i; j<=n;j++){
				Console.Write("#");
			}
			Console.Write("\n");
		}
	}
}

class Program
{
	static void Main(string [] args)
	{
		Console.WriteLine("== EJECUTANDO PRUEBAS LOCAALES ==\n");
		int test1 = 5;
		Result.staircase(test1);
	}
}
