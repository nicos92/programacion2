namespace Guia_5
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.ListBoxFrases = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnLimpiarTodo = new Controles.NSButton();
            this.TxtFrase = new Controles.NSTextBox();
            this.TxtUltimaPalabra = new Controles.NSTextBox();
            this.TxtPrimerPalabra = new Controles.NSTextBox();
            this.TxtCantEspacios = new Controles.NSTextBox();
            this.TxtCantLetras = new Controles.NSTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(8);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(780, 457);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.BtnLimpiarTodo, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ListBoxFrases, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.TxtFrase, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(11, 11);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(376, 435);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "INGRESE UNA FRASE";
            // 
            // ListBoxFrases
            // 
            this.ListBoxFrases.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(34)))));
            this.ListBoxFrases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBoxFrases.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ListBoxFrases.FormattingEnabled = true;
            this.ListBoxFrases.ItemHeight = 16;
            this.ListBoxFrases.Location = new System.Drawing.Point(16, 94);
            this.ListBoxFrases.Margin = new System.Windows.Forms.Padding(16);
            this.ListBoxFrases.Name = "ListBoxFrases";
            this.ListBoxFrases.Size = new System.Drawing.Size(344, 269);
            this.ListBoxFrases.TabIndex = 2;
            this.ListBoxFrases.SelectedIndexChanged += new System.EventHandler(this.ListBoxFrases_SelectedIndexChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.TxtUltimaPalabra, 0, 8);
            this.tableLayoutPanel3.Controls.Add(this.TxtPrimerPalabra, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.TxtCantEspacios, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.TxtCantLetras, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(398, 16);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(8);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 9;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(366, 425);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "LA FRASE SELECCIONADA";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contiene un total de:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Contiene un total de:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 247);
            this.label5.Margin = new System.Windows.Forms.Padding(4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Comienza con la palabra:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 336);
            this.label6.Margin = new System.Windows.Forms.Padding(4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Termina con la palabra:";
            // 
            // BtnLimpiarTodo
            // 
            this.BtnLimpiarTodo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnLimpiarTodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.BtnLimpiarTodo.BackGroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.BtnLimpiarTodo.BorderColor = System.Drawing.Color.Pink;
            this.BtnLimpiarTodo.BorderRadius = 15;
            this.BtnLimpiarTodo.BorderSize = 0;
            this.BtnLimpiarTodo.FlatAppearance.BorderSize = 0;
            this.BtnLimpiarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiarTodo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiarTodo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnLimpiarTodo.Location = new System.Drawing.Point(113, 387);
            this.BtnLimpiarTodo.Margin = new System.Windows.Forms.Padding(8);
            this.BtnLimpiarTodo.Name = "BtnLimpiarTodo";
            this.BtnLimpiarTodo.Size = new System.Drawing.Size(150, 40);
            this.BtnLimpiarTodo.TabIndex = 3;
            this.BtnLimpiarTodo.Text = "Limpiar Todo";
            this.BtnLimpiarTodo.TextColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnLimpiarTodo.UseVisualStyleBackColor = false;
            // 
            // TxtFrase
            // 
            this.TxtFrase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(34)))));
            this.TxtFrase.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.TxtFrase.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.TxtFrase.BorderSize = 2;
            this.TxtFrase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtFrase.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFrase.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtFrase.Location = new System.Drawing.Point(8, 40);
            this.TxtFrase.Margin = new System.Windows.Forms.Padding(8);
            this.TxtFrase.Multiline = false;
            this.TxtFrase.Name = "TxtFrase";
            this.TxtFrase.Padding = new System.Windows.Forms.Padding(7);
            this.TxtFrase.PasswordChar = false;
            this.TxtFrase.ReadOnly = false;
            this.TxtFrase.Size = new System.Drawing.Size(360, 30);
            this.TxtFrase.TabIndex = 1;
            this.TxtFrase.UnderLinesStyle = false;
            this.TxtFrase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFrase_KeyPress);
            // 
            // TxtUltimaPalabra
            // 
            this.TxtUltimaPalabra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(34)))));
            this.TxtUltimaPalabra.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.TxtUltimaPalabra.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.TxtUltimaPalabra.BorderSize = 1;
            this.TxtUltimaPalabra.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtUltimaPalabra.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUltimaPalabra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtUltimaPalabra.Location = new System.Drawing.Point(8, 364);
            this.TxtUltimaPalabra.Margin = new System.Windows.Forms.Padding(8);
            this.TxtUltimaPalabra.Multiline = false;
            this.TxtUltimaPalabra.Name = "TxtUltimaPalabra";
            this.TxtUltimaPalabra.Padding = new System.Windows.Forms.Padding(7);
            this.TxtUltimaPalabra.PasswordChar = false;
            this.TxtUltimaPalabra.ReadOnly = true;
            this.TxtUltimaPalabra.Size = new System.Drawing.Size(350, 29);
            this.TxtUltimaPalabra.TabIndex = 7;
            this.TxtUltimaPalabra.UnderLinesStyle = false;
            // 
            // TxtPrimerPalabra
            // 
            this.TxtPrimerPalabra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(34)))));
            this.TxtPrimerPalabra.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.TxtPrimerPalabra.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.TxtPrimerPalabra.BorderSize = 1;
            this.TxtPrimerPalabra.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtPrimerPalabra.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrimerPalabra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtPrimerPalabra.Location = new System.Drawing.Point(8, 275);
            this.TxtPrimerPalabra.Margin = new System.Windows.Forms.Padding(8);
            this.TxtPrimerPalabra.Multiline = false;
            this.TxtPrimerPalabra.Name = "TxtPrimerPalabra";
            this.TxtPrimerPalabra.Padding = new System.Windows.Forms.Padding(7);
            this.TxtPrimerPalabra.PasswordChar = false;
            this.TxtPrimerPalabra.ReadOnly = true;
            this.TxtPrimerPalabra.Size = new System.Drawing.Size(350, 29);
            this.TxtPrimerPalabra.TabIndex = 6;
            this.TxtPrimerPalabra.UnderLinesStyle = false;
            // 
            // TxtCantEspacios
            // 
            this.TxtCantEspacios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(34)))));
            this.TxtCantEspacios.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.TxtCantEspacios.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.TxtCantEspacios.BorderSize = 1;
            this.TxtCantEspacios.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtCantEspacios.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCantEspacios.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtCantEspacios.Location = new System.Drawing.Point(8, 186);
            this.TxtCantEspacios.Margin = new System.Windows.Forms.Padding(8);
            this.TxtCantEspacios.Multiline = false;
            this.TxtCantEspacios.Name = "TxtCantEspacios";
            this.TxtCantEspacios.Padding = new System.Windows.Forms.Padding(7);
            this.TxtCantEspacios.PasswordChar = false;
            this.TxtCantEspacios.ReadOnly = true;
            this.TxtCantEspacios.Size = new System.Drawing.Size(350, 29);
            this.TxtCantEspacios.TabIndex = 5;
            this.TxtCantEspacios.UnderLinesStyle = false;
            // 
            // TxtCantLetras
            // 
            this.TxtCantLetras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(34)))));
            this.TxtCantLetras.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.TxtCantLetras.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.TxtCantLetras.BorderSize = 1;
            this.TxtCantLetras.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtCantLetras.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCantLetras.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtCantLetras.Location = new System.Drawing.Point(8, 97);
            this.TxtCantLetras.Margin = new System.Windows.Forms.Padding(8);
            this.TxtCantLetras.Multiline = false;
            this.TxtCantLetras.Name = "TxtCantLetras";
            this.TxtCantLetras.Padding = new System.Windows.Forms.Padding(7);
            this.TxtCantLetras.PasswordChar = false;
            this.TxtCantLetras.ReadOnly = true;
            this.TxtCantLetras.Size = new System.Drawing.Size(350, 30);
            this.TxtCantLetras.TabIndex = 4;
            this.TxtCantLetras.UnderLinesStyle = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(780, 457);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Guia 5";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Controles.NSButton BtnLimpiarTodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ListBoxFrases;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Controles.NSTextBox TxtFrase;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Controles.NSTextBox TxtUltimaPalabra;
        private Controles.NSTextBox TxtPrimerPalabra;
        private Controles.NSTextBox TxtCantEspacios;
        private Controles.NSTextBox TxtCantLetras;
    }
}

