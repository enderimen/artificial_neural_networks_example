﻿namespace artificial_neural_networks
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
            this.parametre_sayisi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.alt_sinir = new System.Windows.Forms.NumericUpDown();
            this.ust_sinir = new System.Windows.Forms.NumericUpDown();
            this.toplama_fonk = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.aktivasyon_fonk = new System.Windows.Forms.ComboBox();
            this.hesapla_buton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.alt_sinir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ust_sinir)).BeginInit();
            this.SuspendLayout();
            // 
            // parametre_sayisi
            // 
            this.parametre_sayisi.Location = new System.Drawing.Point(31, 43);
            this.parametre_sayisi.Name = "parametre_sayisi";
            this.parametre_sayisi.Size = new System.Drawing.Size(108, 20);
            this.parametre_sayisi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bağımsız Değiş. Sayısı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alt Sınır";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Üst Sınır";
            // 
            // alt_sinir
            // 
            this.alt_sinir.Location = new System.Drawing.Point(84, 84);
            this.alt_sinir.Name = "alt_sinir";
            this.alt_sinir.Size = new System.Drawing.Size(55, 20);
            this.alt_sinir.TabIndex = 1;
            // 
            // ust_sinir
            // 
            this.ust_sinir.Location = new System.Drawing.Point(84, 110);
            this.ust_sinir.Name = "ust_sinir";
            this.ust_sinir.Size = new System.Drawing.Size(55, 20);
            this.ust_sinir.TabIndex = 2;
            // 
            // toplama_fonk
            // 
            this.toplama_fonk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toplama_fonk.FormattingEnabled = true;
            this.toplama_fonk.Items.AddRange(new object[] {
            "∑",
            "Π"});
            this.toplama_fonk.Location = new System.Drawing.Point(238, 43);
            this.toplama_fonk.Name = "toplama_fonk";
            this.toplama_fonk.Size = new System.Drawing.Size(121, 21);
            this.toplama_fonk.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Toplama Fonk. Seçiniz";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Aktivasyon Fonk. Seçiniz";
            // 
            // aktivasyon_fonk
            // 
            this.aktivasyon_fonk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aktivasyon_fonk.FormattingEnabled = true;
            this.aktivasyon_fonk.Items.AddRange(new object[] {
            "Sigmoid",
            "Hyperbolic"});
            this.aktivasyon_fonk.Location = new System.Drawing.Point(238, 110);
            this.aktivasyon_fonk.Name = "aktivasyon_fonk";
            this.aktivasyon_fonk.Size = new System.Drawing.Size(121, 21);
            this.aktivasyon_fonk.TabIndex = 4;
            // 
            // hesapla_buton
            // 
            this.hesapla_buton.Location = new System.Drawing.Point(372, 298);
            this.hesapla_buton.Name = "hesapla_buton";
            this.hesapla_buton.Size = new System.Drawing.Size(123, 40);
            this.hesapla_buton.TabIndex = 5;
            this.hesapla_buton.Text = "Hesapla";
            this.hesapla_buton.UseVisualStyleBackColor = true;
            this.hesapla_buton.Click += new System.EventHandler(this.hesapla_buton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(31, 165);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(64, 173);
            this.listBox1.TabIndex = 6;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(94, 165);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(122, 173);
            this.listBox2.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(235, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Toplama fonk. sonucu: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(235, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Aktivasyon fonk. sonucu:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Parametreler";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(93, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Ağırlık Değerleri";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 40);
            this.button1.TabIndex = 11;
            this.button1.Text = "Temizle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 350);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.hesapla_buton);
            this.Controls.Add(this.aktivasyon_fonk);
            this.Controls.Add(this.toplama_fonk);
            this.Controls.Add(this.ust_sinir);
            this.Controls.Add(this.alt_sinir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.parametre_sayisi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Artificial Neural Networks Dataset Processing";
            ((System.ComponentModel.ISupportInitialize)(this.alt_sinir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ust_sinir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox parametre_sayisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown alt_sinir;
        private System.Windows.Forms.NumericUpDown ust_sinir;
        private System.Windows.Forms.ComboBox toplama_fonk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox aktivasyon_fonk;
        private System.Windows.Forms.Button hesapla_buton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
    }
}

