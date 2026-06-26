namespace Granja
{
    partial class AlmacenAB
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
            btnProduccion = new Button();
            btnAlmacen = new Button();
            btnVentas = new Button();
            btnReportes = new Button();
            btnMolino = new Button();
            btnInsumos = new Button();
            btnAlimento = new Button();
            btnDashboard = new Button();
            panelMain = new Panel();
            lblStockTotal = new Label();
            lblStockLabel = new Label();
            btnMostrarOrdenStock = new Button();
            lblAlimentoTitle = new Label();
            panelOrdenStock = new Panel();
            btnCancelarOrdenStock = new Button();
            btnRegistrarOrdenStock = new Button();
            txtCantidadOrdenStock = new TextBox();
            lblCantidadOrdenStock = new Label();
            dtpFechaOrdenStock = new DateTimePicker();
            lblFechaOrdenStock = new Label();
            lblOrdenStockTitle = new Label();
            panelMovimientos = new Panel();
            dgvMovimientos = new DataGridView();
            lblMovimientosTitle = new Label();
            panelHeader.SuspendLayout();
            panelNav.SuspendLayout();
            panelMain.SuspendLayout();
            panelOrdenStock.SuspendLayout();
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
            lblTitle.Size = new Size(547, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Sistema de Alimento Balanceado - Granja";
            // 
            // panelNav
            // 
            panelNav.BackColor = Color.White;
            panelNav.Controls.Add(btnProduccion);
            panelNav.Controls.Add(btnAlmacen);
            panelNav.Controls.Add(btnVentas);
            panelNav.Controls.Add(btnReportes);
            panelNav.Controls.Add(btnMolino);
            panelNav.Controls.Add(btnInsumos);
            panelNav.Controls.Add(btnAlimento);
            panelNav.Controls.Add(btnDashboard);
            panelNav.Dock = DockStyle.Top;
            panelNav.Location = new Point(0, 80);
            panelNav.Margin = new Padding(3, 4, 3, 4);
            panelNav.Name = "panelNav";
            panelNav.Size = new Size(1257, 73);
            panelNav.TabIndex = 1;
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
            btnProduccion.TabIndex = 10;
            btnProduccion.Text = "Órdenes";
            btnProduccion.UseVisualStyleBackColor = true;
            btnProduccion.Click += btnProduccion_Click_1;
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
            btnAlmacen.TabIndex = 9;
            btnAlmacen.Text = "Distribución";
            btnAlmacen.UseVisualStyleBackColor = true;
            btnAlmacen.Click += btnAlmacen_Click_1;
            // 
            // btnVentas
            // 
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Segoe UI", 10F);
            btnVentas.ForeColor = Color.FromArgb(26, 32, 44);
            btnVentas.Location = new Point(423, 0);
            btnVentas.Margin = new Padding(3, 4, 3, 4);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(137, 67);
            btnVentas.TabIndex = 8;
            btnVentas.Text = "Administrador";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
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
            btnAlimento.ForeColor = Color.FromArgb(0, 125, 62);
            btnAlimento.Location = new Point(560, 0);
            btnAlimento.Margin = new Padding(3, 4, 3, 4);
            btnAlimento.Name = "btnAlimento";
            btnAlimento.Size = new Size(137, 67);
            btnAlimento.TabIndex = 4;
            btnAlimento.Text = "Almacén AB";
            btnAlimento.UseVisualStyleBackColor = true;
            btnAlimento.Click += btnAlimento_Click;
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
            panelMain.Controls.Add(btnMostrarOrdenStock);
            panelMain.Controls.Add(lblAlimentoTitle);
            panelMain.Controls.Add(panelOrdenStock);
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
            lblStockTotal.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            lblStockTotal.ForeColor = Color.FromArgb(0, 125, 62);
            lblStockTotal.Location = new Point(1059, 27);
            lblStockTotal.Name = "lblStockTotal";
            lblStockTotal.Size = new Size(89, 46);
            lblStockTotal.TabIndex = 6;
            lblStockTotal.Text = "0.00";
            // 
            // lblStockLabel
            // 
            lblStockLabel.AutoSize = true;
            lblStockLabel.Font = new Font("Segoe UI", 10F);
            lblStockLabel.ForeColor = Color.Gray;
            lblStockLabel.Location = new Point(1068, 4);
            lblStockLabel.Name = "lblStockLabel";
            lblStockLabel.Size = new Size(90, 23);
            lblStockLabel.TabIndex = 5;
            lblStockLabel.Text = "Stock total";
            // 
            // btnMostrarOrdenStock
            // 
            btnMostrarOrdenStock.BackColor = Color.FromArgb(0, 125, 62);
            btnMostrarOrdenStock.FlatAppearance.BorderSize = 0;
            btnMostrarOrdenStock.FlatStyle = FlatStyle.Flat;
            btnMostrarOrdenStock.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnMostrarOrdenStock.ForeColor = Color.White;
            btnMostrarOrdenStock.Location = new Point(34, 90);
            btnMostrarOrdenStock.Name = "btnMostrarOrdenStock";
            btnMostrarOrdenStock.Size = new Size(230, 55);
            btnMostrarOrdenStock.TabIndex = 3;
            btnMostrarOrdenStock.Text = "Generar orden";
            btnMostrarOrdenStock.UseVisualStyleBackColor = false;
            btnMostrarOrdenStock.Click += btnRegistrarPerdida_Click;
            // 
            // lblAlimentoTitle
            // 
            lblAlimentoTitle.AutoSize = true;
            lblAlimentoTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblAlimentoTitle.ForeColor = Color.FromArgb(26, 32, 44);
            lblAlimentoTitle.Location = new Point(34, 20);
            lblAlimentoTitle.Name = "lblAlimentoTitle";
            lblAlimentoTitle.Size = new Size(489, 41);
            lblAlimentoTitle.TabIndex = 2;
            lblAlimentoTitle.Text = "Almacén de Alimento Balanceado";
            // 
            // panelOrdenStock
            // 
            panelOrdenStock.BackColor = Color.White;
            panelOrdenStock.Controls.Add(btnCancelarOrdenStock);
            panelOrdenStock.Controls.Add(btnRegistrarOrdenStock);
            panelOrdenStock.Controls.Add(txtCantidadOrdenStock);
            panelOrdenStock.Controls.Add(lblCantidadOrdenStock);
            panelOrdenStock.Controls.Add(dtpFechaOrdenStock);
            panelOrdenStock.Controls.Add(lblFechaOrdenStock);
            panelOrdenStock.Controls.Add(lblOrdenStockTitle);
            panelOrdenStock.Location = new Point(34, 180);
            panelOrdenStock.Margin = new Padding(3, 4, 3, 4);
            panelOrdenStock.Name = "panelOrdenStock";
            panelOrdenStock.Padding = new Padding(30);
            panelOrdenStock.Size = new Size(1189, 280);
            panelOrdenStock.TabIndex = 0;
            panelOrdenStock.Visible = false;
            // 
            // btnCancelarOrdenStock
            // 
            btnCancelarOrdenStock.BackColor = Color.FromArgb(108, 117, 125);
            btnCancelarOrdenStock.FlatAppearance.BorderSize = 0;
            btnCancelarOrdenStock.FlatStyle = FlatStyle.Flat;
            btnCancelarOrdenStock.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCancelarOrdenStock.ForeColor = Color.White;
            btnCancelarOrdenStock.Location = new Point(166, 214);
            btnCancelarOrdenStock.Name = "btnCancelarOrdenStock";
            btnCancelarOrdenStock.Size = new Size(130, 45);
            btnCancelarOrdenStock.TabIndex = 6;
            btnCancelarOrdenStock.Text = "Cancelar";
            btnCancelarOrdenStock.UseVisualStyleBackColor = false;
            btnCancelarOrdenStock.Click += btnCancelarPerdida_Click;
            // 
            // btnRegistrarOrdenStock
            // 
            btnRegistrarOrdenStock.BackColor = Color.FromArgb(0, 125, 62);
            btnRegistrarOrdenStock.FlatAppearance.BorderSize = 0;
            btnRegistrarOrdenStock.FlatStyle = FlatStyle.Flat;
            btnRegistrarOrdenStock.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRegistrarOrdenStock.ForeColor = Color.White;
            btnRegistrarOrdenStock.Location = new Point(30, 214);
            btnRegistrarOrdenStock.Name = "btnRegistrarOrdenStock";
            btnRegistrarOrdenStock.Size = new Size(130, 45);
            btnRegistrarOrdenStock.TabIndex = 5;
            btnRegistrarOrdenStock.Text = "Registrar orden";
            btnRegistrarOrdenStock.UseVisualStyleBackColor = false;
            btnRegistrarOrdenStock.Click += btnRegistrarPerdida2_Click;
            // 
            // txtCantidadOrdenStock
            // 
            txtCantidadOrdenStock.Font = new Font("Segoe UI", 12F);
            txtCantidadOrdenStock.Location = new Point(30, 162);
            txtCantidadOrdenStock.Name = "txtCantidadOrdenStock";
            txtCantidadOrdenStock.PlaceholderText = "Cantidad sugerida";
            txtCantidadOrdenStock.Size = new Size(1129, 34);
            txtCantidadOrdenStock.TabIndex = 4;
            // 
            // lblCantidadOrdenStock
            // 
            lblCantidadOrdenStock.AutoSize = true;
            lblCantidadOrdenStock.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCantidadOrdenStock.ForeColor = Color.FromArgb(44, 62, 80);
            lblCantidadOrdenStock.Location = new Point(30, 127);
            lblCantidadOrdenStock.Name = "lblCantidadOrdenStock";
            lblCantidadOrdenStock.Size = new Size(83, 23);
            lblCantidadOrdenStock.TabIndex = 3;
            lblCantidadOrdenStock.Text = "Cantidad";
            // 
            // dtpFechaOrdenStock
            // 
            dtpFechaOrdenStock.Font = new Font("Segoe UI", 12F);
            dtpFechaOrdenStock.Format = DateTimePickerFormat.Short;
            dtpFechaOrdenStock.Location = new Point(30, 90);
            dtpFechaOrdenStock.Name = "dtpFechaOrdenStock";
            dtpFechaOrdenStock.Size = new Size(1129, 34);
            dtpFechaOrdenStock.TabIndex = 2;
            // 
            // lblFechaOrdenStock
            // 
            lblFechaOrdenStock.AutoSize = true;
            lblFechaOrdenStock.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFechaOrdenStock.ForeColor = Color.FromArgb(44, 62, 80);
            lblFechaOrdenStock.Location = new Point(30, 64);
            lblFechaOrdenStock.Name = "lblFechaOrdenStock";
            lblFechaOrdenStock.Size = new Size(55, 23);
            lblFechaOrdenStock.TabIndex = 1;
            lblFechaOrdenStock.Text = "Fecha";
            // 
            // lblOrdenStockTitle
            // 
            lblOrdenStockTitle.AutoSize = true;
            lblOrdenStockTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblOrdenStockTitle.ForeColor = Color.FromArgb(26, 32, 44);
            lblOrdenStockTitle.Location = new Point(3, 13);
            lblOrdenStockTitle.Name = "lblOrdenStockTitle";
            lblOrdenStockTitle.Size = new Size(434, 32);
            lblOrdenStockTitle.TabIndex = 0;
            lblOrdenStockTitle.Text = "Generar orden por stock insuficiente";
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
            lblMovimientosTitle.Size = new Size(301, 32);
            lblMovimientosTitle.TabIndex = 0;
            lblMovimientosTitle.Text = "Movimientos de almacén";
            // 
            // AlmacenAB
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 933);
            Controls.Add(panelMain);
            Controls.Add(panelNav);
            Controls.Add(panelHeader);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AlmacenAB";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Almacén AB";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelNav.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panelOrdenStock.ResumeLayout(false);
            panelOrdenStock.PerformLayout();
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
        private System.Windows.Forms.Button btnMostrarOrdenStock;
        private System.Windows.Forms.Label lblAlimentoTitle;
        private System.Windows.Forms.Panel panelOrdenStock;
        private System.Windows.Forms.Button btnCancelarOrdenStock;
        private System.Windows.Forms.Button btnRegistrarOrdenStock;
        private System.Windows.Forms.TextBox txtCantidadOrdenStock;
        private System.Windows.Forms.Label lblCantidadOrdenStock;
        private System.Windows.Forms.DateTimePicker dtpFechaOrdenStock;
        private System.Windows.Forms.Label lblFechaOrdenStock;
        private System.Windows.Forms.Label lblOrdenStockTitle;
        private System.Windows.Forms.Label lblFormulaOrden = new();
        private System.Windows.Forms.ComboBox cmbFormulaOrden = new();
        private System.Windows.Forms.Label lblDetalleOrden = new();
        private System.Windows.Forms.TextBox txtDetalleOrden = new();
        private System.Windows.Forms.Panel panelMovimientos;
        private System.Windows.Forms.DataGridView dgvMovimientos;
        private System.Windows.Forms.Label lblMovimientosTitle;
        private System.Windows.Forms.Label lblFiltroDesde = new();
        private System.Windows.Forms.DateTimePicker dtpFiltroDesde = new();
        private System.Windows.Forms.Label lblFiltroHasta = new();
        private System.Windows.Forms.DateTimePicker dtpFiltroHasta = new();
        private System.Windows.Forms.Button btnLimpiarFiltros = new();
    }
}


