using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NSMessageBox
{
    public partial class NSMessageBox : Form
    {



        public NSMessageBox()
        {
            InitializeComponent();


        }

        private void MostrarBotones(int Btn)
        {
            if (Btn == 0)
            {
                BtnCancelar.Visible = false;
                TableLayoutBtns.SetColumn(BtnAceptar, 1);
            }

        }





        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public DialogResult ShowDialog(string TituloBarra, string Mensaje, Iconos Icon, Botones Boton)
        {
            this.Text = TituloBarra;
            LblMessage.Text = Mensaje;

            int miIcono = Convert.ToInt32(Icon);

            LblImage.ImageIndex = miIcono;
            Icon sIcon = GetMiIcon(miIcono);
            this.Icon = sIcon;

            MostrarBotones(Convert.ToInt32(Boton));
            return this.ShowDialog();
        }

       

        private Icon GetMiIcon(int icon)
        { 
            if (icon == 0)
            {
                BtnAceptar.BackGroudColor = ColoresARGB.Danger;
                return Properties.Resources.cross32;



            }
            if (icon == 1)
            {
                BtnAceptar.BackGroudColor = ColoresARGB.Primary;
                return Properties.Resources.info32;
            }
            if (icon == 2)
            {
                BtnAceptar.BackGroudColor = ColoresARGB.Primary;
                return Properties.Resources.question32;

            }
            if (icon == 3)
            {
                BtnAceptar.BackGroudColor = ColoresARGB.Warning;
                BtnAceptar.ForeColor = ColoresARGB.Black;
                return Properties.Resources.warning32;

            }
            if (icon == 4)
            {
                BtnAceptar.BackGroudColor = ColoresARGB.Success;
                return Properties.Resources.check;

            }
            return Properties.Resources.check;
        }
    }
}








