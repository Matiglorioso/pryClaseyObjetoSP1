﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryClaseyObjetoSP1
{
    internal class clsRepuestos
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public decimal Precio { get; set; }
        public bool Origen { get; set; }

        public string Consultar()
        {
            return Codigo + " " + Nombre + " " + Marca + " " + Precio + " " + Origen;
        }
    }
}
