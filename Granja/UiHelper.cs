using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Granja
{
    public static class UiHelper
    {
        public static void ConfigurarTituloGeneral(Label lblTitle)
        {
            lblTitle.Text = "Sistema de Alimento Balanceado - Granja";
        }

        public static void ConfigurarNavegacion(
            Button btnDashboard,
            Button btnProduccion,
            Button btnAlmacen,
            Button btnVentas,
            Button btnAlimento,
            Button btnInsumos,
            Button btnMolino,
            Button btnReportes)
        {
            btnDashboard.Text = " Panel";
            btnProduccion.Text = " Órdenes";
            btnAlmacen.Text = " Distribución";
            btnVentas.Text = " Administrador";
            btnAlimento.Text = " Almacén AB";
            btnInsumos.Text = " Insumos";
            btnMolino.Text = " Molino";
            btnReportes.Text = " Reportes";
        }

        public static Button CrearBotonPestana(string texto, Point location, Size size, bool activo = false)
        {
            return new Button
            {
                Text = texto,
                Location = location,
                Size = size,
                FlatStyle = FlatStyle.Flat,
                BackColor = activo ? Color.FromArgb(0, 125, 62) : Color.FromArgb(230, 230, 230),
                ForeColor = activo ? Color.White : Color.FromArgb(44, 62, 80),
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                FlatAppearance = { BorderSize = 0 }
            };
        }

        public static Label CrearTituloPanel(string texto, Point location)
        {
            return new Label
            {
                AutoSize = true,
                Text = texto,
                Location = location,
                Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                ForeColor = Color.FromArgb(26, 32, 44)
            };
        }

        public static DataGridView CrearGrid(Point location, Size size)
        {
            return new DataGridView
            {
                Location = location,
                Size = size,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                ReadOnly = true,
                RowHeadersVisible = false
            };
        }

        public static void MostrarSoloDiseno()
        {
            MessageBox.Show("Solo se avanzó el diseño visual de esta pantalla. La lógica operativa se implementará después.", "Modo diseño", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void MostrarDetalleDocumento(string numeroDocumento)
        {
            var detalles = GlobalData.ObtenerDetalleDocumento(numeroDocumento);
            if (!detalles.Any())
            {
                MessageBox.Show("El documento no tiene detalle disponible.", "Detalle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var sb = new StringBuilder();
            sb.AppendLine(numeroDocumento);
            sb.AppendLine(GlobalData.ObtenerResumenDocumento(numeroDocumento));
            sb.AppendLine();
            sb.AppendLine("Detalle:");

            foreach (var item in detalles)
            {
                sb.AppendLine($"- {item.Item}: {item.Cantidad:F2} {item.Unidad}");
            }

            MessageBox.Show(sb.ToString(), "Detalle del documento", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

