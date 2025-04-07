using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NSMessageBox;

namespace Form3_1
{
    public partial class Form1 : Form
    {
        private NSMessageBox.NSMessageBox msjBox = new NSMessageBox.NSMessageBox();

        public Form1()
        {
            InitializeComponent();
        }

        long MontoIngresado;
        long ValorProducto;
        long resto;

        int[] ArrValor = { 50000, 20000, 10000, 5000, 2000, 1000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };

        private List<TipoCambio> ListTipoCambio = new List<TipoCambio>();

        private void TbMontoIngresado_KeyPress(object sender, KeyPressEventArgs e)
        {
            IngresoDigitoEntero(e);
        }

        private void TbValorProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            IngresoDigitoDecimal(e);


        }

        private void IngresoDigitoEntero(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }
        private void IngresoDigitoDecimal(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 46 || e.KeyChar == 44)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }



        private void BtnCalcularVuelto_Click(object sender, EventArgs e)
        {
            ListTipoCambio.Clear();

            MontoIngresado = Convert.ToInt64(TbMontoIngresado.Text);

            ValorProducto = Convert.ToInt64(TbValorProducto.Text.Split(',')[0]);



            DialogResult dr = msjBox.ShowDialog("Cuenta", "¿Estas seguro que querés hacer el cálculo?\nValor producto: " + ValorProducto + "\nMonto ingresado: " + MontoIngresado, Iconos.Info, Botones.AceptarCancelar);

            if (dr == DialogResult.Yes)
            {


                resto = MontoIngresado - ValorProducto;

                LblTotalCambio.Text = "Cambio Total: $" + resto.ToString();
                LblTotalCambio.Visible = true;
                AgregarItemLista(resto);

                AgregarItemCambio();
            }




        }

        private void AgregarItemLista(long resto)
        {
            for (int i = 0; i < ArrValor.Length; i++)
            {

                decimal resultado = resto / ArrValor[i];
                if (resultado > 0)
                {
                    resto = resto % ArrValor[i];
                    TipoCambio tc = new TipoCambio();
                    tc.Tipo = ArrValor[i] > 10 ? "Billete de " : "Moneda de";
                    tc.Valor = "$" + ArrValor[i].ToString();
                    tc.Cantidad = resultado.ToString();
                    ListTipoCambio.Add(tc);

                }
            }
        }

        private void AgregarItemCambio()
        {
            LvListaCambio.Items.Clear();
            LvListaCambio.View = View.Details; // Establecer la vista a Detalles


            foreach (var item in ListTipoCambio)
            {


                ListViewItem lvi = new ListViewItem(item.Tipo);

                lvi.SubItems.Add(item.Valor);
                lvi.SubItems.Add(item.Cantidad);

                LvListaCambio.Items.Add(lvi);
            }
        }

        private void HabilitarCalcular()
        {
            if (TbValorProducto.Text.Length == 0 || TbMontoIngresado.Text.Length == 0)
            {
                BtnCalcularVuelto.Enabled = false;
            }
            else if (TbValorProducto.Text.Length > 0 && TbMontoIngresado.Text.Length > 0)
            {

                BtnCalcularVuelto.Enabled = Convert.ToDecimal(TbMontoIngresado.Text) >= Convert.ToDecimal(TbValorProducto.Text);
            }
        }

        private void TbMontoIngresado_KeyUp(object sender, KeyEventArgs e)
        {
            //HabilitarCalcular();

        }

        private void TbValorProducto_KeyUp(object sender, KeyEventArgs e)
        {
            //HabilitarCalcular();

        }

        private void TbMontoIngresado__TextChanged(object sender, EventArgs e)
        {
            HabilitarCalcular();
        }

        private void TbValorProducto__TextChanged(object sender, EventArgs e)
        {
            HabilitarCalcular();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TbValorProducto.Focus();
        }

        private void BtnCalcularVuelto_EnabledChanged(object sender, EventArgs e)
        {
            if (BtnCalcularVuelto.Enabled)
            {
                BtnCalcularVuelto.FlatAppearance.BorderColor = ColoresARGB.White;
                BtnCalcularVuelto.BackColor = ColoresARGB.Primary;
                BtnCalcularVuelto.Font = new Font("Verdana", 12, FontStyle.Bold);
            }
            else
            {
                BtnCalcularVuelto.FlatAppearance.BorderColor = ColoresARGB.Black;

                BtnCalcularVuelto.BackColor = ColoresARGB.Secondary;
                BtnCalcularVuelto.Font = new Font("Verdana", 10, FontStyle.Regular);


            }
        }

        private void TbValorProducto_Enter(object sender, EventArgs e)
        {
            TbValorProducto.BorderStyle = BorderStyle.Fixed3D;
        }

        private void TbValorProducto_Leave(object sender, EventArgs e)
        {
            TbValorProducto.BorderStyle = BorderStyle.FixedSingle;

        }

        private void TbMontoIngresado_Enter(object sender, EventArgs e)
        {
            TbMontoIngresado.BorderStyle = BorderStyle.Fixed3D;
        }

        private void TbMontoIngresado_Leave(object sender, EventArgs e)
        {
            TbMontoIngresado.BorderStyle = BorderStyle.FixedSingle;

        }
    }
}
