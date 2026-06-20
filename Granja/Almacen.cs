using System;
using System.Linq;
using System.Windows.Forms;

namespace Granja
{
    public partial class Almacen : Form
    {
        private readonly ComboBox cmbGalpon = new();
        private readonly ComboBox cmbFormula = new();
        private readonly ComboBox cmbSolicitud = new();
        private readonly TextBox txtDetalle = new();
        private readonly Label lblGalpon = new();
        private readonly Label lblFormula = new();
        private readonly Label lblSolicitud = new();
        private readonly Label lblDetalle = new();
        private readonly DateTimePicker dtpFiltroDesde = new();
        private readonly DateTimePicker dtpFiltroHasta = new();
        private readonly Label lblFiltroDesde = new();
        private readonly Label lblFiltroHasta = new();
        private readonly Button btnLimpiarFiltros = new();

        public Almacen()
        {
            InitializeComponent();
            ConfigurarVista();
            CargarDistribucion();
        }

        private void ConfigurarVista()
        {
            UiHelper.ConfigurarTituloGeneral(lblTitle);
            UiHelper.ConfigurarNavegacion(btnDashboard, btnProduccion, btnAlmacen, btnVentas, btnAlimento, btnInsumos, btnMolino, btnReportes);

            panelNuevoMovimiento.Visible = false;
            lblAlmacenTitle.Text = "Distribución a Galpones";
            btnRegistrarMovimiento.Text = "Nueva distribución";
            lblNuevoMovimientoTitle.Text = "Solicitud y distribución";
            lblTipo.Text = "Tipo de registro";
            lblCantidad.Text = "Cantidad";
            txtCantidad.PlaceholderText = "Cantidad solicitada / distribuida";
            panelNuevoMovimiento.Height = 490;
            panelMovimientos.Location = new System.Drawing.Point(34, 180);
            panelMovimientos.Height = 500;
            cmbTipo.Items.Clear();
            cmbTipo.Items.Add("Solicitud de alimento");
            cmbTipo.Items.Add("Distribución");
            cmbTipo.SelectedIndex = 0;

            lblGalpon.AutoSize = true;
            lblGalpon.Text = "Galpón";
            lblGalpon.Location = new System.Drawing.Point(30, 145);
            panelNuevoMovimiento.Controls.Add(lblGalpon);

            cmbGalpon.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGalpon.Location = new System.Drawing.Point(30, 175);
            cmbGalpon.Size = new System.Drawing.Size(529, 36);
            panelNuevoMovimiento.Controls.Add(cmbGalpon);

            lblFormula.AutoSize = true;
            lblFormula.Text = "Fórmula";
            lblFormula.Location = new System.Drawing.Point(630, 145);
            panelNuevoMovimiento.Controls.Add(lblFormula);

            cmbFormula.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFormula.Location = new System.Drawing.Point(630, 175);
            cmbFormula.Size = new System.Drawing.Size(529, 36);
            panelNuevoMovimiento.Controls.Add(cmbFormula);

            lblSolicitud.AutoSize = true;
            lblSolicitud.Text = "Solicitud relacionada";
            lblSolicitud.Location = new System.Drawing.Point(30, 225);
            panelNuevoMovimiento.Controls.Add(lblSolicitud);

            cmbSolicitud.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSolicitud.Location = new System.Drawing.Point(30, 255);
            cmbSolicitud.Size = new System.Drawing.Size(529, 36);
            panelNuevoMovimiento.Controls.Add(cmbSolicitud);

            lblDetalle.AutoSize = true;
            lblDetalle.Text = "Detalle";
            lblDetalle.Location = new System.Drawing.Point(630, 225);
            panelNuevoMovimiento.Controls.Add(lblDetalle);

            txtDetalle.Location = new System.Drawing.Point(630, 255);
            txtDetalle.Size = new System.Drawing.Size(529, 34);
            txtDetalle.PlaceholderText = "Observación";
            panelNuevoMovimiento.Controls.Add(txtDetalle);

            dtpFecha.Location = new System.Drawing.Point(30, 255);
            dtpFecha.Size = new System.Drawing.Size(529, 34);
            lblFecha.Location = new System.Drawing.Point(30, 225);

            lblSolicitud.Location = new System.Drawing.Point(630, 225);
            cmbSolicitud.Location = new System.Drawing.Point(630, 255);

            lblCantidad.Location = new System.Drawing.Point(30, 305);
            txtCantidad.Location = new System.Drawing.Point(30, 335);
            txtCantidad.Size = new System.Drawing.Size(529, 34);

            lblDetalle.Location = new System.Drawing.Point(630, 305);
            txtDetalle.Location = new System.Drawing.Point(630, 335);

            btnRegistrar.Location = new System.Drawing.Point(30, 395);
            btnCancelar.Location = new System.Drawing.Point(180, 395);
            cmbTipo.SelectedIndexChanged += (_, _) => ActualizarSelectorSolicitud();

            lblFiltroDesde.AutoSize = true;
            lblFiltroDesde.Text = "Desde";
            lblFiltroDesde.Location = new System.Drawing.Point(30, 42);
            panelMovimientos.Controls.Add(lblFiltroDesde);

            dtpFiltroDesde.Format = DateTimePickerFormat.Short;
            dtpFiltroDesde.Location = new System.Drawing.Point(90, 38);
            dtpFiltroDesde.Size = new System.Drawing.Size(140, 27);
            dtpFiltroDesde.Value = DateTime.Today.AddMonths(-1);
            dtpFiltroDesde.ValueChanged += (_, _) => CargarDistribucion();
            panelMovimientos.Controls.Add(dtpFiltroDesde);

            lblFiltroHasta.AutoSize = true;
            lblFiltroHasta.Text = "Hasta";
            lblFiltroHasta.Location = new System.Drawing.Point(255, 42);
            panelMovimientos.Controls.Add(lblFiltroHasta);

            dtpFiltroHasta.Format = DateTimePickerFormat.Short;
            dtpFiltroHasta.Location = new System.Drawing.Point(315, 38);
            dtpFiltroHasta.Size = new System.Drawing.Size(140, 27);
            dtpFiltroHasta.Value = DateTime.Today;
            dtpFiltroHasta.ValueChanged += (_, _) => CargarDistribucion();
            panelMovimientos.Controls.Add(dtpFiltroHasta);

            btnLimpiarFiltros.Text = "Limpiar filtros";
            btnLimpiarFiltros.Location = new System.Drawing.Point(480, 33);
            btnLimpiarFiltros.Size = new System.Drawing.Size(140, 34);
            btnLimpiarFiltros.Click += (_, _) =>
            {
                dtpFiltroDesde.Value = DateTime.Today.AddMonths(-1);
                dtpFiltroHasta.Value = DateTime.Today;
                CargarDistribucion();
            };
            panelMovimientos.Controls.Add(btnLimpiarFiltros);

            dgvMovimientos.Location = new System.Drawing.Point(30, 110);
            dgvMovimientos.Size = new System.Drawing.Size(1129, 300);
            dgvMovimientos.CellClick += DgvMovimientos_CellClick;
        }

