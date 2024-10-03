using ABSTRACCION;
using BE;
using BL_L.BLL;
using BLL;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    public partial class frmAltaUsuario : Form
    {
        private BLLRoles _bllRoles;
        private BLLUsuario _bllUsuario;
        public frmAltaUsuario()
        {
            InitializeComponent();
            _bllRoles = new BLLRoles();
            _bllUsuario = new BLLUsuario();
        }

        private void MostrarToolTip(string mensaje, Control control)
        {
            toolTip2.Show(mensaje, control, 0, 0, 2200);
        }

        private void OcultarToolTip(Control control)
        {
            toolTip2.Hide(control);
        }

       

        private void frmAltaUsuario_Load(object sender, EventArgs e)
        {
            CargarRoles();
        }

        private void CargarRoles()
        {
            try
            {
                List<BERol> roles = _bllRoles.ObtenerTodosLosRoles();
                cmbRol.DataSource = roles;
                cmbRol.DisplayMember = "NombreRol"; // Campo que se muestra
                cmbRol.ValueMember = "RolID"; // Valor del campo
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los roles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

            
            string username = txtUserAlta.Text.Trim();
            if (string.IsNullOrEmpty(username))
            {
                MostrarToolTip("Por favor ingresar un usuario", txtUserAlta);
                return;
            }
            OcultarToolTip(txtUserAlta);

            string password = txtPassAlta.Text;
            if (string.IsNullOrEmpty(password))
            {
                MostrarToolTip("Por favor ingrese una contraseña", txtPassAlta);
                return;
            }
            OcultarToolTip(txtPassAlta);

            BLLUsuario _bllUsuario = new BLLUsuario();

            BEUser user = new BEUser
            {
                Username = username,
                Nombre = txtNombreAlta.Text.Trim(),
                Apellido = txtApellidoAlta.Text.Trim(),
                Mail = txtMailAlta.Text,
                RolID = (int)cmbRol.SelectedValue
            };

            if (_bllUsuario.ValidarUser(user))
            {
                MessageBox.Show("Modifique por favor el nombre de Usuario.", "ERROR USUARIO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!_bllUsuario.Validar_pass_regex(password))
            {
                MessageBox.Show("La contraseña debe contener entre 6 y 15 caracteres alfanuméricos.", "ERROR CONTRASEÑA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassAlta.Text = "";
                return;
            }

            string confirmPass = txtConfirm.Text;
            if (password != confirmPass)
            {
                MessageBox.Show("Las contraseñas no coinciden, por favor inténtelo de nuevo.", "ERROR CONTRASEÑA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string passwordEncriptada = _bllUsuario.Encriptador(password);
            user.Password = passwordEncriptada;
            user.DVV = _bllUsuario.ObtenerDVH(user);

            _bllUsuario.AltaUsuario(user);

            MessageBox.Show("Usuario creado exitosamente", "Alta exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
            frmLogin ofrmLogin = new frmLogin();
            ofrmLogin.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
           
                DialogResult resultado = MessageBox.Show("¿Está seguro de que desea salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    this.Hide();
                    frmLogin ofrmLogin = new frmLogin();
                    ofrmLogin.Show();
                }

            
        }


    }

}
