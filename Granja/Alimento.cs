using System;
using System.Linq;
using System.Windows.Forms;

namespace Granja
{
    public partial class Alimento : Form
    {
        private readonly ComboBox cmbFormulaOrden = new();
        private readonly TextBox txtDetalleOrden = new();
        private readonly Label lblFormulaOrden = new();
        private readonly Label lblDetalleOrden = new();
        private readonly DateTimePicker dtpFiltroDesde = new();
        private readonly DateTimePicker dtpFiltroHasta = new();
        private readonly Label lblFiltroDesde = new();
        private readonly Label lblFiltroHasta = new();
        private readonly Button btnLimpiarFiltros = new();

        public Alimento()
        {
            InitializeComponent();
            ConfigurarVista();
            CargarStockAlimento();
        }

        private void ConfigurarVista()
        {
            UiHelper.ConfigurarTituloGeneral(lblTitle);
            UiHelper.ConfigurarNavegacion(btnDashboard, btnProduccion, btnAlmacen, btnVentas, btnAlimento, btnInsumos, btnMolino, btnReportes);

            lblAlimentoTitle.Text = "Almacén de Alimento Balanceado";
            btnRegistrarPerdida.Text = "Generar orden";
            lblNuevoPerdidaTitle.Text = "Generar orden por stock insuficiente";
            lblFechaPerdida.Text = "Fecha";
            lblCantidadPerdida.Text = "Cantidad";
            txtCantidadPerdida.PlaceholderText = "Cantidad sugerida";
            panelNuevoPerdida.Height = 360;
            panelMovimientos.Location = new System.Drawing.Point(34, 180);
            panelMovimientos.Height = 500;

            lblFormulaOrden.AutoSize = true;
            lblFormulaOrden.Text = "Fórmula";
            lblFormulaOrden.Location = new System.Drawing.Point(30, 75);
            panelNuevoPerdida.Controls.Add(lblFormulaOrden);

            cmbFormulaOrden.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFormulaOrden.Location = new System.Drawing.Point(30, 105);
            cmbFormulaOrden.Size = new System.Drawing.Size(529, 36);
            panelNuevoPerdida.Controls.Add(cmbFormulaOrden);

            lblDetalleOrden.AutoSize = true;
            lblDetalleOrden.Text = "Detalle";
            lblDetalleOrden.Location = new System.Drawing.Point(30, 185);
            panelNuevoPerdida.Controls.Add(lblDetalleOrden);

            txtDetalleOrden.Location = new System.Drawing.Point(30, 215);
            txtDetalleOrden.Size = new System.Drawing.Size(1129, 34);
            txtDetalleOrden.PlaceholderText = "Motivo de la orden";
            panelNuevoPerdida.Controls.Add(txtDetalleOrden);

            lblFechaPerdida.Location = new System.Drawing.Point(630, 75);
            dtpFechaPerdida.Location = new System.Drawing.Point(630, 105);
            lblCantidadPerdida.Location = new System.Drawing.Point(30, 155);
            txtCantidadPerdida.Location = new System.Drawing.Point(30, 185);
            lblDetalleOrden.Location = new System.Drawing.Point(30, 235);
            txtDetalleOrden.Location = new System.Drawing.Point(30, 265);
            btnRegistrarPerdida2.Location = new System.Drawing.Point(30, 310);
            btnCancelarPerdida.Location = new System.Drawing.Point(180, 310);

            lblFiltroDesde.AutoSize = true;
            lblFiltroDesde.Text = "Desde";
            lblFiltroDesde.Location = new System.Drawing.Point(30, 42);
            panelMovimientos.Controls.Add(lblFiltroDesde);

            dtpFiltroDesde.Format = DateTimePickerFormat.Short;
            dtpFiltroDesde.Location = new System.Drawing.Point(90, 38);
            dtpFiltroDesde.Size = new System.Drawing.Size(140, 27);
            dtpFiltroDesde.Value = DateTime.Today.AddMonths(-1);
            dtpFiltroDesde.ValueChanged += (_, _) => CargarStockAlimento();
            panelMovimientos.Controls.Add(dtpFiltroDesde);

            lblFiltroHasta.AutoSize = true;
            lblFiltroHasta.Text = "Hasta";
            lblFiltroHasta.Location = new System.Drawing.Point(255, 42);
            panelMovimientos.Controls.Add(lblFiltroHasta);

            dtpFiltroHasta.Format = DateTimePickerFormat.Short;
            dtpFiltroHasta.Location = new System.Drawing.Point(315, 38);
            dtpFiltroHasta.Size = new System.Drawing.Size(140, 27);
            dtpFiltroHasta.Value = DateTime.Today;
            dtpFiltroHasta.ValueChanged += (_, _) => CargarStockAlimento();
            panelMovimientos.Controls.Add(dtpFiltroHasta);

            btnLimpiarFiltros.Text = "Limpiar filtros";
            btnLimpiarFiltros.Location = new System.Drawing.Point(480, 33);
            btnLimpiarFiltros.Size = new System.Drawing.Size(140, 34);
            btnLimpiarFiltros.Click += (_, _) =>
            {
                dtpFiltroDesde.Value = DateTime.Today.AddMonths(-1);
                dtpFiltroHasta.Value = DateTime.Today;
                CargarStockAlimento();
            };
            panelMovimientos.Controls.Add(btnLimpiarFiltros);

            dgvMovimientos.Location = new System.Drawing.Point(30, 110);
            dgvMovimientos.Size = new System.Drawing.Size(1129, 300);
            dgvMovimientos.CellClick += DgvMovimientos_CellClick;
        }

