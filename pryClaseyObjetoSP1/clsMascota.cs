using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace pryClaseyObjetoSP1
{
    internal class Archivo
    {
     
        public string NombreArchivo { get; set; }
        
        public bool GrabarRepuesto(clsRepuestos repuesto)
        {
            bool resultado = false;
            if (NombreArchivo != "")
            {
                StreamWriter sw = new StreamWriter(NombreArchivo, true);
                sw.WriteLine(repuesto.Codigo + "," + 
                    repuesto.Nombre + 
                    "," + repuesto.Marca + 
                    "," + repuesto.Precio.ToString("#.00", CultureInfo.InvariantCulture) + "," 
                    + repuesto.Origen);
                sw.Close();
                sw.Dispose();
                resultado = true;   
            }
            return resultado;
        }
        public bool BuscarCodigo(string codigo)
        {
            //recibe el codigo del repuesto a buscar
            bool resultado = false;
            string Linea;
            string CodigoRepuesto;
            //verificar si existe el archivo
            if(NombreArchivo != "" && File.Exists(NombreArchivo))
            {
                StreamReader sr = new StreamReader(NombreArchivo);
                while(sr.EndOfStream == false)
                {
                    Linea = sr.ReadLine();  
                    CodigoRepuesto = Linea.Split(',')[0];
                    //compara los codigos
                    if(CodigoRepuesto == codigo) //si coinciden
                    {
                        resultado = true; 
                        break;
                    }
                }
                sr.Close();
                sr.Dispose();
            }
            return resultado;
        }
        public List <clsRepuestos> ObtenerRepuestos()
        {
            List <clsRepuestos> listaRep = new List<clsRepuestos>();
            string Linea;
            if(NombreArchivo != "" && File.Exists (NombreArchivo))
            {
                StreamReader sr = new StreamReader(NombreArchivo);
                while(sr.EndOfStream == false) 
                {
                    Linea = sr.ReadLine(); //lee una linea
                    clsRepuestos rep = new clsRepuestos();
                    rep.Codigo = Linea.Split(',')[0];
                    rep.Nombre = Linea.Split(',')[1];
                    rep.Marca = Linea.Split(',')[2];
                    rep.Precio = decimal.Parse(Linea.Split(',')[3], CultureInfo.InvariantCulture);
                    rep.Origen = Linea.Split(',')[4];
                    listaRep.Add(rep);
                }
                sr.Close(); 
                sr.Dispose();   
            }
            return listaRep;
        }
        public List <clsRepuestos> ObtenerRepOrdenados()
        {
            List<clsRepuestos> Lista = ObtenerRepuestos();
            clsRepuestos[] repArray = Lista.ToArray();
            
            for(int i = 0; i < repArray.Length - 1; i++)//ordena de menor a mayot 
            {
                for(int c = 0; c < repArray.Length - 1; c++)
                {
                    if (string.Compare(repArray[c].Nombre, repArray[c+1].Nombre) > 0)
                    {
                        clsRepuestos aux = repArray[c];
                        repArray[c] = repArray[c+1];
                        repArray[c+1] = aux;
                    }
                }

            }
            List<clsRepuestos> Ordenados = repArray.ToList<clsRepuestos>();//convierte el arreglo ordenado en una lista
            return Ordenados;
        }
    }
}
