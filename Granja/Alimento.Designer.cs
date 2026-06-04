namespace Granja
{
    partial class Alimento
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
            lblStockTotal = new Label();
            lblStockLabel = new Label();
            btnRegistrarConsumo = new Button();
            btnRegistrarIngreso = new Button();
            lblAlimentoTitle = new Label();
            panelNuevoIngreso = new Panel();
            btnCancelarIngreso = new Button();
            btnRegistrarIngreso2 = new Button();
            txtCantidadIngreso = new TextBox();
            lblCantidadIngreso = new Label();
            dtpFechaIngreso = new DateTimePicker();
            lblFechaIngreso = new Label();
            lblNuevoIngresoTitle = new Label();
            panelNuevoConsumo = new Panel();
            btnCancelarConsumo = new Button();
            btnRegistrarConsumo2 = new Button();
            txtCantidadConsumo = new TextBox();
            lblCantidadConsumo = new Label();
            dtpFechaConsumo = new DateTimePicker();
            lblFechaConsumo = new Label();
            lblNuevoConsumoTitle = new Label();
            panelMovimientos = new Panel();
            dgvMovimientos = new DataGridView();
            lblMovimientosTitle = new Label();
            panelHeader.SuspendLayout();
            panelNav.SuspendLayout();
            panelMain.SuspendLayout();
            panelNuevoIngreso.SuspendLayout();
            panelNuevoConsumo.SuspendLayout();
            panelMovimientos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMovimientos).BeginInit();
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
            lblTitle.Size = new Size(575, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Sistema Avícola - El Rancho del Buen Pastor";
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
            btnReportes.Text = " Reportes";
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
            btnMolino.Text = " Molino";
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
            btnInsumos.Text = " Insumos";
            btnInsumos.UseVisualStyleBackColor = true;
            btnInsumos.Click += btnInsumos_Click;
            // 
            // btnAlimento
            // 
            btnAlimento.FlatAppearance.BorderSize = 0;
            btnAlimento.FlatStyle = FlatStyle.Flat;
            btnAlimento.Font = new Font("Segoe UI", 10F);
            btnAlimento.ForeColor = Color.FromArgb(0, 125, 62);
            btnAlimento.Location = new Point(560, 0);
            btnAlimento.Margin = new Padding(3, 4, 3, 4);
            btnAlimento.Name = "btnAlimento";
            btnAlimento.Size = new Size(137, 67);
            btnAlimento.TabIndex = 4;
            btnAlimento.Text = " Alimento";
            btnAlimento.UseVisualStyleBackColor = true;
            btnAlimento.Click += btnAlimento_Click;
            // 
            // btnVentas
            // 
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Segoe UI", 10F);
            btnVentas.Location = new Point(423, 0);
            btnVentas.Margin = new Padding(3, 4, 3, 4);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(137, 67);
            btnVentas.TabIndex = 3;
            btnVentas.Text = " Ventas";
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
            btnAlmacen.Text = " Almacén";
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
            btnProduccion.Text = " Producción";
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
            btnDashboard.Text = " Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panelMain
            // 
            panelMain.AutoScroll = true;
            panelMain.BackColor = Color.FromArgb(248, 249, 250);
            panelMain.Controls.Add(lblStockTotal);
            panelMain.Controls.Add(lblStockLabel);
            panelMain.Controls.Add(btnRegistrarConsumo);
            panelMain.Controls.Add(btnRegistrarIngreso);
            panelMain.Controls.Add(lblAlimentoTitle);
            panelMain.Controls.Add(panelNuevoIngreso);
            panelMain.Controls.Add(panelNuevoConsumo);
            panelMain.Controls.Add(panelMovimientos);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 153);
            panelMain.Margin = new Padding(3, 4, 3, 4);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(34, 40, 34, 40);
            panelMain.Size = new Size(1257, 780);
            panelMain.TabIndex = 2;
            // 
            // lblStockTotal
            // 
            lblStockTotal.AutoSize = true;
            lblStockTotal.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStockTotal.ForeColor = Color.FromArgb(0, 125, 62);
            lblStockTotal.Location = new Point(1059, 27);
            lblStockTotal.Name = "lblStockTotal";
            lblStockTotal.Size = new Size(174, 46);
            lblStockTotal.TabIndex = 6;
            lblStockTotal.Text = "300 sacos";
            // 
            // lblStockLabel
            // 
            lblStockLabel.AutoSize = true;
            lblStockLabel.Font = new Font("Segoe UI", 10F);
            lblStockLabel.ForeColor = Color.Gray;
            lblStockLabel.Location = new Point(1132, 4);
            lblStockLabel.Name = "lblStockLabel";
            lblStockLabel.Size = new Size(101, 23);
            lblStockLabel.TabIndex = 5;
            lblStockLabel.Text = "Stock actual";
            // 
            // btnRegistrarConsumo
            // 
            btnRegistrarConsumo.BackColor = Color.FromArgb(220, 38, 38);
            btnRegistrarConsumo.FlatAppearance.BorderSize = 0;
            btnRegistrarConsumo.FlatStyle = FlatStyle.Flat;
            btnRegistrarConsumo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRegistrarConsumo.ForeColor = Color.White;
            btnRegistrarConsumo.Location = new Point(280, 100);
            btnRegistrarConsumo.Name = "btnRegistrarConsumo";
            btnRegistrarConsumo.Size = new Size(230, 55);
            btnRegistrarConsumo.TabIndex = 4;
            btnRegistrarConsumo.Text = "— Registrar consumo";
            btnRegistrarConsumo.UseVisualStyleBackColor = false;
            btnRegistrarConsumo.Click += btnRegistrarConsumo_Click;
            // 
            // btnRegistrarIngreso
            // 
            btnRegistrarIngreso.BackColor = Color.FromArgb(0, 125, 62);
            btnRegistrarIngreso.FlatAppearance.BorderSize = 0;
            btnRegistrarIngreso.FlatStyle = FlatStyle.Flat;
            btnRegistrarIngreso.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRegistrarIngreso.ForeColor = Color.White;
            btnRegistrarIngreso.Location = new Point(34, 100);
            btnRegistrarIngreso.Name = "btnRegistrarIngreso";
            btnRegistrarIngreso.Size = new Size(230, 55);
            btnRegistrarIngreso.TabIndex = 3;
            btnRegistrarIngreso.Text = "+ Registrar ingreso";
            btnRegistrarIngreso.UseVisualStyleBackColor = false;
            btnRegistrarIngreso.Click += btnRegistrarIngreso_Click;
            // 
            // lblAlimentoTitle
            // 
            lblAlimentoTitle.AutoSize = true;
            lblAlimentoTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblAlimentoTitle.ForeColor = Color.FromArgb(26, 32, 44);
            lblAlimentoTitle.Location = new Point(34, 20);
            lblAlimentoTitle.Name = "lblAlimentoTitle";
            lblAlimentoTitle.Size = new Size(320, 41);
            lblAlimentoTitle.TabIndex = 2;
            lblAlimentoTitle.Text = "Almacén de Alimento";
            // 
            // panelNuevoIngreso
            // 
            panelNuevoIngreso.BackColor = Color.White;
            panelNuevoIngreso.Controls.Add(btnCancelarIngreso);
            panelNuevoIngreso.Controls.Add(btnRegistrarIngreso2);
            panelNuevoIngreso.Controls.Add(txtCantidadIngreso);
            panelNuevoIngreso.Controls.Add(lblCantidadIngreso);
            panelNuevoIngreso.Controls.Add(dtpFechaIngreso);
            panelNuevoIngreso.Controls.Add(lblFechaIngreso);
            panelNuevoIngreso.Controls.Add(lblNuevoIngresoTitle);
            panelNuevoIngreso.Location = new Point(34, 180);
            panelNuevoIngreso.Margin = new Padding(3, 4, 3, 4);
            panelNuevoIngreso.Name = "panelNuevoIngreso";
            panelNuevoIngreso.Padding = new Padding(30);
            panelNuevoIngreso.Size = new Size(1189, 280);
            panelNuevoIngreso.TabIndex = 0;
            // 
            // btnCancelarIngreso
            // 
            btnCancelarIngreso.BackColor = Color.FromArgb(108, 117, 125);
            btnCancelarIngreso.FlatAppearance.BorderSize = 0;
            btnCancelarIngreso.FlatStyle = FlatStyle.Flat;
            btnCancelarIngreso.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCancelarIngreso.ForeColor = Color.White;
            btnCancelarIngreso.Location = new Point(170, 200);
            btnCancelarIngreso.Name = "btnCancelarIngreso";
            btnCancelarIngreso.Size = new Size(130, 45);
            btnCancelarIngreso.TabIndex = 6;
            btnCancelarIngreso.Text = "Cancelar";
            btnCancelarIngreso.UseVisualStyleBackColor = false;
            btnCancelarIngreso.Click += btnCancelarIngreso_Click;
            // 
            // btnRegistrarIngreso2
            // 
            btnRegistrarIngreso2.BackColor = Color.FromArgb(0, 125, 62);
            btnRegistrarIngreso2.FlatAppearance.BorderSize = 0;
            btnRegistrarIngreso2.FlatStyle = FlatStyle.Flat;
            btnRegistrarIngreso2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRegistrarIngreso2.ForeColor = Color.White;
            btnRegistrarIngreso2.Location = new Point(30, 200);
            btnRegistrarIngreso2.Name = "btnRegistrarIngreso2";
            btnRegistrarIngreso2.Size = new Size(130, 45);
            btnRegistrarIngreso2.TabIndex = 5;
            btnRegistrarIngreso2.Text = "Registrar";
            btnRegistrarIngreso2.UseVisualStyleBackColor = false;
            btnRegistrarIngreso2.Click += btnRegistrarIngreso2_Click;
            // 
            // txtCantidadIngreso
            // 
            txtCantidadIngreso.Font = new Font("Segoe UI", 12F);
            txtCantidadIngreso.Location = new Point(30, 145);
            txtCantidadIngreso.Name = "txtCantidadIngreso";
            txtCantidadIngreso.PlaceholderText = "Número de sacos";
            txtCantidadIngreso.Size = new Size(1129, 34);
            txtCantidadIngreso.TabIndex = 4;
            // 
            // lblCantidadIngreso
            // 
            lblCantidadIngreso.AutoSize = true;
            lblCantidadIngreso.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCantidadIngreso.ForeColor = Color.FromArgb(44, 62, 80);
            lblCantidadIngreso.Location = new Point(30, 115);
            lblCantidadIngreso.Name = "lblCantidadIngreso";
            lblCantidadIngreso.Size = new Size(141, 23);
            lblCantidadIngreso.TabIndex = 3;
            lblCantidadIngreso.Text = "Cantidad (sacos)";
            // 
            // dtpFechaIngreso
            // 
            dtpFechaIngreso.Font = new Font("Segoe UI", 12F);
            dtpFechaIngreso.Format = DateTimePickerFormat.Short;
            dtpFechaIngreso.Location = new Point(30, 75);
            dtpFechaIngreso.Name = "dtpFechaIngreso";
            dtpFechaIngreso.Size = new Size(1129, 34);
            dtpFechaIngreso.TabIndex = 2;
            // 
            // lblFechaIngreso
            // 
            lblFechaIngreso.AutoSize = true;
            lblFechaIngreso.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFechaIngreso.ForeColor = Color.FromArgb(44, 62, 80);
            lblFechaIngreso.Location = new Point(30, 45);
            lblFechaIngreso.Name = "lblFechaIngreso";
            lblFechaIngreso.Size = new Size(55, 23);
            lblFechaIngreso.TabIndex = 1;
            lblFechaIngreso.Text = "Fecha";
            // 
            // lblNuevoIngresoTitle
            // 
            lblNuevoIngresoTitle.AutoSize = true;
            lblNuevoIngresoTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblNuevoIngresoTitle.ForeColor = Color.FromArgb(26, 32, 44);
            lblNuevoIngresoTitle.Location = new Point(0, 0);
            lblNuevoIngresoTitle.Name = "lblNuevoIngresoTitle";
            lblNuevoIngresoTitle.Size = new Size(183, 32);
            lblNuevoIngresoTitle.TabIndex = 0;
            lblNuevoIngresoTitle.Text = "Nuevo Ingreso";
            // 
            // panelNuevoConsumo
            // 
            panelNuevoConsumo.BackColor = Color.White;
            panelNuevoConsumo.Controls.Add(btnCancelarConsumo);
            panelNuevoConsumo.Controls.Add(btnRegistrarConsumo2);
            panelNuevoConsumo.Controls.Add(txtCantidadConsumo);
            panelNuevoConsumo.Controls.Add(lblCantidadConsumo);
            panelNuevoConsumo.Controls.Add(dtpFechaConsumo);
            panelNuevoConsumo.Controls.Add(lblFechaConsumo);
            panelNuevoConsumo.Controls.Add(lblNuevoConsumoTitle);
            panelNuevoConsumo.Location = new Point(34, 180);
            panelNuevoConsumo.Margin = new Padding(3, 4, 3, 4);
            panelNuevoConsumo.Name = "panelNuevoConsumo";
            panelNuevoConsumo.Padding = new Padding(30);
            panelNuevoConsumo.Size = new Size(1189, 280);
            panelNuevoConsumo.TabIndex = 1;
            // 
            // btnCancelarConsumo
            // 
            btnCancelarConsumo.BackColor = Color.FromArgb(108, 117, 125);
            btnCancelarConsumo.FlatAppearance.BorderSize = 0;
            btnCancelarConsumo.FlatStyle = FlatStyle.Flat;
            btnCancelarConsumo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCancelarConsumo.ForeColor = Color.White;
            btnCancelarConsumo.Location = new Point(170, 200);
            btnCancelarConsumo.Name = "btnCancelarConsumo";
            btnCancelarConsumo.Size = new Size(130, 45);
            btnCancelarConsumo.TabIndex = 6;
            btnCancelarConsumo.Text = "Cancelar";
            btnCancelarConsumo.UseVisualStyleBackColor = false;
            btnCancelarConsumo.Click += btnCancelarConsumo_Click;
            // 
            // btnRegistrarConsumo2
            // 
            btnRegistrarConsumo2.BackColor = Color.FromArgb(0, 125, 62);
            btnRegistrarConsumo2.FlatAppearance.BorderSize = 0;
            btnRegistrarConsumo2.FlatStyle = FlatStyle.Flat;
            btnRegistrarConsumo2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRegistrarConsumo2.ForeColor = Color.White;
            btnRegistrarConsumo2.Location = new Point(30, 200);
            btnRegistrarConsumo2.Name = "btnRegistrarConsumo2";
            btnRegistrarConsumo2.Size = new Size(130, 45);
            btnRegistrarConsumo2.TabIndex = 5;
            btnRegistrarConsumo2.Text = "Registrar";
            btnRegistrarConsumo2.UseVisualStyleBackColor = false;
            btnRegistrarConsumo2.Click += btnRegistrarConsumo2_Click;
            // 
            // txtCantidadConsumo
            // 
            txtCantidadConsumo.Font = new Font("Segoe UI", 12F);
            txtCantidadConsumo.Location = new Point(30, 145);
            txtCantidadConsumo.Name = "txtCantidadConsumo";
            txtCantidadConsumo.PlaceholderText = "Número de sacos";
            txtCantidadConsumo.Size = new Size(1129, 34);
            txtCantidadConsumo.TabIndex = 4;
            // 
            // lblCantidadConsumo
            // 
            lblCantidadConsumo.AutoSize = true;
            lblCantidadConsumo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCantidadConsumo.ForeColor = Color.FromArgb(44, 62, 80);
            lblCantidadConsumo.Location = new Point(30, 115);
            lblCantidadConsumo.Name = "lblCantidadConsumo";
            lblCantidadConsumo.Size = new Size(141, 23);
            lblCantidadConsumo.TabIndex = 3;
            lblCantidadConsumo.Text = "Cantidad (sacos)";
            // 
            // dtpFechaConsumo
            // 
            dtpFechaConsumo.Font = new Font("Segoe UI", 12F);
            dtpFechaConsumo.Format = DateTimePickerFormat.Short;
            dtpFechaConsumo.Location = new Point(30, 75);
            dtpFechaConsumo.Name = "dtpFechaConsumo";
            dtpFechaConsumo.Size = new Size(1129, 34);
            dtpFechaConsumo.TabIndex = 2;
            // 
            // lblFechaConsumo
            // 
            lblFechaConsumo.AutoSize = true;
            lblFechaConsumo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFechaConsumo.ForeColor = Color.FromArgb(44, 62, 80);
            lblFechaConsumo.Location = new Point(30, 45);
            lblFechaConsumo.Name = "lblFechaConsumo";
            lblFechaConsumo.Size = new Size(55, 23);
            lblFechaConsumo.TabIndex = 1;
            lblFechaConsumo.Text = "Fecha";
            // 
            // lblNuevoConsumoTitle
            // 
            lblNuevoConsumoTitle.AutoSize = true;
            lblNuevoConsumoTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblNuevoConsumoTitle.ForeColor = Color.FromArgb(26, 32, 44);
            lblNuevoConsumoTitle.Location = new Point(0, 0);
            lblNuevoConsumoTitle.Name = "lblNuevoConsumoTitle";
            lblNuevoConsumoTitle.Size = new Size(204, 32);
            lblNuevoConsumoTitle.TabIndex = 0;
            lblNuevoConsumoTitle.Text = "Nuevo Consumo";
            // 
            // panelMovimientos
            // 
            panelMovimientos.BackColor = Color.White;
            panelMovimientos.Controls.Add(dgvMovimientos);
            panelMovimientos.Controls.Add(lblMovimientosTitle);
            panelMovimientos.Location = new Point(34, 180);
            panelMovimientos.Margin = new Padding(3, 4, 3, 4);
            panelMovimientos.Name = "panelMovimientos";
            panelMovimientos.Padding = new Padding(30);
            panelMovimientos.Size = new Size(1189, 480);
            panelMovimientos.TabIndex = 2;
            // 
            // dgvMovimientos
            // 
            dgvMovimientos.AllowUserToAddRows = false;
            dgvMovimientos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMovimientos.BackgroundColor = Color.White;
            dgvMovimientos.BorderStyle = BorderStyle.None;
            dgvMovimientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMovimientos.Location = new Point(30, 70);
            dgvMovimientos.Name = "dgvMovimientos";
            dgvMovimientos.RowHeadersVisible = false;
            dgvMovimientos.RowHeadersWidth = 51;
            dgvMovimientos.Size = new Size(1129, 380);
            dgvMovimientos.TabIndex = 1;
            // 
            // lblMovimientosTitle
            // 
            lblMovimientosTitle.AutoSize = true;
            lblMovimientosTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblMovimientosTitle.ForeColor = Color.FromArgb(26, 32, 44);
            lblMovimientosTitle.Location = new Point(0, 0);
            lblMovimientosTitle.Name = "lblMovimientosTitle";
            lblMovimientosTitle.Size = new Size(164, 32);
            lblMovimientosTitle.TabIndex = 0;
            lblMovimientosTitle.Text = "Movimientos";
            // 
            // Alimento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 933);
            Controls.Add(panelMain);
            Controls.Add(panelNav);
            Controls.Add(panelHeader);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Alimento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alimento - Rancho del Buen Pastor";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelNav.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panelNuevoIngreso.ResumeLayout(false);
            panelNuevoIngreso.PerformLayout();
            panelNuevoConsumo.ResumeLayout(false);
            panelNuevoConsumo.PerformLayout();
            panelMovimientos.ResumeLayout(false);
            panelMovimientos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMovimientos).EndInit();
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
        private System.Windows.Forms.Label lblStockTotal;
        private System.Windows.Forms.Label lblStockLabel;
        private System.Windows.Forms.Button btnRegistrarConsumo;
        private System.Windows.Forms.Button btnRegistrarIngreso;
        private System.Windows.Forms.Label lblAlimentoTitle;
        private System.Windows.Forms.Panel panelNuevoIngreso;
        private System.Windows.Forms.Button btnCancelarIngreso;
        private System.Windows.Forms.Button btnRegistrarIngreso2;
        private System.Windows.Forms.TextBox txtCantidadIngreso;
        private System.Windows.Forms.Label lblCantidadIngreso;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.Label lblNuevoIngresoTitle;
        private System.Windows.Forms.Panel panelNuevoConsumo;
        private System.Windows.Forms.Button btnCancelarConsumo;
        private System.Windows.Forms.Button btnRegistrarConsumo2;
        private System.Windows.Forms.TextBox txtCantidadConsumo;
        private System.Windows.Forms.Label lblCantidadConsumo;
        private System.Windows.Forms.DateTimePicker dtpFechaConsumo;
        private System.Windows.Forms.Label lblFechaConsumo;
        private System.Windows.Forms.Label lblNuevoConsumoTitle;
        private System.Windows.Forms.Panel panelMovimientos;
        private System.Windows.Forms.DataGridView dgvMovimientos;
        private System.Windows.Forms.Label lblMovimientosTitle;
    }
}
