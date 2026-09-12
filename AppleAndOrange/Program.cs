/* APPLE AND ORANGE 
 * Implementation*/

/* Sam's house has an apple tree and an orange tree that
 * yield an abundance of fruit. Using the information below,
 * determine the number of apples and oranges that land
 * on Sam's house.*/

/* In the diagram below:
 * - The red region denotes the house, where 's' is the 
 * start point. The apple tree is to the left of the house,
 * and the orange tree is to its right.
 * - Assume the trees are located on a single point, where
 * the apple tree is at point 'a', and the orange tree
 * is at point b.
 * - When a fruit falls from its tree, it land d units
 * of distance from its tree of origin along the x-axis.
 * "A negative value of 'd' means the fruit fell 'd'
 * units to the tree's left, and a positive value of
 * 'd' means it falls 'd' units to the tree's right." */

/* Given the value of 'd' for 'm' apples and 'n' oranges,
 * determine how many apples and oranges will fall on 
 * Sam's house (In the inclusive range [s,t])*/

/* FOR EXAMPLE
 * Sam's house is between s = 7 and t = 10.
 * The apple tree is locates at a = 4 and the orange
 * at b = 12. There are m = 3 apples and n = 3 oranges.
 * Apples are thrown apples = [2,3,-4] units distance
 * from a, and oranges = [3,-2,-4] units distance.
 * Adding each apple distance to the position of the
 * tree, they land at [4 + 2, 4 + 4, 4 + -4] = [6,7,0].
 * Oranges land at [12 + 3, 12 + -2, 12 + -4] = [15,10,8].
 * One apple and two oranges land in the inclusive
 * range 7 - 10 so we print
 * 1
 * 2 */

/* FUNCTION DESCRIPTIONs
 * It should print he number of apples and oranges that 
 * land on Sam's house, each on a separate line.
 * - s: integer, starting point of Sams's house location.
 * - t: integer, ending location of Sam's house Location.
 * - a: integer, locatin of the Apple Tree.
 * - b: integer, location of the Orange Tree.
 * - apples: integer array, distances at which each
 * apple falls from the tree.
 * - oranges: integer array, distances at which each
 * orange falls from the tree.*/

/* INPUT FORMAT
 * The first line contains two space-separated integers
 * denoting the respective values of 'm' and 'n'
 * The second line contains two space-separated integers 
 * denoting the respective values of 'a' and 'b'.
 * The third line contains two space-separated integers
 * denoting the respective values of 'm' and 'n'.
 * The fourth line contains 'm' space-separated integers
 * denoting the respective distances that each apple
 * falls from point 'a'.
 * The fifth line contains 'n' space-separated integers
 * denoting the respective distances that each orange
 * falls from point 'b'. */

/* CONSTRAINTS
 * - 1 <= s,t,a,b,m,n <= 10^5
 * - -10^5 <= d <= 10^5
 & - a < s < t < b */

/* OUTPUT FORMAT
 * Print two integers on two different lines:
 * 1. The first integer: the number of apples that
 * fall on Sam's house.
 * 2. The second integer: the number of oranges
 * that fall on Sam's house. */

/* SAMPLE INPUT 0
 * 7 11
 * 5 15
 * 3 2
 * -2 2 1
 * 5 -6 */

/* SAMPLE OUTPUT 0
 * 1
 * 1
 */

/* EXPLANATION
 * The first apple falls at position 5 - 2 = 3
 * The second apple falls at position 5 + 2 = 7
 * The third apple falls at position 5 + 1 = 6
 * The first orange falls at position 15 + 5 = 20
 * The second orange falls at position 15 - 6 = 9
 * Only one fruit (the second apple) falls within
 * the region between 7 and 11, so wer print 1
 * as our first line of output.
 * Only the second orange falls within the region
 * between 7 and 11, so we print 1 as our second
 * line of output.
*/

class Result
{
	public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
	{
		int manzanas = 0;
		int naranjas = 0;
		
		foreach(int distancia in apples){
			int posicion = distancia + a;
			if(posicion >= s && posicion <= t) manzanas++;
		}
		
		foreach(int distancia in oranges){
			int posicion = distancia + b;
			if(posicion >= s && posicion <= t) naranjas++;
		}
		Console.WriteLine(manzanas);
		Console.WriteLine(naranjas);
	}
}

class Program
{
	static void Main()
	{
		Console.WriteLine("== EJECUTANDO PRUEBAS UNITARIAS ==\n");

		// Caso de Prueba 1: Ejemplo base del enunciado (Sample Input 0)
		Console.WriteLine("Prueba 1");
		//,esperadoApples: 1, esperadoOranges: 1
		Result.countApplesAndOranges(s: 7, t: 11, a: 5, b: 15,apples: new List<int> { -2, 2, 1 },oranges: new List<int> { 5, -6 });

		// Caso de Prueba 2: Ejemplo explicativo de la descripción (For Example)
		// , esperadoApples: 1, esperadoOranges: 2
		Console.WriteLine("Prueba 2");
		Result.countApplesAndOranges(s: 7, t: 10, a: 4, b: 12,apples: new List<int> { 2, 3, -4 },oranges: new List<int> { 3, -2, -4 });

		// Caso de Prueba 3: Ninguna fruta cae en la casa (Límites lejanos)
		// , esperadoApples: 0, esperadoOranges: 0
		Console.WriteLine("Prueba 3");
		Result.countApplesAndOranges(s: 10, t: 20, a: 2, b: 30, apples: new List<int> { 1, 2, -3 }, oranges: new List<int> { 5, 10, 15 });

		// Caso de Prueba 4: Valores en el límite exacto [s] y [t] (Inclusivo)
		// ,esperadoApples: 1, esperadoOranges: 1
		Console.WriteLine("Prueba 4");
		Result.countApplesAndOranges(s: 10, t: 15, a: 5, b: 20, apples: new List<int> { 5 },oranges: new List<int> { -5 });
    }
}

