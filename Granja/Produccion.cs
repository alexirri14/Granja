using System;
using System.Linq;
using System.Windows.Forms;

namespace Granja
{
    public partial class Produccion : Form
    {
        private readonly ComboBox cmbEstadoOrden = new();
        private readonly TextBox txtDetalleOrden = new();
        private readonly Label lblEstadoOrden = new();
        private readonly Label lblDetalleOrden = new();
        private readonly DateTimePicker dtpFiltroDesde = new();
        private readonly DateTimePicker dtpFiltroHasta = new();
        private readonly Label lblFiltroDesde = new();
        private readonly Label lblFiltroHasta = new();
        private readonly Button btnLimpiarFiltros = new();
        private string ordenSeleccionada = string.Empty;

        public Produccion()
        {
            InitializeComponent();
            btnGuardar.Click += BtnGuardar_Click;
            btnCancelar.Click += BtnCancelar_Click;
            ConfigurarVista();
            CargarListado();
        }

        private void ConfigurarVista()
        {
            UiHelper.ConfigurarTituloGeneral(lblTitle);
            UiHelper.ConfigurarNavegacion(btnDashboard, btnProduccion, btnAlmacen, btnVentas, btnAlimento, btnInsumos, btnMolino, btnReportes);

            lblFormTitle.Text = "Orden de Producción";
            lblGalpon.Text = "Fórmula";
            lblFecha.Text = "Fecha";
            lblCantidad.Text = "Cantidad a producir";
            lblListTitle.Text = "Historial de órdenes";

            lblEstadoOrden.AutoSize = true;
            lblEstadoOrden.Text = "Estado";
            lblEstadoOrden.Location = new System.Drawing.Point(34, 285);
            panelForm.Controls.Add(lblEstadoOrden);

            cmbEstadoOrden.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstadoOrden.Items.AddRange(new object[] { "Pendiente", "En proceso", "Completada", "Inhabilitada" });
            cmbEstadoOrden.Location = new System.Drawing.Point(34, 315);
            cmbEstadoOrden.Size = new System.Drawing.Size(529, 36);
            panelForm.Controls.Add(cmbEstadoOrden);

            lblDetalleOrden.AutoSize = true;
            lblDetalleOrden.Text = "Detalle";
            lblDetalleOrden.Location = new System.Drawing.Point(630, 285);
            panelForm.Controls.Add(lblDetalleOrden);

            txtDetalleOrden.Location = new System.Drawing.Point(630, 315);
            txtDetalleOrden.Size = new System.Drawing.Size(529, 34);
            txtDetalleOrden.PlaceholderText = "Observación de la orden";
            panelForm.Controls.Add(txtDetalleOrden);

            cmbGalpon.Items.Clear();
            cmbGalpon.Items.AddRange(GlobalData.ObtenerFormulasActivas().Select(f => f.Nombre).Cast<object>().ToArray());
            if (cmbGalpon.Items.Count > 0)
            {
                cmbGalpon.SelectedIndex = 0;
            }

            txtCantidad.PlaceholderText = "Cantidad de alimento balanceado";
            btnGuardar.Text = "Registrar orden";
            btnCancelar.Text = "Actualizar estado";
            dtpFecha.Value = DateTime.Today;
            cmbEstadoOrden.SelectedIndex = 0;
            dgvProduccionList.SelectionChanged += (_, _) => CargarOrdenSeleccionada();

            panelForm.Height = 430;
            panelList.Location = new System.Drawing.Point(34, 520);
            panelList.Height = 320;

            cmbGalpon.Location = new System.Drawing.Point(30, 55);
            cmbGalpon.Size = new System.Drawing.Size(1129, 36);
            dtpFecha.Location = new System.Drawing.Point(30, 135);
            dtpFecha.Size = new System.Drawing.Size(1129, 34);
            txtCantidad.Location = new System.Drawing.Point(30, 215);
            txtCantidad.Size = new System.Drawing.Size(1129, 34);

            lblEstadoOrden.Location = new System.Drawing.Point(30, 265);
            cmbEstadoOrden.Location = new System.Drawing.Point(30, 295);
            cmbEstadoOrden.Size = new System.Drawing.Size(529, 36);

            lblDetalleOrden.Location = new System.Drawing.Point(630, 265);
            txtDetalleOrden.Location = new System.Drawing.Point(630, 295);
            txtDetalleOrden.Size = new System.Drawing.Size(529, 34);

            btnGuardar.Location = new System.Drawing.Point(30, 355);
            btnCancelar.Location = new System.Drawing.Point(190, 355);

            lblFiltroDesde.AutoSize = true;
            lblFiltroDesde.Text = "Desde";
            lblFiltroDesde.Location = new System.Drawing.Point(30, 42);
            panelList.Controls.Add(lblFiltroDesde);

            dtpFiltroDesde.Format = DateTimePickerFormat.Short;
            dtpFiltroDesde.Location = new System.Drawing.Point(90, 38);
            dtpFiltroDesde.Size = new System.Drawing.Size(140, 27);
            dtpFiltroDesde.Value = DateTime.Today.AddMonths(-1);
            dtpFiltroDesde.ValueChanged += (_, _) => CargarListado();
            panelList.Controls.Add(dtpFiltroDesde);

            lblFiltroHasta.AutoSize = true;
            lblFiltroHasta.Text = "Hasta";
            lblFiltroHasta.Location = new System.Drawing.Point(255, 42);
            panelList.Controls.Add(lblFiltroHasta);

            dtpFiltroHasta.Format = DateTimePickerFormat.Short;
            dtpFiltroHasta.Location = new System.Drawing.Point(315, 38);
            dtpFiltroHasta.Size = new System.Drawing.Size(140, 27);
            dtpFiltroHasta.Value = DateTime.Today;
            dtpFiltroHasta.ValueChanged += (_, _) => CargarListado();
            panelList.Controls.Add(dtpFiltroHasta);

            btnLimpiarFiltros.Text = "Limpiar filtros";
            btnLimpiarFiltros.Location = new System.Drawing.Point(480, 33);
            btnLimpiarFiltros.Size = new System.Drawing.Size(140, 34);
            btnLimpiarFiltros.Click += (_, _) =>
            {
                dtpFiltroDesde.Value = DateTime.Today.AddMonths(-1);
                dtpFiltroHasta.Value = DateTime.Today;
                CargarListado();
            };
            panelList.Controls.Add(btnLimpiarFiltros);

            dgvProduccionList.Location = new System.Drawing.Point(30, 110);
            dgvProduccionList.Size = new System.Drawing.Size(1129, 180);
        }

