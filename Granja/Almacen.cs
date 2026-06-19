using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Granja
{
    public partial class Almacen : Form
    {
        public Almacen()
        {
            InitializeComponent();
            panelNuevoMovimiento.Visible = false;
            PopulateData();
        }

        private void PopulateData()
        {
            // Agregar datos de ejemplo si no hay
            if (!GlobalData.MovimientosHuevos.Any())
            {
                GlobalData.MovimientosHuevos.Add(new MovimientoHuevo { Fecha = new DateTime(2026, 4, 8), Tipo = "Entrada", Detalle = "Producción", Cantidad = 500 });
                GlobalData.MovimientosHuevos.Add(new MovimientoHuevo { Fecha = new DateTime(2026, 4, 8), Tipo = "Venta", Detalle = "Cliente A", Cantidad = -200 });
                GlobalData.MovimientosHuevos.Add(new MovimientoHuevo { Fecha = new DateTime(2026, 4, 8), Tipo = "Pérdida", Detalle = "Rotura", Cantidad = -35 });
            }

            ActualizarUI();
        }

        private void ActualizarUI()
        {
            // Actualizar stock
            lblStockTotal.Text = GlobalData.StockHuevos + " huevos";

            // Cargar movimientos
            dgvMovimientos.Columns.Clear();
            dgvMovimientos.Columns.Add("Fecha", "Fecha");
            dgvMovimientos.Columns.Add("Tipo", "Tipo");
            dgvMovimientos.Columns.Add("Detalle", "Detalle");
            dgvMovimientos.Columns.Add("Cantidad", "Cantidad");

            foreach (var mov in GlobalData.MovimientosHuevos.OrderByDescending(m => m.Fecha))
            {
                string cantidadFormateada = mov.Cantidad >= 0 ? "+" + mov.Cantidad : mov.Cantidad.ToString();
                dgvMovimientos.Rows.Add(mov.Fecha.ToString("dd/MM/yyyy"), mov.Tipo, mov.Detalle, cantidadFormateada);
            }
        }

        private void btnRegistrarMovimiento_Click(object sender, EventArgs e)
        {
            panelNuevoMovimiento.Visible = true;
            panelMovimientos.Location = new Point(34, 500);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panelNuevoMovimiento.Visible = false;
            panelMovimientos.Location = new Point(34, 180);
            LimpiarCampos();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validar
            if (string.IsNullOrWhiteSpace(txtCantidad.Text) || !int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Por favor ingrese una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Registrar pérdida
            GlobalData.MovimientosHuevos.Add(new MovimientoHuevo
            {
                Fecha = dtpFecha.Value,
                Tipo = "Pérdida",
                Detalle = "Registro manual",
                Cantidad = -cantidad
            });
            GlobalData.StockHuevos -= cantidad;

            // Actualizar UI
            ActualizarUI();
            panelNuevoMovimiento.Visible = false;
            panelMovimientos.Location = new Point(34, 180);
            LimpiarCampos();

            MessageBox.Show("Pérdida registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LimpiarCampos()
{
    cmbTipo.SelectedIndex = -1;
    txtCantidad.Text = null;
}

        // Métodos de navegación
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

        private void btnProduccion_Click(object sender, EventArgs e)
        {
            Produccion produ = new Produccion();
            produ.Show();
            this.Hide();
        }
    }
}
