/* BREAKING THE RECORDS
 * HackerRank
 * Cathegory: Implementation
 * Maria plays college baasketball and wants to go pro.
 * Each season he maintains a record of her play.
 * She tabulates the number of times she breaks her season record
 * for most points and least points in a game. Points scored in the
 * first game established her record for the season, and she 
 * begins counting from there.
 *
 * EXAMPLE
 * scores = [12, 24, 10, 24]
 * Scores are in the same order as the games played.
 * She tabulates her results
 *                                     COUNT
 * GAMES | SCORE | MINIMUM | MAXIMUM | MIN MAX | 
 *  0    |  12   |	12	   |	12	 |  0   0  |
 *  1    |  24   |	12	   |	24	 |  0   1  |
 *  2    |  10   |	10	   |	24	 |  1   1  |
 *  3    |  24   |	10	   |	24	 |  1   1  |
 *
 * Given the scores for a season, determine the number
 * of times Maria breaks her records for most an least
 * points scored during the season.
 */

/* FUNCTION DESCRIPTION 
 * Complete the breakingRecords function
 * - int scores[n]: points score per game
 * 
 * RETURNS
 * - int[2]: An array with the numbers of times
 * she broke her records. Index 0 is for breaking
 * most points records, and index 1 is for breaking 
 * least points records. */

/* INPUT FORMAT
 * The first line contains an integer n, the number
 * of games.
 * The second line contains n space-separated integers
 * describing the respectie alues of score0, score1,...
 * scoreN-1 */

/* CONSTRAINTS 
 * - 1 <= n <= 1000
 * - 0 <= scores[i] <= 10^8*/

/* SAMPLE INPUT 0
 * 9
 * 10 5 20 20 4 5 2 25 1
 * SAMPLE OUTPUT 0
 * 2 4
 * EXPLANATION
 * The diagram below depicts the number of times Maria Broke her best and worst records throughout the season:
 *  */

/*   GAME | 0  | 1  | 2  | 3  | 4  | 5  | 6  | 7  | 8  |
 *  SCORE | 10 | 5  | 20 | 20 | 4  | 5  | 2  | 25 | 1  |
 *   HIGH | 10 | 10 | 20 | 20 | 20 | 20 | 20 | 25 | 25 |
 * LOWEST | 10 | 5  | 5  | 5  | 4  | 5  | 2  | 25 | 1  |
 *  */

/* She broke her best record twice (after games 2 and 7) and her worst record four times (after games 1,4,6 and 8) 
 * so we print 2 4 as our answer. Note that she did not break her record for best score during that game
 * was not strictly greater than her best record at the time.
 * */

/* SAMPLE INPUT 1
 * 10
 * 3 4 21 36 10 28 35 5 24 42
 * SAMPLE OUTPUT 1
 * 4 0
 * EXPLANATION 1
 * The diagram below depicts the number of times Maria Broke her best and worst records throughout the season:
 *  */

/*   GAME | 0 | 1 | 2  | 3  | 4  | 5  | 6  | 7  | 8  | 9  |
 *  SCORE | 3 | 4 | 21 | 36 | 10 | 28 | 35 | 5  | 24 | 42 |
 *   HIGH | 3 | 4 | 21 | 36 | 36 | 36 | 36 | 36 | 36 | 42 |
 * LOWEST | 3 | 3 | 3  | 3  | 3  | 3  | 3  | 3  | 3  | 3  |
 *  */

/* She broke her best record four times (after games 1,2,3 and 9) and her worst record zero times 
 * (No score uring the season was lower than the one she earned during her first game)
 * so we print 4 0 as our answer.
 * */

class Result
{
	public static List<int> breakingRecords(List<int> scores)
	{
		int masalto = scores[0];
		int minimo = scores[0];
		int superados = 0;
		int retrocesos = 0;
		foreach(int elemento in scores){
			if(elemento > masalto){
				masalto = elemento;
				superados++;
			   	Console.WriteLine($"El mas alto: {masalto}");
			}

			if(elemento < minimo){
				minimo = elemento;
				retrocesos++;
			   	Console.WriteLine($"El mas bajo: {minimo}");
			}
		}
		return [superados, retrocesos];
	}
}

class Program
{
	static void Main()
	{
		Console.WriteLine("== EJECUTANDO PRUEBAS ==");
		List<int> test1 = [3,4,21,36,10,28,35,5,24,42];
		Console.WriteLine("Prueba 1 con: [3,4,21,36,10,28,35,5,24,42]");
		List<int> k1 = Result.breakingRecords(test1);
		Console.WriteLine("Resultado es: ");
		imprimir(k1);

		List<int> test2 = [10,5,20,20,4,5,2,25,1];
		Console.WriteLine("Prueba 2 con: [10,5,20,20,4,5,2,25,1]");
		List<int> k2 = Result.breakingRecords(test2);
		Console.WriteLine("Resultado es: ");
		imprimir(k2);
	}

	static void imprimir(List<int>resultado){
		foreach(int p in resultado) Console.Write($"{p} ");
		Console.WriteLine("\n");
	}
}
