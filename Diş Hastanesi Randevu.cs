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
    public partial class Form4 : Form
    {
        
        public Form4()
        {
            InitializeComponent();
        }

        private void btnHastaKabul_Click(object sender, EventArgs e)
        {
            Hasta_Ekle hs = new Hasta_Ekle();
            hs.Show();
            Form4 f = new Form4();
            f.Hide();
        }

        private void btnHastaIslemleri_Click(object sender, EventArgs e)
        {
          Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void btnMuayene_Click(object sender, EventArgs e)
        {
            Hasta_Ekle hst = new Hasta_Ekle();
            hst.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            label1.Text = DateTime.Now.ToShortDateString();
            label2.Text = DateTime.Now.ToShortTimeString();
        }

        private void btnDoktorIslemleri_Click(object sender, EventArgs e)
        {
            DialogResult cikis = new DialogResult();
            cikis = MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
            if (cikis == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (cikis == DialogResult.No)
            {

                
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            btnMuayene.Visible = false;
            btnHastaKabul.Visible = false;

        }
    }
}
