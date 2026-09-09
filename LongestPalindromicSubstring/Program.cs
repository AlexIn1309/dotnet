/* 5. Longest Palindromic Substring
 * Medium
 * Given a string 's', return the longest palindromic substring in 's'*/

/* EXAMPLE 1
 * Input: s = "babad"
 * Output: "bab"
 * Explanation: "aba" is also a vali answer.*/


/* EXAMPLE 2
 * Input: s = "cbbd"
 * Output: "bb" */

/* CONSTRAINTS
 * 1 <= s.length <= 1000
 * 's' consist of only digits and English letters.*/

public class Solution {
	public string LongestPalindrome(string s) {
		if(s.Length == 0 || s.Length == 1)return s;
		int grandeIzquierda = 0;
		int grandeDerecha = 1;
		int grandeLongitud = 1;
		int i = 0;
		while(i < s.Length){
			int izquierda = i -1;
			int derecha = i +1;
			int longitud = 1;
			while(izquierda >= 0 && derecha < s.Length){
				Console.WriteLine($"Izquierda: {s[izquierda]}");
				Console.WriteLine($"Centro: {s[i]}");
				Console.WriteLine($"Derecha: {s[derecha]}");
				if(s[izquierda] == s[derecha]){
					Console.WriteLine($"Son iguales: {s[izquierda]} y {s[derecha]}");
					Console.WriteLine($"Grande Izquierda es {grandeIzquierda} y izquierda es: {izquierda}");
					Console.WriteLine($"Grande Derecha es {grandeDerecha} y derecha es: {derecha}");
					longitud+=2;
					if(longitud > grandeLongitud){
						grandeIzquierda= izquierda;
						grandeDerecha= derecha+1;
						grandeLongitud = longitud;
					}
					izquierda--;
					derecha++;
				}else{
					break;
				}
			}
			longitud = 0;
			izquierda = i;
			derecha = i +1;
			while(izquierda >= 0 && derecha < s.Length){
				Console.WriteLine($"Par -> Izquierda: {s[izquierda]}");
				Console.WriteLine($"Par -> Derecha: {s[derecha]}");
				if(s[izquierda] == s[derecha]){
					Console.WriteLine($"Par -> Son iguales: {s[izquierda]} y {s[derecha]}");
					Console.WriteLine($"PAR -> Grande Izquierda es {grandeIzquierda} y izquierda es: {izquierda}");
					Console.WriteLine($"PAR -> Grande Derecha es {grandeDerecha} y derecha es: {derecha}");
					longitud+=2;
					if(longitud > grandeLongitud){
						grandeIzquierda= izquierda;
						grandeDerecha= derecha + 1;
						grandeLongitud = longitud;
					}

					izquierda--;
					derecha++;
				}else{
					break;
				}
			}
			Console.WriteLine("-- Siguiente Centro --");
			i++;
		}
		string nuevo = s[grandeIzquierda..grandeDerecha];
		return nuevo;
	}
}

class Program{
	static void Main(){
		Solution sol = new Solution();

		// Prueba 1
		string test1 = "babad";
		Console.WriteLine("-- Prueba 1 --");
		Console.WriteLine($"Entrada: {test1}");
		Console.WriteLine("Esperado: bab o aba");

		string k1 = sol.LongestPalindrome(test1);

		Console.WriteLine($"Resultado: {k1}");

		Console.WriteLine("\n");

		// Prueba 2
		string test2 = "cbbd";
		Console.WriteLine("-- Prueba 2 --");
		Console.WriteLine($"Entrada: {test2}");
		Console.WriteLine($"Esperado: bb");

		string k2 = sol.LongestPalindrome(test2);
		
		Console.WriteLine($"Resultado: {k2}");

		Console.WriteLine("\n");

		// Prueba 3
		string test3 = "a";
		Console.WriteLine("-- Prueba 3 --");
		Console.WriteLine($"Entrada: {test3}");
		Console.WriteLine($"Esperado: a");

		string k3 = sol.LongestPalindrome(test3);
		
		Console.WriteLine($"Resultado: {k3}");

		Console.WriteLine("\n");


		// Prueba 4
		string test4 = "ac";
		Console.WriteLine("-- Prueba 4 --");
		Console.WriteLine($"Entrada: {test4}");
		Console.WriteLine($"Esperado: a");

		string k4 = sol.LongestPalindrome(test4);
		
		Console.WriteLine($"Resultado: {k4}");

		Console.WriteLine("\n");

		// Prueba 5
		string test5 = "ccc";
		Console.WriteLine("-- Prueba 5 --");
		Console.WriteLine($"Entrada: {test5}");
		Console.WriteLine($"Esperado: ccc");

		string k5 = sol.LongestPalindrome(test5);
		
		Console.WriteLine($"Resultado: {k5}");

		Console.WriteLine("\n");
	}
}
