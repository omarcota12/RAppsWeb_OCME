using System;
using System.Collections.Generic;
using System.Text;

namespace RAppsWeb_OCME.Models
{
    public class Pmodelo
    {
        public double MontoCuenta { get; set; }
        public double PorcentajePropina { get; set; }
        public int NumeroPersonas { get; set; }

        public double TotalPropina => (MontoCuenta * PorcentajePropina) / 100;

        public double TotalPagar => MontoCuenta + TotalPropina;

        public double MontoPorPersona => NumeroPersonas > 0 ? TotalPagar / NumeroPersonas : 0;

        public string Carita => PorcentajePropina >= 10 ? "https://i.ibb.co/VT3n5NQ/feli.png" : "https://i.ibb.co/bFRrN0X/tiste.png";
    }
}



