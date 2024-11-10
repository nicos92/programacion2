using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long centavos;
            centavos = long.Parse(TbIngreso.Text);
            LblDolares.Text = "$ " + Convert.ToString(centavos / 100);
            LblCentavos.Text = "C "+  Convert.ToString(centavos % 100);
        }

        private void TbIngreso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;

            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }


        }

        private void EnabledButtonCalcular()
        {
            if (TbIngreso.Text.Length > 0)
            {
                EnabledCalcular(true);
            }
            else
            {
                EnabledCalcular(false);

            }
        }

        private void EnabledCalcular(bool enabled)
        {
            button1.Enabled = enabled;
        }

        private void TbIngreso_TextChanged(object sender, EventArgs e)
        {
            EnabledButtonCalcular();

        }
    }
}
