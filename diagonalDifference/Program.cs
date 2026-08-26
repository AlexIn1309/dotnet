using System;
using System.Collections.Generic;

class Result
{
    /*
     * Completa la función 'diagonalDifference' a continuación.
     *
     * Se espera que retorne un INTEGER.
     * Acepta un 2D_INTEGER_ARRAY arr como parámetro.
     */
	public static int diagonalDifference(List<List<int>> arr)
	{
		int tamano = arr.Count();
		int sumaA = 0;
		int sumaB = 0;
		for(int i = 0; i < tamano; i++){
			for(int j = 0; j < tamano; j++){
					Console.WriteLine($"i es: {i}");
					Console.WriteLine($"j es: {j}");
				if(j == i ){
					Console.WriteLine($"Primera diagonal: {arr[i][j]}");
					sumaA += arr[i][j];
				}
				if(i + j == (tamano - 1) ){
					Console.WriteLine($"Segunda diagonal: {arr[i][j]}");
					sumaB += arr[i][j];
				}
			}
		}
		int resultado = sumaA - sumaB;
		if(resultado < 0) return sumaB - sumaA;
		return sumaA - sumaB;
	}
}

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("=== EJECUTANDO PRUEBAS LOCALES ===\n");
        // Prueba 1: Ejemplo estándar 3x3
        // Diagonal 1: 1 + 5 + 9 = 15
        // Diagonal 2: 3 + 5 + 9 = 17
        // Diferencia absoluta: |15 - 17| = 2
        var test1 = new List<List<int>>
        {
            new List<int> { 1, 2, 3 },
            new List<int> { 4, 5, 6 },
            new List<int> { 7, 8, 9 }
        };
        RunTest("Prueba 1 (Matriz 3x3)", test1, expected: 2);

        // Prueba 2: Números negativos y positivos
        // Diagonal 1: 11 + 5 + (-12) = 4
        // Diagonal 2: 4 + 5 + 10 = 19
        // Diferencia absoluta: |4 - 19| = 15
        var test2 = new List<List<int>>
        {
            new List<int> { 11,  2,   4 },
            new List<int> {  4,  5,   6 },
            new List<int> { 10,  8, -12 }
        };
        RunTest("Prueba 2 (Con negativos)", test2, expected: 15);

        // Prueba 3: Matriz 1x1 (Borde mínimo)
        // Diagonal 1: 42
        // Diagonal 2: 42
        // Diferencia absoluta: |42 - 42| = 0
        var test3 = new List<List<int>>
        {
            new List<int> { 42 }
        };
        RunTest("Prueba 3 (Matriz 1x1)", test3, expected: 0);

        // Prueba 4: Matriz 4x4
        // Diagonal 1: 1 + 6 + 11 + 16 = 34
        // Diagonal 2: 4 + 7 + 10 + 13 = 34
        // Diferencia absoluta: |34 - 34| = 0
        var test4 = new List<List<int>>
        {
            new List<int> {  1,  2,  3,  4 },
            new List<int> {  5,  6,  7,  8 },
            new List<int> {  9, 10, 11, 12 },
            new List<int> { 13, 14, 15, 16 }
        };
        RunTest("Prueba 4 (Matriz 4x4)", test4, expected: 0);

        // Prueba 5: Matriz con ceros y valores mixtos
        // Diagonal 1: -5 + 0 + 7 = 2
        // Diagonal 2: 10 + 0 + -3 = 7
        // Diferencia absoluta: |2 - 7| = 5
        var test5 = new List<List<int>>
        {
            new List<int> { -5,  0, 10 },
            new List<int> {  0,  0,  0 },
            new List<int> { -3,  0,  7 }
        };
        RunTest("Prueba 5 (Ceros y mixtos)", test5, expected: 5);
    }

    static void RunTest(string testName, List<List<int>> matrix, int expected)
    {
        int actual = Result.diagonalDifference(matrix);
        bool passed = actual == expected;
        string status = passed ? "[PASÓ]" : "[FALLÓ]";

        Console.WriteLine($"{status} {testName}");
        Console.WriteLine($"   Obtenido: {actual} | Esperado: {expected}\n");
    }
}
