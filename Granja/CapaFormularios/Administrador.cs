using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Granja
{
    public partial class Administrador : Form
    {
        private const string VersionDisenoAdministrador = "ADMIN-20260626";

        private enum VistaMaestro
        {
            Galpones,
            Formulas
        }

        private VistaMaestro vistaActual = VistaMaestro.Galpones;
        private string seleccionado = string.Empty;

        public Administrador()
        {
            InitializeComponent();
            ConfigurarVista();
            MostrarGalpones();
        }

        private void ConfigurarVista()
        {
            UiHelper.ConfigurarTituloGeneral(lblTitle);
            UiHelper.ConfigurarNavegacion(panelNav, btnDashboard, btnProduccion, btnAlmacen, btnVentas, btnAlimento, btnInsumos, btnMolino, btnReportes, btnVentas);

            btnVentas.Text = " Administrador";
            panelMain.AutoScroll = true;
            panelRegistro.Height = 390;
            OcultarControlesLegado();
            AplicarVersionDiseno();
            AsegurarControlesMaestrosEnPantalla();
            lblRegistroTitle.Text = "Administrador del sistema";
            lblListadoResumenTitle.Visible = false;
            dgvListadoResumen.Visible = false;

            btnGalpones.BackColor = Color.FromArgb(0, 125, 62);
            btnGalpones.FlatAppearance.BorderSize = 0;
            btnGalpones.FlatStyle = FlatStyle.Flat;
            btnGalpones.ForeColor = Color.White;
            btnGalpones.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnFormulas.BackColor = Color.FromArgb(230, 230, 230);
            btnFormulas.FlatAppearance.BorderSize = 0;
            btnFormulas.FlatStyle = FlatStyle.Flat;
            btnFormulas.ForeColor = Color.FromArgb(44, 62, 80);
            btnFormulas.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
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
            lblEditorMaestroTitle.Text = "Editor";

            txtNombreMaestro.Location = new Point(30, 145);
            txtNombreMaestro.Size = new Size(360, 34);

            cmbEstadoMaestro.DropDownStyle = ComboBoxStyle.DropDownList;
            if (cmbEstadoMaestro.Items.Count == 0)
            {
                cmbEstadoMaestro.Items.AddRange(new object[] { "Activo", "Inhabilitado" });
            }
            cmbEstadoMaestro.Location = new Point(410, 145);
            cmbEstadoMaestro.Size = new Size(250, 36);

            txtDetalleMaestro.Location = new Point(680, 145);
            txtDetalleMaestro.Size = new Size(479, 34);

            btnNuevoMaestro.Text = "Nuevo";
            btnNuevoMaestro.Location = new Point(30, 200);
            btnNuevoMaestro.Size = new Size(130, 42);
            btnNuevoMaestro.Click += (_, _) => LimpiarFormulario();

            btnGuardarMaestro.Text = "Guardar";
            btnGuardarMaestro.Location = new Point(180, 200);
            btnGuardarMaestro.Size = new Size(130, 42);
            btnGuardarMaestro.Click += (_, _) => GuardarActual();

            btnVerDetalleMaestro.Text = "Ver detalle";
            btnVerDetalleMaestro.Location = new Point(330, 200);
            btnVerDetalleMaestro.Size = new Size(130, 42);
            btnVerDetalleMaestro.Click += (_, _) => MostrarDetalleSeleccionado();

            btnAgregarDetalleFormula.Text = "Agregar insumo";
            btnAgregarDetalleFormula.Location = new Point(480, 200);
            btnAgregarDetalleFormula.Size = new Size(160, 42);
            btnAgregarDetalleFormula.Click += (_, _) => AgregarFilaFormula();

            dgvDetalleFormulaMaestro.Location = new Point(30, 255);
            dgvDetalleFormulaMaestro.Size = new Size(1129, 90);
            dgvDetalleFormulaMaestro.RowHeadersVisible = false;
            dgvDetalleFormulaMaestro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalleFormulaMaestro.AllowUserToAddRows = false;
            if (dgvDetalleFormulaMaestro.Columns.Count == 0)
            {
                dgvDetalleFormulaMaestro.Columns.Add(new DataGridViewComboBoxColumn
                {
                    Name = "Insumo",
                    HeaderText = "Insumo",
                    DataSource = GlobalData.ObtenerInsumosActivos().Select(i => i.Nombre).ToList()
                });
                dgvDetalleFormulaMaestro.Columns.Add("Cantidad", "Cantidad");
                dgvDetalleFormulaMaestro.Columns.Add("Unidad", "Unidad");
            }

            dgvMaestros.Location = new Point(30, 52);
            dgvMaestros.Size = new Size(1129, 190);
            dgvMaestros.BackgroundColor = Color.White;
            dgvMaestros.BorderStyle = BorderStyle.None;
            dgvMaestros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMaestros.AllowUserToAddRows = false;
            dgvMaestros.ReadOnly = true;
            dgvMaestros.RowHeadersVisible = false;
            dgvMaestros.SelectionChanged += (_, _) => CargarSeleccionado();
            dgvMaestros.CellDoubleClick += (_, _) => MostrarDetalleSeleccionado();
            lblListadoMaestrosTitle.Text = "Listado";

            cmbEstadoMaestro.SelectedIndex = 0;
            ActualizarPestanas();
        }

        private void AplicarVersionDiseno()
        {
            Tag = VersionDisenoAdministrador;
            panelMain.Tag = VersionDisenoAdministrador;
            panelRegistro.Tag = VersionDisenoAdministrador;
            panelHistorial.Tag = VersionDisenoAdministrador;
        }

        private void OcultarControlesLegado()
        {
            txtCliente.Visible = false;
            lblCliente.Visible = false;
            txtCantidad.Visible = false;
            lblCantidad.Visible = false;
            txtPrecio.Visible = false;
            lblPrecio.Visible = false;
            btnRegistrarVenta.Visible = false;
            panelTotal.Visible = false;
            dgvListadoResumen.Visible = false;
            lblListadoResumenTitle.Visible = false;
        }

        private void AsegurarControlesMaestrosEnPantalla()
        {
            lblEditorMaestroTitle.Visible = true;
            btnGalpones.Visible = true;
            btnFormulas.Visible = true;
            txtNombreMaestro.Visible = true;
            cmbEstadoMaestro.Visible = true;
            txtDetalleMaestro.Visible = true;
            btnNuevoMaestro.Visible = true;
            btnGuardarMaestro.Visible = true;
            btnVerDetalleMaestro.Visible = true;
            btnAgregarDetalleFormula.Visible = true;
            dgvDetalleFormulaMaestro.Visible = true;
            lblListadoMaestrosTitle.Visible = true;
            dgvMaestros.Visible = true;
        }

        private void MostrarGalpones()
        {
            dgvMaestros.Rows.Clear();
            lblEditorMaestroTitle.Text = "Editor de galpones";
            lblListadoMaestrosTitle.Text = "Galpones registrados";
            txtNombreMaestro.PlaceholderText = "Nombre del galpón";
            txtDetalleMaestro.PlaceholderText = "Observaciones";
            btnAgregarDetalleFormula.Visible = false;
            dgvDetalleFormulaMaestro.Visible = false;
            dgvMaestros.Columns.Clear();
            dgvMaestros.Columns.Add("Nombre", "Galpón");
            dgvMaestros.Columns.Add("Estado", "Estado");
            dgvMaestros.Columns.Add("Detalle", "Observaciones");

            foreach (var galpon in GlobalData.Galpones.OrderBy(g => g.Nombre))
            {
                dgvMaestros.Rows.Add(galpon.Nombre, galpon.Estado, galpon.Observaciones);
            }

            lblTotalRegistrosTitulo.Text = "Total de galpones";
            lblTotalRegistrosValor.Text = GlobalData.Galpones.Count.ToString();
            lblTotalRegistrosTitulo.Location = new Point(910, 248);
            lblTotalRegistrosValor.Location = new Point(910, 274);
            if (!panelHistorial.Controls.Contains(lblTotalRegistrosTitulo)) panelHistorial.Controls.Add(lblTotalRegistrosTitulo);
            if (!panelHistorial.Controls.Contains(lblTotalRegistrosValor)) panelHistorial.Controls.Add(lblTotalRegistrosValor);
            LimpiarFormulario();
        }

        private void MostrarFormulas()
        {
            dgvMaestros.Rows.Clear();
            lblEditorMaestroTitle.Text = "Editor de fórmulas";
            lblListadoMaestrosTitle.Text = "Fórmulas registradas";
            txtNombreMaestro.PlaceholderText = "Nombre de la fórmula";
            txtDetalleMaestro.PlaceholderText = "Detalle";
            btnAgregarDetalleFormula.Visible = true;
            dgvDetalleFormulaMaestro.Visible = true;
            dgvMaestros.Columns.Clear();
            dgvMaestros.Columns.Add("Nombre", "Fórmula");
            dgvMaestros.Columns.Add("Estado", "Estado");
            dgvMaestros.Columns.Add("Detalle", "Detalle");
            dgvMaestros.Columns.Add("Items", "N° Insumos");

            foreach (var formula in GlobalData.Formulas.OrderBy(f => f.Nombre))
            {
                dgvMaestros.Rows.Add(formula.Nombre, formula.Estado, formula.Detalle, formula.Insumos.Count);
            }

            lblTotalRegistrosTitulo.Text = "Total de fórmulas";
            lblTotalRegistrosValor.Text = GlobalData.Formulas.Count.ToString();
            lblTotalRegistrosTitulo.Location = new Point(910, 248);
            lblTotalRegistrosValor.Location = new Point(910, 274);
            if (!panelHistorial.Controls.Contains(lblTotalRegistrosTitulo)) panelHistorial.Controls.Add(lblTotalRegistrosTitulo);
            if (!panelHistorial.Controls.Contains(lblTotalRegistrosValor)) panelHistorial.Controls.Add(lblTotalRegistrosValor);
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
                        GlobalData.RegistrarGalpon(txtNombreMaestro.Text.Trim(), txtDetalleMaestro.Text.Trim());
                    }
                    else
                    {
                        GlobalData.ModificarGalpon(seleccionado, txtNombreMaestro.Text.Trim(), txtDetalleMaestro.Text.Trim(), cmbEstadoMaestro.SelectedItem?.ToString() ?? "Activo");
                    }

                    MostrarGalpones();
                }
                else
                {
                    var detalles = dgvDetalleFormulaMaestro.Rows.Cast<DataGridViewRow>()
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
                        GlobalData.RegistrarFormula(txtNombreMaestro.Text.Trim(), txtDetalleMaestro.Text.Trim(), detalles);
                    }
                    else
                    {
                        GlobalData.ModificarFormula(seleccionado, txtNombreMaestro.Text.Trim(), txtDetalleMaestro.Text.Trim(), cmbEstadoMaestro.SelectedItem?.ToString() ?? "Activo", detalles);
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
            if (dgvMaestros.CurrentRow == null)
            {
                seleccionado = string.Empty;
                return;
            }

            seleccionado = dgvMaestros.CurrentRow.Cells[0].Value?.ToString() ?? string.Empty;
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

                txtNombreMaestro.Text = galpon.Nombre;
                txtDetalleMaestro.Text = galpon.Observaciones;
                cmbEstadoMaestro.SelectedItem = galpon.Estado;
            }
            else
            {
                var formula = GlobalData.Formulas.FirstOrDefault(f => f.Nombre == seleccionado);
                if (formula == null)
                {
                    LimpiarFormulario();
                    return;
                }

                txtNombreMaestro.Text = formula.Nombre;
                txtDetalleMaestro.Text = formula.Detalle;
                cmbEstadoMaestro.SelectedItem = formula.Estado;
                dgvDetalleFormulaMaestro.Rows.Clear();
                foreach (var item in formula.Insumos)
                {
                    dgvDetalleFormulaMaestro.Rows.Add(item.Insumo, item.Cantidad.ToString("F2"), item.Unidad);
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
            dgvDetalleFormulaMaestro.Rows.Add(null, "0.00", "KG");
        }

        private void LimpiarFormulario()
        {
            seleccionado = string.Empty;
            txtNombreMaestro.Clear();
            txtDetalleMaestro.Clear();
            cmbEstadoMaestro.SelectedIndex = 0;
            dgvDetalleFormulaMaestro.Rows.Clear();
        }

        private void ActualizarPestanas()
        {
            btnGalpones.BackColor = vistaActual == VistaMaestro.Galpones ? Color.FromArgb(0, 125, 62) : Color.FromArgb(230, 230, 230);
            btnGalpones.ForeColor = vistaActual == VistaMaestro.Galpones ? Color.White : Color.FromArgb(44, 62, 80);
            btnFormulas.BackColor = vistaActual == VistaMaestro.Formulas ? Color.FromArgb(0, 125, 62) : Color.FromArgb(230, 230, 230);
            btnFormulas.ForeColor = vistaActual == VistaMaestro.Formulas ? Color.White : Color.FromArgb(44, 62, 80);
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
