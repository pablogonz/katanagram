using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsCali
{
    public partial class QueDeseaRegistra : Form
    {
        public QueDeseaRegistra()
        {
            InitializeComponent();
        }

        private void BRegistrarE_Click(object sender, EventArgs e)
        {
            Form FormulariodeEstudiante = new RegistrodeEstudiantes();
            FormulariodeEstudiante.ShowDialog();
        }

        private void BRegistrarP_Click(object sender, EventArgs e)
        {
            Form FormularioProfesor = new RegistrodeProfesores();
            FormularioProfesor.ShowDialog();
        }

        private void BRegistrarA_Click(object sender, EventArgs e)
        {
            
            
            Form FormularioAsignatura = new RegistrarAsignatura();
            FormularioAsignatura.ShowDialog();
        }

        private void BRegistrarC_Click(object sender, EventArgs e)
        {
            // Formulario Registrar Calificación
            Form FormCalificaciones = new RegistroCalificaciones();
            FormCalificaciones.ShowDialog();
        }

        private void btnPuntosHonor_Click(object sender, EventArgs e)
        {
            Form frmPuntosHonor = new frmPuntosHonor();
            frmPuntosHonor.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Form f = new fCrearUsuarios();
            f.ShowDialog();
        }
    }
}
