using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace DogShop
{
    public partial class AdaugaCaine : Form
    {
        public AdaugaCaine(Meniu frm)
        {
            InitializeComponent();
            this.frm = frm;
            pictureBox2.ImageLocation = @"Husky Siberian 1.png";
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            rat.Fill(ra);
            comboBox1.ValueMember = "Id_Caine";
            comboBox1.DisplayMember = "Rasa";
            comboBox1.DataSource = ra;
            osul7 = new OS(80, 210, DogShop.Properties.Resources.Adauga, 190, 100);
            osul8 = new OS(80, 280, DogShop.Properties.Resources.vizualizare, 190, 100);
                   
        }
        Meniu frm;
        OS osul7;
        OS osul8;
        DogShop.Database1DataSet.CainiDataTable ra = new Database1DataSet.CainiDataTable();
        DogShop.Database1DataSetTableAdapters.CainiTableAdapter rat = new Database1DataSetTableAdapters.CainiTableAdapter();
        DogShop.Database1DataSet.InformatiiDataTable tb;
        DogShop.Database1DataSetTableAdapters.InformatiiTableAdapter tba;
        private void button2_Click(object sender, EventArgs e)
        {
            BazaDeDate f = new BazaDeDate(this);
            f.Show();
            this.Hide();
        }
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm.Show();
        }
       
        private void pictureBox1_Paint_1(object sender, PaintEventArgs e)
        {
            osul7.Deseneaza(e.Graphics);
            osul8.Deseneaza(e.Graphics);
        }

        private void pictureBox1_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (e.X > 80 && e.X < 80 + 190 && e.Y > 210 && e.Y < 210 + 100)
            {
                tb = new Database1DataSet.InformatiiDataTable();
                tba = new Database1DataSetTableAdapters.InformatiiTableAdapter();
                tba.Fill(tb);
                if (this.radioButton1.Checked)
                {
                    tba.Insert((long)this.comboBox1.SelectedValue, (double)this.numericUpDown1.Value, this.textBox2.Text, this.textBox3.Text, (double)numericUpDown2.Value, (double)numericUpDown3.Value, "Femela", (int)numericUpDown5.Value, this.textBox1_imgPath.Text);
                }
                else
                {
                    tba.Insert((long)this.comboBox1.SelectedValue, (double)this.numericUpDown1.Value, this.textBox2.Text, this.textBox3.Text, (double)numericUpDown2.Value, (double)numericUpDown3.Value, "Mascul", (int)numericUpDown5.Value, this.textBox1_imgPath.Text);
                }
                MessageBox.Show("Cățel inserat");
            }
            if (e.X > 80 && e.X < 80 + 190 && e.Y > 280 && e.Y < 280 + 100)
            {
                BazaDeDate f = new BazaDeDate(this);
                f.Show();
                this.Hide();
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string PicPath = dlg.FileName.ToString();
                string a = Path.GetFileName(PicPath);
                string pt = Path.Combine(Application.StartupPath, Path.GetFileName(PicPath));
                File.Copy(PicPath,pt, true);
                pictureBox2.ImageLocation = a;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                this.textBox1_imgPath.Text = a;
            }
        }
      

       
           
    }
}
