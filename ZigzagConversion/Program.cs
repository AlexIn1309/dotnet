/* Zigzag Conversion 
 * Medium
 * The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: 
 * (you may want to display this pattern in a fixed font for better legibility)
 * P   A   H   N
 * A P L S I I G
 * Y   I   R
 * And then read line by line: "PAHNAPLSIIGYIR"
 * Write the code that will take a string and make this conversion given a number of rows:
 * string conversion(string s, int numRows);
 * EXAMPLE 1
 * Input: s "PAYPALISHIRING", numRows = 3
 * Output: "PAHNAPLSIIGYIR"
 *
 * EXAMPLE 2
 * Input: s "PAYPALISHIRING", numRows = 4
 * Output: "PINALSIGYAHRPI"
 * Explanation: 
 * P     I     N
 * A   L S   I G
 * Y A   H R
 * P     I
 * 
 * EXAMPLE 3
 * Input: s = "A", numRows = 1
 * Output: "A"
 *
 * Constraints
 * - 1 <= s.lenght <= 1000
 * - s consists of English letters (lower-case and upper-case), ',' and '.'
 * - 1 <= numRows <= 1000 */

using System;
using System.Text;

public class Solution {
	public string Convert(string s, int numRows){
		if(numRows == 1 || s.Length <= numRows)return s;

		StringBuilder[] filas = new StringBuilder[numRows];
		for(int i = 0; i < numRows; i++){
			filas[i] = new StringBuilder();
		}

		int actual = 0;
		bool engrane = false;
		foreach(char elemento in s){
			filas[actual].Append(elemento);

			if(actual == 0 || actual == numRows - 1) engrane = !engrane;

			actual += engrane ? 1: -1;
		}
		StringBuilder resultado = new StringBuilder();
	   	foreach(StringBuilder fila in filas) resultado.Append(fila);
			
		return resultado.ToString();
	}
}


class Program
{
	static void Main()
	{
		Solution sol = new Solution();
		Console.WriteLine("== EJECUTANDO PRUEBAS ==");
		string cadena1 = "PAYPALISHIRING";
		int nuRos1 = 3;
		Console.WriteLine($"PRUEBA 1: {cadena1} NUMROWS: {nuRos1}");
		string k1 = sol.Convert(cadena1, nuRos1);
		Console.WriteLine($"Cadena Modificada es: {k1}");
	}
}
