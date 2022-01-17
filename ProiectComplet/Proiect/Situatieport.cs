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
    public partial class Situatieport : Form
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbConnection con1 = new OleDbConnection();
        private OleDbCommand cmd1 = new OleDbCommand();
        private OleDbDataReader r;

        public Situatieport()
        {
            InitializeComponent();
        }

        private void Situatieport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.LocuriDane' table. You can move, or remove it, as needed.
            this.locuriDaneTableAdapter.Fill(this.dataSet1.LocuriDane);
            this.daneTableAdapter.Fill(this.dataSet1.Dane);
            // TODO: This line of code loads data into the 'dataSet1.CalculSituatie' table. You can move, or remove it, as needed.
            this.calculSituatieTableAdapter.Fill(this.dataSet1.CalculSituatie);
            con.ConnectionString = calculSituatieTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "Delete * from CalculSituatie";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "Delete * from CalculSituatie";
            cmd.ExecuteNonQuery();

            con.Close();

            con.Open();
            //Situatie Initiala
            cmd.CommandText = "Insert into CalculSituatie(IdOperatie, IdDana, IdNava, Data, Operatiune, DOp) " +
            "Select 1,IdDana,IdNava,Data,1, 'Situatie initiala' " +
            "From SituatieInitiala";
            try { cmd.ExecuteNonQuery(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            con.Close();
            //Incarc dataTable-ul CalculSituatie
            calculSituatieTableAdapter.Fill(this.dataSet1.CalculSituatie);

            con.Open();
            cmd.CommandText = "Insert into CalculSituatie(IdOperatie, IdDana, IdNava, Data, Operatiune,DOp) " +
            "Select 2,IdDana,IdNava,DataIntrare AS Data,1,oi.DOpIn FROM OperatorIntrare oi INNER JOIN Intrari i ON oi.IdOpIn = i.IdOpIn";
            try { cmd.ExecuteNonQuery(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            con.Close();
            //Incarc dataTable-ul CalculSituatie
            calculSituatieTableAdapter.Fill(this.dataSet1.CalculSituatie);


            con.Open();
            cmd.CommandText = "Insert into CalculSituatie(IdOperatie, IdDana, IdNava, Data, Operatiune, DOp ) " +
            "Select 3,i.IdDana,i.IdNava,i.DataIesire AS Data,-1,oi.DOpOut FROM OperatorIesire oi INNER JOIN Iesiri i ON oi.IdOpOut = i.IdOpOut";
            try { cmd.ExecuteNonQuery(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            con.Close();
            //Incarc dataTable-ul CalculSituatie
            calculSituatieTableAdapter.Fill(this.dataSet1.CalculSituatie);


            con1.ConnectionString = locuriDaneTableAdapter.Connection.ConnectionString;
            cmd1.Connection = con1;


            con.Open();
            
            cmd.CommandText = "SELECT IdDana, SUM(Operatiune) FROM CalculSituatie GROUP BY IdDana";
            r = cmd.ExecuteReader();
            while (r.Read())
            {

                int nr = (int)r[0];
                String val = r[1].ToString();
                int valoare = int.Parse(val);
                con1.Open();
                cmd1.CommandText = "UPDATE LocuriDane SET LocuriOcupate=0+" + val + " WHERE IdDana=" + nr;
                cmd1.ExecuteNonQuery();
                con1.Close();
            }
            r.Close();
            con.Close();
            daneTableAdapter.Fill(this.dataSet1.Dane);


            //Stoc final
            con.Open();
            cmd.CommandText = "INSERT INTO CalculSituatie ( IdOperatie, IdDana, IdNava, Data, Operatiune, DOp) " +
            "SELECT 4, IdDana, 14, now(),LocuriOcupate, 'Situatie Finala'" +
            "FROM LocuriDane WHERE LocuriOcupate>0";
            cmd.ExecuteNonQuery();
            con.Close();
            //Incarc dataTable-ul CalculStoc si Stoc
            dataSet1.CalculSituatie.Clear();
            calculSituatieTableAdapter.Fill(this.dataSet1.CalculSituatie);

        }

        private void filtrare()
        {

            try { calculSituatieBindingSource.Filter = "IdDana=" + txtIdDana.Text; }
            catch { }

        }

        private void locuriDaneBindingSource_PositionChanged(object sender, EventArgs e)
        {
            filtrare();
        }
    }
}
