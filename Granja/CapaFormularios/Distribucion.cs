using System;
using System.Linq;
using System.Windows.Forms;

namespace Granja
{
    public partial class Distribucion : Form
    {
        public Distribucion()
        {
            InitializeComponent();
            ConfigurarVista();
            CargarDistribucion();
        }

        private void ConfigurarVista()
        {
            UiHelper.ConfigurarTituloGeneral(lblTitle);
            UiHelper.ConfigurarNavegacion(panelNav, btnDashboard, btnProduccion, btnAlmacen, btnVentas, btnAlimento, btnInsumos, btnMolino, btnReportes, btnAlmacen);

            panelRegistroDistribucion.Visible = false;
            panelMain.AutoScroll = true;
            lblDistribucionTitle.Text = "Distribución a Galpones";
            btnNuevaDistribucion.Text = "Nueva distribución";
            lblRegistroDistribucionTitle.Text = "Solicitud y distribución";
            lblTipoRegistroDistribucion.Text = "Tipo de registro";
            lblCantidadDistribucion.Text = "Cantidad";
            txtCantidadDistribucion.PlaceholderText = "Cantidad solicitada / distribuida";
            panelRegistroDistribucion.Height = 430;
            panelHistorialDistribucion.Location = new System.Drawing.Point(34, 180);
            panelHistorialDistribucion.Height = 440;
            cmbTipoRegistroDistribucion.Items.Clear();
            cmbTipoRegistroDistribucion.Items.Add("Solicitud de alimento");
            cmbTipoRegistroDistribucion.Items.Add("Distribución");
            cmbTipoRegistroDistribucion.SelectedIndex = 0;

            lblFechaDistribucion.Text = "Fecha";
            lblFechaDistribucion.AutoSize = true;
            lblFechaDistribucion.Location = new System.Drawing.Point(30, 145);
            dtpFechaDistribucion.Location = new System.Drawing.Point(30, 175);
            dtpFechaDistribucion.Size = new System.Drawing.Size(529, 34);

            lblGalponDistribucion.AutoSize = true;
            lblGalponDistribucion.Text = "Galpón";
            lblGalponDistribucion.Location = new System.Drawing.Point(630, 145);

            cmbGalponDistribucion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGalponDistribucion.Location = new System.Drawing.Point(630, 175);
            cmbGalponDistribucion.Size = new System.Drawing.Size(529, 36);

            lblFormulaDistribucion.AutoSize = true;
            lblFormulaDistribucion.Text = "Fórmula";
            lblFormulaDistribucion.Location = new System.Drawing.Point(30, 225);

            cmbFormulaDistribucion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFormulaDistribucion.Location = new System.Drawing.Point(30, 255);
            cmbFormulaDistribucion.Size = new System.Drawing.Size(529, 36);

            lblSolicitudDistribucion.AutoSize = true;
            lblSolicitudDistribucion.Text = "Solicitud relacionada";
            lblSolicitudDistribucion.Location = new System.Drawing.Point(630, 225);

            cmbSolicitudDistribucion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSolicitudDistribucion.Location = new System.Drawing.Point(630, 255);
            cmbSolicitudDistribucion.Size = new System.Drawing.Size(529, 36);

            lblDetalleDistribucion.AutoSize = true;
            lblDetalleDistribucion.Text = "Detalle";
            lblDetalleDistribucion.Location = new System.Drawing.Point(630, 305);

            txtDetalleDistribucion.Location = new System.Drawing.Point(630, 335);
            txtDetalleDistribucion.Size = new System.Drawing.Size(529, 34);
            txtDetalleDistribucion.PlaceholderText = "Observación";

            lblCantidadDistribucion.Location = new System.Drawing.Point(30, 305);
            txtCantidadDistribucion.Location = new System.Drawing.Point(30, 335);
            txtCantidadDistribucion.Size = new System.Drawing.Size(529, 34);

            btnRegistrarDistribucion.Location = new System.Drawing.Point(30, 395);
            btnCancelarDistribucion.Location = new System.Drawing.Point(180, 395);
            cmbTipoRegistroDistribucion.SelectedIndexChanged += (_, _) => ActualizarSelectorSolicitud();

            lblFiltroDesde.AutoSize = true;
            lblFiltroDesde.Text = "Desde";
            lblFiltroDesde.Location = new System.Drawing.Point(30, 42);

            dtpFiltroDesde.Format = DateTimePickerFormat.Short;
            dtpFiltroDesde.Location = new System.Drawing.Point(90, 38);
            dtpFiltroDesde.Size = new System.Drawing.Size(140, 27);
            dtpFiltroDesde.Value = DateTime.Today.AddMonths(-1);
            dtpFiltroDesde.ValueChanged += (_, _) => CargarDistribucion();

            lblFiltroHasta.AutoSize = true;
            lblFiltroHasta.Text = "Hasta";
            lblFiltroHasta.Location = new System.Drawing.Point(255, 42);

            dtpFiltroHasta.Format = DateTimePickerFormat.Short;
            dtpFiltroHasta.Location = new System.Drawing.Point(315, 38);
            dtpFiltroHasta.Size = new System.Drawing.Size(140, 27);
            dtpFiltroHasta.Value = DateTime.Today;
            dtpFiltroHasta.ValueChanged += (_, _) => CargarDistribucion();

            btnLimpiarFiltros.Text = "Limpiar filtros";
            btnLimpiarFiltros.Location = new System.Drawing.Point(480, 33);
            btnLimpiarFiltros.Size = new System.Drawing.Size(140, 34);
            btnLimpiarFiltros.Click += (_, _) =>
            {
                dtpFiltroDesde.Value = DateTime.Today.AddMonths(-1);
                dtpFiltroHasta.Value = DateTime.Today;
                CargarDistribucion();
            };

            dgvHistorialDistribucion.Location = new System.Drawing.Point(30, 110);
            dgvHistorialDistribucion.Size = new System.Drawing.Size(1129, 300);
            dgvHistorialDistribucion.CellClick += DgvMovimientos_CellClick;

            lblTipoRegistroDistribucion.BringToFront();
            lblFechaDistribucion.BringToFront();
            lblGalponDistribucion.BringToFront();
            lblFormulaDistribucion.BringToFront();
            lblSolicitudDistribucion.BringToFront();
            lblCantidadDistribucion.BringToFront();
            lblDetalleDistribucion.BringToFront();
        }

