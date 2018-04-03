using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio_3
{
    class Accesorios
    {
        string Tipos;
        double Precio;
        public Accesorios(string ntipo, double nprecio)
        {
            Tipos = ntipo;
            Precio = nprecio;
        }
        public string GetTipo()
        {
            return Tipos;
        }
        public double GetPrecio()
        {
            return Precio;
        }
    
    }
}
