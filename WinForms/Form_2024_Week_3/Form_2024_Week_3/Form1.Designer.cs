namespace Form_2024_Week_3
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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "1", "Nesrin", "Aydın", "0 555 560 7878", "Engineer" }, -1);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "2", "Ayşe", "Tok", "0 555 567 9898", "Teacher" }, -1);
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            btnAdd = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtID = new TextBox();
            txtName = new TextBox();
            txtSurname = new TextBox();
            txtNumber = new TextBox();
            txtJob = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listView1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            listView1.Location = new Point(48, 204);
            listView1.Name = "listView1";
            listView1.Size = new Size(604, 169);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Customer ID";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Name";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Surname";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Phone Number";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Job";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 120;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(554, 115);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(89, 39);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(35, 19);
            label1.Name = "label1";
            label1.Size = new Size(101, 21);
            label1.TabIndex = 3;
            label1.Text = "Customer ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(176, 19);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 4;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(288, 19);
            label3.Name = "label3";
            label3.Size = new Size(74, 21);
            label3.TabIndex = 5;
            label3.Text = "Surname";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(391, 19);
            label4.Name = "label4";
            label4.Size = new Size(120, 21);
            label4.TabIndex = 6;
            label4.Text = "Phone Number";
            // 
            // txtID
            // 
            txtID.Location = new Point(35, 55);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.Location = new Point(164, 55);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 9;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(279, 55);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(100, 23);
            txtSurname.TabIndex = 10;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(403, 55);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(123, 23);
            txtNumber.TabIndex = 11;
            // 
            // txtJob
            // 
            txtJob.Location = new Point(543, 55);
            txtJob.Name = "txtJob";
            txtJob.Size = new Size(100, 23);
            txtJob.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(569, 19);
            label5.Name = "label5";
            label5.Size = new Size(36, 21);
            label5.TabIndex = 13;
            label5.Text = "Job";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 404);
            Controls.Add(label5);
            Controls.Add(txtJob);
            Controls.Add(txtNumber);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Controls.Add(listView1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Button btnAdd;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtSurname;
        private TextBox txtNumber;
        private TextBox txtJob;
        private Label label5;
    }
}
