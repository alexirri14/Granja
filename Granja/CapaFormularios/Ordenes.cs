using System;
using System.Linq;
using System.Windows.Forms;

namespace Granja
{
    public partial class Ordenes : Form
    {
        private string ordenSeleccionada = string.Empty;

        public Ordenes()
        {
            InitializeComponent();
            btnRegistrarOrdenProduccion.Click += BtnGuardar_Click;
            btnActualizarEstadoOrden.Click += BtnCancelar_Click;
            ConfigurarVista();
            CargarListado();
        }

        private void ConfigurarVista()
        {
            UiHelper.ConfigurarTituloGeneral(lblTitle);
            UiHelper.ConfigurarNavegacion(panelNav, btnDashboard, btnProduccion, btnAlmacen, btnVentas, btnAlimento, btnInsumos, btnMolino, btnReportes, btnProduccion);

            lblOrdenProduccionTitle.Text = "Orden de Producción";
            lblFormulaOrdenProduccion.Text = "Fórmula";
            lblFechaOrdenProduccion.Text = "Fecha";
            lblCantidadObjetivoOrden.Text = "Cantidad a producir";
            lblHistorialOrdenesTitle.Text = "Historial de órdenes";
            panelMain.AutoScroll = true;

            cmbEstadoOrden.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstadoOrden.Items.AddRange(new object[] { "Pendiente", "En proceso", "Completada", "Inhabilitada" });
            cmbEstadoOrden.Location = new System.Drawing.Point(34, 315);
            cmbEstadoOrden.Size = new System.Drawing.Size(529, 36);

            txtDetalleOrden.Location = new System.Drawing.Point(630, 315);
            txtDetalleOrden.Size = new System.Drawing.Size(529, 34);
            txtDetalleOrden.PlaceholderText = "Observación de la orden";

            cmbFormulaOrdenProduccion.Items.Clear();
            cmbFormulaOrdenProduccion.Items.AddRange(GlobalData.ObtenerFormulasActivas().Select(f => f.Nombre).Cast<object>().ToArray());
            if (cmbFormulaOrdenProduccion.Items.Count > 0)
            {
                cmbFormulaOrdenProduccion.SelectedIndex = 0;
            }

            txtCantidadObjetivoOrden.PlaceholderText = "Cantidad de alimento balanceado";
            btnRegistrarOrdenProduccion.Text = "Registrar orden";
            btnActualizarEstadoOrden.Text = "Actualizar estado";
            dtpFechaOrdenProduccion.Value = DateTime.Today;
            cmbEstadoOrden.SelectedIndex = 0;
            dgvHistorialOrdenesProduccion.SelectionChanged += (_, _) => CargarOrdenSeleccionada();

            panelOrdenProduccion.Height = 400;
            panelHistorialOrdenesProduccion.Location = new System.Drawing.Point(34, 485);
            panelHistorialOrdenesProduccion.Height = 300;

            cmbFormulaOrdenProduccion.Location = new System.Drawing.Point(30, 55);
            cmbFormulaOrdenProduccion.Size = new System.Drawing.Size(1129, 36);
            lblFechaOrdenProduccion.Location = new System.Drawing.Point(30, 105);
            dtpFechaOrdenProduccion.Location = new System.Drawing.Point(30, 135);
            dtpFechaOrdenProduccion.Size = new System.Drawing.Size(1129, 34);
            lblCantidadObjetivoOrden.Location = new System.Drawing.Point(30, 185);
            txtCantidadObjetivoOrden.Location = new System.Drawing.Point(30, 215);
            txtCantidadObjetivoOrden.Size = new System.Drawing.Size(1129, 34);

            lblEstadoOrden.Location = new System.Drawing.Point(30, 270);
            cmbEstadoOrden.Location = new System.Drawing.Point(30, 300);
            cmbEstadoOrden.Size = new System.Drawing.Size(529, 36);

            lblDetalleOrden.Location = new System.Drawing.Point(630, 270);
            txtDetalleOrden.Location = new System.Drawing.Point(630, 300);
            txtDetalleOrden.Size = new System.Drawing.Size(529, 34);

            btnRegistrarOrdenProduccion.Location = new System.Drawing.Point(30, 345);
            btnActualizarEstadoOrden.Location = new System.Drawing.Point(190, 345);

            dtpFiltroDesde.Format = DateTimePickerFormat.Short;
            dtpFiltroDesde.Location = new System.Drawing.Point(90, 38);
            dtpFiltroDesde.Size = new System.Drawing.Size(140, 27);
            dtpFiltroDesde.Value = DateTime.Today.AddMonths(-1);
            dtpFiltroDesde.ValueChanged += (_, _) => CargarListado();

            dtpFiltroHasta.Format = DateTimePickerFormat.Short;
            dtpFiltroHasta.Location = new System.Drawing.Point(315, 38);
            dtpFiltroHasta.Size = new System.Drawing.Size(140, 27);
            dtpFiltroHasta.Value = DateTime.Today;
            dtpFiltroHasta.ValueChanged += (_, _) => CargarListado();

            btnLimpiarFiltros.Text = "Limpiar filtros";
            btnLimpiarFiltros.Location = new System.Drawing.Point(480, 33);
            btnLimpiarFiltros.Size = new System.Drawing.Size(140, 34);
            btnLimpiarFiltros.Click += (_, _) =>
            {
                dtpFiltroDesde.Value = DateTime.Today.AddMonths(-1);
                dtpFiltroHasta.Value = DateTime.Today;
                CargarListado();
            };

            dgvHistorialOrdenesProduccion.Location = new System.Drawing.Point(30, 110);
            dgvHistorialOrdenesProduccion.Size = new System.Drawing.Size(1129, 180);

            lblFormulaOrdenProduccion.BringToFront();
            lblFechaOrdenProduccion.BringToFront();
            lblCantidadObjetivoOrden.BringToFront();
            lblEstadoOrden.BringToFront();
            lblDetalleOrden.BringToFront();
        }

