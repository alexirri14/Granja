namespace Granja
{
    partial class Produccion
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
            panelForm = new Panel();
            btnCancelar = new Button();
            btnGuardar = new Button();
            txtCantidad = new TextBox();
            lblCantidad = new Label();
            dtpFecha = new DateTimePicker();
            lblFecha = new Label();
            cmbGalpon = new ComboBox();
            lblGalpon = new Label();
            panelList = new Panel();
            dgvProduccionList = new DataGridView();
            lblListTitle = new Label();
            lblFormTitle = new Label();
            panelHeader.SuspendLayout();
            panelNav.SuspendLayout();
            panelMain.SuspendLayout();
            panelForm.SuspendLayout();
            panelList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduccionList).BeginInit();
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
            btnReportes.Text = " Reportes";
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
            btnMolino.Text = " Molino";
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
            btnInsumos.Text = " Insumos";
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
            btnVentas.Text = " Ventas";
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
            btnProduccion.ForeColor = Color.FromArgb(0, 125, 62);
            btnProduccion.Location = new Point(149, 0);
            btnProduccion.Margin = new Padding(3, 4, 3, 4);
            btnProduccion.Name = "btnProduccion";
            btnProduccion.Size = new Size(137, 67);
            btnProduccion.TabIndex = 1;
            btnProduccion.Text = " Producción";
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
            btnDashboard.Text = " Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panelMain
            // 
            panelMain.AutoScroll = true;
            panelMain.BackColor = Color.FromArgb(248, 249, 250);
            panelMain.Controls.Add(panelForm);
            panelMain.Controls.Add(panelList);
            panelMain.Controls.Add(lblFormTitle);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 153);
            panelMain.Margin = new Padding(3, 4, 3, 4);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(34, 40, 34, 40);
            panelMain.Size = new Size(1257, 780);
            panelMain.TabIndex = 2;
            // 
            // panelForm
            // 
            panelForm.BackColor = Color.White;
            panelForm.Controls.Add(btnCancelar);
            panelForm.Controls.Add(btnGuardar);
            panelForm.Controls.Add(txtCantidad);
            panelForm.Controls.Add(lblCantidad);
            panelForm.Controls.Add(dtpFecha);
            panelForm.Controls.Add(lblFecha);
            panelForm.Controls.Add(cmbGalpon);
            panelForm.Controls.Add(lblGalpon);
            panelForm.Location = new Point(34, 62);
            panelForm.Margin = new Padding(3, 4, 3, 4);
            panelForm.Name = "panelForm";
            panelForm.Padding = new Padding(30);
            panelForm.Size = new Size(1189, 320);
            panelForm.TabIndex = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(108, 117, 125);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(186, 253);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 45);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "✕ Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(0, 125, 62);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(30, 253);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 45);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "💾 Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Segoe UI", 12F);
            txtCantidad.Location = new Point(27, 201);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.PlaceholderText = "Número de jabas";
            txtCantidad.Size = new Size(1129, 34);
            txtCantidad.TabIndex = 6;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCantidad.ForeColor = Color.FromArgb(44, 62, 80);
            lblCantidad.Location = new Point(27, 163);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(83, 23);
            lblCantidad.TabIndex = 5;
            lblCantidad.Text = "Cantidad";
            // 
            // dtpFecha
            // 
            dtpFecha.Font = new Font("Segoe UI", 12F);
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(27, 111);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(1129, 34);
            dtpFecha.TabIndex = 4;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFecha.ForeColor = Color.FromArgb(44, 62, 80);
            lblFecha.Location = new Point(27, 85);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(55, 23);
            lblFecha.TabIndex = 3;
            lblFecha.Text = "Fecha";
            // 
            // cmbGalpon
            // 
            cmbGalpon.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGalpon.Font = new Font("Segoe UI", 12F);
            cmbGalpon.FormattingEnabled = true;
            cmbGalpon.Items.AddRange(new object[] { "A", "B", "C", "D" });
            cmbGalpon.Location = new Point(27, 46);
            cmbGalpon.Name = "cmbGalpon";
            cmbGalpon.Size = new Size(1129, 36);
            cmbGalpon.TabIndex = 2;
            // 
            // lblGalpon
            // 
            lblGalpon.AutoSize = true;
            lblGalpon.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblGalpon.ForeColor = Color.FromArgb(44, 62, 80);
            lblGalpon.Location = new Point(27, 11);
            lblGalpon.Name = "lblGalpon";
            lblGalpon.Size = new Size(67, 23);
            lblGalpon.TabIndex = 1;
            lblGalpon.Text = "Galpón";
            // 
            // panelList
            // 
            panelList.BackColor = Color.White;
            panelList.Controls.Add(dgvProduccionList);
            panelList.Controls.Add(lblListTitle);
            panelList.Location = new Point(34, 390);
            panelList.Margin = new Padding(3, 4, 3, 4);
            panelList.Name = "panelList";
            panelList.Padding = new Padding(30);
            panelList.Size = new Size(1189, 360);
            panelList.TabIndex = 1;
            // 
            // dgvProduccionList
            // 
            dgvProduccionList.AllowUserToAddRows = false;
            dgvProduccionList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProduccionList.BackgroundColor = Color.White;
            dgvProduccionList.BorderStyle = BorderStyle.None;
            dgvProduccionList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduccionList.Location = new Point(30, 70);
            dgvProduccionList.Name = "dgvProduccionList";
            dgvProduccionList.RowHeadersVisible = false;
            dgvProduccionList.RowHeadersWidth = 51;
            dgvProduccionList.Size = new Size(1129, 260);
            dgvProduccionList.TabIndex = 1;
            // 
            // lblListTitle
            // 
            lblListTitle.AutoSize = true;
            lblListTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblListTitle.ForeColor = Color.FromArgb(26, 32, 44);
            lblListTitle.Location = new Point(14, 13);
            lblListTitle.Name = "lblListTitle";
            lblListTitle.Size = new Size(229, 32);
            lblListTitle.TabIndex = 0;
            lblListTitle.Text = "Producción del día";
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblFormTitle.ForeColor = Color.FromArgb(26, 32, 44);
            lblFormTitle.Location = new Point(23, 4);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(316, 37);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "Registro de Producción";
            // 
            // Produccion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 933);
            Controls.Add(panelMain);
            Controls.Add(panelNav);
            Controls.Add(panelHeader);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Produccion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Producción - Rancho del Buen Pastor";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelNav.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            panelList.ResumeLayout(false);
            panelList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduccionList).EndInit();
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
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblGalpon;
        private System.Windows.Forms.ComboBox cmbGalpon;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panelList;
        private System.Windows.Forms.Label lblListTitle;
        private System.Windows.Forms.DataGridView dgvProduccionList;
    }
}
