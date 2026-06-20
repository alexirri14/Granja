namespace Granja
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
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
            panelInsumos = new Panel();
            dgvInsumos = new DataGridView();
            lblInsumosTitle = new Label();
            panelProduction = new Panel();
            dgvProduccion = new DataGridView();
            lblProductionReciente = new Label();
            panelAlerts = new Panel();
            panelAlertBox = new Panel();
            lblAlerta = new Label();
            lblAlertas = new Label();
            panelCardsContainer = new FlowLayoutPanel();
            cardHuevos = new Panel();
            lblHuevosHoy = new Label();
            lblHuevosValor = new Label();
            accHuevos = new Panel();
            cardStock = new Panel();
            lblStock = new Label();
            lblStockValor = new Label();
            accStock = new Panel();
            cardVentas = new Panel();
            lblVentasHoy = new Label();
            lblVentasValor = new Label();
            accVentas = new Panel();
            cardAlimentoStock = new Panel();
            lblAlimentoStock = new Label();
            lblAlimentoValor = new Label();
            accAlimento = new Panel();
            lblResumenTitle = new Label();
            panelHeader.SuspendLayout();
            panelNav.SuspendLayout();
            panelMain.SuspendLayout();
            panelInsumos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInsumos).BeginInit();
            panelProduction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduccion).BeginInit();
            panelAlerts.SuspendLayout();
            panelAlertBox.SuspendLayout();
            panelCardsContainer.SuspendLayout();
            cardHuevos.SuspendLayout();
            cardStock.SuspendLayout();
            cardVentas.SuspendLayout();
            cardAlimentoStock.SuspendLayout();
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
            btnReportes.Location = new Point(699, 2);
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
            btnMolino.Location = new Point(562, 2);
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
            btnInsumos.Location = new Point(425, 2);
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
            btnAlimento.Location = new Point(288, 2);
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
            btnVentas.Location = new Point(151, 2);
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
            btnDashboard.ForeColor = Color.FromArgb(0, 125, 62);
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
            panelMain.Controls.Add(panelInsumos);
            panelMain.Controls.Add(panelProduction);
            panelMain.Controls.Add(panelAlerts);
            panelMain.Controls.Add(panelCardsContainer);
            panelMain.Controls.Add(lblResumenTitle);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 153);
            panelMain.Margin = new Padding(3, 4, 3, 4);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(34, 40, 34, 40);
            panelMain.Size = new Size(1257, 780);
            panelMain.TabIndex = 2;
            // 
            // panelInsumos
            // 
            panelInsumos.BackColor = Color.White;
            panelInsumos.Controls.Add(dgvInsumos);
            panelInsumos.Controls.Add(lblInsumosTitle);
            panelInsumos.Location = new Point(34, 793);
            panelInsumos.Margin = new Padding(3, 4, 3, 4);
            panelInsumos.Name = "panelInsumos";
            panelInsumos.Padding = new Padding(30);
            panelInsumos.Size = new Size(1189, 360);
            panelInsumos.TabIndex = 4;
            // 
            // dgvInsumos
            // 
            dgvInsumos.AllowUserToAddRows = false;
            dgvInsumos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInsumos.BackgroundColor = Color.White;
            dgvInsumos.BorderStyle = BorderStyle.None;
            dgvInsumos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInsumos.Location = new Point(30, 53);
            dgvInsumos.Margin = new Padding(3, 4, 3, 4);
            dgvInsumos.Name = "dgvInsumos";
            dgvInsumos.RowHeadersVisible = false;
            dgvInsumos.RowHeadersWidth = 51;
            dgvInsumos.Size = new Size(1129, 280);
            dgvInsumos.TabIndex = 1;
            // 
            // lblInsumosTitle
            // 
            lblInsumosTitle.AutoSize = true;
            lblInsumosTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblInsumosTitle.ForeColor = Color.FromArgb(26, 32, 44);
            lblInsumosTitle.Location = new Point(0, 0);
            lblInsumosTitle.Name = "lblInsumosTitle";
            lblInsumosTitle.Size = new Size(307, 32);
            lblInsumosTitle.TabIndex = 0;
            lblInsumosTitle.Text = "Stock de Insumos Críticos";
            // 
            // panelProduction
            // 
            panelProduction.Controls.Add(dgvProduccion);
            panelProduction.Controls.Add(lblProductionReciente);
            panelProduction.Location = new Point(34, 453);
            panelProduction.Margin = new Padding(3, 4, 3, 4);
            panelProduction.Name = "panelProduction";
            panelProduction.Size = new Size(1189, 320);
            panelProduction.TabIndex = 3;
            // 
            // dgvProduccion
            // 
            dgvProduccion.AllowUserToAddRows = false;
            dgvProduccion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProduccion.BackgroundColor = Color.White;
            dgvProduccion.BorderStyle = BorderStyle.None;
            dgvProduccion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduccion.Location = new Point(0, 53);
            dgvProduccion.Margin = new Padding(3, 4, 3, 4);
            dgvProduccion.Name = "dgvProduccion";
            dgvProduccion.RowHeadersVisible = false;
            dgvProduccion.RowHeadersWidth = 51;
            dgvProduccion.Size = new Size(1189, 240);
            dgvProduccion.TabIndex = 1;
            // 
            // lblProductionReciente
            // 
            lblProductionReciente.AutoSize = true;
            lblProductionReciente.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblProductionReciente.Location = new Point(0, 13);
            lblProductionReciente.Name = "lblProductionReciente";
            lblProductionReciente.Size = new Size(206, 28);
            lblProductionReciente.TabIndex = 0;
            lblProductionReciente.Text = "Producción Reciente";
            // 
            // panelAlerts
            // 
            panelAlerts.Controls.Add(panelAlertBox);
            panelAlerts.Controls.Add(lblAlertas);
            panelAlerts.Location = new Point(34, 293);
            panelAlerts.Margin = new Padding(3, 4, 3, 4);
            panelAlerts.Name = "panelAlerts";
            panelAlerts.Size = new Size(1189, 147);
            panelAlerts.TabIndex = 2;
            // 
            // panelAlertBox
            // 
            panelAlertBox.BackColor = Color.FromArgb(255, 243, 205);
            panelAlertBox.BorderStyle = BorderStyle.FixedSingle;
            panelAlertBox.Controls.Add(lblAlerta);
            panelAlertBox.Location = new Point(0, 53);
            panelAlertBox.Margin = new Padding(3, 4, 3, 4);
            panelAlertBox.Name = "panelAlertBox";
            panelAlertBox.Size = new Size(1188, 66);
            panelAlertBox.TabIndex = 1;
            // 
            // lblAlerta
            // 
            lblAlerta.AutoSize = true;
            lblAlerta.Font = new Font("Segoe UI", 10F);
            lblAlerta.ForeColor = Color.FromArgb(133, 100, 4);
            lblAlerta.Location = new Point(17, 20);
            lblAlerta.Name = "lblAlerta";
            lblAlerta.Size = new Size(188, 23);
            lblAlerta.TabIndex = 0;
            lblAlerta.Text = " Bajo stock de alimento";
            // 
            // lblAlertas
            // 
            lblAlertas.AutoSize = true;
            lblAlertas.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAlertas.Location = new Point(0, 13);
            lblAlertas.Name = "lblAlertas";
            lblAlertas.Size = new Size(130, 28);
            lblAlertas.TabIndex = 0;
            lblAlertas.Text = "🔔 ALERTAS";
            // 
            // panelCardsContainer
            // 
            panelCardsContainer.Controls.Add(cardHuevos);
            panelCardsContainer.Controls.Add(cardStock);
            panelCardsContainer.Controls.Add(cardVentas);
            panelCardsContainer.Controls.Add(cardAlimentoStock);
            panelCardsContainer.Location = new Point(34, 80);
            panelCardsContainer.Margin = new Padding(3, 4, 3, 4);
            panelCardsContainer.Name = "panelCardsContainer";
            panelCardsContainer.Size = new Size(1189, 200);
            panelCardsContainer.TabIndex = 1;
            // 
            // cardHuevos
            // 
            cardHuevos.BackColor = Color.White;
            cardHuevos.Controls.Add(lblHuevosHoy);
            cardHuevos.Controls.Add(lblHuevosValor);
            cardHuevos.Controls.Add(accHuevos);
            cardHuevos.Location = new Point(0, 0);
            cardHuevos.Margin = new Padding(0, 0, 23, 0);
            cardHuevos.Name = "cardHuevos";
            cardHuevos.Size = new Size(263, 160);
            cardHuevos.TabIndex = 0;
            // 
            // lblHuevosHoy
            // 
            lblHuevosHoy.AutoSize = true;
            lblHuevosHoy.Font = new Font("Segoe UI", 9F);
            lblHuevosHoy.ForeColor = Color.Gray;
            lblHuevosHoy.Location = new Point(17, 20);
            lblHuevosHoy.Name = "lblHuevosHoy";
            lblHuevosHoy.Size = new Size(86, 20);
            lblHuevosHoy.TabIndex = 0;
            lblHuevosHoy.Text = "Huevos hoy";
            // 
            // lblHuevosValor
            // 
            lblHuevosValor.AutoSize = true;
            lblHuevosValor.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblHuevosValor.Location = new Point(17, 60);
            lblHuevosValor.Name = "lblHuevosValor";
            lblHuevosValor.Size = new Size(40, 46);
            lblHuevosValor.TabIndex = 1;
            lblHuevosValor.Text = "0";
            // 
            // accHuevos
            // 
            accHuevos.BackColor = Color.FromArgb(0, 123, 255);
            accHuevos.Dock = DockStyle.Left;
            accHuevos.Location = new Point(0, 0);
            accHuevos.Margin = new Padding(3, 4, 3, 4);
            accHuevos.Name = "accHuevos";
            accHuevos.Size = new Size(5, 160);
            accHuevos.TabIndex = 2;
            // 
            // cardStock
            // 
            cardStock.BackColor = Color.White;
            cardStock.Controls.Add(lblStock);
            cardStock.Controls.Add(lblStockValor);
            cardStock.Controls.Add(accStock);
            cardStock.Location = new Point(286, 0);
            cardStock.Margin = new Padding(0, 0, 23, 0);
            cardStock.Name = "cardStock";
            cardStock.Size = new Size(263, 160);
            cardStock.TabIndex = 1;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 9F);
            lblStock.ForeColor = Color.Gray;
            lblStock.Location = new Point(17, 20);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(89, 20);
            lblStock.TabIndex = 0;
            lblStock.Text = "Stock actual";
            // 
            // lblStockValor
            // 
            lblStockValor.AutoSize = true;
            lblStockValor.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblStockValor.Location = new Point(17, 60);
            lblStockValor.Name = "lblStockValor";
            lblStockValor.Size = new Size(100, 46);
            lblStockValor.TabIndex = 1;
            lblStockValor.Text = "8500";
            // 
            // accStock
            // 
            accStock.BackColor = Color.FromArgb(40, 167, 69);
            accStock.Dock = DockStyle.Left;
            accStock.Location = new Point(0, 0);
            accStock.Margin = new Padding(3, 4, 3, 4);
            accStock.Name = "accStock";
            accStock.Size = new Size(5, 160);
            accStock.TabIndex = 2;
            // 
            // cardVentas
            // 
            cardVentas.BackColor = Color.White;
            cardVentas.Controls.Add(lblVentasHoy);
            cardVentas.Controls.Add(lblVentasValor);
            cardVentas.Controls.Add(accVentas);
            cardVentas.Location = new Point(572, 0);
            cardVentas.Margin = new Padding(0, 0, 23, 0);
            cardVentas.Name = "cardVentas";
            cardVentas.Size = new Size(263, 160);
            cardVentas.TabIndex = 2;
            // 
            // lblVentasHoy
            // 
            lblVentasHoy.AutoSize = true;
            lblVentasHoy.Font = new Font("Segoe UI", 9F);
            lblVentasHoy.ForeColor = Color.Gray;
            lblVentasHoy.Location = new Point(17, 20);
            lblVentasHoy.Name = "lblVentasHoy";
            lblVentasHoy.Size = new Size(80, 20);
            lblVentasHoy.TabIndex = 0;
            lblVentasHoy.Text = "Ventas hoy";
            // 
            // lblVentasValor
            // 
            lblVentasValor.AutoSize = true;
            lblVentasValor.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblVentasValor.Location = new Point(17, 60);
            lblVentasValor.Name = "lblVentasValor";
            lblVentasValor.Size = new Size(132, 46);
            lblVentasValor.TabIndex = 1;
            lblVentasValor.Text = "S/ 0.00";
            // 
            // accVentas
            // 
            accVentas.BackColor = Color.FromArgb(255, 193, 7);
            accVentas.Dock = DockStyle.Left;
            accVentas.Location = new Point(0, 0);
            accVentas.Margin = new Padding(3, 4, 3, 4);
            accVentas.Name = "accVentas";
            accVentas.Size = new Size(5, 160);
            accVentas.TabIndex = 2;
            // 
            // cardAlimentoStock
            // 
            cardAlimentoStock.BackColor = Color.White;
            cardAlimentoStock.Controls.Add(lblAlimentoStock);
            cardAlimentoStock.Controls.Add(lblAlimentoValor);
            cardAlimentoStock.Controls.Add(accAlimento);
            cardAlimentoStock.Location = new Point(858, 0);
            cardAlimentoStock.Margin = new Padding(0, 0, 23, 0);
            cardAlimentoStock.Name = "cardAlimentoStock";
            cardAlimentoStock.Size = new Size(263, 160);
            cardAlimentoStock.TabIndex = 3;
            // 
            // lblAlimentoStock
            // 
            lblAlimentoStock.AutoSize = true;
            lblAlimentoStock.Font = new Font("Segoe UI", 9F);
            lblAlimentoStock.ForeColor = Color.Gray;
            lblAlimentoStock.Location = new Point(17, 20);
            lblAlimentoStock.Name = "lblAlimentoStock";
            lblAlimentoStock.Size = new Size(108, 20);
            lblAlimentoStock.TabIndex = 0;
            lblAlimentoStock.Text = "Alimento stock";
            // 
            // lblAlimentoValor
            // 
            lblAlimentoValor.AutoSize = true;
            lblAlimentoValor.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblAlimentoValor.Location = new Point(17, 60);
            lblAlimentoValor.Name = "lblAlimentoValor";
            lblAlimentoValor.Size = new Size(174, 46);
            lblAlimentoValor.TabIndex = 1;
            lblAlimentoValor.Text = "300 sacos";
            // 
            // accAlimento
            // 
            accAlimento.BackColor = Color.FromArgb(111, 66, 193);
            accAlimento.Dock = DockStyle.Left;
            accAlimento.Location = new Point(0, 0);
            accAlimento.Margin = new Padding(3, 4, 3, 4);
            accAlimento.Name = "accAlimento";
            accAlimento.Size = new Size(5, 160);
            accAlimento.TabIndex = 2;
            // 
            // lblResumenTitle
            // 
            lblResumenTitle.AutoSize = true;
            lblResumenTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblResumenTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblResumenTitle.Location = new Point(34, 27);
            lblResumenTitle.Name = "lblResumenTitle";
            lblResumenTitle.Size = new Size(283, 32);
            lblResumenTitle.TabIndex = 0;
            lblResumenTitle.Text = "📊 RESUMEN GENERAL";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 933);
            Controls.Add(panelMain);
            Controls.Add(panelNav);
            Controls.Add(panelHeader);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rancho del Buen Pastor";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelNav.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panelInsumos.ResumeLayout(false);
            panelInsumos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInsumos).EndInit();
            panelProduction.ResumeLayout(false);
            panelProduction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduccion).EndInit();
            panelAlerts.ResumeLayout(false);
            panelAlerts.PerformLayout();
            panelAlertBox.ResumeLayout(false);
            panelAlertBox.PerformLayout();
            panelCardsContainer.ResumeLayout(false);
            cardHuevos.ResumeLayout(false);
            cardHuevos.PerformLayout();
            cardStock.ResumeLayout(false);
            cardStock.PerformLayout();
            cardVentas.ResumeLayout(false);
            cardVentas.PerformLayout();
            cardAlimentoStock.ResumeLayout(false);
            cardAlimentoStock.PerformLayout();
            ResumeLayout(false);
        }




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
        private System.Windows.Forms.Label lblResumenTitle;
        private System.Windows.Forms.FlowLayoutPanel panelCardsContainer;
        private System.Windows.Forms.Panel panelAlerts;
        private System.Windows.Forms.Label lblAlertas;
        private System.Windows.Forms.Panel panelAlertBox;
        private System.Windows.Forms.Label lblAlerta;
        private System.Windows.Forms.Panel panelProduction;
        private System.Windows.Forms.Label lblProductionReciente;
        private System.Windows.Forms.DataGridView dgvProduccion;
        private System.Windows.Forms.Label lblHuevosHoy;
        private System.Windows.Forms.Label lblHuevosValor;
        private System.Windows.Forms.Panel accHuevos;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblStockValor;
        private System.Windows.Forms.Panel accStock;
        private System.Windows.Forms.Label lblVentasHoy;
        private System.Windows.Forms.Label lblVentasValor;
        private System.Windows.Forms.Panel accVentas;
        private System.Windows.Forms.Label lblAlimentoStock;
        private System.Windows.Forms.Label lblAlimentoValor;
        private System.Windows.Forms.Panel accAlimento;
        private System.Windows.Forms.Panel cardHuevos;
        private System.Windows.Forms.Panel cardStock;
        private System.Windows.Forms.Panel cardVentas;
        private System.Windows.Forms.Panel cardAlimentoStock;
        private System.Windows.Forms.Panel panelInsumos;
        private System.Windows.Forms.Label lblInsumosTitle;
        private System.Windows.Forms.DataGridView dgvInsumos;

        #endregion
    }
}

