using System;
using System.Linq;
using System.Windows.Forms;

namespace Granja
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            ConfigurarVista();
            CargarDashboard();
        }

        private void ConfigurarVista()
        {
            UiHelper.ConfigurarTituloGeneral(lblTitle);
            UiHelper.ConfigurarNavegacion(panelNav, btnDashboard, btnProduccion, btnAlmacen, btnVentas, btnAlimento, btnInsumos, btnMolino, btnReportes, btnDashboard);

            panelMain.AutoScroll = true;
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
    }
}
