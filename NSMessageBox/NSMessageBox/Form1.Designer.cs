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
            this.BtnAceptar = new Controles.NSButton();
            this.BtnCancelar = new Controles.NSButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.LblMessage = new System.Windows.Forms.Label();
            this.LblImage = new System.Windows.Forms.Label();
            this.Imgs = new System.Windows.Forms.ImageList(this.components);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 8);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(368, 195);
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
            this.TableLayoutBtns.Location = new System.Drawing.Point(3, 149);
            this.TableLayoutBtns.Name = "TableLayoutBtns";
            this.TableLayoutBtns.RowCount = 1;
            this.TableLayoutBtns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutBtns.Size = new System.Drawing.Size(362, 43);
            this.TableLayoutBtns.TabIndex = 0;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.Green;
            this.BtnAceptar.BackGroudColor = System.Drawing.Color.Green;
            this.BtnAceptar.BorderColor = System.Drawing.Color.DarkGreen;
            this.BtnAceptar.BorderRadius = 18;
            this.BtnAceptar.BorderSize = 1;
            this.BtnAceptar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAceptar.FlatAppearance.BorderSize = 0;
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAceptar.ForeColor = System.Drawing.Color.White;
            this.BtnAceptar.Location = new System.Drawing.Point(3, 3);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(114, 37);
            this.BtnAceptar.TabIndex = 0;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.TextColor = System.Drawing.Color.White;
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Red;
            this.BtnCancelar.BackGroudColor = System.Drawing.Color.Red;
            this.BtnCancelar.BorderColor = System.Drawing.Color.DarkRed;
            this.BtnCancelar.BorderRadius = 18;
            this.BtnCancelar.BorderSize = 1;
            this.BtnCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(243, 3);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(116, 37);
            this.BtnCancelar.TabIndex = 1;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextColor = System.Drawing.Color.White;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
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
            this.tableLayoutPanel3.Size = new System.Drawing.Size(362, 140);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // LblMessage
            // 
            this.LblMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblMessage.AutoSize = true;
            this.LblMessage.Location = new System.Drawing.Point(211, 63);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(47, 13);
            this.LblMessage.TabIndex = 1;
            this.LblMessage.Text = "Mensaje";
            // 
            // LblImage
            // 
            this.LblImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblImage.ImageKey = "cross";
            this.LblImage.ImageList = this.Imgs;
            this.LblImage.Location = new System.Drawing.Point(6, 22);
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
            // NSMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NSMessageBox";
            this.Padding = new System.Windows.Forms.Padding(8);
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

