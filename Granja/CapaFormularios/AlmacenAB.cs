using System;
using System.Linq;
using System.Windows.Forms;

namespace Granja
{
    public partial class AlmacenAB : Form
    {
        public AlmacenAB()
        {
            InitializeComponent();
            ConfigurarVista();
            CargarStockAlimento();
        }

        private void ConfigurarVista()
        {
            UiHelper.ConfigurarTituloGeneral(lblTitle);
            UiHelper.ConfigurarNavegacion(panelNav, btnDashboard, btnProduccion, btnAlmacen, btnVentas, btnAlimento, btnInsumos, btnMolino, btnReportes, btnAlimento);

            lblAlimentoTitle.Text = "Almacén de Alimento Balanceado";
            btnMostrarOrdenStock.Text = "Generar orden";
            lblOrdenStockTitle.Text = "Generar orden por stock insuficiente";
            lblFechaOrdenStock.Text = "Fecha";
            lblCantidadOrdenStock.Text = "Cantidad";
            txtCantidadOrdenStock.PlaceholderText = "Cantidad sugerida";
            panelMain.AutoScroll = true;
            panelOrdenStock.Height = 330;
            panelMovimientos.Location = new System.Drawing.Point(34, 180);
            panelMovimientos.Height = 420;

            lblFormulaOrden.AutoSize = true;
            lblFormulaOrden.Text = "Fórmula";
            lblFormulaOrden.Location = new System.Drawing.Point(30, 75);

            cmbFormulaOrden.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFormulaOrden.Location = new System.Drawing.Point(30, 105);
            cmbFormulaOrden.Size = new System.Drawing.Size(529, 36);

            lblDetalleOrden.AutoSize = true;
            lblDetalleOrden.Text = "Detalle";
            lblDetalleOrden.Location = new System.Drawing.Point(30, 185);

            txtDetalleOrden.Location = new System.Drawing.Point(30, 215);
            txtDetalleOrden.Size = new System.Drawing.Size(1129, 34);
            txtDetalleOrden.PlaceholderText = "Motivo de la orden";

            lblFechaOrdenStock.AutoSize = true;
            lblFechaOrdenStock.Location = new System.Drawing.Point(630, 75);
            dtpFechaOrdenStock.Location = new System.Drawing.Point(630, 105);
            lblCantidadOrdenStock.AutoSize = true;
            lblCantidadOrdenStock.Location = new System.Drawing.Point(30, 155);
            txtCantidadOrdenStock.Location = new System.Drawing.Point(30, 185);
            txtCantidadOrdenStock.Size = new System.Drawing.Size(1129, 34);
            lblDetalleOrden.Location = new System.Drawing.Point(30, 225);
            txtDetalleOrden.Location = new System.Drawing.Point(30, 255);
            btnRegistrarOrdenStock.Location = new System.Drawing.Point(30, 295);
            btnCancelarOrdenStock.Location = new System.Drawing.Point(180, 295);

            lblFiltroDesde.AutoSize = true;
            lblFiltroDesde.Text = "Desde";
            lblFiltroDesde.Location = new System.Drawing.Point(30, 42);

            dtpFiltroDesde.Format = DateTimePickerFormat.Short;
            dtpFiltroDesde.Location = new System.Drawing.Point(90, 38);
            dtpFiltroDesde.Size = new System.Drawing.Size(140, 27);
            dtpFiltroDesde.Value = DateTime.Today.AddMonths(-1);
            dtpFiltroDesde.ValueChanged += (_, _) => CargarStockAlimento();

            lblFiltroHasta.AutoSize = true;
            lblFiltroHasta.Text = "Hasta";
            lblFiltroHasta.Location = new System.Drawing.Point(255, 42);

            dtpFiltroHasta.Format = DateTimePickerFormat.Short;
            dtpFiltroHasta.Location = new System.Drawing.Point(315, 38);
            dtpFiltroHasta.Size = new System.Drawing.Size(140, 27);
            dtpFiltroHasta.Value = DateTime.Today;
            dtpFiltroHasta.ValueChanged += (_, _) => CargarStockAlimento();

            btnLimpiarFiltros.Text = "Limpiar filtros";
            btnLimpiarFiltros.Location = new System.Drawing.Point(480, 33);
            btnLimpiarFiltros.Size = new System.Drawing.Size(140, 34);
            btnLimpiarFiltros.Click += (_, _) =>
            {
                dtpFiltroDesde.Value = DateTime.Today.AddMonths(-1);
                dtpFiltroHasta.Value = DateTime.Today;
                CargarStockAlimento();
            };

            dgvMovimientos.Location = new System.Drawing.Point(30, 110);
            dgvMovimientos.Size = new System.Drawing.Size(1129, 300);
            dgvMovimientos.CellClick += DgvMovimientos_CellClick;

            lblFormulaOrden.BringToFront();
            lblFechaOrdenStock.BringToFront();
            lblCantidadOrdenStock.BringToFront();
            lblDetalleOrden.BringToFront();
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
            panelOrdenStock.Visible = !panelOrdenStock.Visible;
            panelMovimientos.Location = panelOrdenStock.Visible ? new System.Drawing.Point(34, panelOrdenStock.Bottom + 20) : new System.Drawing.Point(34, 180);
        }

        private void btnCancelarPerdida_Click(object sender, EventArgs e)
        {
            panelOrdenStock.Visible = false;
            panelMovimientos.Location = new System.Drawing.Point(34, 180);
        }

        private void btnRegistrarPerdida2_Click(object sender, EventArgs e)
        {
            if (cmbFormulaOrden.SelectedItem == null)
            {
                MessageBox.Show("Selecciona una fórmula.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtCantidadOrdenStock.Text, out double cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingresa una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var orden = GlobalData.GenerarOrdenPorStockInsuficiente(
                    dtpFechaOrdenStock.Value,
                    cmbFormulaOrden.SelectedItem.ToString() ?? string.Empty,
                    cantidad,
                    txtDetalleOrden.Text.Trim());

                panelOrdenStock.Visible = false;
                panelMovimientos.Location = new System.Drawing.Point(34, 180);
                txtCantidadOrdenStock.Clear();
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
            UiHelper.AbrirFormulario<Dashboard>(this);
        }

        private void btnAlimento_Click(object sender, EventArgs e)
        {
            UiHelper.AbrirFormulario<AlmacenAB>(this);
        }

        private void btnMolino_Click(object sender, EventArgs e)
        {
            UiHelper.AbrirFormulario<Molino>(this);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            UiHelper.AbrirFormulario<Reportes>(this);
        }

        private void btnInsumos_Click(object sender, EventArgs e)
        {
            UiHelper.AbrirFormulario<Insumos>(this);
        }

        private void btnProduccion_Click_1(object sender, EventArgs e)
        {
            UiHelper.AbrirFormulario<Ordenes>(this);
        }

        private void btnAlmacen_Click_1(object sender, EventArgs e)
        {
            UiHelper.AbrirFormulario<Distribucion>(this);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            UiHelper.AbrirFormulario<Administrador>(this);
        }
    }
}