        private void CargarStockAlimento()
        {
            lblStockTotal.Text = GlobalData.StockAlimentos.Sum(s => s.StockDisponible).ToString("F2");
            lblStockLabel.Text = "Stock total";
            cmbFormulaOrden.Items.Clear();
            cmbFormulaOrden.Items.AddRange(GlobalData.ObtenerFormulasActivas().Select(f => f.Nombre).Cast<object>().ToArray());
            if (cmbFormulaOrden.Items.Count > 0)
            {
                cmbFormulaOrden.SelectedIndex = 0;
            }

            dgvMovimientos.Rows.Clear();
            dgvMovimientos.Columns.Clear();
            dgvMovimientos.Columns.Add("Documento", "Documento");
            dgvMovimientos.Columns.Add("Fecha", "Fecha");
            dgvMovimientos.Columns.Add("Tipo", "Tipo");
            dgvMovimientos.Columns.Add("Formula", "Fórmula");
            dgvMovimientos.Columns.Add("Cantidad", "Cantidad");
            dgvMovimientos.Columns.Add("Stock", "Stock resultante");

            DateTime desde = dtpFiltroDesde.Value.Date;
            DateTime hasta = dtpFiltroHasta.Value.Date;
            if (desde > hasta)
            {
                (desde, hasta) = (hasta, desde);
            }

            foreach (var mov in GlobalData.MovimientosAlimento
                .Where(m => m.Fecha.Date >= desde && m.Fecha.Date <= hasta)
                .OrderByDescending(m => m.Fecha))
            {
                dgvMovimientos.Rows.Add(
                    mov.Documento,
                    mov.Fecha.ToString("dd/MM/yyyy"),
                    mov.Tipo,
                    mov.Formula,
                    mov.Cantidad.ToString("F2"),
                    mov.StockResultante.ToString("F2"));
            }

        }

        private void DgvMovimientos_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            string doc = dgvMovimientos.Rows[e.RowIndex].Cells[0].Value?.ToString() ?? string.Empty;
            if (!string.IsNullOrWhiteSpace(doc))
            {
                UiHelper.MostrarDetalleDocumento(doc);
            }
        }

        private void btnRegistrarPerdida_Click(object sender, EventArgs e)
        {
            panelNuevoPerdida.Visible = !panelNuevoPerdida.Visible;
            panelMovimientos.Location = panelNuevoPerdida.Visible ? new System.Drawing.Point(34, panelNuevoPerdida.Bottom + 20) : new System.Drawing.Point(34, 180);
        }

        private void btnCancelarPerdida_Click(object sender, EventArgs e)
        {
            panelNuevoPerdida.Visible = false;
            panelMovimientos.Location = new System.Drawing.Point(34, 180);
        }

        private void btnRegistrarPerdida2_Click(object sender, EventArgs e)
        {
            if (cmbFormulaOrden.SelectedItem == null)
            {
                MessageBox.Show("Selecciona una fórmula.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtCantidadPerdida.Text, out double cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingresa una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var orden = GlobalData.GenerarOrdenPorStockInsuficiente(
                    dtpFechaPerdida.Value,
                    cmbFormulaOrden.SelectedItem.ToString() ?? string.Empty,
                    cantidad,
                    txtDetalleOrden.Text.Trim());

                panelNuevoPerdida.Visible = false;
                panelMovimientos.Location = new System.Drawing.Point(34, 180);
                txtCantidadPerdida.Clear();
                txtDetalleOrden.Clear();
                MessageBox.Show($"Orden generada: {orden.Numero}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            Ventas maestros = new Ventas();
            maestros.Show();
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
