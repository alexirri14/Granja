using System.Data;
// Elimine using innecesarios para mantener el código limpio

namespace Granja
{
    public partial class Insumos : Form
    {
        public Insumos()
        {
            InitializeComponent();
            CargarDatosIniciales();
            ActualizarResumen();
            CargarInventario();
            CargarHistorial();
            CargarRecetas();
        }

        private void CargarDatosIniciales()
        {
            // Cargar insumos en el ComboBox
            cmbInsumoMovimiento.DataSource = GlobalData.Insumos;
            cmbInsumoMovimiento.DisplayMember = "Nombre";
            cmbInsumoMovimiento.ValueMember = "Nombre";
            cmbTipoMovimiento.SelectedIndex = 0;
        }

        private void ActualizarResumen()
        {
            // Total de insumos
            lblTotalValor.Text = GlobalData.Insumos.Count.ToString();

            // Stock crítico
            int stockCritico = GlobalData.Insumos.Count(i => i.StockActual <= i.StockMinimo);
            lblCriticoValor.Text = stockCritico.ToString();

            // Entradas
            double entradas = GlobalData.MovimientosInsumos
                .Where(m => m.Tipo == "Entrada")
                .Sum(m => m.Cantidad);
            lblEntradasValor.Text = entradas.ToString("F2");

            // Consumos
            double consumos = GlobalData.MovimientosInsumos
                .Where(m => m.Tipo == "Consumo")
                .Sum(m => m.Cantidad);
            lblConsumosValor.Text = consumos.ToString("F2");
        }

        private void CargarInventario()
        {
            dgvInventario.Columns.Clear();
            dgvInventario.Columns.Add("Insumo", "Insumo");
            dgvInventario.Columns.Add("Unidad", "Unidad");
            dgvInventario.Columns.Add("KgPorSaco", "Kg/Saco");
            dgvInventario.Columns.Add("StockActual", "Stock Actual");
            dgvInventario.Columns.Add("StockMinimo", "Stock Mínimo");
            dgvInventario.Columns.Add("Estado", "Estado");

            foreach (var insumo in GlobalData.Insumos)
            {
                string estado = insumo.StockActual <= insumo.StockMinimo ? "Crítico" : "Normal";
                dgvInventario.Rows.Add(
                    insumo.Nombre,
                    insumo.Unidad,
                    insumo.KgPorSaco.ToString("F2"),
                    insumo.StockActual.ToString("F2"),
                    insumo.StockMinimo.ToString("F2"),
                    estado
                );

                // Colorear estado
                if (estado == "Crítico")
                {
                    dgvInventario.Rows[dgvInventario.Rows.Count - 1].Cells[5].Style.ForeColor = Color.Red;
                }
                else
                {
                    dgvInventario.Rows[dgvInventario.Rows.Count - 1].Cells[5].Style.ForeColor = Color.Green;
                }
            }
        }

        private void CargarHistorial()
        {
            dgvHistorial.Columns.Clear();
            dgvHistorial.Columns.Add("Fecha", "Fecha");
            dgvHistorial.Columns.Add("Insumo", "Insumo");
            dgvHistorial.Columns.Add("Tipo", "Tipo");
            dgvHistorial.Columns.Add("Cantidad", "Cantidad");
            dgvHistorial.Columns.Add("Galpon", "Galpón");
            dgvHistorial.Columns.Add("Observaciones", "Observaciones");

            foreach (var movimiento in GlobalData.MovimientosInsumos.OrderByDescending(m => m.Fecha))
            {
                dgvHistorial.Rows.Add(
                    movimiento.Fecha.ToString("dd/MM/yyyy HH:mm"),
                    movimiento.Insumo,
                    movimiento.Tipo,
                    movimiento.Cantidad.ToString("F2"),
                    movimiento.Galpon,
                    movimiento.Observaciones
                );

                // Colorear tipo
                if (movimiento.Tipo == "Consumo")
                {
                    dgvHistorial.Rows[dgvHistorial.Rows.Count - 1].Cells[2].Style.ForeColor = Color.Red;
                }
                else if (movimiento.Tipo == "Entrada")
                {
                    dgvHistorial.Rows[dgvHistorial.Rows.Count - 1].Cells[2].Style.ForeColor = Color.Green;
                }
            }
        }

