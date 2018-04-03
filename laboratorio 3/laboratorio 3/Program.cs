using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cliente> Clientela;
            List<Accesorios> AccesoriosDisponibles;
            List<Sucursal> Inventario;
            List<Arriendo> historial;
            List<> pedido;
            Cliente a;
            List<Accesorios> AccesoriosSeleccionados;
            string tipo;
            Vehiculo movil;
            string nombre;
            string lugar;
            Console.WriteLine("introduzca el nombre del cliente");
            nombre = Console.ReadLine();
            foreach(Cliente g in Clientela)
            {
                if (g.GetNombre() == nombre)
                {
                    a=g
                }
            }
            
            Console.WriteLine("introduzca la sucursal en la que quiere buscar");
            lugar = Console.ReadLine();
            Console.WriteLine("los tipos disponibles son los siguientes:");
            foreach (Sucursal g in Inventario)
            {
                if (g.GetSucursal() == lugar)
                {
                    Console.WriteLine(g.GetTipo());
                }
            }
            Console.WriteLine("introduzca el tipo de vehiculo deseado");
            tipo = Console.ReadLine();
            foreach (Cliente g in Clientela)
            {
                if (g.GetNombre() == nombre)
                {
                    a = g
                }
            }


            pedido.Add(a.GetNombre());
            pedido.Add(tipo);
            pedido.Add(AccesoriosSeleccionados);

        }
    }
}
