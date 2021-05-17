
namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_minimized = new System.Windows.Forms.PictureBox();
            this.bt_close = new System.Windows.Forms.PictureBox();
            this.resultado = new System.Windows.Forms.Label();
            this.btScience = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bt_dividir = new System.Windows.Forms.PictureBox();
            this.bt_multiplicar = new System.Windows.Forms.PictureBox();
            this.bt_subtracao = new System.Windows.Forms.PictureBox();
            this.bt_mais = new System.Windows.Forms.PictureBox();
            this.bt_igual = new System.Windows.Forms.PictureBox();
            this.bt_0 = new System.Windows.Forms.Button();
            this.bt_1 = new System.Windows.Forms.Button();
            this.bt_decimal = new System.Windows.Forms.Button();
            this.bt_3 = new System.Windows.Forms.Button();
            this.bt_2 = new System.Windows.Forms.Button();
            this.bt_5 = new System.Windows.Forms.Button();
            this.bt_4 = new System.Windows.Forms.Button();
            this.bt_6 = new System.Windows.Forms.Button();
            this.bt_7 = new System.Windows.Forms.Button();
            this.bt_8 = new System.Windows.Forms.Button();
            this.bt_9 = new System.Windows.Forms.Button();
            this.porcent = new System.Windows.Forms.Button();
            this.negate = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bt_minimized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_close)).BeginInit();
            this.btScience.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_dividir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_multiplicar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_subtracao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_mais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_igual)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.bt_minimized);
            this.panel1.Controls.Add(this.bt_close);
            this.panel1.Controls.Add(this.resultado);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 113);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // bt_minimized
            // 
            this.bt_minimized.Image = ((System.Drawing.Image)(resources.GetObject("bt_minimized.Image")));
            this.bt_minimized.Location = new System.Drawing.Point(12, 10);
            this.bt_minimized.Name = "bt_minimized";
            this.bt_minimized.Size = new System.Drawing.Size(19, 19);
            this.bt_minimized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bt_minimized.TabIndex = 4;
            this.bt_minimized.TabStop = false;
            this.bt_minimized.Click += new System.EventHandler(this.btminimized_Click);
            // 
            // bt_close
            // 
            this.bt_close.Image = ((System.Drawing.Image)(resources.GetObject("bt_close.Image")));
            this.bt_close.Location = new System.Drawing.Point(37, 10);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(19, 19);
            this.bt_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bt_close.TabIndex = 2;
            this.bt_close.TabStop = false;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultado.Location = new System.Drawing.Point(24, 61);
            this.resultado.MinimumSize = new System.Drawing.Size(290, 40);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(290, 40);
            this.resultado.TabIndex = 1;
            this.resultado.Text = "0";
            this.resultado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btScience
            // 
            this.btScience.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btScience.Controls.Add(this.label1);
            this.btScience.Controls.Add(this.pictureBox2);
            this.btScience.Location = new System.Drawing.Point(0, 87);
            this.btScience.Name = "btScience";
            this.btScience.Size = new System.Drawing.Size(158, 37);
            this.btScience.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Científica";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(8, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 37);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // bt_dividir
            // 
            this.bt_dividir.Image = ((System.Drawing.Image)(resources.GetObject("bt_dividir.Image")));
            this.bt_dividir.Location = new System.Drawing.Point(259, 130);
            this.bt_dividir.Name = "bt_dividir";
            this.bt_dividir.Size = new System.Drawing.Size(47, 46);
            this.bt_dividir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bt_dividir.TabIndex = 2;
            this.bt_dividir.TabStop = false;
            this.bt_dividir.Click += new System.EventHandler(this.bt_dividir_Click);
            // 
            // bt_multiplicar
            // 
            this.bt_multiplicar.Image = ((System.Drawing.Image)(resources.GetObject("bt_multiplicar.Image")));
            this.bt_multiplicar.Location = new System.Drawing.Point(259, 200);
            this.bt_multiplicar.Name = "bt_multiplicar";
            this.bt_multiplicar.Size = new System.Drawing.Size(47, 47);
            this.bt_multiplicar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bt_multiplicar.TabIndex = 3;
            this.bt_multiplicar.TabStop = false;
            this.bt_multiplicar.Click += new System.EventHandler(this.bt_multiplicar_Click);
            // 
            // bt_subtracao
            // 
            this.bt_subtracao.Image = ((System.Drawing.Image)(resources.GetObject("bt_subtracao.Image")));
            this.bt_subtracao.Location = new System.Drawing.Point(259, 274);
            this.bt_subtracao.Name = "bt_subtracao";
            this.bt_subtracao.Size = new System.Drawing.Size(47, 48);
            this.bt_subtracao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bt_subtracao.TabIndex = 4;
            this.bt_subtracao.TabStop = false;
            this.bt_subtracao.Click += new System.EventHandler(this.bt_subtracao_Click);
            // 
            // bt_mais
            // 
            this.bt_mais.Image = ((System.Drawing.Image)(resources.GetObject("bt_mais.Image")));
            this.bt_mais.Location = new System.Drawing.Point(259, 352);
            this.bt_mais.Name = "bt_mais";
            this.bt_mais.Size = new System.Drawing.Size(47, 48);
            this.bt_mais.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bt_mais.TabIndex = 5;
            this.bt_mais.TabStop = false;
            this.bt_mais.Click += new System.EventHandler(this.bt_mais_Click);
            // 
            // bt_igual
            // 
            this.bt_igual.Image = ((System.Drawing.Image)(resources.GetObject("bt_igual.Image")));
            this.bt_igual.Location = new System.Drawing.Point(258, 430);
            this.bt_igual.Name = "bt_igual";
            this.bt_igual.Size = new System.Drawing.Size(48, 48);
            this.bt_igual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bt_igual.TabIndex = 6;
            this.bt_igual.TabStop = false;
            this.bt_igual.Click += new System.EventHandler(this.bt_igual_Click);
            // 
            // bt_0
            // 
            this.bt_0.BackColor = System.Drawing.SystemColors.Control;
            this.bt_0.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_0.FlatAppearance.BorderSize = 0;
            this.bt_0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bt_0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bt_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_0.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_0.Location = new System.Drawing.Point(24, 430);
            this.bt_0.Name = "bt_0";
            this.bt_0.Size = new System.Drawing.Size(57, 48);
            this.bt_0.TabIndex = 7;
            this.bt_0.Text = "0";
            this.bt_0.UseVisualStyleBackColor = false;
            this.bt_0.Click += new System.EventHandler(this.bt_0_Click);
            // 
            // bt_1
            // 
            this.bt_1.BackColor = System.Drawing.SystemColors.Control;
            this.bt_1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_1.FlatAppearance.BorderSize = 0;
            this.bt_1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bt_1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bt_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_1.Location = new System.Drawing.Point(24, 352);
            this.bt_1.Name = "bt_1";
            this.bt_1.Size = new System.Drawing.Size(57, 48);
            this.bt_1.TabIndex = 8;
            this.bt_1.Text = "1";
            this.bt_1.UseVisualStyleBackColor = false;
            this.bt_1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt_decimal
            // 
            this.bt_decimal.BackColor = System.Drawing.SystemColors.Control;
            this.bt_decimal.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_decimal.FlatAppearance.BorderSize = 0;
            this.bt_decimal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bt_decimal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bt_decimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_decimal.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_decimal.Location = new System.Drawing.Point(176, 432);
            this.bt_decimal.Name = "bt_decimal";
            this.bt_decimal.Size = new System.Drawing.Size(57, 48);
            this.bt_decimal.TabIndex = 9;
            this.bt_decimal.Text = ".";
            this.bt_decimal.UseVisualStyleBackColor = false;
            this.bt_decimal.Click += new System.EventHandler(this.bt_decimal_Click);
            // 
            // bt_3
            // 
            this.bt_3.BackColor = System.Drawing.SystemColors.Control;
            this.bt_3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_3.FlatAppearance.BorderSize = 0;
            this.bt_3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bt_3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bt_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_3.Location = new System.Drawing.Point(176, 352);
            this.bt_3.Name = "bt_3";
            this.bt_3.Size = new System.Drawing.Size(57, 48);
            this.bt_3.TabIndex = 10;
            this.bt_3.Text = "3";
            this.bt_3.UseVisualStyleBackColor = false;
            this.bt_3.Click += new System.EventHandler(this.bt_3_Click);
            // 
            // bt_2
            // 
            this.bt_2.BackColor = System.Drawing.SystemColors.Control;
            this.bt_2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_2.FlatAppearance.BorderSize = 0;
            this.bt_2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bt_2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bt_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_2.Location = new System.Drawing.Point(98, 352);
            this.bt_2.Name = "bt_2";
            this.bt_2.Size = new System.Drawing.Size(57, 48);
            this.bt_2.TabIndex = 11;
            this.bt_2.Text = "2";
            this.bt_2.UseVisualStyleBackColor = false;
            this.bt_2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt_5
            // 
            this.bt_5.BackColor = System.Drawing.SystemColors.Control;
            this.bt_5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_5.FlatAppearance.BorderSize = 0;
            this.bt_5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bt_5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bt_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_5.Location = new System.Drawing.Point(98, 274);
            this.bt_5.Name = "bt_5";
            this.bt_5.Size = new System.Drawing.Size(57, 48);
            this.bt_5.TabIndex = 12;
            this.bt_5.Text = "5";
            this.bt_5.UseVisualStyleBackColor = false;
            this.bt_5.Click += new System.EventHandler(this.bt_5_Click);
            // 
            // bt_4
            // 
            this.bt_4.BackColor = System.Drawing.SystemColors.Control;
            this.bt_4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_4.FlatAppearance.BorderSize = 0;
            this.bt_4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bt_4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bt_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_4.Location = new System.Drawing.Point(24, 274);
            this.bt_4.Name = "bt_4";
            this.bt_4.Size = new System.Drawing.Size(57, 48);
            this.bt_4.TabIndex = 13;
            this.bt_4.Text = "4";
            this.bt_4.UseVisualStyleBackColor = false;
            this.bt_4.Click += new System.EventHandler(this.bt_4_Click);
            // 
            // bt_6
            // 
            this.bt_6.BackColor = System.Drawing.SystemColors.Control;
            this.bt_6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_6.FlatAppearance.BorderSize = 0;
            this.bt_6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bt_6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bt_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_6.Location = new System.Drawing.Point(176, 274);
            this.bt_6.Name = "bt_6";
            this.bt_6.Size = new System.Drawing.Size(57, 48);
            this.bt_6.TabIndex = 14;
            this.bt_6.Text = "6";
            this.bt_6.UseVisualStyleBackColor = false;
            this.bt_6.Click += new System.EventHandler(this.bt_6_Click);
            // 
            // bt_7
            // 
            this.bt_7.BackColor = System.Drawing.SystemColors.Control;
            this.bt_7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_7.FlatAppearance.BorderSize = 0;
            this.bt_7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bt_7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bt_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_7.Location = new System.Drawing.Point(24, 200);
            this.bt_7.Name = "bt_7";
            this.bt_7.Size = new System.Drawing.Size(57, 48);
            this.bt_7.TabIndex = 15;
            this.bt_7.Text = "7";
            this.bt_7.UseVisualStyleBackColor = false;
            this.bt_7.Click += new System.EventHandler(this.bt_7_Click);
            // 
            // bt_8
            // 
            this.bt_8.BackColor = System.Drawing.SystemColors.Control;
            this.bt_8.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_8.FlatAppearance.BorderSize = 0;
            this.bt_8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bt_8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bt_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_8.Location = new System.Drawing.Point(98, 199);
            this.bt_8.Name = "bt_8";
            this.bt_8.Size = new System.Drawing.Size(57, 48);
            this.bt_8.TabIndex = 16;
            this.bt_8.Text = "8";
            this.bt_8.UseVisualStyleBackColor = false;
            this.bt_8.Click += new System.EventHandler(this.bt_8_Click);
            // 
            // bt_9
            // 
            this.bt_9.BackColor = System.Drawing.SystemColors.Control;
            this.bt_9.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_9.FlatAppearance.BorderSize = 0;
            this.bt_9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bt_9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bt_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_9.Location = new System.Drawing.Point(176, 199);
            this.bt_9.Name = "bt_9";
            this.bt_9.Size = new System.Drawing.Size(57, 48);
            this.bt_9.TabIndex = 17;
            this.bt_9.Text = "9";
            this.bt_9.UseVisualStyleBackColor = false;
            this.bt_9.Click += new System.EventHandler(this.bt_9_Click);
            // 
            // porcent
            // 
            this.porcent.BackColor = System.Drawing.SystemColors.Control;
            this.porcent.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.porcent.FlatAppearance.BorderSize = 0;
            this.porcent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.porcent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.porcent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.porcent.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.porcent.Location = new System.Drawing.Point(176, 130);
            this.porcent.Name = "porcent";
            this.porcent.Size = new System.Drawing.Size(57, 48);
            this.porcent.TabIndex = 18;
            this.porcent.Text = "%";
            this.porcent.UseVisualStyleBackColor = false;
            // 
            // negate
            // 
            this.negate.BackColor = System.Drawing.SystemColors.Control;
            this.negate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.negate.FlatAppearance.BorderSize = 0;
            this.negate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.negate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.negate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.negate.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.negate.Location = new System.Drawing.Point(98, 130);
            this.negate.Name = "negate";
            this.negate.Size = new System.Drawing.Size(57, 48);
            this.negate.TabIndex = 19;
            this.negate.Text = "+/-";
            this.negate.UseVisualStyleBackColor = false;
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.SystemColors.Control;
            this.clear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.clear.FlatAppearance.BorderSize = 0;
            this.clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clear.Location = new System.Drawing.Point(24, 130);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(57, 48);
            this.clear.TabIndex = 20;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 492);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.negate);
            this.Controls.Add(this.porcent);
            this.Controls.Add(this.bt_9);
            this.Controls.Add(this.bt_8);
            this.Controls.Add(this.bt_7);
            this.Controls.Add(this.bt_6);
            this.Controls.Add(this.bt_4);
            this.Controls.Add(this.bt_5);
            this.Controls.Add(this.bt_2);
            this.Controls.Add(this.bt_3);
            this.Controls.Add(this.bt_decimal);
            this.Controls.Add(this.bt_1);
            this.Controls.Add(this.bt_0);
            this.Controls.Add(this.bt_igual);
            this.Controls.Add(this.bt_mais);
            this.Controls.Add(this.bt_subtracao);
            this.Controls.Add(this.bt_multiplicar);
            this.Controls.Add(this.bt_dividir);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bt_minimized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_close)).EndInit();
            this.btScience.ResumeLayout(false);
            this.btScience.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_dividir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_multiplicar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_subtracao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_mais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_igual)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel btScience;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox bt_dividir;
        private System.Windows.Forms.PictureBox bt_multiplicar;
        private System.Windows.Forms.PictureBox bt_subtracao;
        private System.Windows.Forms.PictureBox bt_mais;
        private System.Windows.Forms.PictureBox bt_igual;
        private System.Windows.Forms.Button bt_0;
        private System.Windows.Forms.Button bt_1;
        private System.Windows.Forms.Button bt_decimal;
        private System.Windows.Forms.Button bt_3;
        private System.Windows.Forms.Button bt_2;
        private System.Windows.Forms.Button bt_5;
        private System.Windows.Forms.Button bt_4;
        private System.Windows.Forms.Button bt_6;
        private System.Windows.Forms.Button bt_7;
        private System.Windows.Forms.Button bt_8;
        private System.Windows.Forms.Button bt_9;
        private System.Windows.Forms.Button porcent;
        private System.Windows.Forms.Button negate;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.PictureBox bt_minimized;
        private System.Windows.Forms.PictureBox bt_close;
    }
}

