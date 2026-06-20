// Elimine using innecesarios para mantener el código limpio

namespace Granja
{
    public partial class Molino : Form
    {
        private List<InsumoItem> insumos = new List<InsumoItem>();

        public Molino()
        {
            InitializeComponent();
            AgregarInsumoInicial("Maíz", 50);
            AgregarInsumoInicial("Aditivo", 10);
            PopulateHistorial();
            linkAgregarInsumo.LinkClicked += LinkAgregarInsumo_LinkClicked;
            btnRegistrarProduccion.Click += BtnRegistrarProduccion_Click;
        }

        private void LinkAgregarInsumo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var panelInsumo = CrearPanelInsumo();
            panelInsumos.Controls.Add(panelInsumo);
            insumos.Add(new InsumoItem { Panel = panelInsumo });
            ReordenarInsumos();
        }

        private void BtnRegistrarProduccion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreLote.Text))
            {
                MessageBox.Show("Por favor ingrese el nombre del lote.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCantidadSacos.Text) || !int.TryParse(txtCantidadSacos.Text, out _))
            {
                MessageBox.Show("Por favor ingrese una cantidad válida de sacos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener insumos
            var listaInsumos = new List<string>();
            foreach (Control control in panelInsumos.Controls)
            {
                if (control is Panel panel)
                {
                    var txtNombre = panel.Controls.OfType<TextBox>().FirstOrDefault(t => t.Location.X == 0);
                    var txtCantidad = panel.Controls.OfType<TextBox>().FirstOrDefault(t => t.Location.X == 820);

                    if (!string.IsNullOrWhiteSpace(txtNombre?.Text) && !string.IsNullOrWhiteSpace(txtCantidad?.Text))
                    {
                        listaInsumos.Add($"{txtNombre.Text}: {txtCantidad.Text} kg");
                    }
                }
            }

            string insumosTexto = string.Join("\n", listaInsumos);

            // Agregar al historial
            dgvHistorial.Rows.Insert(0, DateTime.Now.ToString("d/M/yyyy"), txtNombreLote.Text, insumosTexto, txtCantidadSacos.Text);

            // Limpiar campos
            txtNombreLote.Text = "";
            txtCantidadSacos.Text = "";
        }

        private void AgregarInsumoInicial(string nombre, double cantidad)
        {
            var panelInsumo = CrearPanelInsumo(nombre, cantidad);
            panelInsumos.Controls.Add(panelInsumo);
            insumos.Add(new InsumoItem { Nombre = nombre, Cantidad = cantidad, Panel = panelInsumo });
        }

        private Panel CrearPanelInsumo(string nombre = "", double cantidad = 0)
        {
            var panel = new Panel();
            panel.Size = new Size(1100, 40);
            panel.Margin = new Padding(0, 0, 0, 10);

            var txtNombre = new TextBox();
            txtNombre.Font = new Font("Segoe UI", 12F);
            txtNombre.Location = new Point(0, 0);
            txtNombre.Size = new Size(800, 34);
            txtNombre.PlaceholderText = "Nombre del insumo";
            txtNombre.Text = nombre;

            var txtCantidad = new TextBox();
            txtCantidad.Font = new Font("Segoe UI", 12F);
            txtCantidad.Location = new Point(820, 0);
            txtCantidad.Size = new Size(200, 34);
            txtCantidad.PlaceholderText = "kg";
            txtCantidad.Text = cantidad > 0 ? cantidad.ToString() : "";

            var btnEliminar = new Button();
            btnEliminar.Text = "✕";
            btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.Red;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.Location = new Point(1030, 0);
            btnEliminar.Size = new Size(30, 34);
            btnEliminar.Click += (s, e) => EliminarInsumo(panel);

            panel.Controls.Add(txtNombre);
            panel.Controls.Add(txtCantidad);
            panel.Controls.Add(btnEliminar);

            return panel;
        }

        private void EliminarInsumo(Panel panel)
        {
            var insumo = insumos.FirstOrDefault(i => i.Panel == panel);
            if (insumo != null)
            {
                insumos.Remove(insumo);
                panelInsumos.Controls.Remove(panel);
                ReordenarInsumos();
            }
        }

        private void ReordenarInsumos()
        {
            int y = 0;
            foreach (Control control in panelInsumos.Controls)
            {
                control.Location = new Point(0, y);
                y += control.Height + 10;
            }
        }

        private void PopulateHistorial()
        {
            dgvHistorial.Columns.Add("Fecha", "Fecha");
            dgvHistorial.Columns.Add("Lote", "Lote");
            dgvHistorial.Columns.Add("Insumos", "Insumos");
            dgvHistorial.Columns.Add("Sacos", "Sacos");

            dgvHistorial.Rows.Add("8/4/2026", "Lote 1", "Maíz: 50 kg\nAditivo: 10 kg", "40");
            dgvHistorial.Rows.Add("6/4/2026", "Lote 2", "Maíz: 45 kg\nAditivo: 8 kg", "35");
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Form1 dashboard = new Form1();
            dashboard.Show();
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

    public class InsumoItem
    {
        public string Nombre { get; set; }
        public double Cantidad { get; set; }
        public Panel Panel { get; set; }
    }
}
