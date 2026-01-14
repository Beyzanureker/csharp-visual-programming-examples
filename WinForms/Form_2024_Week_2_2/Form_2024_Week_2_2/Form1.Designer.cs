namespace Form_2024_Week_2_2
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
            colorDialog1 = new ColorDialog();
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            txt_Color = new TextBox();
            chb_N = new CheckBox();
            Color_Dialog_Select = new Button();
            progressBar1 = new ProgressBar();
            chb_Y = new CheckBox();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            rb_Female = new RadioButton();
            rb_Male = new RadioButton();
            cmb_Country = new ComboBox();
            label6 = new Label();
            btn_Send = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            txt_Name = new TextBox();
            txt_Surname = new TextBox();
            tabPage2 = new TabPage();
            label8 = new Label();
            listBox1 = new ListBox();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Location = new Point(0, 12);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(558, 574);
            tabControl.TabIndex = 17;
            tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.CornflowerBlue;
            tabPage1.Controls.Add(txt_Color);
            tabPage1.Controls.Add(chb_N);
            tabPage1.Controls.Add(Color_Dialog_Select);
            tabPage1.Controls.Add(progressBar1);
            tabPage1.Controls.Add(chb_Y);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(dateTimePicker1);
            tabPage1.Controls.Add(rb_Female);
            tabPage1.Controls.Add(rb_Male);
            tabPage1.Controls.Add(cmb_Country);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(btn_Send);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txt_Name);
            tabPage1.Controls.Add(txt_Surname);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(550, 546);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Registration";
            // 
            // txt_Color
            // 
            txt_Color.Location = new Point(263, 240);
            txt_Color.Name = "txt_Color";
            txt_Color.Size = new Size(100, 23);
            txt_Color.TabIndex = 47;
            // 
            // chb_N
            // 
            chb_N.AutoSize = true;
            chb_N.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            chb_N.Location = new Point(263, 333);
            chb_N.Name = "chb_N";
            chb_N.Size = new Size(52, 25);
            chb_N.TabIndex = 46;
            chb_N.Text = "No";
            chb_N.UseVisualStyleBackColor = true;
            // 
            // Color_Dialog_Select
            // 
            Color_Dialog_Select.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Color_Dialog_Select.Location = new Point(142, 240);
            Color_Dialog_Select.Name = "Color_Dialog_Select";
            Color_Dialog_Select.Size = new Size(102, 29);
            Color_Dialog_Select.TabIndex = 45;
            Color_Dialog_Select.Text = "Select";
            Color_Dialog_Select.UseVisualStyleBackColor = true;
            Color_Dialog_Select.Click += Color_Dialog_Select_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(66, 429);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(409, 55);
            progressBar1.TabIndex = 44;
            progressBar1.Value = 10;
            // 
            // chb_Y
            // 
            chb_Y.AutoSize = true;
            chb_Y.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            chb_Y.Location = new Point(190, 332);
            chb_Y.Name = "chb_Y";
            chb_Y.Size = new Size(54, 25);
            chb_Y.TabIndex = 43;
            chb_Y.Text = "Yes";
            chb_Y.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(35, 332);
            label7.Name = "label7";
            label7.Size = new Size(142, 21);
            label7.TabIndex = 42;
            label7.Text = "Are you student ?";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(142, 153);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(186, 23);
            dateTimePicker1.TabIndex = 41;
            // 
            // rb_Female
            // 
            rb_Female.AutoSize = true;
            rb_Female.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            rb_Female.Location = new Point(233, 285);
            rb_Female.Name = "rb_Female";
            rb_Female.Size = new Size(83, 25);
            rb_Female.TabIndex = 40;
            rb_Female.TabStop = true;
            rb_Female.Text = "Female";
            rb_Female.UseVisualStyleBackColor = true;
            // 
            // rb_Male
            // 
            rb_Male.AutoSize = true;
            rb_Male.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            rb_Male.Location = new Point(142, 285);
            rb_Male.Name = "rb_Male";
            rb_Male.Size = new Size(66, 25);
            rb_Male.TabIndex = 39;
            rb_Male.TabStop = true;
            rb_Male.Text = "Male";
            rb_Male.UseVisualStyleBackColor = true;
            // 
            // cmb_Country
            // 
            cmb_Country.FormattingEnabled = true;
            cmb_Country.Items.AddRange(new object[] { "Türkiye", "Italy", "Germany", "Syria", "Irak", "Slovenya" });
            cmb_Country.Location = new Point(141, 192);
            cmb_Country.Name = "cmb_Country";
            cmb_Country.Size = new Size(186, 23);
            cmb_Country.TabIndex = 38;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(35, 287);
            label6.Name = "label6";
            label6.Size = new Size(70, 21);
            label6.TabIndex = 37;
            label6.Text = "Gender:";
            // 
            // btn_Send
            // 
            btn_Send.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_Send.Location = new Point(356, 354);
            btn_Send.Name = "btn_Send";
            btn_Send.Size = new Size(149, 45);
            btn_Send.TabIndex = 36;
            btn_Send.Text = "Send";
            btn_Send.UseVisualStyleBackColor = true;
            btn_Send.Click += btn_Send_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(35, 237);
            label5.Name = "label5";
            label5.Size = new Size(95, 21);
            label5.TabIndex = 35;
            label5.Text = "Your Color:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(35, 190);
            label4.Name = "label4";
            label4.Size = new Size(76, 21);
            label4.TabIndex = 34;
            label4.Text = "Country:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(35, 146);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 33;
            label3.Text = "Birthday:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(35, 42);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 29;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(35, 87);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 30;
            label2.Text = "Surname:";
            // 
            // txt_Name
            // 
            txt_Name.Location = new Point(145, 44);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(183, 23);
            txt_Name.TabIndex = 31;
            // 
            // txt_Surname
            // 
            txt_Surname.Location = new Point(145, 89);
            txt_Surname.Name = "txt_Surname";
            txt_Surname.Size = new Size(183, 23);
            txt_Surname.TabIndex = 32;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(listBox1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(550, 546);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Show Information";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.Location = new Point(181, 37);
            label8.Name = "label8";
            label8.Size = new Size(167, 25);
            label8.TabIndex = 1;
            label8.Text = "Your Information";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(72, 79);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(417, 244);
            listBox1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 586);
            Controls.Add(tabControl);
            Name = "Form1";
            Text = "Form1";
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ColorDialog colorDialog1;
        private TabControl tabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ProgressBar progressBar1;
        private CheckBox chb_Y;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private RadioButton rb_Female;
        private RadioButton rb_Male;
        private ComboBox cmb_Country;
        private Label label6;
        private Button btn_Send;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private TextBox txt_Name;
        private TextBox txt_Surname;
        private Label label8;
        private ListBox listBox1;
        private Button Color_Dialog_Select;
        private CheckBox chb_N;
        private TextBox txt_Color;
    }
}
