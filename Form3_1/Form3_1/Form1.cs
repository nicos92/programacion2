using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] ArrValor = { 10000, 5000, 2000, 1000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };

        private List<TipoCambio> ListTipoCambio = new List<TipoCambio>();

        private void TbMontoIngresado_KeyPress(object sender, KeyPressEventArgs e)
        {
            IngresoDigito(e);
        }

        private void TbValorProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            IngresoDigito(e);

        }

        private void IngresoDigito(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
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
            int MontoIngresado = Convert.ToInt32(TbMontoIngresado.Text);
            int ValorProducto = Convert.ToInt32(TbValorProducto.Text);
            int resto = MontoIngresado - ValorProducto;
            Console.WriteLine("Resto: {0}", resto);
            for (int i = 0; i < ArrValor.Length; i++)
            {

                int resultado = resto / ArrValor[i];
                Console.WriteLine("resultado: {0}", resultado);
                if (resultado > 0)
                {
                    resto = resto % ArrValor[i];
                    TipoCambio tc = new TipoCambio();
                    tc.Tipo = ArrValor[i] > 10 ? "Billete" : "Moneda";
                    tc.Valor = ArrValor[i].ToString();
                    tc.Cantidad = resultado.ToString();
                    ListTipoCambio.Add(tc);

                }
            }

            AgregarItemCambio();


        }

        private void AgregarItemCambio()
        {
            LvListaCambio.Items.Clear();
            // Configurar el ListView
            LvListaCambio.View = View.Details; // Establecer la vista a Detalles
            //LvListaCambio.FullRowSelect = true; // Seleccionar toda la fila
            //LvListaCambio.GridLines = false; // Mostrar líneas de la cuadrícula (opcional)
            /*TipoCambio tipoCambio = new TipoCambio()
            {
                Tipo = "Billetin",
                Valor = "200",
                Cantidad = "3"
            };*/

            foreach (var item in ListTipoCambio)
            {


                ListViewItem lvi = new ListViewItem(item.Tipo);

                lvi.SubItems.Add(item.Valor);
                lvi.SubItems.Add(item.Cantidad);

                LvListaCambio.Items.Add(lvi);
            }
        }
    }
}
