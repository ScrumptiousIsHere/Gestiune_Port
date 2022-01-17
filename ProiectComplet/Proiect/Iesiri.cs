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
    public partial class Iesiri : Form
    {
        public Iesiri()
        {
            InitializeComponent();
        }

        private void Iesiri_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.OperatorIesire' table. You can move, or remove it, as needed.
            this.operatorIesireTableAdapter.Fill(this.dataSet1.OperatorIesire);
            // TODO: This line of code loads data into the 'dataSet1.Nave' table. You can move, or remove it, as needed.
            this.naveTableAdapter.Fill(this.dataSet1.Nave);
            // TODO: This line of code loads data into the 'dataSet1.Iesiri' table. You can move, or remove it, as needed.
            this.iesiriTableAdapter.Fill(this.dataSet1.Iesiri);
            // TODO: This line of code loads data into the 'dataSet1.Iesiri' table. You can move, or remove it, as needed.
            this.iesiriTableAdapter.Fill(this.dataSet1.Iesiri);
            protectiiTabel();
            
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            fAdaugare();
        }

        private void BtnConfirmare_Click(object sender, EventArgs e)
        {
            fConfirmare();
        }

        private void btnAnulare_Click(object sender, EventArgs e)
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
            

        }


        private void fRenuntare()
        {
            lblOp.Text = "";
            configBtn(true);
            protectiePanel(true);
            legareControale(true);
            cmbNave.Text = "";
        }

        

        private void fConfirmare()
        {


            if (lblOp.Text == "ADAUGARE")
            {
                if (!campuriObligatorii()) return;

                addInreg();
                golireTb();

                cmbNave.Focus();
                refreshGrid(iesiriBindingSource.Position);

            }

            else
                MessageBox.Show("Operatiunea de actualizare nu s-a efectuat!");
        }

        private void configBtn(bool v)
        {
            btnRenuntare.Visible = !v;
            btnConfirmare.Visible = !v;
            btnAdaugare.Enabled = v;
            
        }

        private void legareControale(bool v)
        {
            if (v)
            {
               // cmbNave.DataBindings.Add("Value", iesiriBindingSource, "DNava");
                txtDane.DataBindings.Add("Text", iesiriBindingSource, "IdDana");
                dateTimePicker1.DataBindings.Add("Value", iesiriBindingSource, "DataIesire");
                txtID.DataBindings.Add("Text", iesiriBindingSource, "IdIesire");
            }
            else
            {
                cmbNave.DataBindings.Clear();
                txtDane.DataBindings.Clear();
                dateTimePicker1.DataBindings.Clear();
                txtID.DataBindings.Clear();
            }
        }

        private void protectiePanel(bool v)
        {
           // cmbNave.ReadOnly = v;
            txtDane.ReadOnly = v;
            dateTimePicker1.Enabled = !v;
            cmbNave.Enabled = !v;
            cmbOpOut.Enabled = !v;



        }

        private void golireTb()
        {
            cmbNave.Text = "";
            txtDane.Text = "";
            dateTimePicker1.Text = "";
            txtID.Text = "";

        }

        private bool campuriObligatorii()
        {
            if (cmbNave.Text == "")
            {
                MessageBox.Show("Completati nava!");
                cmbNave.Focus();
                return false;
            }

            if (txtDane.Text == "")
            {
                MessageBox.Show("Completati dana");
                txtDane.Focus();
                return false;
            }

        /*    if (dateTimePicker1.Value == "")
            {
                MessageBox.Show("Completati capacitatea navei! ");
                txtCapacitate.Focus();
                return false;
            }*/
            return true;
        }

        private int addInreg()
        {
            
            string listaCampuri;
            string listaValori;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();

            OleDbDataReader r;
            con.ConnectionString = iesiriTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            int numVal = 0;
            try
            {
                numVal = int.Parse(cmbNave.SelectedValue.ToString());
                Console.WriteLine(numVal);
            }
            catch (FormatException e) { MessageBox.Show("Eroare"); }

            cmd.CommandText = "SELECT SUM(Operatiune) FROM CalculSituatie WHERE IdNava = " + ((int)cmbNave.SelectedIndex + 1) + "";
            con.Open();
            r = cmd.ExecuteReader();
            if (r.Read())
            {


                if (r[0].ToString() == "0")
                {
                    MessageBox.Show("Eroare! Nava nu se afla in port!");
                    return 0;
                }
                else if (r[0].ToString() == "1")
                {
                    OleDbConnection conn = new OleDbConnection();
                    OleDbCommand cmdd = new OleDbCommand();
                    OleDbDataReader r1;
                    conn.ConnectionString = iesiriTableAdapter.Connection.ConnectionString;
                    cmdd.Connection = conn;

                    cmdd.CommandText = "SELECT Data FROM CalculSituatie WHERE IdNava=" + ((int)cmbNave.SelectedIndex + 1) + "";
                    conn.Open();
                    r1 = cmdd.ExecuteReader();
                    if(r1.Read())
                    {
                        if (dateTimePicker1.Value.Date < DateTime.Parse(r1[0].ToString()))
                        {
                            MessageBox.Show("Eroare! Data trebuie sa fie mai mare decat cea de intrare. Data intrarii: "+r1[0].ToString());
                        }
                        else
                        {
                            OleDbConnection con1 = new OleDbConnection();
                            OleDbCommand cmd1 = new OleDbCommand();
                            con1.ConnectionString = iesiriTableAdapter.Connection.ConnectionString;
                            cmd1.Connection = con1;

                            listaCampuri = "IdNava, IdDana, DataIesire, IdOpOut";
                            listaValori = "'" + ((int)cmbNave.SelectedIndex + 1) + "'" +
                            ",'" + txtDane.Text + "','" + dateTimePicker1.Value + "','" + ((int)cmbOpOut.SelectedIndex + 1) + "'";
                            cmd1.CommandText = "Insert into Iesiri(" + listaCampuri + ") " +
                            "Select " + listaValori;
                            MessageBox.Show("Nava iese din port!");
                            con1.Open();
                            cmd1.ExecuteNonQuery();
                            con1.Close();
                            return 1;
                        }

                    }

                }

                else if (r[0].ToString() == "")
                {
                    MessageBox.Show("Nava nu are intrari in acest port!");
                }
            }
            con.Close();
            return 0;
        }

        private void refreshGrid(int n)
        {
            iesiriTableAdapter.Fill(dataSet1.Iesiri);
            iesiriBindingSource.Position = n;
        }

        private void cmbNave_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Ceva nu a mers bine!");
        }

        private void txtDane_TextChanged(object sender, EventArgs e)
        {
            string text = txtDane.Text;
            if (text.Trim() == "") return;
            for (int i = 0; i < text.Length; i++)
            {
                if (!char.IsNumber(text[i]))
                {
                    MessageBox.Show("Format eronat, folositi doar cifre!");
                    txtDane.Text = "";
                    return;
                }

            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ReportIesiri f = new ReportIesiri();
            f.ShowDialog();
        }
    }
}
