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
    public partial class Dane : Form
    {
        public Dane()
        {
            InitializeComponent();
        }

        private void Dane_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Dane1' table. You can move, or remove it, as needed.
            this.dane1TableAdapter.Fill(this.dataSet1.Dane1);
            // TODO: This line of code loads data into the 'dataSet1.Dane' table. You can move, or remove it, as needed.
            this.daneTableAdapter.Fill(this.dataSet1.Dane);
            A1();
        }

        private void btnActualizare_Click(object sender, EventArgs e)
        {
            A2();
        }

        private void btnModificare_Click(object sender, EventArgs e)
        {
            A7();
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) return;
            A8();
        }

        private void btnConfirmare_Click(object sender, EventArgs e)
        {
            A4();
        }

        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            A3();
        }

        private void A1()
        {
            dane1TableAdapter.Fill(dataSet1.Dane1);
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            txtIdDana.ReadOnly = true;
            A3();
        }

        private void A2()
        {
            configureazaButoane(false);
            legareControale(false);
            protectiePanel(false);
            txtIdDana.ReadOnly = true;
            lblOp.Text = "ADAUGARE";
            txtTipDana.Focus();
            golireCampuri();
        }

        private void A3()
        {
            lblOp.Text = "";
            configureazaButoane(true);
            protectiePanel(true);
            legareControale(true);
        }

        private void A4()
        {
            if (lblOp.Text == "ADAUGARE")
            {
                if (!validareCampuriObligatorii()) return;
                adaugaInregistrare();
                golireCampuri();
                txtTipDana.Focus();
                refreshGrid(dane1BindingSource.Position);
            }
            else if (lblOp.Text == "MODIFICARE")
            {
                if (!validareCampuriObligatorii()) return;
                modificaInregistrare();
                refreshGrid(dane1BindingSource.Position);
                A3();
            }
            else MessageBox.Show("Operatie actualizare neefectuata");
        }

        private void A5(TextBox txtB)
        {
            decimal p;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmdadaugare = new OleDbCommand();
            OleDbCommand cmdmodificare = new OleDbCommand();
            OleDbDataReader r;

            if (lblOp.Text == "") return;
            if (txtB.Text == "") return;
            if (btnRenuntare.Focused) return;
            if (txtB == txtCapacitate)
            {// Validare numericitate
                try { p = Convert.ToDecimal(txtB.Text); }
                catch { MessageBox.Show("Format eronat"); txtB.Focus(); }
                return;
            }
            con.ConnectionString = dane1TableAdapter.Connection.ConnectionString;
            cmdadaugare.Connection = con;
            cmdmodificare.Connection = con;
            if (lblOp.Text == "ADAUGARE")
            {
                cmdadaugare.CommandText = "Select IdDana From Dane where IdDana='" + txtIdDana.Text + "'";
                con.Open();
                r = cmdadaugare.ExecuteReader();
                if (r.Read())
                {
                    MessageBox.Show("Dana este deja existenta !");
                    txtIdDana.Focus();
                }
                con.Close();
            }

        }


        private void A7()
        {
            configureazaButoane(false);
            legareControale(false);
            protectiePanel(false);
            txtIdDana.ReadOnly = true;
            lblOp.Text = "MODIFICARE";
            txtIdDana.Focus();
        }

        private void A8()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader r;
            con.ConnectionString = dane1TableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            cmd.CommandText = "Select IdOperatie From CalculSituatie where IdDana=" + txtIdDana.Text; con.Open();
            r = cmd.ExecuteReader();
            if (r.Read())
            {
                MessageBox.Show("Dana este referita in tabela CalculSituatie nu se poate sterge!");
                con.Close();
                return;
            }
            con.Close();
            con.ConnectionString = dane1TableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            cmd.CommandText = "Delete From Dane Where IdDana = " + txtIdDana.Text; MessageBox.Show(cmd.CommandText);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            refreshGrid(dane1BindingSource.Position);
        }


        private void configureazaButoane(bool v)
        {
            btnRenuntare.Visible = !v;
            btnConfirmare.Visible = !v;
            btnActualizare.Enabled = v;
            btnModificare.Enabled = v;
            btnStergere.Enabled = v;
        }

        private void legareControale(bool v)
        {
            if (v)
            {
                txtTipDana.DataBindings.Clear();
                txtCapacitate.DataBindings.Clear();
                txtIdDana.DataBindings.Clear();
                txtTipDana.DataBindings.Add("Text", dane1BindingSource, "TipDana");
                txtCapacitate.DataBindings.Add("Text", dane1BindingSource, "Capacitate");
                txtIdDana.DataBindings.Add("Text", dane1BindingSource, "IdDana");
            }
            else
            {
                txtTipDana.DataBindings.Clear();
                txtCapacitate.DataBindings.Clear();
                txtIdDana.DataBindings.Clear();
            }
        }


        private void protectiePanel(bool v)
        {
            txtTipDana.ReadOnly = v;
            txtCapacitate.ReadOnly = v;
            txtIdDana.ReadOnly = v;
        }


        private void golireCampuri()
        {
            txtTipDana.Text = "";
            txtCapacitate.Text = "";
            txtIdDana.Text = "";
        }


        private bool validareCampuriObligatorii()
        {
            //Validare de completare obligatorie campurile: Nume, CNP, Salariu, Localitate
            if (txtTipDana.Text == "")
            {
                MessageBox.Show("Completati tipul de dana !");
                txtTipDana.Focus();
                return false;
            }
            if (txtCapacitate.Text == "")
            {
                MessageBox.Show("Completati capacitatea !");
                txtCapacitate.Focus();
                return false;
            }
            return true;
        }

        private void adaugaInregistrare()
        {
            string listaCampuri;
            string listaValori;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            con.ConnectionString = dane1TableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            listaCampuri = "TipDana, Capacitate";
            listaValori = "'" + txtTipDana.Text + "'" +
            ",'" + txtCapacitate.Text + "'";
            cmd.CommandText = "Insert into Dane(" + listaCampuri + ") " +
            "Select " + listaValori;
            MessageBox.Show(cmd.CommandText);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void refreshGrid(int p)
        {
            dane1TableAdapter.Fill(dataSet1.Dane1);
            dane1BindingSource.Position = p;
        }


        private void modificaInregistrare()
        {
            string listaSet;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            con.ConnectionString = dane1TableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            listaSet = "TipDana = '" + txtTipDana.Text + "'," +
            "Capacitate = '" + txtCapacitate.Text + "'";
            cmd.CommandText = "Update Dane Set " + listaSet + " Where IdDana=" +
            txtIdDana.Text;
            MessageBox.Show(cmd.CommandText);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
