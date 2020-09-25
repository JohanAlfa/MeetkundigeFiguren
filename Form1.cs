using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeetkundigeFiguren
{
    public partial class Form1 : Form
    {
        int straal = 0;
        int lijnDikte = 0;
        Color kleur = Color.Red;

        public Form1()
        {
            InitializeComponent();
           
        }

        private void btnTeken_Click(object sender, EventArgs e)
        {
            lblOppervlakte.Text = "Oppervlakte is ";
            lblOmtrek.Text = "Omtrek is ";
            
            Cirkel c2 = new Cirkel(this, straal, new Point(100, 100), lijnDikte, kleur);
            c2.Teken();
            
            lblOppervlakte.Text = lblOppervlakte.Text + c2.Oppervlak().ToString();
            lblOmtrek.Text = lblOmtrek.Text + c2.Omtrek().ToString();
        }

        private void txtStraal_TextChanged(object sender, EventArgs e)
        {
            straal = int.Parse(txtStraal.Text);
        }

        private void btnKleur_Click(object sender, EventArgs e)
        {
            var dialogResult = colorDialog1.ShowDialog();
            kleur = colorDialog1.Color;
        }

        private void txtLijndikte_TextChanged(object sender, EventArgs e)
        {
            lijnDikte = int.Parse( txtLijndikte.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
