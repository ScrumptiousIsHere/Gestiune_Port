﻿using System;
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
    public partial class OperatoriIesire : Form
    {
        public OperatoriIesire()
        {
            InitializeComponent();
        }

        private void OperatoriIesire_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.OperatorIesire' table. You can move, or remove it, as needed.
            this.operatorIesireTableAdapter.Fill(this.dataSet1.OperatorIesire);
            A1();
        }

        private void A1()
        {
            operatorIesireTableAdapter.Fill(dataSet1.OperatorIesire);
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            txtIdOperator.ReadOnly = true;
            A3();
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

        private void A2()
        {
            configureazaButoane(false);
            legareControale(false);
            protectiePanel(false);
            txtIdOperator.ReadOnly = true;
            lblOp.Text = "ADAUGARE";
            txtDOperator.Focus();
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
                txtDOperator.Focus();
                refreshGrid(operatorIesireBindingSource.Position);
            }
            else if (lblOp.Text == "MODIFICARE")
            {
                if (!validareCampuriObligatorii()) return;
                modificaInregistrare();
                refreshGrid(operatorIesireBindingSource.Position);
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
            con.ConnectionString = operatorIesireTableAdapter.Connection.ConnectionString;
            cmdadaugare.Connection = con;
            cmdmodificare.Connection = con;
            if (lblOp.Text == "ADAUGARE")
            {
                cmdadaugare.CommandText = "Select IdOpOut From OperatorIesire where DOpOut='" + txtDOperator.Text + "'";
                con.Open();
                r = cmdadaugare.ExecuteReader();
                if (r.Read())
                {
                    MessageBox.Show("Operatia este deja existenta !");
                    txtDOperator.Focus();
                }
                con.Close();
            }

        }


        private void A7()
        {
            configureazaButoane(false);
            legareControale(false);
            protectiePanel(false);
            txtIdOperator.ReadOnly = true;
            lblOp.Text = "MODIFICARE";
            txtIdOperator.Focus();
        }

        private void A8()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader r;
            con.ConnectionString = operatorIesireTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            cmd.CommandText = "Select IdOpOut From Iesiri where IdOpOut=" + txtIdOperator.Text; con.Open();
            r = cmd.ExecuteReader();
            if (r.Read())
            {
                MessageBox.Show("Operatorul este referit in tabela Iesiri nu se poate sterge!");
                con.Close();
                return;
            }
            con.Close();
            con.ConnectionString = operatorIesireTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            cmd.CommandText = "Delete From OperatorIesire Where IdOpOut = " + txtIdOperator.Text;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            refreshGrid(operatorIesireBindingSource.Position);
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
                txtIdOperator.DataBindings.Clear();
                txtIdOperator.DataBindings.Add("Text", operatorIesireBindingSource, "IdOpOut");
                txtDOperator.DataBindings.Clear();
                txtDOperator.DataBindings.Add("Text", operatorIesireBindingSource, "DOpOut");
            }
            else
            {
                txtDOperator.DataBindings.Clear();
                txtIdOperator.DataBindings.Clear();
            }
        }


        private void protectiePanel(bool v)
        {
            txtDOperator.ReadOnly = v;
        }


        private void golireCampuri()
        {
            txtDOperator.Text = "";
        }


        private bool validareCampuriObligatorii()
        {
            //Validare de completare obligatorie campurile: Nume, CNP, Salariu, Localitate
            if (txtDOperator.Text == "")
            {
                MessageBox.Show("Completati denumirea operatorului !");
                txtDOperator.Focus();
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
            con.ConnectionString = operatorIesireTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            listaCampuri = "DOpOut";
            listaValori = "'" + txtDOperator.Text + "'";
            cmd.CommandText = "Insert into OperatorIesire(" + listaCampuri + ") " +
            "Select " + listaValori;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void refreshGrid(int p)
        {
            operatorIesireTableAdapter.Fill(dataSet1.OperatorIesire);
            operatorIesireBindingSource.Position = p;
        }


        private void modificaInregistrare()
        {
            string listaSet;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            con.ConnectionString = operatorIesireTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            cmd.CommandText = "Update OperatorIesire Set DOpOut = '" + txtDOperator.Text + "' Where IdOpOut = " + txtIdOperator.Text;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}