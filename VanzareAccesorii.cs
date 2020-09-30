using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace DogShop
{
    public partial class VanzareAccesorii : Form
    {
        public VanzareAccesorii(AccesoriiCatei frm,string denumire,int pret,Meniu meniu)
        {
            InitializeComponent();
            this.frm = frm;
            this.meniu= meniu;
            this.label14.Text = denumire;
            this.label15.Text = pret.ToString();
            osul9 = new OS(650, 370, DogShop.Properties.Resources.iesire3, 130, 70);
            osul10 = new OS(640, 290, DogShop.Properties.Resources.comanda_noua, 155, 80);
            osul11 = new OS(640, 210, DogShop.Properties.Resources.trimite_comanda, 155, 80);
         }
        AccesoriiCatei frm;
        Meniu meniu;
        OS osul9;
        OS osul10;
        OS osul11;
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.X > 650 && e.X < 650 + 130 && e.Y > 370 && e.Y < 370 + 70)
            {
                meniu.Show();
                this.Hide();
            }
            if (e.X > 640 && e.X < 640 + 155 && e.Y > 290 && e.Y < 290 + 80)
            {
                frm.Show();
                this.Hide();
            }
            if (e.X > 640 && e.X < 640 + 155 && e.Y > 210 && e.Y < 210 + 80)
            {
                if (this.textBox1.Text == "" || this.textBox2.Text == "")
                {
                    MessageBox.Show("Nu ați completat toate câmpurile!");
                }
                else
                {

                    MessageBox.Show("Comanda a fost plasată cu succes!");
                }
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            osul9.Deseneaza(e.Graphics);
            osul10.Deseneaza(e.Graphics);
            osul11.Deseneaza(e.Graphics);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int a = (int.Parse(this.label15.Text) * (int)this.numericUpDown1.Value) + int.Parse(this.label8.Text);
            this.label11.Text = a.ToString();
        }
    }
}
