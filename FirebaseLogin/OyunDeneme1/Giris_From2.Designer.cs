namespace OyunDeneme1
{
    partial class Giris_From2
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
            this.Giris_button2 = new System.Windows.Forms.Button();
            this.Kayit_button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Sifre_textBox2 = new System.Windows.Forms.TextBox();
            this.Kullanici_adi_textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Giris_button2
            // 
            this.Giris_button2.Location = new System.Drawing.Point(351, 189);
            this.Giris_button2.Name = "Giris_button2";
            this.Giris_button2.Size = new System.Drawing.Size(86, 35);
            this.Giris_button2.TabIndex = 16;
            this.Giris_button2.Text = "Giriş Yap";
            this.Giris_button2.UseVisualStyleBackColor = true;
            this.Giris_button2.Click += new System.EventHandler(this.Giris_button2_Click);
            // 
            // Kayit_button1
            // 
            this.Kayit_button1.Location = new System.Drawing.Point(250, 189);
            this.Kayit_button1.Name = "Kayit_button1";
            this.Kayit_button1.Size = new System.Drawing.Size(86, 35);
            this.Kayit_button1.TabIndex = 15;
            this.Kayit_button1.Text = "Kayıt Ol";
            this.Kayit_button1.UseVisualStyleBackColor = true;
            this.Kayit_button1.Click += new System.EventHandler(this.Kayit_button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(179, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Şifre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(120, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Kullanıcı Adı:";
            // 
            // Sifre_textBox2
            // 
            this.Sifre_textBox2.Location = new System.Drawing.Point(250, 154);
            this.Sifre_textBox2.Multiline = true;
            this.Sifre_textBox2.Name = "Sifre_textBox2";
            this.Sifre_textBox2.Size = new System.Drawing.Size(187, 29);
            this.Sifre_textBox2.TabIndex = 12;
            // 
            // Kullanici_adi_textBox1
            // 
            this.Kullanici_adi_textBox1.Location = new System.Drawing.Point(250, 108);
            this.Kullanici_adi_textBox1.Multiline = true;
            this.Kullanici_adi_textBox1.Name = "Kullanici_adi_textBox1";
            this.Kullanici_adi_textBox1.Size = new System.Drawing.Size(187, 29);
            this.Kullanici_adi_textBox1.TabIndex = 11;
            // 
            // Giris_From2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 350);
            this.Controls.Add(this.Giris_button2);
            this.Controls.Add(this.Kayit_button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Sifre_textBox2);
            this.Controls.Add(this.Kullanici_adi_textBox1);
            this.Name = "Giris_From2";
            this.Text = "Giris_From2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Giris_button2;
        private System.Windows.Forms.Button Kayit_button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Sifre_textBox2;
        private System.Windows.Forms.TextBox Kullanici_adi_textBox1;
    }
}