        private void CargarRecetas()
        {
            // Cargar receta Galpón 4
            var receta4 = GlobalData.Recetas.First(r => r.NombreGalpon == "Galpón 4");
            dgvRecetaGalpon4.Columns.Clear();
            dgvRecetaGalpon4.Columns.Add("Insumo", "Insumo");
            dgvRecetaGalpon4.Columns.Add("Cantidad", "Cantidad (%)");
            foreach (var item in receta4.Insumos)
            {
                dgvRecetaGalpon4.Rows.Add(item.Insumo, item.Cantidad.ToString("F2"));
            }

            // Cargar receta Galpón 6-8-7
            var receta687 = GlobalData.Recetas.First(r => r.NombreGalpon == "Galpón 6-8-7");
            dgvRecetaGalpon687.Columns.Clear();
            dgvRecetaGalpon687.Columns.Add("Insumo", "Insumo");
            dgvRecetaGalpon687.Columns.Add("Cantidad", "Cantidad (%)");
            foreach (var item in receta687.Insumos)
            {
                dgvRecetaGalpon687.Rows.Add(item.Insumo, item.Cantidad.ToString("F2"));
            }

            // Cargar receta Galpón 3-5-8
            var receta358 = GlobalData.Recetas.First(r => r.NombreGalpon == "Galpón 3-5-8");
            dgvRecetaGalpon358.Columns.Clear();
            dgvRecetaGalpon358.Columns.Add("Insumo", "Insumo");
            dgvRecetaGalpon358.Columns.Add("Cantidad", "Cantidad (%)");
            foreach (var item in receta358.Insumos)
            {
                dgvRecetaGalpon358.Rows.Add(item.Insumo, item.Cantidad.ToString("F2"));
            }
        }

        private void btnRegistrarMovimiento_Click(object sender, EventArgs e)
        {
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
            txtCantidadMovimiento.Clear();
            txtObservaciones.Clear();
        }

        private void btnRegistrarMovimientoConfirmar_Click(object sender, EventArgs e)
        {
            if (cmbInsumoMovimiento.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un insumo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtCantidadMovimiento.Text, out double cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingresa una cantidad válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nombreInsumo = cmbInsumoMovimiento.SelectedValue.ToString();
            string tipo = cmbTipoMovimiento.SelectedItem.ToString();
            var insumo = GlobalData.Insumos.First(i => i.Nombre == nombreInsumo);

            if (tipo == "Consumo" && insumo.StockActual < cantidad)
            {
                MessageBox.Show("No hay suficiente stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Actualizar stock
            if (tipo == "Entrada")
            {
                insumo.StockActual += cantidad;
            }
            else if (tipo == "Consumo")
            {
                insumo.StockActual -= cantidad;
            }

            // Registrar movimiento
            GlobalData.MovimientosInsumos.Add(new MovimientoInsumo
            {
                Fecha = DateTime.Now,
                Insumo = nombreInsumo,
                Tipo = tipo,
                Cantidad = cantidad,
                Galpon = "",
                Observaciones = txtObservaciones.Text
            });

            // Actualizar UI
            ActualizarResumen();
            CargarInventario();
            CargarHistorial();

            // Limpiar formulario
            panelNuevoMovimiento.Visible = false;
            panelInventario.Visible = true;
            panelHistorial.Visible = true;
            txtCantidadMovimiento.Clear();
            txtObservaciones.Clear();

            MessageBox.Show("Movimiento registrado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnVerRecetas_Click(object sender, EventArgs e)
        {
            panelRecetas.Visible = true;
            panelInventario.Visible = false;
            panelHistorial.Visible = false;
            panelNuevoMovimiento.Visible = false;
        }

        private void btnCerrarRecetas_Click(object sender, EventArgs e)
        {
            panelRecetas.Visible = false;
            panelInventario.Visible = true;
            panelHistorial.Visible = true;
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
            Ventas ventas = new Ventas();
            ventas.Show();
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
