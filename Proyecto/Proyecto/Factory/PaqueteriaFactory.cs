using Proyecto.Clases;
using Proyecto.Interfaces;
using Proyecto.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Factory
{
    public class PaqueteriaFactory
    {
        public static IPaquete ObtenerInstacia(Paqueteria paqueria)
        {
            IPaquete paquete = null;

            switch (paqueria)
            {
                case Paqueteria.DHL:
                    paquete = new AliExpressDHL();
                    break;
                case Paqueteria.Estafeta:
                    paquete = new AliExpressEstafeta();
                    break;
                case Paqueteria.Fedex:
                    paquete = new AliExpressFedex();
                    break;
            }

            return paquete;
        }
    }
}
