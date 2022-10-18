namespace HAzırMetodlar
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
            this.metin1 = new System.Windows.Forms.TextBox();
            this.metin2 = new System.Windows.Forms.TextBox();
            this.calistir = new System.Windows.Forms.Button();
            this.yasakliListe = new System.Windows.Forms.ListBox();
            this.kelimeYaz = new System.Windows.Forms.TextBox();
            this.kelimeEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // metin1
            // 
            this.metin1.Location = new System.Drawing.Point(276, 13);
            this.metin1.Multiline = true;
            this.metin1.Name = "metin1";
            this.metin1.Size = new System.Drawing.Size(258, 386);
            this.metin1.TabIndex = 0;
            this.metin1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // metin2
            // 
            this.metin2.Location = new System.Drawing.Point(540, 12);
            this.metin2.Multiline = true;
            this.metin2.Name = "metin2";
            this.metin2.Size = new System.Drawing.Size(285, 386);
            this.metin2.TabIndex = 1;
            this.metin2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // calistir
            // 
            this.calistir.Location = new System.Drawing.Point(12, 404);
            this.calistir.Name = "calistir";
            this.calistir.Size = new System.Drawing.Size(813, 34);
            this.calistir.TabIndex = 2;
            this.calistir.Text = "button1";
            this.calistir.UseVisualStyleBackColor = true;
            this.calistir.Click += new System.EventHandler(this.calistir_Click);
            // 
            // yasakliListe
            // 
            this.yasakliListe.FormattingEnabled = true;
            this.yasakliListe.ItemHeight = 15;
            this.yasakliListe.Location = new System.Drawing.Point(12, 48);
            this.yasakliListe.Name = "yasakliListe";
            this.yasakliListe.Size = new System.Drawing.Size(258, 349);
            this.yasakliListe.TabIndex = 3;
            // 
            // kelimeYaz
            // 
            this.kelimeYaz.Location = new System.Drawing.Point(12, 12);
            this.kelimeYaz.Name = "kelimeYaz";
            this.kelimeYaz.Size = new System.Drawing.Size(190, 23);
            this.kelimeYaz.TabIndex = 4;
            // 
            // kelimeEkle
            // 
            this.kelimeEkle.Location = new System.Drawing.Point(208, 12);
            this.kelimeEkle.Name = "kelimeEkle";
            this.kelimeEkle.Size = new System.Drawing.Size(62, 23);
            this.kelimeEkle.TabIndex = 5;
            this.kelimeEkle.Text = "button2";
            this.kelimeEkle.UseVisualStyleBackColor = true;
            this.kelimeEkle.Click += new System.EventHandler(this.kelimeEkle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 450);
            this.Controls.Add(this.kelimeEkle);
            this.Controls.Add(this.kelimeYaz);
            this.Controls.Add(this.yasakliListe);
            this.Controls.Add(this.calistir);
            this.Controls.Add(this.metin2);
            this.Controls.Add(this.metin1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox metin1;
        private TextBox metin2;
        private Button calistir;
        private ListBox yasakliListe;
        private TextBox kelimeYaz;
        private Button kelimeEkle;
    }
}