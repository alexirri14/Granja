namespace Granja
{
    partial class Administrador
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelHeader = new Panel();
            lblTitle = new Label();
            panelNav = new Panel();
            btnReportes = new Button();
            btnMolino = new Button();
            btnInsumos = new Button();
            btnAlimento = new Button();
            btnVentas = new Button();
            btnAlmacen = new Button();
            btnProduccion = new Button();
            btnDashboard = new Button();
            panelMain = new Panel();
            panelHistorial = new Panel();
            lblTotalRegistrosValor = new Label();
            lblTotalRegistrosTitulo = new Label();
            dgvListadoResumen = new DataGridView();
            lblListadoResumenTitle = new Label();
            panelRegistro = new Panel();
            btnRegistrarVenta = new Button();
            panelTotal = new Panel();
            lblTotal = new Label();
            lblTotalLabel = new Label();
            txtPrecio = new TextBox();
            lblPrecio = new Label();
            txtCantidad = new TextBox();
            lblCantidad = new Label();
            txtCliente = new TextBox();
            lblCliente = new Label();
            lblRegistroTitle = new Label();
            lblEditorMaestroTitle = new Label();
            btnGalpones = new Button();
            btnFormulas = new Button();
            txtNombreMaestro = new TextBox();
            cmbEstadoMaestro = new ComboBox();
            txtDetalleMaestro = new TextBox();
            btnNuevoMaestro = new Button();
            btnGuardarMaestro = new Button();
            btnVerDetalleMaestro = new Button();
            btnAgregarDetalleFormula = new Button();
            dgvDetalleFormulaMaestro = new DataGridView();
            lblListadoMaestrosTitle = new Label();
            dgvMaestros = new DataGridView();
            panelHeader.SuspendLayout();
            panelNav.SuspendLayout();
            panelMain.SuspendLayout();
            panelHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListadoResumen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMaestros).BeginInit();
            panelRegistro.SuspendLayout();
            panelTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleFormulaMaestro).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 125, 62);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(3, 4, 3, 4);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1257, 80);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(23, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(547, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Sistema de Alimento Balanceado - Granja";
            // 
            // panelNav
            // 
            panelNav.BackColor = Color.White;
            panelNav.Controls.Add(btnReportes);
            panelNav.Controls.Add(btnMolino);
            panelNav.Controls.Add(btnInsumos);
            panelNav.Controls.Add(btnAlimento);
            panelNav.Controls.Add(btnVentas);
            panelNav.Controls.Add(btnAlmacen);
            panelNav.Controls.Add(btnProduccion);
            panelNav.Controls.Add(btnDashboard);
            panelNav.Dock = DockStyle.Top;
            panelNav.Location = new Point(0, 80);
            panelNav.Margin = new Padding(3, 4, 3, 4);
            panelNav.Name = "panelNav";
            panelNav.Size = new Size(1257, 73);
            panelNav.TabIndex = 1;
            // 
            // btnReportes
            // 
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Segoe UI", 10F);
            btnReportes.Location = new Point(971, 0);
            btnReportes.Margin = new Padding(3, 4, 3, 4);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(137, 67);
            btnReportes.TabIndex = 7;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnMolino
            // 
            btnMolino.FlatAppearance.BorderSize = 0;
            btnMolino.FlatStyle = FlatStyle.Flat;
            btnMolino.Font = new Font("Segoe UI", 10F);
            btnMolino.Location = new Point(834, 0);
            btnMolino.Margin = new Padding(3, 4, 3, 4);
            btnMolino.Name = "btnMolino";
            btnMolino.Size = new Size(137, 67);
            btnMolino.TabIndex = 6;
            btnMolino.Text = "Molino";
            btnMolino.UseVisualStyleBackColor = true;
            btnMolino.Click += btnMolino_Click;
            // 
            // btnInsumos
            // 
            btnInsumos.FlatAppearance.BorderSize = 0;
            btnInsumos.FlatStyle = FlatStyle.Flat;
            btnInsumos.Font = new Font("Segoe UI", 10F);
            btnInsumos.Location = new Point(697, 0);
            btnInsumos.Margin = new Padding(3, 4, 3, 4);
            btnInsumos.Name = "btnInsumos";
            btnInsumos.Size = new Size(137, 67);
            btnInsumos.TabIndex = 5;
            btnInsumos.Text = "Insumos";
            btnInsumos.UseVisualStyleBackColor = true;
            btnInsumos.Click += btnInsumos_Click;
            // 
            // btnAlimento
            // 
            btnAlimento.FlatAppearance.BorderSize = 0;
            btnAlimento.FlatStyle = FlatStyle.Flat;
            btnAlimento.Font = new Font("Segoe UI", 10F);
            btnAlimento.Location = new Point(560, 0);
            btnAlimento.Margin = new Padding(3, 4, 3, 4);
            btnAlimento.Name = "btnAlimento";
            btnAlimento.Size = new Size(137, 67);
            btnAlimento.TabIndex = 4;
            btnAlimento.Text = "Almacén AB";
            btnAlimento.UseVisualStyleBackColor = true;
            btnAlimento.Click += btnAlimento_Click;
            // 
            // btnVentas
            // 
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Segoe UI", 10F);
            btnVentas.ForeColor = Color.FromArgb(0, 125, 62);
            btnVentas.Location = new Point(423, 0);
            btnVentas.Margin = new Padding(3, 4, 3, 4);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(137, 67);
            btnVentas.TabIndex = 3;
            btnVentas.Text = "Administrador";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnAlmacen
            // 
            btnAlmacen.FlatAppearance.BorderSize = 0;
            btnAlmacen.FlatStyle = FlatStyle.Flat;
            btnAlmacen.Font = new Font("Segoe UI", 10F);
            btnAlmacen.Location = new Point(286, 0);
            btnAlmacen.Margin = new Padding(3, 4, 3, 4);
            btnAlmacen.Name = "btnAlmacen";
            btnAlmacen.Size = new Size(137, 67);
            btnAlmacen.TabIndex = 2;
            btnAlmacen.Text = "Distribución";
            btnAlmacen.UseVisualStyleBackColor = true;
            btnAlmacen.Click += btnAlmacen_Click;
            // 
            // btnProduccion
            // 
            btnProduccion.FlatAppearance.BorderSize = 0;
            btnProduccion.FlatStyle = FlatStyle.Flat;
            btnProduccion.Font = new Font("Segoe UI", 10F);
            btnProduccion.Location = new Point(149, 0);
            btnProduccion.Margin = new Padding(3, 4, 3, 4);
            btnProduccion.Name = "btnProduccion";
            btnProduccion.Size = new Size(137, 67);
            btnProduccion.TabIndex = 1;
            btnProduccion.Text = "Órdenes";
            btnProduccion.UseVisualStyleBackColor = true;
            btnProduccion.Click += btnProduccion_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 10F);
            btnDashboard.Location = new Point(0, 0);
            btnDashboard.Margin = new Padding(3, 4, 3, 4);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(149, 67);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panelMain
            // 
            panelMain.AutoScroll = true;
            panelMain.BackColor = Color.FromArgb(248, 249, 250);
            panelMain.Controls.Add(panelHistorial);
            panelMain.Controls.Add(panelRegistro);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 153);
            panelMain.Margin = new Padding(3, 4, 3, 4);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(34, 40, 34, 40);
            panelMain.Size = new Size(1257, 780);
            panelMain.TabIndex = 2;
            // 
            // panelHistorial
            // 
            panelHistorial.BackColor = Color.White;
            panelHistorial.Controls.Add(dgvMaestros);
            panelHistorial.Controls.Add(lblListadoMaestrosTitle);
            panelHistorial.Controls.Add(lblTotalRegistrosValor);
            panelHistorial.Controls.Add(lblTotalRegistrosTitulo);
            panelHistorial.Controls.Add(dgvListadoResumen);
            panelHistorial.Controls.Add(lblListadoResumenTitle);
            panelHistorial.Location = new Point(34, 450);
            panelHistorial.Margin = new Padding(3, 4, 3, 4);
            panelHistorial.Name = "panelHistorial";
            panelHistorial.Padding = new Padding(30);
            panelHistorial.Size = new Size(1189, 330);
            panelHistorial.TabIndex = 1;
            // 
            // lblTotalRegistrosValor
            // 
            lblTotalRegistrosValor.AutoSize = true;
            lblTotalRegistrosValor.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTotalRegistrosValor.ForeColor = Color.FromArgb(0, 125, 62);
            lblTotalRegistrosValor.Location = new Point(910, 274);
            lblTotalRegistrosValor.Name = "lblTotalRegistrosValor";
            lblTotalRegistrosValor.Size = new Size(40, 46);
            lblTotalRegistrosValor.TabIndex = 3;
            lblTotalRegistrosValor.Text = "0";
            // 
            // lblTotalRegistrosTitulo
            // 
            lblTotalRegistrosTitulo.AutoSize = true;
            lblTotalRegistrosTitulo.Font = new Font("Segoe UI", 10F);
            lblTotalRegistrosTitulo.ForeColor = Color.Gray;
            lblTotalRegistrosTitulo.Location = new Point(910, 248);
            lblTotalRegistrosTitulo.Name = "lblTotalRegistrosTitulo";
            lblTotalRegistrosTitulo.Size = new Size(79, 23);
            lblTotalRegistrosTitulo.TabIndex = 2;
            lblTotalRegistrosTitulo.Text = "Registros";
            // 
            // dgvListadoResumen
            // 
            dgvListadoResumen.AllowUserToAddRows = false;
            dgvListadoResumen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListadoResumen.BackgroundColor = Color.White;
            dgvListadoResumen.BorderStyle = BorderStyle.None;
            dgvListadoResumen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListadoResumen.Location = new Point(30, 70);
            dgvListadoResumen.Name = "dgvListadoResumen";
            dgvListadoResumen.RowHeadersVisible = false;
            dgvListadoResumen.RowHeadersWidth = 51;
            dgvListadoResumen.Size = new Size(1129, 220);
            dgvListadoResumen.TabIndex = 1;
            dgvListadoResumen.Visible = false;
            // 
            // lblListadoResumenTitle
            // 
            lblListadoResumenTitle.AutoSize = true;
            lblListadoResumenTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblListadoResumenTitle.ForeColor = Color.FromArgb(26, 32, 44);
            lblListadoResumenTitle.Location = new Point(6, 10);
            lblListadoResumenTitle.Name = "lblListadoResumenTitle";
            lblListadoResumenTitle.Size = new Size(133, 37);
            lblListadoResumenTitle.TabIndex = 0;
            lblListadoResumenTitle.Text = "Resumen";
            lblListadoResumenTitle.Visible = false;
            // 
            // lblListadoMaestrosTitle
            // 
            lblListadoMaestrosTitle.AutoSize = true;
            lblListadoMaestrosTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblListadoMaestrosTitle.ForeColor = Color.FromArgb(26, 32, 44);
            lblListadoMaestrosTitle.Location = new Point(0, 0);
            lblListadoMaestrosTitle.Name = "lblListadoMaestrosTitle";
            lblListadoMaestrosTitle.Size = new Size(103, 37);
            lblListadoMaestrosTitle.TabIndex = 4;
            lblListadoMaestrosTitle.Text = "Listado";
            // 
            // dgvMaestros
            // 
            dgvMaestros.AllowUserToAddRows = false;
            dgvMaestros.AllowUserToDeleteRows = false;
            dgvMaestros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMaestros.BackgroundColor = Color.White;
            dgvMaestros.BorderStyle = BorderStyle.None;
            dgvMaestros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaestros.Location = new Point(30, 52);
            dgvMaestros.Name = "dgvMaestros";
            dgvMaestros.ReadOnly = true;
            dgvMaestros.RowHeadersVisible = false;
            dgvMaestros.RowHeadersWidth = 51;
            dgvMaestros.Size = new Size(1129, 190);
            dgvMaestros.TabIndex = 5;
            // 
            // panelRegistro
            // 
            panelRegistro.BackColor = Color.White;
            panelRegistro.Controls.Add(dgvDetalleFormulaMaestro);
            panelRegistro.Controls.Add(btnAgregarDetalleFormula);
            panelRegistro.Controls.Add(btnVerDetalleMaestro);
            panelRegistro.Controls.Add(btnGuardarMaestro);
            panelRegistro.Controls.Add(btnNuevoMaestro);
            panelRegistro.Controls.Add(txtDetalleMaestro);
            panelRegistro.Controls.Add(cmbEstadoMaestro);
            panelRegistro.Controls.Add(txtNombreMaestro);
            panelRegistro.Controls.Add(lblEditorMaestroTitle);
            panelRegistro.Controls.Add(btnFormulas);
            panelRegistro.Controls.Add(btnGalpones);
            panelRegistro.Controls.Add(btnRegistrarVenta);
            panelRegistro.Controls.Add(panelTotal);
            panelRegistro.Controls.Add(txtPrecio);
            panelRegistro.Controls.Add(lblPrecio);
            panelRegistro.Controls.Add(txtCantidad);
            panelRegistro.Controls.Add(lblCantidad);
            panelRegistro.Controls.Add(txtCliente);
            panelRegistro.Controls.Add(lblCliente);
            panelRegistro.Controls.Add(lblRegistroTitle);
            panelRegistro.Location = new Point(34, 40);
            panelRegistro.Margin = new Padding(3, 4, 3, 4);
            panelRegistro.Name = "panelRegistro";
            panelRegistro.Padding = new Padding(30);
            panelRegistro.Size = new Size(1189, 390);
            panelRegistro.TabIndex = 0;
            // 
            // btnRegistrarVenta
            // 
            btnRegistrarVenta.BackColor = Color.FromArgb(0, 125, 62);
            btnRegistrarVenta.FlatAppearance.BorderSize = 0;
            btnRegistrarVenta.FlatStyle = FlatStyle.Flat;
            btnRegistrarVenta.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRegistrarVenta.ForeColor = Color.White;
            btnRegistrarVenta.Location = new Point(33, 267);
            btnRegistrarVenta.Name = "btnRegistrarVenta";
            btnRegistrarVenta.Size = new Size(1108, 43);
            btnRegistrarVenta.TabIndex = 8;
            btnRegistrarVenta.Text = "Registrar";
            btnRegistrarVenta.UseVisualStyleBackColor = false;
            btnRegistrarVenta.Visible = false;
            // 
            // panelTotal
            // 
            panelTotal.BackColor = Color.FromArgb(240, 255, 240);
            panelTotal.Controls.Add(lblTotal);
            panelTotal.Controls.Add(lblTotalLabel);
            panelTotal.Location = new Point(30, 201);
            panelTotal.Name = "panelTotal";
            panelTotal.Size = new Size(1129, 60);
            panelTotal.TabIndex = 7;
            panelTotal.Visible = false;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(0, 125, 62);
            lblTotal.Location = new Point(1003, 9);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(35, 41);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "0";
            // 
            // lblTotalLabel
            // 
            lblTotalLabel.AutoSize = true;
            lblTotalLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalLabel.ForeColor = Color.FromArgb(44, 62, 80);
            lblTotalLabel.Location = new Point(20, 15);
            lblTotalLabel.Name = "lblTotalLabel";
            lblTotalLabel.Size = new Size(59, 28);
            lblTotalLabel.TabIndex = 0;
            lblTotalLabel.Text = "Total";
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Segoe UI", 12F);
            txtPrecio.Location = new Point(600, 152);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.PlaceholderText = "Precio";
            txtPrecio.Size = new Size(559, 34);
            txtPrecio.TabIndex = 6;
            txtPrecio.Visible = false;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPrecio.ForeColor = Color.FromArgb(44, 62, 80);
            lblPrecio.Location = new Point(600, 126);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(59, 23);
            lblPrecio.TabIndex = 5;
            lblPrecio.Text = "Precio";
            lblPrecio.Visible = false;
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Segoe UI", 12F);
            txtCantidad.Location = new Point(30, 152);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.PlaceholderText = "Cantidad";
            txtCantidad.Size = new Size(559, 34);
            txtCantidad.TabIndex = 4;
            txtCantidad.Visible = false;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCantidad.ForeColor = Color.FromArgb(44, 62, 80);
            lblCantidad.Location = new Point(30, 126);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(83, 23);
            lblCantidad.TabIndex = 3;
            lblCantidad.Text = "Cantidad";
            lblCantidad.Visible = false;
            // 
            // txtCliente
            // 
            txtCliente.Font = new Font("Segoe UI", 12F);
            txtCliente.Location = new Point(27, 89);
            txtCliente.Name = "txtCliente";
            txtCliente.PlaceholderText = "Detalle";
            txtCliente.Size = new Size(1129, 34);
            txtCliente.TabIndex = 2;
            txtCliente.Visible = false;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCliente.ForeColor = Color.FromArgb(44, 62, 80);
            lblCliente.Location = new Point(33, 63);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(67, 23);
            lblCliente.TabIndex = 1;
            lblCliente.Text = "Detalle";
            lblCliente.Visible = false;
            // 
            // lblRegistroTitle
            // 
            lblRegistroTitle.AutoSize = true;
            lblRegistroTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblRegistroTitle.ForeColor = Color.FromArgb(26, 32, 44);
            lblRegistroTitle.Location = new Point(3, 11);
            lblRegistroTitle.Name = "lblRegistroTitle";
            lblRegistroTitle.Size = new Size(315, 41);
            lblRegistroTitle.TabIndex = 0;
            lblRegistroTitle.Text = "Administrador del sistema";
            // 
            // btnGalpones
            // 
            btnGalpones.BackColor = Color.FromArgb(0, 125, 62);
            btnGalpones.FlatAppearance.BorderSize = 0;
            btnGalpones.FlatStyle = FlatStyle.Flat;
            btnGalpones.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGalpones.ForeColor = Color.White;
            btnGalpones.Location = new Point(30, 64);
            btnGalpones.Name = "btnGalpones";
            btnGalpones.Size = new Size(160, 40);
            btnGalpones.TabIndex = 9;
            btnGalpones.Text = "Galpones";
            btnGalpones.UseVisualStyleBackColor = false;
            // 
            // btnFormulas
            // 
            btnFormulas.BackColor = Color.FromArgb(230, 230, 230);
            btnFormulas.FlatAppearance.BorderSize = 0;
            btnFormulas.FlatStyle = FlatStyle.Flat;
            btnFormulas.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnFormulas.ForeColor = Color.FromArgb(44, 62, 80);
            btnFormulas.Location = new Point(206, 64);
            btnFormulas.Name = "btnFormulas";
            btnFormulas.Size = new Size(160, 40);
            btnFormulas.TabIndex = 10;
            btnFormulas.Text = "Fórmulas";
            btnFormulas.UseVisualStyleBackColor = false;
            // 
            // lblEditorMaestroTitle
            // 
            lblEditorMaestroTitle.AutoSize = true;
            lblEditorMaestroTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblEditorMaestroTitle.ForeColor = Color.FromArgb(26, 32, 44);
            lblEditorMaestroTitle.Location = new Point(30, 118);
            lblEditorMaestroTitle.Name = "lblEditorMaestroTitle";
            lblEditorMaestroTitle.Size = new Size(205, 32);
            lblEditorMaestroTitle.TabIndex = 11;
            lblEditorMaestroTitle.Text = "Editor de galpones";
            // 
            // txtNombreMaestro
            // 
            txtNombreMaestro.Font = new Font("Segoe UI", 12F);
            txtNombreMaestro.Location = new Point(30, 155);
            txtNombreMaestro.Name = "txtNombreMaestro";
            txtNombreMaestro.PlaceholderText = "Nombre";
            txtNombreMaestro.Size = new Size(360, 34);
            txtNombreMaestro.TabIndex = 12;
            // 
            // cmbEstadoMaestro
            // 
            cmbEstadoMaestro.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstadoMaestro.Font = new Font("Segoe UI", 12F);
            cmbEstadoMaestro.FormattingEnabled = true;
            cmbEstadoMaestro.Location = new Point(410, 154);
            cmbEstadoMaestro.Name = "cmbEstadoMaestro";
            cmbEstadoMaestro.Size = new Size(250, 36);
            cmbEstadoMaestro.TabIndex = 13;
            // 
            // txtDetalleMaestro
            // 
            txtDetalleMaestro.Font = new Font("Segoe UI", 12F);
            txtDetalleMaestro.Location = new Point(680, 155);
            txtDetalleMaestro.Name = "txtDetalleMaestro";
            txtDetalleMaestro.PlaceholderText = "Detalle";
            txtDetalleMaestro.Size = new Size(479, 34);
            txtDetalleMaestro.TabIndex = 14;
            // 
            // btnNuevoMaestro
            // 
            btnNuevoMaestro.BackColor = Color.FromArgb(108, 117, 125);
            btnNuevoMaestro.FlatAppearance.BorderSize = 0;
            btnNuevoMaestro.FlatStyle = FlatStyle.Flat;
            btnNuevoMaestro.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNuevoMaestro.ForeColor = Color.White;
            btnNuevoMaestro.Location = new Point(30, 210);
            btnNuevoMaestro.Name = "btnNuevoMaestro";
            btnNuevoMaestro.Size = new Size(130, 42);
            btnNuevoMaestro.TabIndex = 15;
            btnNuevoMaestro.Text = "Nuevo";
            btnNuevoMaestro.UseVisualStyleBackColor = false;
            // 
            // btnGuardarMaestro
            // 
            btnGuardarMaestro.BackColor = Color.FromArgb(0, 125, 62);
            btnGuardarMaestro.FlatAppearance.BorderSize = 0;
            btnGuardarMaestro.FlatStyle = FlatStyle.Flat;
            btnGuardarMaestro.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardarMaestro.ForeColor = Color.White;
            btnGuardarMaestro.Location = new Point(180, 210);
            btnGuardarMaestro.Name = "btnGuardarMaestro";
            btnGuardarMaestro.Size = new Size(130, 42);
            btnGuardarMaestro.TabIndex = 16;
            btnGuardarMaestro.Text = "Guardar";
            btnGuardarMaestro.UseVisualStyleBackColor = false;
            // 
            // btnVerDetalleMaestro
            // 
            btnVerDetalleMaestro.BackColor = Color.FromArgb(59, 130, 246);
            btnVerDetalleMaestro.FlatAppearance.BorderSize = 0;
            btnVerDetalleMaestro.FlatStyle = FlatStyle.Flat;
            btnVerDetalleMaestro.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnVerDetalleMaestro.ForeColor = Color.White;
            btnVerDetalleMaestro.Location = new Point(330, 210);
            btnVerDetalleMaestro.Name = "btnVerDetalleMaestro";
            btnVerDetalleMaestro.Size = new Size(130, 42);
            btnVerDetalleMaestro.TabIndex = 17;
            btnVerDetalleMaestro.Text = "Ver detalle";
            btnVerDetalleMaestro.UseVisualStyleBackColor = false;
            // 
            // btnAgregarDetalleFormula
            // 
            btnAgregarDetalleFormula.BackColor = Color.FromArgb(139, 92, 246);
            btnAgregarDetalleFormula.FlatAppearance.BorderSize = 0;
            btnAgregarDetalleFormula.FlatStyle = FlatStyle.Flat;
            btnAgregarDetalleFormula.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAgregarDetalleFormula.ForeColor = Color.White;
            btnAgregarDetalleFormula.Location = new Point(480, 210);
            btnAgregarDetalleFormula.Name = "btnAgregarDetalleFormula";
            btnAgregarDetalleFormula.Size = new Size(160, 42);
            btnAgregarDetalleFormula.TabIndex = 18;
            btnAgregarDetalleFormula.Text = "Agregar insumo";
            btnAgregarDetalleFormula.UseVisualStyleBackColor = false;
            // 
            // dgvDetalleFormulaMaestro
            // 
            dgvDetalleFormulaMaestro.AllowUserToAddRows = false;
            dgvDetalleFormulaMaestro.AllowUserToDeleteRows = true;
            dgvDetalleFormulaMaestro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalleFormulaMaestro.BackgroundColor = Color.White;
            dgvDetalleFormulaMaestro.BorderStyle = BorderStyle.None;
            dgvDetalleFormulaMaestro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleFormulaMaestro.Location = new Point(30, 270);
            dgvDetalleFormulaMaestro.Name = "dgvDetalleFormulaMaestro";
            dgvDetalleFormulaMaestro.RowHeadersVisible = false;
            dgvDetalleFormulaMaestro.RowHeadersWidth = 51;
            dgvDetalleFormulaMaestro.Size = new Size(1129, 90);
            dgvDetalleFormulaMaestro.TabIndex = 19;
            // 
            // Administrador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 933);
            Controls.Add(panelMain);
            Controls.Add(panelNav);
            Controls.Add(panelHeader);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Administrador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administrador";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelNav.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            panelHistorial.ResumeLayout(false);
            panelHistorial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListadoResumen).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMaestros).EndInit();
            panelRegistro.ResumeLayout(false);
            panelRegistro.PerformLayout();
            panelTotal.ResumeLayout(false);
            panelTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleFormulaMaestro).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnProduccion;
        private System.Windows.Forms.Button btnAlmacen;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnAlimento;
        private System.Windows.Forms.Button btnInsumos;
        private System.Windows.Forms.Button btnMolino;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelRegistro;
        private System.Windows.Forms.Label lblRegistroTitle;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Panel panelTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalLabel;
        private System.Windows.Forms.Button btnRegistrarVenta;
        private System.Windows.Forms.Panel panelHistorial;
        private System.Windows.Forms.Label lblListadoResumenTitle;
        private System.Windows.Forms.DataGridView dgvListadoResumen;
        private System.Windows.Forms.Label lblTotalRegistrosValor;
        private System.Windows.Forms.Label lblTotalRegistrosTitulo;
        private System.Windows.Forms.Label lblEditorMaestroTitle;
        private System.Windows.Forms.Button btnGalpones;
        private System.Windows.Forms.Button btnFormulas;
        private System.Windows.Forms.TextBox txtNombreMaestro;
        private System.Windows.Forms.ComboBox cmbEstadoMaestro;
        private System.Windows.Forms.TextBox txtDetalleMaestro;
        private System.Windows.Forms.Button btnNuevoMaestro;
        private System.Windows.Forms.Button btnGuardarMaestro;
        private System.Windows.Forms.Button btnVerDetalleMaestro;
        private System.Windows.Forms.Button btnAgregarDetalleFormula;
        private System.Windows.Forms.DataGridView dgvDetalleFormulaMaestro;
        private System.Windows.Forms.Label lblListadoMaestrosTitle;
        private System.Windows.Forms.DataGridView dgvMaestros;
    }
}


