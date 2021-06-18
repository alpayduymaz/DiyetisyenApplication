
namespace Diyetisyen
{
    partial class HastaEkle
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
            this.txtHastaAdi = new System.Windows.Forms.TextBox();
            this.txtHastaSoyadi = new System.Windows.Forms.TextBox();
            this.btnHastaKayit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHastaTC = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.cmbDiyetTipi = new System.Windows.Forms.ComboBox();
            this.cmbHastalikAdi = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtHastaAdi
            // 
            this.txtHastaAdi.Location = new System.Drawing.Point(152, 70);
            this.txtHastaAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txtHastaAdi.Name = "txtHastaAdi";
            this.txtHastaAdi.Size = new System.Drawing.Size(110, 20);
            this.txtHastaAdi.TabIndex = 0;
            // 
            // txtHastaSoyadi
            // 
            this.txtHastaSoyadi.Location = new System.Drawing.Point(152, 110);
            this.txtHastaSoyadi.Margin = new System.Windows.Forms.Padding(2);
            this.txtHastaSoyadi.Name = "txtHastaSoyadi";
            this.txtHastaSoyadi.Size = new System.Drawing.Size(110, 20);
            this.txtHastaSoyadi.TabIndex = 1;
            // 
            // btnHastaKayit
            // 
            this.btnHastaKayit.BackColor = System.Drawing.Color.Transparent;
            this.btnHastaKayit.BackgroundImage = global::Diyetisyen.Properties.Resources.hastakayit2;
            this.btnHastaKayit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHastaKayit.Location = new System.Drawing.Point(152, 235);
            this.btnHastaKayit.Margin = new System.Windows.Forms.Padding(2);
            this.btnHastaKayit.Name = "btnHastaKayit";
            this.btnHastaKayit.Size = new System.Drawing.Size(109, 33);
            this.btnHastaKayit.TabIndex = 6;
            this.btnHastaKayit.UseVisualStyleBackColor = false;
            this.btnHastaKayit.Click += new System.EventHandler(this.btnHastaKayit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(72, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Hasta Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(46, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hasta Soyadı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(53, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Hastalık Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(77, 194);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Diyet Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(72, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Hasta TC";
            // 
            // txtHastaTC
            // 
            this.txtHastaTC.Location = new System.Drawing.Point(152, 29);
            this.txtHastaTC.Margin = new System.Windows.Forms.Padding(2);
            this.txtHastaTC.Name = "txtHastaTC";
            this.txtHastaTC.Size = new System.Drawing.Size(110, 20);
            this.txtHastaTC.TabIndex = 12;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::Diyetisyen.Properties.Resources.Go_back_icon;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.ForeColor = System.Drawing.Color.Transparent;
            this.btnBack.Location = new System.Drawing.Point(10, 6);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(32, 28);
            this.btnBack.TabIndex = 14;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cmbDiyetTipi
            // 
            this.cmbDiyetTipi.FormattingEnabled = true;
            this.cmbDiyetTipi.Items.AddRange(new object[] {
            "Akdeniz",
            "GlutenFree",
            "Deniz Ürünleri",
            "Yeşillikler Dünyası"});
            this.cmbDiyetTipi.Location = new System.Drawing.Point(153, 194);
            this.cmbDiyetTipi.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDiyetTipi.Name = "cmbDiyetTipi";
            this.cmbDiyetTipi.Size = new System.Drawing.Size(109, 21);
            this.cmbDiyetTipi.TabIndex = 15;
            this.cmbDiyetTipi.Text = "Diyet Tipi Seçiniz";
            // 
            // cmbHastalikAdi
            // 
            this.cmbHastalikAdi.FormattingEnabled = true;
            this.cmbHastalikAdi.Items.AddRange(new object[] {
            "Obez",
            "Şeker",
            "Çölyak"});
            this.cmbHastalikAdi.Location = new System.Drawing.Point(153, 152);
            this.cmbHastalikAdi.Margin = new System.Windows.Forms.Padding(2);
            this.cmbHastalikAdi.Name = "cmbHastalikAdi";
            this.cmbHastalikAdi.Size = new System.Drawing.Size(109, 21);
            this.cmbHastalikAdi.TabIndex = 16;
            this.cmbHastalikAdi.Text = "Hastalık Adı Seçiniz";
            // 
            // HastaEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Diyetisyen.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(334, 300);
            this.Controls.Add(this.cmbHastalikAdi);
            this.Controls.Add(this.cmbDiyetTipi);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHastaTC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHastaKayit);
            this.Controls.Add(this.txtHastaSoyadi);
            this.Controls.Add(this.txtHastaAdi);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HastaEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Ekleme ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHastaAdi;
        private System.Windows.Forms.TextBox txtHastaSoyadi;
        private System.Windows.Forms.Button btnHastaKayit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHastaTC;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cmbDiyetTipi;
        private System.Windows.Forms.ComboBox cmbHastalikAdi;
    }
}