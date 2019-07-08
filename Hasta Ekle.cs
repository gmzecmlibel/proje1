using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diş_Hasta_Muayene
{
    public partial class Hasta_Ekle : Form
    {
        public bool yeni;
      public  DişDatabaseDataSet.hastalarRow t;
        public Hasta_Ekle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            src_to_db();
            this.DialogResult = DialogResult.OK; 
        }
        
        Form4 f = new Form4();
        private void Hasta_Ekle_Load(object sender, EventArgs e)
        {
            if (yeni)
                bosalt();
            else
            { db_to_src(); }
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            
        }
     
        private void db_to_src()
        {
           
            textBox1.Text = t.Ad;
            textBox2.Text = t.Soyad;
            textBox3.Text = t.TckNo;
            dateTimePicker1.Value = t.RandevuTarihi;
            comboBox1.SelectedItem = t.BolumAdi;
            comboBox2.SelectedItem = t.Doktor_Adi;
            textBox4.Text = t.Telefon;
            textBox5.Text = t.Eposta;
            
        }
        

        private void bosalt()
        {
         
          
        
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox1.SelectedItem = "";
            comboBox2.SelectedItem = "";
        }
       
       private void src_to_db()
        {

            t.Ad = textBox1.Text;
            t.Soyad = textBox2.Text;
            t.TckNo = textBox3.Text;
            t.RandevuTarihi = dateTimePicker1.Value;
            t.BolumAdi = comboBox1.SelectedItem.ToString();
            t.Doktor_Adi = comboBox2.SelectedItem.ToString();
            t.Telefon = textBox4.Text;
            t.Eposta = textBox5.Text;
           
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar);
            if (textBox3.TextLength == 11)
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar);
            if (textBox4.TextLength == 10)
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            MessageBox.Show("Kayıttan Vazgeçildi..");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || comboBox1.SelectedIndex == 0 || comboBox2.SelectedIndex == 0)
                MessageBox.Show("lütfen boş alan bırakmayın..");
            else
            {
                src_to_db();
                this.DialogResult = DialogResult.OK;
               
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsNumber(e.KeyChar);
         
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsNumber(e.KeyChar);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 fr = new Form4();
            fr.Show();
            this.Hide();
        }
    }
}
