using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia2_Act2
{
    public partial class FormSecundario : Form
    {
        public FormSecundario()
        {
            this.Name = "frmInicio";
            this.Text = "Pantala Inicio";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.BackColor = SystemColors.InactiveCaption;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.ControlBox = true;
            this.Font = new Font("Trebuchet MS", 14.75F, FontStyle.Bold);
            this.ShowIcon = false;
            InitializeComponent();
        }

       

        private void FormSecundario_MouseMove(object sender, MouseEventArgs e)
        {
            Random generador = new Random();
            int r = generador.Next(0, 256);
            int g = generador.Next(0, 256);
            int b = generador.Next(0, 256);
            this.BackColor = Color.FromArgb(r, g, b);
        }
    }
}
