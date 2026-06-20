// Elimine using innecesarios para mantener el código limpio

namespace Granja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PopulateData();
        }

        private void PopulateData()
        {
            dgvProduccion.Columns.Add("Galpon", "Galpón");
            dgvProduccion.Columns.Add("Fecha", "Fecha");
            dgvProduccion.Columns.Add("Huevos", "Huevos");

            dgvProduccion.Rows.Add("A", "8/4/2026", "300");
            dgvProduccion.Rows.Add("B", "8/4/2026", "250");
            dgvProduccion.Rows.Add("C", "7/4/2026", "280");
            dgvProduccion.Rows.Add("A", "7/4/2026", "290");

            dgvInsumos.Columns.Add("Insumo", "Insumo");
            dgvInsumos.Columns.Add("StockActual", "Stock Actual");
            dgvInsumos.Columns.Add("StockMinimo", "Stock Mínimo");
            dgvInsumos.Columns.Add("Estado", "Estado");

            dgvInsumos.Rows.Add("Maíz", "2500.00 KG", "500.00 KG", "Normal");
            dgvInsumos.Rows.Add("Torta de Soya", "1200.00 KG", "300.00 KG", "Normal");
            dgvInsumos.Rows.Add("Soya Integral", "800.00 KG", "200.00 KG", "Normal");
            dgvInsumos.Rows.Add("Afrechillo", "600.00 KG", "150.00 KG", "Normal");
            dgvInsumos.Rows.Add("Sal Industrial", "400.00 KG", "100.00 KG", "Normal");
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Form1 dashboard = new Form1();
            dashboard.Show();
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
