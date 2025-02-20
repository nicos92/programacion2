using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TopBar
{
    public partial class Form1 : Form
    {
        private UserControl topbar;
        private bool isDragging = false;
        private Point lastCursorPosition;
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            topbar = new UserControlTopBar();
            PanelTop.Controls.Add(topbar);
            
            //topbar.Size = new Size(PanelTop.Width, PanelTop.Height);
            topbar.Dock = DockStyle.Fill;
        }

        private void PanelTop_SizeChanged(object sender, EventArgs e)
        {


            //topbar.Size = new Size(PanelTop.Width, PanelTop.Height);
            
        }

        private void PanelTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursorPosition = e.Location;
            }
        }

        private void PanelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                // Calcular la nueva posición del formulario
                int deltaX = e.Location.X - lastCursorPosition.X;
                int deltaY = e.Location.Y - lastCursorPosition.Y;
                this.Location = new Point(this.Location.X + deltaX, this.Location.Y + deltaY);
            }
        }

        private void PanelTop_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }
    }
}
