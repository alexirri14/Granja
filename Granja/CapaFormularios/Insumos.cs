using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Granja
{
    public partial class Insumos : Form
    {
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
            UiHelper.ConfigurarNavegacion(panelNav, btnDashboard, btnProduccion, btnAlmacen, btnVentas, btnAlimento, btnInsumos, btnMolino, btnReportes, btnInsumos);

            lblInsumosTitle.Text = "Módulo de Insumos";
            lblEntradasTitulo.Text = "Solicitudes";
            lblConsumosTitulo.Text = "Documentos";
            lblInventarioTitulo.Text = "Disponibilidad de insumos";
            lblHistorialTitulo.Text = "Notas y órdenes";
            btnRegistrarMovimiento.Text = "Nueva nota de ingreso";
            btnRegistrarMovimientoConfirmar.Text = "Registrar nota";
            btnCerrarRecetas.Text = "Cerrar";
            btnVerRecetas.Text = "Ver solicitudes";

            panelMain.AutoScroll = true;
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
            lblNuevoMovimientoTitulo.Text = "Nota de ingreso por pedido";
            lblSolicitudIngreso.Text = "Solicitud de abastecimiento";
            cmbSolicitudIngreso.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSolicitudIngreso.SelectedIndexChanged += (_, _) => CargarSolicitudSeleccionada();
            lblFechaDoc.Text = "Fecha";
            lblReferencia.Text = "Proveedor";
            txtReferencia.PlaceholderText = "Nombre del proveedor";
            lblInsumoMovimiento.Text = "Insumo";
            cmbInsumoMovimiento.DropDownStyle = ComboBoxStyle.DropDownList;
            rdbInsumoExistente.Text = "Usar insumo existente";
            rdbInsumoExistente.Checked = true;
            rdbInsumoExistente.CheckedChanged += (_, _) => ActualizarModoInsumo();
            rdbInsumoNuevo.Text = "Registrar insumo nuevo";
            rdbInsumoNuevo.CheckedChanged += (_, _) => ActualizarModoInsumo();
            lblNuevoInsumo.Text = "Nuevo insumo";
            txtNuevoInsumo.PlaceholderText = "Nombre del nuevo insumo";
            lblNuevaUnidad.Text = "Unidad";
            txtNuevaUnidad.PlaceholderText = "KG o L";
            lblNuevoStockMinimo.Text = "Stock mínimo";
            txtNuevoStockMinimo.PlaceholderText = "0";
            lblCantidadMovimiento.Text = "Cantidad";
            txtCantidadMovimiento.PlaceholderText = "Cantidad solicitada";
            lblObservaciones.Text = "Detalle";
            txtObservaciones.PlaceholderText = "Detalle del ingreso";
            btnAgregarDetalle.Text = "Cargar detalle";
            btnAgregarDetalle.BackColor = Color.FromArgb(0, 125, 62);
            btnAgregarDetalle.ForeColor = Color.White;
            btnAgregarDetalle.FlatStyle = FlatStyle.Flat;
            btnAgregarDetalle.FlatAppearance.BorderSize = 0;
            btnAgregarDetalle.Click += (_, _) => AgregarDetalleDocumento();
            dgvDetalleDocumento.AllowUserToAddRows = false;
            dgvDetalleDocumento.AllowUserToDeleteRows = true;
            dgvDetalleDocumento.BackgroundColor = Color.White;
            dgvDetalleDocumento.RowHeadersVisible = false;
            dgvDetalleDocumento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalleDocumento.Columns.Clear();
            dgvDetalleDocumento.Columns.Add("Item", "Insumo");
            dgvDetalleDocumento.Columns.Add("Cantidad", "Cantidad");
            dgvDetalleDocumento.Columns.Add("Unidad", "Unidad");

            // Estos controles quedaron visibles en el Designer y ya no se usan para
            // reconstruir la interfaz en runtime.
            cmbTipoMovimiento.Visible = false;
            lblTipoMovimiento.Visible = false;

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
            UiHelper.AbrirFormulario<Dashboard>(this);
        }

        private void btnProduccion_Click(object sender, EventArgs e)
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
    }
}
