/* 66. PLUS ONE 
 * EASY
 * You are given a large integer represented as an integer array 
 * 'digits', where each digits[i] id the ith digit of the integer.
 * The digits are ordered from most significant to least significant
 * in left-to-rigth order. The large integer does not contain any leading
 * 0s. 
 *
 * Increment the large integer by one and return the resulting array of digits.*/

/* EXAMPLE 1
 * Input: digits = [1,2,3]
 * Output: [1,2,4]
 * Explanation: The array represents the integer 123.
 * Incrementing by one gives 123 + 1 = 124.
 * Thus, the result should be [1,2,4].*/

/* EXAMPLE 2
 * Input: digits = [4,3,2,1]
 * Output: [4,3,2,2]
 * Explanation: The array represents the integer 4321.
 * Incrementing by one gives 4321 + 1 = 4322.
 * Thus, the result should be [4,3,2,2]. */

/* EXAMPLE 3
 * Input: digits = [9]
 * Output: [1,0]
 * Explanation: The array represents the integer 9.
 * Incrementing by one gives 9 + 1 = 10.
 * Thus, the result should be [1,0]. */

/* CONSTRAINTS
 * 1 <= digits.length <= 100
 * 0 <= digits[i] <= 9
 * digits does not contain any leading 0s. */

public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            if (digits[i] != 9)
            {
                digits[i] += 1;
                return digits;
            }
            digits[i] = 0;
        }

        int[] result = new int[digits.Length + 1];
        result[0] = 1;
        return result;
    }
}

class Program {
    static void Main(){
        Solution sol = new Solution();

        // Prueba 1: [1,2,3]
        int[] test1 = new int[] {1,2,3};

        Console.WriteLine("-- Prueba 1 --");
        Console.WriteLine("Entrada: [" + string.Join(",", test1) + "]");

        int[] k1 = sol.PlusOne(test1);
        Console.WriteLine($"Resultado: [{string.Join(",", k1)}]");

        Console.WriteLine("\n");
        // Prueba 1: [1,2,3]
        int[] test2 = new int[] {4,3,2,1};

        Console.WriteLine("-- Prueba 2 --");
        Console.WriteLine("Entrada: [" + string.Join(",", test2) + "]");

        int[] k2 = sol.PlusOne(test2);
        Console.WriteLine($"Resultado: [{string.Join(",", k2)}]");

        Console.WriteLine("\n");
        // Prueba 1: [9]
        int[] test3 = new int[] {9};

        Console.WriteLine("-- Prueba 3 --");
        Console.WriteLine("Entrada: [" + string.Join(",", test3) + "]");

        int[] k3 = sol.PlusOne(test3);
        Console.WriteLine($"Resultado: [{string.Join(",", k3)}]");

        Console.WriteLine("\n");
    }
}
