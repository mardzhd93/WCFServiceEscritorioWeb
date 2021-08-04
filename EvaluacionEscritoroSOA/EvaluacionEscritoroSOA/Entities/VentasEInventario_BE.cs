using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionEscritorioSOA.Entities
{
   public class VentasEInventario_BE
    {
        private string titulo;
        private int idProductos;
        private string descripcion;
        private double precioUnitario;
        private int existencias;
        private int idVentas;
        private int cantidadVendida;
        private DateTime fecha;
        public int IDProductos
        {
            get { return idProductos; }
            set { idProductos = value; }
        }

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public double PrecioUnitario
        {
            get { return precioUnitario; }
            set { precioUnitario = value; }
        }

        public int Existencias
        {
            get { return existencias; }
            set { existencias = value; }
        }

        public int IDVentas
        {
            get { return idVentas; }
            set { idVentas = value; }
        }

        public int CantidadVendida
        {
            get { return cantidadVendida; }
            set { cantidadVendida = value; }
        }
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
    }
}
