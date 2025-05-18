using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    internal class Botella
    {

        /// capacidad maxima:100
        /// cantidadActual = 0
        /// metodo de recarga: carga al 100 y devuelve el costo de recargar. 50 cada 100
        /// Constructor Botella
        public Botella(string color, string material)
        {
            this.color = color;
            this.material = material;
            capacidad = 100;
            cantidadActual = 0;
        }
        
        /// Sobrecargar el constructor
        public Botella() { }


        private int capacidad;
        private string color;
        private string material;
        private int cantidadActual;

        public int Capacidad
        {
            get { return capacidad; }
        }

        public int CantidadActual
        {
            get { return cantidadActual; }
        }

        public string Material {
            get { return this.material; } 
        }

        public float recargar()
        {
            if (cantidadActual > 0)
            {
                int dif = 100 - cantidadActual;
                float monto = dif * 50 / 100 ;
                cantidadActual += dif;
                return monto;
            }
            cantidadActual = 100;
            return 50;
        }


    }
}
