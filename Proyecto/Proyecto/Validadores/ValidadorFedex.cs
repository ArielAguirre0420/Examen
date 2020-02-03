using Proyecto.Interfaces;
using Proyecto.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Validadores
{
    public class ValidadorFedex : IValidador
    {
        Transporte _transporte;

        public void setTransporte(Transporte transporte)
        {
            _transporte = transporte;
        }

        public bool ValidarPaquete()
        {
            bool result = false;

            if (_transporte == Transporte.Barco)
            {
                result = true;
            }

            return result;
        }
    }
}
