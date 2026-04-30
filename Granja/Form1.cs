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
        }

    }
}