        private void CargarDistribucion()
        {
            lblStockTotal.Text = GlobalData.OrdenesIngresoDistribucion.Count.ToString();
            lblStockLabel.Text = "Ingresos a distribución";
            cmbGalponDistribucion.Items.Clear();
            cmbGalponDistribucion.Items.AddRange(GlobalData.Galpones.Where(g => g.Estado == "Activo").Select(g => g.Nombre).Cast<object>().ToArray());
            cmbFormulaDistribucion.Items.Clear();
            cmbFormulaDistribucion.Items.AddRange(GlobalData.Formulas.Where(f => f.Estado == "Activo").Select(f => f.Nombre).Cast<object>().ToArray());
            if (cmbGalponDistribucion.Items.Count > 0) cmbGalponDistribucion.SelectedIndex = 0;
            if (cmbFormulaDistribucion.Items.Count > 0) cmbFormulaDistribucion.SelectedIndex = 0;
            ActualizarSelectorSolicitud();

            dgvHistorialDistribucion.Rows.Clear();
            dgvHistorialDistribucion.Columns.Clear();
            dgvHistorialDistribucion.Columns.Add("Numero", "Documento");
            dgvHistorialDistribucion.Columns.Add("Fecha", "Fecha");
            dgvHistorialDistribucion.Columns.Add("Galpon", "Galpón");
            dgvHistorialDistribucion.Columns.Add("Formula", "Fórmula");
            dgvHistorialDistribucion.Columns.Add("Cantidad", "Cantidad");
            dgvHistorialDistribucion.Columns.Add("Solicitud", "Solicitud");

            DateTime desde = dtpFiltroDesde.Value.Date;
            DateTime hasta = dtpFiltroHasta.Value.Date;
            if (desde > hasta)
            {
                (desde, hasta) = (hasta, desde);
            }

            foreach (var dist in GlobalData.OrdenesIngresoDistribucion
                .Where(d => d.Fecha.Date >= desde && d.Fecha.Date <= hasta)
                .OrderByDescending(d => d.Fecha))
            {
                dgvHistorialDistribucion.Rows.Add(
                    dist.Numero,
                    dist.Fecha.ToString("dd/MM/yyyy"),
                    dist.Galpon,
                    dist.Formula,
                    dist.Detalles.Sum(x => x.Cantidad).ToString("F2"),
                    dist.SolicitudNumero);
            }

        }

