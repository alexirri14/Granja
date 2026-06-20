using System.Data;
// Elimine using innecesarios para mantener el código limpio

namespace Granja
{
    public partial class Produccion : Form
    {
        public Produccion()
        {
            InitializeComponent();
            PopulateData();
            btnGuardar.Click += BtnGuardar_Click;
            btnCancelar.Click += BtnCancelar_Click;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            cmbGalpon.SelectedIndex = -1;
            dtpFecha.Value = DateTime.Now;
            txtCantidad.Clear();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbGalpon.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un galpón", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtCantidad.Text, out int jabas) || jabas <= 0)
            {
                MessageBox.Show("Ingresa un número de jabas válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calcular consumo de alimento (ejemplo: 0.25 kg por java, y cada saco es 50 kg)
            double kgAlimento = jabas * GlobalData.KgAlimentoPorJava;
            double sacosAlimento = kgAlimento / 50; // Asumiendo sacos de 50 kg

            if (GlobalData.StockAlimentoSacos < sacosAlimento)
            {
                MessageBox.Show("No hay suficiente alimento en stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calcular huevos producidos
            int huevos = jabas * GlobalData.HuevosPorJava;

            // Registrar producción
            GlobalData.Producciones.Add(new ProduccionItem
            {
                Galpon = cmbGalpon.SelectedItem.ToString(),
                Fecha = dtpFecha.Value,
                jabas = jabas
            });

            // Actualizar stock de alimento
            GlobalData.StockAlimentoSacos -= sacosAlimento;
            GlobalData.MovimientosAlimento.Add(new MovimientoAlimento
            {
                Fecha = DateTime.Now,
                Tipo = "Consumo (Producción)",
                CantidadSacos = sacosAlimento,
                Observaciones = $"Producción de {jabas} jabas en galpón {cmbGalpon.SelectedItem}"
            });

            // Actualizar stock de huevos (almacén)
            GlobalData.StockHuevos += huevos;
            GlobalData.MovimientosHuevos.Add(new MovimientoHuevo
            {
                Fecha = dtpFecha.Value,
                Tipo = "Entrada",
                Detalle = $"Producción en galpón {cmbGalpon.SelectedItem}",
                Cantidad = huevos
            });

            // Actualizar UI
            CargarListado();
            BtnCancelar_Click(sender, e);
            MessageBox.Show("Producción registrada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PopulateData()
        {
            CargarListado();
            dtpFecha.Value = DateTime.Now;
            
            // Agregar datos de ejemplo
            if (!GlobalData.Producciones.Any())
            {
                GlobalData.Producciones.Add(new ProduccionItem { Galpon = "A", Fecha = new DateTime(2026, 4, 8), jabas = 1 }); // 360 huevos
                GlobalData.Producciones.Add(new ProduccionItem { Galpon = "B", Fecha = new DateTime(2026, 4, 8), jabas = 1 }); // 360 huevos
                GlobalData.Producciones.Add(new ProduccionItem { Galpon = "C", Fecha = new DateTime(2026, 4, 7), jabas = 1 }); // 360 huevos
            }
        }

        private void CargarListado()
        {
            dgvProduccionList.Columns.Clear();
            dgvProduccionList.Columns.Add("Galpon", "Galpón");
            dgvProduccionList.Columns.Add("Fecha", "Fecha");
            dgvProduccionList.Columns.Add("jabas", "jabas");
            dgvProduccionList.Columns.Add("Huevos", "Huevos");

            foreach (var item in GlobalData.Producciones.OrderByDescending(p => p.Fecha))
            {
                dgvProduccionList.Rows.Add(
                    item.Galpon,
                    item.Fecha.ToString("dd/MM/yyyy"),
                    item.jabas,
                    item.Huevos
                );
            }
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
