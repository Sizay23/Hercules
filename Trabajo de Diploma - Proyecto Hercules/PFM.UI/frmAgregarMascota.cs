using BE;
using BL_L;
using SERVICIOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class frmAgregarMascota : Form
    {
        private BLLMascota _bllMascota;
        public frmAgregarMascota()
        {
            InitializeComponent();
            _bllMascota = new BLLMascota();
        }
        private void ConfigurarFormulario()
        {
          
        }




        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Capturar los datos ingresados por el usuario
                string nombre = txtNombre.Text;
                string especie = cmbEspecie.SelectedItem?.ToString();
                string raza = txtRaza.Text;
                int edad = (int)nudEdad.Value;
                char sexo = Convert.ToChar(cmbSexo.SelectedItem?.ToString());
                string imagen = txtImagen.Text;
                string userName = Sesion.ObtenerUsername(); // Obtener el nombre de usuario desde la sesión

                // Validar los datos
                if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(especie))
                {
                    MessageBox.Show("El nombre y la especie son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Crear una nueva instancia de BEMascota
                BEMascota nuevaMascota = new BEMascota
                {
                    Nombre = nombre,
                    Especie = especie,
                    Raza = raza,
                    Edad = edad,
                    Sexo = sexo,
                    Imagen = imagen,
                    UserName = userName
                };

                // Intentar agregar la mascota a través de la BLL
                bool resultado = _bllMascota.AgregarMascota(nuevaMascota);

                if (resultado)
                {
                    MessageBox.Show("Mascota agregada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Cerrar el formulario después de guardar
                }
                else
                {
                    MessageBox.Show("No se pudo agregar la mascota. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnSeleccionarImagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtImagen.Text = openFileDialog.FileName; // Mostrar la ruta del archivo seleccionado
                }
            }
        }


    }
}