/* 28. Find the Index of the First Occurrence in a String
 * Easy */

/* Given two strings needle and haystack,
 * return the index of the first occurrence of
 * 'needle' in haystack, or -1 if needle is not part of haystack */

/* EXAMPLE 1
 * Input: haystack = "sadbutsad", needle = "sad" 
 * Output: 0
 * Explanation: "sad" occurs at index 0 and 6.
 * The first occurrence is at index 0, so we return 0. */

/* EXAMPLE 2
 * Input: haystack = "leetcode", needle = "leeto" 
 * Output: -1
 * Explanation: "leeto" did not occur in "leetcode", so we return -1. */

/* Constraints:
 * - 1 <= haystack.length, needle.length <= 10 a la cuarta potencia
 * - haystack and needle consist of only lowercase English characters. */

using System;

public class Solution {
    public int StrStr(string haystack, string needle) {
        return haystack.IndexOf(needle);
    }
}

class Program {
    static void Main() {
        Solution sol = new Solution();

        // ---------------------------------------------------------
        // PRUEBA 1: "sadbutsad", needle = "sad" -> Debería dar 0
        // ---------------------------------------------------------
        string haystack1 = "sadbutsad";
        string needle1 = "sad";
        Console.WriteLine("--- Prueba 1 ---");
        Console.WriteLine($"Haystack: \"{haystack1}\", Needle: \"{needle1}\"");

        int res1 = sol.StrStr(haystack1, needle1);
        Console.WriteLine($"Índice obtenido: {res1} | Esperado: 0\n");

        // ---------------------------------------------------------
        // PRUEBA 2: "leetcode", needle = "leeto" -> Debería dar -1
        // ---------------------------------------------------------
        string haystack2 = "leetcode";
        string needle2 = "leeto";
        Console.WriteLine("--- Prueba 2 ---");
        Console.WriteLine($"Haystack: \"{haystack2}\", Needle: \"{needle2}\"");

        int res2 = sol.StrStr(haystack2, needle2);
        Console.WriteLine($"Índice obtenido: {res2} | Esperado: -1\n");

        // ---------------------------------------------------------
        // PRUEBA 3: La aguja está al final -> "hello", needle = "ll" -> Debería dar 2
        // ---------------------------------------------------------
        string haystack3 = "hello";
        string needle3 = "ll";
        Console.WriteLine("--- Prueba 3 ---");
        Console.WriteLine($"Haystack: \"{haystack3}\", Needle: \"{needle3}\"");

        int res3 = sol.StrStr(haystack3, needle3);
        Console.WriteLine($"Índice obtenido: {res3} | Esperado: 2\n");

        // ---------------------------------------------------------
        // PRUEBA 4: La aguja es más larga que el pajar -> "aaa", needle = "aaaa" -> Debería dar -1
        // ---------------------------------------------------------
        string haystack4 = "aaa";
        string needle4 = "aaaa";
        Console.WriteLine("--- Prueba 4 (Needle más grande) ---");
        Console.WriteLine($"Haystack: \"{haystack4}\", Needle: \"{needle4}\"");

        int res4 = sol.StrStr(haystack4, needle4);
        Console.WriteLine($"Índice obtenido: {res4} | Esperado: -1\n");

        // ---------------------------------------------------------
        // PRUEBA 5: La aguja es más larga que el pajar -> "aaa", needle = "aaaa" -> Debería dar -1
        // ---------------------------------------------------------
        string haystack5 = "mississippi";
        string needle5 = "issipi";
        Console.WriteLine("--- Prueba 5 ---");
        Console.WriteLine($"Haystack: \"{haystack5}\", Needle: \"{needle5}\"");

        int res5 = sol.StrStr(haystack5, needle5);
        Console.WriteLine($"Índice obtenido: {res5} | Esperado: -1\n");
    }
}
