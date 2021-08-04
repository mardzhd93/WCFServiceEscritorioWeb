using EvaluacionEscritorioSOA.Entities;
using EvaluacionEscritorioSOA.Process;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluacionEscritorioSOA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                cmbFiltro.Items.Add("Ventas Por Articulo");
                cmbFiltro.Items.Add("Ventas Globales");
                cmbFiltro.Items.Add("Articulo Mas Vendidos");
                cmbFiltro.Items.Add("Cantidad Productos Existentes");
                cmbFiltro.Items.Add("Cantidad Baja Inventario");
                cmbFiltro.SelectedIndex = 0;
                dtGVWEstad.Visible = false;
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            var ventas = cmbFiltro.Text;
            try
            {
                VentasEInventario_BP VentasBP = new VentasEInventario_BP();

                if (ventas.Contains("Articulo"))
                {

                    dtGVWEstad.DataSource = VentasBP.obtenerVentasporArticulo_BP(ventas);
                }
                else if (ventas.Contains("Globales"))
                {
                    dtGVWEstad.DataSource = VentasBP.obtenerVentasGlobales_BP(ventas);
                }
                else
                {
                    dtGVWEstad.DataSource = VentasBP.obtenerCantidadArticulos_BP(ventas);
                }
                dtGVWEstad.Visible = true;

            }
            catch (Exception)
            {
                throw;
            }
         
        }
    }
}
