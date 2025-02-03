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
            if(Btn == 0)
            {
                BtnCancelar.Visible = false;
                TableLayoutBtns.SetColumn(BtnAceptar, 1);
            }
            
        }

        

  

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            //this.Close();
            var nuevo = new NSMessageBox();
            nuevo.ShowDialog("titulo", "mensaje", Iconos.Cross, Botones.Aceptar);
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
            //this.Icon = new Icon(GetType(), $"NSMessageBox.Resources.{sIcon}.ico");
            this.Icon = sIcon;

            MostrarBotones(Convert.ToInt32(Boton));
            return this.ShowDialog();
        }

        private Icon GetMiIcon(int icon)
        {
            
                if (icon == 0)
                {
                    return Properties.Resources.cross;
                }
                if (icon == 4)
                {
                    return Properties.Resources.check; 
                }
                return Properties.Resources.check;
        }
        }
    }

   

   

 


