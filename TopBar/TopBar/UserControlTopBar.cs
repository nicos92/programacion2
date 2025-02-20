using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TopBar
{
    public partial class UserControlTopBar : UserControl
    {
        public UserControlTopBar()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            Form mainForm = this.FindForm();


            if (mainForm!=null)
            {
                mainForm.WindowState = FormWindowState.Minimized;
            }
        }

        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            Form mainForm = this.FindForm();

            if (BtnMaximize.Tag.ToString() == "Restore")
            {
                
                BtnMaximize.Tag = "Maximized";
                if (mainForm != null)
                {
                    mainForm.WindowState = FormWindowState.Maximized;
                }
                BtnMaximize.BackgroundImage = Properties.Resources.icons8maximizebutton32;
            }
            else if (BtnMaximize.Tag.ToString()=="Maximized")
            {
                BtnMaximize.Tag = "Restore";
                if (mainForm != null)
                {
                    mainForm.WindowState = FormWindowState.Normal;
                }
                BtnMaximize.BackgroundImage = Properties.Resources.icons8restoredown32;
            }
        }

        private bool isDragging = false;
        private Point lastCursorPosition;
        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursorPosition = e.Location;
            }
        }

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            Form Mainform = this.FindForm();
            if (isDragging)
            {
                // Calcular la nueva posición del formulario
                int deltaX = e.Location.X - lastCursorPosition.X;
                int deltaY = e.Location.Y - lastCursorPosition.Y;
                Mainform.Location = new Point(Mainform.Location.X + deltaX, Mainform.Location.Y + deltaY);
            }
        }

        private void Panel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void Panel_DoubleClick(object sender, EventArgs e)
        {
            //BtnMaximize_Click(sender, e);
        }
    }
}
