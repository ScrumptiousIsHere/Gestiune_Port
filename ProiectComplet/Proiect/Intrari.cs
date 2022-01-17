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
    public partial class Intrari : Form
    {
        public Intrari()
        {
            InitializeComponent();
        }

        private void Intrare_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.OperatorIntrare' table. You can move, or remove it, as needed.
            this.operatorIntrareTableAdapter.Fill(this.dataSet1.OperatorIntrare);
            // TODO: This line of code loads data into the 'dataSet1.Nave' table. You can move, or remove it, as needed.
            this.naveTableAdapter.Fill(this.dataSet1.Nave);
            // TODO: This line of code loads data into the 'dataSet1.Intrari' table. You can move, or remove it, as needed.
            this.intrariTableAdapter.Fill(this.dataSet1.Intrari);
            A1();

        }

        private void A1()
        {
            intrariTableAdapter.Fill(dataSet1.Intrari);
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            txtIdIntrare.ReadOnly = true;
            txtIdDana.ReadOnly = false;
            A3();
        }


        private void btnActualizare_Click(object sender, EventArgs e)
        {
            A2();
        }

        private void btnConfirmare_Click(object sender, EventArgs e)
        {
            A4();
        }

        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            A3();
        }


        private void A2()
        {
            configureazaButoane(false);
            legareControale(false);
            protectiePanel(false);
            txtIdIntrare.ReadOnly = true;
            lblOp.Text = "ADAUGARE";
            txtIdDana.Focus();
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
                int ok = 0;
                if (!validareCampuriObligatorii()) return;
                adaugaInregistrare();
                golireCampuri();
                txtIdDana.Focus();
                //MessageBox.Show("pozitia:" + intrariBindingSource.Position.ToString());
                refreshGrid(intrariBindingSource.Position);
            }
            else MessageBox.Show("Operatie actualizare neefectuata");
        }

        private void A5(TextBox txtB)
        {
            decimal p;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmdadaugare = new OleDbCommand();
            OleDbDataReader r;

            if (lblOp.Text == "") return;
            if (txtB.Text == "") return;
            if (btnRenuntare.Focused) return;
            if (txtB == txtIdDana)
            {// Validare numericitate
                try { p = Convert.ToDecimal(txtB.Text); }
                catch { MessageBox.Show("Format eronat"); txtB.Focus(); }
                return;
            }
            con.ConnectionString = intrariTableAdapter.Connection.ConnectionString;
            cmdadaugare.Connection = con;
            if (lblOp.Text == "ADAUGARE")
            {
                cmdadaugare.CommandText = "Select IdIntrare From Intrari where IdIntrare='" + txtIdIntrare.Text + "'";
                con.Open();
                r = cmdadaugare.ExecuteReader();
                if (r.Read())
                {
                    MessageBox.Show("Intrarea este deja existenta !");
                    txtIdDana.Focus();
                }
                con.Close();
            }

        }

        private void configureazaButoane(bool v)
        {
            btnRenuntare.Visible = !v;
            btnConfirmare.Visible = !v;
            btnActualizare.Enabled = v;
            
        }

        private void legareControale(bool v)
        {
            if (v)
            {
                txtIdIntrare.DataBindings.Clear();
                txtIdDana.DataBindings.Clear();
                cmbDNava.DataBindings.Clear();
                txtIdIntrare.DataBindings.Add("Text", intrariBindingSource, "IdIntrare");
                txtIdDana.DataBindings.Add("Text", intrariBindingSource, "IdDana");

            }
            else
            {
                txtIdIntrare.DataBindings.Clear();
                txtIdDana.DataBindings.Clear();
                cmbDNava.DataBindings.Clear();
            }
        }


        private void protectiePanel(bool v)
        {
            txtIdIntrare.ReadOnly = v;
            txtIdDana.ReadOnly = v;
            cmbDNava.Enabled = !v;
            cmbOpIn.Enabled = !v;
            txtIdIntrare.ReadOnly = !v;

        }


        private void golireCampuri()
        {
            txtIdDana.Text = "";
            cmbDNava.SelectedIndex = 0;
            txtIdIntrare.Text = "";

        }


        private bool validareCampuriObligatorii()
        {
            //Validare de completare obligatorie campurile: Nume, CNP, Salariu, Localitate
            if (txtIdDana.Text == "")
            {
                MessageBox.Show("Completati numarul danei !");
                txtIdDana.Focus();
                return false;
            }
            if (cmbDNava.Text == "")
            {
                MessageBox.Show("Completati capacitatea !");
                cmbDNava.Focus();
                return false;
            }
            return true;
        }

        private int adaugaInregistrare()
        {
            string listaCampuri;
            string listaValori;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            con.ConnectionString = intrariTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            OleDbConnection converif = new OleDbConnection();
            OleDbCommand cmdverif = new OleDbCommand();
            OleDbDataReader r;
            converif.ConnectionString = intrariTableAdapter.Connection.ConnectionString;
            cmdverif.Connection = converif;
            int numVal = 0;
            try
            {
                numVal = int.Parse(cmbDNava.SelectedValue.ToString());
                Console.WriteLine(numVal);
            }
            catch (FormatException e) { MessageBox.Show("Eroare"); }

            cmdverif.CommandText = "SELECT SUM(Operatiune) FROM CalculSituatie WHERE IdNava = " + ((int)cmbDNava.SelectedIndex + 1) + "";
            converif.Open();
            r = cmdverif.ExecuteReader();
            if (r.Read())
            {


                if (r[0].ToString() == "0")
                {
                    listaCampuri = "IdDana, IdNava, DataIntrare, IdOpIn";
                    listaValori = "'" + txtIdDana.Text + "'" +
                    ",'" + ((int)cmbDNava.SelectedIndex + 1) + "',now(),'" + cmbOpIn.SelectedValue + "'";
                    cmd.CommandText = "Insert into Intrari(" + listaCampuri + ") " +
                    "Select " + listaValori;
                    //MessageBox.Show(cmd.CommandText);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    cmd.CommandText = "Insert into CalculSituatie(IdOperatie, IdDana, IdNava, Data, Operatiune, DOp) SELECT 2,'" + txtIdDana.Text + "'" +
                    ",'" + ((int)cmbDNava.SelectedIndex + 1) + "', now() ,1,'" + cmbOpIn.SelectedValue + "'";
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    return 1;
                }

                else if (r[0].ToString() == "1")
                {
                    MessageBox.Show("Eroare! Nava este deja in port!");
                    return 0;
                }

                else if (r[0].ToString() == "")
                {
                    OleDbConnection conn = new OleDbConnection();
                    OleDbCommand cmdn = new OleDbCommand();
                    conn.ConnectionString = intrariTableAdapter.Connection.ConnectionString;
                    cmdn.Connection = conn;
                    listaCampuri = "IdDana, IdNava, DataIntrare, IdOpIn";
                    listaValori = "'" + txtIdDana.Text + "'" +
                    ",'" + ((int)cmbDNava.SelectedIndex + 1) + "',now(),'" + cmbOpIn.SelectedValue + "'";
                    cmdn.CommandText = "Insert into Intrari(" + listaCampuri + ") " +
                    "Select " + listaValori;
                    conn.Open();
                    cmdn.ExecuteNonQuery();
                    conn.Close();
                    cmdn.CommandText = "Insert into CalculSituatie(IdOperatie, IdDana, IdNava, Data, Operatiune, DOp) SELECT 2,'" + txtIdDana.Text + "'" +
                     ",'" + ((int)cmbDNava.SelectedIndex + 1) + "',now(),1,'" + cmbOpIn.SelectedValue + "'";
                    conn.Open();
                    cmdn.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Nava a intrat in dana " + txtIdDana.Text);
                    return 1;
                }

            }
            else
            {
                MessageBox.Show("EROARE");
            }
            converif.Close();
            MessageBox.Show("EROARE");
            return 0;
        }

        private void refreshGrid(int p)
        {
            intrariBindingSource.Position = p;
            intrariTableAdapter.Fill(dataSet1.Intrari);
            
        }

        private void txtIdDana_Leave(object sender, EventArgs e)
        {
            A5(txtIdDana);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ReportIntrari f = new ReportIntrari();
            f.ShowDialog();
        }
    }
}
