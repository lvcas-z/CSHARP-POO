using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AnimalDomestico a1 = new AnimalDomestico();
            a1.Nombre = "Pepe";

            Console.WriteLine(a1.ToString());

            Gato g1 = new Gato();
            g1.Nombre = "Leoncito";
            Console.WriteLine(g1.ToString());
            Console.WriteLine(g1.Comunicarse());


            List<Animal> listaAnimales = new List<Animal>();
            listaAnimales.Add(a1);
            listaAnimales.Add(g1 );
            listaAnimales.Add(new Pez());

            /// Poliformismo aplicado porque cada obj tiene se def
            /// 


            /// no se puede crear instancia de una interfaz por ende no se crea como flyable f1 = etc etc
           

            List<Flyable> listaVoladores = new List<Flyable>();

            listaVoladores.Add(new Canario());
            listaVoladores.Add(new Aguila());



            foreach(Animal a in listaAnimales)
            {
                Console.WriteLine(a.Comunicarse());
            }

            Console.ReadKey();


        }
    }
}
