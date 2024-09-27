using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int giris_hakki = 3;
        int hata_oldumu;
        private void button1_Click(object sender, EventArgs e)
        {
            
            if(textBox1.Text !="enes")
            {
                hata_oldumu = 1;
                MessageBox.Show("Kullanıcı Adı Hatalı");
            }
            if (textBox3.Text !="123")
            {
                hata_oldumu = 2;
                MessageBox.Show("Şifre Hatalı");
                giris_hakki--;
            }


            if (giris_hakki > 0)
            {
                if (hata_oldumu == 0)
                {
                    MessageBox.Show("başarılı");
                }
                else
                {
                    MessageBox.Show("hatalı, Kalan giriş hakkı :" + giris_hakki);
                }

            }
            else
            {
                button1.Enabled = false;
                textBox1.Text = "";
                textBox3.Text = "";

                textBox1.Enabled = false;
                textBox3.Enabled = false;
            }






            /*
            if (textBox1.Text != "enes" && textBox3.Text == "123")
            {
                MessageBox.Show("Kullanıcı Bulunamadı");
            }
            if (textBox1.Text == "enes" && textBox3.Text != "123")
            {
                MessageBox.Show("Yanlış Şifre");
            }
            */


            /*
            if (textBox1.Text == "enes" && textBox3.Text == "123")
            {
                MessageBox.Show("Giriş Başarılı");
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }
            */
        }
    }

}
