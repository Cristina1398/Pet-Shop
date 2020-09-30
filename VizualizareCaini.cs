using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogShop
{
    public partial class VizualizareCaini : Form
    {
        public VizualizareCaini(Meniu frm)
        {
            InitializeComponent();
            this.frm = frm;
            tb = new Database1DataSet.C1DataTable();
            DogShop.Database1DataSetTableAdapters.C1TableAdapter tba = new Database1DataSetTableAdapters.C1TableAdapter();
            tba.Fill(tb);
            index = 0;
            Vizualizare();
         }
        Meniu frm;
        int index;
         DogShop.Database1DataSet.C1DataTable tb;
        private void Vizualizare()
        {
            this.textBox1.Text = tb.Rows[index]["Rasa"].ToString();
            this.textBox2.Text = tb.Rows[index]["Pret"].ToString();
            this.textBox3.Text = tb.Rows[index]["Origine"].ToString();
            this.textBox4.Text = tb.Rows[index]["Culoare"].ToString();
            this.textBox5.Text = tb.Rows[index]["Greutate(kg)"].ToString();
            this.textBox6.Text = tb.Rows[index]["Inaltime(cm)"].ToString();
            this.textBox7.Text = tb.Rows[index]["Sex"].ToString();
            this.textBox8.Text = tb.Rows[index]["Varsta(luni)"].ToString();
            this.pictureBox1.ImageLocation = tb.Rows[index]["Imagine"].ToString();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            index = 0;
            Vizualizare();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            index = tb.Rows.Count - 1;
            Vizualizare();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (index >= 1) index--;
            Vizualizare();
                  
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (index < tb.Rows.Count - 1) index++;
            Vizualizare();
        }
    }
}
