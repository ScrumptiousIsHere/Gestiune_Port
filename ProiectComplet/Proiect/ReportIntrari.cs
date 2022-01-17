using Microsoft.Reporting.WinForms;
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
    public partial class ReportIntrari : Form
    {
        public ReportIntrari()
        {
            InitializeComponent();
        }

        private void ReportIntrari_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.Intrari1' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'DataSet1.Intrari1' table. You can move, or remove it, as needed.


            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            DateTime d1 = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month,
            dateTimePicker1.Value.Day);
            DateTime d2 = new DateTime(dateTimePicker2.Value.Year, dateTimePicker2.Value.Month, dateTimePicker2.Value.Day);
            this.Intrari1TableAdapter.Fill(this.DataSet1.Intrari1, d1, d2);

            ReportParameter[] parameters = new ReportParameter[1];
            parameters[0] = new ReportParameter("TITLU", "Intrarile in port din perioada " + d1.ToShortDateString() +
                                                                     " - " + d2.ToShortDateString());

            //Comunicare parametrii
            this.reportViewer1.LocalReport.SetParameters(parameters);

            //Emit raport
            this.reportViewer1.RefreshReport();
        }
    }
}
