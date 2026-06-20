namespace Granja
{
    partial class Alimento
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
            lblStockTotal = new Label();
            lblStockLabel = new Label();
            btnRegistrarPerdida = new Button();
            lblAlimentoTitle = new Label();
            panelNuevoPerdida = new Panel();
            btnCancelarPerdida = new Button();
            btnRegistrarPerdida2 = new Button();
            txtCantidadPerdida = new TextBox();
            lblCantidadPerdida = new Label();
            dtpFechaPerdida = new DateTimePicker();
            lblFechaPerdida = new Label();
            lblNuevoPerdidaTitle = new Label();
            panelMovimientos = new Panel();
            dgvMovimientos = new DataGridView();
            lblMovimientosTitle = new Label();
            panelHeader.SuspendLayout();
            panelNav.SuspendLayout();
            panelMain.SuspendLayout();
            panelNuevoPerdida.SuspendLayout();
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
            btnReportes.Location = new Point(556, 2);
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
            btnMolino.Location = new Point(419, 2);
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
            btnInsumos.Location = new Point(282, 2);
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
            btnAlimento.ForeColor = Color.FromArgb(0, 125, 62);
            btnAlimento.Location = new Point(145, 2);
            btnAlimento.Margin = new Padding(3, 4, 3, 4);
            btnAlimento.Name = "btnAlimento";
            btnAlimento.Size = new Size(137, 67);
            btnAlimento.TabIndex = 4;
            btnAlimento.Text = " Alimento";
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
            panelMain.Controls.Add(btnRegistrarPerdida);
            panelMain.Controls.Add(lblAlimentoTitle);
            panelMain.Controls.Add(panelNuevoPerdida);
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
            lblStockTotal.Size = new Size(174, 46);
            lblStockTotal.TabIndex = 6;
            lblStockTotal.Text = "300 sacos";
            // 
            // lblStockLabel
            // 
            lblStockLabel.AutoSize = true;
            lblStockLabel.Font = new Font("Segoe UI", 10F);
            lblStockLabel.ForeColor = Color.Gray;
            lblStockLabel.Location = new Point(1132, 4);
            lblStockLabel.Name = "lblStockLabel";
            lblStockLabel.Size = new Size(101, 23);
            lblStockLabel.TabIndex = 5;
            lblStockLabel.Text = "Stock actual";
            // 
            // btnRegistrarPerdida
            // 
            btnRegistrarPerdida.BackColor = Color.FromArgb(220, 38, 38);
            btnRegistrarPerdida.FlatAppearance.BorderSize = 0;
            btnRegistrarPerdida.FlatStyle = FlatStyle.Flat;
            btnRegistrarPerdida.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRegistrarPerdida.ForeColor = Color.White;
            btnRegistrarPerdida.Location = new Point(34, 100);
            btnRegistrarPerdida.Name = "btnRegistrarPerdida";
            btnRegistrarPerdida.Size = new Size(230, 55);
            btnRegistrarPerdida.TabIndex = 3;
            btnRegistrarPerdida.Text = "— Registrar pérdida";
            btnRegistrarPerdida.UseVisualStyleBackColor = false;
            btnRegistrarPerdida.Click += btnRegistrarPerdida_Click;
            // 
            // lblAlimentoTitle
            // 
            lblAlimentoTitle.AutoSize = true;
            lblAlimentoTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblAlimentoTitle.ForeColor = Color.FromArgb(26, 32, 44);
            lblAlimentoTitle.Location = new Point(34, 20);
            lblAlimentoTitle.Name = "lblAlimentoTitle";
            lblAlimentoTitle.Size = new Size(320, 41);
            lblAlimentoTitle.TabIndex = 2;
            lblAlimentoTitle.Text = "Almacén de Alimento";
            // 
            // panelNuevoPerdida
            // 
            panelNuevoPerdida.BackColor = Color.White;
            panelNuevoPerdida.Controls.Add(btnCancelarPerdida);
            panelNuevoPerdida.Controls.Add(btnRegistrarPerdida2);
            panelNuevoPerdida.Controls.Add(txtCantidadPerdida);
            panelNuevoPerdida.Controls.Add(lblCantidadPerdida);
            panelNuevoPerdida.Controls.Add(dtpFechaPerdida);
            panelNuevoPerdida.Controls.Add(lblFechaPerdida);
            panelNuevoPerdida.Controls.Add(lblNuevoPerdidaTitle);
            panelNuevoPerdida.Location = new Point(34, 180);
            panelNuevoPerdida.Margin = new Padding(3, 4, 3, 4);
            panelNuevoPerdida.Name = "panelNuevoPerdida";
            panelNuevoPerdida.Padding = new Padding(30);
            panelNuevoPerdida.Size = new Size(1189, 280);
            panelNuevoPerdida.TabIndex = 0;
            panelNuevoPerdida.Visible = false;
            // 
            // btnCancelarPerdida
            // 
            btnCancelarPerdida.BackColor = Color.FromArgb(108, 117, 125);
            btnCancelarPerdida.FlatAppearance.BorderSize = 0;
            btnCancelarPerdida.FlatStyle = FlatStyle.Flat;
            btnCancelarPerdida.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCancelarPerdida.ForeColor = Color.White;
            btnCancelarPerdida.Location = new Point(170, 200);
            btnCancelarPerdida.Name = "btnCancelarPerdida";
            btnCancelarPerdida.Size = new Size(130, 45);
            btnCancelarPerdida.TabIndex = 6;
            btnCancelarPerdida.Text = "Cancelar";
            btnCancelarPerdida.UseVisualStyleBackColor = false;
            btnCancelarPerdida.Click += btnCancelarPerdida_Click;
            // 
            // btnRegistrarPerdida2
            // 
            btnRegistrarPerdida2.BackColor = Color.FromArgb(0, 125, 62);
            btnRegistrarPerdida2.FlatAppearance.BorderSize = 0;
            btnRegistrarPerdida2.FlatStyle = FlatStyle.Flat;
            btnRegistrarPerdida2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRegistrarPerdida2.ForeColor = Color.White;
            btnRegistrarPerdida2.Location = new Point(30, 200);
            btnRegistrarPerdida2.Name = "btnRegistrarPerdida2";
            btnRegistrarPerdida2.Size = new Size(130, 45);
            btnRegistrarPerdida2.TabIndex = 5;
            btnRegistrarPerdida2.Text = "Registrar";
            btnRegistrarPerdida2.UseVisualStyleBackColor = false;
            btnRegistrarPerdida2.Click += btnRegistrarPerdida2_Click;
            // 
            // txtCantidadPerdida
            // 
            txtCantidadPerdida.Font = new Font("Segoe UI", 12F);
            txtCantidadPerdida.Location = new Point(30, 145);
            txtCantidadPerdida.Name = "txtCantidadPerdida";
            txtCantidadPerdida.PlaceholderText = "Número de sacos";
            txtCantidadPerdida.Size = new Size(1129, 34);
            txtCantidadPerdida.TabIndex = 4;
            // 
            // lblCantidadPerdida
            // 
            lblCantidadPerdida.AutoSize = true;
            lblCantidadPerdida.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCantidadPerdida.ForeColor = Color.FromArgb(44, 62, 80);
            lblCantidadPerdida.Location = new Point(30, 115);
            lblCantidadPerdida.Name = "lblCantidadPerdida";
            lblCantidadPerdida.Size = new Size(141, 23);
            lblCantidadPerdida.TabIndex = 3;
            lblCantidadPerdida.Text = "Cantidad (sacos)";
            // 
            // dtpFechaPerdida
            // 
            dtpFechaPerdida.Font = new Font("Segoe UI", 12F);
            dtpFechaPerdida.Format = DateTimePickerFormat.Short;
            dtpFechaPerdida.Location = new Point(30, 75);
            dtpFechaPerdida.Name = "dtpFechaPerdida";
            dtpFechaPerdida.Size = new Size(1129, 34);
            dtpFechaPerdida.TabIndex = 2;
            // 
            // lblFechaPerdida
            // 
            lblFechaPerdida.AutoSize = true;
            lblFechaPerdida.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFechaPerdida.ForeColor = Color.FromArgb(44, 62, 80);
            lblFechaPerdida.Location = new Point(30, 45);
            lblFechaPerdida.Name = "lblFechaPerdida";
            lblFechaPerdida.Size = new Size(55, 23);
            lblFechaPerdida.TabIndex = 1;
            lblFechaPerdida.Text = "Fecha";
            // 
            // lblNuevoPerdidaTitle
            // 
            lblNuevoPerdidaTitle.AutoSize = true;
            lblNuevoPerdidaTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblNuevoPerdidaTitle.ForeColor = Color.FromArgb(26, 32, 44);
            lblNuevoPerdidaTitle.Location = new Point(0, 0);
            lblNuevoPerdidaTitle.Name = "lblNuevoPerdidaTitle";
            lblNuevoPerdidaTitle.Size = new Size(211, 32);
            lblNuevoPerdidaTitle.TabIndex = 0;
            lblNuevoPerdidaTitle.Text = "Registrar Pérdida";
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
            lblMovimientosTitle.Size = new Size(164, 32);
            lblMovimientosTitle.TabIndex = 0;
            lblMovimientosTitle.Text = "Movimientos";
            // 
            // Alimento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 933);
            Controls.Add(panelMain);
            Controls.Add(panelNav);
            Controls.Add(panelHeader);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Alimento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alimento - Rancho del Buen Pastor";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelNav.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panelNuevoPerdida.ResumeLayout(false);
            panelNuevoPerdida.PerformLayout();
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
        private System.Windows.Forms.Button btnAlimento;
        private System.Windows.Forms.Button btnInsumos;
        private System.Windows.Forms.Button btnMolino;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblStockTotal;
        private System.Windows.Forms.Label lblStockLabel;
        private System.Windows.Forms.Button btnRegistrarPerdida;
        private System.Windows.Forms.Label lblAlimentoTitle;
        private System.Windows.Forms.Panel panelNuevoPerdida;
        private System.Windows.Forms.Button btnCancelarPerdida;
        private System.Windows.Forms.Button btnRegistrarPerdida2;
        private System.Windows.Forms.TextBox txtCantidadPerdida;
        private System.Windows.Forms.Label lblCantidadPerdida;
        private System.Windows.Forms.DateTimePicker dtpFechaPerdida;
        private System.Windows.Forms.Label lblFechaPerdida;
        private System.Windows.Forms.Label lblNuevoPerdidaTitle;
        private System.Windows.Forms.Panel panelMovimientos;
        private System.Windows.Forms.DataGridView dgvMovimientos;
        private System.Windows.Forms.Label lblMovimientosTitle;
    }
}
