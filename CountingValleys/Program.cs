/* COUNTING VALLEYS
 * HackerRank
 * Easy
 * Cathegory: Implementation
 * 
 * An avid hiker keeps meticulous records of their hikes. During the last hike
 * that took exactly 'steps' steps, for every step it was noted if it was an 
 * uphill, 'U', or a downhill, 'D' step. Hikes always start and end at sea level,
 * and each step up or down represents a 1 unit change in altitude. */

/* - A mountain is a sequence of consecutive steps above sea level, starting
 * with a step up from sea level and ending with a step down to sea level.
 * - A valley is a sequence of consecutive steps below sea level, startng with
 * a step down from sea level and ending with a step up to sea level.
 * Given the sequence of up and down steps during a hike, find and print
 * the number of valleys walked through. */

/* EXAMPLE
 * steps = 8 path = [DDUUUUDD] 
 * The hiker first enters a valley2 units deep. Then they climb out and up onto
 * a mountain 2 units high. Finally, the hiker returns to sea level and ends 
 * the hike.*/

/* FUNCTION DESCRIPTION
 * - int steps: the number of steps on the hike
 * - string path: a string describing the path
 * RETURNS
 * - int: the number of valleys traversed
 * INPUT FORMAT
 * The first line contains an integer 'steps', the number of steps in the hike.
 * The second line contains a single string 'path', of 'steps' characters
 * that describe the path */

/* CONSTRAINTS
 * - 2 <= steps <= 10^6
 * - path[i] E {U D} */

/* SAMPLE INPUT
 * 8
 * UDDDUDUU
 * SAMPLE OUTPUT
 * 1
 * EXPLANATION
 * If we represent _ as sea level, a step up as /, and a step down as \,
 * the hike can be drawn as:
 * 
 * _/\      _
 *    \    /
 *     \/\/ 
 * 
 * The hiker enters and leaves one valley */


class Result
{
	public static int countingValleys(int steps, string path)
	{
		int contador = 0;
		int valles = 0;
		foreach(char avance in path){
			if(avance == 'U'){
				contador++;
				if(contador == 0)valles++;
			}else{
				contador--;
			}
		}
		return valles;
	}
}

class Program
{
	static void Main()
	{
		Console.WriteLine("== EJECUTANDO PRUEBAS ==");
		EjecutarPruebas(8,"UDDDUDUU", 1);
	}

	static void EjecutarPruebas(int steps, string path, int esperado)
	{
		int resultado = Result.countingValleys(steps, path);
		Console.WriteLine(
			$"steps = {steps}" +
			$"path = {path}" +
			$"Esperado: {esperado}" +
			$"Obtenido: {resultado} |" +
			$"{(resultado == esperado?"OK":"FALLO")}"
		);
	}
	
}
