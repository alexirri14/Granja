using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Granja
{
    public partial class Insumos : Form
    {
        private readonly ComboBox cmbSolicitudIngreso = new();
        private readonly Label lblSolicitudIngreso = new();
        private readonly Label lblFechaDoc = new();
        private readonly DateTimePicker dtpFechaDoc = new();
        private readonly Label lblReferencia = new();
        private readonly TextBox txtReferencia = new();
        private readonly RadioButton rdbInsumoExistente = new();
        private readonly RadioButton rdbInsumoNuevo = new();
        private readonly TextBox txtNuevoInsumo = new();
        private readonly TextBox txtNuevaUnidad = new();
        private readonly TextBox txtNuevoStockMinimo = new();
        private readonly Label lblNuevoInsumo = new();
        private readonly Label lblNuevaUnidad = new();
        private readonly Label lblNuevoStockMinimo = new();
        private readonly Button btnAgregarDetalle = new();
        private readonly DataGridView dgvDetalleDocumento = new();

        public Insumos()
        {
            InitializeComponent();
            ConfigurarVista();
            CargarTarjetas();
            CargarInventario();
            CargarHistorial();
            CargarSolicitudes();
        }

        private void ConfigurarVista()
        {
            UiHelper.ConfigurarTituloGeneral(lblTitle);
            UiHelper.ConfigurarNavegacion(btnDashboard, btnProduccion, btnAlmacen, btnVentas, btnAlimento, btnInsumos, btnMolino, btnReportes);

            lblInsumosTitle.Text = "Módulo de Insumos";
            lblEntradasTitulo.Text = "Solicitudes";
            lblConsumosTitulo.Text = "Documentos";
            lblInventarioTitulo.Text = "Disponibilidad de insumos";
            lblHistorialTitulo.Text = "Notas y órdenes";
            btnRegistrarMovimiento.Text = "Nueva nota de ingreso";
            btnVerRecetas.Text = "Ver pedidos";
            btnRegistrarMovimientoConfirmar.Text = "Registrar nota";
            btnCerrarRecetas.Text = "Cerrar";
            btnVerRecetas.Text = "Ver solicitudes";

            panelNuevoMovimiento.Visible = false;
            panelRecetas.Visible = false;
            ConfigurarPanelOperacion();
            dgvHistorial.CellClick += DgvHistorial_CellClick;
        }

        private void CargarTarjetas()
        {
            lblTotalValor.Text = GlobalData.Insumos.Count.ToString();
            lblCriticoValor.Text = GlobalData.ObtenerInsumosCriticos().Count().ToString();
            lblEntradasValor.Text = GlobalData.SolicitudesAbastecimientoInsumos.Count(s => s.Estado == "Pendiente").ToString();
            lblConsumosValor.Text = GlobalData.MovimientosInsumos.Count.ToString();
        }

        private void CargarInventario()
        {
            dgvInventario.Rows.Clear();
            dgvInventario.Columns.Clear();
            dgvInventario.Columns.Add("Nombre", "Insumo");
            dgvInventario.Columns.Add("Unidad", "Unidad");
            dgvInventario.Columns.Add("Disponible", "Disponible");
            dgvInventario.Columns.Add("Minimo", "Stock mínimo");
            dgvInventario.Columns.Add("Estado", "Estado");

            foreach (var insumo in GlobalData.Insumos.OrderBy(i => i.Nombre))
            {
                dgvInventario.Rows.Add(
                    insumo.Nombre,
                    insumo.Unidad,
                    insumo.StockDisponible.ToString("F2"),
                    insumo.StockMinimo.ToString("F2"),
                    insumo.Estado);
            }
        }

        private void CargarHistorial()
        {
            dgvHistorial.Rows.Clear();
            dgvHistorial.Columns.Clear();
            dgvHistorial.Columns.Add("Documento", "Documento");
            dgvHistorial.Columns.Add("Fecha", "Fecha");
            dgvHistorial.Columns.Add("Tipo", "Tipo");
            dgvHistorial.Columns.Add("Referencia", "Proveedor / Orden");
            dgvHistorial.Columns.Add("Items", "Items");
            dgvHistorial.Columns.Add("Detalle", "Detalle");

            foreach (var nota in GlobalData.NotasIngresoInsumos.OrderByDescending(m => m.Fecha))
            {
                dgvHistorial.Rows.Add(
                    nota.Numero,
                    nota.Fecha.ToString("dd/MM/yyyy"),
                    "Nota de ingreso",
                    nota.Proveedor,
                    nota.Detalles.Count,
                    nota.Detalle);
            }

            foreach (var orden in GlobalData.OrdenesSalidaInsumos.OrderByDescending(m => m.Fecha))
            {
                dgvHistorial.Rows.Add(
                    orden.Numero,
                    orden.Fecha.ToString("dd/MM/yyyy"),
                    "Orden de salida",
                    orden.OrdenProduccionNumero,
                    orden.Detalles.Count,
                    orden.Detalle);
            }
        }

        private void CargarSolicitudes()
        {
            dgvRecetaGalpon4.Columns.Clear();
            dgvRecetaGalpon4.Columns.Add("Numero", "Solicitud");
            dgvRecetaGalpon4.Columns.Add("Fecha", "Fecha");
            dgvRecetaGalpon4.Columns.Add("Insumo", "Insumo");
            dgvRecetaGalpon4.Columns.Add("Cantidad", "Cantidad");
            dgvRecetaGalpon4.Columns.Add("Estado", "Estado");

            foreach (var solicitud in GlobalData.ObtenerSolicitudesAbastecimientoPendientes().Take(6))
            {
                dgvRecetaGalpon4.Rows.Add(
                    solicitud.Numero,
                    solicitud.Fecha.ToString("dd/MM/yyyy"),
                    solicitud.Insumo,
                    solicitud.Cantidad.ToString("F2"),
                    solicitud.Estado);
            }

            dgvRecetaGalpon687.Columns.Clear();
            dgvRecetaGalpon687.Columns.Add("Documento", "Documento");
            dgvRecetaGalpon687.Columns.Add("Fecha", "Fecha");
            dgvRecetaGalpon687.Columns.Add("Orden", "Orden");
            dgvRecetaGalpon687.Columns.Add("Formula", "Fórmula");
            foreach (var solicitud in GlobalData.ObtenerSolicitudesAbastecimientoPendientes().Take(8))
            {
                dgvRecetaGalpon687.Rows.Add(
                    solicitud.Numero,
                    solicitud.Fecha.ToString("dd/MM/yyyy"),
                    solicitud.OrdenProduccionNumero,
                    solicitud.Formula);
            }

            dgvRecetaGalpon358.Columns.Clear();
            dgvRecetaGalpon358.Columns.Add("Campo", "Campo");
            dgvRecetaGalpon358.Columns.Add("Detalle", "Detalle");
            dgvRecetaGalpon358.Rows.Add("Pedido", "Selecciona una solicitud pendiente para registrar la nota de ingreso.");
            dgvRecetaGalpon358.Rows.Add("Orden", "Si falta alimento para un galpón, la orden de producción se genera automáticamente.");
            dgvRecetaGalpon358.Rows.Add("Detalle", "Haz clic en notas y órdenes para ver el desglose.");

            lblRecetasTitulo.Text = "Pedidos de abastecimiento";
            lblRecetaGalpon4Titulo.Text = "Solicitudes pendientes";
            lblRecetaGalpon687Titulo.Text = "Cobertura por orden";
            lblRecetaGalpon358Titulo.Text = "Reglas del módulo";
        }

        private void ConfigurarPanelOperacion()
        {
            panelNuevoMovimiento.Controls.Clear();
            panelNuevoMovimiento.Size = new Size(1189, 620);

            lblNuevoMovimientoTitulo.Location = new Point(30, 20);
            lblNuevoMovimientoTitulo.Text = "Nota de ingreso por pedido";
            panelNuevoMovimiento.Controls.Add(lblNuevoMovimientoTitulo);

            lblSolicitudIngreso.AutoSize = true;
            lblSolicitudIngreso.Text = "Solicitud de abastecimiento";
            lblSolicitudIngreso.Location = new Point(30, 80);
            panelNuevoMovimiento.Controls.Add(lblSolicitudIngreso);

            cmbSolicitudIngreso.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSolicitudIngreso.Location = new Point(30, 110);
            cmbSolicitudIngreso.Size = new Size(529, 36);
            cmbSolicitudIngreso.SelectedIndexChanged += (_, _) => CargarSolicitudSeleccionada();
            panelNuevoMovimiento.Controls.Add(cmbSolicitudIngreso);

            lblFechaDoc.AutoSize = true;
            lblFechaDoc.Text = "Fecha";
            lblFechaDoc.Location = new Point(630, 80);
            panelNuevoMovimiento.Controls.Add(lblFechaDoc);

            dtpFechaDoc.Location = new Point(630, 110);
            dtpFechaDoc.Size = new Size(529, 34);
            panelNuevoMovimiento.Controls.Add(dtpFechaDoc);

            lblReferencia.AutoSize = true;
            lblReferencia.Text = "Proveedor";
            lblReferencia.Location = new Point(30, 160);
            panelNuevoMovimiento.Controls.Add(lblReferencia);

            txtReferencia.Location = new Point(30, 190);
            txtReferencia.Size = new Size(529, 34);
            txtReferencia.PlaceholderText = "Nombre del proveedor";
            panelNuevoMovimiento.Controls.Add(txtReferencia);

            lblInsumoMovimiento.Text = "Insumo";
            lblInsumoMovimiento.Location = new Point(630, 160);
            panelNuevoMovimiento.Controls.Add(lblInsumoMovimiento);

            cmbInsumoMovimiento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbInsumoMovimiento.Location = new Point(630, 190);
            cmbInsumoMovimiento.Size = new Size(529, 36);
            panelNuevoMovimiento.Controls.Add(cmbInsumoMovimiento);

            rdbInsumoExistente.AutoSize = true;
            rdbInsumoExistente.Text = "Usar insumo existente";
            rdbInsumoExistente.Location = new Point(30, 245);
            rdbInsumoExistente.Checked = true;
            rdbInsumoExistente.CheckedChanged += (_, _) => ActualizarModoInsumo();
            panelNuevoMovimiento.Controls.Add(rdbInsumoExistente);

            rdbInsumoNuevo.AutoSize = true;
            rdbInsumoNuevo.Text = "Registrar insumo nuevo";
            rdbInsumoNuevo.Location = new Point(260, 245);
            rdbInsumoNuevo.CheckedChanged += (_, _) => ActualizarModoInsumo();
            panelNuevoMovimiento.Controls.Add(rdbInsumoNuevo);

            lblNuevoInsumo.AutoSize = true;
            lblNuevoInsumo.Text = "Nuevo insumo";
            lblNuevoInsumo.Location = new Point(30, 280);
            panelNuevoMovimiento.Controls.Add(lblNuevoInsumo);

            txtNuevoInsumo.Location = new Point(30, 310);
            txtNuevoInsumo.Size = new Size(360, 34);
            txtNuevoInsumo.PlaceholderText = "Nombre del nuevo insumo";
            panelNuevoMovimiento.Controls.Add(txtNuevoInsumo);

            lblNuevaUnidad.AutoSize = true;
            lblNuevaUnidad.Text = "Unidad";
            lblNuevaUnidad.Location = new Point(410, 280);
            panelNuevoMovimiento.Controls.Add(lblNuevaUnidad);

            txtNuevaUnidad.Location = new Point(410, 310);
            txtNuevaUnidad.Size = new Size(170, 34);
            txtNuevaUnidad.PlaceholderText = "KG o L";
            panelNuevoMovimiento.Controls.Add(txtNuevaUnidad);

            lblNuevoStockMinimo.AutoSize = true;
            lblNuevoStockMinimo.Text = "Stock mínimo";
            lblNuevoStockMinimo.Location = new Point(600, 280);
            panelNuevoMovimiento.Controls.Add(lblNuevoStockMinimo);

            txtNuevoStockMinimo.Location = new Point(600, 310);
            txtNuevoStockMinimo.Size = new Size(170, 34);
            txtNuevoStockMinimo.PlaceholderText = "0";
            panelNuevoMovimiento.Controls.Add(txtNuevoStockMinimo);

            lblCantidadMovimiento.Text = "Cantidad";
            lblCantidadMovimiento.Location = new Point(30, 360);
            panelNuevoMovimiento.Controls.Add(lblCantidadMovimiento);

            txtCantidadMovimiento.Location = new Point(30, 390);
            txtCantidadMovimiento.Size = new Size(529, 34);
            txtCantidadMovimiento.PlaceholderText = "Cantidad solicitada";
            panelNuevoMovimiento.Controls.Add(txtCantidadMovimiento);

            lblObservaciones.Text = "Detalle";
            lblObservaciones.Location = new Point(630, 360);
            panelNuevoMovimiento.Controls.Add(lblObservaciones);

            txtObservaciones.Location = new Point(630, 390);
            txtObservaciones.Size = new Size(529, 34);
            txtObservaciones.Multiline = false;
            txtObservaciones.PlaceholderText = "Detalle del ingreso";
            panelNuevoMovimiento.Controls.Add(txtObservaciones);

            btnAgregarDetalle.Text = "Cargar detalle";
            btnAgregarDetalle.Location = new Point(30, 445);
            btnAgregarDetalle.Size = new Size(170, 40);
            btnAgregarDetalle.BackColor = Color.FromArgb(0, 125, 62);
            btnAgregarDetalle.ForeColor = Color.White;
            btnAgregarDetalle.FlatStyle = FlatStyle.Flat;
            btnAgregarDetalle.FlatAppearance.BorderSize = 0;
            btnAgregarDetalle.Click += (_, _) => AgregarDetalleDocumento();
            panelNuevoMovimiento.Controls.Add(btnAgregarDetalle);

            dgvDetalleDocumento.Location = new Point(30, 500);
            dgvDetalleDocumento.Size = new Size(1129, 90);
            dgvDetalleDocumento.AllowUserToAddRows = false;
            dgvDetalleDocumento.AllowUserToDeleteRows = true;
            dgvDetalleDocumento.BackgroundColor = Color.White;
            dgvDetalleDocumento.RowHeadersVisible = false;
            dgvDetalleDocumento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalleDocumento.Columns.Clear();
            dgvDetalleDocumento.Columns.Add("Item", "Insumo");
            dgvDetalleDocumento.Columns.Add("Cantidad", "Cantidad");
            dgvDetalleDocumento.Columns.Add("Unidad", "Unidad");
            panelNuevoMovimiento.Controls.Add(dgvDetalleDocumento);

            btnRegistrarMovimientoConfirmar.Location = new Point(30, 600);
            btnCancelarMovimiento.Location = new Point(180, 600);
            panelNuevoMovimiento.Controls.Add(btnRegistrarMovimientoConfirmar);
            panelNuevoMovimiento.Controls.Add(btnCancelarMovimiento);

            dtpFechaDoc.Value = DateTime.Today;
            ActualizarSolicitudesIngreso();
            ActualizarModoInsumo();
        }

        private void btnRegistrarMovimiento_Click(object sender, EventArgs e)
        {
            LimpiarOperacion();
            if (cmbSolicitudIngreso.Items.Count == 0)
            {
                MessageBox.Show("No hay pedidos pendientes para registrar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            panelNuevoMovimiento.Visible = true;
            panelInventario.Visible = false;
            panelHistorial.Visible = false;
            panelRecetas.Visible = false;
        }

        private void btnCancelarMovimiento_Click(object sender, EventArgs e)
        {
            panelNuevoMovimiento.Visible = false;
            panelInventario.Visible = true;
            panelHistorial.Visible = true;
        }

        private void btnRegistrarMovimientoConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                string numeroSolicitud = cmbSolicitudIngreso.SelectedItem?.ToString() ?? string.Empty;
                var solicitud = GlobalData.ObtenerSolicitudAbastecimiento(numeroSolicitud);
                if (solicitud == null)
                {
                    MessageBox.Show("Selecciona un pedido pendiente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (dgvDetalleDocumento.Rows.Count == 0)
                {
                    MessageBox.Show("Carga el detalle del pedido antes de registrar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var detalles = dgvDetalleDocumento.Rows.Cast<DataGridViewRow>()
                    .Where(r => r.Cells[0].Value != null)
                    .Select(r => new DocumentoDetalle
                    {
                        Item = r.Cells[0].Value?.ToString() ?? string.Empty,
                        Cantidad = double.Parse(r.Cells[1].Value?.ToString() ?? "0", CultureInfo.InvariantCulture),
                        Unidad = r.Cells[2].Value?.ToString() ?? string.Empty
                    })
                    .ToList();

                double cantidadRegistrada = detalles.Sum(d => d.Cantidad);
                if (Math.Abs(cantidadRegistrada - solicitud.Cantidad) > 0.0001)
                {
                    MessageBox.Show("La nota debe coincidir con la cantidad del pedido para poder atenderlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var nota = GlobalData.RegistrarNotaIngresoInsumo(
                    dtpFechaDoc.Value,
                    txtReferencia.Text.Trim(),
                    txtObservaciones.Text.Trim(),
                    detalles,
                    solicitud.Numero);

                MessageBox.Show($"Nota registrada: {nota.Numero}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UiHelper.MostrarDetalleDocumento(nota.Numero);

                LimpiarOperacion();
                panelNuevoMovimiento.Visible = false;
                panelInventario.Visible = true;
                panelHistorial.Visible = true;
                CargarTarjetas();
                CargarInventario();
                CargarHistorial();
                CargarSolicitudes();
            }
            catch (Exception ex) when (ex is InvalidOperationException || ex is FormatException)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVerRecetas_Click(object sender, EventArgs e)
        {
            panelRecetas.Visible = true;
            panelInventario.Visible = false;
            panelHistorial.Visible = false;
        }

        private void btnCerrarRecetas_Click(object sender, EventArgs e)
        {
            panelRecetas.Visible = false;
            panelInventario.Visible = true;
            panelHistorial.Visible = true;
        }

        private void AgregarDetalleDocumento()
        {
            string numeroSolicitud = cmbSolicitudIngreso.SelectedItem?.ToString() ?? string.Empty;
            var solicitud = GlobalData.ObtenerSolicitudAbastecimiento(numeroSolicitud);
            if (solicitud == null)
            {
                MessageBox.Show("Selecciona un pedido pendiente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtCantidadMovimiento.Text, out double cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingresa una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string insumo;
            string unidad;
            if (rdbInsumoNuevo.Checked)
            {
                insumo = txtNuevoInsumo.Text.Trim();
                unidad = txtNuevaUnidad.Text.Trim().ToUpperInvariant();
                if (string.IsNullOrWhiteSpace(insumo) || string.IsNullOrWhiteSpace(unidad))
                {
                    MessageBox.Show("Completa el nombre y la unidad del nuevo insumo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (GlobalData.ExisteInsumo(insumo))
                {
                    MessageBox.Show("Ese insumo ya existe. Selecciónalo como insumo predefinido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!double.TryParse(txtNuevoStockMinimo.Text, out double stockMinimo) || stockMinimo < 0)
                {
                    MessageBox.Show("Ingresa un stock mínimo válido para el nuevo insumo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                GlobalData.RegistrarInsumoDesdeIngreso(insumo, unidad, stockMinimo, "Registrado desde nota de ingreso por pedido");
                CargarInventario();
            }
            else
            {
                if (cmbInsumoMovimiento.SelectedItem == null)
                {
                    MessageBox.Show("Selecciona un insumo existente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                insumo = cmbInsumoMovimiento.SelectedItem.ToString() ?? string.Empty;
                unidad = GlobalData.ObtenerUnidadInsumo(insumo);
            }

            dgvDetalleDocumento.Rows.Clear();
            dgvDetalleDocumento.Rows.Add(insumo, cantidad.ToString("F2", CultureInfo.InvariantCulture), unidad);
        }

        private void LimpiarOperacion()
        {
            txtReferencia.Clear();
            txtObservaciones.Clear();
            txtCantidadMovimiento.Clear();
            txtNuevoInsumo.Clear();
            txtNuevaUnidad.Clear();
            txtNuevoStockMinimo.Clear();
            dgvDetalleDocumento.Rows.Clear();
            dtpFechaDoc.Value = DateTime.Today;
            rdbInsumoExistente.Checked = true;
            ActualizarSolicitudesIngreso();
        }

        private void ActualizarSolicitudesIngreso()
        {
            cmbSolicitudIngreso.Items.Clear();
            foreach (var solicitud in GlobalData.ObtenerSolicitudesAbastecimientoPendientes())
            {
                cmbSolicitudIngreso.Items.Add(solicitud.Numero);
            }

            if (cmbSolicitudIngreso.Items.Count > 0)
            {
                cmbSolicitudIngreso.SelectedIndex = 0;
            }
            else
            {
                cmbInsumoMovimiento.DataSource = null;
                txtCantidadMovimiento.Clear();
            }
        }

        private void CargarSolicitudSeleccionada()
        {
            string numeroSolicitud = cmbSolicitudIngreso.SelectedItem?.ToString() ?? string.Empty;
            var solicitud = GlobalData.ObtenerSolicitudAbastecimiento(numeroSolicitud);
            if (solicitud == null)
            {
                cmbInsumoMovimiento.DataSource = null;
                txtCantidadMovimiento.Clear();
                return;
            }

            cmbInsumoMovimiento.DataSource = GlobalData.ObtenerInsumosActivos().Select(i => i.Nombre).ToList();
            if (GlobalData.ExisteInsumo(solicitud.Insumo))
            {
                cmbInsumoMovimiento.SelectedItem = GlobalData.ObtenerInsumosActivos()
                    .First(i => i.Nombre.Equals(solicitud.Insumo, StringComparison.OrdinalIgnoreCase)).Nombre;
                rdbInsumoExistente.Checked = true;
            }
            else
            {
                rdbInsumoNuevo.Checked = true;
                txtNuevoInsumo.Text = solicitud.Insumo;
            }

            txtCantidadMovimiento.Text = solicitud.Cantidad.ToString("F2", CultureInfo.InvariantCulture);
            txtObservaciones.Text = solicitud.Detalle;
            dgvDetalleDocumento.Rows.Clear();
        }

        private void ActualizarModoInsumo()
        {
            bool usarNuevo = rdbInsumoNuevo.Checked;
            cmbInsumoMovimiento.Enabled = !usarNuevo;
            txtNuevoInsumo.Enabled = usarNuevo;
            txtNuevaUnidad.Enabled = usarNuevo;
            txtNuevoStockMinimo.Enabled = usarNuevo;
            lblNuevoInsumo.Enabled = usarNuevo;
            lblNuevaUnidad.Enabled = usarNuevo;
            lblNuevoStockMinimo.Enabled = usarNuevo;
        }

        private void DgvHistorial_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            string documento = dgvHistorial.Rows[e.RowIndex].Cells[0].Value?.ToString() ?? string.Empty;
            if (!string.IsNullOrWhiteSpace(documento))
            {
                UiHelper.MostrarDetalleDocumento(documento);
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
            Alimento alimento = new Alimento();
            alimento.Show();
            this.Hide();
        }

        private void btnMolino_Click(object sender, EventArgs e)
        {
            Molino molino = new Molino();
            molino.Show();
            this.Hide();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            Reportes reportes = new Reportes();
            reportes.Show();
            this.Hide();
        }
    }
}
