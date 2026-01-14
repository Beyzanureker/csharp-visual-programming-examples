namespace Form_2024_Week_2_2
{
    public partial class Form1 : Form
    {
        
        
        public Form1()
        {
            InitializeComponent();
        }


        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Color_Dialog_Select_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            color.ShowDialog();
           
            txt_Color.BackColor = color.Color;
            color.Reset();

        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
           listBox1.Items.Clear();
            progressBar1.Value = 0;
            listBox1.Items.Add(" Your Name: " + txt_Name.Text);
            listBox1.Items.Add(" Your Surname: "+ txt_Surname.Text);
           
            listBox1.Items.Add(("Your Age:   " + (DateTime.Now.Year - dateTimePicker1.Value.Year)));
            listBox1.Items.Add("Your Country:  "+cmb_Country.Text);
            if (rb_Male.Checked) listBox1.Items.Add("Your gender: "+ rb_Male.Text); else listBox1.Items.Add("Your gender: " + rb_Female.Text);
            if (chb_Y.Checked) listBox1.Items.Add("Your position: " + chb_Y.Text); else listBox1.Items.Add("Your position: "+ chb_N.Text);
             progressBar1.Value = 100;
            tabPage1.Refresh();

        }
    }
}