        private void CargarListado()
        {
            dgvProduccionList.Rows.Clear();
            dgvProduccionList.Columns.Clear();
            dgvProduccionList.Columns.Add("Numero", "Orden");
            dgvProduccionList.Columns.Add("Fecha", "Fecha");
            dgvProduccionList.Columns.Add("Formula", "Fórmula");
            dgvProduccionList.Columns.Add("Objetivo", "Objetivo");
            dgvProduccionList.Columns.Add("Producido", "Producido");
            dgvProduccionList.Columns.Add("Estado", "Estado");

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
                dgvProduccionList.Rows.Add(
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
            if (dgvProduccionList.CurrentRow == null)
            {
                return;
            }

            ordenSeleccionada = dgvProduccionList.CurrentRow.Cells[0].Value?.ToString() ?? string.Empty;
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

            cmbGalpon.SelectedItem = orden.Formula;
            dtpFecha.Value = orden.Fecha;
            txtCantidad.Text = orden.CantidadObjetivo.ToString("F2");
            cmbEstadoOrden.SelectedItem = orden.Estado;
            txtDetalleOrden.Text = orden.Detalle;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Form1 dashboard = new Form1();
            dashboard.Show();
            this.Hide();
        }

        private void btnProduccion_Click_1(object sender, EventArgs e)
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

        private void BtnCancelar_Click(object sender, EventArgs e)
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

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbGalpon.SelectedItem == null)
            {
                MessageBox.Show("Selecciona una fórmula.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtCantidad.Text, out double cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingresa una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var orden = GlobalData.RegistrarOrdenProduccion(
                    dtpFecha.Value,
                    cmbGalpon.SelectedItem.ToString() ?? string.Empty,
                    cantidad,
                    txtDetalleOrden.Text.Trim());

                CargarListado();
                txtCantidad.Clear();
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
