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
    public partial class Form1 : Form
    {
        public Form1()
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

        bool Mostrar = true;

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Random generador = new Random();
            int r = generador.Next(0, 256);
            int g = generador.Next(0, 256);
            int b = generador.Next(0, 256);
            this.BackColor = Color.FromArgb(r, g, b);

        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            //creamos una instancia de la clase “frmSecundario”
            FormSecundario F1 = new FormSecundario();
            //controlamos que la variable no haya cambiado aún
            //en caso de ser "false" significa que F1 ya fue abierto
            if (Mostrar == true)
            {
                F1.Show();
                Mostrar = false;
            }

        }
    }
}
