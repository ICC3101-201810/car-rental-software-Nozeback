using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio_3
{
    class Cliente
    {
        string Nombre;
        string Tipo;
        string Identificador;
        List<string> Licencias;
        public cliente(string nnombre, string ntipo, string nidentificador, List<string> nlicencias)
        {
            nombre = nnombre;
            tipo = ntipo;
            nidentificador = identificador;
            licencias = nlicencias;
        }
        public string GetNombre()
        {
            return nombre;
        }
        public string GetTipo()
        {
            return tipo;
        }
        public string GetIdentificador()
        {
            return identificador;
        }
        public List<string> GetLicencias()
        {
            return licencias;
        }
    }
}
