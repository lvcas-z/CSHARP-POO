using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///Primer lote con 10 registros de productos, cada producto tiene:
            /// Cod Articulo (3 digitos no correlativos)
            ///Cod marca (Dr 1 a 10)

            ///Segundo lote con ventas de la semana. Cada venta tiene:
            ///Codigo Articulo
            ///Cantidad
            ///Cod cliente (1 a 100)
            ///EL LOTE CORTA CON COD CLIENTE 0

            Articulo[] articulos = new Articulo[10];
            articulos[6].CodigoMarca = 3;

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese los datos del producto...");

                Console.WriteLine("Ingrese el codigo del producto:");
                articulos[x].CodigoArticulo = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el precio del producto:");
                articulos[x].Precio = float.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el codigo de marca del producto 1 a 10:");
                articulos[x].CodigoMarca = int.Parse(Console.ReadLine());

            }
            ///Cargado el vector con 10
            Venta venta = new Venta();
            Console.WriteLine("Ingrese los datos de la venta...");

            Console.WriteLine("Ingrese el codigo de cliente:");
            venta.CodCliente = int.Parse(Console.ReadLine());

            while (venta.CodCliente != 0)
            {
                Console.WriteLine("Ingrese el codigo de articulo:");
                venta.CodArticulo = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la cantidad:");
                venta.Cantidad = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese los datos de la venta...");

                Console.WriteLine("Ingrese el codigo de cliente:");
                venta.CodCliente = int.Parse(Console.ReadLine());

            }


        }
    }
}
