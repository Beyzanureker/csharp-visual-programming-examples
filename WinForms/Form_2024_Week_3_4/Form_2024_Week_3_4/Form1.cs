using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_2024_Week_3_4
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
        int krSayac=0;
        public static String Sonuclar = "Kronometre Degerleri" + System.Environment.NewLine;
        public static SaveFileDialog sfd = new SaveFileDialog();
        private void buttonBasla_Click(object sender, EventArgs e)
        {
            timerKronometre.Start();

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonDuraklat_Click(object sender, EventArgs e)
        {
            timerKronometre.Stop();

        }

        private void buttonSıfırla_Click(object sender, EventArgs e)
        {
            krSaat= 0;
            krDakika= 0;
            krSaniye= 0;
            krSalise= 0;
            krSayac = 0;

            labelSalise.Text = krSalise.ToString();
            labelSaniye.Text = krSaniye.ToString();
            labelDakika.Text = String.Format("{0:00}", krDakika);
            labelSaat.Text = String.Format("{0:00}", krSaat);
            listBoxSureler.Items.Clear();

        }

        private void timerKronometre_Tick(object sender, EventArgs e)
        {
            krSalise++;
            labelSalise.Text = krSalise.ToString();
            if(krSalise==60)
            {
                krSalise= 0;
                krSaniye++;
            }
                     
            if (krSaniye == 60)
            {
                krSaniye = 0;
                krDakika++;
            }

            if (krDakika == 60)
            {
                krDakika = 0;
                krSaat++;
            }
            labelSalise.Text = krSalise.ToString();
            labelSaniye.Text = krSaniye.ToString();
            labelDakika.Text = String.Format("{0:00}", krDakika);
            labelSaat.Text = String.Format("{0:00}", krSaat);



        }

        private void button5_Click(object sender, EventArgs e)
        {
            krSayac++;
            listBoxSureler.Items.Add(krSayac+":"+labelSaat.Text+":"+labelDakika.Text+":"+labelSaniye.Text+":"+labelSalise.Text);
             listBoxSureler.SelectedIndex=listBoxSureler.Items.Count-1;
            Sonuclar = Sonuclar + listBoxSureler.GetItemText(listBoxSureler.SelectedItem)+System.Environment.NewLine;

        }

        private void timerTarihSaat_Tick(object sender, EventArgs e)
        {
            
            labelTarih.Text = "Tarih:" + DateTime.Now.ToLongDateString();
            labelSat.Text = "Saat:" + DateTime.Now.ToLongTimeString();

            Random rnd = new Random();
            int r = rnd.Next(0, 255);
            
            int g = rnd.Next(0, 255);
            int b = rnd.Next(0, 255);
           
            labelBaslik.ForeColor = Color.FromArgb(r,g,b);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerTarihSaat.Start();

        }

        
        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            Sonuclar = Sonuclar + System.Environment.NewLine + System.DateTime.Now + System.Environment.NewLine;
            sfd.Filter = "Text File|*.txt";
            sfd.FileName= "Sonuclar";
            sfd.Title = "Sonuc Kayıt Dosyası";

            if(sfd.ShowDialog()==System.Windows.Forms.DialogResult.OK)

            {

                string path= sfd.FileName;
                StreamWriter stW = new StreamWriter(File.Create(path));
                stW.Write(Sonuclar);
                stW.Dispose();

            }
        }
    }
}
