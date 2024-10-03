using Abstraccion;
using BE;
using BLL;
using SERVICIOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ABSTRACCION;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    public partial class frmMDI : Form, ITraducible
    {
        private frmBitacora formBitacora = null;
        private frmGestionUser formGestionUser = null;
        private frmPermisos formPermisos = null;
        private frmPermisosUsuarios formPermisosUsuarios = null;
        private frmCrearIdioma formCrearIdioma = null;
        private FromModificarIdioma formModificarIdioma = null;
        private frmAltaUsuario formAltaUsuario = null;
        private FrmModificarUsuario frmModificarUsuario = null;
        private FrmPerfiles frmPerfiles = null;


        BLLUsuario _bllUsuario;
        BLLBitacora _bllBitacora;
        BEBitacora _beBitacora;
        BEPermiso _bePermiso;
        public frmMDI()
        {
            InitializeComponent();
            PermisosUsuario();
            Registrarse();
            CargarIdiomas();
            Actualizar();
            //this.BackgroundImage = Image.FromFile("C:\\Users\\Usuario\\Desktop\\Diploma\\Trabajo de Diploma - Proyecto Hercules\\Imagenes\\images.jpg");
            //this.BackgroundImageLayout = ImageLayout.Zoom; // Opciones: Center, Tile, Stretch, Zoom
        }

        public void Actualizar()
        {
            BLLTraductor bllTraductor = new BLLTraductor();
            List<BEPalabra> Palabras = bllTraductor.ObtenerPalabras();

            if (Tag != null)
            {
                Text = Palabras.Find(pal => pal.Tag.Equals(Tag)).Texto;
            }
            try
            {
                cambioDeContraseñaToolStripMenuItem.Text = Palabras.Find(pal => pal.Tag.Equals(cambioDeContraseñaToolStripMenuItem.Tag)).Texto;
                listarBitacoraToolStripMenuItem.Text = Palabras.Find(pal => pal.Tag.Equals(listarBitacoraToolStripMenuItem.Tag)).Texto;
                altaUsuarioToolStripMenuItem.Text = Palabras.Find(pal => pal.Tag.Equals(altaUsuarioToolStripMenuItem.Tag)).Texto;
                modificarUsuarioToolStripMenuItem.Text = Palabras.Find(pal => pal.Tag.Equals(modificarUsuarioToolStripMenuItem.Tag)).Texto;
                crearIdiomaToolStripMenuItem.Text = Palabras.Find(pal => pal.Tag.Equals(crearIdiomaToolStripMenuItem.Tag)).Texto;
                modificarIdiomaToolStripMenuItem.Text = Palabras.Find(pal => pal.Tag.Equals(modificarIdiomaToolStripMenuItem.Tag)).Texto;
                bitacoraToolStripMenuItem.Text = Palabras.Find(pal => pal.Tag.Equals(bitacoraToolStripMenuItem.Tag)).Texto;
                cambioDeContraseñaToolStripMenuItem.Text = Palabras.Find(pal => pal.Tag.Equals(cambioDeContraseñaToolStripMenuItem.Tag)).Texto;
                permisoToolStripMenuItem.Text = Palabras.Find(pal => pal.Tag.Equals(permisoToolStripMenuItem.Tag)).Texto;
                permisosUsuariosToolStripMenuItem.Text = Palabras.Find(pal => pal.Tag.Equals(permisosUsuariosToolStripMenuItem.Tag)).Texto;
                salirToolStripMenuItem.Text = Palabras.Find(pal => pal.Tag.Equals(salirToolStripMenuItem.Tag)).Texto;
                controlDeVersionesToolStripMenuItem.Text = Palabras.Find(pal => pal.Tag.Equals(controlDeVersionesToolStripMenuItem.Tag)).Texto;
                gestionarIdiomaToolStripMenuItem.Text = Palabras.Find(pal => pal.Tag.Equals(gestionarIdiomaToolStripMenuItem.Tag)).Texto;
                gestionUser.Text = Palabras.Find(pal => pal.Tag.Equals(gestionUser.Tag)).Texto;
            }
            catch (Exception)
            {
                MessageBox.Show("Faltan traducciones");
            }
        }

        private void CargarIdiomas()
        {
            BLLTraductor bllTraductor = new BLLTraductor();
            List<BEIdioma> Idiomas = bllTraductor.ObtenerIdiomasHabilitados();
            comboBox1.DataSource = null;
            comboBox1.DataSource = Idiomas;
        }

        public void Registrarse()
        {
            BLLTraductor BllTraductor = new BLLTraductor();
            BllTraductor.RegistrarForm(this);
        }

        private bool TienePermiso(List<BEPermiso> permisos, string nombrePermiso)
        {
            // Verifica si en la lista de permisos del usuario existe un permiso con el nombre especificado
            return permisos.Any(p => p.NombrePermiso.Equals(nombrePermiso, StringComparison.OrdinalIgnoreCase));
        }
        private void PermisosUsuario()
        {

            BLLUsuario bllUsuario = new BLLUsuario();
            BEUser UsuarioLogueado = bllUsuario.ObtenerUsuarioLogueado();

            List<BEPermiso> permisosUsuario = bllUsuario.ObtenerPermisosUsuario(UsuarioLogueado);

            // Verificar permisos utilizando IDs
            this.cambioDeContraseñaToolStripMenuItem.Visible = TienePermisoPorId(permisosUsuario, 1); // Cambiar Contraseña
            this.listarBitacoraToolStripMenuItem.Visible = TienePermisoPorId(permisosUsuario, 2); // Listar Bitacora
            this.altaUsuarioToolStripMenuItem.Visible = TienePermisoPorId(permisosUsuario, 3); // Alta Usuario
            this.modificarUsuarioToolStripMenuItem.Visible = TienePermisoPorId(permisosUsuario, 4); // Eliminar Usuario
            this.crearIdiomaToolStripMenuItem.Visible = TienePermisoPorId(permisosUsuario, 5); // Crear Idioma
            this.modificarIdiomaToolStripMenuItem.Visible = TienePermisoPorId(permisosUsuario, 6); // Modificar Idioma
            this.controlDeVersionesToolStripMenuItem.Visible = TienePermisoPorId(permisosUsuario, 7); // Control de Versiones
            this.mascotasToolStripMenuItem.Visible = TienePermisoPorId(permisosUsuario, 27); // Mascota
            this.misDatosToolStripMenuItem.Visible = TienePermisoPorId(permisosUsuario, 28); // Mis Datos
            this.turnosToolStripMenuItem.Visible = TienePermisoPorId(permisosUsuario, 29); // Turnos
            this.bitacoraToolStripMenuItem.Visible = TienePermisoPorId(permisosUsuario, 9);//Bitacora
            this.gestionarIdiomaToolStripMenuItem.Visible = TienePermisoPorId(permisosUsuario, 5); //Idioma
            this.gestionUser.Visible = TienePermisoPorId(permisosUsuario, 3); //Gestion User

        }

        // Método para verificar si el usuario tiene un permiso por su ID
        private bool TienePermisoPorId(List<BEPermiso> permisos, int idPermiso)
        {
            // Verifica si en la lista de permisos del usuario existe un permiso con el ID especificado
            return permisos.Any(p => p.Id == idPermiso);
        }

        //bool resultado;
        //resultado = bllpadre.ValidarIdPermiso(UsuarioLogueado.LPermisos, 1);
        //if (resultado == false)
        //{
        //    this.cambioDeContraseñaToolStripMenuItem.Visible = true;
        //}
        //else
        //{
        //    this.cambioDeContraseñaToolStripMenuItem.Visible = false;
        //}

        //resultado = true;
        //resultado = bllpadre.ValidarIdPermiso(UsuarioLogueado.LPermisos, 2);
        //if (resultado == false)
        //{
        //    this.listarBitacoraToolStripMenuItem.Visible = true;
        //}
        //else
        //{
        //    this.listarBitacoraToolStripMenuItem.Visible = false;
        //}

        //resultado = true;
        //resultado = bllpadre.ValidarIdPermiso(UsuarioLogueado.LPermisos, 3);
        //if (resultado == false)
        //{
        //    this.altaUsuarioToolStripMenuItem.Visible = true;
        //}
        //else
        //{
        //    this.altaUsuarioToolStripMenuItem.Visible = false;
        //}

        //resultado = true;
        //resultado = bllpadre.ValidarIdPermiso(UsuarioLogueado.LPermisos, 4);
        //if (resultado == false)
        //{
        //    this.modificarUsuarioToolStripMenuItem.Visible = true;
        //}
        //else
        //{
        //    this.modificarUsuarioToolStripMenuItem.Visible = false;
        //}


        //resultado = true;
        //resultado = bllpadre.ValidarIdPermiso(UsuarioLogueado.LPermisos, 5);
        //if (resultado == false)
        //{
        //    this.crearIdiomaToolStripMenuItem.Visible = true;
        //}
        //else
        //{
        //    this.crearIdiomaToolStripMenuItem.Visible = false;
        //}

        //resultado = true;
        //resultado = bllpadre.ValidarIdPermiso(UsuarioLogueado.LPermisos, 6);
        //if (resultado == false)
        //{
        //    this.modificarIdiomaToolStripMenuItem.Visible = true;
        //}
        //else
        //{
        //    this.modificarIdiomaToolStripMenuItem.Visible = false;
        //}



        //resultado = true;
        //resultado = bllpadre.ValidarIdPermiso(UsuarioLogueado.LPermisos, 7);
        //if (resultado == false)
        //{
        //    this.controlDeVersionesToolStripMenuItem.Visible = true;
        //}
        //else
        //{
        //    this.controlDeVersionesToolStripMenuItem.Visible = false;
        //}


    //}
        private void AbrirFormBitacora()
        {
            if (formGestionUser != null && formGestionUser.Visible)
            {
                formGestionUser.Hide();
            }

            if (formBitacora == null || formBitacora.IsDisposed)
            {
                formBitacora = new frmBitacora();
                formBitacora.MdiParent = this;
                formBitacora.FormClosed += (s, e) => formBitacora = null; 
                formBitacora.WindowState = FormWindowState.Maximized;
                formBitacora.Show();
            }
            else
            {
                formBitacora.BringToFront();
                formBitacora.WindowState = FormWindowState.Maximized;
                formBitacora.Show(); 
            }
        }

        private void AbrirFormGestionUser()
        {
            if (formBitacora != null && formBitacora.Visible)
            {
                formBitacora.Hide();
            }

            if (formGestionUser == null || formGestionUser.IsDisposed)
            {
                formGestionUser = new frmGestionUser();
                formGestionUser.MdiParent = this;
                formGestionUser.FormClosed += (s, e) => formGestionUser = null; 
                formGestionUser.WindowState = FormWindowState.Maximized;
                formGestionUser.Show();
            }
            else
            {
                formGestionUser.BringToFront();
                formGestionUser.WindowState = FormWindowState.Maximized;
                formGestionUser.Show(); 
            }
        }





        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                _beBitacora = new BEBitacora();
                _bllBitacora = new BLLBitacora();
                _bllUsuario = new BLLUsuario();



                _beBitacora.Tipo = BitacoraTipo.INFO;
                _beBitacora.Usuario = Sesion.ObtenerUsername();
                _beBitacora.Mensaje = "Cierre de sesion.";
                _bllBitacora.Add(_beBitacora);
                _bllUsuario.CerrarSesion();
                Application.Exit();
            }
        }

        private void cambioDeContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormGestionUser();
        }

        private void listarBitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormBitacora();
        }

        private void permisoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (formPermisos == null || formPermisos.IsDisposed)
            {
                formPermisos = new frmPermisos();
                formPermisos.MdiParent = this;
                formPermisos.WindowState = FormWindowState.Maximized;
                formPermisos.Show();
            }
            else
            {
                formPermisos.BringToFront();
            }

        }

        private void permisosUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formPermisosUsuarios == null || formPermisosUsuarios.IsDisposed)
            {
                formPermisosUsuarios = new frmPermisosUsuarios();
                formPermisosUsuarios.MdiParent = this;
                formPermisosUsuarios.WindowState = FormWindowState.Maximized;
                formPermisosUsuarios.Show();
            }
            else
            {
                formPermisosUsuarios.BringToFront();
            }

        }

        private void altaUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formAltaUsuario == null || formAltaUsuario.IsDisposed)
            {
                formAltaUsuario = new frmAltaUsuario();
                formAltaUsuario.MdiParent = this;
                formAltaUsuario.WindowState = FormWindowState.Maximized;
                formAltaUsuario.Show();

            }
            else
            {
                formAltaUsuario.BringToFront();
            }
        }

        

        private void crearIdiomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formCrearIdioma == null || formCrearIdioma.IsDisposed)
            {
                formCrearIdioma = new frmCrearIdioma();
                formCrearIdioma.MdiParent = this;
                formCrearIdioma.WindowState = FormWindowState.Maximized;
                formCrearIdioma.Show();

            }
            else
            {
                formCrearIdioma.BringToFront();
            }
        }

        private void modificarIdiomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formModificarIdioma == null || formModificarIdioma.IsDisposed)
            {
                formModificarIdioma = new FromModificarIdioma();
                formModificarIdioma.MdiParent = this;
                formModificarIdioma.WindowState = FormWindowState.Maximized;
                formModificarIdioma.Show();

            }
            else
            {
                formModificarIdioma.BringToFront();
            }
        }

        private void controlDeVersionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmPerfiles == null || frmPerfiles.IsDisposed)
            {
                frmPerfiles = new FrmPerfiles();
                frmPerfiles.MdiParent = this;
                frmPerfiles.WindowState = FormWindowState.Maximized;
                frmPerfiles.Show();

            }
            else
            {
                frmPerfiles.BringToFront();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            BEIdioma Idioma = (BEIdioma)comboBox1.SelectedItem;
            if (Idioma != null)
            {
                BLLTraductor bllTraductor = new BLLTraductor();
                bllTraductor.CambiarIdioma(Idioma.Id);
            }
        }


        private void modificarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmModificarUsuario == null || frmModificarUsuario.IsDisposed)
            {
                frmModificarUsuario = new FrmModificarUsuario();
                frmModificarUsuario.MdiParent = this;
                frmModificarUsuario.WindowState = FormWindowState.Maximized;
                frmModificarUsuario.Show();

            }
            else
            {
                frmModificarUsuario.BringToFront();
            }
        }

        private void gestionUser_Click(object sender, EventArgs e)
        {

        }

        private void bitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmMDI_Load(object sender, EventArgs e)
        {

        }

        private void mascota1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void MostrarPanel(Control control)
        {
            // Limpiar el contenido del panel principal
            panelContenidoPrincipal.Controls.Clear();

            // Agregar el nuevo control al panel
            control.Dock = DockStyle.Fill; // Para que el control ocupe todo el espacio disponible
            panelContenidoPrincipal.Controls.Add(control);
        }
        private void btnMascotas_Click(object sender, EventArgs e)
        {
            // Crear una instancia del control de usuario de Mascotas
            ucMascotas controlMascotas = new ucMascotas();
            MostrarPanel(controlMascotas); // Muestra el control de usuario de Mascotas


        }

        private void btnTurnos_Click(object sender, EventArgs e)
        {
            // Crear una instancia del control de usuario de Turnos
            ucTurnos controlTurnos = new ucTurnos();
            MostrarPanel(controlTurnos); // Muestra el control de usuario de Turnos
        }

        private void btnMisDatos_Click(object sender, EventArgs e)
        {
            // Crear una instancia del control de usuario de Mis Datos
            ucMisDatos controlMisDatos = new ucMisDatos();
            MostrarPanel(controlMisDatos); // Muestra el control de usuario de Mis Datos
        }

        private void panelMenuLateral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnVerMascotas_Click(object sender, EventArgs e)
        {

        }

        private void BtnAgregarMascota_Click(object sender, EventArgs e)
        {

        }
    }


}
