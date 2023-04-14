using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryClaseyObjetoSP1
{
    public partial class frmConsulta : Form
    {
        private string PATH_ARCHIVO;
        public frmConsulta(string Path)
        {
            InitializeComponent();
            PATH_ARCHIVO = Path;
        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {
            LimpiarInterfaz();
            cmbMarca.Items.Add("Marca A");
            cmbMarca.Items.Add("Marca B");
            cmbMarca.Items.Add("Marca C");
        }
        public void LimpiarInterfaz()
        {
            cmbMarca.SelectedItem = 0;
            optNacional.Checked = true;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + "\\" + PATH_ARCHIVO))
            {
                MessageBox.Show("No hay datos para mostrar", "Consulta",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            // leer el contenido del archivo
            Archivo Repuestos = new Archivo();
            Repuestos.NombreArchivo = PATH_ARCHIVO;
            List<Repuestos> repuestos = Repuestos.ObtenerRepOrdenados();
            // limpiar la grilla
            dgvRepuestos.Rows.Clear();
            // recorrer la lista de repuestos
            foreach (Repuestos repuesto in repuestos)
            {
                // controlar el valor de la Marca
                if (repuesto.Marca == cmbMarca.SelectedItem.ToString())
                {
                    // controlar el tipo de Origen y los botones de opción
                    //activos
                if (optImportado.Checked && repuesto.Origen == "Importado")
                    {
                        // agregar el repuesto a la grilla
                        dgvRepuestos.Rows.Add(repuesto.Codigo, repuesto.Nombre,
                        repuesto.Marca, repuesto.Origen,
                        repuesto.Precio.ToString());
                    }
                    else
                    {
                        if (optNacional.Checked && repuesto.Origen == "Nacional")
                        {
                            // agregar el repuesto a la grilla
                            dgvRepuestos.Rows.Add(repuesto.Codigo,
                            repuesto.Nombre,
                            repuesto.Marca, repuesto.Origen,
                            repuesto.Precio.ToString());
                        }
                        else
                        {
                            if (optAmbos.Checked)
                            {
                                // agregar el repuesto a la grilla
                                dgvRepuestos.Rows.Add(repuesto.Codigo,
                                repuesto.Nombre,
                                repuesto.Marca, repuesto.Origen,
                                repuesto.Precio.ToString());
                            }
                        }
                    }
                }

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