        private void CargarListado()
        {
            dgvHistorialOrdenesProduccion.Rows.Clear();
            dgvHistorialOrdenesProduccion.Columns.Clear();
            dgvHistorialOrdenesProduccion.Columns.Add("Numero", "Orden");
            dgvHistorialOrdenesProduccion.Columns.Add("Fecha", "Fecha");
            dgvHistorialOrdenesProduccion.Columns.Add("Formula", "Fórmula");
            dgvHistorialOrdenesProduccion.Columns.Add("Objetivo", "Objetivo");
            dgvHistorialOrdenesProduccion.Columns.Add("Producido", "Producido");
            dgvHistorialOrdenesProduccion.Columns.Add("Estado", "Estado");

            DateTime desde = dtpFiltroDesde.Value.Date;
            DateTime hasta = dtpFiltroHasta.Value.Date;
            if (desde > hasta)
            {
                (desde, hasta) = (hasta, desde);
            }

            foreach (var orden in GlobalData.OrdenesProduccion
                .Where(o => o.Fecha.Date >= desde && o.Fecha.Date <= hasta)
                .OrderByDescending(o => o.Fecha))
            {
                dgvHistorialOrdenesProduccion.Rows.Add(
                    orden.Numero,
                    orden.Fecha.ToString("dd/MM/yyyy"),
                    orden.Formula,
                    orden.CantidadObjetivo.ToString("F2"),
                    orden.CantidadProducida.ToString("F2"),
                    orden.Estado);
            }
        }

        private void CargarOrdenSeleccionada()
        {
            if (dgvHistorialOrdenesProduccion.CurrentRow == null)
            {
                return;
            }

            ordenSeleccionada = dgvHistorialOrdenesProduccion.CurrentRow.Cells[0].Value?.ToString() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(ordenSeleccionada))
            {
                return;
            }

            var orden = GlobalData.OrdenesProduccion.FirstOrDefault(o => o.Numero == ordenSeleccionada);
            if (orden == null)
            {
                ordenSeleccionada = string.Empty;
                return;
            }

            cmbFormulaOrdenProduccion.SelectedItem = orden.Formula;
            dtpFechaOrdenProduccion.Value = orden.Fecha;
            txtCantidadObjetivoOrden.Text = orden.CantidadObjetivo.ToString("F2");
            cmbEstadoOrden.SelectedItem = orden.Estado;
            txtDetalleOrden.Text = orden.Detalle;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            UiHelper.AbrirFormulario<Dashboard>(this);
        }

        private void btnProduccion_Click_1(object sender, EventArgs e)
        {
            UiHelper.AbrirFormulario<Ordenes>(this);
        }

        private void btnAlmacen_Click(object sender, EventArgs e)
        {
            UiHelper.AbrirFormulario<Distribucion>(this);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            UiHelper.AbrirFormulario<Administrador>(this);
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

        private void BtnCancelar_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ordenSeleccionada) || cmbEstadoOrden.SelectedItem == null)
            {
                MessageBox.Show("Selecciona una orden para actualizar su estado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            GlobalData.CambiarEstadoOrden(ordenSeleccionada, cmbEstadoOrden.SelectedItem.ToString() ?? "Pendiente");
            CargarListado();
            MessageBox.Show("Estado de orden actualizado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnGuardar_Click(object? sender, EventArgs e)
        {
            if (cmbFormulaOrdenProduccion.SelectedItem == null)
            {
                MessageBox.Show("Selecciona una fórmula.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtCantidadObjetivoOrden.Text, out double cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingresa una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var orden = GlobalData.RegistrarOrdenProduccion(
                    dtpFechaOrdenProduccion.Value,
                    cmbFormulaOrdenProduccion.SelectedItem.ToString() ?? string.Empty,
                    cantidad,
                    txtDetalleOrden.Text.Trim());

                CargarListado();
                txtCantidadObjetivoOrden.Clear();
                txtDetalleOrden.Clear();
                cmbEstadoOrden.SelectedIndex = 0;
                MessageBox.Show($"Orden registrada: {orden.Numero}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