        private void CargarDistribucion()
        {
            lblStockTotal.Text = GlobalData.OrdenesIngresoDistribucion.Count.ToString();
            lblStockLabel.Text = "Ingresos a distribución";
            cmbGalpon.Items.Clear();
            cmbGalpon.Items.AddRange(GlobalData.Galpones.Where(g => g.Estado == "Activo").Select(g => g.Nombre).Cast<object>().ToArray());
            cmbFormula.Items.Clear();
            cmbFormula.Items.AddRange(GlobalData.Formulas.Where(f => f.Estado == "Activo").Select(f => f.Nombre).Cast<object>().ToArray());
            if (cmbGalpon.Items.Count > 0) cmbGalpon.SelectedIndex = 0;
            if (cmbFormula.Items.Count > 0) cmbFormula.SelectedIndex = 0;
            ActualizarSelectorSolicitud();

            dgvMovimientos.Rows.Clear();
            dgvMovimientos.Columns.Clear();
            dgvMovimientos.Columns.Add("Numero", "Documento");
            dgvMovimientos.Columns.Add("Fecha", "Fecha");
            dgvMovimientos.Columns.Add("Galpon", "Galpón");
            dgvMovimientos.Columns.Add("Formula", "Fórmula");
            dgvMovimientos.Columns.Add("Cantidad", "Cantidad");
            dgvMovimientos.Columns.Add("Solicitud", "Solicitud");

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
                dgvMovimientos.Rows.Add(
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

            string doc = dgvMovimientos.Rows[e.RowIndex].Cells[0].Value?.ToString() ?? string.Empty;
            if (!string.IsNullOrWhiteSpace(doc))
            {
                UiHelper.MostrarDetalleDocumento(doc);
            }
        }

        private void ActualizarSelectorSolicitud()
        {
            cmbSolicitud.Items.Clear();
            bool esDistribucion = (cmbTipo.SelectedItem?.ToString() ?? string.Empty) == "Distribución";
            lblSolicitud.Visible = esDistribucion;
            cmbSolicitud.Visible = esDistribucion;

            if (esDistribucion)
            {
                var solicitudes = GlobalData.SolicitudesAlimentoGalpones
                    .Where(s => s.Estado == "Pendiente")
                    .Select(s => s.Numero)
                    .ToArray();

                cmbSolicitud.Items.Add(string.Empty);
                cmbSolicitud.Items.AddRange(solicitudes);
                cmbSolicitud.SelectedIndex = 0;
            }
        }

        private void btnRegistrarMovimiento_Click(object sender, EventArgs e)
        {
            panelNuevoMovimiento.Visible = true;
            panelMovimientos.Location = new System.Drawing.Point(34, panelNuevoMovimiento.Bottom + 20);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panelNuevoMovimiento.Visible = false;
            panelMovimientos.Location = new System.Drawing.Point(34, 180);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cmbGalpon.SelectedItem == null || cmbFormula.SelectedItem == null)
            {
                MessageBox.Show("Selecciona galpón y fórmula.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtCantidad.Text, out double cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingresa una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string tipo = cmbTipo.SelectedItem?.ToString() ?? string.Empty;
                if (tipo == "Solicitud de alimento")
                {
                    var solicitud = GlobalData.RegistrarSolicitudAlimento(
                        dtpFecha.Value,
                        cmbGalpon.SelectedItem.ToString() ?? string.Empty,
                        cmbFormula.SelectedItem.ToString() ?? string.Empty,
                        cantidad,
                        txtDetalle.Text.Trim());

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
                        dtpFecha.Value,
                        cmbGalpon.SelectedItem.ToString() ?? string.Empty,
                        cmbFormula.SelectedItem.ToString() ?? string.Empty,
                        cantidad,
                        txtDetalle.Text.Trim(),
                        cmbSolicitud.SelectedItem?.ToString() ?? string.Empty);

                    MessageBox.Show(
                        $"Salida de almacén: {resultado.salida.Numero}\nIngreso a distribución: {resultado.ingreso.Numero}",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    UiHelper.MostrarDetalleDocumento(resultado.ingreso.Numero);
                }

                CargarDistribucion();
                panelNuevoMovimiento.Visible = false;
                panelMovimientos.Location = new System.Drawing.Point(34, 180);
                txtCantidad.Clear();
                txtDetalle.Clear();
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

        private void btnProduccion_Click(object sender, EventArgs e)
        {
            Produccion produ = new Produccion();
            produ.Show();
            this.Hide();
        }
    }
}
