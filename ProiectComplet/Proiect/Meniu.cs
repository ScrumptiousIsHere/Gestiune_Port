using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class Meniu : Form
    {
        public Meniu()
        {
            InitializeComponent();
        }

        private void btnOpOut_Click(object sender, EventArgs e)
        {
            OperatoriIesire opout = new OperatoriIesire();
            opout.ShowDialog();
        }

        private void btnOpIn_Click(object sender, EventArgs e)
        {
            OperatoriIntrare opin = new OperatoriIntrare();
            opin.ShowDialog();
        }

        private void btnIntrari_Click(object sender, EventArgs e)
        {
            Intrari intrare = new Intrari();
            intrare.ShowDialog();
        }

        private void btnIesiri_Click(object sender, EventArgs e)
        {
            Iesiri iesire = new Iesiri();
            iesire.ShowDialog();
        }

        private void btnNave_Click(object sender, EventArgs e)
        {
            Nave nave = new Nave();
            nave.ShowDialog();
        }

        private void btnDane_Click(object sender, EventArgs e)
        {
            Dane dane = new Dane();
            dane.ShowDialog();
        }

        private void btnSituatie_Click(object sender, EventArgs e)
        {
            Situatieport situatiegenerala = new Situatieport();
            situatiegenerala.ShowDialog();
        }
    }
}
