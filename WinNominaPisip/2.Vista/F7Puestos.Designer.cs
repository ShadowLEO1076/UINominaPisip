namespace WinNominaPisip._2.Vista
{
    partial class F7Puestos
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
            tableLayoutPanel3 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtIdpuesto = new TextBox();
            txtPuestoNombre = new TextBox();
            txtPuestoSalario = new TextBox();
            dgvPuestos = new DataGridView();
            idPuestoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            puestoNombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            puestoSalarioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            puestosBindingSource = new BindingSource(components);
            flowLayoutPanel1 = new FlowLayoutPanel();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            textBox1 = new TextBox();
            iconButton7 = new FontAwesome.Sharp.IconButton();
            iconButton6 = new FontAwesome.Sharp.IconButton();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            label10 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPuestos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)puestosBindingSource).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.7696877F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.23031F));
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(label2, 0, 1);
            tableLayoutPanel3.Controls.Add(label3, 0, 2);
            tableLayoutPanel3.Controls.Add(txtIdpuesto, 1, 0);
            tableLayoutPanel3.Controls.Add(txtPuestoNombre, 1, 1);
            tableLayoutPanel3.Controls.Add(txtPuestoSalario, 1, 2);
            tableLayoutPanel3.Location = new Point(41, 39);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.Size = new Size(673, 216);
            tableLayoutPanel3.TabIndex = 97;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F);
            label1.Location = new Point(3, 26);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 25;
            label1.Text = "idPuesto:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F);
            label2.Location = new Point(3, 98);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 26;
            label2.Text = "PuestoNombre";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F);
            label3.Location = new Point(3, 170);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 29;
            label3.Text = "PuestoSalario";
            // 
            // txtIdpuesto
            // 
            txtIdpuesto.Anchor = AnchorStyles.Left;
            txtIdpuesto.Location = new Point(237, 22);
            txtIdpuesto.Margin = new Padding(3, 2, 3, 2);
            txtIdpuesto.Name = "txtIdpuesto";
            txtIdpuesto.Size = new Size(433, 27);
            txtIdpuesto.TabIndex = 32;
            // 
            // txtPuestoNombre
            // 
            txtPuestoNombre.Anchor = AnchorStyles.Left;
            txtPuestoNombre.Location = new Point(237, 94);
            txtPuestoNombre.Margin = new Padding(3, 2, 3, 2);
            txtPuestoNombre.Name = "txtPuestoNombre";
            txtPuestoNombre.Size = new Size(433, 27);
            txtPuestoNombre.TabIndex = 30;
            // 
            // txtPuestoSalario
            // 
            txtPuestoSalario.Anchor = AnchorStyles.Left;
            txtPuestoSalario.Location = new Point(237, 166);
            txtPuestoSalario.Margin = new Padding(3, 2, 3, 2);
            txtPuestoSalario.Name = "txtPuestoSalario";
            txtPuestoSalario.Size = new Size(433, 27);
            txtPuestoSalario.TabIndex = 31;
            // 
            // dgvPuestos
            // 
            dgvPuestos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dgvPuestos.AutoGenerateColumns = false;
            dgvPuestos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPuestos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPuestos.Columns.AddRange(new DataGridViewColumn[] { idPuestoDataGridViewTextBoxColumn, puestoNombreDataGridViewTextBoxColumn, puestoSalarioDataGridViewTextBoxColumn });
            dgvPuestos.DataSource = puestosBindingSource;
            dgvPuestos.Location = new Point(3, 3);
            dgvPuestos.Name = "dgvPuestos";
            dgvPuestos.RowHeadersWidth = 51;
            dgvPuestos.Size = new Size(1236, 352);
            dgvPuestos.TabIndex = 0;
            // 
            // idPuestoDataGridViewTextBoxColumn
            // 
            idPuestoDataGridViewTextBoxColumn.DataPropertyName = "idPuesto";
            idPuestoDataGridViewTextBoxColumn.HeaderText = "idPuesto";
            idPuestoDataGridViewTextBoxColumn.MinimumWidth = 6;
            idPuestoDataGridViewTextBoxColumn.Name = "idPuestoDataGridViewTextBoxColumn";
            // 
            // puestoNombreDataGridViewTextBoxColumn
            // 
            puestoNombreDataGridViewTextBoxColumn.DataPropertyName = "PuestoNombre";
            puestoNombreDataGridViewTextBoxColumn.HeaderText = "PuestoNombre";
            puestoNombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            puestoNombreDataGridViewTextBoxColumn.Name = "puestoNombreDataGridViewTextBoxColumn";
            // 
            // puestoSalarioDataGridViewTextBoxColumn
            // 
            puestoSalarioDataGridViewTextBoxColumn.DataPropertyName = "PuestoSalario";
            puestoSalarioDataGridViewTextBoxColumn.HeaderText = "PuestoSalario";
            puestoSalarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            puestoSalarioDataGridViewTextBoxColumn.Name = "puestoSalarioDataGridViewTextBoxColumn";
            // 
            // puestosBindingSource
            // 
            puestosBindingSource.DataSource = typeof(NominaPISIB.Infraestructura.AccesoDatos.Puestos);
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Right;
            flowLayoutPanel1.Controls.Add(iconButton4);
            flowLayoutPanel1.Controls.Add(textBox1);
            flowLayoutPanel1.Controls.Add(iconButton7);
            flowLayoutPanel1.Controls.Add(iconButton6);
            flowLayoutPanel1.Controls.Add(iconButton5);
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(991, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(266, 285);
            flowLayoutPanel1.TabIndex = 91;
            // 
            // iconButton4
            // 
            iconButton4.Anchor = AnchorStyles.Right;
            iconButton4.BackColor = Color.Transparent;
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.Font = new Font("Microsoft Sans Serif", 9F);
            iconButton4.ForeColor = Color.WhiteSmoke;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconButton4.IconColor = Color.WhiteSmoke;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 35;
            iconButton4.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton4.Location = new Point(205, 2);
            iconButton4.Margin = new Padding(3, 2, 3, 2);
            iconButton4.Name = "iconButton4";
            iconButton4.Padding = new Padding(15, 0, 0, 0);
            iconButton4.Size = new Size(58, 47);
            iconButton4.TabIndex = 84;
            iconButton4.TextAlign = ContentAlignment.MiddleLeft;
            iconButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton4.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(38, 12);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(161, 27);
            textBox1.TabIndex = 87;
            // 
            // iconButton7
            // 
            iconButton7.Anchor = AnchorStyles.Right;
            iconButton7.BackColor = Color.Transparent;
            iconButton7.FlatAppearance.BorderSize = 0;
            iconButton7.FlatStyle = FlatStyle.Flat;
            iconButton7.Font = new Font("Microsoft Sans Serif", 9F);
            iconButton7.ForeColor = Color.WhiteSmoke;
            iconButton7.IconChar = FontAwesome.Sharp.IconChar.Trash;
            iconButton7.IconColor = Color.WhiteSmoke;
            iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton7.IconSize = 35;
            iconButton7.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton7.Location = new Point(81, 53);
            iconButton7.Margin = new Padding(3, 2, 3, 2);
            iconButton7.Name = "iconButton7";
            iconButton7.Padding = new Padding(15, 0, 0, 0);
            iconButton7.Size = new Size(182, 48);
            iconButton7.TabIndex = 72;
            iconButton7.Text = "Eliminar";
            iconButton7.TextAlign = ContentAlignment.MiddleLeft;
            iconButton7.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton7.UseVisualStyleBackColor = false;
            // 
            // iconButton6
            // 
            iconButton6.Anchor = AnchorStyles.Right;
            iconButton6.BackColor = Color.Transparent;
            iconButton6.FlatAppearance.BorderSize = 0;
            iconButton6.FlatStyle = FlatStyle.Flat;
            iconButton6.Font = new Font("Microsoft Sans Serif", 9F);
            iconButton6.ForeColor = Color.WhiteSmoke;
            iconButton6.IconChar = FontAwesome.Sharp.IconChar.FilePen;
            iconButton6.IconColor = Color.WhiteSmoke;
            iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton6.IconSize = 35;
            iconButton6.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton6.Location = new Point(81, 105);
            iconButton6.Margin = new Padding(3, 2, 3, 2);
            iconButton6.Name = "iconButton6";
            iconButton6.Padding = new Padding(15, 0, 0, 0);
            iconButton6.Size = new Size(182, 46);
            iconButton6.TabIndex = 71;
            iconButton6.Text = "Actualizar";
            iconButton6.TextAlign = ContentAlignment.MiddleLeft;
            iconButton6.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton6.UseVisualStyleBackColor = false;
            // 
            // iconButton5
            // 
            iconButton5.Anchor = AnchorStyles.Right;
            iconButton5.BackColor = Color.Transparent;
            iconButton5.FlatAppearance.BorderSize = 0;
            iconButton5.FlatStyle = FlatStyle.Flat;
            iconButton5.Font = new Font("Microsoft Sans Serif", 9F);
            iconButton5.ForeColor = Color.WhiteSmoke;
            iconButton5.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            iconButton5.IconColor = Color.WhiteSmoke;
            iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton5.IconSize = 35;
            iconButton5.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton5.Location = new Point(81, 155);
            iconButton5.Margin = new Padding(3, 2, 3, 2);
            iconButton5.Name = "iconButton5";
            iconButton5.Padding = new Padding(15, 0, 0, 0);
            iconButton5.Size = new Size(182, 48);
            iconButton5.TabIndex = 70;
            iconButton5.Text = "Agregar";
            iconButton5.TextAlign = ContentAlignment.MiddleLeft;
            iconButton5.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton5.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(label10);
            panel1.Location = new Point(0, 322);
            panel1.Name = "panel1";
            panel1.Size = new Size(1257, 35);
            panel1.TabIndex = 99;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(493, 2);
            label10.Name = "label10";
            label10.Size = new Size(286, 25);
            label10.TabIndex = 0;
            label10.Text = "EMPLEADOS REGISTRADOS";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(dgvPuestos, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 363);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1242, 358);
            tableLayoutPanel1.TabIndex = 100;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Controls.Add(tableLayoutPanel3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1257, 291);
            panel2.TabIndex = 101;
            // 
            // F7Puestos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 708);
            Controls.Add(panel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Name = "F7Puestos";
            Text = "F7Puestos";
            Load += F7Puestos_Load;
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPuestos).EndInit();
            ((System.ComponentModel.ISupportInitialize)puestosBindingSource).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idpuesto;
        private DataGridViewTextBoxColumn puestonombres;
        private DataGridViewTextBoxColumn puestosalario;
        private DataGridViewTextBoxColumn puestoVacantes;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtIdpuesto;
        private TextBox txtPuestoNombre;
        private TextBox txtPuestoSalario;
        private DateTimePicker dateTimePicker3;
        private DataGridView dgvPuestos;
        private FlowLayoutPanel flowLayoutPanel1;
        private FontAwesome.Sharp.IconButton iconButton4;
        private TextBox textBox1;
        private FontAwesome.Sharp.IconButton iconButton7;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton iconButton5;
        private Panel panel1;
        private Label label10;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private BindingSource puestosBindingSource;
        private DataGridViewTextBoxColumn idPuestoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn puestoNombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn puestoSalarioDataGridViewTextBoxColumn;
    }
}