/* 35. SEARCH INSERT POSITION
 * Easy
 * Given a sorted array of distinct integers and a target value, 
 * return the index if the target is found. If not,
 * return the index where it would be if it were inserted in order.*/

/* You must write an algorithm with '0(log n)' runtime complexity. */

/* EXAMPLE 1
 * Input nums = [1,3,5,6], target = 5
 * Output: 2*/

/* EXAMPLE 2
 * Input nums = [1,3,5,6], target = 2
 * Output: 1*/

/* EXAMPLE 3
 * Input nums = [1,3,5,6], target = 7
 * Output: 4*/

using System;

public class Solution {
    public int SearchInsert(int[] nums, int target) {
		int inferior = 0;
		int superior = nums.Length - 1;


		while(inferior <= superior ){
			int mitad = inferior + (superior - inferior)/2;

			if (nums[mitad] == target)
			{
				return mitad;
			} else if (nums[mitad]> target){
			    superior = mitad - 1;
			} else {
			    inferior = mitad + 1;
			}
		}
		return inferior;
    }
}

class Program {
    static void Main() {
        Solution sol = new Solution();

        // ---------------------------------------------------------
        // PRUEBA 1: [3, 2, 2, 3], val = 3
        // ---------------------------------------------------------
        int[] test1 = new int[] { 1, 3, 5, 6 };
        int val1 = 5;
        Console.WriteLine("--- Prueba 1 ---");
        Console.WriteLine($"Entrada: [{string.Join(", ", test1)}], val = {val1}");

        int k1 = sol.SearchInsert(test1, val1);

        Console.WriteLine($"Conteo devuelto (k): {k1}");
        Console.Write("Arreglo modificado (primeros k): ");
        ImprimirArreglo(test1, k1);
        Console.WriteLine("\n");

        // ---------------------------------------------------------
        // PRUEBA 2: [0, 1, 2, 2, 3, 0, 4, 2], val = 2
        // ---------------------------------------------------------
        int[] test2 = new int[] { 1, 3, 5, 6 };
        int val2 = 2;
        Console.WriteLine("--- Prueba 2 ---");
        Console.WriteLine($"Entrada: [{string.Join(", ", test2)}], val = {val2}");

        int k2 = sol.SearchInsert(test2, val2);

        Console.WriteLine($"Conteo devuelto (k): {k2}");
        Console.Write("Arreglo modificado (primeros k): ");
        ImprimirArreglo(test2, k2);
        Console.WriteLine("\n");

        // ---------------------------------------------------------
        // PRUEBA 3: Todos los elementos son 'val' -> [1, 1, 1], val = 1
        // ---------------------------------------------------------
        int[] test3 = new int[] { 1, 3, 5, 6 };
        int val3 = 4;
        Console.WriteLine("--- Prueba 3 (Borrando todos) ---");
        Console.WriteLine($"Entrada: [{string.Join(", ", test3)}], val = {val3}");

        int k3 = sol.SearchInsert(test3, val3);

        Console.WriteLine($"Conteo devuelto (k): {k3}");
        Console.Write("Arreglo modificado (primeros k): ");
        ImprimirArreglo(test3, k3);
        Console.WriteLine("\n");

        // ---------------------------------------------------------
        // PRUEBA 4: Ningún elemento coincide -> [4, 5, 6], val = 2
        // ---------------------------------------------------------
        int[] test4 = new int[] { 1, 3, 5, 6 };
        int val4 = 4;
        Console.WriteLine("--- Prueba 4 (Sin coincidencias) ---");
        Console.WriteLine($"Entrada: [{string.Join(", ", test4)}], val = {val4}");

        int k4 = sol.SearchInsert(test4, val4);

        Console.WriteLine($"Conteo devuelto (k): {k4}");
        Console.Write("Arreglo modificado (primeros k): ");
        ImprimirArreglo(test4, k4);
        Console.WriteLine();
    }

    // Función auxiliar para imprimir solo los primeros 'k' elementos válidos
    static void ImprimirArreglo(int[] arr, int k) {
        Console.Write("[");
        for (int i = 0; i < k; i++) {
            Console.Write(arr[i] + (i < k - 1 ? ", " : ""));
        }
        Console.WriteLine("]");
    }
}
