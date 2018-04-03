using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio_3
{
    class Vehiculo
    {
        string tipo;
        string patente;
        string licencia;
        double precio;
        public Vehiculo(string ntipo, string npatente, string nlicencia, double nprecio):base()
        {
            tipo = ntipo;
            patente = npatente;
            licencia = nlicencia;
            precio = nprecio;
        }
        public string GetTipo()
        {
            return tipo;
        }
        public string GetLicencia()
        {
            return licencia;
        }
        public string GetPatente()
        {
            return patente;
        }
        public double GetPrecio()
        {
            return precio;
        }
    }
}
