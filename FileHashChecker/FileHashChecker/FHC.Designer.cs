namespace FileHashChecker
{
    partial class FHC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FHC));
            this.Dosya = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSec = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnMD5Copy = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnSHA1Copy = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnSHA256Copy = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.rdBtnMD5 = new System.Windows.Forms.RadioButton();
            this.rdBtnSHA1 = new System.Windows.Forms.RadioButton();
            this.rdBtnSHA256 = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnDogrula = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dosya
            // 
            this.Dosya.SupportMultiDottedExtensions = true;
            this.Dosya.Title = "FHC Dosya Seç";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hash Değeri Hesaplanacak Dosyayı Seçiniz :";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(15, 73);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(552, 26);
            this.textBox1.TabIndex = 0;
            // 
            // btnSec
            // 
            this.btnSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSec.Location = new System.Drawing.Point(577, 73);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(99, 26);
            this.btnSec.TabIndex = 1;
            this.btnSec.Text = "Dosya Seç";
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Dosya Adı ve Boyutu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(135, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tespit Edilemedi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Seçtiğiniz Dosyanın MD5 Değeri :";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(15, 247);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(552, 26);
            this.textBox2.TabIndex = 0;
            // 
            // btnMD5Copy
            // 
            this.btnMD5Copy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMD5Copy.Location = new System.Drawing.Point(577, 247);
            this.btnMD5Copy.Name = "btnMD5Copy";
            this.btnMD5Copy.Size = new System.Drawing.Size(99, 26);
            this.btnMD5Copy.TabIndex = 7;
            this.btnMD5Copy.Text = "Kopyala";
            this.btnMD5Copy.UseVisualStyleBackColor = true;
            this.btnMD5Copy.Click += new System.EventHandler(this.btnMD5Copy_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Seçtiğiniz Dosyanın SHA-1 Değeri :";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(15, 308);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(552, 26);
            this.textBox3.TabIndex = 0;
            // 
            // btnSHA1Copy
            // 
            this.btnSHA1Copy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSHA1Copy.Location = new System.Drawing.Point(577, 308);
            this.btnSHA1Copy.Name = "btnSHA1Copy";
            this.btnSHA1Copy.Size = new System.Drawing.Size(99, 26);
            this.btnSHA1Copy.TabIndex = 8;
            this.btnSHA1Copy.Text = "Kopyala";
            this.btnSHA1Copy.UseVisualStyleBackColor = true;
            this.btnSHA1Copy.Click += new System.EventHandler(this.btnSHA1Copy_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Seçtiğiniz Dosyanın SHA-256 Değeri :";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(15, 381);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(552, 26);
            this.textBox4.TabIndex = 0;
            // 
            // btnSHA256Copy
            // 
            this.btnSHA256Copy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSHA256Copy.Location = new System.Drawing.Point(577, 381);
            this.btnSHA256Copy.Name = "btnSHA256Copy";
            this.btnSHA256Copy.Size = new System.Drawing.Size(99, 26);
            this.btnSHA256Copy.TabIndex = 9;
            this.btnSHA256Copy.Text = "Kopyala";
            this.btnSHA256Copy.UseVisualStyleBackColor = true;
            this.btnSHA256Copy.Click += new System.EventHandler(this.btnSHA256Copy_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 459);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(303, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Girecek Olduğunuz Orijinal Hash Değeri Türünü Seçiniz :";
            // 
            // rdBtnMD5
            // 
            this.rdBtnMD5.AutoSize = true;
            this.rdBtnMD5.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnMD5.Location = new System.Drawing.Point(15, 478);
            this.rdBtnMD5.Name = "rdBtnMD5";
            this.rdBtnMD5.Size = new System.Drawing.Size(53, 21);
            this.rdBtnMD5.TabIndex = 2;
            this.rdBtnMD5.TabStop = true;
            this.rdBtnMD5.Text = "MD5";
            this.rdBtnMD5.UseVisualStyleBackColor = true;
            // 
            // rdBtnSHA1
            // 
            this.rdBtnSHA1.AutoSize = true;
            this.rdBtnSHA1.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnSHA1.Location = new System.Drawing.Point(105, 478);
            this.rdBtnSHA1.Name = "rdBtnSHA1";
            this.rdBtnSHA1.Size = new System.Drawing.Size(71, 21);
            this.rdBtnSHA1.TabIndex = 3;
            this.rdBtnSHA1.TabStop = true;
            this.rdBtnSHA1.Text = "SHA-1";
            this.rdBtnSHA1.UseVisualStyleBackColor = true;
            // 
            // rdBtnSHA256
            // 
            this.rdBtnSHA256.AutoSize = true;
            this.rdBtnSHA256.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnSHA256.Location = new System.Drawing.Point(220, 478);
            this.rdBtnSHA256.Name = "rdBtnSHA256";
            this.rdBtnSHA256.Size = new System.Drawing.Size(89, 21);
            this.rdBtnSHA256.TabIndex = 4;
            this.rdBtnSHA256.TabStop = true;
            this.rdBtnSHA256.Text = "SHA-256";
            this.rdBtnSHA256.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 527);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(348, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Dosyanın Seçim Yaptığınız Orijinal Hash Değerini Aşağıya Giriniz:";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(15, 546);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(552, 26);
            this.textBox5.TabIndex = 5;
            // 
            // btnDogrula
            // 
            this.btnDogrula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDogrula.Location = new System.Drawing.Point(573, 546);
            this.btnDogrula.Name = "btnDogrula";
            this.btnDogrula.Size = new System.Drawing.Size(103, 26);
            this.btnDogrula.TabIndex = 6;
            this.btnDogrula.Text = "Doğrula";
            this.btnDogrula.UseVisualStyleBackColor = true;
            this.btnDogrula.Click += new System.EventHandler(this.btnDogrula_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(182, 577);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(291, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "✓✓✓ Hash Değerleri Uyuşuyor ✓✓✓";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(202, 600);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(251, 23);
            this.label10.TabIndex = 0;
            this.label10.Text = "!!! Hash Değerleri Uyuşmuyor !!!";
            this.label10.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(77, 636);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(533, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Hash Değer Türü Seçiminizi Yaptığınızdan veya Doğru Yaptığınızdan Emin Olunuz ..." +
    "";
            this.label11.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 24);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // FHC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 663);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnMD5Copy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btnSHA1Copy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.btnSHA256Copy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rdBtnMD5);
            this.Controls.Add(this.rdBtnSHA1);
            this.Controls.Add(this.rdBtnSHA256);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.btnDogrula);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FHC";
            this.Text = "File Hash Checker";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog Dosya;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnMD5Copy;
        private System.Windows.Forms.Button btnSHA1Copy;
        private System.Windows.Forms.Button btnSHA256Copy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdBtnMD5;
        private System.Windows.Forms.RadioButton rdBtnSHA1;
        private System.Windows.Forms.RadioButton rdBtnSHA256;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btnDogrula;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

