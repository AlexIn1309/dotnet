// See https://aka.ms/new-console-template for more information
/* REMOVE DUPLICATES FROM SORTED ARRAYS
 * Easy
 * Given an integer array 'nums' sorte in non-decreasing ordder,
 * remove the duplicates in-place such that each unique element appears only once.
 * The relative order of the elements should be kept the same.
 * Consider the number of unique elements in 'nums' to be 'k'.
 * After removing duplicates, return the number of unique elements k.
 * The first 'k' element of 'nums' should contain the unique numbers in sorted order.
 * The remaining elements beyond index k - 1 can be ignored. */

/* Custom judge:
 * The judge will test your solution with the following code:
 * */

/* EXAMPLE 1
 * Input: nums = [1,1,2]
 * Output: 2, nums = [1,2, _]
 * Explanation: Your function should return k = 2,
 * with the first two elements of nums being 1 and 2 respectively.
 * It does not matter what you leave beyond the returned k (hence they are underscored)*/

/* EXAMPLE 2
 * Input: nums = [0,0,1,1,1,2,2,3,3,4]
 * Output: 5, nums = [0,1,2,3,4,_,_,_,_,_]
 * Explanation: Your function should return k = 5, 
 * with the first five elements of nums being 0, 1, 2, 3, and 4 respectively.
 * It does not matter what you leave beyond the returned k (hence they are underscores).*/

/* Constraints:
 * 1 <= nums.length <= 3 * 10 a la cuarta potencia 
 * -100 <= nums[i] <= 100
 * nums is sorted in non-decreasing order */

using System;

public class Solution {
    public int RemoveDuplicates(int[] nums) {
		// 1. Validamos si el arreglo esta vacio
		if (nums == null || nums.Length == 0)
		{
		    return 0;
		}

		// 2. Inicializamos el puntero de escritura
		int escritura = 1;

		// 3. Recorrer arreglo desde posicion 1
		for (int i = 0; i < nums.Length; i++)
		{
			if (nums[i] != nums[escritura - 1])
			{
				// Valor diferente al anterior, colocarlo en nums[escritura] y avanzamos escritura
			    nums[escritura] = nums[i];
				escritura++;
			}
		}

        return escritura;
    }
}

class Program {
    static void Main() {
        Solution sol = new Solution();

        // ---------------------------------------------------------
        // PRUEBA 1: [1, 1, 2]
        // ---------------------------------------------------------
        int[] test1 = new int[] { 1, 1, 2 };
        Console.WriteLine("--- Prueba 1 ---");
        Console.WriteLine("Entrada original: " + string.Join(", ", test1));

        int k1 = sol.RemoveDuplicates(test1);

        Console.WriteLine($"Conteo devuelto (k): {k1}");
        Console.Write("Arreglo modificado (primeros k): ");
        ImprimirArreglo(test1, k1);
        Console.WriteLine("\n");

        // ---------------------------------------------------------
        // PRUEBA 2: [0, 0, 1, 1, 1, 2, 2, 3, 3, 4]
        // ---------------------------------------------------------
        int[] test2 = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
        Console.WriteLine("--- Prueba 2 ---");
        Console.WriteLine("Entrada original: " + string.Join(", ", test2));

        int k2 = sol.RemoveDuplicates(test2);

        Console.WriteLine($"Conteo devuelto (k): {k2}");
        Console.Write("Arreglo modificado (primeros k): ");
        ImprimirArreglo(test2, k2);
        Console.WriteLine("\n");

        // ---------------------------------------------------------
        // PRUEBA 3: Arreglo de un solo elemento [5]
        // ---------------------------------------------------------
        int[] test3 = new int[] { 5 };
        Console.WriteLine("--- Prueba 3 ---");
        Console.WriteLine("Entrada original: " + string.Join(", ", test3));

        int k3 = sol.RemoveDuplicates(test3);

        Console.WriteLine($"Conteo devuelto (k): {k3}");
        Console.Write("Arreglo modificado (primeros k): ");
        ImprimirArreglo(test3, k3);
        Console.WriteLine();
    }

    // Función auxiliar para imprimir solo los primeros 'k' elementos del arreglo
    static void ImprimirArreglo(int[] arr, int k) {
        Console.Write("[");
        for (int i = 0; i < k; i++) {
            Console.Write(arr[i] + (i < k - 1 ? ", " : ""));
        }
        Console.WriteLine("]");
    }
}
