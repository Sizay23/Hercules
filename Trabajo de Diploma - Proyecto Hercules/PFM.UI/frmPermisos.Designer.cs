namespace UI
{
    partial class frmPermisos
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label4 = new System.Windows.Forms.Label();
            this.metroButton1 = new System.Windows.Forms.Button();
            this.btnGuardarConfig = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenuEditar = new System.Windows.Forms.Button();
            this.btnMenuSeleccionar = new System.Windows.Forms.Button();
            this.btnMenuNuevoGuardar = new System.Windows.Forms.Button();
            this.lblNombreNuevoMenu = new System.Windows.Forms.Label();
            this.lblMenuLista = new System.Windows.Forms.Label();
            this.txtBoxNombreMenu = new System.Windows.Forms.TextBox();
            this.cmbBoxMenuLista = new System.Windows.Forms.ComboBox();
            this.btnSubMenuSeleccionar = new System.Windows.Forms.Button();
            this.lblSubMenuLista = new System.Windows.Forms.Label();
            this.cmbBoxNombreSubMenu = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.treeView1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.treeView1.Location = new System.Drawing.Point(306, 67);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(303, 262);
            this.treeView1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(303, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 6;
            this.label4.Tag = "arbol_permisos";
            this.label4.Text = "Arbol de Permisos";
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroButton1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.metroButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroButton1.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold);
            this.metroButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroButton1.Location = new System.Drawing.Point(463, 333);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(146, 47);
            this.metroButton1.TabIndex = 10;
            this.metroButton1.Tag = "eliminar_del_arbol";
            this.metroButton1.Text = "Eliminar del arbol";
            this.metroButton1.UseVisualStyleBackColor = false;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btnGuardarConfig
            // 
            this.btnGuardarConfig.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardarConfig.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuardarConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarConfig.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold);
            this.btnGuardarConfig.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarConfig.Location = new System.Drawing.Point(306, 333);
            this.btnGuardarConfig.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuardarConfig.Name = "btnGuardarConfig";
            this.btnGuardarConfig.Size = new System.Drawing.Size(148, 47);
            this.btnGuardarConfig.TabIndex = 11;
            this.btnGuardarConfig.Tag = "guardar_configuracion";
            this.btnGuardarConfig.Text = "Guardar Arbol";
            this.btnGuardarConfig.UseVisualStyleBackColor = false;
            this.btnGuardarConfig.Click += new System.EventHandler(this.btnGuardarConfig_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(943, 37);
            this.panel1.TabIndex = 12;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(541, 7);
            this.lblUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 20);
            this.lblUser.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(862, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 5;
            this.label1.Tag = "permisos";
            this.label1.Text = "Permisos";
            // 
            // btnMenuEditar
            // 
            this.btnMenuEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMenuEditar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnMenuEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuEditar.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold);
            this.btnMenuEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMenuEditar.Location = new System.Drawing.Point(84, 95);
            this.btnMenuEditar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMenuEditar.Name = "btnMenuEditar";
            this.btnMenuEditar.Size = new System.Drawing.Size(84, 30);
            this.btnMenuEditar.TabIndex = 16;
            this.btnMenuEditar.Tag = "editar";
            this.btnMenuEditar.Text = "Seleccionar";
            this.btnMenuEditar.UseVisualStyleBackColor = false;
            this.btnMenuEditar.Click += new System.EventHandler(this.btnMenuEditar_Click);
            // 
            // btnMenuSeleccionar
            // 
            this.btnMenuSeleccionar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMenuSeleccionar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnMenuSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuSeleccionar.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold);
            this.btnMenuSeleccionar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMenuSeleccionar.Location = new System.Drawing.Point(172, 95);
            this.btnMenuSeleccionar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMenuSeleccionar.Name = "btnMenuSeleccionar";
            this.btnMenuSeleccionar.Size = new System.Drawing.Size(99, 30);
            this.btnMenuSeleccionar.TabIndex = 15;
            this.btnMenuSeleccionar.Tag = "seleccionar";
            this.btnMenuSeleccionar.Text = "Añadir Fam.";
            this.btnMenuSeleccionar.UseVisualStyleBackColor = false;
            this.btnMenuSeleccionar.Click += new System.EventHandler(this.btnMenuSeleccionar_Click);
            // 
            // btnMenuNuevoGuardar
            // 
            this.btnMenuNuevoGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMenuNuevoGuardar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnMenuNuevoGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuNuevoGuardar.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold);
            this.btnMenuNuevoGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMenuNuevoGuardar.Location = new System.Drawing.Point(27, 80);
            this.btnMenuNuevoGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMenuNuevoGuardar.Name = "btnMenuNuevoGuardar";
            this.btnMenuNuevoGuardar.Size = new System.Drawing.Size(133, 33);
            this.btnMenuNuevoGuardar.TabIndex = 14;
            this.btnMenuNuevoGuardar.Tag = "guarda_familia";
            this.btnMenuNuevoGuardar.Text = "Guardar Familia";
            this.btnMenuNuevoGuardar.UseVisualStyleBackColor = false;
            this.btnMenuNuevoGuardar.Click += new System.EventHandler(this.btnMenuNuevoGuardar_Click_1);
            // 
            // lblNombreNuevoMenu
            // 
            this.lblNombreNuevoMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombreNuevoMenu.AutoSize = true;
            this.lblNombreNuevoMenu.Font = new System.Drawing.Font("Arial Narrow", 10.2F);
            this.lblNombreNuevoMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNombreNuevoMenu.Location = new System.Drawing.Point(24, 27);
            this.lblNombreNuevoMenu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreNuevoMenu.Name = "lblNombreNuevoMenu";
            this.lblNombreNuevoMenu.Size = new System.Drawing.Size(86, 17);
            this.lblNombreNuevoMenu.TabIndex = 13;
            this.lblNombreNuevoMenu.Tag = "nombre_familia";
            this.lblNombreNuevoMenu.Text = "Nombre Familia";
            // 
            // lblMenuLista
            // 
            this.lblMenuLista.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMenuLista.AutoSize = true;
            this.lblMenuLista.Font = new System.Drawing.Font("Arial Narrow", 10.2F);
            this.lblMenuLista.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMenuLista.Location = new System.Drawing.Point(82, 46);
            this.lblMenuLista.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMenuLista.Name = "lblMenuLista";
            this.lblMenuLista.Size = new System.Drawing.Size(94, 17);
            this.lblMenuLista.TabIndex = 12;
            this.lblMenuLista.Tag = "familia_permiso";
            this.lblMenuLista.Text = "Familia Permisos";
            // 
            // txtBoxNombreMenu
            // 
            this.txtBoxNombreMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxNombreMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxNombreMenu.Location = new System.Drawing.Point(27, 46);
            this.txtBoxNombreMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxNombreMenu.MaxLength = 20;
            this.txtBoxNombreMenu.Name = "txtBoxNombreMenu";
            this.txtBoxNombreMenu.Size = new System.Drawing.Size(133, 23);
            this.txtBoxNombreMenu.TabIndex = 11;
            // 
            // cmbBoxMenuLista
            // 
            this.cmbBoxMenuLista.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbBoxMenuLista.FormattingEnabled = true;
            this.cmbBoxMenuLista.Location = new System.Drawing.Point(84, 66);
            this.cmbBoxMenuLista.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbBoxMenuLista.Name = "cmbBoxMenuLista";
            this.cmbBoxMenuLista.Size = new System.Drawing.Size(188, 28);
            this.cmbBoxMenuLista.TabIndex = 10;
            // 
            // btnSubMenuSeleccionar
            // 
            this.btnSubMenuSeleccionar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubMenuSeleccionar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSubMenuSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenuSeleccionar.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold);
            this.btnSubMenuSeleccionar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubMenuSeleccionar.Location = new System.Drawing.Point(85, 192);
            this.btnSubMenuSeleccionar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSubMenuSeleccionar.Name = "btnSubMenuSeleccionar";
            this.btnSubMenuSeleccionar.Size = new System.Drawing.Size(187, 30);
            this.btnSubMenuSeleccionar.TabIndex = 20;
            this.btnSubMenuSeleccionar.Tag = "seleccionar";
            this.btnSubMenuSeleccionar.Text = "Añadir";
            this.btnSubMenuSeleccionar.UseVisualStyleBackColor = false;
            this.btnSubMenuSeleccionar.Click += new System.EventHandler(this.btnSubMenuSeleccionar_Click);
            // 
            // lblSubMenuLista
            // 
            this.lblSubMenuLista.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSubMenuLista.AutoSize = true;
            this.lblSubMenuLista.Font = new System.Drawing.Font("Arial Narrow", 10.2F);
            this.lblSubMenuLista.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSubMenuLista.Location = new System.Drawing.Point(82, 143);
            this.lblSubMenuLista.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubMenuLista.Name = "lblSubMenuLista";
            this.lblSubMenuLista.Size = new System.Drawing.Size(91, 17);
            this.lblSubMenuLista.TabIndex = 19;
            this.lblSubMenuLista.Tag = "permiso";
            this.lblSubMenuLista.Text = "Asignar Permiso";
            // 
            // cmbBoxNombreSubMenu
            // 
            this.cmbBoxNombreSubMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbBoxNombreSubMenu.FormattingEnabled = true;
            this.cmbBoxNombreSubMenu.Location = new System.Drawing.Point(84, 162);
            this.cmbBoxNombreSubMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbBoxNombreSubMenu.Name = "cmbBoxNombreSubMenu";
            this.cmbBoxNombreSubMenu.Size = new System.Drawing.Size(188, 28);
            this.cmbBoxNombreSubMenu.TabIndex = 18;
            this.cmbBoxNombreSubMenu.UseWaitCursor = true;
            this.cmbBoxNombreSubMenu.SelectedIndexChanged += new System.EventHandler(this.cmbBoxNombreSubMenu_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.txtBoxNombreMenu);
            this.groupBox1.Controls.Add(this.lblNombreNuevoMenu);
            this.groupBox1.Controls.Add(this.btnMenuNuevoGuardar);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 10.2F);
            this.groupBox1.Location = new System.Drawing.Point(85, 246);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(188, 134);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear Nueva Familia";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.treeView1);
            this.groupBox2.Controls.Add(this.btnSubMenuSeleccionar);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.lblSubMenuLista);
            this.groupBox2.Controls.Add(this.cmbBoxNombreSubMenu);
            this.groupBox2.Controls.Add(this.cmbBoxMenuLista);
            this.groupBox2.Controls.Add(this.lblMenuLista);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.metroButton1);
            this.groupBox2.Controls.Add(this.btnMenuSeleccionar);
            this.groupBox2.Controls.Add(this.btnGuardarConfig);
            this.groupBox2.Controls.Add(this.btnMenuEditar);
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 12.2F);
            this.groupBox2.Location = new System.Drawing.Point(167, 87);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(666, 414);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gestion de Permisos";
            // 
            // frmPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(943, 614);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmPermisos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "permisos";
            this.Text = "Gestion de Permisos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPermisos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button metroButton1;
        private System.Windows.Forms.Button btnGuardarConfig;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMenuEditar;
        private System.Windows.Forms.Button btnMenuSeleccionar;
        private System.Windows.Forms.Button btnMenuNuevoGuardar;
        private System.Windows.Forms.Label lblNombreNuevoMenu;
        private System.Windows.Forms.Label lblMenuLista;
        private System.Windows.Forms.TextBox txtBoxNombreMenu;
        private System.Windows.Forms.ComboBox cmbBoxMenuLista;
        private System.Windows.Forms.Button btnSubMenuSeleccionar;
        private System.Windows.Forms.Label lblSubMenuLista;
        private System.Windows.Forms.ComboBox cmbBoxNombreSubMenu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}