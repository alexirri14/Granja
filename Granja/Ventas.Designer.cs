namespace Granja
{
    partial class Ventas
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
            btnDashboard = new Button();
            panelMain = new Panel();
            panelHistorial = new Panel();
            lblTotalVentas = new Label();
            lblTotalVentasLabel = new Label();
            dgvVentas = new DataGridView();
            lblHistorialTitle = new Label();
            panelRegistro = new Panel();
            btnRegistrarVenta = new Button();
            panelTotal = new Panel();
            lblTotal = new Label();
            lblTotalLabel = new Label();
            txtPrecio = new TextBox();
            lblPrecio = new Label();
            txtCantidad = new TextBox();
            lblCantidad = new Label();
            txtCliente = new TextBox();
            lblCliente = new Label();
            lblRegistroTitle = new Label();
            panelHeader.SuspendLayout();
            panelNav.SuspendLayout();
            panelMain.SuspendLayout();
            panelHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            panelRegistro.SuspendLayout();
            panelTotal.SuspendLayout();
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
            btnReportes.Location = new Point(690, 2);
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
            btnMolino.Location = new Point(553, 2);
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
            btnInsumos.Location = new Point(416, 2);
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
            btnAlimento.Location = new Point(279, 2);
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
            btnVentas.ForeColor = Color.FromArgb(0, 125, 62);
            btnVentas.Location = new Point(142, 2);
            btnVentas.Margin = new Padding(3, 4, 3, 4);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(137, 67);
            btnVentas.TabIndex = 3;
            btnVentas.Text = " Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 10F);
            btnDashboard.Location = new Point(9, 3);
            btnDashboard.Margin = new Padding(3, 4, 3, 4);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(130, 67);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = " Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panelMain
            // 
            panelMain.AutoScroll = true;
            panelMain.BackColor = Color.FromArgb(248, 249, 250);
            panelMain.Controls.Add(panelHistorial);
            panelMain.Controls.Add(panelRegistro);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 153);
            panelMain.Margin = new Padding(3, 4, 3, 4);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(34, 40, 34, 40);
            panelMain.Size = new Size(1257, 780);
            panelMain.TabIndex = 2;
            // 
            // panelHistorial
            // 
            panelHistorial.BackColor = Color.White;
            panelHistorial.Controls.Add(lblTotalVentas);
            panelHistorial.Controls.Add(lblTotalVentasLabel);
            panelHistorial.Controls.Add(dgvVentas);
            panelHistorial.Controls.Add(lblHistorialTitle);
            panelHistorial.Location = new Point(34, 380);
            panelHistorial.Margin = new Padding(3, 4, 3, 4);
            panelHistorial.Name = "panelHistorial";
            panelHistorial.Padding = new Padding(30);
            panelHistorial.Size = new Size(1189, 400);
            panelHistorial.TabIndex = 1;
            // 
            // lblTotalVentas
            // 
            lblTotalVentas.AutoSize = true;
            lblTotalVentas.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTotalVentas.ForeColor = Color.FromArgb(0, 125, 62);
            lblTotalVentas.Location = new Point(850, 330);
            lblTotalVentas.Name = "lblTotalVentas";
            lblTotalVentas.Size = new Size(192, 46);
            lblTotalVentas.TabIndex = 3;
            lblTotalVentas.Text = "S/ 5625.00";
            // 
            // lblTotalVentasLabel
            // 
            lblTotalVentasLabel.AutoSize = true;
            lblTotalVentasLabel.Font = new Font("Segoe UI", 10F);
            lblTotalVentasLabel.ForeColor = Color.Gray;
            lblTotalVentasLabel.Location = new Point(850, 300);
            lblTotalVentasLabel.Name = "lblTotalVentasLabel";
            lblTotalVentasLabel.Size = new Size(100, 23);
            lblTotalVentasLabel.TabIndex = 2;
            lblTotalVentasLabel.Text = "Total ventas";
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentas.BackgroundColor = Color.White;
            dgvVentas.BorderStyle = BorderStyle.None;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(30, 70);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.RowHeadersVisible = false;
            dgvVentas.RowHeadersWidth = 51;
            dgvVentas.Size = new Size(1129, 220);
            dgvVentas.TabIndex = 1;
            // 
            // lblHistorialTitle
            // 
            lblHistorialTitle.AutoSize = true;
            lblHistorialTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHistorialTitle.ForeColor = Color.FromArgb(26, 32, 44);
            lblHistorialTitle.Location = new Point(0, 0);
            lblHistorialTitle.Name = "lblHistorialTitle";
            lblHistorialTitle.Size = new Size(258, 37);
            lblHistorialTitle.TabIndex = 0;
            lblHistorialTitle.Text = "Historial de ventas";
            // 
            // panelRegistro
            // 
            panelRegistro.BackColor = Color.White;
            panelRegistro.Controls.Add(btnRegistrarVenta);
            panelRegistro.Controls.Add(panelTotal);
            panelRegistro.Controls.Add(txtPrecio);
            panelRegistro.Controls.Add(lblPrecio);
            panelRegistro.Controls.Add(txtCantidad);
            panelRegistro.Controls.Add(lblCantidad);
            panelRegistro.Controls.Add(txtCliente);
            panelRegistro.Controls.Add(lblCliente);
            panelRegistro.Controls.Add(lblRegistroTitle);
            panelRegistro.Location = new Point(34, 40);
            panelRegistro.Margin = new Padding(3, 4, 3, 4);
            panelRegistro.Name = "panelRegistro";
            panelRegistro.Padding = new Padding(30);
            panelRegistro.Size = new Size(1189, 320);
            panelRegistro.TabIndex = 0;
            // 
            // btnRegistrarVenta
            // 
            btnRegistrarVenta.BackColor = Color.FromArgb(0, 125, 62);
            btnRegistrarVenta.FlatAppearance.BorderSize = 0;
            btnRegistrarVenta.FlatStyle = FlatStyle.Flat;
            btnRegistrarVenta.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRegistrarVenta.ForeColor = Color.White;
            btnRegistrarVenta.Location = new Point(30, 260);
            btnRegistrarVenta.Name = "btnRegistrarVenta";
            btnRegistrarVenta.Size = new Size(1129, 55);
            btnRegistrarVenta.TabIndex = 8;
            btnRegistrarVenta.Text = "Registrar venta";
            btnRegistrarVenta.UseVisualStyleBackColor = false;
            // 
            // panelTotal
            // 
            panelTotal.BackColor = Color.FromArgb(240, 255, 240);
            panelTotal.Controls.Add(lblTotal);
            panelTotal.Controls.Add(lblTotalLabel);
            panelTotal.Location = new Point(30, 190);
            panelTotal.Name = "panelTotal";
            panelTotal.Size = new Size(1129, 60);
            panelTotal.TabIndex = 7;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(0, 125, 62);
            lblTotal.Location = new Point(1000, 10);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(140, 41);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "$ S/ 0.00";
            // 
            // lblTotalLabel
            // 
            lblTotalLabel.AutoSize = true;
            lblTotalLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalLabel.ForeColor = Color.FromArgb(44, 62, 80);
            lblTotalLabel.Location = new Point(20, 15);
            lblTotalLabel.Name = "lblTotalLabel";
            lblTotalLabel.Size = new Size(64, 28);
            lblTotalLabel.TabIndex = 0;
            lblTotalLabel.Text = "Total:";
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Segoe UI", 12F);
            txtPrecio.Location = new Point(600, 110);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.PlaceholderText = "7.5";
            txtPrecio.Size = new Size(559, 34);
            txtPrecio.TabIndex = 6;
            txtPrecio.Text = "7.5";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPrecio.ForeColor = Color.FromArgb(44, 62, 80);
            lblPrecio.Location = new Point(600, 80);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(180, 23);
            lblPrecio.TabIndex = 5;
            lblPrecio.Text = "Precio por huevo (S/)";
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Segoe UI", 12F);
            txtCantidad.Location = new Point(30, 110);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.PlaceholderText = "Número de huevos";
            txtCantidad.Size = new Size(559, 34);
            txtCantidad.TabIndex = 4;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCantidad.ForeColor = Color.FromArgb(44, 62, 80);
            lblCantidad.Location = new Point(30, 80);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(155, 23);
            lblCantidad.TabIndex = 3;
            lblCantidad.Text = "Cantidad (huevos)";
            // 
            // txtCliente
            // 
            txtCliente.Font = new Font("Segoe UI", 12F);
            txtCliente.Location = new Point(30, 45);
            txtCliente.Name = "txtCliente";
            txtCliente.PlaceholderText = "Nombre del cliente";
            txtCliente.Size = new Size(1129, 34);
            txtCliente.TabIndex = 2;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCliente.ForeColor = Color.FromArgb(44, 62, 80);
            lblCliente.Location = new Point(0, 15);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(66, 23);
            lblCliente.TabIndex = 1;
            lblCliente.Text = "Cliente";
            // 
            // lblRegistroTitle
            // 
            lblRegistroTitle.AutoSize = true;
            lblRegistroTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblRegistroTitle.ForeColor = Color.FromArgb(26, 32, 44);
            lblRegistroTitle.Location = new Point(0, 0);
            lblRegistroTitle.Name = "lblRegistroTitle";
            lblRegistroTitle.Size = new Size(280, 41);
            lblRegistroTitle.TabIndex = 0;
            lblRegistroTitle.Text = "Registro de Ventas";
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 933);
            Controls.Add(panelMain);
            Controls.Add(panelNav);
            Controls.Add(panelHeader);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Ventas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ventas - Rancho del Buen Pastor";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelNav.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            panelHistorial.ResumeLayout(false);
            panelHistorial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            panelRegistro.ResumeLayout(false);
            panelRegistro.PerformLayout();
            panelTotal.ResumeLayout(false);
            panelTotal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnAlimento;
        private System.Windows.Forms.Button btnInsumos;
        private System.Windows.Forms.Button btnMolino;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelRegistro;
        private System.Windows.Forms.Label lblRegistroTitle;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Panel panelTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalLabel;
        private System.Windows.Forms.Button btnRegistrarVenta;
        private System.Windows.Forms.Panel panelHistorial;
        private System.Windows.Forms.Label lblHistorialTitle;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Label lblTotalVentas;
        private System.Windows.Forms.Label lblTotalVentasLabel;
    }
}
