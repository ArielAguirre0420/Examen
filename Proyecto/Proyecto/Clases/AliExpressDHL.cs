using Proyecto.Interfaces;
using Proyecto.Models;
using Proyecto.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Clases
{
    public class AliExpressDHL : IPaquete
    {
        private Pedido _pedido = null;

        private Operaciones _operaciones = null;

        public AliExpressDHL()
        {
            _operaciones = new Operaciones();
        }

        public void setPedido(Pedido pedido)
        {
            _pedido = pedido;
        }

        public string CalcularFechaEntrega()
        {
            throw new NotImplementedException();
        }

        public string CalcularTiempoEntrega()
        {
            int velocidad = _operaciones.VelocidadTren();

            return (_pedido.Distancia / velocidad).ToString();
        }

        public string CalcularCostoEnvio()
        {
            //(Costo por km del [Medio de Transporte] * [Distancia]) * (1 + Margen de utilidad de la[Paquetería]/ 100)
            int costo = _operaciones.PrecioTren();

            return ((costo * _pedido.Distancia) * ( (1 + 40) / 100 )).ToString();
        }
    }
}
