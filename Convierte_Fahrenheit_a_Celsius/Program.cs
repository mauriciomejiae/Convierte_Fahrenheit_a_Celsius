/* Nombre del Autor: Mauricio Mejia Estevez
 Fecha: 08 de Septiembre de 2017
 Doy fe que este ejercicio es de mi autoría, en caso de encontrar plagio la nota de todo mi 
trabajo debe ser de CERO además de las respectivas sanciones a que haya lugar*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convierte_Fahrenheit_a_Celsius
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables
            double f;
            double c;

            Console.WriteLine("*******************************************************");
            Console.WriteLine("   CONVERSOR DE GRADOS FAHRENHEIT  A GRADOS CELSIUS    ");
            Console.WriteLine("*******************************************************");
            Console.WriteLine();
            Console.WriteLine("Ingresa la temperatura en grados Fahrenheit:");
            f = double.Parse(Console.ReadLine());    // Guardar en la variable f el valor ingresado por el usuario

            c = 5.0 / 9.0 * (f - 32.0);  //Convierte a Celsuis

            Console.WriteLine();
            Console.WriteLine("RESULTADO:");
            Console.WriteLine(f + "°F son " + c + "°C."); //Mostrar resultado en pantalla
            Console.WriteLine();
            Console.WriteLine("*******************************************************");
            Console.WriteLine();
            Console.WriteLine("Presiona un tecla para salir...    ");
            Console.ReadKey(); // Detener en pantalla hasta presionar una tecla
        }
    }
}

