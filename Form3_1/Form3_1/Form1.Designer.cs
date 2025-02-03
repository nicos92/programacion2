namespace Form3_1
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.LvListaCambio = new System.Windows.Forms.ListView();
            this.Billete = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCalcularVuelto = new System.Windows.Forms.Button();
            this.TbMontoIngresado = new Controles.NSTextBox();
            this.TbValorProducto = new Controles.NSTextBox();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(780, 457);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculo de vuelto";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.LvListaCambio, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 170);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(774, 284);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // LvListaCambio
            // 
            this.LvListaCambio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.LvListaCambio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LvListaCambio.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Billete,
            this.Valor,
            this.Cantidad});
            this.LvListaCambio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LvListaCambio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LvListaCambio.Location = new System.Drawing.Point(80, 31);
            this.LvListaCambio.Name = "LvListaCambio";
            this.LvListaCambio.Size = new System.Drawing.Size(613, 221);
            this.LvListaCambio.TabIndex = 0;
            this.LvListaCambio.UseCompatibleStateImageBehavior = false;
            // 
            // Billete
            // 
            this.Billete.Text = "Billete/Moneda";
            this.Billete.Width = 180;
            // 
            // Valor
            // 
            this.Valor.Text = "Valor";
            this.Valor.Width = 120;
            // 
            // Cantidad
            // 
            this.Cantidad.Text = "Cantidad";
            this.Cantidad.Width = 120;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnCalcularVuelto, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.TbMontoIngresado, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.TbValorProducto, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882354F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882354F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(774, 147);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(67, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monto Ingresado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(67, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 43);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor Producto:";
            // 
            // BtnCalcularVuelto
            // 
            this.BtnCalcularVuelto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.BtnCalcularVuelto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCalcularVuelto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCalcularVuelto.Enabled = false;
            this.BtnCalcularVuelto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalcularVuelto.Location = new System.Drawing.Point(389, 97);
            this.BtnCalcularVuelto.Name = "BtnCalcularVuelto";
            this.BtnCalcularVuelto.Size = new System.Drawing.Size(316, 37);
            this.BtnCalcularVuelto.TabIndex = 4;
            this.BtnCalcularVuelto.Text = "Calcular Vuelto";
            this.BtnCalcularVuelto.UseVisualStyleBackColor = false;
            this.BtnCalcularVuelto.Click += new System.EventHandler(this.BtnCalcularVuelto_Click);
            // 
            // TbMontoIngresado
            // 
            this.TbMontoIngresado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.TbMontoIngresado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.TbMontoIngresado.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.TbMontoIngresado.BorderSize = 2;
            this.TbMontoIngresado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbMontoIngresado.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbMontoIngresado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TbMontoIngresado.Location = new System.Drawing.Point(390, 12);
            this.TbMontoIngresado.Margin = new System.Windows.Forms.Padding(4);
            this.TbMontoIngresado.Multiline = false;
            this.TbMontoIngresado.Name = "TbMontoIngresado";
            this.TbMontoIngresado.Padding = new System.Windows.Forms.Padding(7);
            this.TbMontoIngresado.PasswordChar = false;
            this.TbMontoIngresado.Size = new System.Drawing.Size(314, 35);
            this.TbMontoIngresado.TabIndex = 5;
            this.TbMontoIngresado.UnderLinesStyle = false;
            this.TbMontoIngresado._TextChanged += new System.EventHandler(this.TbMontoIngresado__TextChanged);
            this.TbMontoIngresado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbMontoIngresado_KeyPress);
            this.TbMontoIngresado.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TbMontoIngresado_KeyUp);
            // 
            // TbValorProducto
            // 
            this.TbValorProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.TbValorProducto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.TbValorProducto.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.TbValorProducto.BorderSize = 2;
            this.TbValorProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbValorProducto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbValorProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TbValorProducto.Location = new System.Drawing.Point(390, 55);
            this.TbValorProducto.Margin = new System.Windows.Forms.Padding(4);
            this.TbValorProducto.Multiline = false;
            this.TbValorProducto.Name = "TbValorProducto";
            this.TbValorProducto.Padding = new System.Windows.Forms.Padding(7);
            this.TbValorProducto.PasswordChar = false;
            this.TbValorProducto.Size = new System.Drawing.Size(314, 35);
            this.TbValorProducto.TabIndex = 6;
            this.TbValorProducto.UnderLinesStyle = false;
            this.TbValorProducto._TextChanged += new System.EventHandler(this.TbValorProducto__TextChanged);
            this.TbValorProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbValorProducto_KeyPress);
            this.TbValorProducto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TbValorProducto_KeyUp);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(780, 457);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guia 3_1";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnCalcularVuelto;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ListView LvListaCambio;
        private System.Windows.Forms.ColumnHeader Billete;
        private System.Windows.Forms.ColumnHeader Cantidad;
        private System.Windows.Forms.ColumnHeader Valor;
        private Controles.NSTextBox TbMontoIngresado;
        private Controles.NSTextBox TbValorProducto;
    }
}

