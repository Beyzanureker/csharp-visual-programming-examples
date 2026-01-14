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
    public partial class Form2 : Form
    {
        char _proces_type;
        bool _clear_screen;
        int  _first_number;

        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(_clear_screen == true)
            {
                label2.Text = "";
                _clear_screen = false;

            }
            if (label2.Text == "0")
                label2.Text = "";
            label2.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (_clear_screen == true)
            {
                label2.Text = "";
                _clear_screen = false;

            }
            if (label2.Text == "0")
                label2.Text = "";
            label2.Text += "2";
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (_clear_screen == true)
            {
                label2.Text = "";
                _clear_screen = false;

            }
            if (label2.Text == "0")
                label2.Text = "";
            label2.Text += "4";
        }

        private void button16_Click(object sender, EventArgs e)
        {

            _proces_type = '/';
            _clear_screen = true;
            _first_number = Convert.ToInt32(label2.Text);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int second_number = Convert.ToInt16(label2.Text);
            double result;
            switch (_proces_type)
            {
                case '+':
                    result = _first_number + second_number;
                    break;
                case '-':
                    result = _first_number - second_number;
                    break;
                case '*':
                    result = _first_number * second_number;
                    break;
                case '/':
                    result = _first_number / second_number;
                    break;
                default: result = 0;
                    break;
            }
            label2.Text = Convert.ToString(result);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            label2.Text = "o";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (_clear_screen == true)
            {
                label2.Text = "";
                _clear_screen = false;

            }
            if (label2.Text == "0")
                label2.Text = "";
            label2.Text += "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (_clear_screen == true)
            {
                label2.Text = "";
                _clear_screen = false;

            }
            if (label2.Text == "0")
                label2.Text = "";
            label2.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (_clear_screen == true)
            {
                label2.Text = "";
                _clear_screen = false;

            }
            if (label2.Text == "0")
                label2.Text = "";
            label2.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (_clear_screen == true)
            {
                label2.Text = "";
                _clear_screen = false;

            }
            if (label2.Text == "0")
                label2.Text = "";
            label2.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (_clear_screen == true)
            {
                label2.Text = "";
                _clear_screen = false;

            }
            if (label2.Text == "0")
                label2.Text = "";
            label2.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (_clear_screen == true)
            {
                label2.Text = "";
                _clear_screen = false;

            }
            if (label2.Text == "0")
                label2.Text = "";
            label2.Text += "9";
        }

        private void button14_Click(object sender, EventArgs e)
        {

            if (_clear_screen == true)
            {
                label2.Text = "";
                _clear_screen = false;

            }
            if (label2.Text == "0")
                label2.Text = "";
            label2.Text += "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            _proces_type = '+';
            _clear_screen = true;
            _first_number = Convert.ToInt32(label2.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {

            _proces_type = '-';
            _clear_screen = true;
            _first_number = Convert.ToInt32(label2.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {

            _proces_type = '*';
            _clear_screen = true;
            _first_number = Convert.ToInt32(label2.Text);
        }
    }
}
