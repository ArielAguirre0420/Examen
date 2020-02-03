using Proyecto.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Models
{
    public class Pedido
    {
        public Pedido(
            string origen,
            string destino,
            int distancia,
            Paqueteria paqueteria,
            Transporte transporte,
            DateTime fecha)
        {
            Origen = origen;
            Destino = destino;
            Distancia = distancia;
            Paqueteria = paqueteria;
            Transporte = transporte;
            FechaPetido = fecha;
        }

        public string Origen { get; set; }
        public string Destino { get; set; }
        public int Distancia { get; set; }
        public Paqueteria Paqueteria { get; set; }
        public Transporte Transporte { get; set; }
        public DateTime FechaPetido { get; set; }
    }
}
