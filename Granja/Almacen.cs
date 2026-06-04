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
            // Ocultar el panel de nuevo movimiento por defecto
            panelNuevoMovimiento.Visible = false;
            PopulateData();
        }

        private void PopulateData()
        {
            dgvMovimientos.Columns.Add("Fecha", "Fecha");
            dgvMovimientos.Columns.Add("Tipo", "Tipo");
            dgvMovimientos.Columns.Add("Detalle", "Detalle");
            dgvMovimientos.Columns.Add("Cantidad", "Cantidad");

            dgvMovimientos.Rows.Add("8/4/2026", "Entrada", "-", "+500");
            dgvMovimientos.Rows.Add("8/4/2026", "Venta", "-", "-200");
            dgvMovimientos.Rows.Add("8/4/2026", "Pérdida", "Rotura", "-35");
            dgvMovimientos.Rows.Add("7/4/2026", "Entrada", "-", "+450");
            dgvMovimientos.Rows.Add("7/4/2026", "Venta", "-", "-300");
            dgvMovimientos.Rows.Add("7/4/2026", "Pérdida", "Mal estado", "-25");
            dgvMovimientos.Rows.Add("6/4/2026", "Pérdida", "Rotura en manipulación", "-40");
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
            // Validar que la cantidad sea un numero
            if (string.IsNullOrWhiteSpace(txtCantidad.Text) || !int.TryParse(txtCantidad.Text, out _))
            {
                MessageBox.Show("Por favor ingrese una cantidad válida de huevos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener valores
            string fecha = dtpFecha.Value.ToString("d/M/yyyy");
            string tipo = cmbTipo.SelectedItem?.ToString() ?? "";
            string detalle = "-";
            int cantidad = int.Parse(txtCantidad.Text);

            // Formatear la cantidad
            string cantidadFormateada = "";
            if (tipo == "Entrada")
                cantidadFormateada = "+" + cantidad;
            else
                cantidadFormateada = "-" + cantidad;

            // Agregar a la lista
            dgvMovimientos.Rows.Insert(0, fecha, tipo, detalle, cantidadFormateada);

            // Ocultar panel y limpiar campos
            panelNuevoMovimiento.Visible = false;
            panelMovimientos.Location = new Point(34, 180);
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            cmbTipo.SelectedIndex = -1;
            txtCantidad.Text = "";
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
