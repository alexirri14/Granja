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
            btnDashboard = new Button();
            panelMain = new Panel();
            lblReportesTitle = new Label();
            panelTabs = new Panel();
            btnStockActual = new Button();
            btnProduccionGalpon = new Button();
            panelContenido = new Panel();
            panelHeader.SuspendLayout();
            panelNav.SuspendLayout();
            panelMain.SuspendLayout();
            panelTabs.SuspendLayout();
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
            btnReportes.ForeColor = Color.FromArgb(0, 125, 62);
            btnReportes.Location = new Point(551, 1);
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
            btnMolino.Location = new Point(414, 3);
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
            btnInsumos.Location = new Point(289, 3);
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
            btnAlimento.Location = new Point(146, 3);
            btnAlimento.Margin = new Padding(3, 4, 3, 4);
            btnAlimento.Name = "btnAlimento";
            btnAlimento.Size = new Size(137, 67);
            btnAlimento.TabIndex = 4;
            btnAlimento.Text = "Alimento";
            btnAlimento.UseVisualStyleBackColor = true;
            btnAlimento.Click += btnAlimento_Click;
            // 
            // btnVentas
            // 
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Segoe UI", 10F);
            btnVentas.Location = new Point(409, 4);
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
            btnAlmacen.Location = new Point(280, 2);
            btnAlmacen.Margin = new Padding(3, 4, 3, 4);
            btnAlmacen.Name = "btnAlmacen";
            btnAlmacen.Size = new Size(137, 67);
            btnAlmacen.TabIndex = 2;
            btnAlmacen.Text = "Almacén";
            btnAlmacen.UseVisualStyleBackColor = true;
            btnAlmacen.Click += btnAlmacen_Click;
            // 
            // btnProduccion
            // 
            btnProduccion.FlatAppearance.BorderSize = 0;
            btnProduccion.FlatStyle = FlatStyle.Flat;
            btnProduccion.Font = new Font("Segoe UI", 10F);
            btnProduccion.Location = new Point(137, 2);
            btnProduccion.Margin = new Padding(3, 4, 3, 4);
            btnProduccion.Name = "btnProduccion";
            btnProduccion.Size = new Size(137, 67);
            btnProduccion.TabIndex = 1;
            btnProduccion.Text = "Producción";
            btnProduccion.UseVisualStyleBackColor = true;
            btnProduccion.Click += btnProduccion_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 10F);
            btnDashboard.Location = new Point(12, 3);
            btnDashboard.Margin = new Padding(3, 4, 3, 4);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(128, 67);
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
            lblReportesTitle.Text = "Reportes";
            // 
            // panelTabs
            // 
            panelTabs.BackColor = Color.White;
            panelTabs.Controls.Add(btnStockActual);
            panelTabs.Controls.Add(btnProduccionGalpon);
            panelTabs.Location = new Point(34, 100);
            panelTabs.Margin = new Padding(3, 4, 3, 4);
            panelTabs.Name = "panelTabs";
            panelTabs.Padding = new Padding(20);
            panelTabs.Size = new Size(1189, 90);
            panelTabs.TabIndex = 1;
            // 
            // btnStockActual
            // 
            btnStockActual.BackColor = Color.FromArgb(230, 230, 230);
            btnStockActual.FlatAppearance.BorderSize = 0;
            btnStockActual.FlatStyle = FlatStyle.Flat;
            btnStockActual.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnStockActual.ForeColor = Color.FromArgb(44, 62, 80);
            btnStockActual.Location = new Point(306, 20);
            btnStockActual.Name = "btnStockActual";
            btnStockActual.Size = new Size(280, 50);
            btnStockActual.TabIndex = 3;
            btnStockActual.Text = "Stock actual";
            btnStockActual.UseVisualStyleBackColor = false;
            // 
            // btnVentasDiarias
            // 
            btnVentasDiarias.BackColor = Color.FromArgb(230, 230, 230);
            btnVentasDiarias.FlatAppearance.BorderSize = 0;
            btnVentasDiarias.FlatStyle = FlatStyle.Flat;
            btnVentasDiarias.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnVentasDiarias.ForeColor = Color.FromArgb(44, 62, 80);
            btnVentasDiarias.Location = new Point(590, 20);
            btnVentasDiarias.Name = "btnVentasDiarias";
            btnVentasDiarias.Size = new Size(280, 50);
            btnVentasDiarias.TabIndex = 2;
            btnVentasDiarias.Text = "Producción";
            btnVentasDiarias.UseVisualStyleBackColor = false;
            // 
            // btnFlujoHuevos
            // 
            btnFlujoHuevos.BackColor = Color.FromArgb(230, 230, 230);
            btnFlujoHuevos.FlatAppearance.BorderSize = 0;
            btnFlujoHuevos.FlatStyle = FlatStyle.Flat;
            btnFlujoHuevos.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnFlujoHuevos.ForeColor = Color.FromArgb(44, 62, 80);
            btnFlujoHuevos.Location = new Point(300, 20);
            btnFlujoHuevos.Name = "btnFlujoHuevos";
            btnFlujoHuevos.Size = new Size(280, 50);
            btnFlujoHuevos.TabIndex = 1;
            btnFlujoHuevos.Text = "Órdenes";
            btnFlujoHuevos.UseVisualStyleBackColor = false;
            // 
            // btnProduccionGalpon
            // 
            btnProduccionGalpon.BackColor = Color.FromArgb(0, 125, 62);
            btnProduccionGalpon.FlatAppearance.BorderSize = 0;
            btnProduccionGalpon.FlatStyle = FlatStyle.Flat;
            btnProduccionGalpon.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnProduccionGalpon.ForeColor = Color.White;
            btnProduccionGalpon.Location = new Point(10, 20);
            btnProduccionGalpon.Name = "btnProduccionGalpon";
            btnProduccionGalpon.Size = new Size(280, 50);
            btnProduccionGalpon.TabIndex = 0;
            btnProduccionGalpon.Text = "[Cambiar de nombre]";
            btnProduccionGalpon.UseVisualStyleBackColor = false;
            // 
            // panelContenido
            // 
            panelContenido.Location = new Point(34, 197);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(1189, 553);
            panelContenido.TabIndex = 2;
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
            Text = "Reportes - Rancho del Buen Pastor";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelNav.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panelTabs.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnAlimento;
        private System.Windows.Forms.Button btnInsumos;
        private System.Windows.Forms.Button btnMolino;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblReportesTitle;
        private System.Windows.Forms.Panel panelTabs;
        private System.Windows.Forms.Button btnStockActual;
        private System.Windows.Forms.Panel panelContenido;
        private Button btnProduccionGalpon;
    }
}