        private void DgvMovimientos_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            string doc = dgvHistorialDistribucion.Rows[e.RowIndex].Cells[0].Value?.ToString() ?? string.Empty;
            if (!string.IsNullOrWhiteSpace(doc))
            {
                UiHelper.MostrarDetalleDocumento(doc);
            }
        }

        private void ActualizarSelectorSolicitud()
        {
            cmbSolicitudDistribucion.Items.Clear();
            bool esDistribucion = (cmbTipoRegistroDistribucion.SelectedItem?.ToString() ?? string.Empty) == "Distribución";
            lblSolicitudDistribucion.Visible = esDistribucion;
            cmbSolicitudDistribucion.Visible = esDistribucion;

            if (esDistribucion)
            {
                var solicitudes = GlobalData.SolicitudesAlimentoGalpones
                    .Where(s => s.Estado == "Pendiente")
                    .Select(s => s.Numero)
                    .ToArray();

                cmbSolicitudDistribucion.Items.Add(string.Empty);
                cmbSolicitudDistribucion.Items.AddRange(solicitudes);
                cmbSolicitudDistribucion.SelectedIndex = 0;
            }
        }

        private void btnRegistrarMovimiento_Click(object sender, EventArgs e)
        {
            panelRegistroDistribucion.Visible = true;
            panelHistorialDistribucion.Location = new System.Drawing.Point(34, panelRegistroDistribucion.Bottom + 20);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panelRegistroDistribucion.Visible = false;
            panelHistorialDistribucion.Location = new System.Drawing.Point(34, 180);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cmbGalponDistribucion.SelectedItem == null || cmbFormulaDistribucion.SelectedItem == null)
            {
                MessageBox.Show("Selecciona galpón y fórmula.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtCantidadDistribucion.Text, out double cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingresa una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string tipo = cmbTipoRegistroDistribucion.SelectedItem?.ToString() ?? string.Empty;
                if (tipo == "Solicitud de alimento")
                {
                    var solicitud = GlobalData.RegistrarSolicitudAlimento(
                        dtpFechaDistribucion.Value,
                        cmbGalponDistribucion.SelectedItem.ToString() ?? string.Empty,
                        cmbFormulaDistribucion.SelectedItem.ToString() ?? string.Empty,
                        cantidad,
                        txtDetalleDistribucion.Text.Trim());

                    string mensaje = $"Solicitud registrada: {solicitud.Numero}";
                    if (!string.IsNullOrWhiteSpace(solicitud.OrdenProduccionGenerada))
                    {
                        mensaje += $"\nOrden generada por faltante: {solicitud.OrdenProduccionGenerada}";
                    }

                    MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var resultado = GlobalData.RegistrarDistribucion(
                        dtpFechaDistribucion.Value,
                        cmbGalponDistribucion.SelectedItem.ToString() ?? string.Empty,
                        cmbFormulaDistribucion.SelectedItem.ToString() ?? string.Empty,
                        cantidad,
                        txtDetalleDistribucion.Text.Trim(),
                        cmbSolicitudDistribucion.SelectedItem?.ToString() ?? string.Empty);

                    MessageBox.Show(
                        $"Salida de almacén: {resultado.salida.Numero}\nIngreso a distribución: {resultado.ingreso.Numero}",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    UiHelper.MostrarDetalleDocumento(resultado.ingreso.Numero);
                }

                CargarDistribucion();
                panelRegistroDistribucion.Visible = false;
                panelHistorialDistribucion.Location = new System.Drawing.Point(34, 180);
                txtCantidadDistribucion.Clear();
                txtDetalleDistribucion.Clear();
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

        private void btnProduccion_Click(object sender, EventArgs e)
        {
            UiHelper.AbrirFormulario<Ordenes>(this);
        }
    }
}
