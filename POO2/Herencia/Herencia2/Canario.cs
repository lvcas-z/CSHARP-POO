﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2
{
    internal class Canario : AnimalDomestico, Flyable
    {
        public string volar()
        {
            return "vuela canario...";
        }
    }
}
