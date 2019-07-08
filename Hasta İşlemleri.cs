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
using System.Configuration;

namespace Diş_Hasta_Muayene
{
    public partial class Form1 : Form
    {
      public  SqlConnection con =new SqlConnection( ConfigurationManager.ConnectionStrings["dis"].ConnectionString);
       public SqlDataAdapter da;
   public     DataSet ds;
    public    SqlCommand komut;

        
        public Form1()
        {
            InitializeComponent();

        }
        void griddoldur()
        {
            
            da = new SqlDataAdapter("Select *From hastalar", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "hastalar");
            dataGridView1.DataSource =  ds.Tables["hastalar"];
            con.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.hastalarTableAdapter.Fill(this.dişDatabaseDataSet.hastalar);
            foreach  (DataColumn kolon in dişDatabaseDataSet.hastalar.Columns)
            {
                SqlCommand cmd = new SqlCommand("",con);
                comboBox1.Items.Add(kolon.ColumnName);
            }
            comboBox1.SelectedIndex = 0;
            //griddoldur();
        }
        void KayıtSil(int numara)
        {
            
            string sql = "DELETE FROM hastalar WHERE SıraNo=@SıraNo";
            komut = new SqlCommand(sql,con);
            komut.Parameters.AddWithValue("@SıraNo", numara);
            con.Open();
            komut.ExecuteNonQuery();
            con.Close();
        }

        private void yeni_hast_ekle_Click(object sender, EventArgs e)
        {
           
           // hastalarBindingSource. Position = hastalarBindingSource. Find("SıraNo", hst.t.SıraNo);
        
        }

      

        private void hasta_sil_Click(object sender, EventArgs e)
        {
            
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void duzenle_Click(object sender, EventArgs e)
        {
          
        }

        private void barkod_olstr_Click(object sender, EventArgs e)
        {
            
            Form2 f = new Form2();
            f.veriler = dataGridView1.SelectedRows[0];
            f.Show();
            

           
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void yeni_rndvu_Click(object sender, EventArgs e)
        {
            Hasta_Ekle hst = new Hasta_Ekle();

            hst.yeni = true;
            hst.t = dişDatabaseDataSet.hastalar.NewhastalarRow();
            if (hst.ShowDialog() == DialogResult.OK)
            {
                dişDatabaseDataSet.hastalar.AddhastalarRow(hst.t);
                hastalarTableAdapter.Update(hst.t);
            }
        }

        private void duzenle_Click_1(object sender, EventArgs e)
        {
            Hasta_Ekle ekleduzeltfrm = new Hasta_Ekle();
            ekleduzeltfrm.yeni = false;
            int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            ekleduzeltfrm.t = dişDatabaseDataSet.hastalar.FindBySıraNo(id);
            if (ekleduzeltfrm.ShowDialog() == DialogResult.OK)
            {
                hastalarTableAdapter.Update(ekleduzeltfrm.t);

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form4 fr = new Form4();
            fr.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            dataGridView1.Refresh();
            griddoldur();
            MessageBox.Show("Veri Tabanından Tablolar Güncellendi...");
        }

        private void hasta_sil_Click_1(object sender, EventArgs e)
        {
            DialogResult cikis = new DialogResult();
            cikis = MessageBox.Show("Kaydı Silmek İstediğinizden Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
            if (cikis == DialogResult.Yes)
            {
                foreach (DataGridViewRow drow in dataGridView1.SelectedRows)  //Seçili Satırları Silme
                {
                    int numara = Convert.ToInt32(drow.Cells[0].Value);
                    KayıtSil(numara);
                }
                griddoldur();

            }
            else if (cikis == DialogResult.No)
            {


            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
                if (textBox1.Text == "")
                    hastalarBindingSource.Filter = "";
                else
                    hastalarBindingSource.Filter = comboBox1.SelectedItem.ToString() + "=" + textBox1.Text;
            else

                hastalarBindingSource.Filter = comboBox1.SelectedItem.ToString() + " like '" + textBox1.Text + "%'";
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
                e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)8); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
