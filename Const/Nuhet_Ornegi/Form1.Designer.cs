namespace Nuhet_Ornegi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.email = new System.Windows.Forms.TextBox();
            this.mail = new System.Windows.Forms.Label();
            this.gsm = new System.Windows.Forms.TextBox();
            this.Telefon = new System.Windows.Forms.Label();
            this.soyisim = new System.Windows.Forms.TextBox();
            this.Soyad = new System.Windows.Forms.Label();
            this.isim = new System.Windows.Forms.TextBox();
            this.Ad = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numara = new System.Windows.Forms.NumericUpDown();
            this.Ulke = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sehir = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.kayit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numara)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.mail);
            this.groupBox1.Controls.Add(this.gsm);
            this.groupBox1.Controls.Add(this.Telefon);
            this.groupBox1.Controls.Add(this.soyisim);
            this.groupBox1.Controls.Add(this.Soyad);
            this.groupBox1.Controls.Add(this.isim);
            this.groupBox1.Controls.Add(this.Ad);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 298);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kisi Bilgileri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.email.Location = new System.Drawing.Point(165, 253);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(220, 33);
            this.email.TabIndex = 7;
            // 
            // mail
            // 
            this.mail.AutoSize = true;
            this.mail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mail.Location = new System.Drawing.Point(22, 253);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(49, 25);
            this.mail.TabIndex = 6;
            this.mail.Text = "Mail";
            this.mail.Click += new System.EventHandler(this.label4_Click);
            // 
            // gsm
            // 
            this.gsm.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gsm.Location = new System.Drawing.Point(165, 179);
            this.gsm.Name = "gsm";
            this.gsm.Size = new System.Drawing.Size(220, 33);
            this.gsm.TabIndex = 5;
            // 
            // Telefon
            // 
            this.Telefon.AutoSize = true;
            this.Telefon.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Telefon.Location = new System.Drawing.Point(22, 179);
            this.Telefon.Name = "Telefon";
            this.Telefon.Size = new System.Drawing.Size(73, 25);
            this.Telefon.TabIndex = 4;
            this.Telefon.Text = "Telefon";
            this.Telefon.Click += new System.EventHandler(this.label3_Click);
            // 
            // soyisim
            // 
            this.soyisim.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.soyisim.Location = new System.Drawing.Point(165, 117);
            this.soyisim.Name = "soyisim";
            this.soyisim.Size = new System.Drawing.Size(220, 33);
            this.soyisim.TabIndex = 3;
            // 
            // Soyad
            // 
            this.Soyad.AutoSize = true;
            this.Soyad.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Soyad.Location = new System.Drawing.Point(22, 117);
            this.Soyad.Name = "Soyad";
            this.Soyad.Size = new System.Drawing.Size(65, 25);
            this.Soyad.TabIndex = 2;
            this.Soyad.Text = "SoyAd";
            this.Soyad.Click += new System.EventHandler(this.label2_Click);
            // 
            // isim
            // 
            this.isim.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.isim.Location = new System.Drawing.Point(165, 57);
            this.isim.Name = "isim";
            this.isim.Size = new System.Drawing.Size(220, 33);
            this.isim.TabIndex = 1;
            // 
            // Ad
            // 
            this.Ad.AutoSize = true;
            this.Ad.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ad.Location = new System.Drawing.Point(22, 57);
            this.Ad.Name = "Ad";
            this.Ad.Size = new System.Drawing.Size(35, 25);
            this.Ad.TabIndex = 0;
            this.Ad.Text = "Ad";
            this.Ad.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numara);
            this.groupBox2.Controls.Add(this.Ulke);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.sehir);
            this.groupBox2.Controls.Add(this.label);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(415, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 286);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kisi Bilgileri";
            // 
            // numara
            // 
            this.numara.Location = new System.Drawing.Point(94, 168);
            this.numara.Name = "numara";
            this.numara.Size = new System.Drawing.Size(120, 33);
            this.numara.TabIndex = 4;
            this.numara.ValueChanged += new System.EventHandler(this.numara_ValueChanged);
            // 
            // Ulke
            // 
            this.Ulke.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ulke.Location = new System.Drawing.Point(119, 117);
            this.Ulke.Name = "Ulke";
            this.Ulke.Size = new System.Drawing.Size(220, 33);
            this.Ulke.TabIndex = 3;
            this.Ulke.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "SoyAd";
            // 
            // sehir
            // 
            this.sehir.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sehir.Location = new System.Drawing.Point(121, 57);
            this.sehir.Name = "sehir";
            this.sehir.Size = new System.Drawing.Size(220, 33);
            this.sehir.TabIndex = 1;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label.Location = new System.Drawing.Point(22, 57);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(55, 25);
            this.label.TabIndex = 0;
            this.label.Text = "Sehir";
            this.label.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // kayit
            // 
            this.kayit.Location = new System.Drawing.Point(78, 316);
            this.kayit.Name = "kayit";
            this.kayit.Size = new System.Drawing.Size(659, 122);
            this.kayit.TabIndex = 9;
            this.kayit.Text = "Kayit";
            this.kayit.UseVisualStyleBackColor = true;
            this.kayit.Click += new System.EventHandler(this.kayit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kayit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numara)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox isim;
        private Label Ad;
        private TextBox soyisim;
        private Label Soyad;
        private TextBox gsm;
        private Label Telefon;
        private TextBox email;
        private Label mail;
        private GroupBox groupBox2;
        private TextBox Ulke;
        private Label label2;
        private TextBox sehir;
        private Label label;
        private Button kayit;
        private NumericUpDown numara;
    }
}