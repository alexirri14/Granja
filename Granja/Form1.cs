using System;
using System.Linq;
using System.Windows.Forms;

namespace Granja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ConfigurarVista();
            CargarDashboard();
        }

        private void ConfigurarVista()
        {
            UiHelper.ConfigurarTituloGeneral(lblTitle);
            UiHelper.ConfigurarNavegacion(btnDashboard, btnProduccion, btnAlmacen, btnVentas, btnAlimento, btnInsumos, btnMolino, btnReportes);

            lblResumenTitle.Text = "Panel Principal";
            lblAlertas.Text = "ALERTAS";
            lblProductionReciente.Text = "Órdenes de producción";
            lblInsumosTitle.Text = "Insumos con stock mínimo";

            lblHuevosHoy.Text = "Insumos críticos";
            lblStock.Text = "Alimento disponible";
            lblVentasHoy.Text = "Órdenes pendientes";
            lblAlimentoStock.Text = "Solicitudes pendientes";
        }

        private void CargarDashboard()
        {
            lblHuevosValor.Text = GlobalData.ObtenerInsumosCriticos().Count().ToString();
            lblStockValor.Text = GlobalData.StockAlimentos.Sum(s => s.StockDisponible).ToString("F0");
            lblVentasValor.Text = GlobalData.OrdenesProduccion.Count(o => o.Estado != "Completada").ToString();
            lblAlimentoValor.Text = GlobalData.SolicitudesAlimentoGalpones.Count(s => s.Estado == "Pendiente").ToString();
            lblAlerta.Text = GlobalData.ObtenerResumenAlertas();

            dgvProduccion.Columns.Clear();
            dgvProduccion.Columns.Add("Numero", "Orden");
            dgvProduccion.Columns.Add("Fecha", "Fecha");
            dgvProduccion.Columns.Add("Formula", "Fórmula");
            dgvProduccion.Columns.Add("Cantidad", "Objetivo");
            dgvProduccion.Columns.Add("Estado", "Estado");

            foreach (var orden in GlobalData.OrdenesProduccion.OrderByDescending(o => o.Fecha))
            {
                dgvProduccion.Rows.Add(
                    orden.Numero,
                    orden.Fecha.ToString("dd/MM/yyyy"),
                    orden.Formula,
                    orden.CantidadObjetivo.ToString("F2"),
                    orden.Estado);
            }

            dgvInsumos.Columns.Clear();
            dgvInsumos.Columns.Add("Insumo", "Insumo");
            dgvInsumos.Columns.Add("Disponible", "Disponible");
            dgvInsumos.Columns.Add("Minimo", "Stock mínimo");
            dgvInsumos.Columns.Add("Estado", "Estado");

            foreach (var insumo in GlobalData.ObtenerInsumosCriticos())
            {
                dgvInsumos.Rows.Add(
                    insumo.Nombre,
                    $"{insumo.StockDisponible:F2} {insumo.Unidad}",
                    $"{insumo.StockMinimo:F2} {insumo.Unidad}",
                    insumo.Estado);
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
    }
}
