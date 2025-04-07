namespace TopBar
{
    partial class UserControlTopBar
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Panel = new System.Windows.Forms.Panel();
            this.LblTituloApp = new System.Windows.Forms.Label();
            this.LblNicoS92 = new System.Windows.Forms.Label();
            this.LogoNicos = new System.Windows.Forms.PictureBox();
            this.BtnMinimize = new System.Windows.Forms.Button();
            this.BtnMaximize = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoNicos)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(9)))), ((int)(((byte)(25)))));
            this.Panel.Controls.Add(this.LblTituloApp);
            this.Panel.Controls.Add(this.LblNicoS92);
            this.Panel.Controls.Add(this.LogoNicos);
            this.Panel.Controls.Add(this.BtnMinimize);
            this.Panel.Controls.Add(this.BtnMaximize);
            this.Panel.Controls.Add(this.BtnCerrar);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(545, 40);
            this.Panel.TabIndex = 0;
            this.Panel.DoubleClick += new System.EventHandler(this.Panel_DoubleClick);
            this.Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.Panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            this.Panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseUp);
            // 
            // LblTituloApp
            // 
            this.LblTituloApp.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblTituloApp.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloApp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblTituloApp.Location = new System.Drawing.Point(140, 0);
            this.LblTituloApp.Name = "LblTituloApp";
            this.LblTituloApp.Size = new System.Drawing.Size(136, 40);
            this.LblTituloApp.TabIndex = 5;
            this.LblTituloApp.Text = "Nombre de la App";
            this.LblTituloApp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblNicoS92
            // 
            this.LblNicoS92.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblNicoS92.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNicoS92.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblNicoS92.Location = new System.Drawing.Point(40, 0);
            this.LblNicoS92.Name = "LblNicoS92";
            this.LblNicoS92.Size = new System.Drawing.Size(100, 40);
            this.LblNicoS92.TabIndex = 4;
            this.LblNicoS92.Text = "NicoS92 App";
            this.LblNicoS92.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogoNicos
            // 
            this.LogoNicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(9)))), ((int)(((byte)(25)))));
            this.LogoNicos.Dock = System.Windows.Forms.DockStyle.Left;
            this.LogoNicos.Image = global::TopBar.Properties.Resources.nsx1;
            this.LogoNicos.Location = new System.Drawing.Point(0, 0);
            this.LogoNicos.Name = "LogoNicos";
            this.LogoNicos.Size = new System.Drawing.Size(40, 40);
            this.LogoNicos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoNicos.TabIndex = 3;
            this.LogoNicos.TabStop = false;
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(9)))), ((int)(((byte)(25)))));
            this.BtnMinimize.BackgroundImage = global::TopBar.Properties.Resources.icons8minimize30;
            this.BtnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnMinimize.FlatAppearance.BorderSize = 0;
            this.BtnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(187)))), ((int)(((byte)(69)))));
            this.BtnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimize.Location = new System.Drawing.Point(425, 0);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(40, 40);
            this.BtnMinimize.TabIndex = 2;
            this.BtnMinimize.UseVisualStyleBackColor = false;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // BtnMaximize
            // 
            this.BtnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(9)))), ((int)(((byte)(25)))));
            this.BtnMaximize.BackgroundImage = global::TopBar.Properties.Resources.icons8restoredown32;
            this.BtnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnMaximize.FlatAppearance.BorderSize = 0;
            this.BtnMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.BtnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.BtnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMaximize.Location = new System.Drawing.Point(465, 0);
            this.BtnMaximize.Name = "BtnMaximize";
            this.BtnMaximize.Size = new System.Drawing.Size(40, 40);
            this.BtnMaximize.TabIndex = 1;
            this.BtnMaximize.Tag = "Restore";
            this.BtnMaximize.UseVisualStyleBackColor = false;
            this.BtnMaximize.Visible = false;
            this.BtnMaximize.Click += new System.EventHandler(this.BtnMaximize_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(9)))), ((int)(((byte)(25)))));
            this.BtnCerrar.BackgroundImage = global::TopBar.Properties.Resources.icons8close30;
            this.BtnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Location = new System.Drawing.Point(505, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(40, 40);
            this.BtnCerrar.TabIndex = 0;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // UserControlTopBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel);
            this.Name = "UserControlTopBar";
            this.Size = new System.Drawing.Size(545, 40);
            this.Load += new System.EventHandler(this.UserControlTopBar_Load);
            this.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoNicos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnMaximize;
        private System.Windows.Forms.Button BtnMinimize;
        private System.Windows.Forms.PictureBox LogoNicos;
        private System.Windows.Forms.Label LblNicoS92;
        private System.Windows.Forms.Label LblTituloApp;
    }
}
