using System.Drawing;

namespace Form_2024_Week_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int iterator;
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string Id, name, surname, p_number, job;
            Id = txtID.Text;
            name = txtName.Text;
            surname = txtSurname.Text;
            p_number = txtNumber.Text;
            job = txtJob.Text;

            string[] colum = {Id, name, surname, p_number, job};

            ListViewItem records = new ListViewItem(colum);

            listView1.Items.Add(records);

            }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string Id, name, surname, p_number, job;
            Id = txtID.Text;
            name = txtName.Text;
            surname = txtSurname.Text;
            p_number = txtNumber.Text;
            job = txtJob.Text;
            string[] colum = { Id, name, surname, p_number, job };
            ListViewItem records = new ListViewItem(colum);





        }
    }
}
