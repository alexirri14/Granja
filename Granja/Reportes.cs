// Elimine using innecesarios para mantener el código limpio

namespace Granja
{
    public partial class Reportes : Form
    {
        private Button btnActivo;

        public Reportes()
        {
            InitializeComponent();
            btnActivo = btnProduccionGalpon;
            MostrarReporteProduccionGalpon();

            btnProduccionGalpon.Click += (s, e) => CambiarReporte(btnProduccionGalpon, MostrarReporteProduccionGalpon);
            btnStockActual.Click += (s, e) => CambiarReporte(btnStockActual, MostrarReporteStockActual);
        }

        private void CambiarReporte(Button btnSeleccionado, Action mostrarReporte)
        {
            btnActivo.BackColor = Color.FromArgb(230, 230, 230);
            btnActivo.ForeColor = Color.FromArgb(44, 62, 80);

            btnSeleccionado.BackColor = Color.FromArgb(0, 125, 62);
            btnSeleccionado.ForeColor = Color.White;

            btnActivo = btnSeleccionado;
            mostrarReporte();
        }

        private void MostrarReporteProduccionGalpon()
        {
            panelContenido.Controls.Clear();

            var panelGrafico = new Panel { Location = new Point(0, 0), Size = new Size(1189, 300), BackColor = Color.White, Padding = new Padding(20) };
            var lblTituloGrafico = new Label { Text = "[Cambiar de Nombre]", Location = new Point(20, 10), Font = new Font("Segoe UI", 12F, FontStyle.Bold), ForeColor = Color.FromArgb(26, 32, 44), AutoSize = true };
            panelGrafico.Controls.Add(lblTituloGrafico);

            var panelDatos = new Panel { Location = new Point(0, 310), Size = new Size(1189, 220), BackColor = Color.White, Padding = new Padding(20) };
            var lblTituloDatos = new Label { Text = "Datos", Location = new Point(20, 10), Font = new Font("Segoe UI", 12F, FontStyle.Bold), ForeColor = Color.FromArgb(26, 32, 44), AutoSize = true };

            var dgvDatos = new DataGridView
            {
                Location = new Point(20, 50),
                Size = new Size(1149, 150),
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize,
                AllowUserToAddRows = false,
                RowHeadersVisible = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };
            dgvDatos.Columns.Add("[Cambiar de Nombre]", "[Cambiar de Nombre]");
            dgvDatos.Columns.Add("[Cambiar de Nombre]", "[Cambiar de Nombre]");
            dgvDatos.Rows.Add("Galpón A", "300 insumos consumidos");
            dgvDatos.Rows.Add("Galpón B", "250 insumos consumidos");
            dgvDatos.Rows.Add("Galpón C", "280 insumos consumidos");
            dgvDatos.Rows.Add("Galpón A", "290 insumos consumidos");

            panelDatos.Controls.Add(lblTituloDatos);
            panelDatos.Controls.Add(dgvDatos);

            panelContenido.Controls.Add(panelGrafico);
            panelContenido.Controls.Add(panelDatos);
        }

        private void MostrarReporteStockActual()
        {
            panelContenido.Controls.Clear();

            var panelGrafico = new Panel { Location = new Point(0, 0), Size = new Size(1189, 300), BackColor = Color.White, Padding = new Padding(20) };
            var lblTituloGrafico = new Label { Text = "Stock Actual", Location = new Point(20, 10), Font = new Font("Segoe UI", 12F, FontStyle.Bold), ForeColor = Color.FromArgb(26, 32, 44), AutoSize = true };
            panelGrafico.Controls.Add(lblTituloGrafico);

            var panelDatos = new Panel { Location = new Point(0, 310), Size = new Size(1189, 220), BackColor = Color.White, Padding = new Padding(20) };
            var lblTituloDatos = new Label { Text = "Datos", Location = new Point(20, 10), Font = new Font("Segoe UI", 12F, FontStyle.Bold), ForeColor = Color.FromArgb(26, 32, 44), AutoSize = true };

            var dgvDatos = new DataGridView
            {
                Location = new Point(20, 50),
                Size = new Size(1149, 150),
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize,
                AllowUserToAddRows = false,
                RowHeadersVisible = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };
            dgvDatos.Columns.Add("Producto", "Producto");
            dgvDatos.Columns.Add("Cantidad", "Cantidad");
            dgvDatos.Rows.Add("Huevos", "8500");
            dgvDatos.Rows.Add("Alimento", "300");

            panelDatos.Controls.Add(lblTituloDatos);
            panelDatos.Controls.Add(dgvDatos);

            panelContenido.Controls.Add(panelGrafico);
            panelContenido.Controls.Add(panelDatos);
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
