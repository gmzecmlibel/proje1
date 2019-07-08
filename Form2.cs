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
    public partial class Form2 : Form
    {
        Form1 f = new Form1();
        public DataGridViewRow veriler { get; set; }

           public Form2()
        {
            InitializeComponent();
        }
        public int SatirSayisi = 0;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs ffff)
        {
           
            try
            {
                Font myFont = new Font("Calibri", 7); 
                SolidBrush sbrush = new SolidBrush(Color.Black);
                Pen myPen = new Pen(Color.Black); 

                                ffff.Graphics.DrawLine(myPen, 50, 45, 800, 45);  

                myFont = new Font("Calibri", 15, FontStyle.Bold);
                ffff.Graphics.DrawString("Randevu Bilgileri", myFont, sbrush, 350, 65);
                ffff.Graphics.DrawLine(myPen, 50, 95, 770, 95); 

                myFont = new Font("Calibri", 10, FontStyle.Bold); 
                ffff.Graphics.DrawString("Sıra No : "+veriler.Cells[0].Value.ToString(), myFont, sbrush, 140, 170); 
                ffff.Graphics.DrawString("Adı : " +veriler.Cells[1].Value.ToString(),myFont, sbrush, 140, 210); 
                ffff.Graphics.DrawString("Soyadı : "+veriler.Cells[2].Value.ToString(),myFont, sbrush, 140, 250);
                ffff.Graphics.DrawString("Tck-No : " + veriler.Cells[3].Value.ToString(), myFont, sbrush, 140, 290);
                ffff.Graphics.DrawString("Randevu-Tarihi : " + veriler.Cells[4].Value.ToString(), myFont, sbrush, 140, 330);
                ffff.Graphics.DrawString("Bölüm : " + veriler.Cells[5].Value.ToString(), myFont, sbrush, 140, 370);
                ffff.Graphics.DrawString(" Doktor : " + veriler.Cells[6].Value.ToString(), myFont, sbrush, 140, 410);
                ffff.Graphics.DrawString("Telefon : " + veriler.Cells[7].Value.ToString(), myFont, sbrush, 140, 450);
                ffff.Graphics.DrawString("E-Posta : " + veriler.Cells[8].Value.ToString(), myFont, sbrush, 140, 490);
                ffff.Graphics.DrawLine(myPen, 50, 125, 770, 125); 

                int y = 150; 

                myFont = new Font("Calibri", 10); 

                int i = 0;

              while (f.dataGridView1.SelectedRows.Count>0)
                {
                    
                  
                    y += 20; 
                    i += 1;
                    
                    if (y > 1000)
                    {
                        ffff.Graphics.DrawString("(Devamı -->)", myFont, sbrush, 700, y + 50);
                        y = 50;
                        break; 
                    }
                }
                if (i < SatirSayisi)
                {
                    ffff.HasMorePages = true;
                }
                else
                {
                    ffff.HasMorePages = false;
                    i = 0;
                }
                StringFormat myStringFormat = new StringFormat();
                myStringFormat.Alignment = StringAlignment.Far; 
            } 
                 
        
    
            catch
            {
            }



        }

        private void Form2_Load(object sender, EventArgs e)
        {

            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

    }
}
