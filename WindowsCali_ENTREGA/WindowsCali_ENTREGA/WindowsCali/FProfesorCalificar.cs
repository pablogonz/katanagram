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
    public partial class FProfesorCalificar : Form
    {
        public FProfesorCalificar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistroCalificaciones calificaciones = new RegistroCalificaciones();
            calificaciones.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmPuntosHonor puntosHonor = new frmPuntosHonor();
            puntosHonor.ShowDialog();
        }
    }
}
