using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Granja
{
    public partial class Molino : Form
    {
        public Molino()
        {
            InitializeComponent();
            ConfigurarVista();
            CargarVistaMolino();
        }

        private void ConfigurarVista()
        {
            UiHelper.ConfigurarTituloGeneral(lblTitle);
            UiHelper.ConfigurarNavegacion(panelNav, btnDashboard, btnProduccion, btnAlmacen, btnVentas, btnAlimento, btnInsumos, btnMolino, btnReportes, btnMolino);

            lblModuloMolinoTitle.Text = "Módulo de Molino";
            lblDetalleProduccionMolino.Text = "Detalle";
            txtDetalleProduccionMolino.PlaceholderText = "Observación del proceso";
            lblCantidadProduccionMolino.Text = "Cantidad a procesar";
            txtCantidadProduccionMolino.PlaceholderText = "Cantidad a producir";
            btnRegistrarProduccionMolino.Text = "Registrar producción";
            linkSalidaInsumosMolino.Text = "Salida automática por producción";
            panelMain.AutoScroll = true;
            panelRequerimientoInsumos.BorderStyle = BorderStyle.FixedSingle;
            panelRegistroProduccionMolino.Height = 450;
            panelHistorialProduccionMolino.Location = new Point(34, 570);
            panelHistorialProduccionMolino.Height = 330;

            lblOrdenProduccionMolino.AutoSize = true;
            lblOrdenProduccionMolino.Text = "Orden de producción";
            lblOrdenProduccionMolino.Location = new Point(30, 175);

            cmbOrdenProduccionMolino.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOrdenProduccionMolino.Location = new Point(30, 205);
            cmbOrdenProduccionMolino.Size = new Size(529, 36);

            lblSalidaInsumosMolino.AutoSize = true;
            lblSalidaInsumosMolino.Text = "Salida de insumos";
            lblSalidaInsumosMolino.Location = new Point(630, 175);

            lblSalidaInsumosInfoMolino.AutoSize = false;
            lblSalidaInsumosInfoMolino.Text = "Se genera una salida nueva y unica al registrar la produccion.";
            lblSalidaInsumosInfoMolino.Location = new Point(630, 205);
            lblSalidaInsumosInfoMolino.Size = new Size(529, 36);

            txtCantidadProduccionMolino.Location = new Point(30, 285);
            txtCantidadProduccionMolino.Size = new Size(529, 34);
            lblCantidadProduccionMolino.Location = new Point(30, 255);

            txtDetalleProduccionMolino.Location = new Point(630, 285);
            txtDetalleProduccionMolino.Size = new Size(529, 34);
            lblDetalleProduccionMolino.Location = new Point(630, 255);

            linkSalidaInsumosMolino.Location = new Point(30, 350);
            btnRegistrarProduccionMolino.Location = new Point(260, 340);
            btnRegistrarProduccionMolino.Size = new Size(200, 45);

            lblFiltroDesde.AutoSize = true;
            lblFiltroDesde.Text = "Desde";
            lblFiltroDesde.Location = new Point(30, 42);

            dtpFiltroDesde.Format = DateTimePickerFormat.Short;
            dtpFiltroDesde.Location = new Point(90, 38);
            dtpFiltroDesde.Size = new Size(140, 27);
            dtpFiltroDesde.Value = DateTime.Today.AddMonths(-1);
            dtpFiltroDesde.ValueChanged += (_, _) => CargarHistorial();

            lblFiltroHasta.AutoSize = true;
            lblFiltroHasta.Text = "Hasta";
            lblFiltroHasta.Location = new Point(255, 42);

            dtpFiltroHasta.Format = DateTimePickerFormat.Short;
            dtpFiltroHasta.Location = new Point(315, 38);
            dtpFiltroHasta.Size = new Size(140, 27);
            dtpFiltroHasta.Value = DateTime.Today;
            dtpFiltroHasta.ValueChanged += (_, _) => CargarHistorial();

            btnLimpiarFiltros.Text = "Limpiar filtros";
            btnLimpiarFiltros.Location = new Point(480, 33);
            btnLimpiarFiltros.Size = new Size(140, 34);
            btnLimpiarFiltros.Click += (_, _) =>
            {
                dtpFiltroDesde.Value = DateTime.Today.AddMonths(-1);
                dtpFiltroHasta.Value = DateTime.Today;
                CargarHistorial();
            };

            dgvHistorialProduccionMolino.Location = new Point(30, 110);
            dgvHistorialProduccionMolino.Size = new Size(1129, 180);

            panelRequerimientoInsumos.Location = new Point(30, 25);
            panelRequerimientoInsumos.Size = new Size(1129, 130);

            lblOrdenProduccionMolino.BringToFront();
            lblSalidaInsumosMolino.BringToFront();
            lblCantidadProduccionMolino.BringToFront();
            lblDetalleProduccionMolino.BringToFront();
        }

        private void CargarVistaMolino()
        {
            cmbOrdenProduccionMolino.Items.Clear();
            cmbOrdenProduccionMolino.Items.AddRange(GlobalData.OrdenesProduccion.Select(o => o.Numero).Cast<object>().ToArray());
            if (cmbOrdenProduccionMolino.Items.Count > 0)
            {
                cmbOrdenProduccionMolino.SelectedIndex = 0;
            }

            cmbOrdenProduccionMolino.SelectedIndexChanged += (_, _) =>
            {
                MostrarRequerimientos();
            };

            MostrarRequerimientos();

            CargarHistorial();

            dgvHistorialProduccionMolino.CellClick += (_, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    string doc = dgvHistorialProduccionMolino.Rows[e.RowIndex].Cells[0].Value?.ToString() ?? string.Empty;
                    if (!string.IsNullOrWhiteSpace(doc))
                    {
                        var ingreso = GlobalData.NotasIngresoAlimento.FirstOrDefault(n => n.ProduccionNumero == doc);
                        if (ingreso != null)
                        {
                            UiHelper.MostrarDetalleDocumento(ingreso.Numero);
                        }
                    }
                }
            };

            linkSalidaInsumosMolino.Enabled = false;
            btnRegistrarProduccionMolino.Click += RegistrarProduccion;
        }

        private void CargarHistorial()
        {
            dgvHistorialProduccionMolino.Rows.Clear();
            dgvHistorialProduccionMolino.Columns.Clear();
            dgvHistorialProduccionMolino.Columns.Add("Documento", "Documento");
            dgvHistorialProduccionMolino.Columns.Add("Fecha", "Fecha");
            dgvHistorialProduccionMolino.Columns.Add("Orden", "Orden");
            dgvHistorialProduccionMolino.Columns.Add("Formula", "Fórmula");
            dgvHistorialProduccionMolino.Columns.Add("Cantidad", "Cantidad");
            dgvHistorialProduccionMolino.Columns.Add("Salida", "Salida insumos");
            dgvHistorialProduccionMolino.Columns.Add("Ingreso", "Ingreso almacén");

            DateTime desde = dtpFiltroDesde.Value.Date;
            DateTime hasta = dtpFiltroHasta.Value.Date;
            if (desde > hasta)
            {
                (desde, hasta) = (hasta, desde);
            }

            foreach (var prod in GlobalData.ProduccionesAlimento
                .Where(p => p.Fecha.Date >= desde && p.Fecha.Date <= hasta)
                .OrderByDescending(p => p.Fecha))
            {
                dgvHistorialProduccionMolino.Rows.Add(
                    prod.Numero,
                    prod.Fecha.ToString("dd/MM/yyyy"),
                    prod.OrdenProduccionNumero,
                    prod.Formula,
                    prod.CantidadProducida.ToString("F2"),
                    prod.OrdenSalidaInsumoNumero,
                    GlobalData.NotasIngresoAlimento.FirstOrDefault(n => n.ProduccionNumero == prod.Numero)?.Numero ?? string.Empty);
            }
        }

        private void MostrarRequerimientos()
        {
            lblRequerimientoInsumosTitle.Text = "Requerimiento estimado de insumos";

            string numeroOrden = cmbOrdenProduccionMolino.SelectedItem?.ToString() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(numeroOrden))
            {
                lblRequerimientoInsumosDetalle.Text = "Selecciona una orden para visualizar el requerimiento.";
                return;
            }

            var orden = GlobalData.OrdenesProduccion.First(o => o.Numero == numeroOrden);
            double cantidad = double.TryParse(txtCantidadProduccionMolino.Text, out double qty) && qty > 0 ? qty : Math.Max(orden.CantidadObjetivo - orden.CantidadProducida, 0);
            var requerimientos = GlobalData.CalcularRequerimientosFormula(orden.Formula, cantidad);
            var texto = $"{orden.Numero} | {orden.Formula} | Pendiente: {(orden.CantidadObjetivo - orden.CantidadProducida):F2}";

            foreach (var item in requerimientos)
            {
                texto += Environment.NewLine + $"{item.Insumo}: {item.Cantidad:F2} {item.Unidad}";
            }

            lblRequerimientoInsumosDetalle.Text = texto;
        }

        private void RegistrarProduccion(object? sender, EventArgs e)
        {
            if (cmbOrdenProduccionMolino.SelectedItem == null)
            {
                MessageBox.Show("Selecciona la orden de producción.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtCantidadProduccionMolino.Text, out double cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingresa una cantidad válida a producir.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var resultado = GlobalData.RegistrarProduccionMolino(
                    DateTime.Today,
                    cmbOrdenProduccionMolino.SelectedItem.ToString() ?? string.Empty,
                    cantidad,
                    txtDetalleProduccionMolino.Text.Trim());

                dgvHistorialProduccionMolino.Rows.Insert(
                    0,
                    resultado.produccion.Numero,
                    resultado.produccion.Fecha.ToString("dd/MM/yyyy"),
                    resultado.produccion.OrdenProduccionNumero,
                    resultado.produccion.Formula,
                    resultado.produccion.CantidadProducida.ToString("F2"),
                    resultado.salida.Numero,
                    resultado.notaIngreso.Numero);
                CargarHistorial();

                MessageBox.Show(
                    $"Salida registrada: {resultado.salida.Numero}\nProducción registrada: {resultado.produccion.Numero}\nIngreso a almacén: {resultado.notaIngreso.Numero}",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                UiHelper.MostrarDetalleDocumento(resultado.notaIngreso.Numero);
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

        private void btnInsumos_Click(object sender, EventArgs e)
        {
            UiHelper.AbrirFormulario<Insumos>(this);
        }

        private void lblHistorialTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
