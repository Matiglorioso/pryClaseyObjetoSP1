using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryClaseyObjetoSP1
{
    public partial class frmMascotas : Form
    {
        public frmMascotas()
        {
            InitializeComponent();
        }
        List<clsMascota> ListaMasc = new List<clsMascota>();
        private void btnCargar_Click(object sender, EventArgs e)
        {
            clsMascota mascota = new clsMascota();
            LimpiarInterfaz();
            mascota.Nombre = txtNombre.Text;
            mascota.TipoAnimal = txtTipo.Text;
            mascota.Edad = Convert.ToInt32(txtEdad.Text);
            ListaMasc.Add(mascota);

        }
        public void LimpiarInterfaz()
        { 
            txtEdad.Text = " ";
            txtTipo.Text = " ";
            txtNombre.Text = " ";
            lstMascotas.Items.Clear();  
        
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            foreach (clsMascota mascota
                in ListaMasc)
            {
                lstMascotas.Items.Add(mascota.Nombre);
                lstMascotas.Items.Add(mascota.TipoAnimal);
                lstMascotas.Items.Add(mascota.Edad);

            }
        }
    }
}
