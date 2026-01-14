using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string user_name = "Beyza";
        int password = 123;
        int counter = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (user_name == textBox1.Text && password == Convert.ToInt16(textBox2.Text))
            {
                MessageBox.Show("Congratulations! Username and password are correct.", "Sign In Panel", MessageBoxButtons.OK);

                this.Hide();

                Form2 form = new Form2();
                form.Show();
            }
            else
            {
                counter++;
                MessageBox.Show("Username or password is wrong...", "Sign In Panel", MessageBoxButtons.OK, MessageBoxIcon.Error);

                textBox1.Clear();
                textBox2.Clear();

                if (counter == 3)
                {
                    MessageBox.Show("You entered the wrong password 3 times.", "Sign In Panel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
       
     }
    
}
