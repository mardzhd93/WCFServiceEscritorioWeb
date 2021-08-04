using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFServiceSOA
{
    [ServiceContract]
    public interface IWCFServiceSOA
    {

        [OperationContract]
        List<Ventas> obtenerVentasporArticulo(string ventas);
        [OperationContract]
        List<Articulos> obtenerCantidadArticulos(string ventas);
        [OperationContract]
        List<VentasGlobales> obtenerVentasGlobales(string ventas);

    }

    [DataContract]
    public class Ventas
    {
        private string titulo;
        private string descripcion;
        private int cantidadVendida;
        private DateTime fecha;

      
        [DataMember]
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        [DataMember]
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        [DataMember]
        public int CantidadVendida
        {
            get { return cantidadVendida; }
            set { cantidadVendida = value; }
        }
        [DataMember]
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
       
    }
    [DataContract]
    public class Articulos
    {
        private string titulo;
        private string descripcion;
        private int existencias;


        [DataMember]
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        [DataMember]
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        [DataMember]
        public int Existencias
        {
            get { return existencias; }
            set { existencias = value; }
        }

    }
    [DataContract]
    public class VentasGlobales
    {
        private int cantidadVendida;
        private decimal totalVentas;

        [DataMember]
        public int CantidadVendida
        {
            get { return cantidadVendida; }
            set { cantidadVendida = value; }
        }

        [DataMember]
        public decimal TotalVentas
        {
            get { return totalVentas; }
            set { totalVentas = value; }
        }

    }
}
