using Proyecto.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Interfaces
{
    public interface IValidador
    {
        void setTransporte(Transporte transporte);

        bool ValidarPaquete();
    }
}
