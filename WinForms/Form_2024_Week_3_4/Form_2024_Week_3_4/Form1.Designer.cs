namespace Form_2024_Week_3_4
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelBaslik = new System.Windows.Forms.Label();
            this.listBoxSureler = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.buttonSıfırla = new System.Windows.Forms.Button();
            this.buttonDuraklat = new System.Windows.Forms.Button();
            this.buttonBasla = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelSalise = new System.Windows.Forms.Label();
            this.labelSaniye = new System.Windows.Forms.Label();
            this.labelDakika = new System.Windows.Forms.Label();
            this.labelSaat = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelTarih = new System.Windows.Forms.Label();
            this.labelSat = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonExit = new System.Windows.Forms.Button();
            this.timerKronometre = new System.Windows.Forms.Timer(this.components);
            this.timerTarihSaat = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(643, 343);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelBaslik);
            this.tabPage2.Controls.Add(this.listBoxSureler);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.buttonKaydet);
            this.tabPage2.Controls.Add(this.buttonSıfırla);
            this.tabPage2.Controls.Add(this.buttonDuraklat);
            this.tabPage2.Controls.Add(this.buttonBasla);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.labelSalise);
            this.tabPage2.Controls.Add(this.labelSaniye);
            this.tabPage2.Controls.Add(this.labelDakika);
            this.tabPage2.Controls.Add(this.labelSaat);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(635, 317);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kronometre";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelBaslik
            // 
            this.labelBaslik.AutoSize = true;
            this.labelBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBaslik.Location = new System.Drawing.Point(21, 212);
            this.labelBaslik.Name = "labelBaslik";
            this.labelBaslik.Size = new System.Drawing.Size(262, 25);
            this.labelBaslik.TabIndex = 17;
            this.labelBaslik.Text = "Kronometre Uygulaması";
            // 
            // listBoxSureler
            // 
            this.listBoxSureler.FormattingEnabled = true;
            this.listBoxSureler.Location = new System.Drawing.Point(427, 22);
            this.listBoxSureler.Name = "listBoxSureler";
            this.listBoxSureler.Size = new System.Drawing.Size(177, 199);
            this.listBoxSureler.TabIndex = 16;
            // 
            // button5
            // 
            this.button5.ImageKey = "Icojam-Blue-Bits-Arrow-right.256.png";
            this.button5.ImageList = this.ımageList1;
            this.button5.Location = new System.Drawing.Point(347, 22);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 50);
            this.button5.TabIndex = 15;
            this.toolTip1.SetToolTip(this.button5, "Skor Al");
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Button-Play-icon.png");
            this.ımageList1.Images.SetKeyName(1, "Custom-Icon-Design-Pretty-Office-8-Stop.256.png");
            this.ımageList1.Images.SetKeyName(2, "Hopstarter-Button-Button-Pause.256.png");
            this.ımageList1.Images.SetKeyName(3, "Icojam-Blue-Bits-Arrow-right.256.png");
            this.ımageList1.Images.SetKeyName(4, "replay-icon.png");
            this.ımageList1.Images.SetKeyName(5, "Save-as-icon.png");
            this.ımageList1.Images.SetKeyName(6, "Hopstarter-Sleek-Xp-Software-Windows-Close-Program.256.png");
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.ImageKey = "Save-as-icon.png";
            this.buttonKaydet.ImageList = this.ımageList1;
            this.buttonKaydet.Location = new System.Drawing.Point(211, 118);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(50, 50);
            this.buttonKaydet.TabIndex = 14;
            this.toolTip1.SetToolTip(this.buttonKaydet, "Kaydet");
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // buttonSıfırla
            // 
            this.buttonSıfırla.ImageKey = "replay-icon.png";
            this.buttonSıfırla.ImageList = this.ımageList1;
            this.buttonSıfırla.Location = new System.Drawing.Point(142, 118);
            this.buttonSıfırla.Name = "buttonSıfırla";
            this.buttonSıfırla.Size = new System.Drawing.Size(50, 50);
            this.buttonSıfırla.TabIndex = 13;
            this.toolTip1.SetToolTip(this.buttonSıfırla, "Sıfırla");
            this.buttonSıfırla.UseVisualStyleBackColor = true;
            this.buttonSıfırla.Click += new System.EventHandler(this.buttonSıfırla_Click);
            // 
            // buttonDuraklat
            // 
            this.buttonDuraklat.ImageKey = "Custom-Icon-Design-Pretty-Office-8-Stop.256.png";
            this.buttonDuraklat.ImageList = this.ımageList1;
            this.buttonDuraklat.Location = new System.Drawing.Point(75, 118);
            this.buttonDuraklat.Name = "buttonDuraklat";
            this.buttonDuraklat.Size = new System.Drawing.Size(50, 50);
            this.buttonDuraklat.TabIndex = 12;
            this.toolTip1.SetToolTip(this.buttonDuraklat, "Duraklat");
            this.buttonDuraklat.UseVisualStyleBackColor = true;
            this.buttonDuraklat.Click += new System.EventHandler(this.buttonDuraklat_Click);
            // 
            // buttonBasla
            // 
            this.buttonBasla.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonBasla.ImageKey = "Button-Play-icon.png";
            this.buttonBasla.ImageList = this.ımageList1;
            this.buttonBasla.Location = new System.Drawing.Point(16, 118);
            this.buttonBasla.Name = "buttonBasla";
            this.buttonBasla.Size = new System.Drawing.Size(50, 50);
            this.buttonBasla.TabIndex = 11;
            this.toolTip1.SetToolTip(this.buttonBasla, "Başla");
            this.buttonBasla.UseVisualStyleBackColor = true;
            this.buttonBasla.Click += new System.EventHandler(this.buttonBasla_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(160, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 29);
            this.label7.TabIndex = 10;
            this.label7.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(100, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(46, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = ":";
            // 
            // labelSalise
            // 
            this.labelSalise.AutoSize = true;
            this.labelSalise.Location = new System.Drawing.Point(186, 68);
            this.labelSalise.Name = "labelSalise";
            this.labelSalise.Size = new System.Drawing.Size(19, 13);
            this.labelSalise.TabIndex = 7;
            this.labelSalise.Text = "00";
            // 
            // labelSaniye
            // 
            this.labelSaniye.AutoSize = true;
            this.labelSaniye.Location = new System.Drawing.Point(133, 67);
            this.labelSaniye.Name = "labelSaniye";
            this.labelSaniye.Size = new System.Drawing.Size(19, 13);
            this.labelSaniye.TabIndex = 6;
            this.labelSaniye.Text = "00";
            // 
            // labelDakika
            // 
            this.labelDakika.AutoSize = true;
            this.labelDakika.Location = new System.Drawing.Point(72, 67);
            this.labelDakika.Name = "labelDakika";
            this.labelDakika.Size = new System.Drawing.Size(19, 13);
            this.labelDakika.TabIndex = 5;
            this.labelDakika.Text = "00";
            // 
            // labelSaat
            // 
            this.labelSaat.AutoSize = true;
            this.labelSaat.Location = new System.Drawing.Point(21, 67);
            this.labelSaat.Name = "labelSaat";
            this.labelSaat.Size = new System.Drawing.Size(19, 13);
            this.labelSaat.TabIndex = 4;
            this.labelSaat.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(180, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Salise";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(124, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saniye";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(68, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dakika";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saat";
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(635, 317);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "GeriSayım";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelTarih
            // 
            this.labelTarih.AutoSize = true;
            this.labelTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTarih.Location = new System.Drawing.Point(13, 379);
            this.labelTarih.Name = "labelTarih";
            this.labelTarih.Size = new System.Drawing.Size(47, 16);
            this.labelTarih.TabIndex = 1;
            this.labelTarih.Text = "Tarih:";
            // 
            // labelSat
            // 
            this.labelSat.AutoSize = true;
            this.labelSat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSat.Location = new System.Drawing.Point(329, 376);
            this.labelSat.Name = "labelSat";
            this.labelSat.Size = new System.Drawing.Size(43, 16);
            this.labelSat.TabIndex = 2;
            this.labelSat.Text = "Saat:";
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonExit.ImageKey = "Hopstarter-Sleek-Xp-Software-Windows-Close-Program.256.png";
            this.buttonExit.ImageList = this.ımageList1;
            this.buttonExit.Location = new System.Drawing.Point(591, 360);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(50, 50);
            this.buttonExit.TabIndex = 3;
            this.toolTip1.SetToolTip(this.buttonExit, "Çıkış");
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // timerKronometre
            // 
            this.timerKronometre.Interval = 1;
            this.timerKronometre.Tick += new System.EventHandler(this.timerKronometre_Tick);
            // 
            // timerTarihSaat
            // 
            this.timerTarihSaat.Interval = 1;
            this.timerTarihSaat.Tick += new System.EventHandler(this.timerTarihSaat_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelSat);
            this.Controls.Add(this.labelTarih);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Kronometre";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelSalise;
        private System.Windows.Forms.Label labelSaniye;
        private System.Windows.Forms.Label labelDakika;
        private System.Windows.Forms.Label labelSaat;
        private System.Windows.Forms.Label labelBaslik;
        private System.Windows.Forms.ListBox listBoxSureler;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.Button buttonSıfırla;
        private System.Windows.Forms.Button buttonDuraklat;
        private System.Windows.Forms.Button buttonBasla;
        private System.Windows.Forms.Label labelTarih;
        private System.Windows.Forms.Label labelSat;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Timer timerKronometre;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Timer timerTarihSaat;
    }
}

