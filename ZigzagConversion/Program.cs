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

public class Solution {
	public string Convert(string s, int numRows){
		string[] arreglo = new string[numRows];
		int contador = 0;
		bool engrane = true;
		foreach(int elemento in s){
			if(engrane == true)contador++;
			if(engrane == false)contador--;
			if(contador == numRows)engrane=false;
			if(contador == 0)engrane=true;
			
		}
		return s;
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
