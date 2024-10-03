namespace UI
{
    partial class frmMDI
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bitacoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarBitacoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionUser = new System.Windows.Forms.ToolStripMenuItem();
            this.altaUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambioDeContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permisoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permisosUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarIdiomaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearIdiomaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarIdiomaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlDeVersionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mascotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mascota1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mascota2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.misDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panelMenuLateral = new System.Windows.Forms.Panel();
            this.btnMisDatos = new System.Windows.Forms.Button();
            this.btnTurnos = new System.Windows.Forms.Button();
            this.btnMascotas = new System.Windows.Forms.Button();
            this.panelContenidoPrincipal = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panelMenuLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bitacoraToolStripMenuItem,
            this.gestionUser,
            this.gestionarIdiomaToolStripMenuItem,
            this.controlDeVersionesToolStripMenuItem,
            this.mascotasToolStripMenuItem,
            this.turnosToolStripMenuItem,
            this.misDatosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1007, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bitacoraToolStripMenuItem
            // 
            this.bitacoraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarBitacoraToolStripMenuItem});
            this.bitacoraToolStripMenuItem.Name = "bitacoraToolStripMenuItem";
            this.bitacoraToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.bitacoraToolStripMenuItem.Tag = "bitacora";
            this.bitacoraToolStripMenuItem.Text = "Bitacora";
            this.bitacoraToolStripMenuItem.Click += new System.EventHandler(this.bitacoraToolStripMenuItem_Click);
            // 
            // listarBitacoraToolStripMenuItem
            // 
            this.listarBitacoraToolStripMenuItem.Name = "listarBitacoraToolStripMenuItem";
            this.listarBitacoraToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.listarBitacoraToolStripMenuItem.Tag = "listar_bitacora";
            this.listarBitacoraToolStripMenuItem.Text = "Listar Bitacora";
            this.listarBitacoraToolStripMenuItem.Click += new System.EventHandler(this.listarBitacoraToolStripMenuItem_Click);
            // 
            // gestionUser
            // 
            this.gestionUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaUsuarioToolStripMenuItem,
            this.modificarUsuarioToolStripMenuItem,
            this.cambioDeContraseñaToolStripMenuItem,
            this.permisoToolStripMenuItem,
            this.permisosUsuariosToolStripMenuItem});
            this.gestionUser.Name = "gestionUser";
            this.gestionUser.Size = new System.Drawing.Size(105, 20);
            this.gestionUser.Tag = "gestion_de_perfil";
            this.gestionUser.Text = "Gestion de Perfil";
            this.gestionUser.Click += new System.EventHandler(this.gestionUser_Click);
            // 
            // altaUsuarioToolStripMenuItem
            // 
            this.altaUsuarioToolStripMenuItem.Name = "altaUsuarioToolStripMenuItem";
            this.altaUsuarioToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.altaUsuarioToolStripMenuItem.Tag = "alta_usuario";
            this.altaUsuarioToolStripMenuItem.Text = "Alta usuario";
            this.altaUsuarioToolStripMenuItem.Click += new System.EventHandler(this.altaUsuarioToolStripMenuItem_Click);
            // 
            // modificarUsuarioToolStripMenuItem
            // 
            this.modificarUsuarioToolStripMenuItem.Name = "modificarUsuarioToolStripMenuItem";
            this.modificarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.modificarUsuarioToolStripMenuItem.Tag = "modificar_usuario";
            this.modificarUsuarioToolStripMenuItem.Text = "Modificar Usuario";
            this.modificarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.modificarUsuarioToolStripMenuItem_Click);
            // 
            // cambioDeContraseñaToolStripMenuItem
            // 
            this.cambioDeContraseñaToolStripMenuItem.Name = "cambioDeContraseñaToolStripMenuItem";
            this.cambioDeContraseñaToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.cambioDeContraseñaToolStripMenuItem.Tag = "cambio_contraseña";
            this.cambioDeContraseñaToolStripMenuItem.Text = "Cambio de contraseña";
            this.cambioDeContraseñaToolStripMenuItem.Click += new System.EventHandler(this.cambioDeContraseñaToolStripMenuItem_Click);
            // 
            // permisoToolStripMenuItem
            // 
            this.permisoToolStripMenuItem.Name = "permisoToolStripMenuItem";
            this.permisoToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.permisoToolStripMenuItem.Tag = "permisos";
            this.permisoToolStripMenuItem.Text = "Permisos";
            this.permisoToolStripMenuItem.Click += new System.EventHandler(this.permisoToolStripMenuItem_Click);
            // 
            // permisosUsuariosToolStripMenuItem
            // 
            this.permisosUsuariosToolStripMenuItem.Name = "permisosUsuariosToolStripMenuItem";
            this.permisosUsuariosToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.permisosUsuariosToolStripMenuItem.Tag = "permisos_usuarios";
            this.permisosUsuariosToolStripMenuItem.Text = "Permisos Usuarios";
            this.permisosUsuariosToolStripMenuItem.Click += new System.EventHandler(this.permisosUsuariosToolStripMenuItem_Click);
            // 
            // gestionarIdiomaToolStripMenuItem
            // 
            this.gestionarIdiomaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearIdiomaToolStripMenuItem,
            this.modificarIdiomaToolStripMenuItem});
            this.gestionarIdiomaToolStripMenuItem.Name = "gestionarIdiomaToolStripMenuItem";
            this.gestionarIdiomaToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.gestionarIdiomaToolStripMenuItem.Tag = "gestionar_idioma";
            this.gestionarIdiomaToolStripMenuItem.Text = "Gestionar Idioma";
            // 
            // crearIdiomaToolStripMenuItem
            // 
            this.crearIdiomaToolStripMenuItem.Name = "crearIdiomaToolStripMenuItem";
            this.crearIdiomaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.crearIdiomaToolStripMenuItem.Tag = "crear_idioma";
            this.crearIdiomaToolStripMenuItem.Text = "Crear Idioma";
            this.crearIdiomaToolStripMenuItem.Click += new System.EventHandler(this.crearIdiomaToolStripMenuItem_Click);
            // 
            // modificarIdiomaToolStripMenuItem
            // 
            this.modificarIdiomaToolStripMenuItem.Name = "modificarIdiomaToolStripMenuItem";
            this.modificarIdiomaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.modificarIdiomaToolStripMenuItem.Tag = "modificar_idioma";
            this.modificarIdiomaToolStripMenuItem.Text = "Modificar Idioma";
            this.modificarIdiomaToolStripMenuItem.Click += new System.EventHandler(this.modificarIdiomaToolStripMenuItem_Click);
            // 
            // controlDeVersionesToolStripMenuItem
            // 
            this.controlDeVersionesToolStripMenuItem.Name = "controlDeVersionesToolStripMenuItem";
            this.controlDeVersionesToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.controlDeVersionesToolStripMenuItem.Tag = "control_de_versiones";
            this.controlDeVersionesToolStripMenuItem.Text = "Control de Versiones";
            this.controlDeVersionesToolStripMenuItem.Click += new System.EventHandler(this.controlDeVersionesToolStripMenuItem_Click);
            // 
            // mascotasToolStripMenuItem
            // 
            this.mascotasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mascota1ToolStripMenuItem,
            this.mascota2ToolStripMenuItem});
            this.mascotasToolStripMenuItem.Name = "mascotasToolStripMenuItem";
            this.mascotasToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.mascotasToolStripMenuItem.Text = "Mascotas";
            // 
            // mascota1ToolStripMenuItem
            // 
            this.mascota1ToolStripMenuItem.Name = "mascota1ToolStripMenuItem";
            this.mascota1ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.mascota1ToolStripMenuItem.Text = "Mascota1";
            this.mascota1ToolStripMenuItem.Click += new System.EventHandler(this.mascota1ToolStripMenuItem_Click);
            // 
            // mascota2ToolStripMenuItem
            // 
            this.mascota2ToolStripMenuItem.Name = "mascota2ToolStripMenuItem";
            this.mascota2ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.mascota2ToolStripMenuItem.Text = "Mascota 2";
            // 
            // turnosToolStripMenuItem
            // 
            this.turnosToolStripMenuItem.Name = "turnosToolStripMenuItem";
            this.turnosToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.turnosToolStripMenuItem.Text = "Turnos";
            // 
            // misDatosToolStripMenuItem
            // 
            this.misDatosToolStripMenuItem.Name = "misDatosToolStripMenuItem";
            this.misDatosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.misDatosToolStripMenuItem.Text = "Mis Datos";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.salirToolStripMenuItem.Tag = "cerrar_sistema";
            this.salirToolStripMenuItem.Text = "Cerrar Sistema";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(750, 3);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panelMenuLateral
            // 
            this.panelMenuLateral.BackColor = System.Drawing.Color.LightGray;
            this.panelMenuLateral.Controls.Add(this.btnMisDatos);
            this.panelMenuLateral.Controls.Add(this.btnTurnos);
            this.panelMenuLateral.Controls.Add(this.btnMascotas);
            this.panelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuLateral.Location = new System.Drawing.Point(0, 24);
            this.panelMenuLateral.Name = "panelMenuLateral";
            this.panelMenuLateral.Size = new System.Drawing.Size(200, 460);
            this.panelMenuLateral.TabIndex = 5;
            this.panelMenuLateral.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenuLateral_Paint);
            // 
            // btnMisDatos
            // 
            this.btnMisDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMisDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMisDatos.Location = new System.Drawing.Point(0, 46);
            this.btnMisDatos.Name = "btnMisDatos";
            this.btnMisDatos.Size = new System.Drawing.Size(200, 23);
            this.btnMisDatos.TabIndex = 2;
            this.btnMisDatos.Text = "Mis Datos";
            this.btnMisDatos.UseVisualStyleBackColor = true;
            this.btnMisDatos.Click += new System.EventHandler(this.btnMisDatos_Click);
            // 
            // btnTurnos
            // 
            this.btnTurnos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTurnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTurnos.Location = new System.Drawing.Point(0, 23);
            this.btnTurnos.Name = "btnTurnos";
            this.btnTurnos.Size = new System.Drawing.Size(200, 23);
            this.btnTurnos.TabIndex = 1;
            this.btnTurnos.Text = "Turnos";
            this.btnTurnos.UseVisualStyleBackColor = true;
            this.btnTurnos.Click += new System.EventHandler(this.btnTurnos_Click);
            // 
            // btnMascotas
            // 
            this.btnMascotas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMascotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMascotas.Location = new System.Drawing.Point(0, 0);
            this.btnMascotas.Name = "btnMascotas";
            this.btnMascotas.Size = new System.Drawing.Size(200, 23);
            this.btnMascotas.TabIndex = 0;
            this.btnMascotas.Text = "Mascotas";
            this.btnMascotas.UseVisualStyleBackColor = true;
            this.btnMascotas.Click += new System.EventHandler(this.btnMascotas_Click);
            // 
            // panelContenidoPrincipal
            // 
            this.panelContenidoPrincipal.BackColor = System.Drawing.Color.DimGray;
            this.panelContenidoPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenidoPrincipal.Location = new System.Drawing.Point(200, 24);
            this.panelContenidoPrincipal.Name = "panelContenidoPrincipal";
            this.panelContenidoPrincipal.Size = new System.Drawing.Size(807, 460);
            this.panelContenidoPrincipal.TabIndex = 6;
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1007, 484);
            this.Controls.Add(this.panelContenidoPrincipal);
            this.Controls.Add(this.panelMenuLateral);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administracion";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMDI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelMenuLateral.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bitacoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionUser;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambioDeContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarBitacoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarIdiomaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearIdiomaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarIdiomaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlDeVersionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permisoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permisosUsuariosToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolStripMenuItem mascotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem misDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mascota1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mascota2ToolStripMenuItem;
        private System.Windows.Forms.Panel panelMenuLateral;
        private System.Windows.Forms.Button btnMisDatos;
        private System.Windows.Forms.Button btnTurnos;
        private System.Windows.Forms.Button btnMascotas;
        private System.Windows.Forms.Panel panelContenidoPrincipal;
    }
}

