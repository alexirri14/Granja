namespace Granja
{
    partial class Distribucion
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
            btnNuevaDistribucion = new Button();
            lblDistribucionTitle = new Label();
            panelRegistroDistribucion = new Panel();
            btnCancelarDistribucion = new Button();
            btnRegistrarDistribucion = new Button();
            txtCantidadDistribucion = new TextBox();
            lblCantidadDistribucion = new Label();
            dtpFechaDistribucion = new DateTimePicker();
            lblFechaDistribucion = new Label();
            lblRegistroDistribucionTitle = new Label();
            cmbTipoRegistroDistribucion = new ComboBox();
            lblTipoRegistroDistribucion = new Label();
            panelHistorialDistribucion = new Panel();
            dgvHistorialDistribucion = new DataGridView();
            lblHistorialDistribucionTitle = new Label();
            panelHeader.SuspendLayout();
            panelNav.SuspendLayout();
            panelMain.SuspendLayout();
            panelRegistroDistribucion.SuspendLayout();
            panelHistorialDistribucion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorialDistribucion).BeginInit();
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
            btnAlmacen.ForeColor = Color.FromArgb(0, 125, 62);
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
            panelMain.Controls.Add(lblStockTotal);
            panelMain.Controls.Add(lblStockLabel);
            panelMain.Controls.Add(btnNuevaDistribucion);
            panelMain.Controls.Add(lblDistribucionTitle);
            panelMain.Controls.Add(panelRegistroDistribucion);
            panelMain.Controls.Add(panelHistorialDistribucion);
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
            lblStockTotal.Location = new Point(1063, 40);
            lblStockTotal.Name = "lblStockTotal";
            lblStockTotal.Size = new Size(40, 46);
            lblStockTotal.TabIndex = 4;
            lblStockTotal.Text = "0";
            // 
            // lblStockLabel
            // 
            lblStockLabel.AutoSize = true;
            lblStockLabel.Font = new Font("Segoe UI", 10F);
            lblStockLabel.ForeColor = Color.Gray;
            lblStockLabel.Location = new Point(1063, 17);
            lblStockLabel.Name = "lblStockLabel";
            lblStockLabel.Size = new Size(182, 23);
            lblStockLabel.TabIndex = 3;
            lblStockLabel.Text = "Ingresos a distribución";
            // 
            // btnNuevaDistribucion
            // 
            btnNuevaDistribucion.BackColor = Color.FromArgb(0, 125, 62);
            btnNuevaDistribucion.FlatAppearance.BorderSize = 0;
            btnNuevaDistribucion.FlatStyle = FlatStyle.Flat;
            btnNuevaDistribucion.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnNuevaDistribucion.ForeColor = Color.White;
            btnNuevaDistribucion.Location = new Point(37, 82);
            btnNuevaDistribucion.Name = "btnNuevaDistribucion";
            btnNuevaDistribucion.Size = new Size(230, 55);
            btnNuevaDistribucion.TabIndex = 2;
            btnNuevaDistribucion.Text = "Nueva distribución";
            btnNuevaDistribucion.UseVisualStyleBackColor = false;
            btnNuevaDistribucion.Click += btnRegistrarMovimiento_Click;
            // 
            // lblDistribucionTitle
            // 
            lblDistribucionTitle.AutoSize = true;
            lblDistribucionTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblDistribucionTitle.ForeColor = Color.FromArgb(26, 32, 44);
            lblDistribucionTitle.Location = new Point(34, 20);
            lblDistribucionTitle.Name = "lblDistribucionTitle";
            lblDistribucionTitle.Size = new Size(351, 41);
            lblDistribucionTitle.TabIndex = 1;
            lblDistribucionTitle.Text = "Distribución a galpones";
            // 
            // panelRegistroDistribucion
            // 
            panelRegistroDistribucion.BackColor = Color.White;
            panelRegistroDistribucion.Controls.Add(btnCancelarDistribucion);
            panelRegistroDistribucion.Controls.Add(btnRegistrarDistribucion);
            panelRegistroDistribucion.Controls.Add(txtCantidadDistribucion);
            panelRegistroDistribucion.Controls.Add(lblCantidadDistribucion);
            panelRegistroDistribucion.Controls.Add(dtpFechaDistribucion);
            panelRegistroDistribucion.Controls.Add(lblFechaDistribucion);
            panelRegistroDistribucion.Controls.Add(lblRegistroDistribucionTitle);
            panelRegistroDistribucion.Controls.Add(cmbTipoRegistroDistribucion);
            panelRegistroDistribucion.Controls.Add(lblTipoRegistroDistribucion);
            panelRegistroDistribucion.Location = new Point(34, 184);
            panelRegistroDistribucion.Margin = new Padding(3, 4, 3, 4);
            panelRegistroDistribucion.Name = "panelRegistroDistribucion";
            panelRegistroDistribucion.Padding = new Padding(30);
            panelRegistroDistribucion.Size = new Size(1189, 394);
            panelRegistroDistribucion.TabIndex = 0;
            // 
            // btnCancelarDistribucion
            // 
            btnCancelarDistribucion.BackColor = Color.FromArgb(108, 117, 125);
            btnCancelarDistribucion.FlatAppearance.BorderSize = 0;
            btnCancelarDistribucion.FlatStyle = FlatStyle.Flat;
            btnCancelarDistribucion.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCancelarDistribucion.ForeColor = Color.White;
            btnCancelarDistribucion.Location = new Point(164, 316);
            btnCancelarDistribucion.Name = "btnCancelarDistribucion";
            btnCancelarDistribucion.Size = new Size(130, 45);
            btnCancelarDistribucion.TabIndex = 8;
            btnCancelarDistribucion.Text = "Cancelar";
            btnCancelarDistribucion.UseVisualStyleBackColor = false;
            btnCancelarDistribucion.Click += btnCancelar_Click;
            // 
            // btnRegistrarDistribucion
            // 
            btnRegistrarDistribucion.BackColor = Color.FromArgb(0, 125, 62);
            btnRegistrarDistribucion.FlatAppearance.BorderSize = 0;
            btnRegistrarDistribucion.FlatStyle = FlatStyle.Flat;
            btnRegistrarDistribucion.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRegistrarDistribucion.ForeColor = Color.White;
            btnRegistrarDistribucion.Location = new Point(27, 316);
            btnRegistrarDistribucion.Name = "btnRegistrarDistribucion";
            btnRegistrarDistribucion.Size = new Size(130, 45);
            btnRegistrarDistribucion.TabIndex = 7;
            btnRegistrarDistribucion.Text = "Registrar";
            btnRegistrarDistribucion.UseVisualStyleBackColor = false;
            btnRegistrarDistribucion.Click += btnRegistrar_Click;
            // 
            // txtCantidadDistribucion
            // 
            txtCantidadDistribucion.Font = new Font("Segoe UI", 12F);
            txtCantidadDistribucion.Location = new Point(30, 259);
            txtCantidadDistribucion.Name = "txtCantidadDistribucion";
            txtCantidadDistribucion.PlaceholderText = "Cantidad solicitada / distribuida";
            txtCantidadDistribucion.Size = new Size(1129, 34);
            txtCantidadDistribucion.TabIndex = 6;
            // 
            // lblCantidadDistribucion
            // 
            lblCantidadDistribucion.AutoSize = true;
            lblCantidadDistribucion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCantidadDistribucion.ForeColor = Color.FromArgb(44, 62, 80);
            lblCantidadDistribucion.Location = new Point(27, 232);
            lblCantidadDistribucion.Name = "lblCantidadDistribucion";
            lblCantidadDistribucion.Size = new Size(83, 23);
            lblCantidadDistribucion.TabIndex = 5;
            lblCantidadDistribucion.Text = "Cantidad";
            // 
            // dtpFechaDistribucion
            // 
            dtpFechaDistribucion.Font = new Font("Segoe UI", 12F);
            dtpFechaDistribucion.Format = DateTimePickerFormat.Short;
            dtpFechaDistribucion.Location = new Point(30, 180);
            dtpFechaDistribucion.Name = "dtpFechaDistribucion";
            dtpFechaDistribucion.Size = new Size(1129, 34);
            dtpFechaDistribucion.TabIndex = 4;
            // 
            // lblFechaDistribucion
            // 
            lblFechaDistribucion.AutoSize = true;
            lblFechaDistribucion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFechaDistribucion.ForeColor = Color.FromArgb(44, 62, 80);
            lblFechaDistribucion.Location = new Point(30, 152);
            lblFechaDistribucion.Name = "lblFechaDistribucion";
            lblFechaDistribucion.Size = new Size(55, 23);
            lblFechaDistribucion.TabIndex = 3;
            lblFechaDistribucion.Text = "Fecha";
            // 
            // lblRegistroDistribucionTitle
            // 
            lblRegistroDistribucionTitle.AutoSize = true;
            lblRegistroDistribucionTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblRegistroDistribucionTitle.ForeColor = Color.FromArgb(26, 32, 44);
            lblRegistroDistribucionTitle.Location = new Point(27, 15);
            lblRegistroDistribucionTitle.Name = "lblRegistroDistribucionTitle";
            lblRegistroDistribucionTitle.Size = new Size(279, 32);
            lblRegistroDistribucionTitle.TabIndex = 0;
            lblRegistroDistribucionTitle.Text = "Solicitud y distribución";
            // 
            // cmbTipoRegistroDistribucion
            // 
            cmbTipoRegistroDistribucion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoRegistroDistribucion.Font = new Font("Segoe UI", 12F);
            cmbTipoRegistroDistribucion.FormattingEnabled = true;
            cmbTipoRegistroDistribucion.Items.AddRange(new object[] { "Solicitud de alimento", "Distribución" });
            cmbTipoRegistroDistribucion.Location = new Point(30, 100);
            cmbTipoRegistroDistribucion.Name = "cmbTipoRegistroDistribucion";
            cmbTipoRegistroDistribucion.Size = new Size(1129, 36);
            cmbTipoRegistroDistribucion.TabIndex = 2;
            // 
            // lblTipoRegistroDistribucion
            // 
            lblTipoRegistroDistribucion.AutoSize = true;
            lblTipoRegistroDistribucion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTipoRegistroDistribucion.ForeColor = Color.FromArgb(44, 62, 80);
            lblTipoRegistroDistribucion.Location = new Point(27, 67);
            lblTipoRegistroDistribucion.Name = "lblTipoRegistroDistribucion";
            lblTipoRegistroDistribucion.Size = new Size(139, 23);
            lblTipoRegistroDistribucion.TabIndex = 1;
            lblTipoRegistroDistribucion.Text = "Tipo de registro";
            // 
            // panelHistorialDistribucion
            // 
            panelHistorialDistribucion.BackColor = Color.White;
            panelHistorialDistribucion.Controls.Add(dgvHistorialDistribucion);
            panelHistorialDistribucion.Controls.Add(lblHistorialDistribucionTitle);
            panelHistorialDistribucion.Location = new Point(34, 180);
            panelHistorialDistribucion.Margin = new Padding(3, 4, 3, 4);
            panelHistorialDistribucion.Name = "panelHistorialDistribucion";
            panelHistorialDistribucion.Padding = new Padding(30);
            panelHistorialDistribucion.Size = new Size(1189, 561);
            panelHistorialDistribucion.TabIndex = 0;
            // 
            // dgvHistorialDistribucion
            // 
            dgvHistorialDistribucion.AllowUserToAddRows = false;
            dgvHistorialDistribucion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorialDistribucion.BackgroundColor = Color.White;
            dgvHistorialDistribucion.BorderStyle = BorderStyle.None;
            dgvHistorialDistribucion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorialDistribucion.Location = new Point(30, 70);
            dgvHistorialDistribucion.Name = "dgvHistorialDistribucion";
            dgvHistorialDistribucion.RowHeadersVisible = false;
            dgvHistorialDistribucion.RowHeadersWidth = 51;
            dgvHistorialDistribucion.Size = new Size(1129, 380);
            dgvHistorialDistribucion.TabIndex = 1;
            // 
            // lblHistorialDistribucionTitle
            // 
            lblHistorialDistribucionTitle.AutoSize = true;
            lblHistorialDistribucionTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblHistorialDistribucionTitle.ForeColor = Color.FromArgb(26, 32, 44);
            lblHistorialDistribucionTitle.Location = new Point(0, 0);
            lblHistorialDistribucionTitle.Name = "lblHistorialDistribucionTitle";
            lblHistorialDistribucionTitle.Size = new Size(440, 32);
            lblHistorialDistribucionTitle.TabIndex = 0;
            lblHistorialDistribucionTitle.Text = "Historial de solicitudes y distribución";
            // 
            // Distribucion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 933);
            Controls.Add(panelMain);
            Controls.Add(panelNav);
            Controls.Add(panelHeader);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Distribucion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Distribución";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelNav.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panelRegistroDistribucion.ResumeLayout(false);
            panelRegistroDistribucion.PerformLayout();
            panelHistorialDistribucion.ResumeLayout(false);
            panelHistorialDistribucion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorialDistribucion).EndInit();
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
        private System.Windows.Forms.Button btnNuevaDistribucion;
        private System.Windows.Forms.Label lblDistribucionTitle;
        private System.Windows.Forms.Panel panelRegistroDistribucion;
        private System.Windows.Forms.Button btnCancelarDistribucion;
        private System.Windows.Forms.Button btnRegistrarDistribucion;
        private System.Windows.Forms.TextBox txtCantidadDistribucion;
        private System.Windows.Forms.Label lblCantidadDistribucion;
        private System.Windows.Forms.DateTimePicker dtpFechaDistribucion;
        private System.Windows.Forms.Label lblFechaDistribucion;
        private System.Windows.Forms.ComboBox cmbTipoRegistroDistribucion;
        private System.Windows.Forms.Label lblTipoRegistroDistribucion;
        private System.Windows.Forms.Label lblRegistroDistribucionTitle;
        private System.Windows.Forms.Label lblGalponDistribucion = new();
        private System.Windows.Forms.ComboBox cmbGalponDistribucion = new();
        private System.Windows.Forms.Label lblFormulaDistribucion = new();
        private System.Windows.Forms.ComboBox cmbFormulaDistribucion = new();
        private System.Windows.Forms.Label lblSolicitudDistribucion = new();
        private System.Windows.Forms.ComboBox cmbSolicitudDistribucion = new();
        private System.Windows.Forms.Label lblDetalleDistribucion = new();
        private System.Windows.Forms.TextBox txtDetalleDistribucion = new();
        private System.Windows.Forms.Panel panelHistorialDistribucion;
        private System.Windows.Forms.DataGridView dgvHistorialDistribucion;
        private System.Windows.Forms.Label lblHistorialDistribucionTitle;
        private System.Windows.Forms.Label lblFiltroDesde = new();
        private System.Windows.Forms.DateTimePicker dtpFiltroDesde = new();
        private System.Windows.Forms.Label lblFiltroHasta = new();
        private System.Windows.Forms.DateTimePicker dtpFiltroHasta = new();
        private System.Windows.Forms.Button btnLimpiarFiltros = new();
    }
}


