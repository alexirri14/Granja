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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelNav = new System.Windows.Forms.Panel();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnMolino = new System.Windows.Forms.Button();
            this.btnInsumos = new System.Windows.Forms.Button();
            this.btnAlimento = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnAlmacen = new System.Windows.Forms.Button();
            this.btnProduccion = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblInsumosTitle = new System.Windows.Forms.Label();
            this.panelResumen = new System.Windows.Forms.Panel();
            this.cardConsumos = new System.Windows.Forms.Panel();
            this.lblConsumosValor = new System.Windows.Forms.Label();
            this.lblConsumosTitulo = new System.Windows.Forms.Label();
            this.cardEntradas = new System.Windows.Forms.Panel();
            this.lblEntradasValor = new System.Windows.Forms.Label();
            this.lblEntradasTitulo = new System.Windows.Forms.Label();
            this.cardCritico = new System.Windows.Forms.Panel();
            this.lblCriticoValor = new System.Windows.Forms.Label();
            this.lblCriticoTitulo = new System.Windows.Forms.Label();
            this.cardTotal = new System.Windows.Forms.Panel();
            this.lblTotalValor = new System.Windows.Forms.Label();
            this.lblTotalTitulo = new System.Windows.Forms.Label();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnVerRecetas = new System.Windows.Forms.Button();
            this.btnRegistrarMovimiento = new System.Windows.Forms.Button();
            this.panelInventario = new System.Windows.Forms.Panel();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.lblInventarioTitulo = new System.Windows.Forms.Label();
            this.panelHistorial = new System.Windows.Forms.Panel();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.lblHistorialTitulo = new System.Windows.Forms.Label();
            this.panelNuevoMovimiento = new System.Windows.Forms.Panel();
            this.btnCancelarMovimiento = new System.Windows.Forms.Button();
            this.btnRegistrarMovimientoConfirmar = new System.Windows.Forms.Button();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.txtCantidadMovimiento = new System.Windows.Forms.TextBox();
            this.lblCantidadMovimiento = new System.Windows.Forms.Label();
            this.cmbTipoMovimiento = new System.Windows.Forms.ComboBox();
            this.lblTipoMovimiento = new System.Windows.Forms.Label();
            this.cmbInsumoMovimiento = new System.Windows.Forms.ComboBox();
            this.lblInsumoMovimiento = new System.Windows.Forms.Label();
            this.lblNuevoMovimientoTitulo = new System.Windows.Forms.Label();
            this.panelRecetas = new System.Windows.Forms.Panel();
            this.lblRecetasTitulo = new System.Windows.Forms.Label();
            this.panelRecetaGalpon4 = new System.Windows.Forms.Panel();
            this.lblRecetaGalpon4Titulo = new System.Windows.Forms.Label();
            this.dgvRecetaGalpon4 = new System.Windows.Forms.DataGridView();
            this.panelRecetaGalpon687 = new System.Windows.Forms.Panel();
            this.lblRecetaGalpon687Titulo = new System.Windows.Forms.Label();
            this.dgvRecetaGalpon687 = new System.Windows.Forms.DataGridView();
            this.panelRecetaGalpon358 = new System.Windows.Forms.Panel();
            this.lblRecetaGalpon358Titulo = new System.Windows.Forms.Label();
            this.dgvRecetaGalpon358 = new System.Windows.Forms.DataGridView();
            this.btnCerrarRecetas = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelNav.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelResumen.SuspendLayout();
            this.cardConsumos.SuspendLayout();
            this.cardEntradas.SuspendLayout();
            this.cardCritico.SuspendLayout();
            this.cardTotal.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.panelInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.panelHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.panelNuevoMovimiento.SuspendLayout();
            this.panelRecetas.SuspendLayout();
            this.panelRecetaGalpon4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecetaGalpon4)).BeginInit();
            this.panelRecetaGalpon687.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecetaGalpon687)).BeginInit();
            this.panelRecetaGalpon358.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecetaGalpon358)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(62)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1257, 80);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(23, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(575, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Sistema Avícola - El Rancho del Buen Pastor";
            // 
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.Color.White;
            this.panelNav.Controls.Add(this.btnReportes);
            this.panelNav.Controls.Add(this.btnMolino);
            this.panelNav.Controls.Add(this.btnInsumos);
            this.panelNav.Controls.Add(this.btnAlimento);
            this.panelNav.Controls.Add(this.btnVentas);
            this.panelNav.Controls.Add(this.btnAlmacen);
            this.panelNav.Controls.Add(this.btnProduccion);
            this.panelNav.Controls.Add(this.btnDashboard);
            this.panelNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNav.Location = new System.Drawing.Point(0, 80);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(1257, 73);
            this.panelNav.TabIndex = 1;
            // 
            // btnReportes
            // 
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnReportes.Location = new System.Drawing.Point(943, 2);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(137, 67);
            this.btnReportes.TabIndex = 7;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnMolino
            // 
            this.btnMolino.FlatAppearance.BorderSize = 0;
            this.btnMolino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMolino.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMolino.Location = new System.Drawing.Point(806, 2);
            this.btnMolino.Name = "btnMolino";
            this.btnMolino.Size = new System.Drawing.Size(137, 67);
            this.btnMolino.TabIndex = 6;
            this.btnMolino.Text = "Molino";
            this.btnMolino.UseVisualStyleBackColor = true;
            this.btnMolino.Click += new System.EventHandler(this.btnMolino_Click);
            // 
            // btnInsumos
            // 
            this.btnInsumos.FlatAppearance.BorderSize = 0;
            this.btnInsumos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsumos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnInsumos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(62)))));
            this.btnInsumos.Location = new System.Drawing.Point(681, 2);
            this.btnInsumos.Name = "btnInsumos";
            this.btnInsumos.Size = new System.Drawing.Size(137, 67);
            this.btnInsumos.TabIndex = 5;
            this.btnInsumos.Text = "Insumos";
            this.btnInsumos.UseVisualStyleBackColor = true;
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
            this.btnVentas.Text = "Ventas";
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
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDashboard.Location = new System.Drawing.Point(3, 2);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(137, 67);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panelMain.Controls.Add(this.panelRecetas);
            this.panelMain.Controls.Add(this.panelNuevoMovimiento);
            this.panelMain.Controls.Add(this.panelHistorial);
            this.panelMain.Controls.Add(this.panelInventario);
            this.panelMain.Controls.Add(this.panelBotones);
            this.panelMain.Controls.Add(this.panelResumen);
            this.panelMain.Controls.Add(this.lblInsumosTitle);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 153);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(34, 40, 34, 40);
            this.panelMain.Size = new System.Drawing.Size(1257, 780);
            this.panelMain.TabIndex = 2;
            // 
            // lblInsumosTitle
            // 
            this.lblInsumosTitle.AutoSize = true;
            this.lblInsumosTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblInsumosTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.lblInsumosTitle.Location = new System.Drawing.Point(34, 20);
            this.lblInsumosTitle.Name = "lblInsumosTitle";
            this.lblInsumosTitle.Size = new System.Drawing.Size(244, 41);
            this.lblInsumosTitle.TabIndex = 0;
            this.lblInsumosTitle.Text = "Control de Insumos";
            // 
            // panelResumen
            // 
            this.panelResumen.Controls.Add(this.cardConsumos);
            this.panelResumen.Controls.Add(this.cardEntradas);
            this.panelResumen.Controls.Add(this.cardCritico);
            this.panelResumen.Controls.Add(this.cardTotal);
            this.panelResumen.Location = new System.Drawing.Point(34, 80);
            this.panelResumen.Name = "panelResumen";
            this.panelResumen.Size = new System.Drawing.Size(1189, 120);
            this.panelResumen.TabIndex = 1;
            // 
            // cardConsumos
            // 
            this.cardConsumos.BackColor = System.Drawing.Color.White;
            this.cardConsumos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardConsumos.Controls.Add(this.lblConsumosValor);
            this.cardConsumos.Controls.Add(this.lblConsumosTitulo);
            this.cardConsumos.Location = new System.Drawing.Point(900, 10);
            this.cardConsumos.Name = "cardConsumos";
            this.cardConsumos.Size = new System.Drawing.Size(280, 100);
            this.cardConsumos.TabIndex = 3;
            // 
            // lblConsumosValor
            // 
            this.lblConsumosValor.AutoSize = true;
            this.lblConsumosValor.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblConsumosValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblConsumosValor.Location = new System.Drawing.Point(20, 40);
            this.lblConsumosValor.Name = "lblConsumosValor";
            this.lblConsumosValor.Size = new System.Drawing.Size(65, 54);
            this.lblConsumosValor.TabIndex = 1;
            this.lblConsumosValor.Text = "0";
            // 
            // lblConsumosTitulo
            // 
            this.lblConsumosTitulo.AutoSize = true;
            this.lblConsumosTitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblConsumosTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblConsumosTitulo.Location = new System.Drawing.Point(20, 10);
            this.lblConsumosTitulo.Name = "lblConsumosTitulo";
            this.lblConsumosTitulo.Size = new System.Drawing.Size(99, 23);
            this.lblConsumosTitulo.TabIndex = 0;
            this.lblConsumosTitulo.Text = "Consumos";
            // 
            // cardEntradas
            // 
            this.cardEntradas.BackColor = System.Drawing.Color.White;
            this.cardEntradas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardEntradas.Controls.Add(this.lblEntradasValor);
            this.cardEntradas.Controls.Add(this.lblEntradasTitulo);
            this.cardEntradas.Location = new System.Drawing.Point(600, 10);
            this.cardEntradas.Name = "cardEntradas";
            this.cardEntradas.Size = new System.Drawing.Size(280, 100);
            this.cardEntradas.TabIndex = 2;
            // 
            // lblEntradasValor
            // 
            this.lblEntradasValor.AutoSize = true;
            this.lblEntradasValor.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblEntradasValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(62)))));
            this.lblEntradasValor.Location = new System.Drawing.Point(20, 40);
            this.lblEntradasValor.Name = "lblEntradasValor";
            this.lblEntradasValor.Size = new System.Drawing.Size(65, 54);
            this.lblEntradasValor.TabIndex = 1;
            this.lblEntradasValor.Text = "0";
            // 
            // lblEntradasTitulo
            // 
            this.lblEntradasTitulo.AutoSize = true;
            this.lblEntradasTitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEntradasTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblEntradasTitulo.Location = new System.Drawing.Point(20, 10);
            this.lblEntradasTitulo.Name = "lblEntradasTitulo";
            this.lblEntradasTitulo.Size = new System.Drawing.Size(86, 23);
            this.lblEntradasTitulo.TabIndex = 0;
            this.lblEntradasTitulo.Text = "Entradas";
            // 
            // cardCritico
            // 
            this.cardCritico.BackColor = System.Drawing.Color.White;
            this.cardCritico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardCritico.Controls.Add(this.lblCriticoValor);
            this.cardCritico.Controls.Add(this.lblCriticoTitulo);
            this.cardCritico.Location = new System.Drawing.Point(300, 10);
            this.cardCritico.Name = "cardCritico";
            this.cardCritico.Size = new System.Drawing.Size(280, 100);
            this.cardCritico.TabIndex = 1;
            // 
            // lblCriticoValor
            // 
            this.lblCriticoValor.AutoSize = true;
            this.lblCriticoValor.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblCriticoValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.lblCriticoValor.Location = new System.Drawing.Point(20, 40);
            this.lblCriticoValor.Name = "lblCriticoValor";
            this.lblCriticoValor.Size = new System.Drawing.Size(65, 54);
            this.lblCriticoValor.TabIndex = 1;
            this.lblCriticoValor.Text = "0";
            // 
            // lblCriticoTitulo
            // 
            this.lblCriticoTitulo.AutoSize = true;
            this.lblCriticoTitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCriticoTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblCriticoTitulo.Location = new System.Drawing.Point(20, 10);
            this.lblCriticoTitulo.Name = "lblCriticoTitulo";
            this.lblCriticoTitulo.Size = new System.Drawing.Size(129, 23);
            this.lblCriticoTitulo.TabIndex = 0;
            this.lblCriticoTitulo.Text = "Stock Crítico";
            // 
            // cardTotal
            // 
            this.cardTotal.BackColor = System.Drawing.Color.White;
            this.cardTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardTotal.Controls.Add(this.lblTotalValor);
            this.cardTotal.Controls.Add(this.lblTotalTitulo);
            this.cardTotal.Location = new System.Drawing.Point(0, 10);
            this.cardTotal.Name = "cardTotal";
            this.cardTotal.Size = new System.Drawing.Size(280, 100);
            this.cardTotal.TabIndex = 0;
            // 
            // lblTotalValor
            // 
            this.lblTotalValor.AutoSize = true;
            this.lblTotalValor.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTotalValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblTotalValor.Location = new System.Drawing.Point(20, 40);
            this.lblTotalValor.Name = "lblTotalValor";
            this.lblTotalValor.Size = new System.Drawing.Size(65, 54);
            this.lblTotalValor.TabIndex = 1;
            this.lblTotalValor.Text = "0";
            // 
            // lblTotalTitulo
            // 
            this.lblTotalTitulo.AutoSize = true;
            this.lblTotalTitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblTotalTitulo.Location = new System.Drawing.Point(20, 10);
            this.lblTotalTitulo.Name = "lblTotalTitulo";
            this.lblTotalTitulo.Size = new System.Drawing.Size(138, 23);
            this.lblTotalTitulo.TabIndex = 0;
            this.lblTotalTitulo.Text = "Total Insumos";
            // 
            // panelBotones
            // 
            this.panelBotones.Controls.Add(this.btnVerRecetas);
            this.panelBotones.Controls.Add(this.btnRegistrarMovimiento);
            this.panelBotones.Location = new System.Drawing.Point(34, 210);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(1189, 60);
            this.panelBotones.TabIndex = 2;
            // 
            // btnVerRecetas
            // 
            this.btnVerRecetas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.btnVerRecetas.FlatAppearance.BorderSize = 0;
            this.btnVerRecetas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerRecetas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnVerRecetas.ForeColor = System.Drawing.Color.White;
            this.btnVerRecetas.Location = new System.Drawing.Point(260, 5);
            this.btnVerRecetas.Name = "btnVerRecetas";
            this.btnVerRecetas.Size = new System.Drawing.Size(230, 50);
            this.btnVerRecetas.TabIndex = 1;
            this.btnVerRecetas.Text = "📋 Ver Recetas";
            this.btnVerRecetas.UseVisualStyleBackColor = false;
            this.btnVerRecetas.Click += new System.EventHandler(this.btnVerRecetas_Click);
            // 
            // btnRegistrarMovimiento
            // 
            this.btnRegistrarMovimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(62)))));
            this.btnRegistrarMovimiento.FlatAppearance.BorderSize = 0;
            this.btnRegistrarMovimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarMovimiento.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnRegistrarMovimiento.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarMovimiento.Location = new System.Drawing.Point(0, 5);
            this.btnRegistrarMovimiento.Name = "btnRegistrarMovimiento";
            this.btnRegistrarMovimiento.Size = new System.Drawing.Size(250, 50);
            this.btnRegistrarMovimiento.TabIndex = 0;
            this.btnRegistrarMovimiento.Text = "+ Registrar Movimiento";
            this.btnRegistrarMovimiento.UseVisualStyleBackColor = false;
            this.btnRegistrarMovimiento.Click += new System.EventHandler(this.btnRegistrarMovimiento_Click);
            // 
            // panelInventario
            // 
            this.panelInventario.BackColor = System.Drawing.Color.White;
            this.panelInventario.Controls.Add(this.dgvInventario);
            this.panelInventario.Controls.Add(this.lblInventarioTitulo);
            this.panelInventario.Location = new System.Drawing.Point(34, 280);
            this.panelInventario.Name = "panelInventario";
            this.panelInventario.Padding = new System.Windows.Forms.Padding(30);
            this.panelInventario.Size = new System.Drawing.Size(1189, 280);
            this.panelInventario.TabIndex = 3;
            // 
            // dgvInventario
            // 
            this.dgvInventario.AllowUserToAddRows = false;
            this.dgvInventario.AllowUserToDeleteRows = false;
            this.dgvInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventario.BackgroundColor = System.Drawing.Color.White;
            this.dgvInventario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Location = new System.Drawing.Point(30, 70);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.ReadOnly = true;
            this.dgvInventario.RowHeadersVisible = false;
            this.dgvInventario.RowHeadersWidth = 51;
            this.dgvInventario.Size = new System.Drawing.Size(1129, 180);
            this.dgvInventario.TabIndex = 1;
            // 
            // lblInventarioTitulo
            // 
            this.lblInventarioTitulo.AutoSize = true;
            this.lblInventarioTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblInventarioTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.lblInventarioTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblInventarioTitulo.Name = "lblInventarioTitulo";
            this.lblInventarioTitulo.Size = new System.Drawing.Size(210, 32);
            this.lblInventarioTitulo.TabIndex = 0;
            this.lblInventarioTitulo.Text = "Inventario de Insumos";
            // 
            // panelHistorial
            // 
            this.panelHistorial.BackColor = System.Drawing.Color.White;
            this.panelHistorial.Controls.Add(this.dgvHistorial);
            this.panelHistorial.Controls.Add(this.lblHistorialTitulo);
            this.panelHistorial.Location = new System.Drawing.Point(34, 570);
            this.panelHistorial.Name = "panelHistorial";
            this.panelHistorial.Padding = new System.Windows.Forms.Padding(30);
            this.panelHistorial.Size = new System.Drawing.Size(1189, 280);
            this.panelHistorial.TabIndex = 4;
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.AllowUserToAddRows = false;
            this.dgvHistorial.AllowUserToDeleteRows = false;
            this.dgvHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistorial.BackgroundColor = System.Drawing.Color.White;
            this.dgvHistorial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.Location = new System.Drawing.Point(30, 70);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.ReadOnly = true;
            this.dgvHistorial.RowHeadersVisible = false;
            this.dgvHistorial.RowHeadersWidth = 51;
            this.dgvHistorial.Size = new System.Drawing.Size(1129, 180);
            this.dgvHistorial.TabIndex = 1;
            // 
            // lblHistorialTitulo
            // 
            this.lblHistorialTitulo.AutoSize = true;
            this.lblHistorialTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblHistorialTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.lblHistorialTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblHistorialTitulo.Name = "lblHistorialTitulo";
            this.lblHistorialTitulo.Size = new System.Drawing.Size(239, 32);
            this.lblHistorialTitulo.TabIndex = 0;
            this.lblHistorialTitulo.Text = "Historial de Movimientos";
            // 
            // panelNuevoMovimiento
            // 
            this.panelNuevoMovimiento.BackColor = System.Drawing.Color.White;
            this.panelNuevoMovimiento.Controls.Add(this.btnCancelarMovimiento);
            this.panelNuevoMovimiento.Controls.Add(this.btnRegistrarMovimientoConfirmar);
            this.panelNuevoMovimiento.Controls.Add(this.txtObservaciones);
            this.panelNuevoMovimiento.Controls.Add(this.lblObservaciones);
            this.panelNuevoMovimiento.Controls.Add(this.txtCantidadMovimiento);
            this.panelNuevoMovimiento.Controls.Add(this.lblCantidadMovimiento);
            this.panelNuevoMovimiento.Controls.Add(this.cmbTipoMovimiento);
            this.panelNuevoMovimiento.Controls.Add(this.lblTipoMovimiento);
            this.panelNuevoMovimiento.Controls.Add(this.cmbInsumoMovimiento);
            this.panelNuevoMovimiento.Controls.Add(this.lblInsumoMovimiento);
            this.panelNuevoMovimiento.Controls.Add(this.lblNuevoMovimientoTitulo);
            this.panelNuevoMovimiento.Location = new System.Drawing.Point(34, 280);
            this.panelNuevoMovimiento.Name = "panelNuevoMovimiento";
            this.panelNuevoMovimiento.Padding = new System.Windows.Forms.Padding(30);
            this.panelNuevoMovimiento.Size = new System.Drawing.Size(1189, 300);
            this.panelNuevoMovimiento.TabIndex = 5;
            this.panelNuevoMovimiento.Visible = false;
            // 
            // btnCancelarMovimiento
            // 
            this.btnCancelarMovimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnCancelarMovimiento.FlatAppearance.BorderSize = 0;
            this.btnCancelarMovimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarMovimiento.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCancelarMovimiento.ForeColor = System.Drawing.Color.White;
            this.btnCancelarMovimiento.Location = new System.Drawing.Point(170, 230);
            this.btnCancelarMovimiento.Name = "btnCancelarMovimiento";
            this.btnCancelarMovimiento.Size = new System.Drawing.Size(150, 45);
            this.btnCancelarMovimiento.TabIndex = 10;
            this.btnCancelarMovimiento.Text = "Cancelar";
            this.btnCancelarMovimiento.UseVisualStyleBackColor = false;
            this.btnCancelarMovimiento.Click += new System.EventHandler(this.btnCancelarMovimiento_Click);
            // 
            // btnRegistrarMovimientoConfirmar
            // 
            this.btnRegistrarMovimientoConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(62)))));
            this.btnRegistrarMovimientoConfirmar.FlatAppearance.BorderSize = 0;
            this.btnRegistrarMovimientoConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarMovimientoConfirmar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnRegistrarMovimientoConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarMovimientoConfirmar.Location = new System.Drawing.Point(30, 230);
            this.btnRegistrarMovimientoConfirmar.Name = "btnRegistrarMovimientoConfirmar";
            this.btnRegistrarMovimientoConfirmar.Size = new System.Drawing.Size(130, 45);
            this.btnRegistrarMovimientoConfirmar.TabIndex = 9;
            this.btnRegistrarMovimientoConfirmar.Text = "Registrar";
            this.btnRegistrarMovimientoConfirmar.UseVisualStyleBackColor = false;
            this.btnRegistrarMovimientoConfirmar.Click += new System.EventHandler(this.btnRegistrarMovimientoConfirmar_Click);
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtObservaciones.Location = new System.Drawing.Point(30, 170);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.PlaceholderText = "Observaciones (opcional)";
            this.txtObservaciones.Size = new System.Drawing.Size(1129, 50);
            this.txtObservaciones.TabIndex = 8;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblObservaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblObservaciones.Location = new System.Drawing.Point(30, 140);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(128, 23);
            this.lblObservaciones.TabIndex = 7;
            this.lblObservaciones.Text = "Observaciones";
            // 
            // txtCantidadMovimiento
            // 
            this.txtCantidadMovimiento.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCantidadMovimiento.Location = new System.Drawing.Point(630, 100);
            this.txtCantidadMovimiento.Name = "txtCantidadMovimiento";
            this.txtCantidadMovimiento.PlaceholderText = "Cantidad";
            this.txtCantidadMovimiento.Size = new System.Drawing.Size(529, 34);
            this.txtCantidadMovimiento.TabIndex = 6;
            // 
            // lblCantidadMovimiento
            // 
            this.lblCantidadMovimiento.AutoSize = true;
            this.lblCantidadMovimiento.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCantidadMovimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblCantidadMovimiento.Location = new System.Drawing.Point(630, 70);
            this.lblCantidadMovimiento.Name = "lblCantidadMovimiento";
            this.lblCantidadMovimiento.Size = new System.Drawing.Size(83, 23);
            this.lblCantidadMovimiento.TabIndex = 5;
            this.lblCantidadMovimiento.Text = "Cantidad";
            // 
            // cmbTipoMovimiento
            // 
            this.cmbTipoMovimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoMovimiento.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbTipoMovimiento.FormattingEnabled = true;
            this.cmbTipoMovimiento.Items.AddRange(new object[] {
            "Entrada",
            "Consumo"});
            this.cmbTipoMovimiento.Location = new System.Drawing.Point(30, 100);
            this.cmbTipoMovimiento.Name = "cmbTipoMovimiento";
            this.cmbTipoMovimiento.Size = new System.Drawing.Size(574, 36);
            this.cmbTipoMovimiento.TabIndex = 4;
            // 
            // lblTipoMovimiento
            // 
            this.lblTipoMovimiento.AutoSize = true;
            this.lblTipoMovimiento.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTipoMovimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblTipoMovimiento.Location = new System.Drawing.Point(30, 70);
            this.lblTipoMovimiento.Name = "lblTipoMovimiento";
            this.lblTipoMovimiento.Size = new System.Drawing.Size(151, 23);
            this.lblTipoMovimiento.TabIndex = 3;
            this.lblTipoMovimiento.Text = "Tipo de Movimiento";
            // 
            // cmbInsumoMovimiento
            // 
            this.cmbInsumoMovimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInsumoMovimiento.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbInsumoMovimiento.FormattingEnabled = true;
            this.cmbInsumoMovimiento.Location = new System.Drawing.Point(30, 40);
            this.cmbInsumoMovimiento.Name = "cmbInsumoMovimiento";
            this.cmbInsumoMovimiento.Size = new System.Drawing.Size(1129, 36);
            this.cmbInsumoMovimiento.TabIndex = 2;
            // 
            // lblInsumoMovimiento
            // 
            this.lblInsumoMovimiento.AutoSize = true;
            this.lblInsumoMovimiento.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblInsumoMovimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblInsumoMovimiento.Location = new System.Drawing.Point(30, 10);
            this.lblInsumoMovimiento.Name = "lblInsumoMovimiento";
            this.lblInsumoMovimiento.Size = new System.Drawing.Size(67, 23);
            this.lblInsumoMovimiento.TabIndex = 1;
            this.lblInsumoMovimiento.Text = "Insumo";
            // 
            // lblNuevoMovimientoTitulo
            // 
            this.lblNuevoMovimientoTitulo.AutoSize = true;
            this.lblNuevoMovimientoTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblNuevoMovimientoTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.lblNuevoMovimientoTitulo.Location = new System.Drawing.Point(0, -20);
            this.lblNuevoMovimientoTitulo.Name = "lblNuevoMovimientoTitulo";
            this.lblNuevoMovimientoTitulo.Size = new System.Drawing.Size(272, 32);
            this.lblNuevoMovimientoTitulo.TabIndex = 0;
            this.lblNuevoMovimientoTitulo.Text = "Registrar Movimiento";
            // 
            // panelRecetas
            // 
            this.panelRecetas.BackColor = System.Drawing.Color.White;
            this.panelRecetas.Controls.Add(this.btnCerrarRecetas);
            this.panelRecetas.Controls.Add(this.panelRecetaGalpon358);
            this.panelRecetas.Controls.Add(this.panelRecetaGalpon687);
            this.panelRecetas.Controls.Add(this.panelRecetaGalpon4);
            this.panelRecetas.Controls.Add(this.lblRecetasTitulo);
            this.panelRecetas.Location = new System.Drawing.Point(34, 280);
            this.panelRecetas.Name = "panelRecetas";
            this.panelRecetas.Padding = new System.Windows.Forms.Padding(30);
            this.panelRecetas.Size = new System.Drawing.Size(1189, 570);
            this.panelRecetas.TabIndex = 6;
            this.panelRecetas.Visible = false;
            // 
            // lblRecetasTitulo
            // 
            this.lblRecetasTitulo.AutoSize = true;
            this.lblRecetasTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblRecetasTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.lblRecetasTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblRecetasTitulo.Name = "lblRecetasTitulo";
            this.lblRecetasTitulo.Size = new System.Drawing.Size(204, 32);
            this.lblRecetasTitulo.TabIndex = 0;
            this.lblRecetasTitulo.Text = "Recetas por Galpón";
            // 
            // panelRecetaGalpon4
            // 
            this.panelRecetaGalpon4.Controls.Add(this.dgvRecetaGalpon4);
            this.panelRecetaGalpon4.Controls.Add(this.lblRecetaGalpon4Titulo);
            this.panelRecetaGalpon4.Location = new System.Drawing.Point(30, 50);
            this.panelRecetaGalpon4.Name = "panelRecetaGalpon4";
            this.panelRecetaGalpon4.Size = new System.Drawing.Size(350, 480);
            this.panelRecetaGalpon4.TabIndex = 1;
            // 
            // lblRecetaGalpon4Titulo
            // 
            this.lblRecetaGalpon4Titulo.AutoSize = true;
            this.lblRecetaGalpon4Titulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblRecetaGalpon4Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.lblRecetaGalpon4Titulo.Location = new System.Drawing.Point(0, 0);
            this.lblRecetaGalpon4Titulo.Name = "lblRecetaGalpon4Titulo";
            this.lblRecetaGalpon4Titulo.Size = new System.Drawing.Size(114, 28);
            this.lblRecetaGalpon4Titulo.TabIndex = 0;
            this.lblRecetaGalpon4Titulo.Text = "Galpón 4";
            // 
            // dgvRecetaGalpon4
            // 
            this.dgvRecetaGalpon4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecetaGalpon4.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecetaGalpon4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRecetaGalpon4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecetaGalpon4.Location = new System.Drawing.Point(0, 40);
            this.dgvRecetaGalpon4.Name = "dgvRecetaGalpon4";
            this.dgvRecetaGalpon4.RowHeadersVisible = false;
            this.dgvRecetaGalpon4.RowHeadersWidth = 51;
            this.dgvRecetaGalpon4.Size = new System.Drawing.Size(350, 440);
            this.dgvRecetaGalpon4.TabIndex = 1;
            // 
            // panelRecetaGalpon687
            // 
            this.panelRecetaGalpon687.Controls.Add(this.dgvRecetaGalpon687);
            this.panelRecetaGalpon687.Controls.Add(this.lblRecetaGalpon687Titulo);
            this.panelRecetaGalpon687.Location = new System.Drawing.Point(410, 50);
            this.panelRecetaGalpon687.Name = "panelRecetaGalpon687";
            this.panelRecetaGalpon687.Size = new System.Drawing.Size(350, 480);
            this.panelRecetaGalpon687.TabIndex = 2;
            // 
            // lblRecetaGalpon687Titulo
            // 
            this.lblRecetaGalpon687Titulo.AutoSize = true;
            this.lblRecetaGalpon687Titulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblRecetaGalpon687Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.lblRecetaGalpon687Titulo.Location = new System.Drawing.Point(0, 0);
            this.lblRecetaGalpon687Titulo.Name = "lblRecetaGalpon687Titulo";
            this.lblRecetaGalpon687Titulo.Size = new System.Drawing.Size(143, 28);
            this.lblRecetaGalpon687Titulo.Text = "Galpón 6-8-7";
            // 
            // dgvRecetaGalpon687
            // 
            this.dgvRecetaGalpon687.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecetaGalpon687.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecetaGalpon687.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRecetaGalpon687.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecetaGalpon687.Location = new System.Drawing.Point(0, 40);
            this.dgvRecetaGalpon687.Name = "dgvRecetaGalpon687";
            this.dgvRecetaGalpon687.RowHeadersVisible = false;
            this.dgvRecetaGalpon687.RowHeadersWidth = 51;
            this.dgvRecetaGalpon687.Size = new System.Drawing.Size(350, 440);
            this.dgvRecetaGalpon687.TabIndex = 1;
            // 
            // panelRecetaGalpon358
            // 
            this.panelRecetaGalpon358.Controls.Add(this.dgvRecetaGalpon358);
            this.panelRecetaGalpon358.Controls.Add(this.lblRecetaGalpon358Titulo);
            this.panelRecetaGalpon358.Location = new System.Drawing.Point(790, 50);
            this.panelRecetaGalpon358.Name = "panelRecetaGalpon358";
            this.panelRecetaGalpon358.Size = new System.Drawing.Size(350, 480);
            this.panelRecetaGalpon358.TabIndex = 3;
            // 
            // lblRecetaGalpon358Titulo
            // 
            this.lblRecetaGalpon358Titulo.AutoSize = true;
            this.lblRecetaGalpon358Titulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblRecetaGalpon358Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.lblRecetaGalpon358Titulo.Location = new System.Drawing.Point(0, 0);
            this.lblRecetaGalpon358Titulo.Name = "lblRecetaGalpon358Titulo";
            this.lblRecetaGalpon358Titulo.Size = new System.Drawing.Size(143, 28);
            this.lblRecetaGalpon358Titulo.Text = "Galpón 3-5-8";
            // 
            // dgvRecetaGalpon358
            // 
            this.dgvRecetaGalpon358.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecetaGalpon358.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecetaGalpon358.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRecetaGalpon358.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecetaGalpon358.Location = new System.Drawing.Point(0, 40);
            this.dgvRecetaGalpon358.Name = "dgvRecetaGalpon358";
            this.dgvRecetaGalpon358.RowHeadersVisible = false;
            this.dgvRecetaGalpon358.RowHeadersWidth = 51;
            this.dgvRecetaGalpon358.Size = new System.Drawing.Size(350, 440);
            this.dgvRecetaGalpon358.TabIndex = 1;
            // 
            // btnCerrarRecetas
            // 
            this.btnCerrarRecetas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnCerrarRecetas.FlatAppearance.BorderSize = 0;
            this.btnCerrarRecetas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarRecetas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCerrarRecetas.ForeColor = System.Drawing.Color.White;
            this.btnCerrarRecetas.Location = new System.Drawing.Point(1029, 0);
            this.btnCerrarRecetas.Name = "btnCerrarRecetas";
            this.btnCerrarRecetas.Size = new System.Drawing.Size(130, 40);
            this.btnCerrarRecetas.TabIndex = 4;
            this.btnCerrarRecetas.Text = "Cerrar";
            this.btnCerrarRecetas.UseVisualStyleBackColor = false;
            this.btnCerrarRecetas.Click += new System.EventHandler(this.btnCerrarRecetas_Click);
            // 
            // Insumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 933);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelNav);
            this.Controls.Add(this.panelHeader);
            this.Name = "Insumos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insumos - Rancho del Buen Pastor";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelNav.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelResumen.ResumeLayout(false);
            this.cardConsumos.ResumeLayout(false);
            this.cardConsumos.PerformLayout();
            this.cardEntradas.ResumeLayout(false);
            this.cardEntradas.PerformLayout();
            this.cardCritico.ResumeLayout(false);
            this.cardCritico.PerformLayout();
            this.cardTotal.ResumeLayout(false);
            this.cardTotal.PerformLayout();
            this.panelBotones.ResumeLayout(false);
            this.panelInventario.ResumeLayout(false);
            this.panelInventario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.panelHistorial.ResumeLayout(false);
            this.panelHistorial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.panelNuevoMovimiento.ResumeLayout(false);
            this.panelNuevoMovimiento.PerformLayout();
            this.panelRecetas.ResumeLayout(false);
            this.panelRecetas.PerformLayout();
            this.panelRecetaGalpon4.ResumeLayout(false);
            this.panelRecetaGalpon4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecetaGalpon4)).EndInit();
            this.panelRecetaGalpon687.ResumeLayout(false);
            this.panelRecetaGalpon687.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecetaGalpon687)).EndInit();
            this.panelRecetaGalpon358.ResumeLayout(false);
            this.panelRecetaGalpon358.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecetaGalpon358)).EndInit();
            this.ResumeLayout(false);
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
