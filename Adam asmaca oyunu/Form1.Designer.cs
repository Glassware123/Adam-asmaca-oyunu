namespace Adam_asmaca_oyunu
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
            this.btnYKelime = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTahminHarf = new System.Windows.Forms.TextBox();
            this.btnHarfdene = new System.Windows.Forms.Button();
            this.lblKelime = new System.Windows.Forms.Label();
            this.lbDenemeler = new System.Windows.Forms.ListBox();
            this.btnTahminEt = new System.Windows.Forms.Button();
            this.txtTahmin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbAdam = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdam)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYKelime
            // 
            this.btnYKelime.Location = new System.Drawing.Point(10, 34);
            this.btnYKelime.Name = "btnYKelime";
            this.btnYKelime.Size = new System.Drawing.Size(203, 23);
            this.btnYKelime.TabIndex = 0;
            this.btnYKelime.Text = "Yeni kelime oluştur";
            this.btnYKelime.UseVisualStyleBackColor = true;
            this.btnYKelime.Click += new System.EventHandler(this.btnYKelime_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Karakter giriniz :";
            // 
            // txtTahminHarf
            // 
            this.txtTahminHarf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTahminHarf.Location = new System.Drawing.Point(91, 6);
            this.txtTahminHarf.MaxLength = 1;
            this.txtTahminHarf.Name = "txtTahminHarf";
            this.txtTahminHarf.Size = new System.Drawing.Size(44, 21);
            this.txtTahminHarf.TabIndex = 4;
            // 
            // btnHarfdene
            // 
            this.btnHarfdene.Location = new System.Drawing.Point(138, 5);
            this.btnHarfdene.Name = "btnHarfdene";
            this.btnHarfdene.Size = new System.Drawing.Size(75, 23);
            this.btnHarfdene.TabIndex = 5;
            this.btnHarfdene.Text = "Harf dene";
            this.btnHarfdene.UseVisualStyleBackColor = true;
            this.btnHarfdene.Click += new System.EventHandler(this.btnHarfdene_Click);
            // 
            // lblKelime
            // 
            this.lblKelime.AutoSize = true;
            this.lblKelime.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKelime.Location = new System.Drawing.Point(12, 95);
            this.lblKelime.Name = "lblKelime";
            this.lblKelime.Size = new System.Drawing.Size(0, 33);
            this.lblKelime.TabIndex = 6;
            // 
            // lbDenemeler
            // 
            this.lbDenemeler.FormattingEnabled = true;
            this.lbDenemeler.Location = new System.Drawing.Point(219, 5);
            this.lbDenemeler.Name = "lbDenemeler";
            this.lbDenemeler.Size = new System.Drawing.Size(65, 108);
            this.lbDenemeler.TabIndex = 7;
            // 
            // btnTahminEt
            // 
            this.btnTahminEt.Location = new System.Drawing.Point(181, 142);
            this.btnTahminEt.Name = "btnTahminEt";
            this.btnTahminEt.Size = new System.Drawing.Size(75, 23);
            this.btnTahminEt.TabIndex = 10;
            this.btnTahminEt.Text = "Tahmin et";
            this.btnTahminEt.UseVisualStyleBackColor = true;
            this.btnTahminEt.Click += new System.EventHandler(this.btnTahminEt_Click);
            // 
            // txtTahmin
            // 
            this.txtTahmin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTahmin.Location = new System.Drawing.Point(76, 144);
            this.txtTahmin.MaxLength = 100;
            this.txtTahmin.Name = "txtTahmin";
            this.txtTahmin.Size = new System.Drawing.Size(99, 21);
            this.txtTahmin.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tahmininiz :";
            // 
            // pbAdam
            // 
            this.pbAdam.Location = new System.Drawing.Point(4, 194);
            this.pbAdam.Name = "pbAdam";
            this.pbAdam.Size = new System.Drawing.Size(274, 189);
            this.pbAdam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAdam.TabIndex = 11;
            this.pbAdam.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Puan:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(43, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 19);
            this.label4.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 395);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbAdam);
            this.Controls.Add(this.btnTahminEt);
            this.Controls.Add(this.txtTahmin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbDenemeler);
            this.Controls.Add(this.lblKelime);
            this.Controls.Add(this.btnHarfdene);
            this.Controls.Add(this.txtTahminHarf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnYKelime);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Adam Asmaca";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAdam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYKelime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTahminHarf;
        private System.Windows.Forms.Button btnHarfdene;
        private System.Windows.Forms.Label lblKelime;
        private System.Windows.Forms.ListBox lbDenemeler;
        private System.Windows.Forms.Button btnTahminEt;
        private System.Windows.Forms.TextBox txtTahmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbAdam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

