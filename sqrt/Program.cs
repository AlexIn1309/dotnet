/* 69. SQRT(X) 
 * Easy
 * Given a non-negative integer 'x',
 * return the square root of 'x' rounded down
 * to the nearest integer. The returned integer
 * should be non-negative as well.
 *
 * You most not use any built-in exponen function or 
 * operator. */

/* EXAMPLE 1
 * Input: x = 4
 * Output: 2
 * Explanation: The square root of 4 is 2, so we return 2 */

/* EXAMPLE 2
 * Input: x = 8
 * Output: 2
 * Explanation: The square root of 8 is 2.82842...,
 * and since we round it down to the nearest integer,
 * 2 is returned */

public class Solution {
    public int MySqrt(int x) {
		int root = 0;

		int left = 1;
		int right = x / 2;
		int mid = 0;
		if (x < 2)
		{
		    return x;
		}else if(x == 2 || x == 3){
            return 1;
        }
			mid = x / 2;
		while(left <= right){
		 mid = (left + right) / 2;
		 if ((x / mid) == mid)
		 {
			Console.WriteLine($"Finaliza mitad como: {mid}");
		     return mid;
		 }else if ((x / mid) < mid)
		 {
		     right = mid - 1;
			Console.WriteLine($"Izquierda es: {left}");
		 }else{
			 root = mid;
			 left = mid + 1;
			Console.WriteLine($"Derecha es: {left}");
		 }
			Console.WriteLine($"La mitad es: {mid}");
		}
		return root;
    }
}

class Program {
	static void Main() {
		Solution sol = new Solution();

		// Prueba 1
		int test1 = 100;
		Console.WriteLine("-- Prueba 1 --");
		Console.WriteLine($"\nEntrada: {test1}\n");

		int resul1 = sol.MySqrt(test1);
		Console.WriteLine($"\nSalida: {resul1}, Esperado: 2\n");
		// Prueba 2
		int test2 = 8;
		Console.WriteLine("-- Prueba 2 --");
		Console.WriteLine($"\nEntrada: {test2}\n");

		int resul2 = sol.MySqrt(test2);
		Console.WriteLine($"\nSalida: {resul2}, Esperado: 2\n");
		// Prueba 3
		int test3 = 9;
		Console.WriteLine("-- Prueba 3 --");
		Console.WriteLine($"\nEntrada: {test3}\n");

		int resul3 = sol.MySqrt(test3);
		Console.WriteLine($"\nSalida: {resul3}, Esperado: 2\n");
		// Prueba 4
		int test4 = 10;
		Console.WriteLine("-- Prueba 3 --");
		Console.WriteLine($"\nEntrada: {test4}\n");

		int resul4 = sol.MySqrt(test4);
		Console.WriteLine($"\nSalida: {resul4}, Esperado: 2\n");

		// Prueba 5
		int test5 = 6;
		Console.WriteLine("-- Prueba 3 --");
		Console.WriteLine($"\nEntrada: {test5}\n");

		int resul5 = sol.MySqrt(test5);
		Console.WriteLine($"\nSalida: {resul5}, Esperado: 2\n");

		// Prueba 6
		int test6 = 2147395599;
		Console.WriteLine("-- Prueba 6 --");
		Console.WriteLine($"\nEntrada: {test6}\n");

		int resul6 = sol.MySqrt(test6);
		Console.WriteLine($"\nSalida: {resul6}, Esperado: 46339\n");
	} 

}
