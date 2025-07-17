namespace WinNominaPisip._2.Vista
{
    partial class F5Asistencias
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
            dgvLicencias = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvLicencias).BeginInit();
            SuspendLayout();
            // 
            // dgvLicencias
            // 
            dgvLicencias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLicencias.Location = new Point(31, 200);
            dgvLicencias.Name = "dgvLicencias";
            dgvLicencias.RowHeadersWidth = 51;
            dgvLicencias.Size = new Size(726, 188);
            dgvLicencias.TabIndex = 0;
            // 
            // F5Asistencias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvLicencias);
            Name = "F5Asistencias";
            Text = "F5Asistencias";
            Load += F5Asistencias_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLicencias).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvLicencias;
    }
}