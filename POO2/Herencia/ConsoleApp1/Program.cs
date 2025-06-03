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
            Lider l1 = new Lider();

            l1.Apellido = "Messi";
            l1.Nombre = "Lionel";
            l1.NroLegajo = 10;
        }
    }
}
