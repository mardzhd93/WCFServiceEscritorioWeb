using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFServiceSOA
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class WCFServiceSOA : IWCFServiceSOA
    {
        public List<Articulos> obtenerCantidadArticulos(string ventas)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=IROXIT031\\SQLEXPRESS;Initial Catalog=IroxIT;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("dbo.USP_VentasEInventario", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Filtro", SqlDbType.NVarChar).Value = ventas;
                using (SqlDataReader r = cmd.ExecuteReader())
                {

                    List<Articulos> VentasporArticulo = new List<Articulos>();
                    while (r.Read())
                    {
                        VentasporArticulo.Add(new Articulos()
                        {
                            Titulo = (string)r["Titulo"]
                            ,
                            Descripcion = (string)r["Descripcion"]
                            ,
                            Existencias = (int)r["Existencias"]

                        });
                    }
                    return VentasporArticulo;
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public List<VentasGlobales> obtenerVentasGlobales(string ventas)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=IROXIT031\\SQLEXPRESS;Initial Catalog=IroxIT;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("dbo.USP_VentasEInventario", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Filtro", SqlDbType.NVarChar).Value = ventas;
                using (SqlDataReader r = cmd.ExecuteReader())
                {

                    List<VentasGlobales> VentasGlobales = new List<VentasGlobales>();
                    while (r.Read())
                    {
                        VentasGlobales.Add(new VentasGlobales()
                        {
                            CantidadVendida = (int)r["CantidadVendida"]
                            ,
                            TotalVentas = (decimal)r["TotalVentas"]
                        }); ;
                    }
                    return VentasGlobales;
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }


        List<Ventas> IWCFServiceSOA.obtenerVentasporArticulo(string ventas)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=IROXIT031\\SQLEXPRESS;Initial Catalog=IroxIT;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("dbo.USP_VentasEInventario", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Filtro", SqlDbType.NVarChar).Value = ventas;
                using (SqlDataReader r = cmd.ExecuteReader())
                {

                    List<Ventas> Inventario = new List<Ventas>();

                    while (r.Read())
                    {
                        Inventario.Add(new Ventas()
                        {
                            Titulo = (string)r["Titulo"]
                        ,
                            Descripcion = (string)r["Descripcion"]
                        ,
                            CantidadVendida = (int)r["CantidadVendida"]
                        ,
                            Fecha = (DateTime)r["Fecha"]
                        });
                    }
                    return Inventario;
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
    }
    

