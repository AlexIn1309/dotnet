/* CATS AND A MOUSE
 * EASY
 * Cathegory: Implementation
 * HackerRank
 *
 * Two cats and a mouse are at various positions on a line. You will be given
 * their starting positions. Your task is to determine which cat will reach
 * the mouse first, assuming the mouse does not move and the cats travel
 * at equal speed. If the cats arrive at the same time, the mouse will be
 * allowed to move and it will escape while they fight. */

/* You are given 'q' queries in the form of x, y and z representing the 
 * respective position for cats 'A' and 'B' and for mouse 'C'.
 * Complete the function catAndMouse to return the appropriate answer to each
 * query, which will be printed on a new line.
 * - If cat A catches the mouse first, print Cat A
 * - If cat B catches the mouse first, print Cat B
 * - If both cats reach the mouse at the same time, print 'Mouse C'
 * as the two cats fight and mouse escape */

/* EXAMPLE 
 * x = 2
 * y = 5
 * z = 4
 * The cats are at position 2 (Cat A) and 5 (Cat B) and the mouse is at position 4.
 * Cat B, at position 5 will arrive first since it is only 1 unit away while the 
 * other is 2 units away. Return 'Cat B'*/

/* FUNCTION DESCRIPTION
 * - int x: Cat A's position 
 * - int y: Cat B's position 
 * - int z: Mouse C's position 
 * RETURNS 
 * - string: Either 'Cat A', 'Cat B' or 'Mouse C'
 * INPUT FORMAT
 * The first line contains a single integer 'q', denoting the number 
 * of queries
 * Each of the 'q' subsequent lines contains three space-separated integers 
 * describing the respective values of 'x' (cat A's location),
 * 'y' (cat A's location) and 'z' (mouse C's location)*/

/* CONSTRAINTS
 * - 1 <= q <= 100
 * - 1 <= x,y,z <= 100  */

/* SAMPLE INPUT 0
 * 2
 * 1 2 3
 * 1 3 2
 * SAMPLE OUTPUT 0
 * Cat B
 * Mouse C
 * EXPLANATION 0
 * Query 0: The positions of the cats and mouse are shown below
 *|0|1|CAT B|3|4
 * 0   1   2   3   4  -> 
 *|0|CAT A|2|Mouse C|4| 
 * */

/* Cat B will catch the mouse first, so we print Cat B on a new line
 * 	Mouse C
 * 0   1   2   3   4  -> 
 *|0|CAT A|2|CAT B|4|  */

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System;

class Solution {
	// Complete the catAndMouse function below.
	static string catAndMouse(int x, int y, int z) {
		int distanciaA = Math.Abs(x - z);
		int distanciaB = Math.Abs(y - z);
		if(distanciaA < distanciaB) return "Cat A";
		if(distanciaA > distanciaB) return "Cat B";
		return "Mouse C";
	}

	static void Main(string[] args) {
		Console.WriteLine("== EJECUTANDO PRUEBAS ==");
		EjecutarPruebas(1,2,3,"Cat B");
		EjecutarPruebas(1,3,2,"Mouse C");
		EjecutarPruebas(2,5,4,"Mouse C");
		EjecutarPruebas(10,20,15,"Mouse C");
		EjecutarPruebas(1,9,5,"Mouse C");
		EjecutarPruebas(5,5,5,"Mouse C");
		EjecutarPruebas(21,95,58,"Mouse C");
	}

	static void EjecutarPruebas(int x, int y, int z, string esperado)
	{
		string resultado = catAndMouse(x,y,z);
		Console.WriteLine(
			$"x = {x}\n" +
			$"y = {y}\n" +
			$"z = {z}\n" +
			$"Esperado: {esperado} \n" +
			$"Obtenido: {resultado} \n" +
			$"{(resultado == esperado ? "Ok\n":"Fallo")}"
		);
	}
}

