/* 67. ADD BINARY
 * EASY
 * Given two binary string 'a' and 'b', return their sum as a binary string. */

/* EXAMPLE 1
 * Input: a = "11", b = "1" 
 * Output: "100" */

/* EXAMPLE 2
 * Input: a = "1010", b = "1011" 
 * Output: "10101" */

/* CONSTRAINTS
 * 1 <= a.length, b.length <= 10 a la cuarta potencia
 * Each string does not contain leading zeros except for the zero itself */

public class Solution {
    public string AddBinary(string a, string b) {
		string resultado = "";
		int indiceA = a.Length - 1;
		int indiceB = b.Length - 1;
		int acarreo = 0;
		int bitA = 0;
		int bitB = 0;
		int suma = 0;
		int bitResultado = 0;
		while (indiceA >= 0 || indiceB >= 0 || acarreo == 1)
		{
		    if (indiceA >= 0){
				 bitA = (int)Char.GetNumericValue(a[indiceA]);
				Console.WriteLine($"Este A {bitA}");
				indiceA--;
		    }else
		    {
		        bitA = 0;
				Console.WriteLine($"Este A {bitA}");
		    }
		    if (indiceB >= 0)
		    {
				 bitB = (int)Char.GetNumericValue(b[indiceB]);
				Console.WriteLine($"Este es B: {bitB}");
				indiceB--;
		    }else
		    {
		        bitB = 0;
				Console.WriteLine($"Este B {bitB}");
		    }
			suma = bitA + bitB + acarreo;
			Console.WriteLine($"La suma de {bitA} + {bitB} = {suma}");
			bitResultado = suma % 2;
			acarreo = suma / 2;
			Console.WriteLine($"El Acarreo es: {acarreo}");
			resultado = Convert.ToString(bitResultado) + resultado;

		}

		return resultado;
    }
}

class Program {
	static void Main(){
		Solution sol = new Solution();
		// Prueba 1
		string binA1 = "11";
		string binB1 = "1";
		Console.WriteLine("-- PRUEBA 1 --");
		Console.WriteLine($"Variable A = \"{binA1}\" AND Variable B = \"{binB1}\"");
		string resultado = sol.AddBinary(binA1,binB1);
		Console.WriteLine($"Resultado es: {resultado} Esperado:100\n");

		// Prueba 2
		string binA2 = "1010";
		string binB2 = "1011";
		Console.WriteLine("-- PRUEBA 2 --");
		Console.WriteLine($"Variable A = \"{binA2}\" AND Variable B = \"{binB2}\"");
		string resultado2 = sol.AddBinary(binA2,binB2);
		Console.WriteLine($"Resultado es: {resultado2} Esperado: 10101\n");
	}
}

