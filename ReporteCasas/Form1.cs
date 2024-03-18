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

namespace ReporteCasas
{
    public partial class Form1 : Form
    {
        List<Propiedad> propiedads = new List<Propiedad>();
        List<Cliente> clients = new List<Cliente>();
        List<Reporte> reportes = new List<Reporte>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cargarPropiedad() {

            string fileName = "Propiedades.txt";
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while(reader.Peek() >-1) {
            
                Propiedad propiedades = new Propiedad();
                propiedades.NumeroCasa=Convert.ToInt16(reader.ReadLine()) ;
                propiedades.Dpi = Convert.ToInt64(reader.ReadLine());
                propiedades.Cuota=Convert.ToInt16(reader.ReadLine());
                propiedads.Add(propiedades);

            }
            reader.Close();
        
        }

        private void cargarClientes()
        {
            string fileName = "Clientes.txt";
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1)
            {

                Cliente clientes = new Cliente();
                clientes.Dpi = Convert.ToInt64(reader.ReadLine());
                clientes.Nombre = reader.ReadLine();
                clientes.Apellido = reader.ReadLine();
                clients.Add(clientes); ;
            }
            reader.Close(); 


        }

        public void mostrarReporte() {

            dataGridInfo.DataSource = null; 
            dataGridInfo.DataSource = reportes;
            dataGridInfo.Refresh();
            
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            cargarClientes();
            cargarPropiedad();

            if(reportes.Count == 0)
            {

                foreach (Cliente cliente in  clients)
                {
                    Propiedad propiedad = propiedads.FirstOrDefault( C => C.Dpi == cliente.Dpi);

                    if (propiedad != null)
                    {
                        Reporte reporte = new Reporte();
                        reporte.Nombre= cliente.Nombre;
                        reporte.Apellido= cliente.Apellido;
                        reporte.NumeroCasa=propiedad.NumeroCasa;
                        reporte.Cuota = propiedad.Cuota;

                        reportes.Add(reporte); 

                    }
                }
                mostrarReporte();
            }
        }
    }
}
