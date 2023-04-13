using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryClaseyObjetoSP1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private const string PATH_ARCHIVO = "Repuestos.txt"; 
        private void Form1_Load(object sender, EventArgs e)
        {
            txtCodigo.Focus();
            LimpiarInterfaz();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if(Validar())
            {
                clsRepuestos nuevoRep = CrearRep();
                Archivo Repuestos = new Archivo();
                Repuestos.NombreArchivo = PATH_ARCHIVO;
                Repuestos.GrabarRepuesto(nuevoRep);
                LimpiarInterfaz();
            }
            else
            {
                MessageBox.Show("Los datos ingresados son incorrectos", "SOMETHING WENT WRONG", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool Validar()
        {
            bool resultado = false;
            if(txtCodigo.Text != "")
            {
                if (txtNombre.Text != "")
                {
                    if (txtPrecio.Text != "")
                    {
                        Archivo Repuestos = new Archivo();
                        Repuestos.NombreArchivo = PATH_ARCHIVO;
                        if(Repuestos.BuscarCodigo(txtCodigo.Text) == false)
                        {
                            resultado = true;
                        }
                    }
                }
            }
            return resultado;
        }
        private clsRepuestos CrearRep()
        {
            clsRepuestos nuevoRep = new clsRepuestos();
            nuevoRep.Codigo = txtCodigo.Text;
            nuevoRep.Nombre = txtNombre.Text;
            nuevoRep.Marca = cmbMarca.SelectedItem.ToString();
            nuevoRep.Precio = decimal.Parse(txtPrecio.Text);
            if(optNacional.Checked)
            {
                nuevoRep.Origen = "Nacional";
            }
            if(optImportado.Checked) 
            {
                nuevoRep.Origen = "Importado";
            }
            return nuevoRep; //devuelve el objeto creado con los nuevos valore asignados
        }


        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsulta x = new frmConsulta();
            x.ShowDialog();
        }
        public void LimpiarInterfaz()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            cmbMarca.SelectedIndex = 0;
            optNacional.Checked = true;
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) &&
               e.KeyChar != ',' && e.KeyChar != (int)Keys.Back)
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' && txtPrecio.Text.Contains(","))
            {
                e.Handled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarInterfaz();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
