namespace Granja
{
    partial class Insumos
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
            btnDashboard = new Button();
            panelMain = new Panel();
            panelRecetas = new Panel();
            btnCerrarRecetas = new Button();
            panelRecetaGalpon358 = new Panel();
            dgvRecetaGalpon358 = new DataGridView();
            lblRecetaGalpon358Titulo = new Label();
            panelRecetaGalpon687 = new Panel();
            dgvRecetaGalpon687 = new DataGridView();
            lblRecetaGalpon687Titulo = new Label();
            panelRecetaGalpon4 = new Panel();
            dgvRecetaGalpon4 = new DataGridView();
            lblRecetaGalpon4Titulo = new Label();
            lblRecetasTitulo = new Label();
            panelNuevoMovimiento = new Panel();
            btnCancelarMovimiento = new Button();
            btnRegistrarMovimientoConfirmar = new Button();
            txtObservaciones = new TextBox();
            lblObservaciones = new Label();
            txtCantidadMovimiento = new TextBox();
            lblCantidadMovimiento = new Label();
            cmbTipoMovimiento = new ComboBox();
            lblTipoMovimiento = new Label();
            cmbInsumoMovimiento = new ComboBox();
            lblInsumoMovimiento = new Label();
            lblNuevoMovimientoTitulo = new Label();
            panelHistorial = new Panel();
            dgvHistorial = new DataGridView();
            lblHistorialTitulo = new Label();
            panelInventario = new Panel();
            dgvInventario = new DataGridView();
            lblInventarioTitulo = new Label();
            panelBotones = new Panel();
            btnVerRecetas = new Button();
            btnRegistrarMovimiento = new Button();
            panelResumen = new Panel();
            cardConsumos = new Panel();
            lblConsumosValor = new Label();
            lblConsumosTitulo = new Label();
            cardEntradas = new Panel();
            lblEntradasValor = new Label();
            lblEntradasTitulo = new Label();
            cardCritico = new Panel();
            lblCriticoValor = new Label();
            lblCriticoTitulo = new Label();
            cardTotal = new Panel();
            lblTotalValor = new Label();
            lblTotalTitulo = new Label();
            lblInsumosTitle = new Label();
            panelHeader.SuspendLayout();
            panelNav.SuspendLayout();
            panelMain.SuspendLayout();
            panelRecetas.SuspendLayout();
            panelRecetaGalpon358.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecetaGalpon358).BeginInit();
            panelRecetaGalpon687.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecetaGalpon687).BeginInit();
            panelRecetaGalpon4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecetaGalpon4).BeginInit();
            panelNuevoMovimiento.SuspendLayout();
            panelHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            panelInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            panelBotones.SuspendLayout();
            panelResumen.SuspendLayout();
            cardConsumos.SuspendLayout();
            cardEntradas.SuspendLayout();
            cardCritico.SuspendLayout();
            cardTotal.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 125, 62);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
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
            panelNav.Controls.Add(btnDashboard);
            panelNav.Dock = DockStyle.Top;
            panelNav.Location = new Point(0, 80);
            panelNav.Name = "panelNav";
            panelNav.Size = new Size(1257, 73);
            panelNav.TabIndex = 1;
            // 
            // btnReportes
            // 
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Segoe UI", 10F);
            btnReportes.Location = new Point(572, 3);
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
            btnMolino.Location = new Point(419, 3);
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
            btnInsumos.ForeColor = Color.FromArgb(0, 125, 62);
            btnInsumos.Location = new Point(286, 3);
            btnInsumos.Name = "btnInsumos";
            btnInsumos.Size = new Size(137, 67);
            btnInsumos.TabIndex = 5;
            btnInsumos.Text = "Insumos";
            btnInsumos.UseVisualStyleBackColor = true;
            // 
            // btnAlimento
            // 
            this.btnAlimento.FlatAppearance.BorderSize = 0;
            this.btnAlimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlimento.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAlimento.Location = new System.Drawing.Point(538, 2);
            this.btnAlimento.Name = "btnAlimento";
            this.btnAlimento.Size = new System.Drawing.Size(137, 67);
            this.btnAlimento.TabIndex = 4;
            this.btnAlimento.Text = "Alimento";
            this.btnAlimento.UseVisualStyleBackColor = true;
            this.btnAlimento.Click += new System.EventHandler(this.btnAlimento_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnVentas.Location = new System.Drawing.Point(409, 2);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(137, 67);
            this.btnVentas.TabIndex = 3;
            this.btnVentas.Text = "Administrador";
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnAlmacen
            // 
            this.btnAlmacen.FlatAppearance.BorderSize = 0;
            this.btnAlmacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlmacen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAlmacen.Location = new System.Drawing.Point(280, 2);
            this.btnAlmacen.Name = "btnAlmacen";
            this.btnAlmacen.Size = new System.Drawing.Size(137, 67);
            this.btnAlmacen.TabIndex = 2;
            this.btnAlmacen.Text = "Almacén";
            this.btnAlmacen.UseVisualStyleBackColor = true;
            this.btnAlmacen.Click += new System.EventHandler(this.btnAlmacen_Click);
            // 
            // btnProduccion
            // 
            this.btnProduccion.FlatAppearance.BorderSize = 0;
            this.btnProduccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduccion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnProduccion.Location = new System.Drawing.Point(137, 2);
            this.btnProduccion.Name = "btnProduccion";
            this.btnProduccion.Size = new System.Drawing.Size(137, 67);
            this.btnProduccion.TabIndex = 1;
            this.btnProduccion.Text = "Producción";
            this.btnProduccion.UseVisualStyleBackColor = true;
            this.btnProduccion.Click += new System.EventHandler(this.btnProduccion_Click);
            // 
            // btnDashboard
            // 
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 10F);
            btnDashboard.Location = new Point(12, 2);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(137, 67);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panelMain
            // 
            panelMain.AutoScroll = true;
            panelMain.BackColor = Color.FromArgb(248, 249, 250);
            panelMain.Controls.Add(panelRecetas);
            panelMain.Controls.Add(panelNuevoMovimiento);
            panelMain.Controls.Add(panelHistorial);
            panelMain.Controls.Add(panelInventario);
            panelMain.Controls.Add(panelBotones);
            panelMain.Controls.Add(panelResumen);
            panelMain.Controls.Add(lblInsumosTitle);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 153);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(34, 40, 34, 40);
            panelMain.Size = new Size(1257, 780);
            panelMain.TabIndex = 2;
            // 
            // panelRecetas
            // 
            panelRecetas.BackColor = Color.White;
            panelRecetas.Controls.Add(btnCerrarRecetas);
            panelRecetas.Controls.Add(panelRecetaGalpon358);
            panelRecetas.Controls.Add(panelRecetaGalpon687);
            panelRecetas.Controls.Add(panelRecetaGalpon4);
            panelRecetas.Controls.Add(lblRecetasTitulo);
            panelRecetas.Location = new Point(34, 280);
            panelRecetas.Name = "panelRecetas";
            panelRecetas.Padding = new Padding(30);
            panelRecetas.Size = new Size(1189, 570);
            panelRecetas.TabIndex = 6;
            panelRecetas.Visible = false;
            // 
            // btnCerrarRecetas
            // 
            btnCerrarRecetas.BackColor = Color.FromArgb(108, 117, 125);
            btnCerrarRecetas.FlatAppearance.BorderSize = 0;
            btnCerrarRecetas.FlatStyle = FlatStyle.Flat;
            btnCerrarRecetas.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCerrarRecetas.ForeColor = Color.White;
            btnCerrarRecetas.Location = new Point(1029, 0);
            btnCerrarRecetas.Name = "btnCerrarRecetas";
            btnCerrarRecetas.Size = new Size(130, 40);
            btnCerrarRecetas.TabIndex = 4;
            btnCerrarRecetas.Text = "Cerrar";
            btnCerrarRecetas.UseVisualStyleBackColor = false;
            btnCerrarRecetas.Click += btnCerrarRecetas_Click;
            // 
            // panelRecetaGalpon358
            // 
            panelRecetaGalpon358.Controls.Add(dgvRecetaGalpon358);
            panelRecetaGalpon358.Controls.Add(lblRecetaGalpon358Titulo);
            panelRecetaGalpon358.Location = new Point(790, 50);
            panelRecetaGalpon358.Name = "panelRecetaGalpon358";
            panelRecetaGalpon358.Size = new Size(350, 480);
            panelRecetaGalpon358.TabIndex = 3;
            // 
            // dgvRecetaGalpon358
            // 
            dgvRecetaGalpon358.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecetaGalpon358.BackgroundColor = Color.White;
            dgvRecetaGalpon358.BorderStyle = BorderStyle.None;
            dgvRecetaGalpon358.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecetaGalpon358.Location = new Point(0, 40);
            dgvRecetaGalpon358.Name = "dgvRecetaGalpon358";
            dgvRecetaGalpon358.RowHeadersVisible = false;
            dgvRecetaGalpon358.RowHeadersWidth = 51;
            dgvRecetaGalpon358.Size = new Size(350, 440);
            dgvRecetaGalpon358.TabIndex = 1;
            // 
            // lblRecetaGalpon358Titulo
            // 
            lblRecetaGalpon358Titulo.AutoSize = true;
            lblRecetaGalpon358Titulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRecetaGalpon358Titulo.ForeColor = Color.FromArgb(26, 32, 44);
            lblRecetaGalpon358Titulo.Location = new Point(0, 0);
            lblRecetaGalpon358Titulo.Name = "lblRecetaGalpon358Titulo";
            lblRecetaGalpon358Titulo.Size = new Size(137, 28);
            lblRecetaGalpon358Titulo.TabIndex = 2;
            lblRecetaGalpon358Titulo.Text = "Galpón 3-5-8";
            // 
            // panelRecetaGalpon687
            // 
            panelRecetaGalpon687.Controls.Add(dgvRecetaGalpon687);
            panelRecetaGalpon687.Controls.Add(lblRecetaGalpon687Titulo);
            panelRecetaGalpon687.Location = new Point(410, 50);
            panelRecetaGalpon687.Name = "panelRecetaGalpon687";
            panelRecetaGalpon687.Size = new Size(350, 480);
            panelRecetaGalpon687.TabIndex = 2;
            // 
            // dgvRecetaGalpon687
            // 
            dgvRecetaGalpon687.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecetaGalpon687.BackgroundColor = Color.White;
            dgvRecetaGalpon687.BorderStyle = BorderStyle.None;
            dgvRecetaGalpon687.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecetaGalpon687.Location = new Point(0, 40);
            dgvRecetaGalpon687.Name = "dgvRecetaGalpon687";
            dgvRecetaGalpon687.RowHeadersVisible = false;
            dgvRecetaGalpon687.RowHeadersWidth = 51;
            dgvRecetaGalpon687.Size = new Size(350, 440);
            dgvRecetaGalpon687.TabIndex = 1;
            // 
            // lblRecetaGalpon687Titulo
            // 
            lblRecetaGalpon687Titulo.AutoSize = true;
            lblRecetaGalpon687Titulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRecetaGalpon687Titulo.ForeColor = Color.FromArgb(26, 32, 44);
            lblRecetaGalpon687Titulo.Location = new Point(0, 0);
            lblRecetaGalpon687Titulo.Name = "lblRecetaGalpon687Titulo";
            lblRecetaGalpon687Titulo.Size = new Size(137, 28);
            lblRecetaGalpon687Titulo.TabIndex = 2;
            lblRecetaGalpon687Titulo.Text = "Galpón 6-8-7";
            // 
            // panelRecetaGalpon4
            // 
            panelRecetaGalpon4.Controls.Add(dgvRecetaGalpon4);
            panelRecetaGalpon4.Controls.Add(lblRecetaGalpon4Titulo);
            panelRecetaGalpon4.Location = new Point(30, 50);
            panelRecetaGalpon4.Name = "panelRecetaGalpon4";
            panelRecetaGalpon4.Size = new Size(350, 480);
            panelRecetaGalpon4.TabIndex = 1;
            // 
            // dgvRecetaGalpon4
            // 
            dgvRecetaGalpon4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecetaGalpon4.BackgroundColor = Color.White;
            dgvRecetaGalpon4.BorderStyle = BorderStyle.None;
            dgvRecetaGalpon4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecetaGalpon4.Location = new Point(0, 40);
            dgvRecetaGalpon4.Name = "dgvRecetaGalpon4";
            dgvRecetaGalpon4.RowHeadersVisible = false;
            dgvRecetaGalpon4.RowHeadersWidth = 51;
            dgvRecetaGalpon4.Size = new Size(350, 440);
            dgvRecetaGalpon4.TabIndex = 1;
            // 
            // lblRecetaGalpon4Titulo
            // 
            lblRecetaGalpon4Titulo.AutoSize = true;
            lblRecetaGalpon4Titulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRecetaGalpon4Titulo.ForeColor = Color.FromArgb(26, 32, 44);
            lblRecetaGalpon4Titulo.Location = new Point(0, 0);
            lblRecetaGalpon4Titulo.Name = "lblRecetaGalpon4Titulo";
            lblRecetaGalpon4Titulo.Size = new Size(97, 28);
            lblRecetaGalpon4Titulo.TabIndex = 0;
            lblRecetaGalpon4Titulo.Text = "Galpón 4";
            // 
            // lblRecetasTitulo
            // 
            lblRecetasTitulo.AutoSize = true;
            lblRecetasTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblRecetasTitulo.ForeColor = Color.FromArgb(26, 32, 44);
            lblRecetasTitulo.Location = new Point(0, 0);
            lblRecetasTitulo.Name = "lblRecetasTitulo";
            lblRecetasTitulo.Size = new Size(236, 32);
            lblRecetasTitulo.TabIndex = 0;
            lblRecetasTitulo.Text = "Recetas por Galpón";
            // 
            // panelNuevoMovimiento
            // 
            panelNuevoMovimiento.BackColor = Color.White;
            panelNuevoMovimiento.Controls.Add(btnCancelarMovimiento);
            panelNuevoMovimiento.Controls.Add(btnRegistrarMovimientoConfirmar);
            panelNuevoMovimiento.Controls.Add(txtObservaciones);
            panelNuevoMovimiento.Controls.Add(lblObservaciones);
            panelNuevoMovimiento.Controls.Add(txtCantidadMovimiento);
            panelNuevoMovimiento.Controls.Add(lblCantidadMovimiento);
            panelNuevoMovimiento.Controls.Add(cmbTipoMovimiento);
            panelNuevoMovimiento.Controls.Add(lblTipoMovimiento);
            panelNuevoMovimiento.Controls.Add(cmbInsumoMovimiento);
            panelNuevoMovimiento.Controls.Add(lblInsumoMovimiento);
            panelNuevoMovimiento.Controls.Add(lblNuevoMovimientoTitulo);
            panelNuevoMovimiento.Location = new Point(34, 280);
            panelNuevoMovimiento.Name = "panelNuevoMovimiento";
            panelNuevoMovimiento.Padding = new Padding(30);
            panelNuevoMovimiento.Size = new Size(1189, 300);
            panelNuevoMovimiento.TabIndex = 5;
            panelNuevoMovimiento.Visible = false;
            // 
            // btnCancelarMovimiento
            // 
            btnCancelarMovimiento.BackColor = Color.FromArgb(108, 117, 125);
            btnCancelarMovimiento.FlatAppearance.BorderSize = 0;
            btnCancelarMovimiento.FlatStyle = FlatStyle.Flat;
            btnCancelarMovimiento.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCancelarMovimiento.ForeColor = Color.White;
            btnCancelarMovimiento.Location = new Point(170, 230);
            btnCancelarMovimiento.Name = "btnCancelarMovimiento";
            btnCancelarMovimiento.Size = new Size(150, 45);
            btnCancelarMovimiento.TabIndex = 10;
            btnCancelarMovimiento.Text = "Cancelar";
            btnCancelarMovimiento.UseVisualStyleBackColor = false;
            btnCancelarMovimiento.Click += btnCancelarMovimiento_Click;
            // 
            // btnRegistrarMovimientoConfirmar
            // 
            btnRegistrarMovimientoConfirmar.BackColor = Color.FromArgb(0, 125, 62);
            btnRegistrarMovimientoConfirmar.FlatAppearance.BorderSize = 0;
            btnRegistrarMovimientoConfirmar.FlatStyle = FlatStyle.Flat;
            btnRegistrarMovimientoConfirmar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRegistrarMovimientoConfirmar.ForeColor = Color.White;
            btnRegistrarMovimientoConfirmar.Location = new Point(30, 230);
            btnRegistrarMovimientoConfirmar.Name = "btnRegistrarMovimientoConfirmar";
            btnRegistrarMovimientoConfirmar.Size = new Size(130, 45);
            btnRegistrarMovimientoConfirmar.TabIndex = 9;
            btnRegistrarMovimientoConfirmar.Text = "Registrar";
            btnRegistrarMovimientoConfirmar.UseVisualStyleBackColor = false;
            btnRegistrarMovimientoConfirmar.Click += btnRegistrarMovimientoConfirmar_Click;
            // 
            // txtObservaciones
            // 
            txtObservaciones.Font = new Font("Segoe UI", 12F);
            txtObservaciones.Location = new Point(30, 170);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.PlaceholderText = "Observaciones (opcional)";
            txtObservaciones.Size = new Size(1129, 50);
            txtObservaciones.TabIndex = 8;
            // 
            // lblObservaciones
            // 
            lblObservaciones.AutoSize = true;
            lblObservaciones.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblObservaciones.ForeColor = Color.FromArgb(44, 62, 80);
            lblObservaciones.Location = new Point(30, 140);
            lblObservaciones.Name = "lblObservaciones";
            lblObservaciones.Size = new Size(125, 23);
            lblObservaciones.TabIndex = 7;
            lblObservaciones.Text = "Observaciones";
            // 
            // txtCantidadMovimiento
            // 
            txtCantidadMovimiento.Font = new Font("Segoe UI", 12F);
            txtCantidadMovimiento.Location = new Point(630, 100);
            txtCantidadMovimiento.Name = "txtCantidadMovimiento";
            txtCantidadMovimiento.PlaceholderText = "Cantidad";
            txtCantidadMovimiento.Size = new Size(529, 34);
            txtCantidadMovimiento.TabIndex = 6;
            // 
            // lblCantidadMovimiento
            // 
            lblCantidadMovimiento.AutoSize = true;
            lblCantidadMovimiento.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCantidadMovimiento.ForeColor = Color.FromArgb(44, 62, 80);
            lblCantidadMovimiento.Location = new Point(630, 70);
            lblCantidadMovimiento.Name = "lblCantidadMovimiento";
            lblCantidadMovimiento.Size = new Size(83, 23);
            lblCantidadMovimiento.TabIndex = 5;
            lblCantidadMovimiento.Text = "Cantidad";
            // 
            // cmbTipoMovimiento
            // 
            cmbTipoMovimiento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoMovimiento.Font = new Font("Segoe UI", 12F);
            cmbTipoMovimiento.FormattingEnabled = true;
            cmbTipoMovimiento.Items.AddRange(new object[] { "Entrada", "Consumo" });
            cmbTipoMovimiento.Location = new Point(30, 100);
            cmbTipoMovimiento.Name = "cmbTipoMovimiento";
            cmbTipoMovimiento.Size = new Size(574, 36);
            cmbTipoMovimiento.TabIndex = 4;
            // 
            // lblTipoMovimiento
            // 
            lblTipoMovimiento.AutoSize = true;
            lblTipoMovimiento.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTipoMovimiento.ForeColor = Color.FromArgb(44, 62, 80);
            lblTipoMovimiento.Location = new Point(30, 70);
            lblTipoMovimiento.Name = "lblTipoMovimiento";
            lblTipoMovimiento.Size = new Size(173, 23);
            lblTipoMovimiento.TabIndex = 3;
            lblTipoMovimiento.Text = "Tipo de Movimiento";
            // 
            // cmbInsumoMovimiento
            // 
            cmbInsumoMovimiento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbInsumoMovimiento.Font = new Font("Segoe UI", 12F);
            cmbInsumoMovimiento.FormattingEnabled = true;
            cmbInsumoMovimiento.Location = new Point(30, 40);
            cmbInsumoMovimiento.Name = "cmbInsumoMovimiento";
            cmbInsumoMovimiento.Size = new Size(1129, 36);
            cmbInsumoMovimiento.TabIndex = 2;
            // 
            // lblInsumoMovimiento
            // 
            lblInsumoMovimiento.AutoSize = true;
            lblInsumoMovimiento.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblInsumoMovimiento.ForeColor = Color.FromArgb(44, 62, 80);
            lblInsumoMovimiento.Location = new Point(30, 10);
            lblInsumoMovimiento.Name = "lblInsumoMovimiento";
            lblInsumoMovimiento.Size = new Size(68, 23);
            lblInsumoMovimiento.TabIndex = 1;
            lblInsumoMovimiento.Text = "Insumo";
            // 
            // lblNuevoMovimientoTitulo
            // 
            lblNuevoMovimientoTitulo.AutoSize = true;
            lblNuevoMovimientoTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblNuevoMovimientoTitulo.ForeColor = Color.FromArgb(26, 32, 44);
            lblNuevoMovimientoTitulo.Location = new Point(0, -20);
            lblNuevoMovimientoTitulo.Name = "lblNuevoMovimientoTitulo";
            lblNuevoMovimientoTitulo.Size = new Size(263, 32);
            lblNuevoMovimientoTitulo.TabIndex = 0;
            lblNuevoMovimientoTitulo.Text = "Registrar Movimiento";
            // 
            // panelHistorial
            // 
            panelHistorial.BackColor = Color.White;
            panelHistorial.Controls.Add(dgvHistorial);
            panelHistorial.Controls.Add(lblHistorialTitulo);
            panelHistorial.Location = new Point(34, 570);
            panelHistorial.Name = "panelHistorial";
            panelHistorial.Padding = new Padding(30);
            panelHistorial.Size = new Size(1189, 280);
            panelHistorial.TabIndex = 4;
            // 
            // dgvHistorial
            // 
            dgvHistorial.AllowUserToAddRows = false;
            dgvHistorial.AllowUserToDeleteRows = false;
            dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorial.BackgroundColor = Color.White;
            dgvHistorial.BorderStyle = BorderStyle.None;
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Location = new Point(30, 70);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.ReadOnly = true;
            dgvHistorial.RowHeadersVisible = false;
            dgvHistorial.RowHeadersWidth = 51;
            dgvHistorial.Size = new Size(1129, 180);
            dgvHistorial.TabIndex = 1;
            // 
            // lblHistorialTitulo
            // 
            lblHistorialTitulo.AutoSize = true;
            lblHistorialTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblHistorialTitulo.ForeColor = Color.FromArgb(26, 32, 44);
            lblHistorialTitulo.Location = new Point(0, 0);
            lblHistorialTitulo.Name = "lblHistorialTitulo";
            lblHistorialTitulo.Size = new Size(303, 32);
            lblHistorialTitulo.TabIndex = 0;
            lblHistorialTitulo.Text = "Historial de Movimientos";
            // 
            // panelInventario
            // 
            panelInventario.BackColor = Color.White;
            panelInventario.Controls.Add(dgvInventario);
            panelInventario.Controls.Add(lblInventarioTitulo);
            panelInventario.Location = new Point(34, 280);
            panelInventario.Name = "panelInventario";
            panelInventario.Padding = new Padding(30);
            panelInventario.Size = new Size(1189, 280);
            panelInventario.TabIndex = 3;
            // 
            // dgvInventario
            // 
            dgvInventario.AllowUserToAddRows = false;
            dgvInventario.AllowUserToDeleteRows = false;
            dgvInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventario.BackgroundColor = Color.White;
            dgvInventario.BorderStyle = BorderStyle.None;
            dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventario.Location = new Point(30, 70);
            dgvInventario.Name = "dgvInventario";
            dgvInventario.ReadOnly = true;
            dgvInventario.RowHeadersVisible = false;
            dgvInventario.RowHeadersWidth = 51;
            dgvInventario.Size = new Size(1129, 180);
            dgvInventario.TabIndex = 1;
            // 
            // lblInventarioTitulo
            // 
            lblInventarioTitulo.AutoSize = true;
            lblInventarioTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblInventarioTitulo.ForeColor = Color.FromArgb(26, 32, 44);
            lblInventarioTitulo.Location = new Point(0, 0);
            lblInventarioTitulo.Name = "lblInventarioTitulo";
            lblInventarioTitulo.Size = new Size(271, 32);
            lblInventarioTitulo.TabIndex = 0;
            lblInventarioTitulo.Text = "Inventario de Insumos";
            // 
            // panelBotones
            // 
            panelBotones.Controls.Add(btnVerRecetas);
            panelBotones.Controls.Add(btnRegistrarMovimiento);
            panelBotones.Location = new Point(34, 210);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(1189, 60);
            panelBotones.TabIndex = 2;
            // 
            // btnVerRecetas
            // 
            btnVerRecetas.BackColor = Color.FromArgb(139, 92, 246);
            btnVerRecetas.FlatAppearance.BorderSize = 0;
            btnVerRecetas.FlatStyle = FlatStyle.Flat;
            btnVerRecetas.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnVerRecetas.ForeColor = Color.White;
            btnVerRecetas.Location = new Point(260, 5);
            btnVerRecetas.Name = "btnVerRecetas";
            btnVerRecetas.Size = new Size(230, 50);
            btnVerRecetas.TabIndex = 1;
            btnVerRecetas.Text = "📋 Ver Recetas";
            btnVerRecetas.UseVisualStyleBackColor = false;
            btnVerRecetas.Click += btnVerRecetas_Click;
            // 
            // btnRegistrarMovimiento
            // 
            btnRegistrarMovimiento.BackColor = Color.FromArgb(0, 125, 62);
            btnRegistrarMovimiento.FlatAppearance.BorderSize = 0;
            btnRegistrarMovimiento.FlatStyle = FlatStyle.Flat;
            btnRegistrarMovimiento.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRegistrarMovimiento.ForeColor = Color.White;
            btnRegistrarMovimiento.Location = new Point(0, 5);
            btnRegistrarMovimiento.Name = "btnRegistrarMovimiento";
            btnRegistrarMovimiento.Size = new Size(250, 50);
            btnRegistrarMovimiento.TabIndex = 0;
            btnRegistrarMovimiento.Text = "+ Registrar Movimiento";
            btnRegistrarMovimiento.UseVisualStyleBackColor = false;
            btnRegistrarMovimiento.Click += btnRegistrarMovimiento_Click;
            // 
            // panelResumen
            // 
            panelResumen.Controls.Add(cardConsumos);
            panelResumen.Controls.Add(cardEntradas);
            panelResumen.Controls.Add(cardCritico);
            panelResumen.Controls.Add(cardTotal);
            panelResumen.Location = new Point(34, 80);
            panelResumen.Name = "panelResumen";
            panelResumen.Size = new Size(1189, 120);
            panelResumen.TabIndex = 1;
            // 
            // cardConsumos
            // 
            cardConsumos.BackColor = Color.White;
            cardConsumos.BorderStyle = BorderStyle.FixedSingle;
            cardConsumos.Controls.Add(lblConsumosValor);
            cardConsumos.Controls.Add(lblConsumosTitulo);
            cardConsumos.Location = new Point(900, 10);
            cardConsumos.Name = "cardConsumos";
            cardConsumos.Size = new Size(280, 100);
            cardConsumos.TabIndex = 3;
            // 
            // lblConsumosValor
            // 
            lblConsumosValor.AutoSize = true;
            lblConsumosValor.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblConsumosValor.ForeColor = Color.FromArgb(220, 38, 38);
            lblConsumosValor.Location = new Point(20, 40);
            lblConsumosValor.Name = "lblConsumosValor";
            lblConsumosValor.Size = new Size(46, 54);
            lblConsumosValor.TabIndex = 1;
            lblConsumosValor.Text = "0";
            // 
            // lblConsumosTitulo
            // 
            lblConsumosTitulo.AutoSize = true;
            lblConsumosTitulo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblConsumosTitulo.ForeColor = Color.FromArgb(44, 62, 80);
            lblConsumosTitulo.Location = new Point(20, 10);
            lblConsumosTitulo.Name = "lblConsumosTitulo";
            lblConsumosTitulo.Size = new Size(91, 23);
            lblConsumosTitulo.TabIndex = 0;
            lblConsumosTitulo.Text = "Consumos";
            // 
            // cardEntradas
            // 
            cardEntradas.BackColor = Color.White;
            cardEntradas.BorderStyle = BorderStyle.FixedSingle;
            cardEntradas.Controls.Add(lblEntradasValor);
            cardEntradas.Controls.Add(lblEntradasTitulo);
            cardEntradas.Location = new Point(600, 10);
            cardEntradas.Name = "cardEntradas";
            cardEntradas.Size = new Size(280, 100);
            cardEntradas.TabIndex = 2;
            // 
            // lblEntradasValor
            // 
            lblEntradasValor.AutoSize = true;
            lblEntradasValor.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblEntradasValor.ForeColor = Color.FromArgb(0, 125, 62);
            lblEntradasValor.Location = new Point(20, 40);
            lblEntradasValor.Name = "lblEntradasValor";
            lblEntradasValor.Size = new Size(46, 54);
            lblEntradasValor.TabIndex = 1;
            lblEntradasValor.Text = "0";
            // 
            // lblEntradasTitulo
            // 
            lblEntradasTitulo.AutoSize = true;
            lblEntradasTitulo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEntradasTitulo.ForeColor = Color.FromArgb(44, 62, 80);
            lblEntradasTitulo.Location = new Point(20, 10);
            lblEntradasTitulo.Name = "lblEntradasTitulo";
            lblEntradasTitulo.Size = new Size(79, 23);
            lblEntradasTitulo.TabIndex = 0;
            lblEntradasTitulo.Text = "Entradas";
            // 
            // cardCritico
            // 
            cardCritico.BackColor = Color.White;
            cardCritico.BorderStyle = BorderStyle.FixedSingle;
            cardCritico.Controls.Add(lblCriticoValor);
            cardCritico.Controls.Add(lblCriticoTitulo);
            cardCritico.Location = new Point(300, 10);
            cardCritico.Name = "cardCritico";
            cardCritico.Size = new Size(280, 100);
            cardCritico.TabIndex = 1;
            // 
            // lblCriticoValor
            // 
            lblCriticoValor.AutoSize = true;
            lblCriticoValor.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblCriticoValor.ForeColor = Color.FromArgb(245, 158, 11);
            lblCriticoValor.Location = new Point(20, 40);
            lblCriticoValor.Name = "lblCriticoValor";
            lblCriticoValor.Size = new Size(46, 54);
            lblCriticoValor.TabIndex = 1;
            lblCriticoValor.Text = "0";
            // 
            // lblCriticoTitulo
            // 
            lblCriticoTitulo.AutoSize = true;
            lblCriticoTitulo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCriticoTitulo.ForeColor = Color.FromArgb(44, 62, 80);
            lblCriticoTitulo.Location = new Point(20, 10);
            lblCriticoTitulo.Name = "lblCriticoTitulo";
            lblCriticoTitulo.Size = new Size(113, 23);
            lblCriticoTitulo.TabIndex = 0;
            lblCriticoTitulo.Text = "Stock Crítico";
            // 
            // cardTotal
            // 
            cardTotal.BackColor = Color.White;
            cardTotal.BorderStyle = BorderStyle.FixedSingle;
            cardTotal.Controls.Add(lblTotalValor);
            cardTotal.Controls.Add(lblTotalTitulo);
            cardTotal.Location = new Point(0, 10);
            cardTotal.Name = "cardTotal";
            cardTotal.Size = new Size(280, 100);
            cardTotal.TabIndex = 0;
            // 
            // lblTotalValor
            // 
            lblTotalValor.AutoSize = true;
            lblTotalValor.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTotalValor.ForeColor = Color.FromArgb(37, 99, 235);
            lblTotalValor.Location = new Point(20, 40);
            lblTotalValor.Name = "lblTotalValor";
            lblTotalValor.Size = new Size(46, 54);
            lblTotalValor.TabIndex = 1;
            lblTotalValor.Text = "0";
            // 
            // lblTotalTitulo
            // 
            lblTotalTitulo.AutoSize = true;
            lblTotalTitulo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotalTitulo.ForeColor = Color.FromArgb(44, 62, 80);
            lblTotalTitulo.Location = new Point(20, 10);
            lblTotalTitulo.Name = "lblTotalTitulo";
            lblTotalTitulo.Size = new Size(119, 23);
            lblTotalTitulo.TabIndex = 0;
            lblTotalTitulo.Text = "Total Insumos";
            // 
            // lblInsumosTitle
            // 
            lblInsumosTitle.AutoSize = true;
            lblInsumosTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblInsumosTitle.ForeColor = Color.FromArgb(26, 32, 44);
            lblInsumosTitle.Location = new Point(34, 20);
            lblInsumosTitle.Name = "lblInsumosTitle";
            lblInsumosTitle.Size = new Size(292, 41);
            lblInsumosTitle.TabIndex = 0;
            lblInsumosTitle.Text = "Control de Insumos";
            // 
            // Insumos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 933);
            Controls.Add(panelMain);
            Controls.Add(panelNav);
            Controls.Add(panelHeader);
            Name = "Insumos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Insumos - Rancho del Buen Pastor";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelNav.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panelRecetas.ResumeLayout(false);
            panelRecetas.PerformLayout();
            panelRecetaGalpon358.ResumeLayout(false);
            panelRecetaGalpon358.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecetaGalpon358).EndInit();
            panelRecetaGalpon687.ResumeLayout(false);
            panelRecetaGalpon687.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecetaGalpon687).EndInit();
            panelRecetaGalpon4.ResumeLayout(false);
            panelRecetaGalpon4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecetaGalpon4).EndInit();
            panelNuevoMovimiento.ResumeLayout(false);
            panelNuevoMovimiento.PerformLayout();
            panelHistorial.ResumeLayout(false);
            panelHistorial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            panelInventario.ResumeLayout(false);
            panelInventario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            panelBotones.ResumeLayout(false);
            panelResumen.ResumeLayout(false);
            cardConsumos.ResumeLayout(false);
            cardConsumos.PerformLayout();
            cardEntradas.ResumeLayout(false);
            cardEntradas.PerformLayout();
            cardCritico.ResumeLayout(false);
            cardCritico.PerformLayout();
            cardTotal.ResumeLayout(false);
            cardTotal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnProduccion = new();
        private System.Windows.Forms.Button btnAlmacen = new();
        private System.Windows.Forms.Button btnVentas = new();
        private System.Windows.Forms.Button btnAlimento;
        private System.Windows.Forms.Button btnMolino;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnInsumos;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblInsumosTitle;
        private System.Windows.Forms.Panel panelResumen;
        private System.Windows.Forms.Panel cardTotal;
        private System.Windows.Forms.Label lblTotalValor;
        private System.Windows.Forms.Label lblTotalTitulo;
        private System.Windows.Forms.Panel cardConsumos;
        private System.Windows.Forms.Label lblConsumosValor;
        private System.Windows.Forms.Label lblConsumosTitulo;
        private System.Windows.Forms.Panel cardEntradas;
        private System.Windows.Forms.Label lblEntradasValor;
        private System.Windows.Forms.Label lblEntradasTitulo;
        private System.Windows.Forms.Panel cardCritico;
        private System.Windows.Forms.Label lblCriticoValor;
        private System.Windows.Forms.Label lblCriticoTitulo;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnVerRecetas;
        private System.Windows.Forms.Button btnRegistrarMovimiento;
        private System.Windows.Forms.Panel panelInventario;
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.Label lblInventarioTitulo;
        private System.Windows.Forms.Panel panelHistorial;
        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.Label lblHistorialTitulo;
        private System.Windows.Forms.Panel panelNuevoMovimiento;
        private System.Windows.Forms.Label lblNuevoMovimientoTitulo;
        private System.Windows.Forms.ComboBox cmbInsumoMovimiento;
        private System.Windows.Forms.Label lblInsumoMovimiento;
        private System.Windows.Forms.TextBox txtCantidadMovimiento;
        private System.Windows.Forms.Label lblCantidadMovimiento;
        private System.Windows.Forms.ComboBox cmbTipoMovimiento;
        private System.Windows.Forms.Label lblTipoMovimiento;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.Button btnCancelarMovimiento;
        private System.Windows.Forms.Button btnRegistrarMovimientoConfirmar;
        private System.Windows.Forms.Panel panelRecetas;
        private System.Windows.Forms.Button btnCerrarRecetas;
        private System.Windows.Forms.Panel panelRecetaGalpon358;
        private System.Windows.Forms.DataGridView dgvRecetaGalpon358;
        private System.Windows.Forms.Label lblRecetaGalpon358Titulo;
        private System.Windows.Forms.Panel panelRecetaGalpon687;
        private System.Windows.Forms.DataGridView dgvRecetaGalpon687;
        private System.Windows.Forms.Label lblRecetaGalpon687Titulo;
        private System.Windows.Forms.Panel panelRecetaGalpon4;
        private System.Windows.Forms.DataGridView dgvRecetaGalpon4;
        private System.Windows.Forms.Label lblRecetaGalpon4Titulo;
        private System.Windows.Forms.Label lblRecetasTitulo;
    }
}

