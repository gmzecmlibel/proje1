namespace Diş_Hasta_Muayene
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDoktorIslemleri = new System.Windows.Forms.Button();
            this.btnHastaKabul = new System.Windows.Forms.Button();
            this.btnMuayene = new System.Windows.Forms.Button();
            this.btnHastaIslemleri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(785, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(785, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 35;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(701, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Tarih";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(701, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Saat";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Diş_Hasta_Muayene.Properties.Resources.beyaz_disler_icin_ipuclari_1463040679_3804;
            this.pictureBox2.Location = new System.Drawing.Point(504, 205);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(484, 379);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Pink;
            this.pictureBox1.Image = global::Diş_Hasta_Muayene.Properties.Resources.dentist_treating_patient;
            this.pictureBox1.Location = new System.Drawing.Point(28, 205);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(468, 379);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // btnDoktorIslemleri
            // 
            this.btnDoktorIslemleri.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoktorIslemleri.Image = ((System.Drawing.Image)(resources.GetObject("btnDoktorIslemleri.Image")));
            this.btnDoktorIslemleri.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDoktorIslemleri.Location = new System.Drawing.Point(469, 43);
            this.btnDoktorIslemleri.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDoktorIslemleri.Name = "btnDoktorIslemleri";
            this.btnDoktorIslemleri.Size = new System.Drawing.Size(93, 69);
            this.btnDoktorIslemleri.TabIndex = 31;
            this.btnDoktorIslemleri.Text = "   Çıkış     ";
            this.btnDoktorIslemleri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDoktorIslemleri.UseVisualStyleBackColor = true;
            this.btnDoktorIslemleri.Click += new System.EventHandler(this.btnDoktorIslemleri_Click);
            // 
            // btnHastaKabul
            // 
            this.btnHastaKabul.Image = ((System.Drawing.Image)(resources.GetObject("btnHastaKabul.Image")));
            this.btnHastaKabul.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHastaKabul.Location = new System.Drawing.Point(335, 43);
            this.btnHastaKabul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHastaKabul.Name = "btnHastaKabul";
            this.btnHastaKabul.Size = new System.Drawing.Size(105, 70);
            this.btnHastaKabul.TabIndex = 30;
            this.btnHastaKabul.Text = "Hasta Kabul";
            this.btnHastaKabul.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHastaKabul.UseVisualStyleBackColor = true;
            this.btnHastaKabul.Click += new System.EventHandler(this.btnHastaKabul_Click);
            // 
            // btnMuayene
            // 
            this.btnMuayene.Image = ((System.Drawing.Image)(resources.GetObject("btnMuayene.Image")));
            this.btnMuayene.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMuayene.Location = new System.Drawing.Point(227, 42);
            this.btnMuayene.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMuayene.Name = "btnMuayene";
            this.btnMuayene.Size = new System.Drawing.Size(83, 70);
            this.btnMuayene.TabIndex = 29;
            this.btnMuayene.Text = "Muayene";
            this.btnMuayene.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMuayene.UseVisualStyleBackColor = true;
            this.btnMuayene.Visible = false;
            this.btnMuayene.Click += new System.EventHandler(this.btnMuayene_Click);
            // 
            // btnHastaIslemleri
            // 
            this.btnHastaIslemleri.Image = ((System.Drawing.Image)(resources.GetObject("btnHastaIslemleri.Image")));
            this.btnHastaIslemleri.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHastaIslemleri.Location = new System.Drawing.Point(91, 43);
            this.btnHastaIslemleri.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHastaIslemleri.Name = "btnHastaIslemleri";
            this.btnHastaIslemleri.Size = new System.Drawing.Size(109, 70);
            this.btnHastaIslemleri.TabIndex = 28;
            this.btnHastaIslemleri.Text = "Hasta İşl.";
            this.btnHastaIslemleri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHastaIslemleri.UseVisualStyleBackColor = true;
            this.btnHastaIslemleri.Click += new System.EventHandler(this.btnHastaIslemleri_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1024, 635);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDoktorIslemleri);
            this.Controls.Add(this.btnHastaKabul);
            this.Controls.Add(this.btnMuayene);
            this.Controls.Add(this.btnHastaIslemleri);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form4";
            this.Text = "Diş Hastanesi Randevu Sistemi";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDoktorIslemleri;
        private System.Windows.Forms.Button btnHastaKabul;
        private System.Windows.Forms.Button btnHastaIslemleri;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMuayene;
    }
}