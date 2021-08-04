using EvaluacionEscritorioSOA.Entities;
using EvaluacionEscritoroSOA.WCFServiceSOA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionEscritorioSOA.DataAccess
{
   public class VentasEInventario_DA
    {
        public Ventas[] obtenerVentasporArticulo_DA(string ventas)
        {
            try
            {
                using (EvaluacionEscritoroSOA.WCFServiceSOA.WCFServiceSOAClient client = new EvaluacionEscritoroSOA.WCFServiceSOA.WCFServiceSOAClient())
                {

                    return client.obtenerVentasporArticulo(ventas);
                    
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        public VentasGlobales[] obtenerVentasGlobales_DA(string ventas)
        {
            try
            {
                using (EvaluacionEscritoroSOA.WCFServiceSOA.WCFServiceSOAClient client = new EvaluacionEscritoroSOA.WCFServiceSOA.WCFServiceSOAClient())
                {

                    return client.obtenerVentasGlobales(ventas);

                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        public Articulos[] obtenerCantidadArticulos_DA(string ventas)
        {
            try
            {
                using (EvaluacionEscritoroSOA.WCFServiceSOA.WCFServiceSOAClient client = new EvaluacionEscritoroSOA.WCFServiceSOA.WCFServiceSOAClient())
                {

                    return client.obtenerCantidadArticulos(ventas);

                }
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
