using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HaberQuePasa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorLeft = 35;

            Console.WriteLine("Vamos a ingresar cantidad de personas y sus datos");

            Console.WriteLine("Ingrese la cantidad de personas:");

            int CantidadDePersonas = Convert.ToInt32(Console.ReadLine());

            List<DatosDeLasPersonas> ListaDePersonas = new List<DatosDeLasPersonas>();


            for (int i=0; i< CantidadDePersonas; i++)
            {
                DatosDeLasPersonas personas = new DatosDeLasPersonas();

                Console.WriteLine("Ingrese el nombre de la persona " + i +  " :");
                personas.nombre = Console.ReadLine();

                Console.WriteLine("Ingrese el apellido de la persona "  + i + " :");
                personas.apellido = Console.ReadLine();

                Console.WriteLine("Ingrese la edad de la persona " + i +" :");
                personas.años = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese la nacionalidad de la persona " + i+ " :");
                personas.nacionalidad = Console.ReadLine();

                ListaDePersonas.Add(personas);

                Console.Clear();
            }

            for ( int i = 0; i< ListaDePersonas.Count; i++)
            {
                DatosDeLasPersonas datosDe = ListaDePersonas[i];
                Console.WriteLine(datosDe.personas());
            }
            Console.ReadKey();

        }
    }
}
