namespace EvaluacionEscritorioSOA
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInformacion = new System.Windows.Forms.Button();
            this.dtGVWEstad = new System.Windows.Forms.DataGridView();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVWEstad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInformacion
            // 
            this.btnInformacion.Location = new System.Drawing.Point(407, 12);
            this.btnInformacion.Name = "btnInformacion";
            this.btnInformacion.Size = new System.Drawing.Size(75, 23);
            this.btnInformacion.TabIndex = 0;
            this.btnInformacion.Text = "Informacion";
            this.btnInformacion.UseVisualStyleBackColor = true;
            this.btnInformacion.Click += new System.EventHandler(this.btnInformacion_Click);
            // 
            // dtGVWEstad
            // 
            this.dtGVWEstad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtGVWEstad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVWEstad.Location = new System.Drawing.Point(30, 55);
            this.dtGVWEstad.Name = "dtGVWEstad";
            this.dtGVWEstad.Size = new System.Drawing.Size(623, 300);
            this.dtGVWEstad.TabIndex = 1;
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Location = new System.Drawing.Point(57, 12);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(191, 21);
            this.cmbFiltro.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(783, 442);
            this.Controls.Add(this.cmbFiltro);
            this.Controls.Add(this.dtGVWEstad);
            this.Controls.Add(this.btnInformacion);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGVWEstad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInformacion;
        private System.Windows.Forms.DataGridView dtGVWEstad;
        private System.Windows.Forms.ComboBox cmbFiltro;
    }
}

