﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace Controles
{
    internal class NSButton : Button
    {
        //Fields
        private int borderSize = 0;
        private int borderRadius = 40;
        private Color borderColor = Color.PaleVioletRed;

        [Category("NS Button")]
        public int BorderSize { get {return borderSize;} set { borderSize = value; this.Invalidate();} }
        [Category("NS Button")]
        public int BorderRadius { get {return borderRadius; }set { borderRadius = value; this.Invalidate(); } }
        [Category("NS Button")]
        public Color BorderColor { get {return borderColor;} set { borderColor = value; this.Invalidate(); } }

        [Category("NS Button")]
        public Color BackGroudColor
        {
            get {return this.BackColor; }
            set { this.BackColor = value; }
            
        }
        [Category("NS Button")]
        public Color TextColor
        {
            get {return this.ForeColor;}
            set { this.ForeColor = value;}
        }

        //Constructor
        public NSButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 49);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
            this.Resize += new EventHandler(Button_Resize);
        }

        private void Button_Resize(object sender, EventArgs e)
        {
            if (borderRadius > this.Height) borderRadius = this.Height;
            {

            }
        }

        //Methods
        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new RectangleF(0,0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1,1,this.Width-0.8f, this.Height-1);

            if (borderRadius > 2) // rounded button
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - 1f))
                using (Pen PenSurface = new Pen(this.Parent.BackColor, 2))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;

                    //Button Surface
                    this.Region = new Region(pathSurface);

                    //draw surface border for HD result
                    e.Graphics.DrawPath(PenSurface, pathSurface);

                    //Button border
                    if (borderSize >= 1)
                    {
                        //draw control border
                        e.Graphics.DrawPath(penBorder, pathBorder);
                    }
                }
            }
            else // normal button
            {
                this.Region = new Region(rectSurface);
                if (borderSize >=1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment=PenAlignment.Inset;
                        e.Graphics.DrawRectangle(penBorder,0,0,this.Width-1,this.Height-1);
                    }
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if (this.DesignMode) { this.Invalidate(); }
        }
    }
}
