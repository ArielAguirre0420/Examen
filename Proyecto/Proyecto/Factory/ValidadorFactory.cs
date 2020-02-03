using Proyecto.Interfaces;
using Proyecto.Utils;
using Proyecto.Validadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Factory
{
    public class ValidadorFactory
    {
        public static IValidador ObtenerInstacia(Paqueteria paqueteria)
        {
            IValidador validador = null;

            switch (paqueteria)
            {
                case Paqueteria.DHL:
                    validador = new ValidadorDHL();
                    break;
                case Paqueteria.Estafeta:
                    validador =  new ValidadorEstafeta();
                    break;
                case Paqueteria.Fedex:
                    validador = new ValidadorFedex();
                    break;
            }

            return validador;
        }
    }
}
