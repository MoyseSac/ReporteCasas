using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReporteCasas
{
    internal class Propiedad
    {
        int numeroCasa;
        long dpi;
        int cuota;

        public int NumeroCasa { get => numeroCasa; set => numeroCasa = value; }
        public long Dpi { get => dpi; set => dpi = value; }
        public int Cuota { get => cuota; set => cuota = value; }
    }
}
