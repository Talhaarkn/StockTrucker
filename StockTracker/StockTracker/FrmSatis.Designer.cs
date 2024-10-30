namespace StockTracker
{
    partial class FrmSatis
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
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtTelefon = new TextBox();
            txtAdSoyad = new TextBox();
            txtTc = new TextBox();
            groupBox2 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtToplamFiyat = new TextBox();
            txtSatisFiyati = new TextBox();
            txtMiktar = new TextBox();
            txtÜrünAdi = new TextBox();
            txtBarkodNo = new TextBox();
            panel1 = new Panel();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            btnEkle = new Button();
            btnSil = new Button();
            btnSatisIptal = new Button();
            btnSatisYap = new Button();
            label9 = new Label();
            GenelToplam = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(358, 135);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(769, 354);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtTelefon);
            groupBox1.Controls.Add(txtAdSoyad);
            groupBox1.Controls.Add(txtTc);
            groupBox1.Location = new Point(73, 135);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(251, 112);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Müşteri İşlemleri";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 88);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 5;
            label3.Text = "Telefon";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 59);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 4;
            label2.Text = "Ad Soyad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 30);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 3;
            label1.Text = "TC";
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(126, 80);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(100, 23);
            txtTelefon.TabIndex = 2;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(126, 51);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(100, 23);
            txtAdSoyad.TabIndex = 1;
            // 
            // txtTc
            // 
            txtTc.Location = new Point(126, 22);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(100, 23);
            txtTc.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtToplamFiyat);
            groupBox2.Controls.Add(txtSatisFiyati);
            groupBox2.Controls.Add(txtMiktar);
            groupBox2.Controls.Add(txtÜrünAdi);
            groupBox2.Controls.Add(txtBarkodNo);
            groupBox2.Location = new Point(73, 253);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(251, 236);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ürün İşlemleri";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 207);
            label8.Name = "label8";
            label8.Size = new Size(74, 15);
            label8.TabIndex = 10;
            label8.Text = "Toplam Fiyat";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 170);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 9;
            label7.Text = "Satış Fiyatı";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 131);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 8;
            label6.Text = "Miktarı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 93);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 7;
            label5.Text = "Ürün Adı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 51);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 6;
            label4.Text = "BarkodNo";
            // 
            // txtToplamFiyat
            // 
            txtToplamFiyat.Location = new Point(126, 199);
            txtToplamFiyat.Name = "txtToplamFiyat";
            txtToplamFiyat.Size = new Size(100, 23);
            txtToplamFiyat.TabIndex = 5;
            // 
            // txtSatisFiyati
            // 
            txtSatisFiyati.Location = new Point(126, 162);
            txtSatisFiyati.Name = "txtSatisFiyati";
            txtSatisFiyati.Size = new Size(100, 23);
            txtSatisFiyati.TabIndex = 4;
            // 
            // txtMiktar
            // 
            txtMiktar.Location = new Point(126, 123);
            txtMiktar.Name = "txtMiktar";
            txtMiktar.Size = new Size(100, 23);
            txtMiktar.TabIndex = 3;
            // 
            // txtÜrünAdi
            // 
            txtÜrünAdi.Location = new Point(126, 85);
            txtÜrünAdi.Name = "txtÜrünAdi";
            txtÜrünAdi.Size = new Size(100, 23);
            txtÜrünAdi.TabIndex = 2;
            // 
            // txtBarkodNo
            // 
            txtBarkodNo.Location = new Point(126, 43);
            txtBarkodNo.Name = "txtBarkodNo";
            txtBarkodNo.Size = new Size(100, 23);
            txtBarkodNo.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button9);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1335, 100);
            panel1.TabIndex = 3;
            // 
            // button5
            // 
            button5.Location = new Point(73, 25);
            button5.Name = "button5";
            button5.Size = new Size(214, 56);
            button5.TabIndex = 4;
            button5.Text = "Müşteri Ekleme";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(293, 25);
            button6.Name = "button6";
            button6.Size = new Size(191, 56);
            button6.TabIndex = 5;
            button6.Text = "Müşteri Listeleme";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(597, 25);
            button7.Name = "button7";
            button7.Size = new Size(183, 56);
            button7.TabIndex = 6;
            button7.Text = "Ürün Ekleme";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(786, 25);
            button8.Name = "button8";
            button8.Size = new Size(174, 56);
            button8.TabIndex = 7;
            button8.Text = "Ürün Listleme";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(1052, 25);
            button9.Name = "button9";
            button9.Size = new Size(175, 56);
            button9.TabIndex = 8;
            button9.Text = "Satışları Listeleme";
            button9.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(358, 495);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(118, 46);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(1133, 135);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(119, 45);
            btnSil.TabIndex = 1;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            // 
            // btnSatisIptal
            // 
            btnSatisIptal.Location = new Point(1133, 202);
            btnSatisIptal.Name = "btnSatisIptal";
            btnSatisIptal.Size = new Size(119, 45);
            btnSatisIptal.TabIndex = 2;
            btnSatisIptal.Text = "Satış İptal";
            btnSatisIptal.UseVisualStyleBackColor = true;
            // 
            // btnSatisYap
            // 
            btnSatisYap.Location = new Point(1004, 495);
            btnSatisYap.Name = "btnSatisYap";
            btnSatisYap.Size = new Size(123, 46);
            btnSatisYap.TabIndex = 3;
            btnSatisYap.Text = "Satış Yap";
            btnSatisYap.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(651, 511);
            label9.Name = "label9";
            label9.Size = new Size(79, 15);
            label9.TabIndex = 4;
            label9.Text = "Genel Toplam";
            // 
            // GenelToplam
            // 
            GenelToplam.AutoSize = true;
            GenelToplam.Location = new Point(736, 511);
            GenelToplam.Name = "GenelToplam";
            GenelToplam.Size = new Size(0, 15);
            GenelToplam.TabIndex = 5;
            // 
            // FrmSatis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(1335, 586);
            Controls.Add(GenelToplam);
            Controls.Add(label9);
            Controls.Add(btnSil);
            Controls.Add(btnSatisIptal);
            Controls.Add(btnSatisYap);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnEkle);
            Controls.Add(dataGridView1);
            Name = "FrmSatis";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StockTracker";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtTelefon;
        private TextBox txtAdSoyad;
        private TextBox txtTc;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtToplamFiyat;
        private TextBox txtSatisFiyati;
        private TextBox txtMiktar;
        private TextBox txtÜrünAdi;
        private TextBox txtBarkodNo;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Panel panel1;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button btnEkle;
        private Button btnSil;
        private Button btnSatisIptal;
        private Button btnSatisYap;
        private Label label9;
        private Label GenelToplam;
    }
}
