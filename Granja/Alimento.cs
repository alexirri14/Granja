using System.Data;
// Elimine using innecesarios para mantener el código limpio

namespace Granja
{
    public partial class Alimento : Form
    {
        public Alimento()
        {
            InitializeComponent();
            PopulateData();
        }

        private void PopulateData()
        {
            // Cargar datos iniciales si no existen
            if (!GlobalData.MovimientosAlimento.Any())
            {
                GlobalData.MovimientosAlimento.Add(new MovimientoAlimento { Fecha = DateTime.Now.AddDays(-1), Tipo = "Ingreso (Molino)", CantidadSacos = 50, Observaciones = "Producción inicial" });
                GlobalData.MovimientosAlimento.Add(new MovimientoAlimento { Fecha = DateTime.Now.AddDays(-2), Tipo = "Consumo (Producción)", CantidadSacos = 20, Observaciones = "Consumo de producción" });
            }
            ActualizarUI();
        }

        private void ActualizarUI()
        {
            // Actualizar stock total
            lblStockTotal.Text = $"{GlobalData.StockAlimentoSacos:F2} sacos";

            // Cargar movimientos
            dgvMovimientos.Columns.Clear();
            dgvMovimientos.Columns.Add("Fecha", "Fecha");
            dgvMovimientos.Columns.Add("Tipo", "Tipo");
            dgvMovimientos.Columns.Add("Cantidad", "Cantidad");
            dgvMovimientos.Columns.Add("Observaciones", "Observaciones");

            foreach (var mov in GlobalData.MovimientosAlimento.OrderByDescending(m => m.Fecha))
            {
                string cantidadFormateada = mov.CantidadSacos >= 0 ? $"+{mov.CantidadSacos:F2}" : $"{mov.CantidadSacos:F2}";
                dgvMovimientos.Rows.Add(mov.Fecha.ToString("dd/MM/yyyy"), mov.Tipo, cantidadFormateada, mov.Observaciones);
            }
        }

        private void btnRegistrarPerdida_Click(object sender, EventArgs e)
        {
            panelNuevoPerdida.Visible = true;
            panelMovimientos.Location = new Point(34, 480);
        }

        private void btnCancelarPerdida_Click(object sender, EventArgs e)
        {
            panelNuevoPerdida.Visible = false;
            panelMovimientos.Location = new Point(34, 180);
            txtCantidadPerdida.Clear();
        }

        private void btnRegistrarPerdida2_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCantidadPerdida.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida de sacos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Registrar pérdida
            GlobalData.StockAlimentoSacos -= cantidad;
            GlobalData.MovimientosAlimento.Add(new MovimientoAlimento
            {
                Fecha = dtpFechaPerdida.Value,
                Tipo = "Pérdida",
                CantidadSacos = -cantidad,
                Observaciones = "Registro manual de pérdida"
            });

            // Actualizar UI
            ActualizarUI();
            panelNuevoPerdida.Visible = false;
            panelMovimientos.Location = new Point(34, 180);
            txtCantidadPerdida.Clear();
            MessageBox.Show("Pérdida registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Form1 dashboard = new Form1();
            dashboard.Show();
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
