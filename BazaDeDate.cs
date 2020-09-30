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
    public partial class BazaDeDate : Form
    {
        public BazaDeDate(AdaugaCaine frm)
        {
            InitializeComponent();
            this.frm = frm;
        }
        AdaugaCaine frm;

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.C1' table. You can move, or remove it, as needed.
            this.c1TableAdapter.Fill(this.database1DataSet.C1);
            // TODO: This line of code loads data into the 'database1DataSet.C1' table. You can move, or remove it, as needed.
            this.c1TableAdapter.Fill(this.database1DataSet.C1);

        }
    }
}
