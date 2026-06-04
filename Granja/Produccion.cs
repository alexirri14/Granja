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
    public partial class Produccion : Form
    {
        public Produccion()
        {
            InitializeComponent();
            PopulateData();
        }

        private void PopulateData()
        {
            dgvProduccionList.Columns.Add("Galpon", "Galpón");
            dgvProduccionList.Columns.Add("Fecha", "Fecha");
            dgvProduccionList.Columns.Add("Huevos", "Huevos");

            dgvProduccionList.Rows.Add("A", "8/4/2026", "300");
            dgvProduccionList.Rows.Add("B", "8/4/2026", "250");
            dgvProduccionList.Rows.Add("C", "7/4/2026", "280");
            dgvProduccionList.Rows.Add("A", "7/4/2026", "290");
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Form1 dashboard = new Form1();
            dashboard.Show();
            this.Hide();
        }

        private void btnProduccion_Click_1(object sender, EventArgs e)
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
