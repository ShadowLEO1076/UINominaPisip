namespace WinNominaPisip._2.Vista
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            panelMenu = new FlowLayoutPanel();
            panelLogo = new Panel();
            btnMenu = new FontAwesome.Sharp.IconButton();
            bntPuestos = new FontAwesome.Sharp.IconButton();
            btnEmpleados = new FontAwesome.Sharp.IconButton();
            btnContratos = new FontAwesome.Sharp.IconButton();
            btnAsistencias = new FontAwesome.Sharp.IconButton();
            btnPercepciones = new FontAwesome.Sharp.IconButton();
            btnNomina = new FontAwesome.Sharp.IconButton();
            btnReportes = new FontAwesome.Sharp.IconButton();
            btnVacaciones = new FontAwesome.Sharp.IconButton();
            btnInfo = new FontAwesome.Sharp.IconButton();
            panelLogo2 = new Panel();
            panel4 = new Panel();
            btnClose = new FontAwesome.Sharp.IconButton();
            btnMax = new FontAwesome.Sharp.IconButton();
            btnMin = new FontAwesome.Sharp.IconButton();
            panel5 = new Panel();
            btnSalir = new FontAwesome.Sharp.IconButton();
            labelTitulo = new Label();
            panelEscritorio = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            timeSlideBar = new System.Windows.Forms.Timer(components);
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panelLogo2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panelEscritorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = SystemColors.HotTrack;
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Controls.Add(bntPuestos);
            panelMenu.Controls.Add(btnEmpleados);
            panelMenu.Controls.Add(btnContratos);
            panelMenu.Controls.Add(btnAsistencias);
            panelMenu.Controls.Add(btnPercepciones);
            panelMenu.Controls.Add(btnNomina);
            panelMenu.Controls.Add(btnReportes);
            panelMenu.Controls.Add(btnVacaciones);
            panelMenu.Controls.Add(btnInfo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 784);
            panelMenu.TabIndex = 24;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(btnMenu);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 80);
            panelLogo.TabIndex = 0;
            // 
            // btnMenu
            // 
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.ForeColor = Color.White;
            btnMenu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            btnMenu.IconColor = Color.White;
            btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenu.Location = new Point(3, -1);
            btnMenu.Margin = new Padding(0);
            btnMenu.Name = "btnMenu";
            btnMenu.Padding = new Padding(12, 0, 0, 0);
            btnMenu.Size = new Size(220, 80);
            btnMenu.TabIndex = 1;
            btnMenu.Text = "      MENU";
            btnMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnMenu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // bntPuestos
            // 
            bntPuestos.BackColor = Color.Transparent;
            bntPuestos.Dock = DockStyle.Top;
            bntPuestos.FlatAppearance.BorderSize = 0;
            bntPuestos.FlatAppearance.MouseOverBackColor = SystemColors.ActiveBorder;
            bntPuestos.FlatStyle = FlatStyle.Flat;
            bntPuestos.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bntPuestos.ForeColor = Color.Gainsboro;
            bntPuestos.IconChar = FontAwesome.Sharp.IconChar.Briefcase;
            bntPuestos.IconColor = Color.Gainsboro;
            bntPuestos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bntPuestos.ImageAlign = ContentAlignment.MiddleLeft;
            bntPuestos.Location = new Point(3, 83);
            bntPuestos.Name = "bntPuestos";
            bntPuestos.Padding = new Padding(12, 0, 0, 0);
            bntPuestos.Size = new Size(220, 60);
            bntPuestos.TabIndex = 44;
            bntPuestos.Text = "  Puestos";
            bntPuestos.TextAlign = ContentAlignment.MiddleLeft;
            bntPuestos.TextImageRelation = TextImageRelation.ImageBeforeText;
            bntPuestos.UseVisualStyleBackColor = false;
            bntPuestos.Click += bntPuestos_Click;
            // 
            // btnEmpleados
            // 
            btnEmpleados.BackColor = Color.Transparent;
            btnEmpleados.BackgroundImageLayout = ImageLayout.None;
            btnEmpleados.Dock = DockStyle.Top;
            btnEmpleados.FlatAppearance.BorderSize = 0;
            btnEmpleados.FlatAppearance.MouseOverBackColor = SystemColors.ActiveBorder;
            btnEmpleados.FlatStyle = FlatStyle.Flat;
            btnEmpleados.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEmpleados.ForeColor = Color.Gainsboro;
            btnEmpleados.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            btnEmpleados.IconColor = Color.Gainsboro;
            btnEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEmpleados.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmpleados.Location = new Point(0, 146);
            btnEmpleados.Margin = new Padding(0);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Padding = new Padding(12, 0, 0, 0);
            btnEmpleados.Size = new Size(220, 60);
            btnEmpleados.TabIndex = 27;
            btnEmpleados.Text = "  Empleados";
            btnEmpleados.TextAlign = ContentAlignment.MiddleLeft;
            btnEmpleados.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEmpleados.UseVisualStyleBackColor = false;
            btnEmpleados.Click += btnEmpleados_Click;
            // 
            // btnContratos
            // 
            btnContratos.BackColor = Color.Transparent;
            btnContratos.Dock = DockStyle.Top;
            btnContratos.FlatAppearance.BorderSize = 0;
            btnContratos.FlatAppearance.MouseOverBackColor = SystemColors.ActiveBorder;
            btnContratos.FlatStyle = FlatStyle.Flat;
            btnContratos.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnContratos.ForeColor = Color.Gainsboro;
            btnContratos.IconChar = FontAwesome.Sharp.IconChar.FileSignature;
            btnContratos.IconColor = Color.Gainsboro;
            btnContratos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnContratos.ImageAlign = ContentAlignment.MiddleLeft;
            btnContratos.Location = new Point(3, 209);
            btnContratos.Name = "btnContratos";
            btnContratos.Padding = new Padding(12, 0, 0, 0);
            btnContratos.Size = new Size(220, 60);
            btnContratos.TabIndex = 28;
            btnContratos.Text = "  Contratos";
            btnContratos.TextAlign = ContentAlignment.MiddleLeft;
            btnContratos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnContratos.UseVisualStyleBackColor = false;
            btnContratos.Click += btnContratos_Click_1;
            // 
            // btnAsistencias
            // 
            btnAsistencias.BackColor = Color.Transparent;
            btnAsistencias.Dock = DockStyle.Top;
            btnAsistencias.FlatAppearance.BorderSize = 0;
            btnAsistencias.FlatAppearance.MouseOverBackColor = SystemColors.ActiveBorder;
            btnAsistencias.FlatStyle = FlatStyle.Flat;
            btnAsistencias.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAsistencias.ForeColor = Color.Gainsboro;
            btnAsistencias.IconChar = FontAwesome.Sharp.IconChar.UserClock;
            btnAsistencias.IconColor = Color.Gainsboro;
            btnAsistencias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAsistencias.ImageAlign = ContentAlignment.MiddleLeft;
            btnAsistencias.Location = new Point(3, 275);
            btnAsistencias.Name = "btnAsistencias";
            btnAsistencias.Padding = new Padding(12, 0, 0, 0);
            btnAsistencias.Size = new Size(220, 60);
            btnAsistencias.TabIndex = 31;
            btnAsistencias.Text = "  Asistencias";
            btnAsistencias.TextAlign = ContentAlignment.MiddleLeft;
            btnAsistencias.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAsistencias.UseVisualStyleBackColor = false;
            btnAsistencias.Click += btnAsistencias_Click_1;
            // 
            // btnPercepciones
            // 
            btnPercepciones.BackColor = Color.Transparent;
            btnPercepciones.Dock = DockStyle.Top;
            btnPercepciones.FlatAppearance.BorderSize = 0;
            btnPercepciones.FlatAppearance.MouseOverBackColor = SystemColors.ActiveBorder;
            btnPercepciones.FlatStyle = FlatStyle.Flat;
            btnPercepciones.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPercepciones.ForeColor = Color.Gainsboro;
            btnPercepciones.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTransfer;
            btnPercepciones.IconColor = Color.Gainsboro;
            btnPercepciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPercepciones.ImageAlign = ContentAlignment.MiddleLeft;
            btnPercepciones.Location = new Point(3, 341);
            btnPercepciones.Name = "btnPercepciones";
            btnPercepciones.Padding = new Padding(12, 0, 0, 0);
            btnPercepciones.Size = new Size(220, 60);
            btnPercepciones.TabIndex = 39;
            btnPercepciones.Text = "  Percepciones";
            btnPercepciones.TextAlign = ContentAlignment.MiddleLeft;
            btnPercepciones.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPercepciones.UseVisualStyleBackColor = false;
            btnPercepciones.Click += btnPercepciones_Click;
            // 
            // btnNomina
            // 
            btnNomina.BackColor = Color.Transparent;
            btnNomina.Dock = DockStyle.Top;
            btnNomina.FlatAppearance.BorderSize = 0;
            btnNomina.FlatAppearance.MouseOverBackColor = SystemColors.ActiveBorder;
            btnNomina.FlatStyle = FlatStyle.Flat;
            btnNomina.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNomina.ForeColor = Color.Gainsboro;
            btnNomina.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            btnNomina.IconColor = Color.Gainsboro;
            btnNomina.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNomina.ImageAlign = ContentAlignment.MiddleLeft;
            btnNomina.Location = new Point(3, 407);
            btnNomina.Name = "btnNomina";
            btnNomina.Padding = new Padding(12, 0, 0, 0);
            btnNomina.Size = new Size(220, 60);
            btnNomina.TabIndex = 41;
            btnNomina.Text = "  Nominas";
            btnNomina.TextAlign = ContentAlignment.MiddleLeft;
            btnNomina.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNomina.UseVisualStyleBackColor = false;
            btnNomina.Click += btnNomina_Click;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.Transparent;
            btnReportes.Dock = DockStyle.Top;
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatAppearance.MouseOverBackColor = SystemColors.ActiveBorder;
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReportes.ForeColor = Color.Gainsboro;
            btnReportes.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            btnReportes.IconColor = Color.Gainsboro;
            btnReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReportes.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportes.Location = new Point(3, 473);
            btnReportes.Name = "btnReportes";
            btnReportes.Padding = new Padding(12, 0, 0, 0);
            btnReportes.Size = new Size(220, 60);
            btnReportes.TabIndex = 43;
            btnReportes.Text = "  Reportes";
            btnReportes.TextAlign = ContentAlignment.MiddleLeft;
            btnReportes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnVacaciones
            // 
            btnVacaciones.BackColor = Color.Transparent;
            btnVacaciones.Dock = DockStyle.Top;
            btnVacaciones.FlatAppearance.BorderSize = 0;
            btnVacaciones.FlatAppearance.MouseOverBackColor = SystemColors.ActiveBorder;
            btnVacaciones.FlatStyle = FlatStyle.Flat;
            btnVacaciones.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVacaciones.ForeColor = Color.Gainsboro;
            btnVacaciones.IconChar = FontAwesome.Sharp.IconChar.Hourglass2;
            btnVacaciones.IconColor = Color.Gainsboro;
            btnVacaciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVacaciones.ImageAlign = ContentAlignment.MiddleLeft;
            btnVacaciones.Location = new Point(3, 539);
            btnVacaciones.Name = "btnVacaciones";
            btnVacaciones.Padding = new Padding(12, 0, 0, 0);
            btnVacaciones.Size = new Size(220, 60);
            btnVacaciones.TabIndex = 45;
            btnVacaciones.Text = "  Vacaciones";
            btnVacaciones.TextAlign = ContentAlignment.MiddleLeft;
            btnVacaciones.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVacaciones.UseVisualStyleBackColor = false;
            btnVacaciones.Click += btnVacaciones_Click;
            // 
            // btnInfo
            // 
            btnInfo.BackColor = Color.Transparent;
            btnInfo.Dock = DockStyle.Bottom;
            btnInfo.FlatAppearance.BorderSize = 0;
            btnInfo.FlatAppearance.MouseOverBackColor = SystemColors.ActiveBorder;
            btnInfo.FlatStyle = FlatStyle.Flat;
            btnInfo.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInfo.ForeColor = Color.Gainsboro;
            btnInfo.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            btnInfo.IconColor = Color.Gainsboro;
            btnInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnInfo.ImageAlign = ContentAlignment.MiddleLeft;
            btnInfo.Location = new Point(3, 605);
            btnInfo.Name = "btnInfo";
            btnInfo.Padding = new Padding(12, 0, 0, 0);
            btnInfo.Size = new Size(220, 60);
            btnInfo.TabIndex = 46;
            btnInfo.Text = " Informacion";
            btnInfo.TextAlign = ContentAlignment.MiddleLeft;
            btnInfo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInfo.UseVisualStyleBackColor = false;
            // 
            // panelLogo2
            // 
            panelLogo2.BackColor = SystemColors.HotTrack;
            panelLogo2.Controls.Add(panel4);
            panelLogo2.Controls.Add(panel5);
            panelLogo2.Controls.Add(labelTitulo);
            panelLogo2.Dock = DockStyle.Top;
            panelLogo2.Location = new Point(220, 0);
            panelLogo2.Name = "panelLogo2";
            panelLogo2.Size = new Size(967, 80);
            panelLogo2.TabIndex = 25;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnClose);
            panel4.Controls.Add(btnMax);
            panel4.Controls.Add(btnMin);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(843, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(124, 80);
            panel4.TabIndex = 3;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = SystemColors.ControlLightLight;
            btnClose.IconChar = FontAwesome.Sharp.IconChar.Circle;
            btnClose.IconColor = SystemColors.ControlLightLight;
            btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClose.IconSize = 33;
            btnClose.Location = new Point(95, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(26, 37);
            btnClose.TabIndex = 4;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click_1;
            // 
            // btnMax
            // 
            btnMax.FlatAppearance.BorderSize = 0;
            btnMax.FlatStyle = FlatStyle.Flat;
            btnMax.ForeColor = SystemColors.ControlLightLight;
            btnMax.IconChar = FontAwesome.Sharp.IconChar.Circle;
            btnMax.IconColor = SystemColors.ControlLightLight;
            btnMax.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMax.IconSize = 33;
            btnMax.Location = new Point(63, 0);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(26, 37);
            btnMax.TabIndex = 3;
            btnMax.UseVisualStyleBackColor = true;
            btnMax.Click += btnMax_Click_1;
            // 
            // btnMin
            // 
            btnMin.FlatAppearance.BorderSize = 0;
            btnMin.FlatStyle = FlatStyle.Flat;
            btnMin.ForeColor = SystemColors.ControlLightLight;
            btnMin.IconChar = FontAwesome.Sharp.IconChar.Circle;
            btnMin.IconColor = SystemColors.ControlLightLight;
            btnMin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMin.IconSize = 33;
            btnMin.Location = new Point(31, 0);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(26, 37);
            btnMin.TabIndex = 2;
            btnMin.UseVisualStyleBackColor = true;
            btnMin.Click += btnMin_Click_1;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnSalir);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(71, 80);
            panel5.TabIndex = 1;
            // 
            // btnSalir
            // 
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.ForeColor = SystemColors.ControlLightLight;
            btnSalir.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            btnSalir.IconColor = SystemColors.ButtonFace;
            btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalir.Location = new Point(6, 12);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(62, 55);
            btnSalir.TabIndex = 0;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click_1;
            // 
            // labelTitulo
            // 
            labelTitulo.Anchor = AnchorStyles.None;
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.ForeColor = SystemColors.ControlLightLight;
            labelTitulo.Location = new Point(368, 24);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(199, 26);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "HOME S.NOMINA";
            // 
            // panelEscritorio
            // 
            panelEscritorio.BackColor = Color.DimGray;
            panelEscritorio.Controls.Add(panel2);
            panelEscritorio.Controls.Add(pictureBox1);
            panelEscritorio.Dock = DockStyle.Fill;
            panelEscritorio.ForeColor = Color.Black;
            panelEscritorio.Location = new Point(220, 80);
            panelEscritorio.Name = "panelEscritorio";
            panelEscritorio.Size = new Size(967, 704);
            panelEscritorio.TabIndex = 26;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(947, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(20, 704);
            panel2.TabIndex = 49;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(195, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(567, 507);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(220, 764);
            panel1.Name = "panel1";
            panel1.Size = new Size(967, 20);
            panel1.TabIndex = 48;
            // 
            // timeSlideBar
            // 
            timeSlideBar.Tick += btnMenu_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1187, 784);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(panelEscritorio);
            Controls.Add(panelLogo2);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo2.ResumeLayout(false);
            panelLogo2.PerformLayout();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panelEscritorio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel panelMenu;
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnMenu;
        private FontAwesome.Sharp.IconButton btnEmpleados;
        private FontAwesome.Sharp.IconButton btnAsistencias;
        private FontAwesome.Sharp.IconButton btnPercepciones;
        private FontAwesome.Sharp.IconButton btnContratos;
        private FontAwesome.Sharp.IconButton btnNomina;
        private FontAwesome.Sharp.IconButton btnReportes;
        private FontAwesome.Sharp.IconButton bntPuestos;
        private FontAwesome.Sharp.IconButton btnVacaciones;
        private Panel panelLogo2;
        private Panel panel4;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnMax;
        private FontAwesome.Sharp.IconButton btnMin;
        private Panel panel5;
        private FontAwesome.Sharp.IconButton btnSalir;
        private Label labelTitulo;
        private Panel panelEscritorio;
        private PictureBox pictureBox1;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnInfo;
        private Panel panel2;
        private System.Windows.Forms.Timer timeSlideBar;
    }
}