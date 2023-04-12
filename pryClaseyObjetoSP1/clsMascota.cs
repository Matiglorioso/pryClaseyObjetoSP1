using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryClaseyObjetoSP1
{
    internal class clsMascota
    {
        public string Nombre { get; set; }
        public string TipoAnimal  { get; set; }
        public int Edad { get; set; }

        public PictureBox Mascotax;
      
        public string Consultar()
        {
            return "Nombre de la mascota: " + Nombre + " Tipo: " + TipoAnimal + " Edad: " + Edad;
        }
    }
}
