using Proyecto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Interfaces
{
    public interface IPaquete
    {
        void setPedido(Pedido pedido);
        string CalcularFechaEntrega();
        string CalcularTiempoEntrega();
        string CalcularCostoEnvio();
    }
}
