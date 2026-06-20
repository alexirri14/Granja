using System.Data;
// Elimine using innecesarios para mantener el código limpio

namespace Granja
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
            PopulateData();
            btnRegistrarVenta.Click += BtnRegistrarVenta_Click;
            txtCantidad.TextChanged += ActualizarTotal;
            txtPrecio.TextChanged += ActualizarTotal;

            // Corrección realizada para práctica de control de versiones
        }

        private void ActualizarTotal(object sender, EventArgs e)
        {
            if (int.TryParse(txtCantidad.Text, out int cantidad) && decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                lblTotal.Text = "S/ " + (cantidad * precio).ToString("F2");
            }
            else
            {
                lblTotal.Text = "S/ 0.00";
            }
        }

        private void BtnRegistrarVenta_Click(object sender, EventArgs e)
        {
            // Validar
            if (string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                MessageBox.Show("Por favor ingrese el nombre del cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Por favor ingrese una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("Por favor ingrese un precio válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (GlobalData.StockHuevos < cantidad)
            {
                MessageBox.Show("No hay suficiente stock de huevos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Registrar venta
            GlobalData.Ventas.Add(new Venta
            {
                Fecha = DateTime.Now,
                Cliente = txtCliente.Text,
                Cantidad = cantidad,
                Precio = precio
            });

            // Actualizar stock de huevos
            GlobalData.StockHuevos -= cantidad;
            GlobalData.MovimientosHuevos.Add(new MovimientoHuevo
            {
                Fecha = DateTime.Now,
                Tipo = "Venta",
                Detalle = txtCliente.Text,
                Cantidad = -cantidad
            });

            // Actualizar UI
            CargarListado();
            LimpiarCampos();
            MessageBox.Show("Venta registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PopulateData()
        {
            // Datos de ejemplo
            if (!GlobalData.Ventas.Any())
            {
                GlobalData.Ventas.Add(new Venta { Fecha = new DateTime(2026, 4, 8), Cliente = "Juan Pérez", Cantidad = 200, Precio = 7.50m });
                GlobalData.Ventas.Add(new Venta { Fecha = new DateTime(2026, 4, 8), Cliente = "María García", Cantidad = 150, Precio = 7.50m });
            }

            CargarListado();
        }

        private void CargarListado()
        {
            dgvVentas.Columns.Clear();
            dgvVentas.Columns.Add("Fecha", "Fecha");
            dgvVentas.Columns.Add("Cliente", "Cliente");
            dgvVentas.Columns.Add("Cantidad", "Cantidad");
            dgvVentas.Columns.Add("Precio", "Precio");
            dgvVentas.Columns.Add("Total", "Total");

            foreach (var venta in GlobalData.Ventas.OrderByDescending(v => v.Fecha))
            {
                dgvVentas.Rows.Add(
                    venta.Fecha.ToString("dd/MM/yyyy"),
                    venta.Cliente,
                    venta.Cantidad,
                    "S/ " + venta.Precio.ToString("F2"),
                    "S/ " + venta.Total.ToString("F2")
                );
            }

            // Actualizar total de ventas
            decimal totalVentas = GlobalData.Ventas.Sum(v => v.Total);
            lblTotalVentas.Text = "S/ " + totalVentas.ToString("F2");
        }

        private void LimpiarCampos()
        {
            txtCliente.Clear();
            txtCantidad.Clear();
            txtPrecio.Text = "7.5";
            lblTotal.Text = "S/ 0.00";
        }

        // Métodos de navegación
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
            Ventas formventa = new Ventas();
            formventa.Show();
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
