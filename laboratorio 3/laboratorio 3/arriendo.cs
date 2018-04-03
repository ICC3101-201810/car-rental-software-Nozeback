using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio_3
{
    class Arriendo
    {
        DateTime FechaDeInicio;
        DateTime FechaDeTermino;
        double PrecioTotal;
        Vehiculo Veh;
        Accesorios Acc;
        Sucursal Suc;
        public Arriendo(DateTime nFechaDeInicio, DateTime nFechaDeTermino, double nPrecioTotal, Vehiculo nVeh, Accesorios nAcc, Sucursal nSuc)
        {
            FechaDeInicio = nFechaDeInicio;
            FechaDeTermino = nFechaDeTermino;
            PrecioTotal = nPrecioTotal;
            Veh = nVeh;
            Acc = nAcc;
            Suc = nSuc;
        }
        public DateTime GetFechaDeInicio() {
            return FechaDeInicio;
            }
        public DateTime GetFechaDeTermino()
        {
            return FechaDeTermino;
        }
        public double GetPrecioTotal()
        {
            return PrecioTotal;
        }
        public Vehiculo GetVehiculo()
        {
            return Veh;
        }
        public Accesorios GetAccesorios()
        {
            return Acc;
        }
        public Sucursal GetSucursal()
        {
            return Suc;
        }
    }
}
