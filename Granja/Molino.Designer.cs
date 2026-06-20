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
            btnDashboard = new Button();
            panelMain = new Panel();
            panelRegistro = new Panel();
            btnRegistrarProduccion = new Button();
            txtCantidadSacos = new TextBox();
            lblCantidadSacos = new Label();
            txtNombreLote = new TextBox();
            lblNombreLote = new Label();
            linkAgregarInsumo = new LinkLabel();
            panelInsumos = new Panel();
            panelHistorial = new Panel();
            dgvHistorial = new DataGridView();
            lblHistorialTitle = new Label();
            lblMolinoTitle = new Label();
            panelHeader.SuspendLayout();
            panelNav.SuspendLayout();
            panelMain.SuspendLayout();
            panelRegistro.SuspendLayout();
            panelHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
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
            btnReportes.Location = new Point(555, 3);
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
            btnMolino.ForeColor = Color.FromArgb(0, 125, 62);
            btnMolino.Location = new Point(418, 3);
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
            btnInsumos.Location = new Point(281, 3);
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
            btnAlimento.Location = new Point(144, 3);
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
            btnVentas.Text = " Administrador";
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
            btnDashboard.Location = new Point(8, 3);
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
            panelMain.Controls.Add(panelRegistro);
            panelMain.Controls.Add(panelHistorial);
            panelMain.Controls.Add(lblMolinoTitle);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 153);
            panelMain.Margin = new Padding(3, 4, 3, 4);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(34, 40, 34, 40);
            panelMain.Size = new Size(1257, 780);
            panelMain.TabIndex = 2;
            // 
            // panelRegistro
            // 
            panelRegistro.BackColor = Color.White;
            panelRegistro.Controls.Add(btnRegistrarProduccion);
            panelRegistro.Controls.Add(txtCantidadSacos);
            panelRegistro.Controls.Add(lblCantidadSacos);
            panelRegistro.Controls.Add(txtNombreLote);
            panelRegistro.Controls.Add(lblNombreLote);
            panelRegistro.Controls.Add(linkAgregarInsumo);
            panelRegistro.Controls.Add(panelInsumos);
            panelRegistro.Location = new Point(34, 100);
            panelRegistro.Margin = new Padding(3, 4, 3, 4);
            panelRegistro.Name = "panelRegistro";
            panelRegistro.Padding = new Padding(30);
            panelRegistro.Size = new Size(1189, 380);
            panelRegistro.TabIndex = 3;
            // 
            // btnRegistrarProduccion
            // 
            btnRegistrarProduccion.BackColor = Color.FromArgb(0, 125, 62);
            btnRegistrarProduccion.FlatAppearance.BorderSize = 0;
            btnRegistrarProduccion.FlatStyle = FlatStyle.Flat;
            btnRegistrarProduccion.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRegistrarProduccion.ForeColor = Color.White;
            btnRegistrarProduccion.Location = new Point(258, 323);
            btnRegistrarProduccion.Name = "btnRegistrarProduccion";
            btnRegistrarProduccion.Size = new Size(200, 45);
            btnRegistrarProduccion.TabIndex = 6;
            btnRegistrarProduccion.Text = "Registrar producción";
            btnRegistrarProduccion.UseVisualStyleBackColor = false;
            // 
            // txtCantidadSacos
            // 
            txtCantidadSacos.Font = new Font("Segoe UI", 12F);
            txtCantidadSacos.Location = new Point(600, 271);
            txtCantidadSacos.Name = "txtCantidadSacos";
            txtCantidadSacos.PlaceholderText = "Cantidad a producir";
            txtCantidadSacos.Size = new Size(559, 34);
            txtCantidadSacos.TabIndex = 5;
            // 
            // lblCantidadSacos
            // 
            lblCantidadSacos.AutoSize = true;
            lblCantidadSacos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCantidadSacos.ForeColor = Color.FromArgb(44, 62, 80);
            lblCantidadSacos.Location = new Point(600, 245);
            lblCantidadSacos.Name = "lblCantidadSacos";
            lblCantidadSacos.Size = new Size(170, 23);
            lblCantidadSacos.TabIndex = 4;
            lblCantidadSacos.Text = "Cantidad a procesar";
            // 
            // txtNombreLote
            // 
            txtNombreLote.Font = new Font("Segoe UI", 12F);
            txtNombreLote.Location = new Point(30, 271);
            txtNombreLote.Name = "txtNombreLote";
            txtNombreLote.PlaceholderText = "Observación del proceso";
            txtNombreLote.Size = new Size(559, 34);
            txtNombreLote.TabIndex = 3;
            // 
            // lblNombreLote
            // 
            lblNombreLote.AutoSize = true;
            lblNombreLote.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNombreLote.ForeColor = Color.FromArgb(44, 62, 80);
            lblNombreLote.Location = new Point(30, 245);
            lblNombreLote.Name = "lblNombreLote";
            lblNombreLote.Size = new Size(67, 23);
            lblNombreLote.TabIndex = 2;
            lblNombreLote.Text = "Detalle";
            // 
            // linkAgregarInsumo
            // 
            linkAgregarInsumo.AutoSize = true;
            linkAgregarInsumo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            linkAgregarInsumo.LinkColor = Color.FromArgb(0, 125, 62);
            linkAgregarInsumo.Location = new Point(23, 335);
            linkAgregarInsumo.Name = "linkAgregarInsumo";
            linkAgregarInsumo.Size = new Size(229, 23);
            linkAgregarInsumo.TabIndex = 1;
            linkAgregarInsumo.TabStop = true;
            linkAgregarInsumo.Text = "Registrar salida de insumos";
            // 
            // panelInsumos
            // 
            panelInsumos.Location = new Point(30, 12);
            panelInsumos.Name = "panelInsumos";
            panelInsumos.Size = new Size(1129, 171);
            panelInsumos.TabIndex = 0;
            // 
            // panelHistorial
            // 
            panelHistorial.BackColor = Color.White;
            panelHistorial.Controls.Add(dgvHistorial);
            panelHistorial.Controls.Add(lblHistorialTitle);
            panelHistorial.Location = new Point(34, 500);
            panelHistorial.Margin = new Padding(3, 4, 3, 4);
            panelHistorial.Name = "panelHistorial";
            panelHistorial.Padding = new Padding(30);
            panelHistorial.Size = new Size(1189, 360);
            panelHistorial.TabIndex = 2;
            // 
            // dgvHistorial
            // 
            dgvHistorial.AllowUserToAddRows = false;
            dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorial.BackgroundColor = Color.White;
            dgvHistorial.BorderStyle = BorderStyle.None;
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Location = new Point(30, 70);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.RowHeadersVisible = false;
            dgvHistorial.RowHeadersWidth = 51;
            dgvHistorial.Size = new Size(1129, 260);
            dgvHistorial.TabIndex = 1;
            // 
            // lblHistorialTitle
            // 
            lblHistorialTitle.AutoSize = true;
            lblHistorialTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblHistorialTitle.ForeColor = Color.FromArgb(26, 32, 44);
            lblHistorialTitle.Location = new Point(13, 10);
            lblHistorialTitle.Name = "lblHistorialTitle";
            lblHistorialTitle.Size = new Size(268, 32);
            lblHistorialTitle.TabIndex = 0;
            lblHistorialTitle.Text = "Producción registrada";
            lblHistorialTitle.Click += lblHistorialTitle_Click;
            // 
            // lblMolinoTitle
            // 
            lblMolinoTitle.AutoSize = true;
            lblMolinoTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblMolinoTitle.ForeColor = Color.FromArgb(26, 32, 44);
            lblMolinoTitle.Location = new Point(34, 20);
            lblMolinoTitle.Name = "lblMolinoTitle";
            lblMolinoTitle.Size = new Size(281, 41);
            lblMolinoTitle.TabIndex = 1;
            lblMolinoTitle.Text = "Módulo de Molino";
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
            Text = "Molino - Rancho del Buen Pastor";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelNav.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panelRegistro.ResumeLayout(false);
            panelRegistro.PerformLayout();
            panelHistorial.ResumeLayout(false);
            panelHistorial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
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
        private System.Windows.Forms.Button btnInsumos;
        private System.Windows.Forms.Button btnMolino;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelHistorial;
        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.Label lblHistorialTitle;
        private System.Windows.Forms.Label lblMolinoTitle;
        private System.Windows.Forms.Panel panelRegistro;
        private System.Windows.Forms.Panel panelInsumos;
        private System.Windows.Forms.LinkLabel linkAgregarInsumo;
        private System.Windows.Forms.TextBox txtCantidadSacos;
        private System.Windows.Forms.Label lblCantidadSacos;
        private System.Windows.Forms.TextBox txtNombreLote;
        private System.Windows.Forms.Label lblNombreLote;
        private System.Windows.Forms.Button btnRegistrarProduccion;
    }
}

