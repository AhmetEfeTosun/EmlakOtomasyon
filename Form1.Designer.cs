namespace EmlakOtomasyon
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.emlakLabel = new System.Windows.Forms.Label();
            this.girisYapBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emlakLabel
            // 
            this.emlakLabel.AutoSize = true;
            this.emlakLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.emlakLabel.Location = new System.Drawing.Point(213, 116);
            this.emlakLabel.Name = "emlakLabel";
            this.emlakLabel.Size = new System.Drawing.Size(462, 46);
            this.emlakLabel.TabIndex = 0;
            this.emlakLabel.Text = "Emlak Otomasyonu V1.0";
            // 
            // girisYapBtn
            // 
            this.girisYapBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisYapBtn.Location = new System.Drawing.Point(301, 216);
            this.girisYapBtn.Name = "girisYapBtn";
            this.girisYapBtn.Size = new System.Drawing.Size(274, 106);
            this.girisYapBtn.TabIndex = 1;
            this.girisYapBtn.Text = "Giriş Yap";
            this.girisYapBtn.UseVisualStyleBackColor = true;
            this.girisYapBtn.Click += new System.EventHandler(this.girisYapBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 519);
            this.Controls.Add(this.girisYapBtn);
            this.Controls.Add(this.emlakLabel);
            this.Name = "Form1";
            this.Text = "Emlak Otomasyonu V1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label emlakLabel;
        private System.Windows.Forms.Button girisYapBtn;
    }
}

