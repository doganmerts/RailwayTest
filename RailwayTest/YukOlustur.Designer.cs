namespace RailwayTest
{
    partial class YukOlustur
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
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            radioButtonKomple = new RadioButton();
            radioButtonParsiyel = new RadioButton();
            YukDurumu = new TextBox();
            label4 = new Label();
            comboBox4 = new ComboBox();
            KonteynerNo = new Label();
            label5 = new Label();
            comboBox5 = new ComboBox();
            label6 = new Label();
            comboBox6 = new ComboBox();
            label7 = new Label();
            comboBox7 = new ComboBox();
            label8 = new Label();
            comboBox8 = new ComboBox();
            comboBox9 = new ComboBox();
            comboBox10 = new ComboBox();
            comboBox11 = new ComboBox();
            comboBox12 = new ComboBox();
            label9 = new Label();
            label10 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox13 = new ComboBox();
            label11 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "710", "711" });
            comboBox1.Location = new Point(123, 27);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(59, 23);
            comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "KLN", "SPT", "DEM" });
            comboBox2.Location = new Point(266, 27);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(59, 23);
            comboBox2.TabIndex = 2;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "01", "06", "34", "35" });
            comboBox3.Location = new Point(401, 27);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(59, 23);
            comboBox3.TabIndex = 3;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 30);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 4;
            label1.Text = "İş Tipi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(194, 30);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 5;
            label2.Text = "Opr. Grubu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(331, 30);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 6;
            label3.Text = "Şube Kodu";
            // 
            // radioButtonKomple
            // 
            radioButtonKomple.AutoSize = true;
            radioButtonKomple.Location = new Point(506, 31);
            radioButtonKomple.Name = "radioButtonKomple";
            radioButtonKomple.Size = new Size(66, 19);
            radioButtonKomple.TabIndex = 8;
            radioButtonKomple.TabStop = true;
            radioButtonKomple.Text = "Komple";
            radioButtonKomple.UseVisualStyleBackColor = true;
            radioButtonKomple.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButtonParsiyel
            // 
            radioButtonParsiyel.AutoSize = true;
            radioButtonParsiyel.Location = new Point(506, 56);
            radioButtonParsiyel.Name = "radioButtonParsiyel";
            radioButtonParsiyel.Size = new Size(65, 19);
            radioButtonParsiyel.TabIndex = 9;
            radioButtonParsiyel.TabStop = true;
            radioButtonParsiyel.Text = "Parsiyel";
            radioButtonParsiyel.UseVisualStyleBackColor = true;
            // 
            // YukDurumu
            // 
            YukDurumu.Location = new Point(830, 27);
            YukDurumu.Name = "YukDurumu";
            YukDurumu.Size = new Size(103, 23);
            YukDurumu.TabIndex = 10;
            YukDurumu.TextChanged += YukDurumu_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(750, 31);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 11;
            label4.Text = "Yük Durumu";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(133, 119);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(144, 23);
            comboBox4.TabIndex = 12;
            // 
            // KonteynerNo
            // 
            KonteynerNo.AutoSize = true;
            KonteynerNo.Location = new Point(12, 122);
            KonteynerNo.Name = "KonteynerNo";
            KonteynerNo.Size = new Size(115, 15);
            KonteynerNo.TabIndex = 13;
            KonteynerNo.Text = "Konteyner Numarası";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 183);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 15;
            label5.Text = "Müşteri";
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(133, 180);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(144, 23);
            comboBox5.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(48, 212);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 17;
            label6.Text = "Üretici";
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(133, 212);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(144, 23);
            comboBox6.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 247);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 19;
            label7.Text = "Gönderici";
            // 
            // comboBox7
            // 
            comboBox7.FormattingEnabled = true;
            comboBox7.Location = new Point(133, 244);
            comboBox7.Name = "comboBox7";
            comboBox7.Size = new Size(144, 23);
            comboBox7.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(59, 281);
            label8.Name = "label8";
            label8.Size = new Size(30, 15);
            label8.TabIndex = 21;
            label8.Text = "Alıcı";
            // 
            // comboBox8
            // 
            comboBox8.FormattingEnabled = true;
            comboBox8.Location = new Point(133, 278);
            comboBox8.Name = "comboBox8";
            comboBox8.Size = new Size(144, 23);
            comboBox8.TabIndex = 20;
            // 
            // comboBox9
            // 
            comboBox9.FormattingEnabled = true;
            comboBox9.Location = new Point(283, 180);
            comboBox9.Name = "comboBox9";
            comboBox9.Size = new Size(620, 23);
            comboBox9.TabIndex = 22;
            // 
            // comboBox10
            // 
            comboBox10.FormattingEnabled = true;
            comboBox10.Location = new Point(283, 278);
            comboBox10.Name = "comboBox10";
            comboBox10.Size = new Size(620, 23);
            comboBox10.TabIndex = 23;
            // 
            // comboBox11
            // 
            comboBox11.FormattingEnabled = true;
            comboBox11.Location = new Point(283, 244);
            comboBox11.Name = "comboBox11";
            comboBox11.Size = new Size(620, 23);
            comboBox11.TabIndex = 24;
            // 
            // comboBox12
            // 
            comboBox12.FormattingEnabled = true;
            comboBox12.Location = new Point(283, 212);
            comboBox12.Name = "comboBox12";
            comboBox12.Size = new Size(620, 23);
            comboBox12.TabIndex = 25;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 346);
            label9.Name = "label9";
            label9.Size = new Size(86, 15);
            label9.TabIndex = 26;
            label9.Text = "Türkçe Mal Adı";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 371);
            label10.Name = "label10";
            label10.Size = new Size(122, 15);
            label10.TabIndex = 27;
            label10.Text = "Yabancı Dilde Mal Adı";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(144, 338);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(103, 23);
            textBox1.TabIndex = 28;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(144, 368);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(103, 23);
            textBox2.TabIndex = 29;
            // 
            // comboBox13
            // 
            comboBox13.FormattingEnabled = true;
            comboBox13.Items.AddRange(new object[] { "CIF", "FOB" });
            comboBox13.Location = new Point(354, 338);
            comboBox13.Name = "comboBox13";
            comboBox13.Size = new Size(59, 23);
            comboBox13.TabIndex = 30;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(281, 341);
            label11.Name = "label11";
            label11.Size = new Size(67, 15);
            label11.TabIndex = 31;
            label11.Text = "Teslim Şekli";
            // 
            // YukOlustur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 627);
            Controls.Add(label11);
            Controls.Add(comboBox13);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(comboBox12);
            Controls.Add(comboBox11);
            Controls.Add(comboBox10);
            Controls.Add(comboBox9);
            Controls.Add(label8);
            Controls.Add(comboBox8);
            Controls.Add(label7);
            Controls.Add(comboBox7);
            Controls.Add(label6);
            Controls.Add(comboBox6);
            Controls.Add(label5);
            Controls.Add(comboBox5);
            Controls.Add(KonteynerNo);
            Controls.Add(comboBox4);
            Controls.Add(label4);
            Controls.Add(YukDurumu);
            Controls.Add(radioButtonParsiyel);
            Controls.Add(radioButtonKomple);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Name = "YukOlustur";
            Text = "YukOlustur";
            Load += YukOlustur_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private RadioButton radioButtonKomple;
        private RadioButton radioButtonParsiyel;
        private TextBox YukDurumu;
        private Label label4;
        private ComboBox comboBox4;
        private Label KonteynerNo;
        private Label label5;
        private ComboBox comboBox5;
        private Label label6;
        private ComboBox comboBox6;
        private Label label7;
        private ComboBox comboBox7;
        private Label label8;
        private ComboBox comboBox8;
        private ComboBox comboBox9;
        private ComboBox comboBox10;
        private ComboBox comboBox11;
        private ComboBox comboBox12;
        private Label label9;
        private Label label10;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox13;
        private Label label11;
    }
}