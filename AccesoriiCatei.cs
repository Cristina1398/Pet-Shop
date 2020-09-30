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
    public partial class AccesoriiCatei : Form
    {
        public AccesoriiCatei(Meniu meniu)
        {
            InitializeComponent();
            this.meniu = meniu;
        }
        Meniu meniu;
        string denumire;
        int pret;
        private void AccesoriiCatei_FormClosing(object sender, FormClosingEventArgs e)
        {
            meniu.Show();
            this.Hide();
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            VanzareAccesorii f = new VanzareAccesorii(this,"JUCĂRII",60,meniu);
            f.Show();
            this.Hide();
        }

        private void pictureBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            VanzareAccesorii f = new VanzareAccesorii(this,"HĂINUȚĂ",80,meniu);
            f.Show();
            this.Hide();
        }

        private void pictureBox3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            VanzareAccesorii f = new VanzareAccesorii(this,"LESĂ",30,meniu);
            f.Show();
            this.Hide();
        }

        private void pictureBox4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            VanzareAccesorii f = new VanzareAccesorii(this,"PERNĂ",56,meniu);
            f.Show();
            this.Hide();
        }

        private void pictureBox5_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            VanzareAccesorii f = new VanzareAccesorii(this,"CĂSUȚĂ",230,meniu);
            f.Show();
            this.Hide();
        }

        private void pictureBox6_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            VanzareAccesorii f = new VanzareAccesorii(this,"MÂNCARE",15,meniu);
            f.Show();
            this.Hide();
        }

      

       
    }
}
