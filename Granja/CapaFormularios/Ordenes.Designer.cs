namespace Granja
{
    partial class Ordenes
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
            panelOrdenProduccion = new Panel();
            btnActualizarEstadoOrden = new Button();
            btnRegistrarOrdenProduccion = new Button();
            txtCantidadObjetivoOrden = new TextBox();
            lblCantidadObjetivoOrden = new Label();
            dtpFechaOrdenProduccion = new DateTimePicker();
            lblFechaOrdenProduccion = new Label();
            cmbFormulaOrdenProduccion = new ComboBox();
            lblFormulaOrdenProduccion = new Label();
            panelHistorialOrdenesProduccion = new Panel();
            dgvHistorialOrdenesProduccion = new DataGridView();
            lblHistorialOrdenesTitle = new Label();
            lblOrdenProduccionTitle = new Label();
            panelHeader.SuspendLayout();
            panelNav.SuspendLayout();
            panelMain.SuspendLayout();
            panelOrdenProduccion.SuspendLayout();
            panelHistorialOrdenesProduccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorialOrdenesProduccion).BeginInit();
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
            btnProduccion.ForeColor = Color.FromArgb(0, 125, 62);
            btnProduccion.Location = new Point(149, 0);
            btnProduccion.Margin = new Padding(3, 4, 3, 4);
            btnProduccion.Name = "btnProduccion";
            btnProduccion.Size = new Size(137, 67);
            btnProduccion.TabIndex = 1;
            btnProduccion.Text = "Órdenes";
            btnProduccion.UseVisualStyleBackColor = true;
            btnProduccion.Click += btnProduccion_Click_1;
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
            panelMain.Controls.Add(panelOrdenProduccion);
            panelMain.Controls.Add(panelHistorialOrdenesProduccion);
            panelMain.Controls.Add(lblOrdenProduccionTitle);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 153);
            panelMain.Margin = new Padding(3, 4, 3, 4);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(34, 40, 34, 40);
            panelMain.Size = new Size(1257, 780);
            panelMain.TabIndex = 2;
            // 
            // panelOrdenProduccion
            // 
            panelOrdenProduccion.BackColor = Color.White;
            panelOrdenProduccion.Controls.Add(btnActualizarEstadoOrden);
            panelOrdenProduccion.Controls.Add(btnRegistrarOrdenProduccion);
            panelOrdenProduccion.Controls.Add(txtDetalleOrden);
            panelOrdenProduccion.Controls.Add(lblDetalleOrden);
            panelOrdenProduccion.Controls.Add(cmbEstadoOrden);
            panelOrdenProduccion.Controls.Add(lblEstadoOrden);
            panelOrdenProduccion.Controls.Add(txtCantidadObjetivoOrden);
            panelOrdenProduccion.Controls.Add(lblCantidadObjetivoOrden);
            panelOrdenProduccion.Controls.Add(dtpFechaOrdenProduccion);
            panelOrdenProduccion.Controls.Add(lblFechaOrdenProduccion);
            panelOrdenProduccion.Controls.Add(cmbFormulaOrdenProduccion);
            panelOrdenProduccion.Controls.Add(lblFormulaOrdenProduccion);
            panelOrdenProduccion.Location = new Point(34, 62);
            panelOrdenProduccion.Margin = new Padding(3, 4, 3, 4);
            panelOrdenProduccion.Name = "panelOrdenProduccion";
            panelOrdenProduccion.Padding = new Padding(30);
            panelOrdenProduccion.Size = new Size(1189, 320);
            panelOrdenProduccion.TabIndex = 0;
            // 
            // btnActualizarEstadoOrden
            // 
            btnActualizarEstadoOrden.BackColor = Color.FromArgb(108, 117, 125);
            btnActualizarEstadoOrden.FlatAppearance.BorderSize = 0;
            btnActualizarEstadoOrden.FlatStyle = FlatStyle.Flat;
            btnActualizarEstadoOrden.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnActualizarEstadoOrden.ForeColor = Color.White;
            btnActualizarEstadoOrden.Location = new Point(186, 253);
            btnActualizarEstadoOrden.Name = "btnActualizarEstadoOrden";
            btnActualizarEstadoOrden.Size = new Size(150, 45);
            btnActualizarEstadoOrden.TabIndex = 8;
            btnActualizarEstadoOrden.Text = "Actualizar estado";
            btnActualizarEstadoOrden.UseVisualStyleBackColor = false;
            // 
            // btnRegistrarOrdenProduccion
            // 
            btnRegistrarOrdenProduccion.BackColor = Color.FromArgb(0, 125, 62);
            btnRegistrarOrdenProduccion.FlatAppearance.BorderSize = 0;
            btnRegistrarOrdenProduccion.FlatStyle = FlatStyle.Flat;
            btnRegistrarOrdenProduccion.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRegistrarOrdenProduccion.ForeColor = Color.White;
            btnRegistrarOrdenProduccion.Location = new Point(30, 253);
            btnRegistrarOrdenProduccion.Name = "btnRegistrarOrdenProduccion";
            btnRegistrarOrdenProduccion.Size = new Size(150, 45);
            btnRegistrarOrdenProduccion.TabIndex = 7;
            btnRegistrarOrdenProduccion.Text = "Registrar orden";
            btnRegistrarOrdenProduccion.UseVisualStyleBackColor = false;
            // 
            // txtCantidadObjetivoOrden
            // 
            txtCantidadObjetivoOrden.Font = new Font("Segoe UI", 12F);
            txtCantidadObjetivoOrden.Location = new Point(27, 201);
            txtCantidadObjetivoOrden.Name = "txtCantidadObjetivoOrden";
            txtCantidadObjetivoOrden.PlaceholderText = "Cantidad de alimento balanceado";
            txtCantidadObjetivoOrden.Size = new Size(1129, 34);
            txtCantidadObjetivoOrden.TabIndex = 6;
            // 
            // lblCantidadObjetivoOrden
            // 
            lblCantidadObjetivoOrden.AutoSize = true;
            lblCantidadObjetivoOrden.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCantidadObjetivoOrden.ForeColor = Color.FromArgb(44, 62, 80);
            lblCantidadObjetivoOrden.Location = new Point(27, 163);
            lblCantidadObjetivoOrden.Name = "lblCantidadObjetivoOrden";
            lblCantidadObjetivoOrden.Size = new Size(83, 23);
            lblCantidadObjetivoOrden.TabIndex = 5;
            lblCantidadObjetivoOrden.Text = "Cantidad a producir";
            // 
            // dtpFechaOrdenProduccion
            // 
            dtpFechaOrdenProduccion.Font = new Font("Segoe UI", 12F);
            dtpFechaOrdenProduccion.Format = DateTimePickerFormat.Short;
            dtpFechaOrdenProduccion.Location = new Point(27, 111);
            dtpFechaOrdenProduccion.Name = "dtpFechaOrdenProduccion";
            dtpFechaOrdenProduccion.Size = new Size(1129, 34);
            dtpFechaOrdenProduccion.TabIndex = 4;
            // 
            // lblFechaOrdenProduccion
            // 
            lblFechaOrdenProduccion.AutoSize = true;
            lblFechaOrdenProduccion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFechaOrdenProduccion.ForeColor = Color.FromArgb(44, 62, 80);
            lblFechaOrdenProduccion.Location = new Point(27, 85);
            lblFechaOrdenProduccion.Name = "lblFechaOrdenProduccion";
            lblFechaOrdenProduccion.Size = new Size(55, 23);
            lblFechaOrdenProduccion.TabIndex = 3;
            lblFechaOrdenProduccion.Text = "Fecha";
            // 
            // cmbFormulaOrdenProduccion
            // 
            cmbFormulaOrdenProduccion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFormulaOrdenProduccion.Font = new Font("Segoe UI", 12F);
            cmbFormulaOrdenProduccion.FormattingEnabled = true;
            cmbFormulaOrdenProduccion.Items.AddRange(new object[] { "Postura 1", "Postura 2", "Postura 3" });
            cmbFormulaOrdenProduccion.Location = new Point(27, 46);
            cmbFormulaOrdenProduccion.Name = "cmbFormulaOrdenProduccion";
            cmbFormulaOrdenProduccion.Size = new Size(1129, 36);
            cmbFormulaOrdenProduccion.TabIndex = 2;
            // 
            // lblFormulaOrdenProduccion
            // 
            lblFormulaOrdenProduccion.AutoSize = true;
            lblFormulaOrdenProduccion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFormulaOrdenProduccion.ForeColor = Color.FromArgb(44, 62, 80);
            lblFormulaOrdenProduccion.Location = new Point(27, 11);
            lblFormulaOrdenProduccion.Name = "lblFormulaOrdenProduccion";
            lblFormulaOrdenProduccion.Size = new Size(67, 23);
            lblFormulaOrdenProduccion.TabIndex = 1;
            lblFormulaOrdenProduccion.Text = "Fórmula";
            // 
            // lblEstadoOrden
            // 
            lblEstadoOrden.AutoSize = true;
            lblEstadoOrden.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEstadoOrden.ForeColor = Color.FromArgb(44, 62, 80);
            lblEstadoOrden.Location = new Point(30, 265);
            lblEstadoOrden.Name = "lblEstadoOrden";
            lblEstadoOrden.Size = new Size(63, 23);
            lblEstadoOrden.TabIndex = 9;
            lblEstadoOrden.Text = "Estado";
            // 
            // cmbEstadoOrden
            // 
            cmbEstadoOrden.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstadoOrden.Font = new Font("Segoe UI", 12F);
            cmbEstadoOrden.FormattingEnabled = true;
            cmbEstadoOrden.Location = new Point(30, 295);
            cmbEstadoOrden.Name = "cmbEstadoOrden";
            cmbEstadoOrden.Size = new Size(529, 36);
            cmbEstadoOrden.TabIndex = 10;
            // 
            // lblDetalleOrden
            // 
            lblDetalleOrden.AutoSize = true;
            lblDetalleOrden.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDetalleOrden.ForeColor = Color.FromArgb(44, 62, 80);
            lblDetalleOrden.Location = new Point(630, 265);
            lblDetalleOrden.Name = "lblDetalleOrden";
            lblDetalleOrden.Size = new Size(67, 23);
            lblDetalleOrden.TabIndex = 11;
            lblDetalleOrden.Text = "Detalle";
            // 
            // txtDetalleOrden
            // 
            txtDetalleOrden.Font = new Font("Segoe UI", 12F);
            txtDetalleOrden.Location = new Point(630, 295);
            txtDetalleOrden.Name = "txtDetalleOrden";
            txtDetalleOrden.PlaceholderText = "Observación de la orden";
            txtDetalleOrden.Size = new Size(529, 34);
            txtDetalleOrden.TabIndex = 12;
            // 
            // panelHistorialOrdenesProduccion
            // 
            panelHistorialOrdenesProduccion.BackColor = Color.White;
            panelHistorialOrdenesProduccion.Controls.Add(btnLimpiarFiltros);
            panelHistorialOrdenesProduccion.Controls.Add(dtpFiltroHasta);
            panelHistorialOrdenesProduccion.Controls.Add(lblFiltroHasta);
            panelHistorialOrdenesProduccion.Controls.Add(dtpFiltroDesde);
            panelHistorialOrdenesProduccion.Controls.Add(lblFiltroDesde);
            panelHistorialOrdenesProduccion.Controls.Add(dgvHistorialOrdenesProduccion);
            panelHistorialOrdenesProduccion.Controls.Add(lblHistorialOrdenesTitle);
            panelHistorialOrdenesProduccion.Location = new Point(34, 390);
            panelHistorialOrdenesProduccion.Margin = new Padding(3, 4, 3, 4);
            panelHistorialOrdenesProduccion.Name = "panelHistorialOrdenesProduccion";
            panelHistorialOrdenesProduccion.Padding = new Padding(30);
            panelHistorialOrdenesProduccion.Size = new Size(1189, 360);
            panelHistorialOrdenesProduccion.TabIndex = 1;
            // 
            // dgvHistorialOrdenesProduccion
            // 
            dgvHistorialOrdenesProduccion.AllowUserToAddRows = false;
            dgvHistorialOrdenesProduccion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorialOrdenesProduccion.BackgroundColor = Color.White;
            dgvHistorialOrdenesProduccion.BorderStyle = BorderStyle.None;
            dgvHistorialOrdenesProduccion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorialOrdenesProduccion.Location = new Point(30, 70);
            dgvHistorialOrdenesProduccion.Name = "dgvHistorialOrdenesProduccion";
            dgvHistorialOrdenesProduccion.RowHeadersVisible = false;
            dgvHistorialOrdenesProduccion.RowHeadersWidth = 51;
            dgvHistorialOrdenesProduccion.Size = new Size(1129, 260);
            dgvHistorialOrdenesProduccion.TabIndex = 1;
            // 
            // lblHistorialOrdenesTitle
            // 
            lblHistorialOrdenesTitle.AutoSize = true;
            lblHistorialOrdenesTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblHistorialOrdenesTitle.ForeColor = Color.FromArgb(26, 32, 44);
            lblHistorialOrdenesTitle.Location = new Point(14, 13);
            lblHistorialOrdenesTitle.Name = "lblHistorialOrdenesTitle";
            lblHistorialOrdenesTitle.Size = new Size(229, 32);
            lblHistorialOrdenesTitle.TabIndex = 0;
            lblHistorialOrdenesTitle.Text = "Historial de órdenes";
            // 
            // lblFiltroDesde
            // 
            lblFiltroDesde.AutoSize = true;
            lblFiltroDesde.Location = new Point(30, 45);
            lblFiltroDesde.Name = "lblFiltroDesde";
            lblFiltroDesde.Size = new Size(48, 20);
            lblFiltroDesde.TabIndex = 2;
            lblFiltroDesde.Text = "Desde";
            // 
            // dtpFiltroDesde
            // 
            dtpFiltroDesde.Format = DateTimePickerFormat.Short;
            dtpFiltroDesde.Location = new Point(90, 40);
            dtpFiltroDesde.Name = "dtpFiltroDesde";
            dtpFiltroDesde.Size = new Size(140, 27);
            dtpFiltroDesde.TabIndex = 3;
            // 
            // lblFiltroHasta
            // 
            lblFiltroHasta.AutoSize = true;
            lblFiltroHasta.Location = new Point(255, 45);
            lblFiltroHasta.Name = "lblFiltroHasta";
            lblFiltroHasta.Size = new Size(45, 20);
            lblFiltroHasta.TabIndex = 4;
            lblFiltroHasta.Text = "Hasta";
            // 
            // dtpFiltroHasta
            // 
            dtpFiltroHasta.Format = DateTimePickerFormat.Short;
            dtpFiltroHasta.Location = new Point(315, 40);
            dtpFiltroHasta.Name = "dtpFiltroHasta";
            dtpFiltroHasta.Size = new Size(140, 27);
            dtpFiltroHasta.TabIndex = 5;
            // 
            // btnLimpiarFiltros
            // 
            btnLimpiarFiltros.Location = new Point(480, 35);
            btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            btnLimpiarFiltros.Size = new Size(140, 34);
            btnLimpiarFiltros.TabIndex = 6;
            btnLimpiarFiltros.Text = "Limpiar filtros";
            btnLimpiarFiltros.UseVisualStyleBackColor = true;
            // 
            // lblOrdenProduccionTitle
            // 
            lblOrdenProduccionTitle.AutoSize = true;
            lblOrdenProduccionTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblOrdenProduccionTitle.ForeColor = Color.FromArgb(26, 32, 44);
            lblOrdenProduccionTitle.Location = new Point(23, 4);
            lblOrdenProduccionTitle.Name = "lblOrdenProduccionTitle";
            lblOrdenProduccionTitle.Size = new Size(316, 37);
            lblOrdenProduccionTitle.TabIndex = 0;
            lblOrdenProduccionTitle.Text = "Orden de Producción";
            // 
            // Ordenes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 933);
            Controls.Add(panelMain);
            Controls.Add(panelNav);
            Controls.Add(panelHeader);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Ordenes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Órdenes";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelNav.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panelOrdenProduccion.ResumeLayout(false);
            panelOrdenProduccion.PerformLayout();
            panelHistorialOrdenesProduccion.ResumeLayout(false);
            panelHistorialOrdenesProduccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorialOrdenesProduccion).EndInit();
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
        private System.Windows.Forms.Panel panelOrdenProduccion;
        private System.Windows.Forms.Label lblOrdenProduccionTitle;
        private System.Windows.Forms.Label lblFormulaOrdenProduccion;
        private System.Windows.Forms.ComboBox cmbFormulaOrdenProduccion;
        private System.Windows.Forms.Label lblFechaOrdenProduccion;
        private System.Windows.Forms.DateTimePicker dtpFechaOrdenProduccion;
        private System.Windows.Forms.Label lblCantidadObjetivoOrden;
        private System.Windows.Forms.TextBox txtCantidadObjetivoOrden;
        private System.Windows.Forms.Button btnRegistrarOrdenProduccion;
        private System.Windows.Forms.Button btnActualizarEstadoOrden;
        private System.Windows.Forms.Label lblEstadoOrden = new();
        private System.Windows.Forms.ComboBox cmbEstadoOrden = new();
        private System.Windows.Forms.Label lblDetalleOrden = new();
        private System.Windows.Forms.TextBox txtDetalleOrden = new();
        private System.Windows.Forms.Panel panelHistorialOrdenesProduccion;
        private System.Windows.Forms.Label lblHistorialOrdenesTitle;
        private System.Windows.Forms.DataGridView dgvHistorialOrdenesProduccion;
        private System.Windows.Forms.Label lblFiltroDesde = new();
        private System.Windows.Forms.DateTimePicker dtpFiltroDesde = new();
        private System.Windows.Forms.Label lblFiltroHasta = new();
        private System.Windows.Forms.DateTimePicker dtpFiltroHasta = new();
        private System.Windows.Forms.Button btnLimpiarFiltros = new();
    }
}


