/* DAY OF PROGRAMMER 
 * - EASY 
 * - Cathegory: IMPLEMENTATION
 * - HACKERRANK
 * Marie invented a Time machine and wants to test it by time-traveling to visit Russia on the
 * Day Of The Programmer (the 256th day of the year) during a year in the inclusive range
 * from 1700 to 2700
 * From 1700 to 1917, Russia's official calendar was the Julian calendar;
 * since 1919 they used the Gregorian calendar system. The transition from the Julian
 * to Gregorian calendar system ocurred in 1918, when the next day after January 31st
 * was February 14th. This means that in 1918, February 14th was the 32nd day of the year
 * in Russia. */

/* In both calendar systems, February is the only month with a variable amount of days;
 * It has 29 days during a leap year, and 28 days during all other years.
 * In the Julian Calendar, leap year are divisible by 4; in the Gregorian calendar,
 * leap years are either of the following:
 * Divisible by 400
 * Divisible by 4 and not divisible by 10 */

/* Given a year, 'y', find the date of the 256th day of that year according to the
 * official Russian calendar during that year. Then print it in the format dd.mm.yyyy
 * where dd is the two-digit day, mm is the two-digit month, and yyyy is y.
 * For example, the given year = 1984. 1984 is divisible by 4, so it is a leap year.
 * The 256th day of a leap year after 1918 is September 12, so the
 * answer is 12.09.1984. */

/* FUNCTION DESCRIPTION
 * Complete the dayOfProgrammer function .
 * It should return a string representing the date of the 256th day of the year given.
 * - year: an integer
 * INPUT FORMAT
 * A single integer denoting year y.
 * CONSTRAINTS
 * - 1700 \|e y \|e 2700 
 * OUTPUT FORMAT
 * Print the full date of Day of the Programmer during year 'y' in the format
 * dd.mm.yyyy where dd is the two-digit day, mm is the two-digit month, and yyyy is y */

/* SAMPLE INPUT 0
 * 2017
 * SAMPLE OUTPUT 0
 * 13.09.2017
 * EXPLANATION
 * In the year y = 2017, January has 31 days, February has 28 days, March has 31 days,
 * April has 30 days, May has 31 days, June has 30 days, July has 31 days 
 * and August has 31 days. When we sum the total number of days in the first eight months
 * we get 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31 = 243. Day of the Programmer is the 
 * 256th day, so then calculates 256 - 243 = 13 to determine that it falls on day 13 of
 * the 9th month (September). We print the full date in the specified format,
 * wich is 13.09.2017. */

/* SAMPLE INPUT 1
 * 2016
 * SAMPLE OUTPUT 1
 * 12.09.2016
 * EXPLANATION
 * Year y = 2016 is a leap year, so February has 29 days but all the other months
 * have the same number of days as in 2017. When we sum the total number of days
 * in the first eight months, we get 31 + 29 + 31 + 30 + 31 + 30 + 31 + 31 = 244.
 * Day of the programmer is the 256th day, so then calculate 256 - 244 = 12
 * to determine that it falls on day 12 of the 9th month (September).
 * We then print the full date in the specified format, which is 12.09.2016. */

/* SAMPLE INPUT 2
 * 1800
 * SAMPLE OUTPUT 2
 * 12.09.1800
 * EXPLANATION 2
 * Since 1800 is leap year as per Julian calendar. Day lies on 12 September */

class Result
{
	public static string dayOfProgrammer(int year)
	{
		if(year == 1918){
			return "26.09." + year;
		}else if(year < 1918){
			if(year%4==0){
				return "12.09." + year;
			}else{
				return "13.09." + year;
			}
		}else{
			if(year % 400 == 0 || (year % 4 == 0 && year % 100 != 0)){
				return "12.09." + year;
			}else{
				return "13.09." + year;
			}
		}
	}
}

class Program
{
	static void Main()
	{
		Console.WriteLine("== EJECUTANDO PRUEBAS ==");
		int test1 = 1800;
		EjecutarPruebas(test1, "12.09.1800");
		int test2 = 2017;
		EjecutarPruebas(test2, "13.09.2017");
		int test3 = 2016;
		EjecutarPruebas(test3, "12.09.2016");
	}

	static void EjecutarPruebas(int year, string esperado)
	{
		string resultado = Result.dayOfProgrammer(year);
		Console.WriteLine(
			$"year={year}" +
			$"Esperado: {esperado}" +
			$"Obtenido: {resultado} | " +
			$"{(resultado == esperado ? "OK": "FALLO")}"
		);
	}
}
