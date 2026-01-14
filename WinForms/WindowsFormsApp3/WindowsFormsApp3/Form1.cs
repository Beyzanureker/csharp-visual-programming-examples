using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int krSaat = 0;
        int krDakika = 0;
        int krSaniye = 0;
        int krSalise = 0;
        int krSayac = 0;

        public static string Sonuclar = "Kronometre Degerleri" + System.Environment.NewLine;
        public static SaveFileDialog sfd = new SaveFileDialog();

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
