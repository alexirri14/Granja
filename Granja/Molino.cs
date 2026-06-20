using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Granja
{
    public partial class Molino : Form
    {
        private readonly ComboBox cmbOrden = new();
        private readonly Label lblOrden = new();
        private readonly Label lblSalida = new();
        private readonly Label lblSalidaInfo = new();
        private readonly DateTimePicker dtpFiltroDesde = new();
        private readonly DateTimePicker dtpFiltroHasta = new();
        private readonly Label lblFiltroDesde = new();
        private readonly Label lblFiltroHasta = new();
        private readonly Button btnLimpiarFiltros = new();

        public Molino()
        {
            InitializeComponent();
            ConfigurarVista();
            CargarVistaMolino();
        }

        private void ConfigurarVista()
        {
            UiHelper.ConfigurarTituloGeneral(lblTitle);
            UiHelper.ConfigurarNavegacion(btnDashboard, btnProduccion, btnAlmacen, btnVentas, btnAlimento, btnInsumos, btnMolino, btnReportes);

            lblMolinoTitle.Text = "Módulo de Molino";
            lblNombreLote.Text = "Detalle";
            txtNombreLote.PlaceholderText = "Observación del proceso";
            lblCantidadSacos.Text = "Cantidad a procesar";
            txtCantidadSacos.PlaceholderText = "Cantidad a producir";
            btnRegistrarProduccion.Text = "Registrar producción";
            linkAgregarInsumo.Text = "Salida automatica por produccion";
            panelInsumos.BorderStyle = BorderStyle.FixedSingle;
            panelRegistro.Height = 450;
            panelHistorial.Location = new Point(34, 570);
            panelHistorial.Height = 330;

            lblOrden.AutoSize = true;
            lblOrden.Text = "Orden de producción";
            lblOrden.Location = new Point(30, 175);
            panelRegistro.Controls.Add(lblOrden);

            cmbOrden.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOrden.Location = new Point(30, 205);
            cmbOrden.Size = new Size(529, 36);
            panelRegistro.Controls.Add(cmbOrden);

            lblSalida.AutoSize = true;
            lblSalida.Text = "Salida de insumos";
            lblSalida.Location = new Point(630, 175);
            panelRegistro.Controls.Add(lblSalida);

            lblSalidaInfo.AutoSize = false;
            lblSalidaInfo.Text = "Se genera una salida nueva y unica al registrar la produccion.";
            lblSalidaInfo.Location = new Point(630, 205);
            lblSalidaInfo.Size = new Size(529, 36);
            panelRegistro.Controls.Add(lblSalidaInfo);

            txtCantidadSacos.Location = new Point(30, 285);
            txtCantidadSacos.Size = new Size(529, 34);
            lblCantidadSacos.Location = new Point(30, 255);

            txtNombreLote.Location = new Point(630, 285);
            txtNombreLote.Size = new Size(529, 34);
            lblNombreLote.Location = new Point(630, 255);

            linkAgregarInsumo.Location = new Point(30, 350);
            btnRegistrarProduccion.Location = new Point(260, 340);
            btnRegistrarProduccion.Size = new Size(200, 45);

            lblFiltroDesde.AutoSize = true;
            lblFiltroDesde.Text = "Desde";
            lblFiltroDesde.Location = new Point(30, 42);
            panelHistorial.Controls.Add(lblFiltroDesde);

            dtpFiltroDesde.Format = DateTimePickerFormat.Short;
            dtpFiltroDesde.Location = new Point(90, 38);
            dtpFiltroDesde.Size = new Size(140, 27);
            dtpFiltroDesde.Value = DateTime.Today.AddMonths(-1);
            dtpFiltroDesde.ValueChanged += (_, _) => CargarHistorial();
            panelHistorial.Controls.Add(dtpFiltroDesde);

            lblFiltroHasta.AutoSize = true;
            lblFiltroHasta.Text = "Hasta";
            lblFiltroHasta.Location = new Point(255, 42);
            panelHistorial.Controls.Add(lblFiltroHasta);

            dtpFiltroHasta.Format = DateTimePickerFormat.Short;
            dtpFiltroHasta.Location = new Point(315, 38);
            dtpFiltroHasta.Size = new Size(140, 27);
            dtpFiltroHasta.Value = DateTime.Today;
            dtpFiltroHasta.ValueChanged += (_, _) => CargarHistorial();
            panelHistorial.Controls.Add(dtpFiltroHasta);

            btnLimpiarFiltros.Text = "Limpiar filtros";
            btnLimpiarFiltros.Location = new Point(480, 33);
            btnLimpiarFiltros.Size = new Size(140, 34);
            btnLimpiarFiltros.Click += (_, _) =>
            {
                dtpFiltroDesde.Value = DateTime.Today.AddMonths(-1);
                dtpFiltroHasta.Value = DateTime.Today;
                CargarHistorial();
            };
            panelHistorial.Controls.Add(btnLimpiarFiltros);

            dgvHistorial.Location = new Point(30, 110);
            dgvHistorial.Size = new Size(1129, 180);

            panelInsumos.Location = new Point(30, 25);
            panelInsumos.Size = new Size(1129, 130);
        }

        private void CargarVistaMolino()
        {
            cmbOrden.Items.Clear();
            cmbOrden.Items.AddRange(GlobalData.OrdenesProduccion.Select(o => o.Numero).Cast<object>().ToArray());
            if (cmbOrden.Items.Count > 0)
            {
                cmbOrden.SelectedIndex = 0;
            }

            cmbOrden.SelectedIndexChanged += (_, _) =>
            {
                MostrarRequerimientos();
            };

            panelInsumos.Controls.Clear();
            MostrarRequerimientos();

            CargarHistorial();

            dgvHistorial.CellClick += (_, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    string doc = dgvHistorial.Rows[e.RowIndex].Cells[0].Value?.ToString() ?? string.Empty;
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

            linkAgregarInsumo.Enabled = false;
            btnRegistrarProduccion.Click += RegistrarProduccion;
        }

        private void CargarHistorial()
        {
            dgvHistorial.Rows.Clear();
            dgvHistorial.Columns.Clear();
            dgvHistorial.Columns.Add("Documento", "Documento");
            dgvHistorial.Columns.Add("Fecha", "Fecha");
            dgvHistorial.Columns.Add("Orden", "Orden");
            dgvHistorial.Columns.Add("Formula", "Fórmula");
            dgvHistorial.Columns.Add("Cantidad", "Cantidad");
            dgvHistorial.Columns.Add("Salida", "Salida insumos");
            dgvHistorial.Columns.Add("Ingreso", "Ingreso almacén");

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
                dgvHistorial.Rows.Add(
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
            panelInsumos.Controls.Clear();

            panelInsumos.Controls.Add(new Label
            {
                AutoSize = true,
                Location = new Point(10, 10),
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Text = "Requerimiento estimado de insumos"
            });

            string numeroOrden = cmbOrden.SelectedItem?.ToString() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(numeroOrden))
            {
                return;
            }

            var orden = GlobalData.OrdenesProduccion.First(o => o.Numero == numeroOrden);
            double cantidad = double.TryParse(txtCantidadSacos.Text, out double qty) && qty > 0 ? qty : Math.Max(orden.CantidadObjetivo - orden.CantidadProducida, 0);
            var requerimientos = GlobalData.CalcularRequerimientosFormula(orden.Formula, cantidad);

            int y = 40;
            panelInsumos.Controls.Add(new Label
            {
                AutoSize = true,
                Location = new Point(10, y),
                Text = $"{orden.Numero} | {orden.Formula} | Pendiente: {(orden.CantidadObjetivo - orden.CantidadProducida):F2}"
            });
            y += 25;

            foreach (var item in requerimientos)
            {
                panelInsumos.Controls.Add(new Label
                {
                    AutoSize = true,
                    Location = new Point(10, y),
                    Text = $"{item.Insumo}: {item.Cantidad:F2} {item.Unidad}"
                });
                y += 20;
            }
        }

        private void RegistrarProduccion(object? sender, EventArgs e)
        {
            if (cmbOrden.SelectedItem == null)
            {
                MessageBox.Show("Selecciona la orden de producción.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtCantidadSacos.Text, out double cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingresa una cantidad válida a producir.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var resultado = GlobalData.RegistrarProduccionMolino(
                    DateTime.Today,
                    cmbOrden.SelectedItem.ToString() ?? string.Empty,
                    cantidad,
                    txtNombreLote.Text.Trim());

                dgvHistorial.Rows.Insert(
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

        private void lblHistorialTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
