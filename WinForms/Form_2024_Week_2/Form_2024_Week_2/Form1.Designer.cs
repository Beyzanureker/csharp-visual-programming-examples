namespace Form_2024_Week_2
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
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            Btn_WriteListbox = new Button();
            Btn_DeleteListbox = new Button();
            Btn_WriteCombobox = new Button();
            Btn_DeleteCombobox4 = new Button();
            Btn_Combobox_toListBox = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(79, 50);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(392, 29);
            textBox1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(545, 50);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(208, 29);
            comboBox1.TabIndex = 1;
            // 
            // Btn_WriteListbox
            // 
            Btn_WriteListbox.Location = new Point(103, 140);
            Btn_WriteListbox.Margin = new Padding(4);
            Btn_WriteListbox.Name = "Btn_WriteListbox";
            Btn_WriteListbox.Size = new Size(159, 50);
            Btn_WriteListbox.TabIndex = 2;
            Btn_WriteListbox.Text = "Write ListBox";
            Btn_WriteListbox.UseVisualStyleBackColor = true;
            Btn_WriteListbox.Click += Btn_WriteListbox_Click;
            // 
            // Btn_DeleteListbox
            // 
            Btn_DeleteListbox.Location = new Point(306, 140);
            Btn_DeleteListbox.Margin = new Padding(4);
            Btn_DeleteListbox.Name = "Btn_DeleteListbox";
            Btn_DeleteListbox.Size = new Size(141, 50);
            Btn_DeleteListbox.TabIndex = 3;
            Btn_DeleteListbox.Text = "Delete ListBox";
            Btn_DeleteListbox.UseVisualStyleBackColor = true;
            Btn_DeleteListbox.Click += Btn_DeleteListbox_Click;
            // 
            // Btn_WriteCombobox
            // 
            Btn_WriteCombobox.Location = new Point(103, 216);
            Btn_WriteCombobox.Margin = new Padding(4);
            Btn_WriteCombobox.Name = "Btn_WriteCombobox";
            Btn_WriteCombobox.Size = new Size(159, 50);
            Btn_WriteCombobox.TabIndex = 4;
            Btn_WriteCombobox.Text = "Write ComboBox";
            Btn_WriteCombobox.UseVisualStyleBackColor = true;
            Btn_WriteCombobox.Click += Btn_WriteCombobox_Click;
            // 
            // Btn_DeleteCombobox4
            // 
            Btn_DeleteCombobox4.Location = new Point(306, 216);
            Btn_DeleteCombobox4.Margin = new Padding(4);
            Btn_DeleteCombobox4.Name = "Btn_DeleteCombobox4";
            Btn_DeleteCombobox4.Size = new Size(141, 50);
            Btn_DeleteCombobox4.TabIndex = 5;
            Btn_DeleteCombobox4.Text = "Delete ComboBox";
            Btn_DeleteCombobox4.UseVisualStyleBackColor = true;
            Btn_DeleteCombobox4.Click += Btn_DeleteCombobox4_Click;
            // 
            // Btn_Combobox_toListBox
            // 
            Btn_Combobox_toListBox.Location = new Point(172, 284);
            Btn_Combobox_toListBox.Margin = new Padding(4);
            Btn_Combobox_toListBox.Name = "Btn_Combobox_toListBox";
            Btn_Combobox_toListBox.Size = new Size(196, 49);
            Btn_Combobox_toListBox.TabIndex = 6;
            Btn_Combobox_toListBox.Text = "ComboBox to ListBox";
            Btn_Combobox_toListBox.UseVisualStyleBackColor = true;
            Btn_Combobox_toListBox.Click += Btn_Combobox_toListBox_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(545, 140);
            listBox1.Margin = new Padding(4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(208, 193);
            listBox1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(104, 8);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 21);
            label1.TabIndex = 8;
            label1.Text = "Textbox";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(599, 10);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(94, 21);
            label2.TabIndex = 9;
            label2.Text = "ComboBox";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(600, 104);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(65, 21);
            label3.TabIndex = 10;
            label3.Text = "ListBox";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 440);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(Btn_Combobox_toListBox);
            Controls.Add(Btn_DeleteCombobox4);
            Controls.Add(Btn_WriteCombobox);
            Controls.Add(Btn_DeleteListbox);
            Controls.Add(Btn_WriteListbox);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private ComboBox comboBox1;
        private Button Btn_WriteListbox;
        private Button Btn_DeleteListbox;
        private Button Btn_WriteCombobox;
        private Button Btn_DeleteCombobox4;
        private Button Btn_Combobox_toListBox;
        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
