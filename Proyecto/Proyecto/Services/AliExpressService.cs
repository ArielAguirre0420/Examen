using Proyecto.Factory;
using Proyecto.Interfaces;
using Proyecto.Models;
using Proyecto.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Services
{
    public class AliExpressService
    {
        private readonly IValidador _validador = null;

        private readonly IPaquete _paquete = null;


        public AliExpressService(Paqueteria paqueteria)
        {
            _paquete = PaqueteriaFactory.ObtenerInstacia(paqueteria);

            _validador = ValidadorFactory.ObtenerInstacia(paqueteria);
        }

        public bool Validar(Transporte transporte)
        {
            _validador.setTransporte(transporte);

            return _validador.ValidarPaquete();
        }

        public string ProcesarPaquete(Pedido pedido)
        {
            _paquete.setPedido(pedido);
            
            //string entrega =_paquete.CalcularFechaEntrega();

            string precio = _paquete.CalcularTiempoEntrega();

            return precio;
        }
    }
}
