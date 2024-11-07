using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class FormUno : System.Windows.Forms.Form
    {
        public FormUno()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Si";
            label2.Text = "Si";

            label3.Text = "Si";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "No";
            label2.Text = "No";

            label3.Text = "No";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "A";
            label2.Text = "B";

            label3.Text = "C";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Adios Mundo!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;

            label3.Visible = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;

            label3.Visible = true;

        }

        private void FormUno_Load(object sender, EventArgs e)
        {
            MessageBox.Show("bienvenido a la aplicacion");
        }

        private void FormUno_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void FormUno_MouseMove(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void FormUno_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("gracias por usar nuestra aplicacion");
        }

        private void FormUno_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("que tengas buen dia");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // no muestra cual es la ventana principal. cuando se cierra la venta principal se cierran los demas formularios

            FormUno form1 = new FormUno();
            form1.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FormUno formDialog = new FormUno();
            formDialog.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form frmInicio = new Form();
            frmInicio.Name = "frmInicio";
            frmInicio.Text = "Formulario de envio";
            frmInicio.StartPosition = FormStartPosition.CenterScreen;
            frmInicio.FormBorderStyle = FormBorderStyle.Fixed3D;
            frmInicio.BackColor = SystemColors.InactiveCaption;
            frmInicio.MaximizeBox = false;
            frmInicio.MinimizeBox = true;
            frmInicio.ControlBox = true;
            frmInicio.Font = new Font("Trebuchet MS", 14.75F, FontStyle.Bold);
            frmInicio.ShowIcon = false;
            frmInicio.ShowDialog();
        }
        private void FrmEjemplo_MouseMove(object sender, MouseEventArgs e)
        {
            Random generador = new Random();
            int r = generador.Next(0, 256);
            int g = generador.Next(0, 256);
            int b = generador.Next(0, 256);
            this.BackColor = Color.FromArgb(r, g, b);
        }
    }
}
