using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReporteCasas
{
    internal class Reporte
    {
        string nombre;
        string apellido;
        int numeroCasa;
        int cuota;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int NumeroCasa { get => numeroCasa; set => numeroCasa = value; }
        public int Cuota { get => cuota; set => cuota = value; }
    }
}
