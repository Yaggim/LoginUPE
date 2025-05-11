namespace LoginPrueba.Administracion
{
    partial class frmConsultaUsuarios
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
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.cboxUsuarios = new System.Windows.Forms.ComboBox();
            this.btnMostrarValorDelCombo = new System.Windows.Forms.Button();
            this.btnMostrarDatosDelClienteDelComboBox = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(12, 12);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(776, 181);
            this.dgvUsuarios.TabIndex = 0;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(135, 415);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(75, 23);
            this.btnRefrescar.TabIndex = 1;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // cboxUsuarios
            // 
            this.cboxUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxUsuarios.FormattingEnabled = true;
            this.cboxUsuarios.Location = new System.Drawing.Point(32, 247);
            this.cboxUsuarios.Name = "cboxUsuarios";
            this.cboxUsuarios.Size = new System.Drawing.Size(121, 21);
            this.cboxUsuarios.TabIndex = 2;
            // 
            // btnMostrarValorDelCombo
            // 
            this.btnMostrarValorDelCombo.Location = new System.Drawing.Point(318, 415);
            this.btnMostrarValorDelCombo.Name = "btnMostrarValorDelCombo";
            this.btnMostrarValorDelCombo.Size = new System.Drawing.Size(151, 23);
            this.btnMostrarValorDelCombo.TabIndex = 3;
            this.btnMostrarValorDelCombo.Text = "Mostrar Valor del Combo";
            this.btnMostrarValorDelCombo.UseVisualStyleBackColor = true;
            this.btnMostrarValorDelCombo.Click += new System.EventHandler(this.btnMostrarValorDelCombo_Click);
            // 
            // btnMostrarDatosDelClienteDelComboBox
            // 
            this.btnMostrarDatosDelClienteDelComboBox.Location = new System.Drawing.Point(318, 311);
            this.btnMostrarDatosDelClienteDelComboBox.Name = "btnMostrarDatosDelClienteDelComboBox";
            this.btnMostrarDatosDelClienteDelComboBox.Size = new System.Drawing.Size(296, 23);
            this.btnMostrarDatosDelClienteDelComboBox.TabIndex = 4;
            this.btnMostrarDatosDelClienteDelComboBox.Text = "Mostrar datos del cliente del combo";
            this.btnMostrarDatosDelClienteDelComboBox.UseVisualStyleBackColor = true;
            this.btnMostrarDatosDelClienteDelComboBox.Click += new System.EventHandler(this.btnMostrarDatosDelClienteDelComboBox_Click);
            // 
            // frmConsultaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMostrarDatosDelClienteDelComboBox);
            this.Controls.Add(this.btnMostrarValorDelCombo);
            this.Controls.Add(this.cboxUsuarios);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.dgvUsuarios);
            this.Name = "frmConsultaUsuarios";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "frmConsultaUsuarios";
            this.Load += new System.EventHandler(this.frmConsultaUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.ComboBox cboxUsuarios;
        private System.Windows.Forms.Button btnMostrarValorDelCombo;
        private System.Windows.Forms.Button btnMostrarDatosDelClienteDelComboBox;
    }
}