using EvaluacionEscritorioSOA.DataAccess;
using EvaluacionEscritorioSOA.Entities;
using EvaluacionEscritoroSOA.WCFServiceSOA;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionEscritorioSOA.Process
{
    public class VentasEInventario_BP
    {

        public Ventas[] obtenerVentasporArticulo_BP(string ventas)
        {   
            try
            {
                VentasEInventario_DA Ventas_DA = new VentasEInventario_DA();
                return Ventas_DA.obtenerVentasporArticulo_DA(ventas);
            }
            catch (Exception)
            {

                throw;
            }

        }
        public Articulos[] obtenerCantidadArticulos_BP(string ventas)
        {
            try
            {
                VentasEInventario_DA Ventas_DA = new VentasEInventario_DA();
                return Ventas_DA.obtenerCantidadArticulos_DA(ventas);
            }
            catch (Exception)
            {

                throw;
            }

        }
        public VentasGlobales[] obtenerVentasGlobales_BP(string ventas)
        {
            try
            {
                VentasEInventario_DA Ventas_DA = new VentasEInventario_DA();
                return Ventas_DA.obtenerVentasGlobales_DA(ventas);
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
