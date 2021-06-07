using System;
using System.IO;

namespace Programas
{
    class Program
    {
		
        static void Main(string[] args){

			StreamReader leer = new StreamReader(File.OpenRead("C:\\Users\\juan_\\Desktop\\Programas\\Registro de datos.txt"));
			
			String contenido = leer.ReadToEnd();
			
			leer.Close();
			
			Console.WriteLine();
			
			Console.WriteLine("Introduzca su cédula: ");
			String cedula = Console.ReadLine();
			Console.WriteLine("Introduzca sus nombres: ");
			String nombres = Console.ReadLine();
			Console.WriteLine("Introduzca sus apellidos: ");
			String apellidos = Console.ReadLine();
			Console.WriteLine("Introduzca su edad: ");
			byte edad = byte.Parse(Console.ReadLine());
			
			contenido = contenido + (cedula + "," + nombres + "," + apellidos + "," + edad);
			
			TextWriter escribir = new StreamWriter(File.OpenWrite("C:\\Users\\juan_\\Desktop\\Programas\\Registro de datos.txt"));
			
			Console.WriteLine();
			
			Console.WriteLine("¿Quisiera guardar estos datos? Y/N");
			String guardar = Console.ReadLine();
			
			if(guardar.Equals("Y")){
				
				escribir.WriteLine(contenido);
				
			}
			
			escribir.Close();
			
			Console.WriteLine();
			Console.WriteLine("Presione cualquier tecla para finalizar...");
			Console.ReadKey();

        }

    }
}
