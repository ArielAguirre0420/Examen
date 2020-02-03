using Proyecto.Interfaces;
using Proyecto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Clases
{
    public class AliExpressEstafeta : IPaquete
    {
        private Pedido _pedido = null;

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
            throw new NotImplementedException();
        }

        public string CalcularCostoEnvio()
        {
            throw new NotImplementedException();
        }
    }
}
