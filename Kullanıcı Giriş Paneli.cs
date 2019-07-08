using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diş_Hasta_Muayene
{
    public partial class Form3 : Form
    {
     public Form1 frm=new Form1();
        public Form3()
        {
            InitializeComponent();
        }
        public bool kadi, parola;
        public void kullaniciParolaKontrol()//kayıtların sayısını bulduruyoruz.
        {
            kadi = false; parola = false;
            frm.con.Open();
           
            SqlDataReader oku;
           string sorgu= "Select *from KullaniciBilgi";
           frm.komut = new SqlCommand(sorgu,frm.con);
            oku = frm.komut.ExecuteReader();
           
            while (oku.Read())
            {
                if (textBox1.Text.Trim() == oku[0].ToString().Trim() && textBox2.Text.Trim() == oku[1].ToString().Trim())
                {
                    kadi = true;
                    parola = true;
                }

            }
            frm.con.Close();
            oku.Dispose();
        }
        private void btnGiris_Click(object sender, EventArgs e)
        {
            kullaniciParolaKontrol();
            if (kadi == true && parola == true)
            {
                Form4 fr = new Form4();
                fr.Show();
                this.Hide();
            }
            else MessageBox.Show("Kullanici Adı Veya Parola Hatalı");

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
