﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad;
            float sueldo;
            string nombre;

            int[] edades = new int[10];
            float[] sueldos = new float[10];
            string[] nombres = new string[10];

            ///GETTERS - SETTERS
            Persona p1 = new Persona();
            p1.setEdad(20);
            Console.WriteLine("La edad de la persona es:" + p1.getEdad());


            // PROPIEDADES DE C#
            Botella b1 = new Botella();
            b1.Capacidad = 200;

            int capacidadDeB1 = b1.Capacidad;
            Console.WriteLine("La capacidad de la botella es:" + capacidadDeB1);
            Console.WriteLine("La capacidad de la botella es:" + b1.Capacidad);


        }
    }
}
