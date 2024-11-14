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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.TbMontoIngresado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbValorProducto = new System.Windows.Forms.TextBox();
            this.BtnCalcularVuelto = new System.Windows.Forms.Button();
            this.LvListaCambio = new System.Windows.Forms.ListView();
            this.Billete = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(239)))), ((int)(((byte)(233)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 361);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 119);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(618, 239);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TbMontoIngresado, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.TbValorProducto, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnCalcularVuelto, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882354F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882354F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(618, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(54, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monto Ingresado:";
            // 
            // TbMontoIngresado
            // 
            this.TbMontoIngresado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.TbMontoIngresado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbMontoIngresado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbMontoIngresado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(239)))), ((int)(((byte)(233)))));
            this.TbMontoIngresado.Location = new System.Drawing.Point(311, 8);
            this.TbMontoIngresado.MaxLength = 18;
            this.TbMontoIngresado.Name = "TbMontoIngresado";
            this.TbMontoIngresado.Size = new System.Drawing.Size(251, 16);
            this.TbMontoIngresado.TabIndex = 2;
            this.TbMontoIngresado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbMontoIngresado_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(54, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor Producto:";
            // 
            // TbValorProducto
            // 
            this.TbValorProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.TbValorProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbValorProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbValorProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(239)))), ((int)(((byte)(233)))));
            this.TbValorProducto.Location = new System.Drawing.Point(311, 37);
            this.TbValorProducto.MaxLength = 18;
            this.TbValorProducto.Name = "TbValorProducto";
            this.TbValorProducto.Size = new System.Drawing.Size(251, 16);
            this.TbValorProducto.TabIndex = 3;
            this.TbValorProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbValorProducto_KeyPress);
            // 
            // BtnCalcularVuelto
            // 
            this.BtnCalcularVuelto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(92)))), ((int)(((byte)(18)))));
            this.BtnCalcularVuelto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCalcularVuelto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCalcularVuelto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(56)))), ((int)(((byte)(33)))));
            this.BtnCalcularVuelto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(111)))), ((int)(((byte)(80)))));
            this.BtnCalcularVuelto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(56)))), ((int)(((byte)(33)))));
            this.BtnCalcularVuelto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalcularVuelto.Location = new System.Drawing.Point(311, 66);
            this.BtnCalcularVuelto.Name = "BtnCalcularVuelto";
            this.BtnCalcularVuelto.Size = new System.Drawing.Size(251, 23);
            this.BtnCalcularVuelto.TabIndex = 4;
            this.BtnCalcularVuelto.Text = "Calcular Vuelto";
            this.BtnCalcularVuelto.UseVisualStyleBackColor = false;
            this.BtnCalcularVuelto.Click += new System.EventHandler(this.BtnCalcularVuelto_Click);
            // 
            // LvListaCambio
            // 
            this.LvListaCambio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.LvListaCambio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LvListaCambio.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Billete,
            this.Valor,
            this.Cantidad});
            this.LvListaCambio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LvListaCambio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(239)))), ((int)(((byte)(233)))));
            this.LvListaCambio.Location = new System.Drawing.Point(64, 26);
            this.LvListaCambio.Name = "LvListaCambio";
            this.LvListaCambio.Size = new System.Drawing.Size(488, 185);
            this.LvListaCambio.TabIndex = 0;
            this.LvListaCambio.UseCompatibleStateImageBehavior = false;
            // 
            // Billete
            // 
            this.Billete.Text = "Billete/Moneda";
            this.Billete.Width = 180;
            // 
            // Cantidad
            // 
            this.Cantidad.Text = "Cantidad";
            this.Cantidad.Width = 120;
            // 
            // Valor
            // 
            this.Valor.Text = "Valor";
            this.Valor.Width = 120;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(624, 361);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("MartianMono NF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(239)))), ((int)(((byte)(233)))));
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
        private System.Windows.Forms.TextBox TbMontoIngresado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbValorProducto;
        private System.Windows.Forms.Button BtnCalcularVuelto;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ListView LvListaCambio;
        private System.Windows.Forms.ColumnHeader Billete;
        private System.Windows.Forms.ColumnHeader Cantidad;
        private System.Windows.Forms.ColumnHeader Valor;
    }
}

