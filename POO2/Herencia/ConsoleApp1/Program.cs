using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)

        {

            // Persona > Lider > Developer > Tester

            Persona persona = new Persona();

            Developer d1 = new Developer();
            d1.Apellido = "Messi";

            Developer d2 = new Developer();
            d2.Apellido = "Neymar";

            Developer d3 = new Developer();
            d3.Apellido = "Suarez";

            Developer d4 = new Developer();
            d4.Apellido = "Iniesta";


            Lider l1 = new Lider();

            l1.Apellido = "Enrique";
            l1.Nombre = "Luis";
            l1.NroLegajo = 1;

            List<Developer> listadoDevelopers = new List<Developer>();
            listadoDevelopers.Add(d1);
            listadoDevelopers.Add (d2);
            listadoDevelopers.Add(d3);
            listadoDevelopers.Add(d4);

            Console.WriteLine("La cantidad de camionetas es: " + listadoDevelopers.Count);
            Console.WriteLine("El apellido es : " + listadoDevelopers[0].Apellido);
            listadoDevelopers[1].Apellido = "Dembele";
            Console.WriteLine("El apellido es : " + listadoDevelopers[1].Apellido);

            listadoDevelopers.Remove(d4);
            Console.WriteLine("La cantidad de camionetas es: " + listadoDevelopers.Count);







            Console.ReadKey();

            

        }
    }
}
