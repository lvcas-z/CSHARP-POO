using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{
    internal class Articulo
    {
        /// <summary>
        /// -CODIGO DE ARTICULO ( 3 DIGITOS NO CORRELATIVOS)
        /// -PRECIO
        /// - CODIGO DE MARCA (1 A 10)
        /// </summary>




        public int CodigoArticulo { get; set; }

        //private float precio;
        public float Precio { get; set; }

        private int codMarca;
        public int CodigoMarca
        {
            get { return codMarca; }
            set {
                if (value > 0 && value < 11)
                    codMarca = value;
                else
                    codMarca = -1;
            }
        }
    }
}
