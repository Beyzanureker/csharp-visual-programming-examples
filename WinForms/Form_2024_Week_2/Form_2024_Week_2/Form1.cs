namespace Form_2024_Week_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Combobox and Listbox Application";
            this.BackColor = Color.White;
        }

        private void Btn_WriteListbox_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void Btn_DeleteListbox_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);

        }

        private void Btn_WriteCombobox_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);
        }

        private void Btn_DeleteCombobox4_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Remove(comboBox1.SelectedItem);
        }

        private void Btn_Combobox_toListBox_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox1.Text);   
            
        }
    }
}
