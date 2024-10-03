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
    public partial class ucMascotas : UserControl
    {
        // Declaración de las instancias de las clases BLL
        private BLLMascota _bllMascotas;
        private BLLHistorialMedico _bllHistorial;
        private BLLTurno _bllTurnos;

        public ucMascotas()
        {
            InitializeComponent();

            // Inicialización de las instancias de las clases BLL
            _bllMascotas = new BLLMascota();
            _bllHistorial = new BLLHistorialMedico();
            _bllTurnos = new BLLTurno();
        }

        private void ucMascotas_Load(object sender, EventArgs e)
        {
            // Llama al método para cargar las mascotas del usuario logueado
            CargarMascotasUsuario();
        }

        private void CargarMascotasUsuario()
        {
            // Obtiene el usuario logueado desde la sesión
            string userName = Sesion.ObtenerUsername();

            // Llama al método que obtiene las mascotas del usuario desde la capa de lógica de negocios (BLL)
            var mascotas = _bllMascotas.ObtenerMascotasPorUsuario(userName);

            // Asigna la lista de mascotas al ComboBox
            comboBoxMascotas.DataSource = mascotas;
            comboBoxMascotas.DisplayMember = "Nombre"; // Campo que se mostrará en el ComboBox
            comboBoxMascotas.ValueMember = "MascotaID"; // Campo que representa el ID de la mascota
        }

        private void comboBoxMascotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Carga la información de la mascota seleccionada
            if (comboBoxMascotas.SelectedItem != null)
            {
                var mascotaSeleccionada = (BEMascota)comboBoxMascotas.SelectedItem;
                CargarInformacionMascota(mascotaSeleccionada);
            }
        }

        private void CargarInformacionMascota(BEMascota mascotaSeleccionada)
        {
            // Mostrar la imagen de la mascota
            pictureBoxMascota1.ImageLocation = mascotaSeleccionada.Imagen;

            lblNombreMascota1.Text = mascotaSeleccionada.Nombre;
            lblEdadMascota1.Text = mascotaSeleccionada.Edad.ToString();
            lblRazaMascota1.Text = mascotaSeleccionada.Raza;
            lblSexoMascota1.Text = mascotaSeleccionada.Sexo.ToString();
            // Llama al método que obtiene el historial médico de la mascota
            var historial = _bllHistorial.ObtenerHistorialMedicoPorMascota(mascotaSeleccionada.MascotaID);
            dataGridViewHistorial.DataSource = historial;

            // Llama al método que obtiene los próximos turnos de la mascota
            var turnos = _bllTurnos.ObtenerTurnosPorMascota(mascotaSeleccionada.MascotaID);
            dataGridViewTurnos.DataSource = turnos;
        }

        private void frmMascota_Click(object sender, EventArgs e)
        {
            frmAgregarMascota formAgregarMascota = new frmAgregarMascota();

       
            formAgregarMascota.ShowDialog();
        }

        private void btnEliminarMascota1_Click(object sender, EventArgs e)
        {
            // Código para eliminar la mascota
            DialogResult result = MessageBox.Show("¿Está seguro de eliminar esta mascota?", "Confirmación", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Lógica de eliminación
                MessageBox.Show("Mascota eliminada.");
            }
        }

        private void btnEditarMascota1_Click(object sender, EventArgs e)
        {
            // Código para editar la mascota
            MessageBox.Show("Editar Mascota: " + lblNombreMascota1.Text);
        }
    }
}
