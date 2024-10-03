namespace UI
{
    partial class ucMascotas
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxMascotas = new System.Windows.Forms.ComboBox();
            this.pictureBoxMascota1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewHistorial = new System.Windows.Forms.DataGridView();
            this.dataGridViewTurnos = new System.Windows.Forms.DataGridView();
            this.frmMascota = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxMascota1 = new System.Windows.Forms.GroupBox();
            this.lblNombreMascota1 = new System.Windows.Forms.Label();
            this.btnEditarMascota1 = new System.Windows.Forms.Button();
            this.btnEliminarMascota1 = new System.Windows.Forms.Button();
            this.lblEdadMascota1 = new System.Windows.Forms.Label();
            this.lblRazaMascota1 = new System.Windows.Forms.Label();
            this.lblSexoMascota1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMascota1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTurnos)).BeginInit();
            this.groupBoxMascota1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxMascotas
            // 
            this.comboBoxMascotas.FormattingEnabled = true;
            this.comboBoxMascotas.Location = new System.Drawing.Point(92, 12);
            this.comboBoxMascotas.Name = "comboBoxMascotas";
            this.comboBoxMascotas.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMascotas.TabIndex = 0;
            this.comboBoxMascotas.SelectedIndexChanged += new System.EventHandler(this.comboBoxMascotas_SelectedIndexChanged);
            // 
            // pictureBoxMascota1
            // 
            this.pictureBoxMascota1.Location = new System.Drawing.Point(192, 19);
            this.pictureBoxMascota1.Name = "pictureBoxMascota1";
            this.pictureBoxMascota1.Size = new System.Drawing.Size(179, 137);
            this.pictureBoxMascota1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMascota1.TabIndex = 1;
            this.pictureBoxMascota1.TabStop = false;
            // 
            // dataGridViewHistorial
            // 
            this.dataGridViewHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistorial.Location = new System.Drawing.Point(558, 90);
            this.dataGridViewHistorial.Name = "dataGridViewHistorial";
            this.dataGridViewHistorial.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewHistorial.TabIndex = 2;
            // 
            // dataGridViewTurnos
            // 
            this.dataGridViewTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTurnos.Location = new System.Drawing.Point(558, 295);
            this.dataGridViewTurnos.Name = "dataGridViewTurnos";
            this.dataGridViewTurnos.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewTurnos.TabIndex = 3;
            // 
            // frmMascota
            // 
            this.frmMascota.Location = new System.Drawing.Point(166, 547);
            this.frmMascota.Name = "frmMascota";
            this.frmMascota.Size = new System.Drawing.Size(163, 23);
            this.frmMascota.TabIndex = 4;
            this.frmMascota.Text = "Agregar Mascota";
            this.frmMascota.UseVisualStyleBackColor = true;
            this.frmMascota.Click += new System.EventHandler(this.frmMascota_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mascota";
            // 
            // groupBoxMascota1
            // 
            this.groupBoxMascota1.Controls.Add(this.lblSexoMascota1);
            this.groupBoxMascota1.Controls.Add(this.lblRazaMascota1);
            this.groupBoxMascota1.Controls.Add(this.lblEdadMascota1);
            this.groupBoxMascota1.Controls.Add(this.btnEliminarMascota1);
            this.groupBoxMascota1.Controls.Add(this.btnEditarMascota1);
            this.groupBoxMascota1.Controls.Add(this.lblNombreMascota1);
            this.groupBoxMascota1.Controls.Add(this.pictureBoxMascota1);
            this.groupBoxMascota1.Location = new System.Drawing.Point(28, 71);
            this.groupBoxMascota1.Name = "groupBoxMascota1";
            this.groupBoxMascota1.Size = new System.Drawing.Size(387, 292);
            this.groupBoxMascota1.TabIndex = 6;
            this.groupBoxMascota1.TabStop = false;
            this.groupBoxMascota1.Text = "Mascota";
            // 
            // lblNombreMascota1
            // 
            this.lblNombreMascota1.AutoSize = true;
            this.lblNombreMascota1.Location = new System.Drawing.Point(9, 41);
            this.lblNombreMascota1.Name = "lblNombreMascota1";
            this.lblNombreMascota1.Size = new System.Drawing.Size(47, 13);
            this.lblNombreMascota1.TabIndex = 2;
            this.lblNombreMascota1.Text = "Nombre:";
            // 
            // btnEditarMascota1
            // 
            this.btnEditarMascota1.Location = new System.Drawing.Point(34, 246);
            this.btnEditarMascota1.Name = "btnEditarMascota1";
            this.btnEditarMascota1.Size = new System.Drawing.Size(75, 23);
            this.btnEditarMascota1.TabIndex = 3;
            this.btnEditarMascota1.Text = "Editar";
            this.btnEditarMascota1.UseVisualStyleBackColor = true;
            this.btnEditarMascota1.Click += new System.EventHandler(this.btnEditarMascota1_Click);
            // 
            // btnEliminarMascota1
            // 
            this.btnEliminarMascota1.Location = new System.Drawing.Point(115, 246);
            this.btnEliminarMascota1.Name = "btnEliminarMascota1";
            this.btnEliminarMascota1.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarMascota1.TabIndex = 4;
            this.btnEliminarMascota1.Text = "Eliminar";
            this.btnEliminarMascota1.UseVisualStyleBackColor = true;
            this.btnEliminarMascota1.Click += new System.EventHandler(this.btnEliminarMascota1_Click);
            // 
            // lblEdadMascota1
            // 
            this.lblEdadMascota1.AutoSize = true;
            this.lblEdadMascota1.Location = new System.Drawing.Point(10, 67);
            this.lblEdadMascota1.Name = "lblEdadMascota1";
            this.lblEdadMascota1.Size = new System.Drawing.Size(35, 13);
            this.lblEdadMascota1.TabIndex = 6;
            this.lblEdadMascota1.Text = "Edad:";
            // 
            // lblRazaMascota1
            // 
            this.lblRazaMascota1.AutoSize = true;
            this.lblRazaMascota1.Location = new System.Drawing.Point(9, 94);
            this.lblRazaMascota1.Name = "lblRazaMascota1";
            this.lblRazaMascota1.Size = new System.Drawing.Size(32, 13);
            this.lblRazaMascota1.TabIndex = 7;
            this.lblRazaMascota1.Text = "Raza";
            // 
            // lblSexoMascota1
            // 
            this.lblSexoMascota1.AutoSize = true;
            this.lblSexoMascota1.Location = new System.Drawing.Point(9, 120);
            this.lblSexoMascota1.Name = "lblSexoMascota1";
            this.lblSexoMascota1.Size = new System.Drawing.Size(34, 13);
            this.lblSexoMascota1.TabIndex = 8;
            this.lblSexoMascota1.Text = "Sexo:";
            // 
            // ucMascotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Controls.Add(this.groupBoxMascota1);
            this.Controls.Add(this.dataGridViewTurnos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.frmMascota);
            this.Controls.Add(this.dataGridViewHistorial);
            this.Controls.Add(this.comboBoxMascotas);
            this.Name = "ucMascotas";
            this.Size = new System.Drawing.Size(1087, 598);
            this.Load += new System.EventHandler(this.ucMascotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMascota1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTurnos)).EndInit();
            this.groupBoxMascota1.ResumeLayout(false);
            this.groupBoxMascota1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMascotas;
        private System.Windows.Forms.PictureBox pictureBoxMascota1;
        private System.Windows.Forms.DataGridView dataGridViewHistorial;
        private System.Windows.Forms.DataGridView dataGridViewTurnos;
        private System.Windows.Forms.Button frmMascota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxMascota1;
        private System.Windows.Forms.Button btnEliminarMascota1;
        private System.Windows.Forms.Button btnEditarMascota1;
        private System.Windows.Forms.Label lblNombreMascota1;
        private System.Windows.Forms.Label lblSexoMascota1;
        private System.Windows.Forms.Label lblRazaMascota1;
        private System.Windows.Forms.Label lblEdadMascota1;
    }
}
