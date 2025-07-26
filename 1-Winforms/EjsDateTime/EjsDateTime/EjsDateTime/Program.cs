using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjsDateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //DateTime fecha = new DateTime(2002, 1, 4);
            //DateTime fechaActual= DateTime.Now;


            //Console.WriteLine(fechaActual.ToString());  
            //Console.WriteLine(fecha.ToString());

            //Console.WriteLine(fechaActual.AddDays(7).ToString());/// agrego dias


            Application.Run(new EjsDate());

        }


    }
}
