/* Given a time in 12-hour AM/PM format, convert it to military
 * (24-hour) time. Note: - 12:00:AM on a 12-hour clock is 00:00:00
 * on a 24-hour clock. - 12:00:00PM on a 12-hour clock is 12:00:00
 * on a 24-hour clock.*/

/* EXAMPLE
 * - s = '12:01:00PM'
 * Return '12:01:00'
 * - s = '12:01:00AM'
 * Return '00:01:00'.*/

/* FUNCTION DESCRIPTION
 * - string s: a time in 12 hour format
 * Returns
 * - string: the time in 24 hour format*/

/* INPUT FORMAT
 * A single string 's' that represents a time in 12-hour clock format
 * (hh:mm:ssAM or hh:mm:ssPM)*/

/* CONSTRAINTS
 * - All input times are valid
 * SAMPLE INPUT 0
 * 07:05:45PM
 * SAMPLE OUTPUT 0
 * 19:05:45*/

class Result
{
	public static string timeConversion(string s)
	{
		string nuevoFormato = "";
		string parteIntermedia = s[2..8];
		Console.WriteLine($"ParteIntermedia es: {parteIntermedia}");
		string primerNumero = s[0..2];
		int modificar = 0;
		Console.WriteLine($"String en s[8]: {s[8]}");
		if(s[8] == 'P')
		{
			Console.WriteLine("Primero");
			if(primerNumero == "12")
			{
				// Si son las 12 PM, se quedan como 12
				nuevoFormato = "12" + parteIntermedia;
			}else{
				// Si es cualquier otra hora PM, se le suma 12
				modificar = 12 + int.Parse(primerNumero);
				nuevoFormato = modificar.ToString() + parteIntermedia;
			}
			return nuevoFormato;
		}
		if(s[8] == 'A' && primerNumero != "12")
		{
			Console.WriteLine("Segundo");
			nuevoFormato = primerNumero + parteIntermedia;
			return nuevoFormato;
		}
		if(s[8] == 'A' && primerNumero == "12")
		{
			Console.WriteLine("Tercero");
			nuevoFormato = "00" + parteIntermedia;
			return nuevoFormato;
		}
		return nuevoFormato;
	}
}

class Program
{
	static void Main()
	{
		Console.WriteLine("== EJECUTANDO PRUEBAS ==");
		string test1 = "12:01:00PM";
		Console.WriteLine("Prueba 1: 12:01:00PM");
		string k1 = Result.timeConversion(test1);
		Console.WriteLine("Esperado: 12:01:00");
		Console.WriteLine($"Resultado: {k1}");

		string test2 = "12:01:00AM";
		Console.WriteLine("Prueba 1: 12:01:00AM");
		string k2 = Result.timeConversion(test2);
		Console.WriteLine("Esperado: 00:01:00");
		Console.WriteLine($"Resultado: {k2}");

	}
}
