/* 58. Length of Last Word
 * Easy
 * Given a string 's' consisting of words ans spaces,
 * return the length of the last word in the string
 * A word is maximal substring consisting of non-space characters only */

/*
 * Example 1:
 * Input: s = "Hello World"
 * Output: 5
 * Explanation: The last word is "World" with length 5.
 * 
 * Example 2:
 * Input: s = "   fly me   to   the moon  "
 * Output: 4
 * Explanation: The last word is "moon" with length 4.
 *
 * Example 3:
 * Input: s = "luffy is still joyboy"
 * Output: 6
 * Explanation: The last word is "joyboy" with length 6.
 * */

/* CONSTRAINTS
 * - 1 <= s.length <= 10 a la cuarta potenciaa
 * - s consistis of only English letters ans spaces ' '. 
 * - There will be at least one word in 's'.*/

using System;

public class Solution {
    public int LengthOfLastWord(string s) {
		int tamano = s.Length;
		int ultimo = tamano - 1;
		bool encontrado = false;
		int contador = 0;
		for (int i = tamano - 1; i >= 0; i--)
		{
			if (s[i] != ' ')
			{
				encontrado = true;
				contador++;
			}else if (encontrado)
			{
				break;
			}
		}
        return contador;
    }
}

class Program {
    static void Main() {
        Solution sol = new Solution();

        // PRUEBA 1
        string test1 = "sadbutsad";
        Console.WriteLine("--- Prueba 1 ---");
        Console.WriteLine($"Entrada: [{string.Join(", ", test1)}]");

        int k1 = sol.LengthOfLastWord(test1);

        Console.WriteLine($"Conteo devuelto (k): {k1}");
        Console.WriteLine("\n");

        // PRUEBA 2
        string test2 = "   fly me   to   the moon  ";
        Console.WriteLine("--- Prueba 2 ---");
        Console.WriteLine($"Entrada: [{string.Join(", ", test2)}]");

        int k2 = sol.LengthOfLastWord(test2);

        Console.WriteLine($"Conteo devuelto (k): {k2}");
        Console.WriteLine("\n");

        // PRUEBA 3
        string test3 = "luffy is still joyboy";
        Console.WriteLine("--- Prueba 3 (Borrando todos) ---");
        Console.WriteLine($"Entrada: [{string.Join(", ", test3)}]");

        int k3 = sol.LengthOfLastWord(test3);

        Console.WriteLine($"Conteo devuelto (k): {k3}");
        Console.WriteLine("\n");
    }
}
