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
        
        //public NSMessageBox(string TituloBarra, string Mensaje, Iconos Icon, Botones Boton)
        //{
        //    InitializeComponent();
        //    this.Text = TituloBarra;
        //    LblMessage.Text = Mensaje;
        //    LblImage.ImageIndex = Convert.ToInt32(Icon);
        //    MostrarBotones(Convert.ToInt32(Boton));
        //}


        public NSMessageBox()
        {
            InitializeComponent();
            
        }

        private void MostrarBotones(int Btn)
        {
            if(Btn == 0)
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
            LblImage.ImageIndex = Convert.ToInt32(Icon);
            MostrarBotones(Convert.ToInt32(Boton));
            return this.ShowDialog();
        }
    }

    public enum Iconos { Cross = 0, Info = 1, Question = 2, Warning = 3, Check = 4 }

    public enum Botones { Aceptar = 0, AceptarCancelar = 1}

 

}
