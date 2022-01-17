using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Proiect
{
    public partial class Nave : Form
    {
        public Nave()
        {
            InitializeComponent();
        }

        private void Nave_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Nave' table. You can move, or remove it, as needed.
            this.naveTableAdapter.Fill(this.dataSet1.Nave);
            protectiiTabel();
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            fAdaugare();
        }

        private void btnModificare_Click(object sender, EventArgs e)
        {
            fModificare();
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            const string msg = "Confirmati stergerea";
            const string titlu = "Stergere nava";
            var rezultat = MessageBox.Show(msg, titlu, MessageBoxButtons.YesNo,
           MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) return;
            fStergere();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ReportNave f = new ReportNave();
            f.ShowDialog();
        }

        private void btnConfirmare_Click(object sender, EventArgs e)
        {
            var tipuri = new[] { "container", "petrolier", "pasageri", "mecanic", "feribot", "barja", "trauler", "pescador" };

            if (!tipuri.Contains(txtTip.Text, StringComparer.CurrentCultureIgnoreCase))
            {
                MessageBox.Show("Va rugam sa alegeti tipul doar dintre: Container, Petrolier, Pasageri, Mecanic, Feribot, Barja, Trauler, Pescador");
                txtTip.Text = "";
            }
            else
            {
                fConfirmare();
            }

        }

        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            fRenuntare();
        }

        private void protectiiTabel()
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            txtID.ReadOnly = true;
            fRenuntare();

        }

        private void fAdaugare()
        {
            golireTb();
            configBtn(false);
            legareControale(false);
            protectiePanel(false);
            lblOp.Text = "ADAUGARE";
            txtDenumire.Focus();

        }

        private void fModificare()
        {
            configBtn(false);
            legareControale(false);
            protectiePanel(false);
            lblOp.Text = "MODIFICARE";
            txtDenumire.Focus();

        }

        private void fRenuntare()
        {
            lblOp.Text = "";
            configBtn(true);
            protectiePanel(true);
            legareControale(true);
        }

        private void fStergere()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader read;

            con.ConnectionString = naveTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;

            cmd.CommandText = "Select IdNava From CalculSituatie Where IdNava=" + txtID.Text;
            con.Open();
            read = cmd.ExecuteReader();
            if (read.Read())
            {
                MessageBox.Show("Nava este referita in tabela Calcul situatie! Aceasta nu poate fi stearsa.");
                con.Close();
                return;
            }
            con.Close();
            cmd.CommandText = "Delete From Nave Where IdNava=" + txtID.Text;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            refreshGrid(naveBindingSource.Position);
        }

        private void fConfirmare()
        {


            if (lblOp.Text == "ADAUGARE")
            {
                if (!campuriObligatorii()) return;

                addInreg();
                golireTb();

                txtDenumire.Focus();
                refreshGrid(naveBindingSource.Position);

            }

            else if (lblOp.Text == "MODIFICARE")
            {
                modifInreg();
                refreshGrid(naveBindingSource.Position);
                fRenuntare();

            }
            else
                MessageBox.Show("Operatiunea de actualizare nu s-a efectuat!");
        }

        private void configBtn(bool v)
        {
            btnRenuntare.Visible = !v;
            btnConfirmare.Visible = !v;
            btnAdaugare.Enabled = v;
            btnModificare.Enabled = v;
        }

        private void legareControale(bool v)
        {
            if (v)
            {
                txtDenumire.DataBindings.Add("Text", naveBindingSource, "DNava");
                txtTip.DataBindings.Add("Text", naveBindingSource, "TipNava");
                txtCapacitate.DataBindings.Add("Text", naveBindingSource, "Capacitate");
                txtID.DataBindings.Add("Text", naveBindingSource, "IdNava");
            }
            else
            {
                txtDenumire.DataBindings.Clear();
                txtTip.DataBindings.Clear();
                txtCapacitate.DataBindings.Clear();
                txtID.DataBindings.Clear();
            }
        }

        private void protectiePanel(bool v)
        {
            txtDenumire.ReadOnly = v;
            txtTip.ReadOnly = v;
            txtCapacitate.ReadOnly = v;

        }

        private void golireTb()
        {
            txtDenumire.Text = "";
            txtTip.Text = "";
            txtCapacitate.Text = "";
            txtID.Text = "";

        }

        private bool campuriObligatorii()
        {
            if (txtDenumire.Text == "")
            {
                MessageBox.Show("Completati denumirea navei!");
                txtDenumire.Focus();
                return false;
            }

            if (txtTip.Text == "")
            {
                MessageBox.Show("Completati tipul navei! 'Container' Ori 'Petrolier' Ori 'Pasageri' Ori 'Mecanic' Ori 'Feribot ' Ori 'Barja' Ori 'Trauler' Ori 'Pescador'");
                txtTip.Focus();
                return false;
            }

            if (txtCapacitate.Text == "")
            {
                MessageBox.Show("Completati capacitatea navei! ");
                txtCapacitate.Focus();
                return false;
            }
            return true;
        }

        private void addInreg()
        {
            string Campuri;
            string Val;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            con.ConnectionString = naveTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            Campuri = "DNava, TipNava, Capacitate";
            Val = "'" + txtDenumire.Text + "'" +
            ",'" + txtTip.Text + "'" +
            ",'" + txtCapacitate.Text + "'";

            cmd.CommandText = "Insert into Nave(" + Campuri + ") " + "Select " + Val;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void modifInreg()
        {
            string list;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            con.ConnectionString = naveTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            list = "DNava = '" + txtDenumire.Text + "'," +
            "TipNava = '" + txtTip.Text + "'," +
            "Capacitate = '" + txtCapacitate.Text + "'";

            cmd.CommandText = "Update Nave Set " + list + " Where IdNava=" +
           txtID.Text;

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void refreshGrid(int n)
        {
            naveTableAdapter.Fill(dataSet1.Nave);
            naveBindingSource.Position = n;
        }

        private void txtCapacitate_TextChanged(object sender, EventArgs e)
        {
            string text = txtCapacitate.Text;
            if (text.Trim() == "") return;
            for (int i = 0; i < text.Length; i++)
            {
                if (!char.IsNumber(text[i]))
                {
                    MessageBox.Show("Format eronat, folositi doar cifre!");
                    txtCapacitate.Text = "";
                    return;
                }

            }
        }

        private void txtDenumire_TextChanged(object sender, EventArgs e)
        {
            if (txtDenumire.Text.Trim() == "") return;
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtDenumire.Text, "^[a-zA-Z ]+"))
            {
                MessageBox.Show("Format eronat, folositi doar litere");
                txtDenumire.Text = " ";
            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Format Eronat!");
        }
    }
}
