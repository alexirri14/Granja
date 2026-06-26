namespace Granja
{
    partial class Reportes
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
            lblReportesTitle = new Label();
            panelTabs = new Panel();
            btnReporteOrdenes = new Button();
            btnReporteProduccion = new Button();
            btnReporteDistribucion = new Button();
            btnReporteMovimientosInsumos = new Button();
            panelContenido = new Panel();
            panelReporte = new Panel();
            panelFiltros = new Panel();
            btnExportarPdf = new Button();
            btnExportarExcel = new Button();
            btnLimpiarFiltros = new Button();
            cmbCategoria = new ComboBox();
            lblFiltroCategoria = new Label();
            dtpHasta = new DateTimePicker();
            lblFiltroHasta = new Label();
            dtpDesde = new DateTimePicker();
            lblFiltroDesde = new Label();
            lblDescripcionReporte = new Label();
            lblTituloReporte = new Label();
            splitReporte = new SplitContainer();
            picGrafico = new PictureBox();
            lblResumen = new Label();
            dgvReporte = new DataGridView();
            panelHeader.SuspendLayout();
            panelNav.SuspendLayout();
            panelMain.SuspendLayout();
            panelTabs.SuspendLayout();
            panelContenido.SuspendLayout();
            panelReporte.SuspendLayout();
            panelFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitReporte).BeginInit();
            splitReporte.Panel1.SuspendLayout();
            splitReporte.Panel2.SuspendLayout();
            splitReporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picGrafico).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).BeginInit();
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
            btnReportes.ForeColor = Color.FromArgb(0, 125, 62);
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
            panelMain.Controls.Add(lblReportesTitle);
            panelMain.Controls.Add(panelTabs);
            panelMain.Controls.Add(panelContenido);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 153);
            panelMain.Margin = new Padding(3, 4, 3, 4);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(34, 40, 34, 40);
            panelMain.Size = new Size(1257, 780);
            panelMain.TabIndex = 2;
            // 
            // lblReportesTitle
            // 
            lblReportesTitle.AutoSize = true;
            lblReportesTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblReportesTitle.ForeColor = Color.FromArgb(26, 32, 44);
            lblReportesTitle.Location = new Point(34, 20);
            lblReportesTitle.Name = "lblReportesTitle";
            lblReportesTitle.Size = new Size(144, 41);
            lblReportesTitle.TabIndex = 0;
            lblReportesTitle.Text = "Centro de Reportes";
            // 
            // panelTabs
            // 
            panelTabs.BackColor = Color.White;
            panelTabs.Controls.Add(btnReporteDistribucion);
            panelTabs.Controls.Add(btnReporteProduccion);
            panelTabs.Controls.Add(btnReporteOrdenes);
            panelTabs.Controls.Add(btnReporteMovimientosInsumos);
            panelTabs.Location = new Point(34, 100);
            panelTabs.Margin = new Padding(3, 4, 3, 4);
            panelTabs.Name = "panelTabs";
            panelTabs.Padding = new Padding(20);
            panelTabs.Size = new Size(1189, 90);
            panelTabs.TabIndex = 1;
            // 
            // btnReporteDistribucion
            // 
            btnReporteDistribucion.BackColor = Color.FromArgb(230, 230, 230);
            btnReporteDistribucion.FlatAppearance.BorderSize = 0;
            btnReporteDistribucion.FlatStyle = FlatStyle.Flat;
            btnReporteDistribucion.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnReporteDistribucion.ForeColor = Color.FromArgb(44, 62, 80);
            btnReporteDistribucion.Location = new Point(579, 18);
            btnReporteDistribucion.Name = "btnReporteDistribucion";
            btnReporteDistribucion.Size = new Size(175, 40);
            btnReporteDistribucion.TabIndex = 3;
            btnReporteDistribucion.Text = "Distribución";
            btnReporteDistribucion.UseVisualStyleBackColor = false;
            // 
            // btnReporteProduccion
            // 
            btnReporteProduccion.BackColor = Color.FromArgb(230, 230, 230);
            btnReporteProduccion.FlatAppearance.BorderSize = 0;
            btnReporteProduccion.FlatStyle = FlatStyle.Flat;
            btnReporteProduccion.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnReporteProduccion.ForeColor = Color.FromArgb(44, 62, 80);
            btnReporteProduccion.Location = new Point(392, 18);
            btnReporteProduccion.Name = "btnReporteProduccion";
            btnReporteProduccion.Size = new Size(175, 40);
            btnReporteProduccion.TabIndex = 2;
            btnReporteProduccion.Text = "Producción";
            btnReporteProduccion.UseVisualStyleBackColor = false;
            // 
            // btnReporteOrdenes
            // 
            btnReporteOrdenes.BackColor = Color.FromArgb(230, 230, 230);
            btnReporteOrdenes.FlatAppearance.BorderSize = 0;
            btnReporteOrdenes.FlatStyle = FlatStyle.Flat;
            btnReporteOrdenes.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnReporteOrdenes.ForeColor = Color.FromArgb(44, 62, 80);
            btnReporteOrdenes.Location = new Point(205, 18);
            btnReporteOrdenes.Name = "btnReporteOrdenes";
            btnReporteOrdenes.Size = new Size(175, 40);
            btnReporteOrdenes.TabIndex = 1;
            btnReporteOrdenes.Text = "Órdenes";
            btnReporteOrdenes.UseVisualStyleBackColor = false;
            // 
            // btnReporteMovimientosInsumos
            // 
            btnReporteMovimientosInsumos.BackColor = Color.FromArgb(0, 125, 62);
            btnReporteMovimientosInsumos.FlatAppearance.BorderSize = 0;
            btnReporteMovimientosInsumos.FlatStyle = FlatStyle.Flat;
            btnReporteMovimientosInsumos.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnReporteMovimientosInsumos.ForeColor = Color.White;
            btnReporteMovimientosInsumos.Location = new Point(18, 18);
            btnReporteMovimientosInsumos.Name = "btnReporteMovimientosInsumos";
            btnReporteMovimientosInsumos.Size = new Size(175, 40);
            btnReporteMovimientosInsumos.TabIndex = 0;
            btnReporteMovimientosInsumos.Text = "Mov. insumos";
            btnReporteMovimientosInsumos.UseVisualStyleBackColor = false;
            // 
            // panelContenido
            // 
            panelContenido.Controls.Add(panelReporte);
            panelContenido.Location = new Point(34, 197);
            panelContenido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(1189, 543);
            panelContenido.TabIndex = 2;
            // 
            // panelReporte
            // 
            panelReporte.BackColor = Color.White;
            panelReporte.Controls.Add(splitReporte);
            panelReporte.Controls.Add(panelFiltros);
            panelReporte.Dock = DockStyle.Fill;
            panelReporte.Location = new Point(0, 0);
            panelReporte.Name = "panelReporte";
            panelReporte.Padding = new Padding(16);
            panelReporte.Size = new Size(1189, 553);
            panelReporte.TabIndex = 0;
            // 
            // panelFiltros
            // 
            panelFiltros.BackColor = Color.WhiteSmoke;
            panelFiltros.Controls.Add(btnExportarPdf);
            panelFiltros.Controls.Add(btnExportarExcel);
            panelFiltros.Controls.Add(btnLimpiarFiltros);
            panelFiltros.Controls.Add(cmbCategoria);
            panelFiltros.Controls.Add(lblFiltroCategoria);
            panelFiltros.Controls.Add(dtpHasta);
            panelFiltros.Controls.Add(lblFiltroHasta);
            panelFiltros.Controls.Add(dtpDesde);
            panelFiltros.Controls.Add(lblFiltroDesde);
            panelFiltros.Controls.Add(lblDescripcionReporte);
            panelFiltros.Controls.Add(lblTituloReporte);
            panelFiltros.Dock = DockStyle.Top;
            panelFiltros.Location = new Point(16, 16);
            panelFiltros.Name = "panelFiltros";
            panelFiltros.Size = new Size(1157, 122);
            panelFiltros.TabIndex = 0;
            // 
            // btnExportarPdf
            // 
            btnExportarPdf.Location = new Point(1010, 70);
            btnExportarPdf.Name = "btnExportarPdf";
            btnExportarPdf.Size = new Size(140, 34);
            btnExportarPdf.TabIndex = 10;
            btnExportarPdf.Text = "Exportar PDF";
            btnExportarPdf.UseVisualStyleBackColor = true;
            // 
            // btnExportarExcel
            // 
            btnExportarExcel.Location = new Point(856, 70);
            btnExportarExcel.Name = "btnExportarExcel";
            btnExportarExcel.Size = new Size(140, 34);
            btnExportarExcel.TabIndex = 9;
            btnExportarExcel.Text = "Exportar Excel";
            btnExportarExcel.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarFiltros
            // 
            btnLimpiarFiltros.Location = new Point(705, 70);
            btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            btnLimpiarFiltros.Size = new Size(130, 34);
            btnLimpiarFiltros.TabIndex = 8;
            btnLimpiarFiltros.Text = "Limpiar filtros";
            btnLimpiarFiltros.UseVisualStyleBackColor = true;
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(475, 74);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(210, 28);
            cmbCategoria.TabIndex = 7;
            // 
            // lblFiltroCategoria
            // 
            lblFiltroCategoria.AutoSize = true;
            lblFiltroCategoria.Location = new Point(400, 78);
            lblFiltroCategoria.Name = "lblFiltroCategoria";
            lblFiltroCategoria.Size = new Size(69, 20);
            lblFiltroCategoria.TabIndex = 6;
            lblFiltroCategoria.Text = "Categoría";
            // 
            // dtpHasta
            // 
            dtpHasta.Format = DateTimePickerFormat.Short;
            dtpHasta.Location = new Point(258, 74);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(120, 27);
            dtpHasta.TabIndex = 5;
            // 
            // lblFiltroHasta
            // 
            lblFiltroHasta.AutoSize = true;
            lblFiltroHasta.Location = new Point(208, 78);
            lblFiltroHasta.Name = "lblFiltroHasta";
            lblFiltroHasta.Size = new Size(45, 20);
            lblFiltroHasta.TabIndex = 4;
            lblFiltroHasta.Text = "Hasta";
            // 
            // dtpDesde
            // 
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.Location = new Point(70, 74);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(120, 27);
            dtpDesde.TabIndex = 3;
            // 
            // lblFiltroDesde
            // 
            lblFiltroDesde.AutoSize = true;
            lblFiltroDesde.Location = new Point(18, 78);
            lblFiltroDesde.Name = "lblFiltroDesde";
            lblFiltroDesde.Size = new Size(48, 20);
            lblFiltroDesde.TabIndex = 2;
            lblFiltroDesde.Text = "Desde";
            // 
            // lblDescripcionReporte
            // 
            lblDescripcionReporte.AutoSize = true;
            lblDescripcionReporte.Location = new Point(18, 48);
            lblDescripcionReporte.Name = "lblDescripcionReporte";
            lblDescripcionReporte.Size = new Size(144, 20);
            lblDescripcionReporte.TabIndex = 1;
            lblDescripcionReporte.Text = "Consulta filtros y visualiza el resumen.";
            // 
            // lblTituloReporte
            // 
            lblTituloReporte.AutoSize = true;
            lblTituloReporte.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTituloReporte.Location = new Point(16, 12);
            lblTituloReporte.Name = "lblTituloReporte";
            lblTituloReporte.Size = new Size(173, 32);
            lblTituloReporte.TabIndex = 0;
            lblTituloReporte.Text = "Movimientos de insumos";
            // 
            // splitReporte
            // 
            splitReporte.Dock = DockStyle.Fill;
            splitReporte.Location = new Point(16, 138);
            splitReporte.Name = "splitReporte";
            splitReporte.Orientation = Orientation.Horizontal;
            // 
            // splitReporte.Panel1
            // 
            splitReporte.Panel1.Controls.Add(picGrafico);
            splitReporte.Panel1.Controls.Add(lblResumen);
            splitReporte.Panel1.Padding = new Padding(12, 8, 12, 12);
            // 
            // splitReporte.Panel2
            // 
            splitReporte.Panel2.Controls.Add(dgvReporte);
            splitReporte.Panel2.Padding = new Padding(12, 8, 12, 12);
            splitReporte.Size = new Size(1157, 399);
            splitReporte.SplitterDistance = 250;
            splitReporte.TabIndex = 1;
            // 
            // picGrafico
            // 
            picGrafico.Dock = DockStyle.Fill;
            picGrafico.Location = new Point(12, 36);
            picGrafico.Name = "picGrafico";
            picGrafico.Size = new Size(1133, 202);
            picGrafico.SizeMode = PictureBoxSizeMode.Zoom;
            picGrafico.TabIndex = 1;
            picGrafico.TabStop = false;
            // 
            // lblResumen
            // 
            lblResumen.Dock = DockStyle.Top;
            lblResumen.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblResumen.Location = new Point(12, 8);
            lblResumen.Name = "lblResumen";
            lblResumen.Size = new Size(1133, 28);
            lblResumen.TabIndex = 0;
            lblResumen.Text = "Resumen del periodo";
            // 
            // dgvReporte
            // 
            dgvReporte.AllowUserToAddRows = false;
            dgvReporte.AllowUserToDeleteRows = false;
            dgvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReporte.BackgroundColor = Color.White;
            dgvReporte.BorderStyle = BorderStyle.None;
            dgvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporte.Dock = DockStyle.Fill;
            dgvReporte.Location = new Point(12, 8);
            dgvReporte.Name = "dgvReporte";
            dgvReporte.ReadOnly = true;
            dgvReporte.RowHeadersVisible = false;
            dgvReporte.RowHeadersWidth = 51;
            dgvReporte.Size = new Size(1133, 121);
            dgvReporte.TabIndex = 0;
            // 
            // Reportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 933);
            Controls.Add(panelMain);
            Controls.Add(panelNav);
            Controls.Add(panelHeader);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Reportes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reportes";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelNav.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panelTabs.ResumeLayout(false);
            panelContenido.ResumeLayout(false);
            panelReporte.ResumeLayout(false);
            panelFiltros.ResumeLayout(false);
            panelFiltros.PerformLayout();
            splitReporte.Panel1.ResumeLayout(false);
            splitReporte.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitReporte).EndInit();
            splitReporte.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picGrafico).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).EndInit();
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
        private System.Windows.Forms.Label lblReportesTitle;
        private System.Windows.Forms.Panel panelTabs;
        private System.Windows.Forms.Button btnReporteOrdenes;
        private System.Windows.Forms.Button btnReporteProduccion;
        private System.Windows.Forms.Button btnReporteDistribucion;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Button btnReporteMovimientosInsumos;
        private System.Windows.Forms.Panel panelReporte;
        private System.Windows.Forms.Panel panelFiltros;
        private System.Windows.Forms.Label lblTituloReporte;
        private System.Windows.Forms.Label lblDescripcionReporte;
        private System.Windows.Forms.Label lblFiltroDesde;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblFiltroHasta;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label lblFiltroCategoria;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private System.Windows.Forms.Button btnExportarExcel;
        private System.Windows.Forms.Button btnExportarPdf;
        private System.Windows.Forms.SplitContainer splitReporte;
        private System.Windows.Forms.Label lblResumen;
        private System.Windows.Forms.PictureBox picGrafico;
        private System.Windows.Forms.DataGridView dgvReporte;
    }
}


