namespace Granja
{
    partial class Almacen
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
            btnDashboard = new Button();
            panelMain = new Panel();
            lblStockTotal = new Label();
            lblStockLabel = new Label();
            btnRegistrarMovimiento = new Button();
            lblAlmacenTitle = new Label();
            panelNuevoMovimiento = new Panel();
            btnCancelar = new Button();
            btnRegistrar = new Button();
            txtCantidad = new TextBox();
            lblCantidad = new Label();
            dtpFecha = new DateTimePicker();
            lblFecha = new Label();
            lblNuevoMovimientoTitle = new Label();
            cmbTipo = new ComboBox();
            lblTipo = new Label();
            panelMovimientos = new Panel();
            dgvMovimientos = new DataGridView();
            lblMovimientosTitle = new Label();
            panelHeader.SuspendLayout();
            panelNav.SuspendLayout();
            panelMain.SuspendLayout();
            panelNuevoMovimiento.SuspendLayout();
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
            btnReportes.Location = new Point(831, 2);
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
            btnMolino.Location = new Point(694, 2);
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
            btnInsumos.Location = new Point(557, 2);
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
            btnAlimento.Location = new Point(420, 2);
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
            btnVentas.Location = new Point(283, 2);
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
            btnAlmacen.ForeColor = Color.FromArgb(0, 125, 62);
            btnAlmacen.Location = new Point(146, 2);
            btnAlmacen.Margin = new Padding(3, 4, 3, 4);
            btnAlmacen.Name = "btnAlmacen";
            btnAlmacen.Size = new Size(137, 67);
            btnAlmacen.TabIndex = 2;
            btnAlmacen.Text = " Almacén";
            btnAlmacen.UseVisualStyleBackColor = true;
            btnAlmacen.Click += btnAlmacen_Click;
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
            panelMain.Controls.Add(btnRegistrarMovimiento);
            panelMain.Controls.Add(lblAlmacenTitle);
            panelMain.Controls.Add(panelNuevoMovimiento);
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
            lblStockTotal.Location = new Point(1023, 40);
            lblStockTotal.Name = "lblStockTotal";
            lblStockTotal.Size = new Size(222, 46);
            lblStockTotal.TabIndex = 4;
            lblStockTotal.Text = "8500 huevos";
            // 
            // lblStockLabel
            // 
            lblStockLabel.AutoSize = true;
            lblStockLabel.Font = new Font("Segoe UI", 10F);
            lblStockLabel.ForeColor = Color.Gray;
            lblStockLabel.Location = new Point(1132, 20);
            lblStockLabel.Name = "lblStockLabel";
            lblStockLabel.Size = new Size(101, 23);
            lblStockLabel.TabIndex = 3;
            lblStockLabel.Text = "Stock actual";
            // 
            // btnRegistrarMovimiento
            // 
            btnRegistrarMovimiento.BackColor = Color.FromArgb(0, 125, 62);
            btnRegistrarMovimiento.FlatAppearance.BorderSize = 0;
            btnRegistrarMovimiento.FlatStyle = FlatStyle.Flat;
            btnRegistrarMovimiento.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRegistrarMovimiento.ForeColor = Color.White;
            btnRegistrarMovimiento.Location = new Point(37, 82);
            btnRegistrarMovimiento.Name = "btnRegistrarMovimiento";
            btnRegistrarMovimiento.Size = new Size(230, 55);
            btnRegistrarMovimiento.TabIndex = 2;
            btnRegistrarMovimiento.Text = "+ Registrar movimiento";
            btnRegistrarMovimiento.UseVisualStyleBackColor = false;
            btnRegistrarMovimiento.Click += btnRegistrarMovimiento_Click;
            // 
            // lblAlmacenTitle
            // 
            lblAlmacenTitle.AutoSize = true;
            lblAlmacenTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblAlmacenTitle.ForeColor = Color.FromArgb(26, 32, 44);
            lblAlmacenTitle.Location = new Point(34, 20);
            lblAlmacenTitle.Name = "lblAlmacenTitle";
            lblAlmacenTitle.Size = new Size(294, 41);
            lblAlmacenTitle.TabIndex = 1;
            lblAlmacenTitle.Text = "Almacén de Huevos";
            // 
            // panelNuevoMovimiento
            // 
            panelNuevoMovimiento.BackColor = Color.White;
            panelNuevoMovimiento.Controls.Add(btnCancelar);
            panelNuevoMovimiento.Controls.Add(btnRegistrar);
            panelNuevoMovimiento.Controls.Add(txtCantidad);
            panelNuevoMovimiento.Controls.Add(lblCantidad);
            panelNuevoMovimiento.Controls.Add(dtpFecha);
            panelNuevoMovimiento.Controls.Add(lblFecha);
            panelNuevoMovimiento.Controls.Add(lblNuevoMovimientoTitle);
            panelNuevoMovimiento.Controls.Add(cmbTipo);
            panelNuevoMovimiento.Controls.Add(lblTipo);
            panelNuevoMovimiento.Location = new Point(34, 184);
            panelNuevoMovimiento.Margin = new Padding(3, 4, 3, 4);
            panelNuevoMovimiento.Name = "panelNuevoMovimiento";
            panelNuevoMovimiento.Padding = new Padding(30);
            panelNuevoMovimiento.Size = new Size(1189, 394);
            panelNuevoMovimiento.TabIndex = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(108, 117, 125);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(164, 316);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(130, 45);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(0, 125, 62);
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(27, 316);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(130, 45);
            btnRegistrar.TabIndex = 7;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Segoe UI", 12F);
            txtCantidad.Location = new Point(30, 259);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.PlaceholderText = "Número de huevos";
            txtCantidad.Size = new Size(1129, 34);
            txtCantidad.TabIndex = 6;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCantidad.ForeColor = Color.FromArgb(44, 62, 80);
            lblCantidad.Location = new Point(27, 232);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(83, 23);
            lblCantidad.TabIndex = 5;
            lblCantidad.Text = "Cantidad";
            // 
            // dtpFecha
            // 
            dtpFecha.Font = new Font("Segoe UI", 12F);
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(30, 180);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(1129, 34);
            dtpFecha.TabIndex = 4;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFecha.ForeColor = Color.FromArgb(44, 62, 80);
            lblFecha.Location = new Point(30, 152);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(55, 23);
            lblFecha.TabIndex = 3;
            lblFecha.Text = "Fecha";
            // 
            // lblNuevoMovimientoTitle
            // 
            lblNuevoMovimientoTitle.AutoSize = true;
            lblNuevoMovimientoTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblNuevoMovimientoTitle.ForeColor = Color.FromArgb(26, 32, 44);
            lblNuevoMovimientoTitle.Location = new Point(27, 28);
            lblNuevoMovimientoTitle.Name = "lblNuevoMovimientoTitle";
            lblNuevoMovimientoTitle.Size = new Size(235, 32);
            lblNuevoMovimientoTitle.TabIndex = 0;
            lblNuevoMovimientoTitle.Text = "Nuevo Movimiento";
            // 
            // cmbTipo
            // 
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.Font = new Font("Segoe UI", 12F);
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Pérdida" });
            cmbTipo.Location = new Point(30, 100);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(1129, 36);
            cmbTipo.TabIndex = 2;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTipo.ForeColor = Color.FromArgb(44, 62, 80);
            lblTipo.Location = new Point(27, 67);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(173, 23);
            lblTipo.TabIndex = 1;
            lblTipo.Text = "Tipo de movimiento";
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
            panelMovimientos.Size = new Size(1189, 561);
            panelMovimientos.TabIndex = 0;
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
            // Almacen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 933);
            Controls.Add(panelMain);
            Controls.Add(panelNav);
            Controls.Add(panelHeader);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Almacen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Almacén - Rancho del Buen Pastor";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelNav.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panelNuevoMovimiento.ResumeLayout(false);
            panelNuevoMovimiento.PerformLayout();
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
        private System.Windows.Forms.Button btnAlmacen;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnAlimento;
        private System.Windows.Forms.Button btnInsumos;
        private System.Windows.Forms.Button btnMolino;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblStockTotal;
        private System.Windows.Forms.Label lblStockLabel;
        private System.Windows.Forms.Button btnRegistrarMovimiento;
        private System.Windows.Forms.Label lblAlmacenTitle;
        private System.Windows.Forms.Panel panelNuevoMovimiento;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblNuevoMovimientoTitle;
        private System.Windows.Forms.Panel panelMovimientos;
        private System.Windows.Forms.DataGridView dgvMovimientos;
        private System.Windows.Forms.Label lblMovimientosTitle;
    }
}
