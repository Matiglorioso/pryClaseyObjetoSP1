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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<clsRepuestos> ListaRep = new List<clsRepuestos>();
        private void Form1_Load(object sender, EventArgs e)
        {
            LimpiarInterfaz();
            txtCodigo.Focus();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            clsRepuestos repuestos = new clsRepuestos();
            LimpiarInterfaz();
            repuestos.Nombre = txtNombre.Text;
            repuestos.Marca = cmbMarca.Text;
            repuestos.Codigo = txtCodigo.Text;
            repuestos.Precio = int.Parse(txtPrecio.Text);
            
            if(optImportado.Checked)
            {
                repuestos.Origen = "Importado";
            }
            if (optNacional.Checked)
            {
                repuestos.Origen = "Nacional";
            }
            ListaRep.Add(repuestos);

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            foreach(clsRepuestos repuestos in ListaRep)
            {
                lstRepuestos.Items.Add(repuestos.Consultar());
                lstRepuestos.Items.Add(repuestos.Codigo + " " + repuestos.Nombre + " " + repuestos.Marca + " $" + repuestos.Precio + " " + repuestos.Origen);
            }
        }
        public void LimpiarInterfaz()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            cmbMarca.SelectedIndex = 0;
            optNacional.Checked = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
