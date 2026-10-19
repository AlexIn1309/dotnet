/* DRAWING BOOK 
 * EASY
 * Cathegory: IMPLEMENTATION
 * HackerRank
 * A techer asks the class to open their books to a page number.
 * A student can either start turning pages from the front of the book.
 * They always turn pages one at a time. When they open the book, page 1 is
 * always on the right side:
 * BOOK
 * [0 | 1]
 * When they flip pages 1, they see pages 2 and 3. Each page except the last
 * page p, what is the minimum of pages to turn? They can start at the
 * beginning or the end of the book. */

/* Given 'n' and 'p', find and print the minimum number of pages that
 * must be turned in order to arrive at page p. */

/* Example
 * n = 5
 * p = 3
 * BOOK
 * [0 | 1] -> [2 | 3] -> [4 | 5] 
 * Using the diagram above, If the student wants to get to page 3, they open
 * the book to page 1, flip 1 page and they are on the correct page.
 * If they open the book to the last page, page 5, they turn 1 page and at the
 * correct page. Return 1. */

/* FUNCTION DESCRIPTION
 * - int n: the number of pages in the book
 * - int p: the page number to turn to */

/* RETURNS
 * - int: the minimum number of pages to turn */

/* INPUT FORMAT
 * The firts line contains an integer 'n', the number of pages in the book.
 * The second line contains an integer 'p', the page to turn to. */

/* CONSTRAINTS
 * - 1 <= n <= 10^5
 * - 1 <= p <= n */

/* SAMPLE INPUT 0
 * 6
 * 2
 * SAMPLE OUTPUT 0
 * 1
 * EXPLANATION
 * If the student starts turning from page 1, they only need to turn 1 page:
 * BOOK 
 * [0 | 1] -> [2 | 3]
 * If a student starts turning from page 6, they need to turn 2 pages:
 * BOOK 
 * [6 |  ] -> [4 | 5] -> [2 | 3] 
 * Return the minimum value, 1.*/

/* SAMPLE INPUT 1
 * 5
 * 4
 * SAMPLE OUTPUT 1
 * 0
 * EXPLANATION
 * If the student starts turning from page 1, they only need to turn 2 page:
 * BOOK 
 * [0 | 1] -> [2 | 3] -> [4 | 5]
 * If they start turning from page 5, they do not neet to turn any pages:
 * BOOK 
 * [4 | 5] */

class Result
{
	public static int pageCount(int n, int p)
	{
		int desdeInicio = p / 2;
		int desdeFinal = (n / 2) - (p / 2);
		
		return (desdeFinal > desdeInicio)?desdeInicio:desdeFinal;
	}
}

class Program
{
	static void Main()
	{
		Console.WriteLine("== EJECUTAR PRUEBAS ==");
		EjecutarPruebas(6,2,1);
	}

	static void EjecutarPruebas(int n, int p, int esperado)
	{
		int resultado = Result.pageCount(n,p);
		Console.WriteLine(
			$"n = {n}" +
			$"p = {p}" +
			$"Esperado: {esperado}" +
			$"Obternido: {resultado} | " +
			$"{(resultado == esperado ? "OK" : "FALLO" )}"
		);
	}
}
