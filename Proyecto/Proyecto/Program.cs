using Proyecto.Models;
using Proyecto.Services;
using Proyecto.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class Program
    {
        static readonly string cMensaje = "Tu paquete {0} de {1} y {2} a {3} {4} y {5} un costo de ${6}. (Cualquier reclamo con {7})";

        static void Main(string[] args)
        {

            Pedido pedido = new Pedido("Motul", "Tizimin", 80, Paqueteria.DHL, Transporte.Tren, DateTime.Parse("24/01/2020"));

            AliExpressService service = new AliExpressService(pedido.Paqueteria);
             
            try
            {
                
                bool v = service.Validar(pedido.Transporte);

                string t = service.ProcesarPaquete(pedido);

                //Console.WriteLine(cMensaje, "salio", "NewYork", "llegará", "Yucatán", t, "tendra", "500 pesos", "DHL");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
            /**
             * Si la fecha de hoy es 23-01-2020 14:00:00 y si se tiene un archivo con la siguiente información:
             * Ticul,Motul,80,Estafeta,Tren,23-01-2020 12:00:00
             * Tu paquete salió de Ticul y llegó a Motul hace 1 hora y tuvo un costo de $480 (cualquier
               reclamación con Estafeta).
             * */

            /**
             * logica
             * validar la empresa tenga el tranporte
             * calcular fechas
             * imprimir resultado
             * */

            /***
             * empresas
             * DHL -- barco
             * Estafecta -- avion , barco
             * fedex -- tren
             * */


            /***
             * **/

        }
    }
}
