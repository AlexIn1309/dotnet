/* 27. REMOVE ELEMENT 
 * Easy
 * Given an integer array 'nums' and a integer val,
 * remove all occurrences of 'val' in 'nums' in-place.
 * The order of the elements maybe changed.
 * Then return the number of the elements in 'nums' 
 * which are not equal to 'val'.*/

/* Consider the number of elements in 'nums' 
 * which are not equal to 'val' be 'k',
 * to get accepted,
 * you need need to do the following things.*/

/* Change the array 'nums' such that the first 'k' elements of
 * 'nums' contain the elements which are not equal to 'val'.
 * The remaining elements of 'nums' are not important as well as the size of nusm.*/

/* Return 'k'. */

/* EXAMPLE 1
 * Input: nums = [3,2,2,3], val = 3
Output: 2, nums = [2,2,_,_]
Explanation: Your function should return k = 2, with the first two elements of nums being 2.
It does not matter what you leave beyond the returned k (hence they are underscores). */

/* EXAMPLE 2
 * Input: nums = [0,1,2,2,3,0,4,2], val = 2
Output: 5, nums = [0,1,4,0,3,_,_,_]
Explanation: Your function should return k = 5, with the first five elements of nums containing 0, 0, 1, 3, and 4.
Note that the five elements can be returned in any order.
It does not matter what you leave beyond the returned k (hence they are underscores).*/

using System;

public class Solution {
    public int RemoveElement(int[] nums, int val) {
		if (nums == null || nums.Length == 0)
		{
		    return 0;
		}

		int escritura = 0;

		for (int i = 0; i < nums.Length; i++)
		{
		    if (nums[i] != val)
		    {
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
        // PRUEBA 1: [3, 2, 2, 3], val = 3
        // ---------------------------------------------------------
        int[] test1 = new int[] { 3, 2, 2, 3 };
        int val1 = 3;
        Console.WriteLine("--- Prueba 1 ---");
        Console.WriteLine($"Entrada: [{string.Join(", ", test1)}], val = {val1}");

        int k1 = sol.RemoveElement(test1, val1);

        Console.WriteLine($"Conteo devuelto (k): {k1}");
        Console.Write("Arreglo modificado (primeros k): ");
        ImprimirArreglo(test1, k1);
        Console.WriteLine("\n");

        // ---------------------------------------------------------
        // PRUEBA 2: [0, 1, 2, 2, 3, 0, 4, 2], val = 2
        // ---------------------------------------------------------
        int[] test2 = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };
        int val2 = 2;
        Console.WriteLine("--- Prueba 2 ---");
        Console.WriteLine($"Entrada: [{string.Join(", ", test2)}], val = {val2}");

        int k2 = sol.RemoveElement(test2, val2);

        Console.WriteLine($"Conteo devuelto (k): {k2}");
        Console.Write("Arreglo modificado (primeros k): ");
        ImprimirArreglo(test2, k2);
        Console.WriteLine("\n");

        // ---------------------------------------------------------
        // PRUEBA 3: Todos los elementos son 'val' -> [1, 1, 1], val = 1
        // ---------------------------------------------------------
        int[] test3 = new int[] { 1, 1, 1 };
        int val3 = 1;
        Console.WriteLine("--- Prueba 3 (Borrando todos) ---");
        Console.WriteLine($"Entrada: [{string.Join(", ", test3)}], val = {val3}");

        int k3 = sol.RemoveElement(test3, val3);

        Console.WriteLine($"Conteo devuelto (k): {k3}");
        Console.Write("Arreglo modificado (primeros k): ");
        ImprimirArreglo(test3, k3);
        Console.WriteLine("\n");

        // ---------------------------------------------------------
        // PRUEBA 4: Ningún elemento coincide -> [4, 5, 6], val = 2
        // ---------------------------------------------------------
        int[] test4 = new int[] { 4, 5, 6 };
        int val4 = 2;
        Console.WriteLine("--- Prueba 4 (Sin coincidencias) ---");
        Console.WriteLine($"Entrada: [{string.Join(", ", test4)}], val = {val4}");

        int k4 = sol.RemoveElement(test4, val4);

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
