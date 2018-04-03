using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio_3
{
    class Sucursal : Vehiculo
    {
        string ubicacion;
        public Sucursal(string nubicacion) { 
            ubicacion = nubicacion;
        }
        public string GetSucursal()
        {
            return ubicacion;
        }

    }
}
