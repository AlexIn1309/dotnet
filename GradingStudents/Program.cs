/* GRADING STUDENTS */

/* HackerLand University has the following grading policy:
 * - Every student receives a grade in the inclusive range
 * from 0 to 100.
 * - Any grade less than 40 is a failing grade.
 * Sam is a professor at the university and likes
 * to round each students's grade according to these rules
 * - If the difference between the grade and the next multiplier
 * of 5 is less than 3, round grade up to the next multiple of 5
 * - If the value of grade is less than 38, no round occurs as
 * the result will still be a failing grade.*/


class Result
{
	public static List<int> gradingStudents(List<int> grades){
		List<int> nuevoArreglo = new List<int>();
		foreach(int elemento in grades){
			bool bandera = true;
			if((elemento + 1)%5 == 0 && elemento > 38){
				nuevoArreglo.Add(elemento+1);
				bandera = false;
			}
			if((elemento + 2)%5 == 0 && elemento >= 38){
				nuevoArreglo.Add(elemento+2);
				bandera = false;
			}
			if(bandera){
				nuevoArreglo.Add(elemento);
			}
		}
		return nuevoArreglo;
	}
}

class Program
{
	static void Main()
	{
		Console.WriteLine("== EJECUTANDO PRUEBAS ==");
		List<int> test1 = [73,67,38,33];
		Console.WriteLine("PRUEBA 1: 73,67,38,33");
		List<int> k1 = Result.gradingStudents(test1);
		Console.Write("Resultado: ");
		imprimirLista(k1);
		Console.WriteLine($"Esperado: 75,67,40,33");
	}

	static void imprimirLista(List<int> grados){
		foreach(int elemento in grados){
			Console.Write($" {elemento} ");
		}
		Console.WriteLine("\n");
	}
}

/* d */
