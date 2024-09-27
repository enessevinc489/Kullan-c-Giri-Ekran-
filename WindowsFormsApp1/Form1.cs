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

        private void button1_Click(object sender, EventArgs e)
        {
            int hata_oldumu;
            if(textBox1.Text !="enes")
            {
                hata_oldumu = 1;
                label1.Visible = true;
                MessageBox.Show("Kullanıcı Adı Hatalı");
            }
            if (textBox3.Text !="123")
            {
                hata_oldumu = 2;
                label1.Visible = true;
                MessageBox.Show("Şifre Hatalı");
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
