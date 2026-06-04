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
    public partial class Alimento : Form
    {
        public Alimento()
        {
            InitializeComponent();
            panelNuevoIngreso.Visible = false;
            panelNuevoConsumo.Visible = false;
            PopulateData();
        }

        private void PopulateData()
        {
            dgvMovimientos.Columns.Add("Fecha", "Fecha");
            dgvMovimientos.Columns.Add("Tipo", "Tipo");
            dgvMovimientos.Columns.Add("Cantidad", "Cantidad");

            dgvMovimientos.Rows.Add("8/4/2026", "Ingreso", "+50 sacos");
            dgvMovimientos.Rows.Add("8/4/2026", "Consumo", "-20 sacos");
            dgvMovimientos.Rows.Add("7/4/2026", "Consumo", "-25 sacos");
            dgvMovimientos.Rows.Add("6/4/2026", "Ingreso", "+100 sacos");
        }

        private void btnRegistrarIngreso_Click(object sender, EventArgs e)
        {
            panelNuevoIngreso.Visible = true;
            panelNuevoConsumo.Visible = false;
            panelMovimientos.Location = new Point(34, 480);
        }

        private void btnCancelarIngreso_Click(object sender, EventArgs e)
        {
            panelNuevoIngreso.Visible = false;
            panelMovimientos.Location = new Point(34, 180);
            LimpiarCamposIngreso();
        }

        private void btnRegistrarIngreso2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCantidadIngreso.Text) || !int.TryParse(txtCantidadIngreso.Text, out _))
            {
                MessageBox.Show("Por favor ingrese una cantidad válida de sacos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string fecha = dtpFechaIngreso.Value.ToString("d/M/yyyy");
            string cantidad = "+" + txtCantidadIngreso.Text + " sacos";

            dgvMovimientos.Rows.Insert(0, fecha, "Ingreso", cantidad);

            panelNuevoIngreso.Visible = false;
            panelMovimientos.Location = new Point(34, 180);
            LimpiarCamposIngreso();
        }

        private void btnRegistrarConsumo_Click(object sender, EventArgs e)
        {
            panelNuevoConsumo.Visible = true;
            panelNuevoIngreso.Visible = false;
            panelMovimientos.Location = new Point(34, 480);
        }

        private void btnCancelarConsumo_Click(object sender, EventArgs e)
        {
            panelNuevoConsumo.Visible = false;
            panelMovimientos.Location = new Point(34, 180);
            LimpiarCamposConsumo();
        }

        private void btnRegistrarConsumo2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCantidadConsumo.Text) || !int.TryParse(txtCantidadConsumo.Text, out _))
            {
                MessageBox.Show("Por favor ingrese una cantidad válida de sacos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string fecha = dtpFechaConsumo.Value.ToString("d/M/yyyy");
            string cantidad = "-" + txtCantidadConsumo.Text + " sacos";

            dgvMovimientos.Rows.Insert(0, fecha, "Consumo", cantidad);

            panelNuevoConsumo.Visible = false;
            panelMovimientos.Location = new Point(34, 180);
            LimpiarCamposConsumo();
        }

        private void LimpiarCamposIngreso()
        {
            txtCantidadIngreso.Text = "";
        }

        private void LimpiarCamposConsumo()
        {
            txtCantidadConsumo.Text = "";
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
