using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Granja
{
    public partial class Ventas : Form
    {
        private enum VistaMaestro
        {
            Galpones,
            Formulas
        }

        private VistaMaestro vistaActual = VistaMaestro.Galpones;
        private readonly TextBox txtNombre = new();
        private readonly TextBox txtDetalle = new();
        private readonly ComboBox cmbEstado = new();
        private readonly DataGridView dgvListado = new();
        private readonly DataGridView dgvDetalleFormula = new();
        private readonly Button btnNuevo = new();
        private readonly Button btnGuardar = new();
        private readonly Button btnDetalle = new();
        private readonly Button btnFilaFormula = new();
        private string seleccionado = string.Empty;
        private Button? btnGalpones;
        private Button? btnFormulas;

        public Ventas()
        {
            InitializeComponent();
            ConfigurarVista();
            MostrarGalpones();
        }

        private void ConfigurarVista()
        {
            UiHelper.ConfigurarTituloGeneral(lblTitle);
            UiHelper.ConfigurarNavegacion(btnDashboard, btnProduccion, btnAlmacen, btnVentas, btnAlimento, btnInsumos, btnMolino, btnReportes);

            btnVentas.Text = " Administrador";
            panelRegistro.Controls.Clear();
            panelHistorial.Controls.Clear();
            panelRegistro.Height = 360;

            btnGalpones = UiHelper.CrearBotonPestana("Galpones", new Point(30, 30), new Size(220, 45), true);
            btnFormulas = UiHelper.CrearBotonPestana("Fórmulas", new Point(270, 30), new Size(220, 45));
            btnGalpones.Click += (_, _) =>
            {
                vistaActual = VistaMaestro.Galpones;
                ActualizarPestanas();
                MostrarGalpones();
            };
            btnFormulas.Click += (_, _) =>
            {
                vistaActual = VistaMaestro.Formulas;
                ActualizarPestanas();
                MostrarFormulas();
            };

            panelRegistro.Controls.Add(btnGalpones);
            panelRegistro.Controls.Add(btnFormulas);

            panelRegistro.Controls.Add(UiHelper.CrearTituloPanel("Editor", new Point(30, 95)));

            txtNombre.Location = new Point(30, 145);
            txtNombre.Size = new Size(360, 34);
            panelRegistro.Controls.Add(txtNombre);

            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.Items.AddRange(new object[] { "Activo", "Inhabilitado" });
            cmbEstado.Location = new Point(410, 145);
            cmbEstado.Size = new Size(250, 36);
            panelRegistro.Controls.Add(cmbEstado);

            txtDetalle.Location = new Point(680, 145);
            txtDetalle.Size = new Size(479, 34);
            panelRegistro.Controls.Add(txtDetalle);

            btnNuevo.Text = "Nuevo";
            btnNuevo.Location = new Point(30, 200);
            btnNuevo.Size = new Size(130, 42);
            btnNuevo.Click += (_, _) => LimpiarFormulario();
            panelRegistro.Controls.Add(btnNuevo);

            btnGuardar.Text = "Guardar";
            btnGuardar.Location = new Point(180, 200);
            btnGuardar.Size = new Size(130, 42);
            btnGuardar.Click += (_, _) => GuardarActual();
            panelRegistro.Controls.Add(btnGuardar);

            btnDetalle.Text = "Ver detalle";
            btnDetalle.Location = new Point(330, 200);
            btnDetalle.Size = new Size(130, 42);
            btnDetalle.Click += (_, _) => MostrarDetalleSeleccionado();
            panelRegistro.Controls.Add(btnDetalle);

            btnFilaFormula.Text = "Agregar insumo";
            btnFilaFormula.Location = new Point(480, 200);
            btnFilaFormula.Size = new Size(160, 42);
            btnFilaFormula.Click += (_, _) => AgregarFilaFormula();
            panelRegistro.Controls.Add(btnFilaFormula);

            dgvDetalleFormula.Location = new Point(30, 255);
            dgvDetalleFormula.Size = new Size(1129, 90);
            dgvDetalleFormula.RowHeadersVisible = false;
            dgvDetalleFormula.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalleFormula.AllowUserToAddRows = false;
            dgvDetalleFormula.Columns.Add(new DataGridViewComboBoxColumn
            {
                Name = "Insumo",
                HeaderText = "Insumo",
                DataSource = GlobalData.ObtenerInsumosActivos().Select(i => i.Nombre).ToList()
            });
            dgvDetalleFormula.Columns.Add("Cantidad", "Cantidad");
            dgvDetalleFormula.Columns.Add("Unidad", "Unidad");
            panelRegistro.Controls.Add(dgvDetalleFormula);

            dgvListado.Location = new Point(0, 40);
            dgvListado.Size = new Size(1129, 320);
            dgvListado.BackgroundColor = Color.White;
            dgvListado.BorderStyle = BorderStyle.None;
            dgvListado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListado.AllowUserToAddRows = false;
            dgvListado.ReadOnly = true;
            dgvListado.RowHeadersVisible = false;
            dgvListado.SelectionChanged += (_, _) => CargarSeleccionado();
            dgvListado.CellDoubleClick += (_, _) => MostrarDetalleSeleccionado();
            panelHistorial.Controls.Add(UiHelper.CrearTituloPanel("Listado", new Point(0, 0)));
            panelHistorial.Controls.Add(dgvListado);

            cmbEstado.SelectedIndex = 0;
            ActualizarPestanas();
        }

        private void MostrarGalpones()
        {
            dgvListado.Rows.Clear();
            txtNombre.PlaceholderText = "Nombre del galpón";
            txtDetalle.PlaceholderText = "Observaciones";
            btnFilaFormula.Visible = false;
            dgvDetalleFormula.Visible = false;
            dgvListado.Columns.Clear();
            dgvListado.Columns.Add("Nombre", "Galpón");
            dgvListado.Columns.Add("Estado", "Estado");
            dgvListado.Columns.Add("Detalle", "Observaciones");

            foreach (var galpon in GlobalData.Galpones.OrderBy(g => g.Nombre))
            {
                dgvListado.Rows.Add(galpon.Nombre, galpon.Estado, galpon.Observaciones);
            }

            lblTotalVentasLabel.Text = "Galpones";
            lblTotalVentas.Text = GlobalData.Galpones.Count.ToString();
            lblTotalVentasLabel.Location = new Point(910, 340);
            lblTotalVentas.Location = new Point(910, 365);
            if (!panelHistorial.Controls.Contains(lblTotalVentasLabel)) panelHistorial.Controls.Add(lblTotalVentasLabel);
            if (!panelHistorial.Controls.Contains(lblTotalVentas)) panelHistorial.Controls.Add(lblTotalVentas);
            LimpiarFormulario();
        }

        private void MostrarFormulas()
        {
            dgvListado.Rows.Clear();
            txtNombre.PlaceholderText = "Nombre de la fórmula";
            txtDetalle.PlaceholderText = "Detalle";
            btnFilaFormula.Visible = true;
            dgvDetalleFormula.Visible = true;
            dgvListado.Columns.Clear();
            dgvListado.Columns.Add("Nombre", "Fórmula");
            dgvListado.Columns.Add("Estado", "Estado");
            dgvListado.Columns.Add("Detalle", "Detalle");
            dgvListado.Columns.Add("Items", "N° Insumos");

            foreach (var formula in GlobalData.Formulas.OrderBy(f => f.Nombre))
            {
                dgvListado.Rows.Add(formula.Nombre, formula.Estado, formula.Detalle, formula.Insumos.Count);
            }

            lblTotalVentasLabel.Text = "Fórmulas";
            lblTotalVentas.Text = GlobalData.Formulas.Count.ToString();
            lblTotalVentasLabel.Location = new Point(910, 340);
            lblTotalVentas.Location = new Point(910, 365);
            if (!panelHistorial.Controls.Contains(lblTotalVentasLabel)) panelHistorial.Controls.Add(lblTotalVentasLabel);
            if (!panelHistorial.Controls.Contains(lblTotalVentas)) panelHistorial.Controls.Add(lblTotalVentas);
            LimpiarFormulario();
        }

        private void GuardarActual()
        {
            try
            {
                if (vistaActual == VistaMaestro.Galpones)
                {
                    if (string.IsNullOrWhiteSpace(seleccionado))
                    {
                        GlobalData.RegistrarGalpon(txtNombre.Text.Trim(), txtDetalle.Text.Trim());
                    }
                    else
                    {
                        GlobalData.ModificarGalpon(seleccionado, txtNombre.Text.Trim(), txtDetalle.Text.Trim(), cmbEstado.SelectedItem?.ToString() ?? "Activo");
                    }

                    MostrarGalpones();
                }
                else
                {
                    var detalles = dgvDetalleFormula.Rows.Cast<DataGridViewRow>()
                        .Where(r => r.Cells[0].Value != null)
                        .Select(r => new FormulaDetalle
                        {
                            Insumo = r.Cells[0].Value?.ToString() ?? string.Empty,
                            Cantidad = double.Parse(r.Cells[1].Value?.ToString() ?? "0"),
                            Unidad = r.Cells[2].Value?.ToString() ?? GlobalData.ObtenerUnidadInsumo(r.Cells[0].Value?.ToString() ?? string.Empty)
                        })
                        .ToList();

                    if (string.IsNullOrWhiteSpace(seleccionado))
                    {
                        GlobalData.RegistrarFormula(txtNombre.Text.Trim(), txtDetalle.Text.Trim(), detalles);
                    }
                    else
                    {
                        GlobalData.ModificarFormula(seleccionado, txtNombre.Text.Trim(), txtDetalle.Text.Trim(), cmbEstado.SelectedItem?.ToString() ?? "Activo", detalles);
                    }

                    MostrarFormulas();
                }

                MessageBox.Show("Registro guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarSeleccionado()
        {
            if (dgvListado.CurrentRow == null)
            {
                seleccionado = string.Empty;
                return;
            }

            seleccionado = dgvListado.CurrentRow.Cells[0].Value?.ToString() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(seleccionado))
            {
                LimpiarFormulario();
                return;
            }

            if (vistaActual == VistaMaestro.Galpones)
            {
                var galpon = GlobalData.Galpones.FirstOrDefault(g => g.Nombre == seleccionado);
                if (galpon == null)
                {
                    LimpiarFormulario();
                    return;
                }

                txtNombre.Text = galpon.Nombre;
                txtDetalle.Text = galpon.Observaciones;
                cmbEstado.SelectedItem = galpon.Estado;
            }
            else
            {
                var formula = GlobalData.Formulas.FirstOrDefault(f => f.Nombre == seleccionado);
                if (formula == null)
                {
                    LimpiarFormulario();
                    return;
                }

                txtNombre.Text = formula.Nombre;
                txtDetalle.Text = formula.Detalle;
                cmbEstado.SelectedItem = formula.Estado;
                dgvDetalleFormula.Rows.Clear();
                foreach (var item in formula.Insumos)
                {
                    dgvDetalleFormula.Rows.Add(item.Insumo, item.Cantidad.ToString("F2"), item.Unidad);
                }
            }
        }

        private void MostrarDetalleSeleccionado()
        {
            if (string.IsNullOrWhiteSpace(seleccionado))
            {
                return;
            }

            if (vistaActual == VistaMaestro.Galpones)
            {
                var galpon = GlobalData.Galpones.FirstOrDefault(g => g.Nombre == seleccionado);
                if (galpon == null)
                {
                    return;
                }

                MessageBox.Show($"{galpon.Nombre}\nEstado: {galpon.Estado}\nObservaciones: {galpon.Observaciones}", "Detalle del galpón", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var formula = GlobalData.Formulas.FirstOrDefault(f => f.Nombre == seleccionado);
                if (formula == null)
                {
                    return;
                }

                string detalle = string.Join(Environment.NewLine, formula.Insumos.Select(i => $"- {i.Insumo}: {i.Cantidad:F2} {i.Unidad}"));
                MessageBox.Show($"{formula.Nombre}\nEstado: {formula.Estado}\n{formula.Detalle}\n\n{detalle}", "Detalle de la fórmula", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AgregarFilaFormula()
        {
            dgvDetalleFormula.Rows.Add(null, "0.00", "KG");
        }

        private void LimpiarFormulario()
        {
            seleccionado = string.Empty;
            txtNombre.Clear();
            txtDetalle.Clear();
            cmbEstado.SelectedIndex = 0;
            dgvDetalleFormula.Rows.Clear();
        }

        private void ActualizarPestanas()
        {
            if (btnGalpones == null || btnFormulas == null)
            {
                return;
            }

            btnGalpones.BackColor = vistaActual == VistaMaestro.Galpones ? Color.FromArgb(0, 125, 62) : Color.FromArgb(230, 230, 230);
            btnGalpones.ForeColor = vistaActual == VistaMaestro.Galpones ? Color.White : Color.FromArgb(44, 62, 80);
            btnFormulas.BackColor = vistaActual == VistaMaestro.Formulas ? Color.FromArgb(0, 125, 62) : Color.FromArgb(230, 230, 230);
            btnFormulas.ForeColor = vistaActual == VistaMaestro.Formulas ? Color.White : Color.FromArgb(44, 62, 80);
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

