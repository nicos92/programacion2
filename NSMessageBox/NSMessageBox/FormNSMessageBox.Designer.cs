namespace NSMessageBox
{
    partial class NSMessageBox
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NSMessageBox));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayoutBtns = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.LblMessage = new System.Windows.Forms.Label();
            this.LblImage = new System.Windows.Forms.Label();
            this.Imgs = new System.Windows.Forms.ImageList(this.components);
            this.BtnAceptar = new Controles.NSButton();
            this.BtnCancelar = new Controles.NSButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.TableLayoutBtns.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.TableLayoutBtns, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 8);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(489, 216);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TableLayoutBtns
            // 
            this.TableLayoutBtns.ColumnCount = 3;
            this.TableLayoutBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutBtns.Controls.Add(this.BtnAceptar, 0, 0);
            this.TableLayoutBtns.Controls.Add(this.BtnCancelar, 2, 0);
            this.TableLayoutBtns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutBtns.Location = new System.Drawing.Point(3, 165);
            this.TableLayoutBtns.Name = "TableLayoutBtns";
            this.TableLayoutBtns.RowCount = 1;
            this.TableLayoutBtns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutBtns.Size = new System.Drawing.Size(483, 48);
            this.TableLayoutBtns.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.Controls.Add(this.LblMessage, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.LblImage, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(483, 156);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // LblMessage
            // 
            this.LblMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblMessage.AutoSize = true;
            this.LblMessage.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMessage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblMessage.Location = new System.Drawing.Point(282, 70);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(62, 16);
            this.LblMessage.TabIndex = 1;
            this.LblMessage.Text = "Mensaje";
            // 
            // LblImage
            // 
            this.LblImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblImage.ImageKey = "cross";
            this.LblImage.ImageList = this.Imgs;
            this.LblImage.Location = new System.Drawing.Point(24, 30);
            this.LblImage.Margin = new System.Windows.Forms.Padding(0);
            this.LblImage.MaximumSize = new System.Drawing.Size(96, 96);
            this.LblImage.MinimumSize = new System.Drawing.Size(96, 96);
            this.LblImage.Name = "LblImage";
            this.LblImage.Size = new System.Drawing.Size(96, 96);
            this.LblImage.TabIndex = 2;
            // 
            // Imgs
            // 
            this.Imgs.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Imgs.ImageStream")));
            this.Imgs.TransparentColor = System.Drawing.Color.Transparent;
            this.Imgs.Images.SetKeyName(0, "cross");
            this.Imgs.Images.SetKeyName(1, "info");
            this.Imgs.Images.SetKeyName(2, "question");
            this.Imgs.Images.SetKeyName(3, "warning");
            this.Imgs.Images.SetKeyName(4, "check");
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.BtnAceptar.BackGroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.BtnAceptar.BorderColor = System.Drawing.Color.DarkGreen;
            this.BtnAceptar.BorderRadius = 18;
            this.BtnAceptar.BorderSize = 1;
            this.BtnAceptar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAceptar.FlatAppearance.BorderSize = 0;
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAceptar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.ForeColor = System.Drawing.Color.White;
            this.BtnAceptar.Location = new System.Drawing.Point(3, 3);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(155, 42);
            this.BtnAceptar.TabIndex = 0;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.TextColor = System.Drawing.Color.White;
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.BtnCancelar.BackGroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.BtnCancelar.BorderColor = System.Drawing.Color.DarkRed;
            this.BtnCancelar.BorderRadius = 18;
            this.BtnCancelar.BorderSize = 1;
            this.BtnCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(325, 3);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(155, 42);
            this.BtnCancelar.TabIndex = 1;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextColor = System.Drawing.Color.White;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // NSMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(507, 232);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NSMessageBox";
            this.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NSMessageBox";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.TableLayoutBtns.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel TableLayoutBtns;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label LblMessage;
        private Controles.NSButton BtnAceptar;
        private Controles.NSButton BtnCancelar;
        private System.Windows.Forms.Label LblImage;
        private System.Windows.Forms.ImageList Imgs;
    }
}

