using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Granja
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
            PopulateData();
        }

        private void PopulateData()
        {
            dgvVentas.Columns.Add("Fecha", "Fecha");
            dgvVentas.Columns.Add("Cliente", "Cliente");
            dgvVentas.Columns.Add("Cantidad", "Cantidad");
            dgvVentas.Columns.Add("Precio", "Precio");
            dgvVentas.Columns.Add("Total", "Total");

            dgvVentas.Rows.Add("8/4/2026", "Juan Pérez", "200", "S/ 7.50", "S/ 1500.00");
            dgvVentas.Rows.Add("8/4/2026", "María García", "150", "S/ 7.50", "S/ 1125.00");
            dgvVentas.Rows.Add("7/4/2026", "Pedro López", "300", "S/ 7.50", "S/ 2250.00");
            dgvVentas.Rows.Add("7/4/2026", "Ana Torres", "100", "S/ 7.50", "S/ 750.00");
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Form1 dashboard = new Form1();
            dashboard.Show();
            this.Hide();
        }

        private void btnProduccion_Click(object sender, EventArgs e)
        {
            Produccion produ = new Produccion();
            produ.Show();
            this.Hide();
        }

        private void btnAlmacen_Click(object sender, EventArgs e)
        {
            Almacen alma = new Almacen();
            alma.Show();
            this.Hide();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            Ventas formventa = new Ventas();
            formventa.Show();
            this.Hide();
        }

        private void btnAlimento_Click(object sender, EventArgs e)
        {
            Alimento formAlimento = new Alimento();
            formAlimento.Show();
            this.Hide();
        }

        private void btnMolino_Click(object sender, EventArgs e)
        {
            Molino mol = new Molino();
            mol.Show();
            this.Hide();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            Reportes repor = new Reportes();
            repor.Show();
            this.Hide();
        }

        private void btnInsumos_Click(object sender, EventArgs e)
        {
            Insumos ins = new Insumos();
            ins.Show();
            this.Hide();
        }


    }
}
