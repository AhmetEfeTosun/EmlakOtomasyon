namespace EmlakOtomasyon
{
    partial class Form2
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
            this.listBtn = new System.Windows.Forms.Button();
            this.listingGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ekleBtn = new System.Windows.Forms.Button();
            this.guncelleBtn = new System.Windows.Forms.Button();
            this.SilBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cityCmb = new System.Windows.Forms.ComboBox();
            this.districtCmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.titleTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.descriptionTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.priceTxtBox = new System.Windows.Forms.TextBox();
            this.squareMeterTxtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.filterDistrictCmb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.filterCityCmb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.minPriceNumeric = new System.Windows.Forms.NumericUpDown();
            this.maxPriceNumeric = new System.Windows.Forms.NumericUpDown();
            this.maxSquareNumeric = new System.Windows.Forms.NumericUpDown();
            this.minSquareNumeric = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listingGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minPriceNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxPriceNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxSquareNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minSquareNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // listBtn
            // 
            this.listBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBtn.Location = new System.Drawing.Point(12, 447);
            this.listBtn.Name = "listBtn";
            this.listBtn.Size = new System.Drawing.Size(463, 40);
            this.listBtn.TabIndex = 0;
            this.listBtn.Text = "Listele";
            this.listBtn.UseVisualStyleBackColor = true;
            this.listBtn.Click += new System.EventHandler(this.listBtn_Click);
            // 
            // listingGrid
            // 
            this.listingGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listingGrid.Location = new System.Drawing.Point(12, 493);
            this.listingGrid.Name = "listingGrid";
            this.listingGrid.Size = new System.Drawing.Size(926, 293);
            this.listingGrid.TabIndex = 1;
            this.listingGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listingGrid_CellClick);
            this.listingGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listingGrid_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 429);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrele";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.squareMeterTxtBox);
            this.groupBox2.Controls.Add(this.priceTxtBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.descriptionTxtBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.titleTxtBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.districtCmb);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cityCmb);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(481, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 429);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İlan Bilgileri";
            // 
            // ekleBtn
            // 
            this.ekleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekleBtn.Location = new System.Drawing.Point(481, 447);
            this.ekleBtn.Name = "ekleBtn";
            this.ekleBtn.Size = new System.Drawing.Size(139, 40);
            this.ekleBtn.TabIndex = 4;
            this.ekleBtn.Text = "Ekle";
            this.ekleBtn.UseVisualStyleBackColor = true;
            this.ekleBtn.Click += new System.EventHandler(this.ekleBtn_Click);
            // 
            // guncelleBtn
            // 
            this.guncelleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncelleBtn.Location = new System.Drawing.Point(639, 447);
            this.guncelleBtn.Name = "guncelleBtn";
            this.guncelleBtn.Size = new System.Drawing.Size(139, 40);
            this.guncelleBtn.TabIndex = 5;
            this.guncelleBtn.Text = "Güncelle";
            this.guncelleBtn.UseVisualStyleBackColor = true;
            this.guncelleBtn.Click += new System.EventHandler(this.guncelleBtn_Click);
            // 
            // SilBtn
            // 
            this.SilBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SilBtn.Location = new System.Drawing.Point(793, 447);
            this.SilBtn.Name = "SilBtn";
            this.SilBtn.Size = new System.Drawing.Size(139, 40);
            this.SilBtn.TabIndex = 6;
            this.SilBtn.Text = "Sil";
            this.SilBtn.UseVisualStyleBackColor = true;
            this.SilBtn.Click += new System.EventHandler(this.SilBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şehir";
            // 
            // cityCmb
            // 
            this.cityCmb.FormattingEnabled = true;
            this.cityCmb.Location = new System.Drawing.Point(176, 41);
            this.cityCmb.Name = "cityCmb";
            this.cityCmb.Size = new System.Drawing.Size(251, 32);
            this.cityCmb.TabIndex = 1;
            this.cityCmb.SelectedIndexChanged += new System.EventHandler(this.cityCmb_SelectedIndexChanged);
            // 
            // districtCmb
            // 
            this.districtCmb.FormattingEnabled = true;
            this.districtCmb.Location = new System.Drawing.Point(176, 79);
            this.districtCmb.Name = "districtCmb";
            this.districtCmb.Size = new System.Drawing.Size(251, 32);
            this.districtCmb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "İlçe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Başlık";
            // 
            // titleTxtBox
            // 
            this.titleTxtBox.Location = new System.Drawing.Point(176, 122);
            this.titleTxtBox.Name = "titleTxtBox";
            this.titleTxtBox.Size = new System.Drawing.Size(251, 29);
            this.titleTxtBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Açıklama";
            // 
            // descriptionTxtBox
            // 
            this.descriptionTxtBox.Location = new System.Drawing.Point(176, 164);
            this.descriptionTxtBox.Multiline = true;
            this.descriptionTxtBox.Name = "descriptionTxtBox";
            this.descriptionTxtBox.Size = new System.Drawing.Size(251, 71);
            this.descriptionTxtBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fiyat";
            // 
            // priceTxtBox
            // 
            this.priceTxtBox.Location = new System.Drawing.Point(176, 255);
            this.priceTxtBox.Name = "priceTxtBox";
            this.priceTxtBox.Size = new System.Drawing.Size(251, 29);
            this.priceTxtBox.TabIndex = 9;
            // 
            // squareMeterTxtBox
            // 
            this.squareMeterTxtBox.Location = new System.Drawing.Point(176, 290);
            this.squareMeterTxtBox.Name = "squareMeterTxtBox";
            this.squareMeterTxtBox.Size = new System.Drawing.Size(251, 29);
            this.squareMeterTxtBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Metrekare";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.filterDistrictCmb);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.filterCityCmb);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(6, 49);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(451, 112);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Konum Bilgileri";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.maxPriceNumeric);
            this.groupBox4.Controls.Add(this.minPriceNumeric);
            this.groupBox4.Location = new System.Drawing.Point(6, 172);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(451, 112);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Fiyat Aralığı";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.maxSquareNumeric);
            this.groupBox5.Controls.Add(this.minSquareNumeric);
            this.groupBox5.Location = new System.Drawing.Point(6, 295);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(451, 112);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Metrekare (m\'2)";
            // 
            // filterDistrictCmb
            // 
            this.filterDistrictCmb.FormattingEnabled = true;
            this.filterDistrictCmb.Location = new System.Drawing.Point(170, 68);
            this.filterDistrictCmb.Name = "filterDistrictCmb";
            this.filterDistrictCmb.Size = new System.Drawing.Size(251, 32);
            this.filterDistrictCmb.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "İlçe";
            // 
            // filterCityCmb
            // 
            this.filterCityCmb.FormattingEnabled = true;
            this.filterCityCmb.Location = new System.Drawing.Point(170, 30);
            this.filterCityCmb.Name = "filterCityCmb";
            this.filterCityCmb.Size = new System.Drawing.Size(251, 32);
            this.filterCityCmb.TabIndex = 5;
            this.filterCityCmb.SelectedIndexChanged += new System.EventHandler(this.filterCityCmb_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 24);
            this.label8.TabIndex = 4;
            this.label8.Text = "Şehir";
            // 
            // minPriceNumeric
            // 
            this.minPriceNumeric.Location = new System.Drawing.Point(170, 34);
            this.minPriceNumeric.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.minPriceNumeric.Name = "minPriceNumeric";
            this.minPriceNumeric.Size = new System.Drawing.Size(251, 29);
            this.minPriceNumeric.TabIndex = 0;
            // 
            // maxPriceNumeric
            // 
            this.maxPriceNumeric.Location = new System.Drawing.Point(170, 69);
            this.maxPriceNumeric.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.maxPriceNumeric.Name = "maxPriceNumeric";
            this.maxPriceNumeric.Size = new System.Drawing.Size(251, 29);
            this.maxPriceNumeric.TabIndex = 1;
            // 
            // maxSquareNumeric
            // 
            this.maxSquareNumeric.Location = new System.Drawing.Point(170, 63);
            this.maxSquareNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.maxSquareNumeric.Name = "maxSquareNumeric";
            this.maxSquareNumeric.Size = new System.Drawing.Size(251, 29);
            this.maxSquareNumeric.TabIndex = 3;
            // 
            // minSquareNumeric
            // 
            this.minSquareNumeric.Location = new System.Drawing.Point(170, 28);
            this.minSquareNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.minSquareNumeric.Name = "minSquareNumeric";
            this.minSquareNumeric.Size = new System.Drawing.Size(251, 29);
            this.minSquareNumeric.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 24);
            this.label9.TabIndex = 8;
            this.label9.Text = "Max";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 24);
            this.label10.TabIndex = 7;
            this.label10.Text = "Min";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 24);
            this.label11.TabIndex = 10;
            this.label11.Text = "Max";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 24);
            this.label12.TabIndex = 9;
            this.label12.Text = "Min";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 798);
            this.Controls.Add(this.SilBtn);
            this.Controls.Add(this.guncelleBtn);
            this.Controls.Add(this.ekleBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listingGrid);
            this.Controls.Add(this.listBtn);
            this.Name = "Form2";
            this.Text = "Emlak Otomasyonu  V1.0";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listingGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minPriceNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxPriceNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxSquareNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minSquareNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button listBtn;
        private System.Windows.Forms.DataGridView listingGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ekleBtn;
        private System.Windows.Forms.Button guncelleBtn;
        private System.Windows.Forms.Button SilBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox squareMeterTxtBox;
        private System.Windows.Forms.TextBox priceTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox descriptionTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox titleTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox districtCmb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cityCmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown maxSquareNumeric;
        private System.Windows.Forms.NumericUpDown minSquareNumeric;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown maxPriceNumeric;
        private System.Windows.Forms.NumericUpDown minPriceNumeric;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox filterDistrictCmb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox filterCityCmb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}