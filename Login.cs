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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            osul = new OS(30, 120, DogShop.Properties.Resources.logare_program, 190, 140);
            osul2 = new OS(445, 120, DogShop.Properties.Resources.iesire_dinprogram, 190, 140);
         }
        OS osul;
        OS osul2;
        


        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            osul.Deseneaza(e.Graphics);
            osul2.Deseneaza(e.Graphics);
            
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.X > 30 && e.X < 30 + 190 && e.Y > 120 && e.Y < 120 + 140)
            {
                if (this.textBox1.Text == "Admin" && this.textBox2.Text == "caini")
                {
                    Meniu f = new Meniu(this);
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Date incorecte");
                }
            }
            if (e.X > 445 && e.X < 445 + 190 && e.Y > 120 && e.Y < 120 + 140)
            {
                DialogResult dialog = MessageBox.Show("Sigur doriți să închideți aplicația?","Atenție!",MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

    }
}
