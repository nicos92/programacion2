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

        }
    }
}
