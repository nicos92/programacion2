using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TxtFrase.Focus();
        }

        private void TxtFrase__TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtFrase_KeyPress(object sender, KeyPressEventArgs e)
        {
            // no deja ingresar un espacio al principio ni dos espacios seguidos ni numeros
            if ((e.KeyChar == 32 && TxtFrase.Text.Length == 0) || (e.KeyChar == 32 && e.KeyChar == TxtFrase.Text[TxtFrase.Text.Length - 1]) || (char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13 && TxtFrase.Text.Length > 0)
            {
                ConfirmarAgregarALista();
            }


        }

        private void ConfirmarAgregarALista()
        {
            NSMessageBox.NSMessageBox cartel = new NSMessageBox.NSMessageBox();
            DialogResult result = cartel.ShowDialog("Confirmar Ingreso", "¿Estas seguro que quieres ingresar esta frase?", NSMessageBox.Iconos.Question, NSMessageBox.Botones.AceptarCancelar);

            if (result == DialogResult.Yes)
            {
                IngresarALista();
            }
        }

        private void IngresarALista()
        {
            string frase = TxtFrase.Text.Trim();
            ListBoxFrases.Items.Add(frase);
            TxtFrase.Text = "";
            TxtFrase.Focus();
        }

        private void ListBoxFrases_SelectedIndexChanged(object sender, EventArgs e)
        {
            string frase = ListBoxFrases.SelectedItem.ToString();
            CantidadPalabras(frase);
            CantidadEspPriUltPalabra(frase);
            CambioColorTxt();
        }

        private void CambioColorTxt()
        {

            //TxtUltimaPalabra.BorderFocusColor = ColoresARGB.Success;
            //TxtPrimerPalabra.BorderFocusColor = ColoresARGB.Success;

            //TxtCantEspacios.BorderFocusColor = ColoresARGB.Success;

            //TxtCantLetras.BorderFocusColor = ColoresARGB.Success;

            ColoresARGB Nuevocolor = new ColoresARGB();
            Color elColor = Nuevocolor.RandomColor();
            TxtUltimaPalabra.BorderFocusColor = elColor;
            TxtPrimerPalabra.BorderFocusColor = elColor;

            TxtCantEspacios.BorderFocusColor = elColor;

            TxtCantLetras.BorderFocusColor = elColor;


        }

        private void CantidadEspPriUltPalabra(string frase)
        {
            string[] palabras = frase.Split(' ');
            int largo = palabras.Length;
            TxtCantEspacios.Text = (largo - 1) + " de Espacios";
            TxtPrimerPalabra.Text = palabras[0];
            TxtUltimaPalabra.Text = palabras[largo - 1];
        }

        private void CantidadPalabras(string frase)
        {
            TxtCantLetras.Text = frase.Length + " Letras";
        }



    }
}
