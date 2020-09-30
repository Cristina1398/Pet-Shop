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
    public partial class Meniu : Form
    {
        public Meniu(Login frm)
        {
            InitializeComponent();
            osul3 = new OS(40, 95, DogShop.Properties.Resources.vizuliazare_caini, 160, 60);
            osul4 = new OS(40, 175, DogShop.Properties.Resources.accesorii_caine, 160, 60);
            osul5 = new OS(40, 15, DogShop.Properties.Resources.adauga_caine, 160, 60);
            osul6 = new OS(pictureBox1.Width - 120, 5, DogShop.Properties.Resources.iesire_dinprogram, 120, 60);
        }
        OS osul3;
        OS osul4;
        OS osul5;
        OS osul6;
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            osul3.Deseneaza(e.Graphics);
            osul4.Deseneaza(e.Graphics);
            osul5.Deseneaza(e.Graphics);
            osul6.Deseneaza(e.Graphics);
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.X > 40 && e.X < 40 + 160 && e.Y > 95 && e.Y < 95 + 60)
            {
                VizualizareCaini f = new VizualizareCaini(this);
                f.Show();
                this.Hide();
            }
            if (e.X > 40 && e.X < 40 + 160 && e.Y > 175 && e.Y < 175 + 60)
            {
                AccesoriiCatei f = new AccesoriiCatei(this);
                f.Show();
                this.Hide();

            }
            if (e.X > 40 && e.X < 40 + 160 && e.Y > 15 && e.Y < 15 + 60)
            {
                AdaugaCaine f = new AdaugaCaine(this);
                f.Show();
                this.Hide();
            }
            if (e.X > pictureBox1.Width - 120 && e.X < pictureBox1.Width - 120 + 160 && e.Y > 5 && e.Y < 5 + 60)
            {
                Application.Exit();
            }
                   

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

