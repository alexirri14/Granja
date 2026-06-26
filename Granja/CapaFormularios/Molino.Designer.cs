namespace Granja
{
    partial class Molino
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
            panelRegistroProduccionMolino = new Panel();
            btnRegistrarProduccionMolino = new Button();
            txtCantidadProduccionMolino = new TextBox();
            lblCantidadProduccionMolino = new Label();
            txtDetalleProduccionMolino = new TextBox();
            lblDetalleProduccionMolino = new Label();
            linkSalidaInsumosMolino = new LinkLabel();
            panelRequerimientoInsumos = new Panel();
            panelHistorialProduccionMolino = new Panel();
            dgvHistorialProduccionMolino = new DataGridView();
            lblHistorialProduccionMolinoTitle = new Label();
            lblModuloMolinoTitle = new Label();
            panelHeader.SuspendLayout();
            panelNav.SuspendLayout();
            panelMain.SuspendLayout();
            panelRegistroProduccionMolino.SuspendLayout();
            panelHistorialProduccionMolino.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorialProduccionMolino).BeginInit();
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
            btnMolino.ForeColor = Color.FromArgb(0, 125, 62);
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
            panelMain.Controls.Add(panelRegistroProduccionMolino);
            panelMain.Controls.Add(panelHistorialProduccionMolino);
            panelMain.Controls.Add(lblModuloMolinoTitle);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 153);
            panelMain.Margin = new Padding(3, 4, 3, 4);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(34, 40, 34, 40);
            panelMain.Size = new Size(1257, 780);
            panelMain.TabIndex = 2;
            // 
            // panelRegistroProduccionMolino
            // 
            panelRegistroProduccionMolino.BackColor = Color.White;
            panelRegistroProduccionMolino.Controls.Add(btnRegistrarProduccionMolino);
            panelRegistroProduccionMolino.Controls.Add(txtCantidadProduccionMolino);
            panelRegistroProduccionMolino.Controls.Add(lblCantidadProduccionMolino);
            panelRegistroProduccionMolino.Controls.Add(txtDetalleProduccionMolino);
            panelRegistroProduccionMolino.Controls.Add(lblDetalleProduccionMolino);
            panelRegistroProduccionMolino.Controls.Add(linkSalidaInsumosMolino);
            panelRegistroProduccionMolino.Controls.Add(panelRequerimientoInsumos);
            panelRegistroProduccionMolino.Location = new Point(34, 100);
            panelRegistroProduccionMolino.Margin = new Padding(3, 4, 3, 4);
            panelRegistroProduccionMolino.Name = "panelRegistroProduccionMolino";
            panelRegistroProduccionMolino.Padding = new Padding(30);
            panelRegistroProduccionMolino.Size = new Size(1189, 380);
            panelRegistroProduccionMolino.TabIndex = 3;
            // 
            // btnRegistrarProduccionMolino
            // 
            btnRegistrarProduccionMolino.BackColor = Color.FromArgb(0, 125, 62);
            btnRegistrarProduccionMolino.FlatAppearance.BorderSize = 0;
            btnRegistrarProduccionMolino.FlatStyle = FlatStyle.Flat;
            btnRegistrarProduccionMolino.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRegistrarProduccionMolino.ForeColor = Color.White;
            btnRegistrarProduccionMolino.Location = new Point(326, 323);
            btnRegistrarProduccionMolino.Name = "btnRegistrarProduccionMolino";
            btnRegistrarProduccionMolino.Size = new Size(200, 45);
            btnRegistrarProduccionMolino.TabIndex = 6;
            btnRegistrarProduccionMolino.Text = "Registrar producción";
            btnRegistrarProduccionMolino.UseVisualStyleBackColor = false;
            // 
            // txtCantidadProduccionMolino
            // 
            txtCantidadProduccionMolino.Font = new Font("Segoe UI", 12F);
            txtCantidadProduccionMolino.Location = new Point(600, 271);
            txtCantidadProduccionMolino.Name = "txtCantidadProduccionMolino";
            txtCantidadProduccionMolino.PlaceholderText = "Cantidad a producir";
            txtCantidadProduccionMolino.Size = new Size(559, 34);
            txtCantidadProduccionMolino.TabIndex = 5;
            // 
            // lblCantidadProduccionMolino
            // 
            lblCantidadProduccionMolino.AutoSize = true;
            lblCantidadProduccionMolino.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCantidadProduccionMolino.ForeColor = Color.FromArgb(44, 62, 80);
            lblCantidadProduccionMolino.Location = new Point(600, 245);
            lblCantidadProduccionMolino.Name = "lblCantidadProduccionMolino";
            lblCantidadProduccionMolino.Size = new Size(170, 23);
            lblCantidadProduccionMolino.TabIndex = 4;
            lblCantidadProduccionMolino.Text = "Cantidad a procesar";
            // 
            // txtDetalleProduccionMolino
            // 
            txtDetalleProduccionMolino.Font = new Font("Segoe UI", 12F);
            txtDetalleProduccionMolino.Location = new Point(30, 271);
            txtDetalleProduccionMolino.Name = "txtDetalleProduccionMolino";
            txtDetalleProduccionMolino.PlaceholderText = "Observación del proceso";
            txtDetalleProduccionMolino.Size = new Size(559, 34);
            txtDetalleProduccionMolino.TabIndex = 3;
            // 
            // lblDetalleProduccionMolino
            // 
            lblDetalleProduccionMolino.AutoSize = true;
            lblDetalleProduccionMolino.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDetalleProduccionMolino.ForeColor = Color.FromArgb(44, 62, 80);
            lblDetalleProduccionMolino.Location = new Point(30, 245);
            lblDetalleProduccionMolino.Name = "lblDetalleProduccionMolino";
            lblDetalleProduccionMolino.Size = new Size(67, 23);
            lblDetalleProduccionMolino.TabIndex = 2;
            lblDetalleProduccionMolino.Text = "Detalle";
            // 
            // linkSalidaInsumosMolino
            // 
            linkSalidaInsumosMolino.AutoSize = true;
            linkSalidaInsumosMolino.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            linkSalidaInsumosMolino.LinkColor = Color.FromArgb(0, 125, 62);
            linkSalidaInsumosMolino.Location = new Point(23, 335);
            linkSalidaInsumosMolino.Name = "linkSalidaInsumosMolino";
            linkSalidaInsumosMolino.Size = new Size(282, 23);
            linkSalidaInsumosMolino.TabIndex = 1;
            linkSalidaInsumosMolino.TabStop = true;
            linkSalidaInsumosMolino.Text = "Salida automática por producción";
            // 
            // panelRequerimientoInsumos
            // 
            panelRequerimientoInsumos.BorderStyle = BorderStyle.FixedSingle;
            panelRequerimientoInsumos.Location = new Point(30, 12);
            panelRequerimientoInsumos.Name = "panelRequerimientoInsumos";
            panelRequerimientoInsumos.Size = new Size(1129, 171);
            panelRequerimientoInsumos.TabIndex = 0;
            // 
            // panelHistorialProduccionMolino
            // 
            panelHistorialProduccionMolino.BackColor = Color.White;
            panelHistorialProduccionMolino.Controls.Add(dgvHistorialProduccionMolino);
            panelHistorialProduccionMolino.Controls.Add(lblHistorialProduccionMolinoTitle);
            panelHistorialProduccionMolino.Location = new Point(34, 500);
            panelHistorialProduccionMolino.Margin = new Padding(3, 4, 3, 4);
            panelHistorialProduccionMolino.Name = "panelHistorialProduccionMolino";
            panelHistorialProduccionMolino.Padding = new Padding(30);
            panelHistorialProduccionMolino.Size = new Size(1189, 360);
            panelHistorialProduccionMolino.TabIndex = 2;
            // 
            // dgvHistorialProduccionMolino
            // 
            dgvHistorialProduccionMolino.AllowUserToAddRows = false;
            dgvHistorialProduccionMolino.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorialProduccionMolino.BackgroundColor = Color.White;
            dgvHistorialProduccionMolino.BorderStyle = BorderStyle.None;
            dgvHistorialProduccionMolino.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorialProduccionMolino.Location = new Point(30, 70);
            dgvHistorialProduccionMolino.Name = "dgvHistorialProduccionMolino";
            dgvHistorialProduccionMolino.RowHeadersVisible = false;
            dgvHistorialProduccionMolino.RowHeadersWidth = 51;
            dgvHistorialProduccionMolino.Size = new Size(1129, 260);
            dgvHistorialProduccionMolino.TabIndex = 1;
            // 
            // lblHistorialProduccionMolinoTitle
            // 
            lblHistorialProduccionMolinoTitle.AutoSize = true;
            lblHistorialProduccionMolinoTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblHistorialProduccionMolinoTitle.ForeColor = Color.FromArgb(26, 32, 44);
            lblHistorialProduccionMolinoTitle.Location = new Point(13, 10);
            lblHistorialProduccionMolinoTitle.Name = "lblHistorialProduccionMolinoTitle";
            lblHistorialProduccionMolinoTitle.Size = new Size(284, 32);
            lblHistorialProduccionMolinoTitle.TabIndex = 0;
            lblHistorialProduccionMolinoTitle.Text = "Historial de producción";
            lblHistorialProduccionMolinoTitle.Click += lblHistorialTitle_Click;
            // 
            // lblModuloMolinoTitle
            // 
            lblModuloMolinoTitle.AutoSize = true;
            lblModuloMolinoTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblModuloMolinoTitle.ForeColor = Color.FromArgb(26, 32, 44);
            lblModuloMolinoTitle.Location = new Point(34, 20);
            lblModuloMolinoTitle.Name = "lblModuloMolinoTitle";
            lblModuloMolinoTitle.Size = new Size(281, 41);
            lblModuloMolinoTitle.TabIndex = 1;
            lblModuloMolinoTitle.Text = "Módulo de Molino";
            // 
            // Molino
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 933);
            Controls.Add(panelMain);
            Controls.Add(panelNav);
            Controls.Add(panelHeader);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Molino";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Molino";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelNav.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panelRegistroProduccionMolino.ResumeLayout(false);
            panelRegistroProduccionMolino.PerformLayout();
            panelHistorialProduccionMolino.ResumeLayout(false);
            panelHistorialProduccionMolino.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorialProduccionMolino).EndInit();
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
        private System.Windows.Forms.Panel panelHistorialProduccionMolino;
        private System.Windows.Forms.DataGridView dgvHistorialProduccionMolino;
        private System.Windows.Forms.Label lblHistorialProduccionMolinoTitle;
        private System.Windows.Forms.Label lblModuloMolinoTitle;
        private System.Windows.Forms.Panel panelRegistroProduccionMolino;
        private System.Windows.Forms.Panel panelRequerimientoInsumos;
        private System.Windows.Forms.Label lblRequerimientoInsumosTitle = new();
        private System.Windows.Forms.Label lblRequerimientoInsumosDetalle = new();
        private System.Windows.Forms.LinkLabel linkSalidaInsumosMolino;
        private System.Windows.Forms.Label lblOrdenProduccionMolino = new();
        private System.Windows.Forms.ComboBox cmbOrdenProduccionMolino = new();
        private System.Windows.Forms.Label lblSalidaInsumosMolino = new();
        private System.Windows.Forms.Label lblSalidaInsumosInfoMolino = new();
        private System.Windows.Forms.TextBox txtCantidadProduccionMolino;
        private System.Windows.Forms.Label lblCantidadProduccionMolino;
        private System.Windows.Forms.TextBox txtDetalleProduccionMolino;
        private System.Windows.Forms.Label lblDetalleProduccionMolino;
        private System.Windows.Forms.Button btnRegistrarProduccionMolino;
        private System.Windows.Forms.Label lblFiltroDesde = new();
        private System.Windows.Forms.DateTimePicker dtpFiltroDesde = new();
        private System.Windows.Forms.Label lblFiltroHasta = new();
        private System.Windows.Forms.DateTimePicker dtpFiltroHasta = new();
        private System.Windows.Forms.Button btnLimpiarFiltros = new();
    }
}


